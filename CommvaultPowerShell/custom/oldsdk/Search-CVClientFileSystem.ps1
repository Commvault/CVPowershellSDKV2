Add-AEnums
function Search-CVClientFileSystem {
    <#
    .SYNOPSIS
        Method to create a client file system browse query.
    .DESCRIPTION
        Method to create a client file system browse query.
    .PARAMETER Name
        Create a browse query for client specified by Name.
    .PARAMETER Id
        Create a browse query for client specified by Id.
        
    .PARAMETER ClientObject
        Create a browse query for client specified by piped ClientObject.
    .PARAMETER SubclientName
        Specify SubclientName for browse query.
    .PARAMETER Path
        Specify Path for browse query.
    .PARAMETER BackupSetId
        Specify BackupSetId for browse query.
    .PARAMETER CopyPrecedence
        Specify CopyPrecedence for browse query: Primary (default), Secondary, Cloud.
    .PARAMETER JobId
        Specify JobId for browse query.
    .PARAMETER Proxy
        Specify Proxy for browse query.
    .PARAMETER MediaAgent
        Specify MediaAgent for browse query.
    .EXAMPLE
        Search-CVClientFileSystem -Name carbonwincs1
    .EXAMPLE
        Search-CVClientFileSystem -Id 2
    .EXAMPLE
        Search-CVClientFileSystem -Name carbonwincs1 -SubclientName ExportTest
        
    .EXAMPLE
        Search-CVClientFileSystem -Name carbonwincs1 -SubclientName ExportTest -Path C:\ExportTest
        
    .EXAMPLE
        Search-CVClientFileSystem -Name carbonwincs1 -SubclientName ExportTest -Path C:\ExportTest | Select-Object -ExpandProperty dataResultSet
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
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
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $SubclientName,
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $Path,
            
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $BackupSetId,
            
            [Parameter(Mandatory = $False)]
            [Int32] $CopyPrecedence,
            
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $JobId,
            
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $Proxy,
            
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $MediaAgent
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
    
                $subclientObj = $null
    
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $clientObj = Get-CVClient -Id $Id
                    if ($null -ne $clientObj) {
                        $ClientObject = $clientObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having id [$Id]"
                        return
                    }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    $clientObj = Get-CVClient -Name $Name
                    if ($null -ne $clientObj) {
                        $ClientObject = $clientObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$Name]"
                        return
                    }
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientObject.clientId)
    
                if (-not [String]::IsNullOrEmpty($SubclientName)) {
                    $subclientObj = $ClientObject | Get-CVSubclient -Name $SubclientName
                    if ($null -eq $subclientObj) { 
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having name [$SubclientName] for client [$Name]"      
                        return
                    }
                }
                else {
                    $globalsObj = Get-CVCommCellGlobals 
                    $SubclientName = $globalsObj.defaultSubclient 
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient name not provided...retrieving default subclient"
                    $subclientObj = $ClientObject | Get-CVSubclient -Name $SubclientName
                    if ($null -eq $subclientObj) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having name [$SubclientName]"
                        return
                    }
                }
    
                $params = $False
    
                if ($null -ne $subclientObj) { 
                    if (-not $params) { 
                        $sessionObj.requestProps.endpoint += '?subclientid={subclientId}' 
                        $params = $True 
                    }
                    else { $sessionObj.requestProps.endpoint += '&subclientid={subclientId}' }                
                }
    
                if (-not [String]::IsNullOrEmpty($Path)) { 
                    if (-not $params) { 
                        $sessionObj.requestProps.endpoint += '?path={path}' 
                        $params = $True 
                    }
                    else { $sessionObj.requestProps.endpoint += '&path={path}' }                
                }
                
                if (-not [String]::IsNullOrEmpty($BackupSetId)) { 
                    if (-not $params) { 
                        $sessionObj.requestProps.endpoint += '?backupsetid={backupsetId}' 
                        $params = $True 
                    }
                    else { $sessionObj.requestProps.endpoint += '&backupsetid={backupsetId}' }                
                }
                
                if (-not $params) { 
                    $sessionObj.requestProps.endpoint += '?copyPrecedence={copyPrecedence}' 
                    $params = $True 
                }
                else { $sessionObj.requestProps.endpoint += '&copyPrecedence={copyPrecedence}' }                
                
                if (-not [String]::IsNullOrEmpty($JobId)) { 
                    if (-not $params) { 
                        $sessionObj.requestProps.endpoint += '?jobid={jobId}' 
                        $params = $True 
                    }
                    else { $sessionObj.requestProps.endpoint += '&jobid={jobId}' }                
                }
                
                if (-not [String]::IsNullOrEmpty($Proxy)) { 
                    if (-not $params) { 
                        $sessionObj.requestProps.endpoint += '?proxy={proxy}' 
                        $params = $True 
                    }
                    else { $sessionObj.requestProps.endpoint += '&proxy={proxy}' }                
                }
                
                if (-not [String]::IsNullOrEmpty($MediaAgent)) { 
                    if (-not $params) { 
                        $sessionObj.requestProps.endpoint += '?ma={ma}' 
                        $params = $True 
                    }
                    else { $sessionObj.requestProps.endpoint += '&ma={ma}' }                
                }
    
                if ($null -ne $subclientObj) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{subclientId}', $subclientObj.subclientId) }
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{path}', $Path)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{backupsetId}', $BackupSetId)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{copyPrecedence}', $CopyPrecedence)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{jobId}', $JobId)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{proxy}', $Proxy)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{ma}', $MediaAgent)
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'queryId'
                
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): query was not created for client file system browse request"      
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }