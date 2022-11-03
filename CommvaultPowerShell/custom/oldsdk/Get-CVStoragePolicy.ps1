Add-AEnums
function Get-CVStoragePolicy {
    <#
    .SYNOPSIS
        Method to retrieve storage policies from the CommServe.
    .DESCRIPTION
        Method to retrieve storage policies from the CommServe. Output can be filtered by media agent and policy Name.
        Note: detail information is
    .PARAMETER Name
        Specify storage policy instances to be output by Name.
    .PARAMETER MediaAgentName
        Specify storage policy instances to be output by MediaAgentName.
    .PARAMETER MediaAgentObject
        Specify storage policy instances to be output pipeline input of MediaAgentObject.
    .PARAMETER AllProperties
        Output AllProperties for each schedule policy.
    .EXAMPLE
        Get-CVStoragePolicy
        
    .EXAMPLE
        Get-CVStoragePolicy -AllProperties | Select-Object -ExpandProperty copy
    .EXAMPLE
        Get-CVStoragePolicy -Name ACPLAN
    .EXAMPLE
        Get-CVStoragePolicy -Name ACPLAN -MediaAgentName carbonwincs1 -AllProperties
    .EXAMPLE
        Get-CVMediaAgent | Get-CVStoragePolicy
    .EXAMPLE
        Get-CVMediaAgent | Get-CVStoragePolicy -Name ACPLAN
    .OUTPUTS
        Outputs [PSCustomObject] containing storage policy instances.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'Default')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $Name,
        
            [Parameter(Mandatory = $False, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $MediaAgentName,
        
            [Parameter(Mandatory = $False, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $MediaAgentObject,
    
            [Parameter(Mandatory = $False)]
            [Switch] $AllProperties
        )
       
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                if ($PSCmdlet.ParameterSetName -eq 'ByName' -or $PSCmdlet.ParameterSetName -eq 'ByObject') {
                    $sessionObj = Get-CVSessionDetail 'GetMediaAgentStoragePolicies'
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
    
                if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    $mediaAgentObj = Get-CVMediaAgent -Name $MediaAgentName
                    if ($null -ne $mediaAgentObj) {
                        $MediaAgentObject = $mediaAgentObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): media agent not found having name [$MediaAgentName]"
                        return
                    }
                }
    
                if ($PSCmdlet.ParameterSetName -eq 'ByName' -or $PSCmdlet.ParameterSetName -eq 'ByObject') {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{mediaAgentId}', $MediaAgentObject.Id)
                    $validate = 'storagePolicyInformationAssociatedToMA'
                }
                else {
                    $validate = 'policies'
                }
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add("headerObject", $headerObj)
                $payload.Add("body", $body)
                    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    $policiesToProcess = @()
                    if ($PSCmdlet.ParameterSetName -eq 'ByName' -or $PSCmdlet.ParameterSetName -eq 'ByObject') {
                        foreach ($policy in $response.Content.storagePolicyInformationAssociatedToMA) {
                            if (-not [String]::IsNullOrEmpty($Name)) {
                                if ($Name -eq $policy.storagePolicyAndCopy.storagePolicyName) {
                                    $policiesToProcess += $policy
                                }
                            }
                            else {
                                $policiesToProcess += $policy
                            }
                        }
                    }
                    else {
                        foreach ($policy in $response.Content.policies) {
                            if (-not [String]::IsNullOrEmpty($Name)) {
                                if ($Name -eq $policy.storagePolicyName) {
                                    $policiesToProcess += $policy
                                }
                            }
                            else {
                                $policiesToProcess += $policy
                            }
                        }
                    }
                    foreach ($policy in $policiesToProcess) {
                        if ($AllProperties) {
                            $sessionObj = Get-CVSessionDetail 'GetStoragePolicyDetail'
    
                            if ($PSCmdlet.ParameterSetName -eq 'ByName' -or $PSCmdlet.ParameterSetName -eq 'ByObject') {
                                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{storagePolicyId}', $policy.storagePolicyAndCopy.storagePolicyId)
                            }
                            else {
                                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{storagePolicyId}', $policy.storagePolicyId)
                            }
    
                            $headerObj = Get-CVRESTHeader $sessionObj
                            $payload.Clear()
                            $payload.Add("headerObject", $headerObj)
                            $payload.Add("body", $body)
                            $validate = 'storagePolicy'
                                
                            $response = Submit-CVRESTRequest $payload $validate
                
                            if ($response.IsValid) {
                                Write-Output $response.Content
                                $outputCount++
                            }
                            else {
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): details not found for policy [$($policy.storagePolicyAndCopy.storagePolicyName)]"
                            }
                        }
                        else {
                            Write-Output $policy
                            $outputCount++
                        }
                    }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByObject') {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no storage policies found for media agent [$($MediaAgentObject.Name)]"
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
    
            try {
                if ($outputCount -eq 0) {
                    if (-not [String]::IsNullOrEmpty($Name)) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): storage policy not found having name [$Name]"
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no storage policies found"
                    }
                }
            }
            catch {
                throw $_
            }
        }
    }