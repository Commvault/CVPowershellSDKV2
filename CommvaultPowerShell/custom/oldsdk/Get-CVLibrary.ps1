Add-AEnums
function Get-CVLibrary {
    <#
    .SYNOPSIS
        Method to retrieve storage resource library instances from the CommServe.
    .DESCRIPTION
        Method to retrieve storage resource library instances from the CommServe. Output can be filtered by both library Name and associated MediaAgentName.
    .PARAMETER Name
        Filter library instances to be output by Name.
    .PARAMETER MediaAgentName
        Filter library instances to be output by associated MediaAgentName.
    .PARAMETER AllProperties
        Output library instances with full detail.
    .EXAMPLE
        Get-CVLibrary
    .EXAMPLE
        Get-CVLibrary -AllProperties
    .EXAMPLE
        Get-CVLibrary -Name LIBRARY01
    .EXAMPLE
        Get-CVLibrary -MediaAgentName PRODDEDUPE3
    .EXAMPLE
        Get-CVLibrary -Name LIBRARY01 -MediaAgentName PRODDEDUPE3
    .EXAMPLE
        Get-CVLibrary -Name LIBRARY01 -MediaAgentName PRODDEDUPE3 -AllProperties
    .OUTPUTS
        Outputs [PSCustomObject] containing storage resource library instances.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'Default')]
        [OutputType([PSCustomObject])]
        param(
            [Alias('LibraryName')]
            [Parameter(Mandatory = $False, ParameterSetName = 'Default', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Alias('MAName')]
            [Parameter(Mandatory = $False, ParameterSetName = 'Default', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [String] $MediaAgentName,
    
            [Parameter(Mandatory = $False)]
            [Switch] $AllProperties
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
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'response'
                
                $response = Submit-CVRESTRequest $payload $validate
    
                $libDetail = @()
                $foundName = $False
                $foundMediaAgentName = $False
    
                if ($response.IsValid) {
                    if ($AllProperties -or -not [String]::IsNullOrEmpty($MediaAgentName)) {
                        foreach ($library in $response.Content.response) {
                            $libDetail += (GetLibraryProperties $library.entityInfo).libraryInfo
                        }
                        foreach ($lib in $libDetail) {
                            if (-not [String]::IsNullOrEmpty($MediaAgentName)) {
                                if (($lib.magLibSummary.associatedMediaAgents).ToLower().Trim() -match ($MediaAgentName).ToLower()) {
                                    $foundMediaAgentName = $True
                                    if (-not [String]::IsNullOrEmpty($Name)) {
                                        if (($lib.library.libraryName).ToLower().Trim() -match ($Name).ToLower()) {
                                            $foundName = $True
                                            if ($AllProperties) { Write-Output $lib } else { Write-Output $lib.library}
                                        }
                                    }
                                    else {
                                        if ($AllProperties) { Write-Output $lib } else { Write-Output $lib.library}
                                    }
                                }
                            }
                            elseif (-not [String]::IsNullOrEmpty($Name)) {
                                if (($lib.library.libraryName).ToLower().Trim() -match ($Name).ToLower()) {
                                    $foundName = $True
                                    if ($AllProperties) { Write-Output $lib } else { Write-Output $lib.library}
                                }
                            }
                            else {
                                if ($AllProperties) { Write-Output $lib } else { Write-Output $lib.library}
                            }
                        }
                    }
                    else {
                        foreach ($library in $response.Content.response) {
                            if (-not [String]::IsNullOrEmpty($Name)) {
                                if ($library.entityInfo.name -eq $Name) {
                                    $foundName = $True
                                    Write-Output $library.entityInfo
                                }
                            }
                            else {
                                Write-Output $library.entityInfo
                            }
                        }
                    }
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no libraries found"
                }
    
                if (-not [String]::IsNullOrEmpty($Name) -and -not $foundName) {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): library not found having name [$Name]"
                }
    
                if (-not [String]::IsNullOrEmpty($MediaAgentName) -and -not $foundMediaAgentName) {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): library not found having media agent [$MediaAgentName]"
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }

    function GetLibraryProperties ([System.Object] $LibraryObject) {

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
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{id}', $LibraryObject.Id)
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'libraryInfo'
    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }