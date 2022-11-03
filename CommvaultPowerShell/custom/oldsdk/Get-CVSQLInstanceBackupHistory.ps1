Add-AEnums
function Get-CVSQLInstanceBackupHistory { 
    <#
    .SYNOPSIS
        Method to retrieve backup history data for specific SQL instance.
    .DESCRIPTION
        Method to retrieve backup history data for specific SQL instance.
        
    .PARAMETER Name
        The SQL instance Name.
    .PARAMETER InstanceObject
        The SQL InstanceObject.
    .PARAMETER JobDetail
        Include full job details.
    .EXAMPLE
        Get-CVSQLInstanceBackupHistory
    .EXAMPLE
        Get-CVSQLInstanceBackupHistory -Name carbonWinCS1\commvault
    .EXAMPLE
        Get-CVSQLInstanceBackupHistory -Name CARBONWINCS1\COMMVAULT -JobDetail
    .EXAMPLE
        Get-CVSQLInstanceBackupHistory -Name CARBONWINCS1\COMMVAULT -JobDetail | Select-Object -ExpandProperty JobDetail
    .EXAMPLE
        Get-CVSQLInstance -Name carbonWinCS1\commvault | Get-CVSQLInstanceBackupHistory
    .OUTPUTS
            Outputs [PSCustomObject] containing SQL instance backup history details.
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
            [System.Object] $InstanceObject,
    
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
                    $instanceObj = Get-CVSQLInstance -Name $Name
                    if ($null -ne $instanceObj) { 
                        $InstanceObject = $instanceObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): instance not found having name [$Name]"      
                        return
                    }
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $InstanceObject.insId)
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{}
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'jobs'
    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    foreach ($job in $response.Content.jobs) {
                        $backupTime = $job |`
                        Select-Object  @{Name='BackupTime';Expression={[timezone]::CurrentTimeZone.ToLocalTime(([datetime]'1/1/1970').AddSeconds($_.endTime))}}|`
                        Select-Object -ExpandProperty BackupTime
                        [PSCustomObject] $custom = New-Object PSObject
                        $custom | Add-Member -NotePropertyName 'Client' -NotePropertyValue $InstanceObject.cName
                        $custom | Add-Member -NotePropertyName 'Instance' -NotePropertyValue $InstanceObject.insName
                        $custom | Add-Member -NotePropertyName 'JobId' -NotePropertyValue $job.jobId
                    
                        if ($JobDetail -and $job.noDBs -gt 0) {
                            $sessionObj = Get-CVSessionDetail 'GetSQLInstanceJobDetail'
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $job.insId)
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{jobId}', $job.jobId)
    
                            $headerObj = Get-CVRESTHeader $sessionObj
                            $body = ''
                            $payload = @{}
                            $payload.Add('headerObject', $headerObj)
                            $payload.Add('body', $body)
                            $validate = 'dbBackups'
                
                            $response2 = Submit-CVRESTRequest $payload $validate
    
                            if ($response2.IsValid) {
                                $custom | Add-Member -NotePropertyName 'JobDetail' -NotePropertyValue $response2.Content.dbBackups
                            }
                            else {
                                $custom | Add-Member -NotePropertyName 'JobDetail' -NotePropertyValue $null
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): job details for instance [$Name] are not available"      
                            }
                        }
                        else {
                            $custom | Add-Member -NotePropertyName 'JobDetail' -NotePropertyValue $null
                        }
        
                        $custom | Add-Member -NotePropertyName 'BackupSize' -NotePropertyValue $job.bkpSize
                        $custom | Add-Member -NotePropertyName 'BackupTime' -NotePropertyValue $backupTime
                        
                        Write-Output $custom
                    }
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): backup history for instance [$Name] is not available"      
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
    