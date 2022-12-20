---
Module Name: CommvaultPowerShell
Module Guid: 2ccdf246-027b-4942-a96e-fd3f8831492a
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell
Help Version: 1.0.0.0
Locale: en-US
---

# CommvaultPowerShell Module
## Description


## CommvaultPowerShell Cmdlets
### [Add-CVBlackoutWindow](Add-CVBlackoutWindow.md)
Method to add/create an blackout window rule.

### [Add-CVEntitytoSchedulePolicy](Add-CVEntitytoSchedulePolicy.md)
Method to add an entity to a schedule policy

### [Add-CVLaptop](Add-CVLaptop.md)
Simplified API to create a laptop

### [Add-CVMediaAgent](Add-CVMediaAgent.md)
Used to add a media agent to a disk access path

### [Add-CVVirtualMachine](Add-CVVirtualMachine.md)
Method to add virtual server subclient content.

### [Add-CVVirtualMachineGroupContent](Add-CVVirtualMachineGroupContent.md)
Method to perform a virtual machine group content preview with option to create clients from result set.

### [Backup-CVClientFileSystem](Backup-CVClientFileSystem.md)
Create backup task for specific or default subclient of client file system.

### [Backup-CVDisasterRecovery](Backup-CVDisasterRecovery.md)
Initiates the CommServe disaster recovery (DR) backup.

### [Backup-CVSQLDatabase](Backup-CVSQLDatabase.md)
Method to submit backup job for specific SQL database.

### [Backup-CVSQLInstance](Backup-CVSQLInstance.md)
Method to submit backup job for SQL instance.

### [Backup-CVSQLSubclient](Backup-CVSQLSubclient.md)
Method to submit backup job for specific SQL subclient.

### [Backup-CVSubclient](Backup-CVSubclient.md)
Create backup task for specific subclient.

### [Backup-CVVirtualMachine](Backup-CVVirtualMachine.md)
Method to initiate backup of specified virtual machine.

### [Backup-CVVMGroup](Backup-CVVMGroup.md)
To Backup the virtual machines in vmgroup

### [Disable-CVAlertDefinition](Disable-CVAlertDefinition.md)
Disable Alert Definition

### [Disable-CVAuxillaryCopyCommcell](Disable-CVAuxillaryCopyCommcell.md)
Used to disable auxillary copy property for commcell

### [Disable-CVBackupAgent](Disable-CVBackupAgent.md)
Used to disable backup property for an agent.\nTypes of available agentIds are:\n41-Active Directory,\n21-AIX File System,\n64-Big Data Apps,\n134-Cloud Apps,\n37-DB2,\n103-DB2 MultiNode,\n62-DB2 on Unix,\n128-Documentum,\n90-Domino Mailbox Archiver,\n91-DPM,\n67-Exchange Compliance Archiver,\n53-Exchange Database,\n45-Exchange Mailbox,\n54-Exchange Mailbox (Classic),\n56-Exchange Mailbox Archiver,\n82-Exchange PF Archiver,\n35-Exchange Public Folder,\n73-File Share Archiver,\n33-File System,\n74-FreeBSD,\n71-GroupWise DB,\n17-HP-UX Files System,\n65-Image Level,\n75-Image Level On Unix,\n76-Image Level ProxyHost,\n87-Image Level ProxyHost on Unix,\n3-Informix Database,\n29-Linux File System,\n89-MS SharePoint Archiver,\n104-MySQL,\n13-NAS,\n83-Netware File Archiver,\n12-Netware File System,\n10-Novell Directory Services,\n124-Object Link,\n131-Object Store,\n86-OES File System on Linux,\n22-Oracle,\n80-Oracle RAC,\n130-Other External Agent,\n125-PostgreSQL,\n38-Proxy Client File System,\n87-ProxyHost on Unix,\n61-SAP for Oracle,\n135-SAP HANA,\n78-SharePoint Server,\n20-Solaris 64bit File System,\n19-Solaris File System,\n81-SQL Server,\n5-Sybase Database,\n66-Unix File Archiver,\n36-Unix Tru64 64-bit File System,\n106-Virtual Server,\n58- Windows File Archiver

### [Disable-CVBackupCommcell](Disable-CVBackupCommcell.md)
Used to disable backup property for commcell

### [Disable-CVBackupInstance](Disable-CVBackupInstance.md)
Used to disable backup property for an instance

### [Disable-CVBackupServerGroup](Disable-CVBackupServerGroup.md)
Used to disable backup property for a server group

### [Disable-CVBackupSubclient](Disable-CVBackupSubclient.md)
Used to disable backup property for a subclient

### [Disable-CVBlackoutWindowIgnoreHigherLevelRules](Disable-CVBlackoutWindowIgnoreHigherLevelRules.md)
Method to disable 'ignore CommCell higher-level blackout window rules' by entity.

### [Disable-CVContentIndexingCommcell](Disable-CVContentIndexingCommcell.md)
Used to disable content indexing property for commcell

### [Disable-CVDataAgingCommcell](Disable-CVDataAgingCommcell.md)
Used to disable data aging property for commcell

### [Disable-CVDataAgingServerGroup](Disable-CVDataAgingServerGroup.md)
Used to disable data aging property for a server group

### [Disable-CVDataVerificationCommcell](Disable-CVDataVerificationCommcell.md)
Used to disable data verification property for commcell

### [Disable-CVDdbCommcell](Disable-CVDdbCommcell.md)
Used to disable DDB property for commcell

### [Disable-CVJobActivityCommcell](Disable-CVJobActivityCommcell.md)
Used to disable all job activity property for commcell

### [Disable-CVLogScrubbing](Disable-CVLogScrubbing.md)
Used to disable log scrubbing

