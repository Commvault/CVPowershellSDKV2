Add-AEnums
function Get-CVSQLDatabaseDetail { 
    <#
    .SYNOPSIS
        Method to retrieve SQL database details.
    .DESCRIPTION
        Method to retrieve SQL database details specified by database name or pipeline input of an SQL database object.
        
    .PARAMETER Name
        Get SQL database details for the database specified by Name.
    .PARAMETER DatabaseObject
        Get SQL database details for the database specified by DatabaseObject.
    .EXAMPLE
        Get-CVSQLDatabaseDetail
        
    .EXAMPLE
        Get-CVSQLDatabaseDetail -Name space_end
        
    .EXAMPLE
        Get-CVSQLDatabase -Name space_end | Get-CVSQLDatabaseDetail
    .OUTPUTS
        Outputs [PSCustomObject] containing SQL database details.
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
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $DatabaseObject
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
                    $databaseObj = Get-CVSQLDatabase -Name $Name
                    if ($null -ne $databaseObj) { 
                        $DatabaseObject = $databaseObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): database not found having name [$Name]"      
                        return
                    }
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $DatabaseObject.insId)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{databaseId}', $DatabaseObject.dbId)
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{}
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'SqlDatabase'
    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    foreach ($database in $response.Content.SqlDatabase) {
                        Write-Output $database
                    }
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): SQL database details not found"      
                }
            }
            catch
            {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }