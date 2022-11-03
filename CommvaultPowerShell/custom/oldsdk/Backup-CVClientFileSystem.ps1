Add-AEnums
function Backup-CVClientFileSystem {
    <#
    .SYNOPSIS
        Create backup task for specific or default subclient of client file system.
    .DESCRIPTION
        Create backup task for specific or default subclient of client file system.
    .PARAMETER Name
        Create a file system backup task for client specified by Name.
    .PARAMETER Id
        Create a file system backup task for client specified by Id.
        
    .PARAMETER ClientObject
        Create a file system backup task for client specified by piped ClientObject.
        
    .PARAMETER SubclientName
        Create a file system backup task for subclient specified by SubclientName.
    .PARAMETER SubclientId
        Create a file system backup task for subclient specified by SubclientId.
    .PARAMETER BackupType
        The BackupType: full, incremental (default), differential, synthFull.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Backup-CVClientFileSystem
    .EXAMPLE
        Backup-CVClientFileSystem -Name carbonwincs1 -SubclientName ExportTest
    .EXAMPLE
        Backup-CVClientFileSystem -Id 2 -SubclientId 9
        
    .EXAMPLE
        Get-CVClient | Backup-CVClientFileSystem
        
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
            [System.Object] $ClientObject,
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $SubclientName,
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [Int32] $SubclientId,
    
            [Parameter(Mandatory = $False)]
            [CVBackupType] $BackupType = 'incremental',
    
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
                    $clientObj = Get-CVClient -Name $Name
                    if ($null -ne $clientObj) { 
                        $ClientObject = $clientObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$Name]"      
                        return
                    }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $clientObj = Get-CVClient -Id $Id
                    if ($null -ne $clientObj) { 
                        $ClientObject = $clientObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having id [$Id]"      
                        return
                    }
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientObject.clientId)
                
                $subclientObj = $null
                if ($SubclientId -gt 0) {
                    $subclientObj = $ClientObject | Get-CVSubclient -Id $SubclientId
                    if ($null -eq $subclientObj) { 
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having id [$SubclientId] for client [$Name]"      
                        return
                    }
                }
                elseif (-not [String]::IsNullOrEmpty($SubclientName)) {
                    $subclientObj = $ClientObject | Get-CVSubclient -Name $SubclientName
                    if ($null -eq $subclientObj) { 
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having name [$SubclientName] for client [$Name]"      
                        return
                    }
                }
                else {
                    $globalsObj = Get-CVCommCellGlobals 
                    $SubclientName = $globalsObj.defaultSubclient 
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient name not provided...retrieving default subclient"
                    $subclientObj = $ClientObject | Get-CVSubclient -Name $SubclientName
                    if ($null -eq $subclientObj) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having name [$SubclientName]"
                        return
                    }
                }
    
                $entity = @{}
                $entity.Add('clientId', $clientObj.clientId)
                $entity.Add('clientName', $clientObj.clientName)
                $entity.Add('subclientId', $subclientObj.subclientId)
    
                $body = @{}
                $body.Add('entity', $entity)
                $body.Add('backuplevel', [Convert]::ToString($BackupType))
                $body = ($body | ConvertTo-Json -Depth 10)
    
                $payload = @{ }
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'taskId'
                
                if ($Force -or $PSCmdlet.ShouldProcess($subclientObj.subclientName)) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): file system backup request declined for [$($ClientObject.clientName)]"      
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }
    