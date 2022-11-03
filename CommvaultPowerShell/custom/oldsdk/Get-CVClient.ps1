Add-AEnums
function Get-CVClient {
    <#
    .SYNOPSIS
        Method to retrieve the list of clients or detailed client properties from the CommServe.
    .DESCRIPTION
        If the Name parameter is not provided, this method will output a list of clients from the CommServe.
        If the Name parameter is provided, a default subset of client properties will be output for the specified client. 
        
    .PARAMETER Name
        Get detail properties for client specified by Name.
    .PARAMETER Id
        Get detail properties for client specified by Id.
    .PARAMETER AdditionalSettings
        Retrieves additional setting properties for each client in the list.
    .PARAMETER AllProperties
        Retrieves all properties for the specified client.
    .PARAMETER Version
        Retrieves package version properties for the specified client.
    .PARAMETER TimeZone
        Retrieves timezone properties for the specified client.
    .EXAMPLE
        Get-CVClient 
    .EXAMPLE
        Get-CVClient -Name ProdTest1
    .EXAMPLE
        Get-CVClient -Name ProdTest1 -AllProperties
    .EXAMPLE
        Get-CVClient -Id 2
    .EXAMPLE
        Get-CVClient -Id 2 -AllProperties
    .EXAMPLE
        Get-CVClient -Name ProdTest1 -AllProperties | Select-Object -ExpandProperty client
        
    .EXAMPLE
        Get-CVClient -Name ProdTest1 -AllProperties | Select-Object -ExpandProperty client | Select-Object jobResulsDir
        
    .EXAMPLE
        Get-CVClient -Name ProdTest1 -Version -TimeZone 
        
    .EXAMPLE
        Get-CVClient -AdditionalSettings
        
    .EXAMPLE
        Get-CVClient -Name SNOWSQL1 -AdditionalSettings
        
    .EXAMPLE
        Get-CVClient -Name ProdTest1 | Get-CVSubclient
        
    .EXAMPLE
        Get-CVClient | Get-CVSubclient
        
    .OUTPUTS
        Outputs [PSCustomObject] containing list of CommServe clients or client properties.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Get-CVClientProps')]
        [Alias('Get-CVClientAdditionalSettings')]
        [CmdletBinding(DefaultParameterSetName = 'Default')]
        [OutputType([PSCustomObject])]
        param(
            [Alias('Client')]
            [Parameter(Mandatory = $False, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Alias('ClientId')]
            [Parameter(Mandatory = $False, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $Id,
    
            [Switch] $AdditionalSettings,
            [Switch] $Version,
            [Switch] $TimeZone,
            [Switch] $AllProperties
        )
        
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                if ($PSCmdlet.ParameterSetName -eq 'ById' -and $AllProperties.IsPresent) {
                    $sessionObj = Get-CVSessionDetail 'GetClientProperties'
                }
                else {
                    $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                }
    
                $endpointSave = $sessionObj.requestProps.endpoint
    
                if ($PSCmdlet.ParameterSetName -eq 'ByName' -or
                    $PSCmdlet.ParameterSetName -eq 'ById' ) {
                    $foundClient = $False
                }
                else {
                    $foundClient = $null
                }
            }
            catch {
                throw $_
            }
        }
        
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
    
            try {
                $sessionObj.requestProps.endpoint = $endpointSave
    
                if ($PSCmdlet.ParameterSetName -eq 'ById' -and $AllProperties.IsPresent) {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $Id)
                    $headerObj = Get-CVRESTHeader $sessionObj
                    $body = ''
                    $payload = @{ }
                    $payload.Add('headerObject', $headerObj)
                    $payload.Add('body', $body)
                    $validate = 'clientProperties'
        
                    $response = Submit-CVRESTRequest $payload $validate
        
                    if ($response.IsValid) {
                        Write-Output $response.Content.clientProperties
                    }
                }
                else {
                    $headerObj = Get-CVRESTHeader $sessionObj
                    $body = ''
                    $payload = @{ }
                    $payload.Add('headerObject', $headerObj)
                    $payload.Add('body', $body)
                    $validate = 'clientProperties'
        
                    $response = Submit-CVRESTRequest $payload $validate
        
                    $clientList = @{ }
        
                    if ($response.IsValid) {
                        foreach ($clientProp in $response.Content.clientProperties) {
                            if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                                if ($clientProp.client.clientEntity.clientName -eq $Name) {
                                    $foundClient = $True
                                }
                            }
                            elseif ($PSCmdlet.ParameterSetName -eq 'ById') {
                                if ($clientProp.client.clientEntity.clientId -eq $Id) {
                                    $foundClient = $True
                                }
                            }
    
                            if ($null -eq $foundClient -or $foundClient -eq $True) {
                                $clientSubProp = @{ }
                                $clientSubProp.Add('clientId', $clientProp.client.clientEntity.clientId)
                                $clientSubProp.Add('clientName', $clientProp.client.clientEntity.clientName)
                                $clientSubProp.Add('clienthostName', $clientProp.client.clientEntity.hostName)
                                $clientSubProp.Add('type', $clientProp.client.clientEntity._type_)
                                $clientSubProp.Add('clientIdGUID', $clientProp.client.clientEntity.clientGUID)
                                $clientSubProp.Add('cvdPort', $clientProp.client.cvdPort)
                               
                                if ($AdditionalSettings) {
                                    $clientSubProp.Add('AdditionalSettings', (GetClientAdditionalSettings -ClientId $clientProp.client.clientEntity.clientId))
                                }
            
                                $clientList.Add($clientProp.client.clientEntity.clientName, $clientSubProp)
                            }
        
                            if ($foundClient -eq $True) {
                                break
                            }
                        }
                    }
        
                    if ($clientList.Count -eq 0) {
                        if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$Name]"
                        }
                        elseif ($PSCmdlet.ParameterSetName -eq 'ById') {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having id [$Id]"
                        }
                        else {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no clients not found"
                        }
                    }
                    else {
                        foreach ($key in $clientList.Keys) {
                            $client = $clientList[$key]
                            if ($AllProperties -or $Version -or $TimeZone) {
                                $propertiesObj = GetClientProperties -ClientObject $client
                                if ($propertiesObj.IsValid) {
                                    if ($AllProperties) {
                                        Write-Output $propertiesObj.Content.clientProperties
                                    }
                                    else {
                                        if ($Version) {
                                            $client.Add('Version', $propertiesObj.Content.clientProperties[0].client.versionInfo)
                                        }
                                        if ($TimeZone) {
                                            $client.Add('TimeZone', $propertiesObj.Content.clientProperties[0].client.TimeZone)
                                        }
                                        Write-Output $client
                                    }
                                }
                            }
                            else {
                                Write-Output $client
                            }
                        }
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

    function GetClientProperties ([System.Object] $ClientObject) {

        try {
            $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientObject.clientId)
    
            $headerObj = Get-CVRESTHeader $sessionObj
            $body = ''
            $payload = @{ }
            $payload.Add('headerObject', $headerObj)
            $payload.Add('body', $body)
            $validate = 'clientProperties'
    
            $response = Submit-CVRESTRequest $payload $validate
    
            Write-Output $response
        }
        catch {
            throw $_
        }
    }
    function GetClientAdditionalSettings ([String] $ClientId) {

        try {
            $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientId)
    
            $headerObj = Get-CVRESTHeader $sessionObj
            $body = ''
            $payload = @{ }
            $payload.Add('headerObject', $headerObj)
            $payload.Add('body', $body)
            $validate = $null
    
            $response = Submit-CVRESTRequest $payload $validate
    
            if ($response.IsValid) {
                if ('regKeys' -in $response.Content.PSObject.Properties.Name) {
                        Write-Output $response.Content.regKeys
                }
                else { 
                    Write-Output $response.Content
                }
            }
        }
        catch {
            throw $_
        }
    }
    