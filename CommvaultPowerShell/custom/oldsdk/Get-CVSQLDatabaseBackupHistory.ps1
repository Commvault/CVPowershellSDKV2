Add-AEnums
function Get-CVSQLDatabaseBackupHistory { 
    <#
    .SYNOPSIS
        Method to retrieve SQL database backup history information.
    .DESCRIPTION
        Method to retrieve SQL database backup history information.
        
    .PARAMETER Name
        The database Name.
    .PARAMETER DatabaseObject
        The SQL DatabaseObject.
    .PARAMETER JobDetail
        Include full job details.
    .EXAMPLE
        Get-CVSQLDatabaseBackupHistory
    .EXAMPLE
        Get-CVSQLDatabaseBackupHistory -Name AuditDB
    .EXAMPLE
        Get-CVSQLDatabaseBackupHistory -Name AuditDB -JobDetail
    .EXAMPLE
        Get-CVSQLDatabaseBackupHistory -Name AuditDB -JobDetail | Select-Object -ExpandProperty JobDetail
    .OUTPUTS
        Outputs [PSCustomObject] containing backup history information.
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
            [System.Object] $DatabaseObject,
    
            [Switch] $JobDetail
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
                $validate = 'dbBackups'
    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    foreach ($backup in $response.Content.dbBackups) {
                        $backupTime = $backup |`
                        Select-Object  @{Name='BackupTime';Expression={[timezone]::CurrentTimeZone.ToLocalTime(([datetime]'1/1/1970').AddSeconds($_.bkpDate))}}|`
                        Select-Object -ExpandProperty BackupTime
                        [PSCustomObject] $custom = New-Object PSObject
                        $custom | Add-Member -NotePropertyName 'Client' -NotePropertyValue $DatabaseObject.cName
                        $custom | Add-Member -NotePropertyName 'Instance' -NotePropertyValue $DatabaseObject.insName
                        $custom | Add-Member -NotePropertyName 'Database' -NotePropertyValue $DatabaseObject.dbName
                        $custom | Add-Member -NotePropertyName 'JobId' -NotePropertyValue $backup.jobId
    
                        if ($JobDetail) {
                            $sessionObj = Get-CVSessionDetail 'GetSQLDatabaseJobDetail'
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $backup.insId)
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{databaseId}', $backup.dbId)
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{jobId}', $backup.jobId)
    
                            $headerObj = Get-CVRESTHeader $sessionObj
                            $body = ''
                            $payload = @{}
                            $payload.Add('headerObject', $headerObj)
                            $payload.Add('body', $body)
                
                            $response2 = Submit-CVRESTRequest $payload $validate
    
                            if ($response2.IsValid) {
                                $custom | Add-Member -NotePropertyName 'JobDetail' -NotePropertyValue $response2.Content.dbBackups
                            }
                            else {
                                $custom | Add-Member -NotePropertyName 'JobDetail' -NotePropertyValue $null
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): job details for database [$Name] are not available"      
                            }
                        }
                        else {
                            $custom | Add-Member -NotePropertyName 'JobDetail' -NotePropertyValue $null
                        }
    
                        $custom | Add-Member -NotePropertyName 'BackupSize' -NotePropertyValue $backup.bkpSize
                        $custom | Add-Member -NotePropertyName 'BackupTime' -NotePropertyValue $backupTime
    
                        Write-Output $custom
                    }
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): backup history for database [$Name] is not available"      
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