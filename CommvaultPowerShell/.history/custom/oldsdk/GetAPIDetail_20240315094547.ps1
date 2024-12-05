$REST_HTTP_STATUS_CODES = @(200, 201, 202, 203, 204, 205, 206, 206, 207, 208);

$CVPS_ERROR_ID = @{
    202  = 'REST API response [Accepted] error: The request has been received but not yet acted upon'
    1000 = 'Empty or null user name: Please provide a user name for web service login'
    1001 = 'Empty or null secure password: Please provide secure password for web service login'
    1002 = 'Invalid CommServe session token: Please login to CommServe with Invoke-SetupLogin'
}
function GetAPIDetail ([String] $Request) {

    try {
        $restapi = @{

            #--------------- Commvault.CommCell ---------------

            'Get-CVVersionInfo' = @{
        
                Description = 'Gets CommServe version'
                Endpoint    = 'CommServ'
                Method      = 'Get'
                Body        = ''
            
            }
        
            'Get-CVAlert' = @{
        
                Description = 'Gets alert list'
                Endpoint    = 'AlertRule'
                Method      = 'Get'
                Body        = ''
            
            }
        
            'Add-CVClient' = @{
        
                Description = 'Add new client'
                Endpoint    = 'CreateTask'
                Method      = 'Post'
                Body        = ''
            
            }
    
            'Get-CVClient' = @{
        
                Description = 'Get client list from CommServe'
                Endpoint    = 'Client?hiddenClients=true'
                Method      = 'Get'
                Body        = ''
            
            }
    
            'GetClientProperties' = @{
        
                Description = 'Get client properties for given client from CommServe'
                Endpoint    = 'Client/{clientId}'
                Method      = 'Get'
                Body        = ''
            
            }
        
            'GetClientAdditionalSettings' = @{
        
                Description = 'Get additional settings for given client from CommServe'
                Endpoint    = 'Client/{clientId}/AdditionalSettings'
                Method      = 'Get'
                Body        = ''
            
            }
        
            'Set-CVClient' = @{
        
                Description = 'Set client properties on CommServe'
                Endpoint    = 'Client/{clientId}'
                Method      = 'Post'
                Body        = ''
            
            }
        
            'Add-CVClientGroup' = @{
        
                Description = 'Add new client group on CommServe'
                Endpoint    = 'ClientGroup'
                Method      = 'Post'
                Body        = ''
            
            }
        
            'Get-CVClientGroup' = @{
        
                Description = 'Get client group list from CommServe'
                Endpoint    = 'ClientGroup'
                Method      = 'Get'
                Body        = ''
            
            }
    
            'GetClientGroupProperties' = @{
        
                Description = 'Get Client group detail properties from CommServe'
                Endpoint    = 'ClientGroup/{clientGroupId}'
                Method      = 'Get'
                Body        = ''
            
            }
    
            'Set-CVClientGroup' = @{
        
                Description = 'Set client group properties on CommServe'
                Endpoint    = 'ClientGroup/{clientGroupId}'
                Method      = 'Post'
                Body        = ''
            
            }
    
            'Get-CVSubclient' = @{
        
                Description = 'Get subclient list for given clientId from CommServe'
                Endpoint    = 'Subclient?clientId={clientId}&propertyLevel=AllProperties'
                Method      = 'Get'
                Body        = ''
            
            }

            'Set-CVSubclient' = @{
                Description = 'Add new subclient'
                Endpoint    = 'Subclient'
                Method      = 'Post'
                Body        = ''
            }

            'Add-EntitytoSchedulePolicy' = @{
                Description = 'Add entity to schedule policy'
                Endpoint    = 'Task/{taskId}/Entity/Add'
                Method      = 'Post'
                Body        = ''
            }
        
            'GetSubclientProperties' = @{
        
                Description = 'Get subclient props for given subclient from CommServe'
                Endpoint    = 'Subclient/{subclientId}'
                Method      = 'Get'
                Body        = ''
            
            }

            'Get-CVId' = @{
        
                Description = 'Gets Id of a given entity'
                Endpoint    = 'GetId?clientName={clientName}'
                Method      = 'Get'
                Body        = ''
            
            }
    
            #--------------- Commvault.FileSystem ---------------

            'Search-CVClientFileSystem' = @{
        
                Description = 'Search for protected data at the backup set or subclient level'
                Endpoint    = 'v2/filesystem/{clientId}/browse'
                #Endpoint    = ''
                Method      = 'Get'
                Body        = ''
            }
            
            'Select-CVClientFileSystem' = @{
        
                Description = 'Select the file(s) matching a particular pattern from specified client file system'
                Endpoint    = 'v2/filesystem/client/{clientId}/find?filepattern={filePattern}'
                Method      = 'Get'
                Body        = ''
            }
            
            'Backup-CVClientFileSystem' = @{
        
                Description = 'Submit backup request for specified client file system content'
                Endpoint    = 'v2/filesystem/{clientId}/backup'
                Method      = 'Post'
                Body        = ''
            }
            
            'Restore-CVClientFileSystem' = @{
        
                Description = 'Submit restore/recover request for specified client file system content'
                Endpoint    = 'v2/filesystem/{clientId}/recover'
                Method      = 'Post'
                Body        = ''
            }
            
            'Set-CVSubclientFileSystemContent' = @{
        
                Description = 'Sets the provided content for specified file system subclient'
                Endpoint    = 'v2/filesystem/client/{clientId}/content'
                Method      = 'Post'
                Body        = ''
            }
            
            #--------------- Commvault.JobManager ---------------

            'Get-CVJob' = @{
        
                Description = 'Get the list of all jobs in CommServe'
                Endpoint    = 'Job?completedJobLookupTime={completedJobLookupTime}&limit={limit}'
                Method      = 'Get'
                Body        = ''
            }
    
            'GetJobById' = @{
        
                Description = 'Get summary for specific job'
                Endpoint    = 'Job/{jobId}'
                Method      = 'Get'
                Body        = ''
            }
    
            'Get-CVJobDetail' = @{
        
                Description = 'Get job details for JobId'
                Endpoint    = 'JobDetails'
                Method      = 'Post'
                Body        = ''
            
            }
        
            'Stop-CVJob' = @{
        
                Description = 'Kill the specified job'
                Endpoint    = 'Job/{jobId}/action/kill'
                Method      = 'Post'
                Body        = ''
            
            }
    
            'Suspend-CVJob' = @{
        
                Description = 'Suspend the specified job'
                Endpoint    = 'Job/{jobId}/action/pause'
                Method      = 'Post'
                Body        = ''
            
            }
            
            'Restart-CVJob' = @{
        
                Description = 'Resubmit the specified job'
                Endpoint    = 'Job/{jobId}/action/resubmit'
                Method      = 'Post'
                Body        = ''
            
            }

            'Resume-CVJob' = @{
        
                Description = 'Resume the specified job'
                Endpoint    = 'Job/{jobId}/action/resume'
                Method      = 'Post'
                Body        = ''
            
            }
        
            'Backup-CVDisasterRecovery' = @{
        
                Description = 'Initiates a CommServe DR backup job'
                Endpoint    = 'CommServ/DRBackup'
                Method      = 'Post'
                Body        = ''
            
            }
    
            'Send-CVLogFile' = @{
        
                Description = 'Creates a task to email job log files'
                Endpoint    = 'CreateTask'
                Method      = 'Post'
                Body        = ''
            }
    
            'Get-CVSLAReport' = @{
        
                Description = 'Gets SLA report for specific client or entire CommCell'
                Endpoint    = 'SLAReport?clientId={clientId}'
                Method      = 'Post'
                Body        = ''
            }
        
            'Update-CVMissedSLA' = @{
        
                Description = 'Initiates backup job for subclients with missed SLA'
                Endpoint    = 'SLAReport?clientId={clientId}'
                Method      = 'Post'
                Body        = ''
            }
    
            'Backup-CVSubclient' = @{
        
                Description = 'Submit subclient backup job'
                Endpoint    = 'Subclient/{subclientId}/action/backup?backupLevel={backupType}'
                Method      = 'Post'
                Body        = ''
            }

            #--------------- Commvault.Policies ---------------

            'Get-CVSchedulePolicy' = @{
        
                Description = 'Get schedule policies'
                Endpoint    = 'SchedulePolicy?subclientId={subclientId}&scheduleType={scheduleType}'
                Method      = 'Get'
                Body        = ''
            }
            
            'GetSchedulePolicyDetails' = @{
        
                Description = 'Get schedule policy details'
                Endpoint    = 'SchedulePolicy/{schedulePolicyId}'
                Method      = 'Get'
                Body        = ''
            }

            'Enable-CVSchedulePolicy' = @{
        
                Description = 'Enable schedule policy'
                Endpoint    = 'Schedules/task/Action/Enable'
                Method      = 'Post'
                Body        = ''
                ContentType = 'text/plain'
            }

            'Disable-CVSchedulePolicy' = @{
        
                Description = 'Disable schedule policy'
                Endpoint    = 'Schedules/task/Action/Disable'
                Method      = 'Post'
                Body        = ''
                ContentType = 'text/plain'
            }

            'Get-CVStoragePolicy' = @{
        
                Description = 'Get storage policies'
                Endpoint    = 'StoragePolicy'
                Method      = 'Get'
                Body        = ''
            }

            'GetStoragePolicyDetail' = @{
        
                Description = 'Get storage policy detail'
                Endpoint    = 'StoragePolicy/{storagePolicyId}'
                #Endpoint    = 'StoragePolicy/{spId}?primaryCopyOnly={primaryCopyOnly}&userId={userId}'
                Method      = 'Get'
                Body        = ''
            }

            'Get-CVBlackoutWindow' = @{
        
                Description = 'Get blackout window list'
                Endpoint    = 'OperationWindow/OpWindowList?commcellId={commcellId}&clientId={clientId}&appTypeId={appTypeId}&instanceId={instanceId}&backupsetId={backupsetId}&subclientId={subclientId}&clientgroupId={clientgroupId}&companyId={companyId}&schedulePolicyId={schedulePolicyId}'
                Method      = 'Get'
                Body        = ''
            }
            
            'GetBlackoutWindowDetail' = @{
        
                Description = 'Get blackout window detail'
                Endpoint    = 'OperationWindow/{ruleId}'
                Method      = 'Get'
                Body        = ''
            }
            
            'Set-CVBlackoutWindow' = @{
        
                Description = 'Update an existing blackwout window rule'
                Endpoint    = 'OperationWindow'
                Method      = 'Put'
                Body        = ''
            }
            
            'Add-CVBlackoutWindow' = @{
        
                Description = 'Create a new blackwout window rule'
                Endpoint    = 'OperationWindow'
                Method      = 'Post'
                Body        = ''
            }
            
            'Remove-CVBlackoutWindow' = @{
        
                Description = 'Delete an existing blackwout window rule'
                Endpoint    = 'OperationWindow/{ruleId}'
                Method      = 'Delete'
                Body        = ''
            }

            'Enable-CVBlackoutWindowIgnoreHigherLevelRules' = @{
        
                Description = 'Enable ignore higher-level blackout window rules feature'
                Endpoint    = 'OperationWindow/IgnoreHigherLevelRules/Action/Enable?&clientId={clientId}&appTypeId={appTypeId}&instanceId={instanceId}&backupsetId={backupsetId}&subclientId={subclientId}'
                Method      = 'Put'
                Body        = ''
            }
            
            'Disable-CVBlackoutWindowIgnoreHigherLevelRules' = @{
        
                Description = 'Disable ignore higher-level blackout window rules feature'
                Endpoint    = 'OperationWindow/IgnoreHigherLevelRules/Action/Disable?&clientId={clientId}&appTypeId={appTypeId}&instanceId={instanceId}&backupsetId={backupsetId}&subclientId={subclientId}'
                Method      = 'Put'
                Body        = ''
            }
            
            #--------------- Commvault.RESTSession ---------------

            'Disconnect-CVServer' = @{
        
                Description = 'Releases session authorization token'
                Endpoint    = 'Logout'
                Method      = 'Post'
                Body        = ''
            
            }
        
            #--------------- Commvault.SQLServer ---------------

            'Get-CVSQLClientDetail' = @{
        
                Description = 'Get detail information about SQL clients'
                Endpoint    = 'sql/properties?clientId={clientId}&instanceId={instanceId}'
                Method      = 'Get'
                Body        = ''
            }
    
            'Get-CVSQLClone' = @{
        
                Description = 'Get information about SQL clones'
                Endpoint    = 'sql/clones?client={clientId}&instance={instanceId}'
                Method      = 'Get'
                Body        = ''
            }
    
            'Get-CVSQLCloneDetail' = @{
        
                Description = 'Get detail information about a specific SQL clone'
                Endpoint    = 'sql/clone/{cloneId}?propertyLevel={propertyLevel}'
                Method      = 'Get'
                Body        = ''
            }
    
            'Remove-CVSQLClone' = @{
        
                Description = 'Restore SQL database'
                Endpoint    = 'v2/sql/instances/{instanceId}/clone/{cloneId}'
                Method      = 'Delete'
                Body        = ''
            }

            'Get-CVSQLDatabase' = @{
        
                Description = 'Get information about protected SQL databases'
                Endpoint    = 'sql/databases?instance={instanceId}&database={databaseId}&propertyLevel={propertyLevel}&paging={paging}&start={startPage}&max={pageSize}&sla={onlySLA}&sortBy={sortBy}&sortDir={sortDir}&toTime={toTime}&showSysDB={showSysDB}&search_term={searchTerm}&databaseName={databaseName}&instanceName={instanceName}&clientName={clientName}'
                Method      = 'Get'
                Body        = ''
            }
    
            'Get-CVSQLDatabaseDetail' = @{
        
                Description = 'Get detail information about a specific SQL database'
                Endpoint    = 'sql/instance/{instanceId}/database/{databaseId}'
                Method      = 'Get'
                Body        = ''
            }
    
            'Get-CVSQLDatabaseBackupHistory' = @{
        
                Description = 'Get backup history for a specific SQL database'
                Endpoint    = 'sql/instance/{instanceId}/database/{databaseId}/history/backup'
                Method      = 'Get'
                Body        = ''
            }
    
            'GetSQLDatabaseJobDetail' = @{
        
                Description = 'Get SQL database backup job details for a specific instance/database/job'
                Endpoint    = 'v2/sql/instances/{instanceId}/databases/{databaseId}/jobs/{jobId}'
                Method      = 'Get'
                Body        = ''
            }
    
            'Get-CVSQLInstance' = @{
        
                Description = 'Get the list of all SQL instances'
                Endpoint    = 'sql/instances?propertyLevel={propertyLevel}&paging={paging}&start={startPage}&max={pageSize}&sla={onlySLA}&sortBy={sortBy}&sortDir={sortDir}&search_term={searchTerm}&instanceName={instanceName}&clientName={clientName}'
                Method      = 'Get'
                Body        = ''
            }
    
            'Get-CVSQLInstanceDetail' = @{
        
                Description = 'Get information about a specific SQL instance'
                Endpoint    = 'sql/instance/{instanceId}?propertyLevel={propertyLevel}'
                Method      = 'Get'
                Body        = ''
            }
    
            'Get-CVSQLInstanceBackupHistory' = @{
        
                Description = 'Get backup history for a specific SQL instance'
                EndPoint    = 'sql/instance/{instanceId}/history/backup'
                Method      = 'Get'
                Body        = ''
            }
    
            'GetSQLInstanceJobDetail' = @{
        
                Description = 'Get SQL instance backup job details for a specific instance/job'
                Endpoint    = 'v2/sql/instances/{instanceId}/jobs/{jobId}'
                Method      = 'Get'
                Body        = ''
            }
    
            'Backup-CVSQLInstance' = @{
        
                Description = 'Backup SQL instance subclients'
                Endpoint    = 'v2/sql/instances/{instanceId}/backup'
                Method      = 'Post'
                Body        = ''
            }

            'Backup-CVSQLSubclient' = @{
        
                Description = 'Backup SQL instance subclients'
                Endpoint    = 'v2/sql/instances/{instanceId}/backup?subclient={subclientId}'
                Method      = 'Post'
                Body        = ''
            }
            
            'Backup-CVSQLDatabase' = @{
        
                Description = 'Backup SQL database'
                Endpoint    = 'v2/sql/instance/{instanceId}/databases/{databaseId}/backup'
                Method      = 'Post'
                Body        = ''
            }

            'Backup-CVSQLDatabaseCopyOnly' = @{

                Description = 'Backup SQL database'
                Endpoint    = 'v2/sql/instance/{instanceId}/backup'
                Method      = 'Post'
                Body        = ''
            }
    
            'Export-CVSQLDatabaseRTD' = @{
        
                Description = 'Submit restore-to-disk job for SQL database'
                Endpoint    = 'v2/sql/instances/{instanceId}/databases/{databaseId}/export'
                Method      = 'Post'
                Body        = ''
            }
            
            'Export-CVSQLDatabaseRTDByJobId' = @{
        
                Description = 'Submit restore-to-disk job for SQL database by jobId'
                Endpoint    = 'v2/sql/instances/{instanceId}/databases/{databaseId}/jobs/{jobId}/export'
                Method      = 'Post'
                Body        = ''
            }
            
            'Mount-CVSQLDatabase' = @{
        
                Description = 'Mount a SQL database'
                Endpoint    = 'v2/sql/instances/{instanceId}/databases/{databaseId}/mount'
                Method      = 'Post'
                Body        = ''
            }
    
            'Restore-CVSQLDatabase' = @{
        
                Description = 'Restore SQL database'
                Endpoint    = 'v2/sql/instances/{instanceId}/databases/{databaseId}/restore'
                Method      = 'Post'
                Body        = ''
            }

            #--------------- Commvault.StorageResources ---------------

            'Get-CVMediaAgent' = @{
        
                Description = 'Get media agent list from CommServe'
                Endpoint    = 'MediaAgent'
                Method      = 'Get'
                Body        = ''
            }

            'Get-CVSubclientMediaAgent' = @{
        
                Description = 'Get subclient media agent details'
                Endpoint    = 'Subclient/{subclientId}/MediaAgent'
                #Endpoint    = 'Subclient/{subclientId}/MediaAgent?fromTime={fromTime}&toTime={toTime}'
                Method      = 'Get'
                Body        = ''
            }

            'GetMediaAgentStoragePolicies' = @{
        
                Description = 'Get storage policy details for a specific media agent'
                Endpoint    = 'StoragePolicyListAssociatedToMediaAgent?MediaAgent={mediaAgentId}'
                Method      = 'Get'
                Body        = ''
            }
    
            'Get-CVLibrary' = @{
        
                Description = 'Get storage resource libraries on the CommServe'
                Endpoint    = 'Library'
                Method      = 'Get'
                Body        = ''
            }
    
            'GetLibraryProperties' = @{
        
                Description = 'Get detail properties for storage resource library'
                Endpoint    = 'Library/{id}'
                Method      = 'Get'
                Body        = ''
            }
    
            'New-CVLibrary' = @{
        
                Description = 'Create magnetic library'
                Endpoint    = 'Library'
                Method      = 'Post'
                Body        = ''
            }
    
            'Get-CVDiskSpace' = @{
        
                Description = 'Get the diskspace available in mountPath'
                Endpoint    = 'Library/{id}'
                Method      = 'Get'
                Body        = ''
            }
    
            #--------------- Commvault.VirtualServer ---------------

            'Add-CVVirtualMachineGroupContent' = @{
        
                Description = 'Discover virtual server subclient content in CommCell'
                Endpoint    = 'Subclient/Content/Preview'
                Method      = 'Post'
                Body        = @'
                <?xml version="1.0" encoding="UTF-8"?>
                <EVGui_PreviewInventoryReq createClientsForDiscoveredVms="{createClientsForDiscoveredVms}" previewInventoryRespType="2">
                <appId clientId="{clientId}" apptypeId="106" instanceId="{instanceId}" backupsetId="{backupsetId}" subclientId="{subclientId}"/>
                <contentEntity>
                <children allOrAnyChildren="1" name="{name}" type="{type}" path="" displayName="{displayName}" equalsOrNotEquals="1"/>
                </contentEntity>
                <filterEntity/>
                </EVGui_PreviewInventoryReq>
'@
                ContentType = 'application/xml'
            }
    
            'Add-CVVirtualMachine' = @{
        
                Description = 'Add content to specified virtual server subclient in CommCell'
                Endpoint    = 'Subclient/{subclientId}'
                Method      = 'Post'
                Body        = ''
            }
    
            'Backup-CVVirtualMachine' = @{
        
                Description = 'Starts backup job for specified virtual machine'
                Endpoint    = '/v2/vsa/vm/{vmGUID}/backup?backupLevel={backupType}'
                Method      = 'Post'
                Body        = ''
            }
    
            'Get-CVVirtualMachine' = @{
        
                Description = 'Gets virtual machines filtered by: protected, unprotected, or all'
                Endpoint    = 'VM?forUser=true&status={status}'
                Method      = 'Get'
                Body        = ''
            }
    
            'Get-CVVirtualMachineByClient' = @{
        
                Description = 'Gets virtual machines filtered by: client, protected, unprotected, or all'
                Endpoint    = 'VM?propertyLevel=AllProperties&status={status}&PseudoClientId={id}'
                Method      = 'Get'
                Body        = ''
            }
    
            'Restore-CVVirtualMachine' = @{
        
                Description = 'Starts restore job for specified virtual machine'
                Endpoint    = 'v2/vsa/vm/{vmGUID}/recover'
                Method      = 'Post'
                Body        = ''
            }
    
            'Restore-CVVirtualMachineOutofPlace' = @{
        
                Description = 'Out of place virtual machine restore'
                Endpoint    = 'v2/vsa/vm/{vmGUID}/recover'
                Method      = 'Post'
                Body        = ''
            }
    
            'Get-CVVirtualMachineLiveMount' = @{
        
                Description = 'Starts virtual machine live unmount job'
                Endpoint    = 'v2/vsa/vm/{vmGUID}/activemounts'
                Method      = 'Get'
                Body        = ''
            }

            'Mount-CVVirtualMachine' = @{
        
                Description = 'Starts virtual machine live mount job'
                Endpoint    = 'v2/vsa/vm/{vmGUID}/livemount'
                Method      = 'Post'
                Body        = ''
            }

            'Dismount-CVVirtualMachine' = @{
        
                Description = 'Starts virtual machine live unmount job'
                Endpoint    = 'v2/vsa/vm/{vmGUID}/liveunmount'
                Method      = 'Post'
                Body        = ''
            }

            'InplaceRecover-VMDetails' = @{
        
                Description = 'Returns the object for InplaceRestore'
                Endpoint    = 'VM?guid={vmGUID}'
                Method      = 'Get'
                Body        = ''
            }

            #--------------- Commvault.Workflow ---------------

            'Get-CVWorkflow' = @{
        
                Description = 'Get workflow list'
                Endpoint    = 'Workflow'
                Method      = 'Get'
                Body        = ''
            }
            
            'GetWorkflowDetail' = @{
        
                Description = 'Get workflow detail'
                Endpoint    = 'Workflow/{workflowId}'
                Method      = 'Get'
                Body        = ''
            }
 
            'Start-CVWorkflow' = @{
        
                Description = 'This operation executes a workflow'
                Endpoint    = 'Wapi/{workflowName}'
                Method      = 'Get'
                Body        = ''
            }
            
            'Remove-CVWorkflow' = @{
        
                Description = 'This operation deletes a workflow from the CommServe'
                Endpoint    = 'Workflow/{workflowId}'
                Method      = 'Delete'
                Body        = ''
            }

            'Get-CVCredentialDetail' = @{

                Description = "This operation gets the details of a credential"
                Endpoint    = "V4/Credential/{name}"
                Method      = "Get"
                Body        = ''
            }

            'Set-CVCredential' = @{

                Description = "This operation gets the details of a credential"
                Endpoint    = "V4/Credential/{name}"
                Method      = "Put"
                Body        = ''
            }

            'New-CVLdap' = @{
                Description = "This operation create a new ldap entity in the commcell"
                Endpoint    = "V4/Ldap"
                Method      = "Post"
                Body        = ''
            }

            'New-CVCloudStorage' = @{
                Description = "This operation creates a new cloud storage"
                EndPoint    = "V4/Storage/Cloud"
                Method      = "Post"
                Body        = ''
            }

            'New-CVReplicationGroup' = @{
                Description = "This operation creates a new replication group"
                EndPoint    = "V4/ReplicationGroup"
                Method      = "Post"
                Body        = ''
            }

            'Get-CVReplicationGroupDetail' = @{
                Description = "This operation gets the details of a replication group"
                EndPoint    = "V4/ReplicationGroup/{ReplicationGroupId}"
                Method      = "Get"
                Body        = ''
            }

            'Set-CVHypervisor' =@{
                Description = "This operation updates the properties of the hypervisor"
                Endpoint    = "V4/Hypervisor/{hypervisorId}"
                Method      = "Put"
                Body        = ''
            }

            'New-CVHypervisor' =@{
                Description = "This operation creates a new hypervisor"
                Endpoint    = "V4/Hypervisor"
                Method      = "Post"
                Body        = ''
            }
            'Update-CVHyperVisorCredentials' = @{
                Description = "This operation updates the credential for the hypervisor"
                Endpoint    = "V4/Hypervisor/{HypervisorId}/Credentials/"
                Method      = "Post"
                Body        = ""
            }

            'New-CVBucketforCloudStorage' = @{
                Description = "This operation creates a new bucket for the cloud storage"
                Endpoint    = "V4/Storage/Cloud/{cloudStorageId}/Bucket"
                Method      = "Post"
                Body        = ""
            }

            'Invoke-CVBrowseHypervisorInventory' = @{
                Description = "This operation creates a new bucket for the cloud storage"
                Endpoint    = "V4/Hypervisor/{hypervisorId}/{InventoryEntityName}/Browse"
                Method      = "Get"
                Body        = ""
            }

            'New-CVCredentials' = @{
                Description = "This operation creates a credential"
                Endpoint    = "V4/credential"
                Method      = "Post"
                Body        = ""
            }
        }
    }
    catch {
        throw $_
    }
    finally {
        Write-Output $restapi.$Request
    }
}