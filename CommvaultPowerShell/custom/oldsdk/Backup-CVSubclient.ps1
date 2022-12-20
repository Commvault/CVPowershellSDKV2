Add-AEnums
function Backup-CVSubclient {
    <#
    .SYNOPSIS
        Create backup task for specific subclient.
    .DESCRIPTION
        Create backup task for specific subclient.
    .PARAMETER Name
        Create backup task for subclient identified by Name.
    .PARAMETER ClientName
        Provide ClientName for subclient lookup.
        
    .PARAMETER Id
        Create backup task for subclient identified by Id.
        
    .PARAMETER SubclientObject
        Create backup task for subclient identified by SubclientObject.
    .PARAMETER BackupType
        The BackupType: full, incremental (default), differential, synthFull.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Backup-CVSubclient
    .EXAMPLE
        Backup-CVSubclient -Name AuditDB -ClientName carbonwincs1
    .EXAMPLE
        Backup-CVSubclient -Id 7
        
    .EXAMPLE
        Backup-CVSubclient -Id 7 -BackupType Full
        
    .EXAMPLE
        Get-CVSubclient -ClientName carbonwincs1 | Backup-CVSubclient (initiates backup of all subclients of ClientName)
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Protect-CVSubclient')]
        [CmdletBinding(DefaultParameterSetName = 'ByName', SupportsShouldProcess = $True, ConfirmImpact = 'Low')]
        [OutputType([String])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [Parameter(Mandatory = $True, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Alias('SubclientId')]
            [Parameter(Mandatory = $True, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $Id,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $SubclientObject,
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [CVBackupType] $BackupType = 'Incremental',
    
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
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{backupType}', $BackupType)
    
                if ($BackupType -eq 'Synthetic_Full') {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint + '&runIncrementalBackup=True&incrementalLevel=AFTER_SYNTH'
                }
    
                if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    $subclientObj = Get-CVSubclient -Name $Name -ClientName $ClientName
                    if ($null -ne $subclientObj) { 
                        $SubclientObject = $subclientObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having name [$Name] for client [$ClientName]"      
                        return
                    }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $subclientObj = Get-CVSubclient -Id $Id -ClientName $ClientName
                    if ($null -ne $subclientObj) { 
                        $SubclientObject = $subclientObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having id [$Id] for client [$ClientName]"      
                        return
                    }
                }
                
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{subclientId}', $SubclientObject.subclientId)
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
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
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }

    function PrepareSubclientBackupBodyJson ($JobObj) {
        try {
            $createTaskReq = [ordered] @{ }
            $taskInfo = [ordered] @{ }
    
            [System.Collections.ArrayList] $associations_arr = @()
            $associatMap = [ordered] @{ }
            $associatMap.Add("subclientId", $JobObj.SubclientId)
            $associatMap.Add("clientName", $JobObj.SubclientObj.clientName)
            $associatMap.Add("backupsetId", $JobObj.SubclientObj.backupsetId)
            $associatMap.Add("instanceId", $JobObj.SubclientObj.instanceId)
            $associatMap.Add("subclientGUID", $JobObj.SubclientObj.subclientGUID)
            $associatMap.Add("clientId", $JobObj.ClientId)
            $associatMap.Add("subclientName", $JobObj.SubclientName)
            $associatMap.Add("backupsetName", $JobObj.SubclientObj.backupsetName)
            $associatMap.Add("instanceName", $JobObj.SubclientObj.instanceName)
            $associatMap.Add("_type_", $JobObj.SubclientObj._type_)
            $associatMap.Add("appName", $JobObj.SubclientObj.appName)
            $flags = [ordered] @{ }
            $associatMap.Add("flags", $flags)
            $null = $associations_arr.Add($associatMap)
    
            $task = @{ }
            $task.Add("taskType", $JobObj.taskType)
    
            [System.Collections.ArrayList] $subTasks_arr = @()
            $subTasksMap = @{ }
            $subTask = @{ }
            $subTask.Add("subTaskType", $JobObj.subTaskType)
            $subTask.Add("operationType", $JobObj.operationType)
            $options = @{ }
            $backupOpts = @{ }
            $backupOpts.Add("backupLevel", $JobObj.Jobtype)
            $options.Add("backupOpts", $backupOpts)
            $subTasksMap.Add("subTask", $subTask)
            $subTasksMap.Add("options", $options)
            $null = $subTasks_arr.Add($subTasksMap)
    
            $taskInfo.Add("associations", $associations_arr)
            $taskInfo.Add("task", $task)
            $taskInfo.Add("subTasks", $subTasks_arr)
    
            $createTaskReq.Add("taskInfo", $taskInfo)
            $body = $createTaskReq | ConvertTo-Json -Depth 10
            Write-Output @{ 'body' = $body }
        }
        catch {
            throw $_
        }
    }