### [Disable-CVRestoreAgent](Disable-CVRestoreAgent.md)
Used to disable restore property for an agent\nTypes of available agentIds are:\n41-Active Directory,\n21-AIX File System,\n64-Big Data Apps,\n134-Cloud Apps,\n37-DB2,\n103-DB2 MultiNode,\n62-DB2 on Unix,\n128-Documentum,\n90-Domino Mailbox Archiver,\n91-DPM,\n67-Exchange Compliance Archiver,\n53-Exchange Database,\n45-Exchange Mailbox,\n54-Exchange Mailbox (Classic),\n56-Exchange Mailbox Archiver,\n82-Exchange PF Archiver,\n35-Exchange Public Folder,\n73-File Share Archiver,\n33-File System,\n74-FreeBSD,\n71-GroupWise DB,\n17-HP-UX Files System,\n65-Image Level,\n75-Image Level On Unix,\n76-Image Level ProxyHost,\n87-Image Level ProxyHost on Unix,\n3-Informix Database,\n29-Linux File System,\n89-MS SharePoint Archiver,\n104-MySQL,\n13-NAS,\n83-Netware File Archiver,\n12-Netware File System,\n10-Novell Directory Services,\n124-Object Link,\n131-Object Store,\n86-OES File System on Linux,\n22-Oracle,\n80-Oracle RAC,\n130-Other External Agent,\n125-PostgreSQL,\n38-Proxy Client File System,\n87-ProxyHost on Unix,\n61-SAP for Oracle,\n135-SAP HANA,\n78-SharePoint Server,\n20-Solaris 64bit File System,\n19-Solaris File System,\n81-SQL Server,\n5-Sybase Database,\n66-Unix File Archiver,\n36-Unix Tru64 64-bit File System,\n106-Virtual Server,\n58- Windows File Archiver

### [Disable-CVRestoreCommcell](Disable-CVRestoreCommcell.md)
Used to disable restore property for commcell

### [Disable-CVRestoreInstance](Disable-CVRestoreInstance.md)
Used to disable restore property for an instance

### [Disable-CVRestoreServerGroup](Disable-CVRestoreServerGroup.md)
Used to disable restore property for a server group

### [Disable-CVSchedulePolicy](Disable-CVSchedulePolicy.md)
Method to disable a schedule policy on the CommServe.

### [Disable-CVSchedulerCommcell](Disable-CVSchedulerCommcell.md)
Used to disable scheduler property for commcell

### [Dismount-CVVirtualMachine](Dismount-CVVirtualMachine.md)
Method to initiate dismount of live mounted virtual machine.

### [Edit-CVAlertDefinition](Edit-CVAlertDefinition.md)
Edit Alert Definition details

### [Enable-CVAlertDefinition](Enable-CVAlertDefinition.md)
Enable Alert Definitions

### [Enable-CVAuxillaryCopyCommcell](Enable-CVAuxillaryCopyCommcell.md)
Used to enable auxillary copy property for commcell

### [Enable-CVBackupAgent](Enable-CVBackupAgent.md)
Used to enable backup property for an agent\nTypes of available agentIds are:\n41-Active Directory,\n21-AIX File System,\n64-Big Data Apps,\n134-Cloud Apps,\n37-DB2,\n103-DB2 MultiNode,\n62-DB2 on Unix,\n128-Documentum,\n90-Domino Mailbox Archiver,\n91-DPM,\n67-Exchange Compliance Archiver,\n53-Exchange Database,\n45-Exchange Mailbox,\n54-Exchange Mailbox (Classic),\n56-Exchange Mailbox Archiver,\n82-Exchange PF Archiver,\n35-Exchange Public Folder,\n73-File Share Archiver,\n33-File System,\n74-FreeBSD,\n71-GroupWise DB,\n17-HP-UX Files System,\n65-Image Level,\n75-Image Level On Unix,\n76-Image Level ProxyHost,\n87-Image Level ProxyHost on Unix,\n3-Informix Database,\n29-Linux File System,\n89-MS SharePoint Archiver,\n104-MySQL,\n13-NAS,\n83-Netware File Archiver,\n12-Netware File System,\n10-Novell Directory Services,\n124-Object Link,\n131-Object Store,\n86-OES File System on Linux,\n22-Oracle,\n80-Oracle RAC,\n130-Other External Agent,\n125-PostgreSQL,\n38-Proxy Client File System,\n87-ProxyHost on Unix,\n61-SAP for Oracle,\n135-SAP HANA,\n78-SharePoint Server,\n20-Solaris 64bit File System,\n19-Solaris File System,\n81-SQL Server,\n5-Sybase Database,\n66-Unix File Archiver,\n36-Unix Tru64 64-bit File System,\n106-Virtual Server,\n58- Windows File Archiver

### [Enable-CVBackupCommcell](Enable-CVBackupCommcell.md)
Used to enable backup property for commcell

### [Enable-CVBackupInstance](Enable-CVBackupInstance.md)
Used to enable backup property for an instance

### [Enable-CVBackupServerGroup](Enable-CVBackupServerGroup.md)
Used to enable backup property for a server group

### [Enable-CVBackupSubclient](Enable-CVBackupSubclient.md)
Used to enable backup property for an subclient

### [Enable-CVBlackoutWindowIgnoreHigherLevelRules](Enable-CVBlackoutWindowIgnoreHigherLevelRules.md)
Method to enable 'ignore CommCell higher-level blackout window rules' by entity.

### [Enable-CVContentIndexingCommcell](Enable-CVContentIndexingCommcell.md)
Used to enable content indexing property for commcell

### [Enable-CVDataAgingCommcell](Enable-CVDataAgingCommcell.md)
Used to enable data aging property for commcell

### [Enable-CVDataAgingServerGroup](Enable-CVDataAgingServerGroup.md)
Used to enable data aging property for a server group

### [Enable-CVDataVerificationCommcell](Enable-CVDataVerificationCommcell.md)
Used to enable data verification property for commcell

### [Enable-CVDdbCommcell](Enable-CVDdbCommcell.md)
Used to enable DDB property for commcell

### [Enable-CVJobActivity](Enable-CVJobActivity.md)
Used to enable all job activity property for commcell

### [Enable-CVLogScrubbing](Enable-CVLogScrubbing.md)
Used to enable log scrubbing

### [Enable-CVRestoreAgent](Enable-CVRestoreAgent.md)
Used to enable restore property for an agent\nTypes of available agentIds are:\n41-Active Directory,\n21-AIX File System,\n64-Big Data Apps,\n134-Cloud Apps,\n37-DB2,\n103-DB2 MultiNode,\n62-DB2 on Unix,\n128-Documentum,\n90-Domino Mailbox Archiver,\n91-DPM,\n67-Exchange Compliance Archiver,\n53-Exchange Database,\n45-Exchange Mailbox,\n54-Exchange Mailbox (Classic),\n56-Exchange Mailbox Archiver,\n82-Exchange PF Archiver,\n35-Exchange Public Folder,\n73-File Share Archiver,\n33-File System,\n74-FreeBSD,\n71-GroupWise DB,\n17-HP-UX Files System,\n65-Image Level,\n75-Image Level On Unix,\n76-Image Level ProxyHost,\n87-Image Level ProxyHost on Unix,\n3-Informix Database,\n29-Linux File System,\n89-MS SharePoint Archiver,\n104-MySQL,\n13-NAS,\n83-Netware File Archiver,\n12-Netware File System,\n10-Novell Directory Services,\n124-Object Link,\n131-Object Store,\n86-OES File System on Linux,\n22-Oracle,\n80-Oracle RAC,\n130-Other External Agent,\n125-PostgreSQL,\n38-Proxy Client File System,\n87-ProxyHost on Unix,\n61-SAP for Oracle,\n135-SAP HANA,\n78-SharePoint Server,\n20-Solaris 64bit File System,\n19-Solaris File System,\n81-SQL Server,\n5-Sybase Database,\n66-Unix File Archiver,\n36-Unix Tru64 64-bit File System,\n106-Virtual Server,\n58- Windows File Archiver

### [Enable-CVRestoreCommcell](Enable-CVRestoreCommcell.md)
Used to enable restore property for commcell

### [Enable-CVRestoreInstance](Enable-CVRestoreInstance.md)
Used to enable restore property for an instance

### [Enable-CVRestoreServerGroup](Enable-CVRestoreServerGroup.md)
Used to enable restore property for a server group

### [Enable-CVSchedulePolicy](Enable-CVSchedulePolicy.md)
Method to enable a schedule policy on the CommServe.

### [Enable-CVSchedulerCommcell](Enable-CVSchedulerCommcell.md)
Used to enable scheduler property for commcell

### [Export-CVSQLDatabaseRTD](Export-CVSQLDatabaseRTD.md)
Method to submit restore-to-disk SQL database export job.

### [Get-CVAccessControl](Get-CVAccessControl.md)
Gets owner permissions and laptop ownership details

### [Get-CVAccessNode](Get-CVAccessNode.md)
Endpoint to get the list of access nodes

### [Get-CVActivateEntityAuditList](Get-CVActivateEntityAuditList.md)
Retrieve the audit details for activate entities like clients, data sources, requests.\nAvailable entity types:\n3 - Client\n132 - Data source\n9515 - Request

### [Get-CVAdldapDetail](Get-CVAdldapDetail.md)
Get detail of the AD/LDAP domain

### [Get-CVAlert](Get-CVAlert.md)
Method to retrieve the list of alerts from the CommServe.

### [Get-CVAlertDefinitionDetail](Get-CVAlertDefinitionDetail.md)
Get details of alert definition

### [Get-CVAlertDefinitionList](Get-CVAlertDefinitionList.md)
Get the list of Alert Definitions

### [Get-CVAlertTriggered](Get-CVAlertTriggered.md)
Get List Of Alerts Triggered

### [Get-CVAnomalouCondition](Get-CVAnomalouCondition.md)
Get various anomalous conditions like events, jobs, offline clients, high CPU and memory loaded clients

### [Get-CVApplicationGroup](Get-CVApplicationGroup.md)
Get the details of all applicationGroups

### [Get-CVArchiveBackupDestination](Get-CVArchiveBackupDestination.md)
Get Backup Destinations for a Plan

### [Get-CVArchiveFileServer](Get-CVArchiveFileServer.md)
This endpoint is used to return the list of Archive file servers.

### [Get-CVArchivePlan](Get-CVArchivePlan.md)
Get Archive Plan details

### [Get-CVAssociation](Get-CVAssociation.md)
API to get list of association for a company

### [Get-CVBackupDestination](Get-CVBackupDestination.md)
Get Backup Destinations for a Plan

### [Get-CVBackupLocationDetail](Get-CVBackupLocationDetail.md)
Used to fetch mount path details of the disk storage pool

### [Get-CVBigDataList](Get-CVBigDataList.md)
This endpoint is used to return the list of big data apps.

### [Get-CVBlackoutWindow](Get-CVBlackoutWindow.md)
Get All Blackout Windows

### [Get-CVBlackoutWindowDetail](Get-CVBlackoutWindowDetail.md)
Get details of a blackout window based on id

### [Get-CVBucketDetail](Get-CVBucketDetail.md)
Get details of a specific bucket of a cloud storage

### [Get-CVClient](Get-CVClient.md)
Method to retrieve the list of clients or detailed client properties from the CommServe.

### [Get-CVClientGroup](Get-CVClientGroup.md)
Method to retrieve client groups from the CommServe.

### [Get-CVCloudStorage](Get-CVCloudStorage.md)
Get Cloud Storage Details

### [Get-CVCloudStorageList](Get-CVCloudStorageList.md)
Get All Cloud Storage

### [Get-CVCloudStorageMetaDataCache](Get-CVCloudStorageMetaDataCache.md)
Get details of metadata Cache of a cloud storage based on Id

### [Get-CVCompany](Get-CVCompany.md)
Get All Companies

