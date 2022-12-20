Add-AEnums
function Send-CVLogFile {
    <#
    .SYNOPSIS
        Create Send Log Files task for client or specific job.
    .DESCRIPTION
        Create Send Log Files task for client or specific job.
    .PARAMETER JobId
        Create Send Log Files task for job identified by JobId.
    .PARAMETER ClientName
        Create Send Log Files task for client identified by ClientName.
        
    .PARAMETER EmailAddr
        Specify EmailAddr for notification purpose.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Send-CVLogFile
    .EXAMPLE
        Send-CVLogFile -ClientName carbonwincs1
    .EXAMPLE
        Send-CVLogFile -JobId 175 -EmailAddr admin@testlab.commvault.com
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Start-CVSendLogFiles')]
        [CmdletBinding(DefaultParameterSetName = 'ById', SupportsShouldProcess = $True, ConfirmImpact = 'High')]
        [OutputType([String])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ById')]   
            [ValidateRange(1, [Int32]::MaxValue)]
            [Int32] $JobId,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]   
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $False)]   
            [ValidateNotNullorEmpty()]
            [String] $EmailAddr,
    
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
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $job = Get-CVJobDetail -JobId $JobId
                    if ($null -eq $job) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): invalid job id [$JobId]"
                        return
                    }
                    $emailSubject = 'Logs for job ' + $JobId
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    $clientObj = Get-CVClient -Name $ClientName
                    if ($null -eq $clientObj) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$ClientName]"
                        return
                    }
                    $emailSubject = 'Logs for client ' + $ClientName
                }
    
                $prepInputs = @{ }
    
                if ($PSCmdlet.ParameterSetName -eq 'ById') { 
                    $prepInputs.Add('JobId', $JobId) 
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    $prepInputs.Add('ClientName', $ClientName)
    
                }
    
                $prepInputs.Add('emailSubject', $emailSubject) # default email to: support@commvault.com
    
                if (-not [String]::IsNullOrEmpty($EmailAddr)) {
                    $prepInputs.Add('EmailId', $EmailAddr)
                }
                
                $body = (PrepareSendLogFilesBodyJson $prepInputs).body
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'taskId'
    
                if ($Force -or $PSCmdlet.ShouldProcess('send log files?')) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): send log files request declined"      
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }

    function PrepareSendLogFilesBodyJson ($PrepInputs) {
        try {
            $createTaskReq = [ordered] @{ }
    
            #taskInfo
            $taskInfo = [ordered]@{ }
            $task = [ordered]@{ }
            $owner = $global:CVConnectionPool.user
            $task.Add("policyType", 0)
            $task.Add("taskType", 1)
            $task.Add("initiatedFrom", 1)
            $task.Add("ownerName", $owner)
            $taskFlags = [ordered] @{ }
            $taskFlags.Add("disabled", $False)
            $task.Add("taskFlags", $taskFlags) 
            $taskInfo.Add("task", $task)
    
            #subtasks
            [System.Collections.ArrayList] $subTasks_arr = @()
            $subTasks_map = [ordered]@{ }
            $subTask = [ordered]@{ }
            $subTask.Add("subTaskType", 1)
            $subTask.Add("operationType", 5010)
            $subTasks_map.Add("subTask", $subTask)
    
            #options
            $options = [ordered]@{ }
            $adminopts = [ordered]@{ }
            $selectiveDeleteOption = [ordered] @{ }
            $adminopts.Add("selectiveDeleteOption", $selectiveDeleteOption)
            $sendLogFilesOption = [ordered]@{ }
            $sendLogFilesOption.Add("actionLogsEndJobId", 0)
            $sendLogFilesOption.Add("emailSelected", $True)
            $sendLogFilesOption.Add("emailDescription", "")
            if ($PrepInputs.ContainsKey("emailSubject")) {
                $sendLogFilesOption.Add("emailSubject", $PrepInputs['emailSubject'])
            }
            if ($PrepInputs.ContainsKey("JobId")) {
                $iJobId = [int] $PrepInputs.JobId
                $sendLogFilesOption.Add("jobid", $iJobId)
            }
            $sendLogFilesOption.Add("galaxyLogs", $True)
            $sendLogFilesOption.Add("getLatestUpdates", $False)
            $sendLogFilesOption.Add("actionLogsStartJobId", 0)
            $sendLogFilesOption.Add("saveToLogDir", "")
            $sendLogFilesOption.Add("computersSelected", $True)
            $sendLogFilesOption.Add("csDatabase", $False)
            $sendLogFilesOption.Add("crashDump", $True)
            $sendLogFilesOption.Add("isNetworkPath", $False)
            $sendLogFilesOption.Add("saveToFolderSelected", $False)
            $sendLogFilesOption.Add("notifyMe", $True)
            $sendLogFilesOption.Add("includeJobResults", $False)
            $sendLogFilesOption.Add("doNotIncludeLogs", $True)
            $sendLogFilesOption.Add("machineInformation", $True)
            $sendLogFilesOption.Add("osLogs", $True)
            $sendLogFilesOption.Add("actionLogs", $False)
            $sendLogFilesOption.Add("includeIndex", $False)
            $sendLogFilesOption.Add("databaseLogs", $False)
            $sendLogFilesOption.Add("logFragments", $False)
            $sendLogFilesOption.Add("uploadLogsSelected", $True)
            $sendLogFilesOption.Add("useDefaultUploadOption", $True)
    
            $impersonateUser = [ordered]@{ }
            $impersonateUser.Add("useImpersonation", $False)
            $sendLogFilesOption.Add("impersonateUser", $impersonateUser)
    
            [System.Collections.ArrayList] $emailids_arr = @()
            
            $null = $emailids_arr.Add('support@commvault.com') # default email id to Commvault support
            if ($PrepInputs.ContainsKey("EmailId")) {
                $null = $emailids_arr.Add($PrepInputs['EmailId'])
            }
            $sendLogFilesOption.Add("emailids", $emailids_arr)
            
            if ($PrepInputs.ContainsKey("JobId")) {
                [System.Collections.ArrayList] $multiJobIds_arr = @()
                $iJobId = [int] $PrepInputs.JobId
                $null = $multiJobIds_arr.Add($iJobId)     
                $sendLogFilesOption.Add("multiJobIds", $multiJobIds_arr)
            }
            else {
                [System.Collections.ArrayList] $clients_arr = @()
                if ($PrepInputs.ContainsKey("ClientName")) {
                    $clientMap = [ordered] @{ }
                    $clientProp = Get-CVClient -Client $PrepInputs['ClientName']
    
                    $clientMap.Add("hostName", $clientProp.clienthostName)
                    $clientMap.Add("clientId", $clientProp.clientId)
                    $clientMap.Add("clientName", $clientProp.clientName)
                    $clientMap.Add("displayName", $clientProp.clientName)
                    $clientMap.Add("clientGUID", $clientProp.clientIdGUID)
                }
                $null = $clients_arr.Add($clientMap)
                $sendLogFilesOption.Add("clients", $clients_arr)
            }
    
            $adminopts.Add("sendLogFilesOption", $sendLogFilesOption)
            $options.Add("adminOpts", $adminopts)
    
            $subTasks_map.Add("options", $options)
            $null = $subTasks_arr.Add($subTasks_map)
            
            $taskInfo.Add("subTasks", $subTasks_arr)
    
            $createTaskReq.Add("taskInfo", $taskInfo)
            $body = $createTaskReq | ConvertTo-Json -Depth 10
            Write-Output @{ 'body' = $body }
        }
        catch {
            throw $_
        }
    }