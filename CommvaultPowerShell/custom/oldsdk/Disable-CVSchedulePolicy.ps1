function Disable-CVSchedulePolicy {
    <#
    .SYNOPSIS
        Method to disable a schedule policy on the CommServe.
    .DESCRIPTION
        Method to disable a schedule policy on the CommServe.
    .PARAMETER Name
        Specify the schedule policy to be disabled by Name.
    .PARAMETER Id
        Specify the schedule policy to be disabled by Id (taskId).
    .PARAMETER ClientName
        Specify the ClientName associated with SubclientName.
    .PARAMETER SubclientName
        Specify the SubclientName.
    .PARAMETER PolicyObject
        Specify the schedule policy to be disabled by piping the PolicyObject.
    .EXAMPLE
        Disable-CVSchedulePolicy (This will prompt for Name)
        
    .EXAMPLE
        Disable-CVSchedulePolicy -Name AuditDB-SchedulePolicy
    .EXAMPLE
        Disable-CVSchedulePolicy -Id 229
    .EXAMPLE
        Disable-CVSchedulePolicy -ClientName carbonWinCS1 -SubclientName AuditDB (Disables all schedule policies associated with the subclient AuditDB)
    .EXAMPLE
        Get-CVSchedulePolicy | Disable-CVSchedulePolicy (Disables all schedule policies on the CommServe)
    .OUTPUTS
        Outputs [PSCustomObject] containing task submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByPolicyName')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ByPolicyName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByPolicyId')]
            [ValidateNotNullorEmpty()]
            [Int32] $Id,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByPolicyObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $PolicyObject,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'BySubclient')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'BySubclient')]
            [ValidateNotNullorEmpty()]
            [String] $SubclientName
        )
        
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                $endpointSave = $sessionObj.requestProps.endpoint
            }
            catch {
                throw $_
            }
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
        
            try {
                $policiesToProcess = @()
    
                if ($PSCmdlet.ParameterSetName -eq 'ByPolicyName') {
                    $policyObj = Get-CVSchedulePolicy -Name $Name
                    if ($null -ne $policyObj) {
                        $policiesToProcess += $policyObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): policy not found having name [$Name]"
                        return
                    }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByPolicyId') {
                    $policyObj = Get-CVSchedulePolicy -Id $Id
                    if ($null -ne $policyObj) {
                        $policiesToProcess += $policyObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): policy not found having id [$Id]"
                        return
                    }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'BySubclient') {
                    $policyObjs = Get-CVSchedulePolicy -ClientName $ClientName -SubclientName $SubclientName
                    foreach ($policyObj in $policyObjs) {
                        $policiesToProcess += $policyObj
                    }
                }
                else { #ByPolicyObject
                    $policiesToProcess += $PolicyObject
                }
    
                foreach ($policy in $policiesToProcess) {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): ...disabling policy [$($policy.task.taskName)] taskId [$($policy.task.taskId)]"
                    $sessionObj.requestProps.endpoint = $endpointSave
    
                    $body = 'TaskId='
                    $body += $policy.task.taskId
    
                    $headerObj = Get-CVRESTHeader $sessionObj
                    $payload = @{ }
                    $payload.Add("headerObject", $headerObj)
                    $payload.Add("body", $body)
                    $validate = '<TMMsg_GenericResp errorCode="0"/>'
                        
                    $response = Submit-CVRESTRequest $payload $validate
        
                    if ($response.IsValid) {
                        Write-Output $response.Content
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): policy [$($policy.task.taskName)] taskId [$($policy.task.taskId)] was not disabled"
                    }
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }
         