### [Get-CVCompanyDetail](Get-CVCompanyDetail.md)
Get details of a company based on id

### [Get-CVCredentailDetail](Get-CVCredentailDetail.md)
Get details of the credential whose credential name is provided

### [Get-CVCredentials](Get-CVCredentials.md)
List of Credentials

### [Get-CVDatabase](Get-CVDatabase.md)
Get all databases

### [Get-CVDiskSpace](Get-CVDiskSpace.md)
Method to retrieve the available disk space of the library.

### [Get-CVDiskStorage](Get-CVDiskStorage.md)
Get a list of disk storage pools

### [Get-CVDiskStorageDetail](Get-CVDiskStorageDetail.md)
Get details of a disk storage pool based on id

### [Get-CVDistributedStorage](Get-CVDistributedStorage.md)
Get the list of distributed storages

### [Get-CVDistributedSystem](Get-CVDistributedSystem.md)
This endpoint is used to return the list of distributed systems.

### [Get-CVEmailServer](Get-CVEmailServer.md)
Retrieves SMTP server details

### [Get-CVEntitySetting](Get-CVEntitySetting.md)
Get list of entity settings used to modify default behaviour for linked entity like servers or server groups

### [Get-CVEpicServer](Get-CVEpicServer.md)
This endpoint is used to return the list of epic servers.

### [Get-CVFailoverGroup](Get-CVFailoverGroup.md)
This end point return the list of failover groups

### [Get-CVFileServer](Get-CVFileServer.md)
This endpoint is used to return the list of file servers.

### [Get-CVFirewallTopology](Get-CVFirewallTopology.md)
This endpoint is used to return the list of network topology.

### [Get-CVFirewallTopologyDetail](Get-CVFirewallTopologyDetail.md)
This endpoint is used to return the detail of network topology.

### [Get-CVGcpSpannerDatabase](Get-CVGcpSpannerDatabase.md)
Get database list for GCP

### [Get-CVGcpSpannerInstanceList](Get-CVGcpSpannerInstanceList.md)
To get the list of instances for GCP

### [Get-CVGcpSpannerPermission](Get-CVGcpSpannerPermission.md)
Get permission status for a cloudAccount on a GCP project

### [Get-CVGlobalException](Get-CVGlobalException.md)
Get list of global execptions

### [Get-CVGlobalSetting](Get-CVGlobalSetting.md)
Get list of global settings used to modify system default behaviour

### [Get-CVHybridFileStore](Get-CVHybridFileStore.md)
Get list of hybrid file stores

### [Get-CVHybridFileStoreShareStatus](Get-CVHybridFileStoreShareStatus.md)
API to get Hybrid File Store Share Status

### [Get-CVHyperScaleStorage](Get-CVHyperScaleStorage.md)
Get details of a specific HyperScale Storage

### [Get-CVHyperScaleStorageList](Get-CVHyperScaleStorageList.md)
Get All HyperScale Storage

### [Get-CVHypervisor](Get-CVHypervisor.md)
Get the details of  HYpervisor

### [Get-CVId](Get-CVId.md)
Method to retrieve the Id for a given Entity from the CommServe.

### [Get-CVIdentityServer](Get-CVIdentityServer.md)
Get identity servers list

### [Get-CVIndexServer](Get-CVIndexServer.md)
Get list of index servers

### [Get-CVInstance](Get-CVInstance.md)
This endpoint is used to return the list of instances.

### [Get-CVInstantClone](Get-CVInstantClone.md)
Get all instant clones

### [Get-CVJob](Get-CVJob.md)
Get job

### [Get-CVKeyManagementServer](Get-CVKeyManagementServer.md)
Get key management servers

### [Get-CVKuberneteApplication](Get-CVKuberneteApplication.md)
Get all application in Kubenetes cluster

### [Get-CVKuberneteCluster](Get-CVKuberneteCluster.md)
Get the details of all cluster

### [Get-CVLaptopBackupDestination](Get-CVLaptopBackupDestination.md)
Get Backup Destinations for a Plan

### [Get-CVLaptopList](Get-CVLaptopList.md)
Get list of laptops

### [Get-CVLaptopOwnerMapping](Get-CVLaptopOwnerMapping.md)
API to get the list of laptop owner mappings

### [Get-CVLaptopPlan](Get-CVLaptopPlan.md)
Get Laptop Plan details

### [Get-CVLibrary](Get-CVLibrary.md)
Method to retrieve storage resource library instances from the CommServe.

### [Get-CVLicenseInfo](Get-CVLicenseInfo.md)
This endpoint returns license information

### [Get-CVMediaAgent](Get-CVMediaAgent.md)
Get All Media Agents

### [Get-CVMediaAgentDetail](Get-CVMediaAgentDetail.md)
Get details of a media agent based on id

### [Get-CVNodeDetail](Get-CVNodeDetail.md)
Get details of a specific node of a hyperscale storage

### [Get-CVPermissionResponse](Get-CVPermissionResponse.md)
Get a list of categories and permissions in each category

### [Get-CVPlan](Get-CVPlan.md)
Get All Plans as Name Id Pairs

### [Get-CVPlanRule](Get-CVPlanRule.md)
Api to fetch plan rules list.

### [Get-CVPlanRuleAssociatedEntity](Get-CVPlanRuleAssociatedEntity.md)
API to fetch list of entities that are applicable for plan association via plan assignment rules.

### [Get-CVPlanRuleDetail](Get-CVPlanRuleDetail.md)
Api to fetch plan rules details.

### [Get-CVPlanRuleEntityExclude](Get-CVPlanRuleEntityExclude.md)
API to get excluded workloads from plan rule evaluation framework

### [Get-CVPlanRuleSetting](Get-CVPlanRuleSetting.md)
API to fetch plan rule execution settings

### [Get-CVPlanSummaryDetail](Get-CVPlanSummaryDetail.md)
Api to fetch summary of a plan.

