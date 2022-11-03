Add-AEnums
function Backup-CVSQLSubclient { 
    <#
    .SYNOPSIS
        Method to submit backup job for specific SQL subclient.
    .DESCRIPTION
        Method to submit backup job for specific SQL subclient.
        
    .PARAMETER Name
        The subclient Name.
    .PARAMETER ClientName
        The ClientName hosting the SQL instance.
    .PARAMETER SubclientObject
        The SQL SubclientObject.
    .PARAMETER BackupType
        The BackupType: full, incremental (default), differential.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Backup-CVSQLSubclient
    .EXAMPLE
        Backup-CVSQLSubclient -Name AuditDB -ClientName carbonWinCS1 -BackupType full
    .EXAMPLE
        Get-CVSubclient -Name AuditDB -ClientName carbonWinCS1 | Backup-CVSQLSubclient
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
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $SubclientObject,
    
            [Parameter(Mandatory = $False)]
            [CVSQLBackupType] $BackupType = 'Incremental',
            
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
                    $subclientObj = Get-CVSubclient -Name $Name -ClientName $ClientName
                    if ($null -ne $subclientObj) { 
                        $SubclientObject = $subclientObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having name [$Name]"      
                        return
                    }
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $SubclientObject.instanceId)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{subclientId}', $SubclientObject.subclientId)
    
                $body = @{}
                $body.Add('backupType', $BackupType)
                $body = ($body | ConvertTo-Json -Depth 10)
    
                $payload = @{}
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'taskId'
    
                if ($Force -or $PSCmdlet.ShouldProcess($SubclientObject.subclientName)) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): backup request declined for subclient [$($SubclientObject.subclientName)]"      
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