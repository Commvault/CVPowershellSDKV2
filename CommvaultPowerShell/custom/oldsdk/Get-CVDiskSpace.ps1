Add-AEnums    
function Get-CVDiskSpace {
    <#
    .SYNOPSIS
        Method to retrieve the available disk space of the library.
    .DESCRIPTION
        Method to retrieve the available disk space of the library. Requires either the LibraryName or an associated MediaAgentName.
    .PARAMETER LibraryName
        Retrieve available disk space details for the library specified by LibraryName.
    .PARAMETER MediaAgentName
        Retrieve available disk space details for libraries associated with MediaAgentName.
    .PARAMETER MountPath
        Filter output for a specific MountPath.
    .EXAMPLE
        Get-CVDiskSpace
        
    .EXAMPLE
        Get-CVDiskSpace -MediaAgentName PRODDEDUPE3
        
    .EXAMPLE
        Get-CVDiskSpace -MAName PRODDEDUPE3
        
    .EXAMPLE
        Get-CVDiskSpace -LibraryName library01
        
    .EXAMPLE
        Get-CVDiskSpace -LibraryName library01 -MountPath F:\PRODTESTLIB
    .OUTPUTS
        Outputs [PSCustomObject] containing storage resource library disk usage details.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByLibraryName')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ByLibraryName', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [String] $LibraryName,
    
            [Alias('MAName')]
            [Parameter(Mandatory = $True, ParameterSetName = 'ByMediaAgentName', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [String] $MediaAgentName,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByLibraryObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $LibraryObject,
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $MountPath
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
                $endpoint = $endpointSave
                $endpoints = @()
                $mountPaths = @()
    
                if ($PSCmdlet.ParameterSetName -eq 'ByLibraryName') {
                    $libraryId = Get-CVLibrary -Name $LibraryName
                    if ($null -ne $libraryId) {
                        $endpoints += $endpoint -creplace ('{id}', $libraryId.id)
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): library not found having name [$LibraryName]"
                        return
                    }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByMediaAgentName') {
                    $libraries = Get-CVLibrary -MediaAgentName $MediaAgentName
                    if ($null -ne $libraries -and $libraries.Count -gt 0) {
                        foreach ($lib in $libraries) {
                            $endpoints += $endpoint -creplace ('{id}', $lib.libraryId)
                        }
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no libraries found for media agent [$MediaAgentName]"
                        return
                    }
                }
                else {
                    $endpoints += $endpoint -creplace ('{id}', $LibraryObject.id)
                }
    
                if (-not [String]::IsNullOrEmpty($MountPath)) { #Wrap up the string so it won't fail for escape chars
                    $MountPath = [regex]::Escape($MountPath)
                }
    
                foreach ($endpoint in $endpoints) {
                    $sessionObj.requestProps.endpoint = $endpoint
                    $headerObj = Get-CVRESTHeader $sessionObj
                    $body = ''
                    $payload = @{ }
                    $payload.Add('headerObject', $headerObj)
                    $payload.Add('body', $body)
                    $validate = 'libraryInfo'
                
                    $response = Submit-CVRESTRequest $payload $validate
                    
                    if ($response.IsValid) {
                        if (-not [String]::IsNullOrEmpty($MountPath)) {
                            foreach ($path in $response.Content.libraryInfo.MountPathList) {
                                $parsed = [regex]::Escape($path.mountPathName)
                                if ($parsed -Like "*$MountPath*") {
                                    $mountPaths += $response.Content.libraryInfo.MountPathList[0].mountPathSummary
                                }
                            }
                        }
                        else {
                            $mountPaths += $response.Content.libraryInfo.magLibSummary
                        }
                    }
                }
    
                if ($mountPaths.Count -eq 0) {
                    if (-not [String]::IsNullOrEmpty($MountPath)) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): mount path not found [$MountPath]"
                    }
                    elseif (-not [String]::IsNullOrEmpty($LibraryName)) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): mount paths not found having library [$LibraryName]"
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): mount paths not found having library [$MediaAgentName]"
                    }
                }
                else {
                    Write-Output $mountPaths
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }
        