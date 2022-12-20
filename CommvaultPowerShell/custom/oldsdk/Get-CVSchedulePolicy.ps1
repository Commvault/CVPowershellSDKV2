Add-AEnums
function Get-CVSchedulePolicy {
    <#
    .SYNOPSIS
        Method to retrieve schedule policies from the CommServe.
    .DESCRIPTION
        Method to retrieve schedule policies from the CommServe. Output can be filtered by client/subclient or by policy name or id.
    .PARAMETER Name
        Filter output by policy Name.
    .PARAMETER Id
        Filter output by policy Id.
    .PARAMETER ClientName
        Filter output by ClientName associated with SubclientName.
    .PARAMETER SubclientName
        Filter output by SubclientName.
    .PARAMETER Scheduletype
        Filter by ScheduleType: All (default), DataProtection, AuxiliaryCopy, BackupCopy, OfflineContentIndexing, DDBVerification, ContentIndexing, or Workflow.
    .EXAMPLE
        Get-CVSchedulePolicy
    .EXAMPLE
        Get-CVSchedulePolicy -ScheduleType All | Select-Object -ExpandProperty task
    .EXAMPLE
        Get-CVSchedulePolicy -ScheduleType Workflow | Select-Object -ExpandProperty task
    .EXAMPLE
        Get-CVSchedulePolicy -Name AuditDB-3
    .EXAMPLE
        Get-CVSchedulePolicy -Id 238
    .EXAMPLE
        Get-CVSchedulePolicy -SubclientName AuditDB -ClientName carbonwincs1
    .EXAMPLE
        Get-CVSchedulePolicy -ClientName carbonWinCS1 -SubclientName AuditDB | Format-List
    .EXAMPLE
        Get-CVSchedulePolicy -ClientName carbonWinCS1 -SubclientName AuditDB | Select-Object -ExpandProperty associations
    .EXAMPLE
        Get-CVSchedulePolicy -ClientName carbonWinCS1 -SubclientName AuditDB | Select-Object -ExpandProperty task
    .EXAMPLE
        Get-CVSchedulePolicy -ClientName carbonWinCS1 -SubclientName AuditDB | Select-Object -ExpandProperty appGroup
    .EXAMPLE
        Get-CVSchedulePolicy -ClientName carbonWinCS1 -SubclientName AuditDB | Select-Object -ExpandProperty subTasks
    .OUTPUTS
        Outputs [PSCustomObject] containing schedule policy instances.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'Default')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'BySubclient')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'BySubclient')]
            [ValidateNotNullorEmpty()]
            [String] $SubclientName,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $Id,
    
            [Parameter(Mandatory = $False)]
            [CVSchedulePolicyType] $ScheduleType = 'All'
        )
        
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                $processCount = 0
            }
            catch {
                throw $_
            }
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
        
            try {
                if ($PSCmdlet.ParameterSetName -eq 'BySubclient') {
                    $subclientObj = Get-CVSubclient -Name $SubclientName -ClientName $ClientName
                    if ($null -ne $subclientObj) { 
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{subclientId}', $subclientObj.subclientId)
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having name [$SubclientName]"      
                        return
                    }
                }
    
                # API currently does not properly filter on scheduleType
                #$sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{scheduleType}', $ScheduleType.value__)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{scheduleType}', $null)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{subclientId}', $null)
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add("headerObject", $headerObj)
                $payload.Add("body", $body)
                $validate = 'taskDetail'
                    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    foreach ($policy in $response.Content.taskDetail) {
                        if ($ScheduleType -ne 'All' -and ($policy.task.policyType -ne $ScheduleType.value__)) { # API does not properly filter on scheduleType
                            continue
                        }
    
                        if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                            if ($Name -ne $policy.task.taskName) { 
                                continue
                            }
                        }
                        elseif ($PSCmdlet.ParameterSetName -eq 'ById') {
                            if ($Id -ne $policy.task.taskId) { 
                                continue
                            }
                        }
        
                        $sessionObj = Get-CVSessionDetail 'GetSchedulePolicyDetails'
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{schedulePolicyId}', $policy.task.taskId)
    
                        $headerObj = Get-CVRESTHeader $sessionObj
                        $payload.Clear()
                        $payload.Add("headerObject", $headerObj)
                        $payload.Add("body", $body)
                        $validate = 'taskInfo'
                            
                        $response = Submit-CVRESTRequest $payload $validate
            
                        if ($response.IsValid) {
                            Write-Output $response.Content.taskInfo
                            $processCount++
                        }
                    }
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
    
            try {
                if ($processCount -eq 0) {
                    if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): policy not found having name [$Name]"
                    }
                    elseif ($PSCmdlet.ParameterSetName -eq 'ById') {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): policy not found having id [$Id]"
                    }
                    elseif ($PSCmdlet.ParameterSetName -eq 'BySubclient') {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no policies found for subclient [$SubclientName]"
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no policies found"
                    }
                }
            }
            catch {
                throw $_
            }
        }
    }