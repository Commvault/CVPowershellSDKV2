Add-AEnums
function Export-CVSQLDatabaseRTD { 
    <#
    .SYNOPSIS
        Method to submit restore-to-disk SQL database export job.
    .DESCRIPTION
        Method to submit restore-to-disk SQL database export job.
        
    .PARAMETER Name
        Specify the database files to be exported by database Name.
    .PARAMETER DatabaseObject
        Specify the database files to be exported by piping DatabaseObject.
    .PARAMETER JobId
        Export the SQL database files for a given JobId.
    .PARAMETER DestClientName
        Export the SQL database files to DestClientName.
    .PARAMETER DestDiskPath
        Export the SQL database files to DestDiskPath.
    .PARAMETER OverwriteExisting
        Switch to control OverwriteExisting of the database files.
    .EXAMPLE
        Export-CVSQLDatabaseRTD
    .EXAMPLE
        Export-CVSQLDatabaseRTD -Name CommServ -OverwriteExisting
    .EXAMPLE
        Export-CVSQLDatabaseRTD -Name CommServ -OverwriteExisting -JobId 111
    .EXAMPLE
        Export-CVSQLDatabaseRTD -Name CommServ -DestClientName carbonwincs1 -DestDiskPath C:\ExportTest
    .EXAMPLE
        Get-CVSQLDatabase -Name AuditDB | Export-CVSQLDatabaseRTD -OverwriteExisting -DestClientName carbonwincs1 -DestDiskPath C:\ExportTest
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByName')]
        [OutputType([String])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $DatabaseObject,
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [Int32] $JobId,
    
            [Parameter(Mandatory = $True)]
            [ValidateNotNullorEmpty()]
            [String] $DestClientName,
    
            [Parameter(Mandatory = $True)]
            [ValidateNotNullorEmpty()]
            [String] $DestDiskPath,
    
            [Switch] $OverwriteExisting
        )
    
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                if ($JobId -eq 0) { $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name }
                else { $sessionObj = Get-CVSessionDetail 'Export-CVSQLDatabaseRTDByJobId' }
                $endpointSave = $sessionObj.requestProps.endpoint
            }
            catch {
                throw $_
            }
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
    
            try {
                $sessionObj.requestProps.endpoint = $endpointSave
                [System.Object] $clientObj = $null
    
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
    
                $clientObj = Get-CVSQLClientDetail -Name $DestClientName
                if ($null -eq $clientObj) { 
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): destination client not found having name [$DestClientName]"      
                    return
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $DatabaseObject.insId)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{databaseId}', $DatabaseObject.dbId)
                if ($JobId -gt 0) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{jobId}', $JobId) }
    
                $body = @{}
                $body.Add('overwriteFiles', $OverwriteExisting.IsPresent)
    
                $destEntity = @{}
                $destEntity.Add('clientId', $clientObj.cId)
                $body.Add('destinationEntity', $destEntity)
                $body.Add('destDiskPath', $DestDiskPath)
                $body = ($body | ConvertTo-Json -Depth 10)
                
                $payload = @{}
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'taskId'
    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): database export request declined"      
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