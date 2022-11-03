Add-AEnums
function Get-CVSubclient {
    <#
    .SYNOPSIS
        Method to retrieve the list of subclients or a named subclient for a given client from the CommServe.
    .DESCRIPTION
        Method to retrieve the list of subclients or a named subclient for a given client from the CommServe.
        
    .PARAMETER ClientName
        Get list of subclient properties for ClientName.
    .PARAMETER Name
        Get properties for the subclient specified by Name.
    .PARAMETER AllProperties
        Retrieves all properties for subclients.
    .EXAMPLE
        Get-CVSubclient
    .EXAMPLE
        Get-CVSubclient -ClientName clientName
    .EXAMPLE
        Get-CVSubclient -ClientName clientName -Name subclientName
    .EXAMPLE
        Get-CVSubclient -ClientName clientName -Name subclientName -AllProperties
    .EXAMPLE
        Get-CVClient -Name clientName | Get-CVSubclient -AllProperties | Select-Object -ExpandProperty subClientProperties | Select-Object -ExpandProperty fsSubClientProp
    .OUTPUTS
        Outputs [PSCustomObject] all subclients of the specified client, or the specified single subclient.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Get-CVSubclientProps')]
        [CmdletBinding(DefaultParameterSetName = 'ByClientName')]
        [OutputType([PSCustomObject])]
        param(
            [Alias('SubclientName')]
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [Int32] $Id,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByClientName')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByClientObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $ClientObject,
    
            [Parameter(Mandatory = $False)]
            [Switch] $AllProperties
        )
    
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                $endpointSave = $sessionObj.requestProps.endpoint
                $processCount = 0
            }
            catch {
                throw $_
            }
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
    
            try {
                $sessionObj.requestProps.endpoint = $endpointSave
    
                if ($PSCmdlet.ParameterSetName -eq 'ByClientName') {
                    $clientObj = Get-CVId -ClientName $ClientName
                    if ($null -ne $clientObj) { 
                        $ClientObject = $clientObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$ClientName]"
                        return
                    }
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientObject.clientId)
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'subClientProperties'
    
                $response = Submit-CVRESTRequest $payload $validate
        
                if ($response.IsValid) {
                    foreach ($subclient in $response.Content.subClientProperties.subClientEntity) {
                        if (-not [String]::IsNullOrEmpty($Name)) {
                            if ($subclient.subclientName -eq $Name) {
                                $processCount++
                                if ($AllProperties) {
                                    Write-Output (GetSubclientProperties -SubclientObject $subclient)
                                }
                                else {
                                    Write-Output $subclient
                                }
                                break
                            }
                        }
                        elseif ($Id -gt 0) {
                            if ($subclient.subclientId -eq $Id) {
                                $processCount++
                                if ($AllProperties) {
                                    Write-Output (GetSubclientProperties -SubclientObject $subclient)
                                }
                                else {
                                    Write-Output $subclient
                                }
                                break
                            }
                        }
                        else {
                            $processCount++
                            if ($AllProperties) {
                                Write-Output (GetSubclientProperties -SubclientObject $subclient)
                            }
                            else {
                                Write-Output $subclient
                            }
                        }
                    }
                }
                
                if ($PSCmdlet.ParameterSetName -eq 'ByClientObject') {
                    if ($processCount -eq 0) {
                        if (-not [String]::IsNullOrEmpty($Name)) {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having name [$Name] for client [$($ClientObject.clientName)]"
                        }
                        elseif ($Id -gt 0) {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having id [$Id] for client [$($ClientObject.clientName)]"
                        }
                        else {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no subclients found for client [$($ClientObject.clientName)]"
                        }
                    }
                    else {
                        $processCount = 0
                    }
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
    
            try {
                if ($PSCmdlet.ParameterSetName -ne 'ByClientObject' -and $processCount -eq 0) {
                    if (-not [String]::IsNullOrEmpty($Name)) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having name [$Name]"
                    }
                    elseif ($Id -gt 0) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having id [$Id]"
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no subclients found"
                    }
                }
            }
            catch {
                throw $_
            }
        }
    }
    