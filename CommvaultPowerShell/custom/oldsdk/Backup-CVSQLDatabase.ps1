Add-AEnums
function Backup-CVSQLDatabase { 
    <#
    .SYNOPSIS
        Method to submit backup job for specific SQL database.
    .DESCRIPTION
        Method to submit backup job for specific SQL database.
        
    .PARAMETER Name
        Specify the database by Name.
    .PARAMETER Id
        Specify the database by Id.
    .PARAMETER DatabaseObject
        Specify the database by piped DatabaseObject.
    .PARAMETER BackupType
        The BackupType: full, incremental (default), differential.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Backup-CVSQLDatabase
    .EXAMPLE
        Backup-CVSQLDatabase -Name AuditDB -BackupType full
    .EXAMPLE
        Backup-CVSQLDatabase -Id 228 -BackupType full
    .EXAMPLE
        Get-CVSQLDatabase -Name AuditDB | Backup-CVSQLDatabase
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByName', SupportsShouldProcess = $True, ConfirmImpact = 'Low')]
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
            [System.Object] $DatabaseObject,
    
            [Parameter(Mandatory = $False)]
            [CVSQLBackupType] $BackupType = 'incremental',
            
            [Switch] $Force
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
    
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $databaseObj = Get-CVSQLDatabase -Id $Id
                    if ($null -ne $databaseObj) { 
                        $DatabaseObject = $databaseObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): database not found having id [$Id]"      
                        return
                    }
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $DatabaseObject.insId)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{databaseId}', $DatabaseObject.dbId)
    
                $body = @{}
                $body.Add('backupType', $BackupType)
                $body = ($body | ConvertTo-Json -Depth 10)
    
                $payload = @{}
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'taskId'
    
                if ($Force -or $PSCmdlet.ShouldProcess($DatabaseObject.dbName)) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): backup request declined for database [$($DatabaseObject.dbName)]"      
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