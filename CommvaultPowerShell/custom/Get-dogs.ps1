Add-AEnums

function Get-Dogs
{
    [CmdletBinding()]
    param(
        [Parameter(Mandatory = $False)]
        [CVBackupType] $BackupType = 'incremental'
    )

    Write-Host "I am a bad commandlet"
    Write-Host $BackupType
}