### [Get-CVPlanSummaryList](Get-CVPlanSummaryList.md)
Get Plan Summary

### [Get-CVProject](Get-CVProject.md)
Retrieve list of projects for the request

### [Get-CVRecoveryPointStore](Get-CVRecoveryPointStore.md)
Fetch details about recovery point stores or library details

### [Get-CVRecoveryTarget](Get-CVRecoveryTarget.md)
Get the list of recovery targets

### [Get-CVRegion](Get-CVRegion.md)
Get list of regions

### [Get-CVRegionDetail](Get-CVRegionDetail.md)
Get details of the region

### [Get-CVReplicationGroup](Get-CVReplicationGroup.md)
Get all replication groups

### [Get-CVReplicationGroupDetail](Get-CVReplicationGroupDetail.md)
Get details of a replication group based on replicationGroupId

### [Get-CVReplicationMonitorPairId](Get-CVReplicationMonitorPairId.md)
Get Continuous Replication Pair Details

### [Get-CVRequestDetail](Get-CVRequestDetail.md)
Retrieve details of an existing request

### [Get-CVResourcePool](Get-CVResourcePool.md)
Get All Resource Pools

### [Get-CVRESTHeader](Get-CVRESTHeader.md)


### [Get-CVRole](Get-CVRole.md)
Get a list of all the roles

### [Get-CVRoleDetail](Get-CVRoleDetail.md)
Get a details of the role whose role id has been provided

### [Get-CVSamlApp](Get-CVSamlApp.md)
Gets details of SAML app based on SAML app name

### [Get-CVSchedulePolicy](Get-CVSchedulePolicy.md)
Method to retrieve schedule policies from the CommServe.

### [Get-CVServer](Get-CVServer.md)
This end point returns the list of servers

### [Get-CVServerGroup](Get-CVServerGroup.md)
Get All Server Groups

### [Get-CVServerGroupDetail](Get-CVServerGroupDetail.md)
Get details of a serverGroup based on id

### [Get-CVServerPlanRpo](Get-CVServerPlanRpo.md)
API to fetch schedules responsible for server plan RPO

### [Get-CVServiceCommcell](Get-CVServiceCommcell.md)
Returns a list of Service Commcells

### [Get-CVSessionDetail](Get-CVSessionDetail.md)


### [Get-CVSLAReport](Get-CVSLAReport.md)
Gets SLA report for specific client or entire CommCell.

### [Get-CVSolutionId](Get-CVSolutionId.md)
API to fetch applicable workload solutions for the user like File Server, Virtualization or Database

### [Get-CVSQLClientDetail](Get-CVSQLClientDetail.md)
Method to retrieve protected SQL client details.

### [Get-CVSQLClone](Get-CVSQLClone.md)
Method to retrieve SQL clone information.

### [Get-CVSQLCloneDetail](Get-CVSQLCloneDetail.md)
Method to retrieve SQL clone detail information.

### [Get-CVSQLDatabase](Get-CVSQLDatabase.md)
Method to retrieve SQL databases protected within the CommServe.

### [Get-CVSQLDatabaseBackupHistory](Get-CVSQLDatabaseBackupHistory.md)
Method to retrieve SQL database backup history information.

### [Get-CVSQLDatabaseDetail](Get-CVSQLDatabaseDetail.md)
Method to retrieve SQL database details.

### [Get-CVSQLInstance](Get-CVSQLInstance.md)
Method to retrieve SQL instances protected within the CommServe.

### [Get-CVSQLInstanceBackupHistory](Get-CVSQLInstanceBackupHistory.md)
Method to retrieve backup history data for specific SQL instance.

### [Get-CVSQLInstanceDetail](Get-CVSQLInstanceDetail.md)
Method to retrieve SQL instance details.

### [Get-CVStoragePolicy](Get-CVStoragePolicy.md)
Method to retrieve storage policies from the CommServe.

### [Get-CVSubclient](Get-CVSubclient.md)
Method to retrieve the list of subclients or a named subclient for a given client from the CommServe.

### [Get-CVSubclientMediaAgent](Get-CVSubclientMediaAgent.md)
Method to retrieve subclient media agent instances from the CommServe.

### [Get-CVSyslogStatus](Get-CVSyslogStatus.md)
This endpoint returns the details of a syslog server.

### [Get-CVTriggeredAlertDetail](Get-CVTriggeredAlertDetail.md)
Get details of triggered alert

### [Get-CVUser](Get-CVUser.md)
Get All Users

### [Get-CVUserDetail](Get-CVUserDetail.md)
Get details of a User based on id

### [Get-CVUserGroup](Get-CVUserGroup.md)
Get a list of existing user groups.

### [Get-CVUserGroupDetail](Get-CVUserGroupDetail.md)
Get details of a user-group based on id

### [Get-CVVersionInfo](Get-CVVersionInfo.md)
Method to retrieve the current version, service pack level, and time zone settings on the CommServe.

### [Get-CVVirtualMachine](Get-CVVirtualMachine.md)
Get all virtual machines

### [Get-CVVirtualMachineBackupTime](Get-CVVirtualMachineBackupTime.md)
Method to retrieve the last backup details of virtual machines in the CommCell.

### [Get-CVVirtualMachineDetail](Get-CVVirtualMachineDetail.md)
Get details for virtual machine

### [Get-CVVirtualMachineLiveMount](Get-CVVirtualMachineLiveMount.md)
Method to retrieve list of active mounts for specified source virtual machine.

### [Get-CVVMGroup](Get-CVVMGroup.md)
Get the details of all vmGroup

### [Get-CVWorkflow](Get-CVWorkflow.md)
Method to retrieve workflows from the CommServe.

### [Install-CVMediaAgent](Install-CVMediaAgent.md)
To install MediaAgent package on a server

### [Invoke-CVBrowseHypervisorInventory](Invoke-CVBrowseHypervisorInventory.md)
Browse the Inventory of your hypervisor

