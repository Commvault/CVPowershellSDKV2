Add-AEnums
function Select-CVClientFileSystem {
    <#
    .SYNOPSIS
        Retrieve list of protected files in client file system by search pattern.
    .DESCRIPTION
        Retrieve list of protected files in client file system by search pattern.
    .PARAMETER Name
        Retrieve file list for client specified by Name.
    .PARAMETER Id
        Retrieve file list for client specified by Id.
        
    .PARAMETER ClientObject
        Retrieve file list for client specified by piped ClientObject.
        
    .PARAMETER FilePattern
        Provide file pattern for search e.g. '*.txt'.
        
    .EXAMPLE
        Select-CVClientFileSystem
    .EXAMPLE
        Select-CVClientFileSystem -Name carbonwincs1 -FilePattern *.txt
    .EXAMPLE
        Select-CVClientFileSystem -Id 2 -FilePattern *.txt
        
    .EXAMPLE
        Get-CVClient | Select-Object-CVClientFileSystem -FilePattern *.txt
        
    .OUTPUTS
        Outputs [PSCustomObject] containing list of files matching the pattern.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByName')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $Id,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $ClientObject,
    
            [Parameter(Mandatory = $True)]
            [ValidateNotNullorEmpty()]
            [String] $FilePattern
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
    
                if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    $clientObj = Get-CVClient -Name $Name
                    if ($null -ne $clientObj) { 
                        $ClientObject = $clientObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$Name]"      
                        return
                    }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $clientObj = Get-CVClient -Id $Id
                    if ($null -ne $clientObj) { 
                        $ClientObject = $clientObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having id [$Id]"      
                        return
                    }
                }
                
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientObject.clientId)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{filePattern}', $FilePattern)
                
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                #GRSTODO: need validate string...currently recieving (500) internal server error
                $validate = 'taskId'
                
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): file system select request declined for [$($ClientObject.clientName)]"      
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }