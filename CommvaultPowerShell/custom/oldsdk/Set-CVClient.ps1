Add-AEnums
function Set-CVClient {
    <#
    .SYNOPSIS
        Method to set client properties.
    .DESCRIPTION
        Method to set client properties.
    .PARAMETER Name
        Set properties on client specified by Name.
    .PARAMETER Id
        Set properties on client specified by Id.
    .PARAMETER Properties
        Piped-in Properties set. 
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        $clientProps = Get-CVClient -Name 'carbonwincs1' -AllProperties
        PS C:\>$clientProps.client.displayName='carbonwincs1-1'
        PS C:\>$clientProps.client.clientDescription = 'carbonwincs1-1 description modified with REST API Post request'
        PS C:\>$clientProps | Set-CVClient -Name 'carbonwincs1' -Force
    .EXAMPLE
        $clientId = (Get-CVVirtualMachine -Name INSIELVM-92-pl).client.clientId
        PS C:\>$clientProps = Get-CVClient -Id $clientId -AllProperties
        PS C:\>$clientProps.client.displayName='INSIELVM-92-pl'
        PS C:\>$clientProps.client.clientDescription = 'INSIELVM-92-pl description modified with REST API Post request'
        PS C:\>$clientProps | Set-CVClient -Id $clientId
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Set-CVClientProps')]
        [CmdletBinding(DefaultParameterSetName = 'ByName', SupportsShouldProcess = $True, ConfirmImpact = 'High')]
        [OutputType([PSCustomObject])]
        param(
            [Alias('ClientName')]
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Alias('ClientId')]
            [Parameter(Mandatory = $True, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $Id,
    
            [Alias('ClientProps')]
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
                
                if ($PSCmdlet.ParameterSetName -eq 'ById' ) {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $Id) 
                }
                else {
                    $clientObj = Get-CVClient -Name $Name
                    if ($null -eq $clientObj) { 
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$Name]"
                        return
                    }
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $clientObj.clientId) 
                }
    
                <#
                {
                    "clientProperties": {
                        "client": {
                            "clientDescription": "client-level description modified with REST API Post request"
                        }
                    },
                    "association": {
                        "entity": [
                            {
                                "clientName": "clientName"
                            }
                        ]
                    }
                }
                #>
                #$client = @{}
                #$client.Add('client', $Properties)
                #$entity = @{}
                #$entity.Add('clientName', $clientObj.clientName)
                #[System.Collections.ArrayList] $entity_arr = @()
                #$null = $entity_arr.Add($entity)
                #$association = @{ }
                #$association.Add('entity', $entity_arr)
        
                $body = @{}
                $body.Add('clientProperties', $Properties)
                #$body.Add('association', $association)
                $body = ($body | ConvertTo-Json -Depth 10)
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'response'
    
                if ($PSCmdlet.ParameterSetName -eq 'ById' ) {
                    if ($Force -or $PSCmdlet.ShouldProcess($Id)) {
                        $response = Submit-CVRESTRequest $payload $validate
                    }
                    else {
                        $response = Submit-CVRESTRequest $payload $validate -DryRun
                    }
                }
                else {
                    if ($Force -or $PSCmdlet.ShouldProcess($clientObj.clientName)) {
                        $response = Submit-CVRESTRequest $payload $validate
                    }
                    else {
                        $response = Submit-CVRESTRequest $payload $validate -DryRun
                    }
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    if ($PSCmdlet.ParameterSetName -eq 'ById' ) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): set client properties request failed for group [$Id]"
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): set client properties request failed for group [$($clientObj.clientName)]"
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