### [Invoke-CVInvokeRefreshNode](Invoke-CVInvokeRefreshNode.md)
Refresh a specific node of HyperScale

### [Invoke-CVLaptopOwnerMapping](Invoke-CVLaptopOwnerMapping.md)
API to create laptop owner mappings

### [Invoke-CVMachine](Invoke-CVMachine.md)
To Backup the virtual machines in vmgroup

### [Invoke-CVPinTriggeredAlert](Invoke-CVPinTriggeredAlert.md)
Pin triggered alerts

### [Invoke-CVPreviewVMGroup](Invoke-CVPreviewVMGroup.md)
Preview of the vm to be protected in VMGroup

### [Invoke-CVReConfigureHypervisor](Invoke-CVReConfigureHypervisor.md)
REconfigures and Renew License for  the hypervisor client

### [Invoke-CVReturnList](Invoke-CVReturnList.md)
This endpoint is used to return the list of tape storages.

### [Invoke-CVSnmp](Invoke-CVSnmp.md)
Get list of SNMP hosts for alert notification

### [Invoke-CVUnpinTriggeredAlert](Invoke-CVUnpinTriggeredAlert.md)
Unpin triggered alerts

### [Invoke-SetupLogin](Invoke-SetupLogin.md)
Add your QSDK Authenticated token to your Postman Environment by providing the details in the pre-request script.\n\nYou only need to run this one time because these values are stored in your Postman Environment.

### [Mount-CVSQLDatabase](Mount-CVSQLDatabase.md)
Method to submit SQL database mount job.

### [Mount-CVVirtualMachine](Mount-CVVirtualMachine.md)
Method to initiate live mount of specified virtual machine.

### [New-CVAccessPath](New-CVAccessPath.md)
Add a new Access path (mediaAgent) to a specific bucket of a specific cloud storage

### [New-CVAlertDefinition](New-CVAlertDefinition.md)
Create Alert Definitions

### [New-CVApplicationGroup](New-CVApplicationGroup.md)
Create a Kubernetes application group

### [New-CVArchiveBackupDestination](New-CVArchiveBackupDestination.md)
Create a Backup Destination for a Plan

### [New-CVArchivePlan](New-CVArchivePlan.md)
Create Archive Plan

### [New-CVBackupDestination](New-CVBackupDestination.md)
Create a Backup Destination for a Plan

### [New-CVBackupLocation](New-CVBackupLocation.md)
Create a new backup location

### [New-CVBlackoutWindow](New-CVBlackoutWindow.md)
Create a Blackout Window

### [New-CVBucketforCloudStorage](New-CVBucketforCloudStorage.md)
Create a new bucket for a specific cloud storage

### [New-CVCdmPlan](New-CVCdmPlan.md)
Create a CDM Plan

### [New-CVCloudStorage](New-CVCloudStorage.md)
Create a Cloud Storage

### [New-CVCloudStorageMetaDataCache](New-CVCloudStorageMetaDataCache.md)
Add metadata cache paths to storage

### [New-CVCompany](New-CVCompany.md)
Create a Company

### [New-CVCredential](New-CVCredential.md)
Create a new credential

### [New-CVDiskStorage](New-CVDiskStorage.md)
Create a new disk storage pool

### [New-CVFirewallTopology](New-CVFirewallTopology.md)
This endpoint is used to create network topology.

### [New-CVHyperScaleStorage](New-CVHyperScaleStorage.md)
Create a HyperScale Storage

### [New-CVHypervisor](New-CVHypervisor.md)
Create Hypervisor for that particular type

### [New-CVKubernetescluster](New-CVKubernetescluster.md)
Create Kubernetes cluster

### [New-CVLaptopBackupDestination](New-CVLaptopBackupDestination.md)
Create a Backup Destination for a Plan

### [New-CVLaptopPlan](New-CVLaptopPlan.md)
Create Laptop Plan

### [New-CVLdap](New-CVLdap.md)
Create LDAP/Active directory for user authentication

### [New-CVNodeforHyperScaleStorage](New-CVNodeforHyperScaleStorage.md)
Add nodes for a specific hyperscale storage

### [New-CVPlanRule](New-CVPlanRule.md)
Api to create plan rules.
Request body will suggest plan against which rule need to be created and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.

### [New-CVRegion](New-CVRegion.md)
Create a region

### [New-CVReplicationGroup](New-CVReplicationGroup.md)
Create a replication group

### [New-CVRequestResourceManager](New-CVRequestResourceManager.md)
Creating a request for request manager

### [New-CVRole](New-CVRole.md)
Create a new role

### [New-CVSamlApp](New-CVSamlApp.md)
Creates SAML app

### [New-CVServerPlan](New-CVServerPlan.md)
Create a Server Plan

### [New-CVServerPlanBackupContent](New-CVServerPlanBackupContent.md)
API to create backup content on server plan

### [New-CVServerPlanRpo](New-CVServerPlanRpo.md)
API to create RPO schedules on server plan

### [New-CVUser](New-CVUser.md)
Create a User

### [New-CVUserGroup](New-CVUserGroup.md)
Create a new user-group

### [New-CVVMGroup](New-CVVMGroup.md)
Create a VM Group

### [ProcessBlackoutWindowIgnoreHigherLevelRules](ProcessBlackoutWindowIgnoreHigherLevelRules.md)


### [Remove-CVAccessPath](Remove-CVAccessPath.md)
Disassociate a MediaAgent (cloud Access Path) from a bucket of a cloud storage

### [Remove-CVAdldap](Remove-CVAdldap.md)
Delete an AD/LDAP domain

### [Remove-CVAlertDefinition](Remove-CVAlertDefinition.md)
Delete alert definitions

### [Remove-CVArchiveBackupDestination](Remove-CVArchiveBackupDestination.md)
Delete Backup Destination for a Plan

### [Remove-CVArchivePlan](Remove-CVArchivePlan.md)
Delete existing archive plan

### [Remove-CVBackupDestination](Remove-CVBackupDestination.md)
Delete Backup Destination for a Plan

### [Remove-CVBackupLocation](Remove-CVBackupLocation.md)
Modify the properties of an existing mount path

### [Remove-CVBlackoutWindow](Remove-CVBlackoutWindow.md)
Used to delete a Blackout Window

### [Remove-CVBucket](Remove-CVBucket.md)
Delete the specified bucket of the cloud storage

### [Remove-CVBulkLaptopOwnerMappingActionDelete](Remove-CVBulkLaptopOwnerMappingActionDelete.md)
API is used to delete multiple laptopowner mappings

### [Remove-CVCloudStorage](Remove-CVCloudStorage.md)
Delete existing cloud storage

### [Remove-CVCloudStorageMetadataCache](Remove-CVCloudStorageMetadataCache.md)
Delete metadata cache of an existing cloud storage

### [Remove-CVCompany](Remove-CVCompany.md)
Used to delete a company which has been deactivated

### [Remove-CVCredential](Remove-CVCredential.md)
Delete Credential whose name has been provided

### [Remove-CVDiskAccessPath](Remove-CVDiskAccessPath.md)
Used to delete a media agent to a disk access path

### [Remove-CVDiskStorage](Remove-CVDiskStorage.md)
Used to delete a disk storage pool

### [Remove-CVFirewallTopology](Remove-CVFirewallTopology.md)
This endpoint is used to delete network topology.

### [Remove-CVHyperScaleStorage](Remove-CVHyperScaleStorage.md)
Delete existing hyperscale storage

### [Remove-CVHypervisor](Remove-CVHypervisor.md)
delete an existing vm group

### [Remove-CVKeyManagementServer](Remove-CVKeyManagementServer.md)
Delete key management server based on Id

### [Remove-CVLaptopBackupDestination](Remove-CVLaptopBackupDestination.md)
Delete Backup Destination for a Plan

### [Remove-CVLaptopPlan](Remove-CVLaptopPlan.md)
Delete existing laptop plan

### [Remove-CVMediaAgent](Remove-CVMediaAgent.md)
Used to delete a media agent.

### [Remove-CVMultipleTriggeredalert](Remove-CVMultipleTriggeredalert.md)
Delete multiple triggered alerts

### [Remove-CVMultipleUser](Remove-CVMultipleUser.md)
Delete multiple users

### [Remove-CVMultipleUserGroup](Remove-CVMultipleUserGroup.md)
Delete multiple userGroups

### [Remove-CVPlan](Remove-CVPlan.md)
Used to delete an existing server plan

### [Remove-CVPlanRule](Remove-CVPlanRule.md)
Api to delete selected plan rule

### [Remove-CVRecoveryPointStore](Remove-CVRecoveryPointStore.md)
Delete a specific recovery point store

### [Remove-CVRecoveryTarget](Remove-CVRecoveryTarget.md)
To delete an exisitng recovery target

### [Remove-CVRegion](Remove-CVRegion.md)
Delete the region

### [Remove-CVReplicationGroup](Remove-CVReplicationGroup.md)
Used to delete a replication group

### [Remove-CVRequestManagerRequest](Remove-CVRequestManagerRequest.md)
Deleting an existing request

### [Remove-CVRole](Remove-CVRole.md)
Used to delete a role

### [Remove-CVServerGroup](Remove-CVServerGroup.md)
Used to delete a serverGroup

### [Remove-CVSQLClone](Remove-CVSQLClone.md)


### [Remove-CVStorageRegion](Remove-CVStorageRegion.md)
Delete Storage Region for an Elastic Plan

### [Remove-CVTriggeredAlert](Remove-CVTriggeredAlert.md)
Delete Triggered Alerts

### [Remove-CVUser](Remove-CVUser.md)
Used to delete a user

### [Remove-CVUserGroup](Remove-CVUserGroup.md)
Used to delete a user-group

### [Remove-CVVirtualMachine](Remove-CVVirtualMachine.md)
Used to delete a virtual machine

### [Remove-CVVMGroup](Remove-CVVMGroup.md)
delete an existing vm group

### [Request-CVManagerRequestList](Request-CVManagerRequestList.md)
Retrieves the list of Requests

### [Restore-CVClientFileSystem](Restore-CVClientFileSystem.md)
Create restore task for specific or default subclient of client file system.

### [Restore-CVSQLDatabase](Restore-CVSQLDatabase.md)
Method to submit SQL database in-place or out-of-place restore job.

### [Restore-CVVirtualMachine](Restore-CVVirtualMachine.md)
Method to initiate restore/recovery of specified virtual machine.

### [Resubmit-CVJob](Resubmit-CVJob.md)
Resubmit the job specified by job Id.

### [Resume-CVJob](Resume-CVJob.md)
Resumes the job specified by job Id.

### [Search-CVClientFileSystem](Search-CVClientFileSystem.md)
Method to create a client file system browse query.

### [Search-CVGlobal](Search-CVGlobal.md)


### [Select-CVClientFileSystem](Select-CVClientFileSystem.md)
Retrieve list of protected files in client file system by search pattern.

### [Send-CVLogFile](Send-CVLogFile.md)
Create Send Log Files task for client or specific job.

### [Send-CVTestMailReq](Send-CVTestMailReq.md)
To test Email settings

### [Set-CVAccessControl](Set-CVAccessControl.md)
Updates owner permissions and/or automatic laptop ownership assignment

### [Set-CVAccessPath](Set-CVAccessPath.md)
Modify access path details of specific bucket of a specific cloud storage

### [Set-CVAdldap](Set-CVAdldap.md)
Update an AD/LDAP domain

### [Set-CVArchiveBackupDestination](Set-CVArchiveBackupDestination.md)
Modify Backup Destination for a Plan

### [Set-CVArchivePlan](Set-CVArchivePlan.md)
Modify existing archive plan details

