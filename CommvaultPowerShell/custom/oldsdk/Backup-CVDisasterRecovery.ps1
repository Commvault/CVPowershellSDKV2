Add-AEnums
function Backup-CVDisasterRecovery {
    <#
    .SYNOPSIS
        Initiates the CommServe disaster recovery (DR) backup.
    .DESCRIPTION
        Initiates the CommServe disaster recovery (DR) backup.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Backup-CVDisasterRecovery
        
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Start-CVDRBackup')]
        [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = 'Low')]
        [OutputType([PSCustomObject])]
        param(
            [Switch] $Force
        )
        
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
            }
            catch {
                throw $_
            }
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
    
            try {
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = (PrepareDRBackupBodyJson).body
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'taskId'
                
                if ($Force -or $PSCmdlet.ShouldProcess('DR backup?')) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): CommServe DR backup request declined"      
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }

    function PrepareDRBackupBodyJson {

        try {
            $drObj = @{}
            $drObj.Add('isCompressionEnabled', $False)
            $drObj.Add('jobType', 1)
            $drObj.Add('backupType', 1)
            $body = $drObj | ConvertTo-Json -Depth 10
            Write-Output @{ 'body' = $body }
        }
        catch {
            throw $_
        }
    }