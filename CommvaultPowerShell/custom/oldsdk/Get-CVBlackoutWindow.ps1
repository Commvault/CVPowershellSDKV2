Add-AEnums
function Get-CVBlackoutWindow {
    <#
    .SYNOPSIS
        Method to retrieve blackout window rules from the CommServe.
    .DESCRIPTION
        Method to retrieve blackout window rules from the CommServe. 
        Output can be filtered by rule Id, Name, CommcellId, ClientId, AppTypeId, InstanceId, BackupsetId, SubclientId, ClientgroupId, CompanyId, or SchedulePolicyId.
    .PARAMETER Name
        Specify blackout window rules to be output by Name.
    .PARAMETER Id
        Specify blackout window rule to be output by Id.
    .PARAMETER CommcellId
        Specify blackout window rule subset by CommcellId (default = 2).
    .PARAMETER ClientId
        Specify blackout window rule subset by ClientId.
    .PARAMETER AppTypeId
        Specify blackout window rule subset by AppTypeId.
    .PARAMETER InstanceId
        Specify blackout window rule subset by InstanceId.
    .PARAMETER BackupsetId
        Specify blackout window rule subset by BackupsetId.
    .PARAMETER SubclientId
        Specify blackout window rule subset by SubclientId.
    .PARAMETER ClientgroupId
        Specify blackout window rule subset by ClientgroupId.
    .PARAMETER CompanyId
        Specify blackout window rule subset by CompanyId.
    .PARAMETER SchedulePolicyId
        Specify blackout window rule subset by SchedulePolicyId.
    .EXAMPLE
        Get-CVBlackoutWindow
    .EXAMPLE
        Get-CVBlackoutWindow -Name CommCell-BWR-1
        
    .EXAMPLE
        Get-CVBlackoutWindow -Id 3
    .EXAMPLE
        Get-CVBlackoutWindow -ClientgroupId 4
        
    .EXAMPLE
        Get-CVBlackoutWindow -ClientId 2
        
    .EXAMPLE
        Get-CVBlackoutWindow -AppTypeId 81
        
    .EXAMPLE
        Get-CVBlackoutWindow -InstanceId 9
        
    .OUTPUTS
        Outputs [PSCustomObject] containing blackout window rules.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByList')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $False, ParameterSetName = 'ByName', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [String] $Name,
        
            [Parameter(Mandatory = $False, ParameterSetName = 'ById', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int64] $Id,
    
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [String] $CommcellId = 2,
            
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int64] $ClientId = 0,
    
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int64] $AppTypeId = 0,
            
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int64] $InstanceId = 0,
    
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int64] $BackupsetId = 0,
            
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int64] $SubclientId = 0,
    
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int64] $ClientgroupId = 0,
            
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int64] $CompanyId = 0,
            
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int64] $SchedulePolicyId = 0
        )
        
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $sessionObj = Get-CVSessionDetail 'GetBlackoutWindowDetail'
                }
                else {
                    $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                }
                $endpointSave = $sessionObj.requestProps.endpoint
                $outputCount = 0
            }
            catch {
                throw $_
            }
        }
        
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
        
            try {
                $sessionObj.requestProps.endpoint = $endpointSave
    
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{ruleId}', $Id)
                }
                else {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{commcellId}', $CommcellId)
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientId)
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{appTypeId}', $AppTypeId)
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $InstanceId)
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{backupsetId}', $BackupsetId)
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{subclientId}', $SubclientId) 
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientgroupId}', $ClientgroupId)
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{companyId}', $CompanyId)
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{schedulePolicyId}', $SchedulePolicyId)
                }
    
                $validate = 'operationWindow'
                
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add("headerObject", $headerObj)
                $payload.Add("body", $body)
                    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    foreach ($rule in $response.Content.operationWindow) {
                        if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                            if ($Name -eq $rule.name) {
                                Write-Output $rule
                                $outputCount++
                            }
                        }
                        else { # 'ByList'
                            Write-Output $rule
                            $outputCount++
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
                if ($outputCount -eq 0) {
                    if ($PSCmdlet.ParameterSetName -eq 'ById') {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): blackout window rule not found having Id [$Id]"
                    }
                    elseif ($PSCmdlet.ParameterSetName -eq 'ByName') {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): blackout window rule not found having name [$name]"
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no blackout window rules found"
                    }
                }
            }
            catch {
                throw $_
            }
        }
    }
    