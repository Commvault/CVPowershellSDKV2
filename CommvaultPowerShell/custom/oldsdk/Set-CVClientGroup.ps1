Add-AEnums
function Set-CVClientGroup {
    <#
    .SYNOPSIS
        Method to set client group properties.
    .DESCRIPTION
        Method to set client group properties.
    .PARAMETER Name
        Set properties on client group specified by Name.
    .PARAMETER Properties
        Piped Properties set.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        1. Get current props: $props = Get-CVClientGroup -Name 'Media Agents'
        2. Modify props: $props.description = 'Selects Clients which have media agents installed' etc.
        3. Set props: $props | Set-CVClientGroup -Name 'Media Agents'
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = 'High')]
        param(
            [Alias('ClientGroupName')]
            [Parameter(Mandatory = $True)]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Alias('ClientGroupProps')]
            [Parameter(Mandatory = $True, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $Properties,
    
            [Switch] $Force
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
                $sessionObj.requestProps.endpoint = $endpointSave
                
                $clientGroupObj = Get-CVClientGroup -Name $Name
                if ($null -eq $clientGroupObj) { 
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client group not found having name [$Name]"
                    return
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientGroupId}', $clientGroupObj.Id) 
    
                <#
                {
                    "clientGroupOperationType": 2,
                    "clientGroupDetail": {
                        "description": "client computer group description modified",
                        "claQuota": 8,
                        "clientGroup": {
                            "clientGroupName": "clientGroupName"
                        }
                    }
                }
                #>
                $clientGroup = @{}
                $clientGroup.Add('clientGroupName', $clientGroupObj.name)
    
                $body = @{}
                $body.Add('clientGroupOperationType', 2)
                $body.Add('clientGroupDetail', $Properties)
                $body.Add('clientGroup', $clientGroup)
                $body = ($body | ConvertTo-Json -Depth 10)
                
                $payload = @{ }
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'errorMessage'
    
                if ($Force -or $PSCmdlet.ShouldProcess($clientGroupObj.Name)) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): set client group properties request failed for group [$($clientGroupObj.Name)]"
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }