Add-AEnums
function Backup-CVVirtualMachine {
    <#
    .SYNOPSIS
        Method to initiate backup of specified virtual machine.
    .DESCRIPTION
        Method to initiate backup of specified virtual machine.
        
    .PARAMETER Id
        Virtual machine Id: this is the virtual machine GUID.
    .PARAMETER Name
        Virtual machine Name.
    .PARAMETER ClientName
        Virtual machine associated ClientName.
    .PARAMETER ClientObject
        Virtual machine associated client specified by piped ClientObject.
    .PARAMETER Protected
        Use this switch to filter legacy, unprotected virtual machines when specifed by Name.
    .PARAMETER BackupType
        Backup Type for the backup of Virtual Machine , default is INCREMENTAL . Supported values are FULL, INCREMENTAL, DIFFERENTIAL, SYNTHETIC_FULL
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Backup-CVVirtualMachine -Id 500b0375-4728-588f-3d69-2d64b5291bcf
    .EXAMPLE
        Backup-CVVirtualMachine -Name 2208 -ClientName V1-VSAQA
    .EXAMPLE
        Backup-CVVirtualMachine -Id 500b0375-4728-588f-3d69-2d64b5291bcf -BackupType FULL
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Backup-CVVM')]
        [CmdletBinding(DefaultParameterSetName = 'ByName', SupportsShouldProcess = $True, ConfirmImpact = 'Low')]
        [OutputType([PSCustomObject])]
        param(
            [Alias('VMName')]
            [Parameter(Mandatory = $True, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [String] $Id,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $ClientObject,
    
            [Parameter(Mandatory = $False)]
            [CVBackupType] $BackupType = 'INCREMENTAL',
    
            [Switch] $Protected,
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
    
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $vmObj = (Get-CVVirtualMachine -Id $Id)
                    if ($null -eq $vmObj) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): virtual machine not found having id [$Id]"
                        return
                    }
                }
                else {
                    if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                        $clientObj = Get-CVClient -Name $ClientName
                        if ($null -ne $clientObj) {
                            $ClientObject = $clientObj
                        }
                        else {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$ClientName]"
                            return
                        }
                    }
    
                    if ($Protected) {
                        $vmObj = ($ClientObject | Get-CVVirtualMachine -Name $Name -Protected)
                    }
                    else {
                        $vmObj = ($ClientObject | Get-CVVirtualMachine -Name $Name)
                    }
                    if ($null -eq $vmObj) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): virtual machine not found having name [$Name]"
                        return
                    }
                    elseif (HasProperty $vmObj 'Length') {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): multiple virtual machine objects returned for client [$($ClientObject.clientName)] having name [$Name]"
                        return
                    }
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{vmGUID}', $vmObj.strGUID)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{backupType}', [Convert]::ToString($BackupType))
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'taskId'
                
                if ($Force -or $PSCmdlet.ShouldProcess($vmObj.name)) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): backup request declined for virtual machine [$($vmObj.name)]"
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }

    function HasProperty($Object, $PropertyName)
{
    $PropertyName -in $Object.PSobject.Properties.Name
}