### [Set-CVBackupDestination](Set-CVBackupDestination.md)
Modify Backup Destination for a Plan

### [Set-CVBackupLocation](Set-CVBackupLocation.md)
Modify the properties of an existing mount path

### [Set-CVBlackoutWindow](Set-CVBlackoutWindow.md)
Modify the properties of an existing Blackout Window

### [Set-CVBucket](Set-CVBucket.md)
Modify configuration of a specific bucket of a specific cloud storage

### [Set-CVClient](Set-CVClient.md)
Method to set client properties.

### [Set-CVClientGroup](Set-CVClientGroup.md)
Method to set client group properties.

### [Set-CVCloudStorage](Set-CVCloudStorage.md)
Modify details like name, encryption, security of a specific cloud storage

### [Set-CVCloudStorageMetaDataCache](Set-CVCloudStorageMetaDataCache.md)
Modify details like credentials and path for metadata Cache of a cloud storage based on Id

### [Set-CVCompany](Set-CVCompany.md)
Modify the properties of an existing company

### [Set-CVCompanyTimezone](Set-CVCompanyTimezone.md)
Assigns company's timezone as the timezone for servers with no packages installed

### [Set-CVCredential](Set-CVCredential.md)
Edit credential whose name has been provided by credential owner

### [Set-CVDiskStorage](Set-CVDiskStorage.md)
Modify the properties of an existing disk storage pool

### [Set-CVEmailServer](Set-CVEmailServer.md)
Configure SMTP server settings.

### [Set-CVEntitySetting](Set-CVEntitySetting.md)
Modify entity settings used to change default behaviour for linked entity like servers or server groups

### [Set-CVFirewallTopology](Set-CVFirewallTopology.md)
This endpoint is used to edit network topology.

### [Set-CVGlobalSetting](Set-CVGlobalSetting.md)
Modify global settings used to override system default behaviour

### [Set-CVHyperScaleStorage](Set-CVHyperScaleStorage.md)
Modify details like name, encryption, security of a specific hyperscale storage

### [Set-CVHypervisor](Set-CVHypervisor.md)
Updates the Hypervisors

### [Set-CVHypervisorAccessNode](Set-CVHypervisorAccessNode.md)
Endpoint to Change the Access Node

### [Set-CVHypervisorFbr](Set-CVHypervisorFbr.md)
Endpoint to set FBR

### [Set-CVLaptopBackupDestination](Set-CVLaptopBackupDestination.md)
Modify Backup Destination for a Plan

### [Set-CVLaptopOwnerMapping](Set-CVLaptopOwnerMapping.md)
API to update existing laptop owner mapping

### [Set-CVLaptopPlan](Set-CVLaptopPlan.md)
Modify existing laptop plan details

### [Set-CVMediaAgent](Set-CVMediaAgent.md)
Modify the properties of an existing media agent

### [Set-CVPlan](Set-CVPlan.md)
Used to modify an exsiting server plan

### [Set-CVPlanRule](Set-CVPlanRule.md)
Api to update existing plan rules.
Request body will suggest which rule need to be updated and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.

### [Set-CVPlanRuleAssociatedEntity](Set-CVPlanRuleAssociatedEntity.md)
API to send request to process plan rules against specific set of entities.

### [Set-CVPlanRuleEntityAssociate](Set-CVPlanRuleEntityAssociate.md)
API to associate workloads to selected plan and plan rule

### [Set-CVPlanRuleEntityExclude](Set-CVPlanRuleEntityExclude.md)
API to exclude workloads from plan rule evaluation framework

### [Set-CVPlanRuleEntityInclude](Set-CVPlanRuleEntityInclude.md)
API to include workloads to be applicable for plan rule evaluation.

### [Set-CVPlanRuleRank](Set-CVPlanRuleRank.md)
API to update rank for multiple rules at a time.

### [Set-CVPlanRuleSetting](Set-CVPlanRuleSetting.md)
API to set plan rule execution settings

### [Set-CVRegion](Set-CVRegion.md)
Api to set region for an entity.

### [Set-CVReplicationGroup](Set-CVReplicationGroup.md)
Modify the properties of an existing replication group

### [Set-CVRequestManagerConfigureRequest](Set-CVRequestManagerConfigureRequest.md)
Configure a created request

### [Set-CVRole](Set-CVRole.md)
Modify the properties of an existing role

### [Set-CVSamlApp](Set-CVSamlApp.md)
Updates details of existing SAML app

### [Set-CVSchedulePattern](Set-CVSchedulePattern.md)
API to update pattern for schedule in schedule policy

### [Set-CVServerPlanRpo](Set-CVServerPlanRpo.md)
API to modify RPO schedules on server plan

### [Set-CVSubclient](Set-CVSubclient.md)
Method to create a new subclient.

### [Set-CVSyslogStatus](Set-CVSyslogStatus.md)
This endpoint configures a syslog server.

### [Set-CVTriggeredAlertNote](Set-CVTriggeredAlertNote.md)
Add, Modify and Delete notes for triggered alerts

### [Set-CVUser](Set-CVUser.md)
Used to modify an existing user

### [Set-CVUserGroup](Set-CVUserGroup.md)
Modify the properties of an existing user-group

### [Set-CVVirtualMachine](Set-CVVirtualMachine.md)
Modify the properties of an existing virtual machine

### [Set-CVVMGroup](Set-CVVMGroup.md)
Updates the VM Group

### [Start-CVWorkflow](Start-CVWorkflow.md)
Method to start/execute a workflow on the CommServe.

### [Stop-CVJob](Stop-CVJob.md)
Stops/kills the job specified by job Id.

### [Submit-CVRESTRequest](Submit-CVRESTRequest.md)


### [Update-CVGlobalException](Update-CVGlobalException.md)
Add/Edit/Delete global execptions

### [Update-CVMissedSLA](Update-CVMissedSLA.md)
Initiates backup job for subclients with missed SLA.

