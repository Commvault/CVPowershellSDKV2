Add-AEnums
function Backup-CVSQLInstance { 
    <#
    .SYNOPSIS
        Method to submit backup job for SQL instance.
    .DESCRIPTION
        Method to submit backup job for SQL instance.
        
    .PARAMETER Name
        The SQL instance Name.
    .PARAMETER InstanceObject
        The SQL InstanceObject.
    .PARAMETER BackupType
        The BackupType: full, incremental (default), differential.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Backup-CVSQLInstance
    .EXAMPLE
        Backup-CVSQLInstance -Name CARBONWINCS1\COMMVAULT -BackupType full
    .EXAMPLE
        Get-CVSQLInstance -Name CARBONWINCS1\COMMVAULT | Backup-CVSQLInstance
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
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $InstanceObject,
    
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
    
                $body = @{}
                $body.Add('backupType', $BackupType)
                $body = ($body | ConvertTo-Json -Depth 10)
    
                $payload = @{}
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'taskId'
    
                if ($Force -or $PSCmdlet.ShouldProcess($InstanceObject.insName)) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): backup request declined for instance [$($InstanceObject.insName)]"      
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