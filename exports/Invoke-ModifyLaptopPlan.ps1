
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Modify existing laptop plan details
.Description
Modify existing laptop plan details
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICommvaultPowerShellIdentity
.Inputs
Commvault.Powershell.Models.IUpdateLaptopPlan
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ALERTS <IIdName[]>: .
  [Id <Int32?>]: 
  [Name <String>]: 

ALLOWEDFEATURES <ILaptopPlanAllowedFeatures>: Create/modify allowed features of laptop plan
  [Archiving <Boolean?>]: Flag to enable archiving of laptop data
  [ArchivingRuleAfterArchiving <String>]: After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving rules
  [ArchivingRuleArchiveReadOnlyFiles <Boolean?>]: To archive files based on the Read-Only attribute, set to TRUE
  [ArchivingRuleFileAccessTimeOlderThan <Int32?>]: To archive files based on the last accessed date of each file within the folder, specify the number of days
  [ArchivingRuleFileCreatedTimeOlderThan <Int32?>]: To archive files based on the time the files were created within the folder, specify the number of days
  [ArchivingRuleFileModifiedTimeOlderThan <Int32?>]: To archive files based on the last modified date of each file within the folder, specify the number of days
  [ArchivingRuleFileSizeGreaterThan <Int32?>]: To archive files based on the size of the file, specify the minimum file size in KB. All files whose size ranges between the minimum and maximum values are archived.
  [ArchivingRuleMaximumFileSize <Int32?>]: To archive files based on the size of the file, specify the maximum file size in KB. All files whose size ranges between the minimum and maximum values are archived.
  [ArchivingRuleStartCleaningIfLessThan <Int32?>]: When free disk space falls below specified amount (in percentage), start cleaning up the disk
  [ArchivingRuleStopCleaningIfupto <Int32?>]: When free disk space more than specified amount (in percentage), stop cleaning up the disk
  [ClientId <Int32?>]: 
  [ClientName <String>]: 
  [Dlp <Boolean?>]: Flag to enable Data loss protection
  [EdgeDrive <Boolean?>]: Flag to enable Edge Drive
  [EdgeDriveSettingAuditDriveOperations <Boolean?>]: Enable auditing which logs the activities based on user interaction like creating, editing, moving, renaming, downloading or deleting files.
  [EdgeDriveSettingCreateNewIndexServer <Boolean?>]: If set to false, uses existing edge index server and requires IndexServer IdName to be passed. If set to true, requires client IdName and indexCachePath to create a new Index Server.
  [EdgeDriveSettingEdgeDriveQuota <Int32?>]: Maximum number of gigabytes that you can store in the Edge Drive. Giving value as -1 means no quota.
  [EdgeDriveSettingIndexCachePath <String>]: 
  [EdgeDriveSettingNotificationsForShares <Boolean?>]: Enables alert notification feature which allows the share user or share owner to subscribe for share notifications when any activities are performed on the Edge Drive or the Collaborative share. The user can receive the notifications on the Web Console or as an email notification.
  [IndexServerId <Int32?>]: 
  [IndexServerName <String>]: 

ASSOCIATEDUSERSANDUSERGROUPS <IPlanUserOrGroups[]>: .
  [Id <Int32?>]: This gives Id of user or user group or external user group
  [Name <String>]: This gives name of user or user group or external user group
  [SendInvite <Boolean?>]: If set to true, will send an invite email to the user or group. Default is true.
  [Type <String>]: Tells what kind of user or user group it is

BODY <IUpdateLaptopPlan>: .
  [Alerts <IIdName[]>]: 
    [Id <Int32?>]: 
    [Name <String>]: 
  [AllowPlanOverride <Boolean?>]: Flag to enable overriding of plan
  [AllowedFeatures <ILaptopPlanAllowedFeatures>]: Create/modify allowed features of laptop plan
    [Archiving <Boolean?>]: Flag to enable archiving of laptop data
    [ArchivingRuleAfterArchiving <String>]: After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving rules
    [ArchivingRuleArchiveReadOnlyFiles <Boolean?>]: To archive files based on the Read-Only attribute, set to TRUE
    [ArchivingRuleFileAccessTimeOlderThan <Int32?>]: To archive files based on the last accessed date of each file within the folder, specify the number of days
    [ArchivingRuleFileCreatedTimeOlderThan <Int32?>]: To archive files based on the time the files were created within the folder, specify the number of days
    [ArchivingRuleFileModifiedTimeOlderThan <Int32?>]: To archive files based on the last modified date of each file within the folder, specify the number of days
    [ArchivingRuleFileSizeGreaterThan <Int32?>]: To archive files based on the size of the file, specify the minimum file size in KB. All files whose size ranges between the minimum and maximum values are archived.
    [ArchivingRuleMaximumFileSize <Int32?>]: To archive files based on the size of the file, specify the maximum file size in KB. All files whose size ranges between the minimum and maximum values are archived.
    [ArchivingRuleStartCleaningIfLessThan <Int32?>]: When free disk space falls below specified amount (in percentage), start cleaning up the disk
    [ArchivingRuleStopCleaningIfupto <Int32?>]: When free disk space more than specified amount (in percentage), stop cleaning up the disk
    [ClientId <Int32?>]: 
    [ClientName <String>]: 
    [Dlp <Boolean?>]: Flag to enable Data loss protection
    [EdgeDrive <Boolean?>]: Flag to enable Edge Drive
    [EdgeDriveSettingAuditDriveOperations <Boolean?>]: Enable auditing which logs the activities based on user interaction like creating, editing, moving, renaming, downloading or deleting files.
    [EdgeDriveSettingCreateNewIndexServer <Boolean?>]: If set to false, uses existing edge index server and requires IndexServer IdName to be passed. If set to true, requires client IdName and indexCachePath to create a new Index Server.
    [EdgeDriveSettingEdgeDriveQuota <Int32?>]: Maximum number of gigabytes that you can store in the Edge Drive. Giving value as -1 means no quota.
    [EdgeDriveSettingIndexCachePath <String>]: 
    [EdgeDriveSettingNotificationsForShares <Boolean?>]: Enables alert notification feature which allows the share user or share owner to subscribe for share notifications when any activities are performed on the Edge Drive or the Collaborative share. The user can receive the notifications on the Web Console or as an email notification.
    [IndexServerId <Int32?>]: 
    [IndexServerName <String>]: 
  [AssociatedUsersAndUserGroups <IPlanUserOrGroups[]>]: 
    [Id <Int32?>]: This gives Id of user or user group or external user group
    [Name <String>]: This gives name of user or user group or external user group
    [SendInvite <Boolean?>]: If set to true, will send an invite email to the user or group. Default is true.
    [Type <String>]: Tells what kind of user or user group it is
  [BackupContentFileSystemQuota <Int32?>]: Maximum number of gigabytes that you can store in the File System. Giving value as -1 means infinite file system quota.
  [BackupContentMacExcludedPaths <String[]>]: Paths to exclude for Mac
  [BackupContentMacIncludedPaths <String[]>]: Paths to include for Mac
  [BackupContentUnixExcludedPaths <String[]>]: Paths to exclude for UNIX
  [BackupContentUnixIncludedPaths <String[]>]: Paths to include for UNIX
  [BackupContentWindowsExcludedPaths <String[]>]: Paths to exclude for Windows
  [BackupContentWindowsIncludedPaths <String[]>]: Paths to include for Windows
  [FileVersionDailyVersions <Int32?>]: Custom version rule: Retain daily versions for this many day(s)
  [FileVersionDays <Int32?>]: Retain files for this many days. Year(s) or month(s) need to be converted to day(s)
  [FileVersionMonthlyVersions <Int32?>]: Custom version rule: Retain monthly versions for this many month(s)
  [FileVersionVersions <Int32?>]: Retain this many file versions. This is considered as default if no file retention rule is specified.
  [FileVersionWeeklyVersions <Int32?>]: Custom version rule: Retain weekly versions for this many week(s)
  [GeneralOptimizedForCloudBackups <Boolean?>]: This feature allows laptops to write backup directly to the cloud storage. It helps to optimize scale by reducing server dependency and extra data hops. Once the feature is enabled, the existing and the newly-added laptops use optimized backups.
  [NetworkResourceThrottleReceive <Int32?>]: Maximum kilobits per second to throttle the receiving speed of data. Giving value as -1 means infinite throttle send speed i.e. no limit
  [NetworkResourceThrottleSend <Int32?>]: Maximum kilobits per second to throttle the emitting speed of data. Giving value as -1 means infinite throttle send speed i.e. no limit
  [NewName <String>]: New plan name to update
  [OfflineLaptopDeleteAfterDays <Int32?>]: The offline laptops are automatically deleted when the number of days are met. -1 means never.
  [OfflineLaptopRetireAfterDays <Int32?>]: The offline laptops are retired when the number of days are met. -1 means never.
  [OverrideRestrictionBackupContent <String>]: 
  [OverrideRestrictionRetention <String>]: 
  [OverrideRestrictionRpo <String>]: 
  [OverrideRestrictionStoragePool <String>]: 
  [RegionToConfigureId <Int32?>]: 
  [RegionToConfigureName <String>]: 
  [RetentionDeletedItemRetention <Int32?>]: Amount of days after deletion of files to keep the items. Giving value as -1 means to retain files indefinitely.
  [RpoBackupFrequency <Int32?>]: Specify incremental backup frequency in minutes. Backup operation will start as per the time zone of the associated server.
  [SlaEnableAfterDelay <Int32?>]: Time provided in Unix format. Give 0 to reset any existing delay.
  [SlaExcludeFromSla <Boolean?>]: Flag to set to exclude plan from SLA
  [SlaExclusionReason <String>]: Reason for exclusion from SLA
  [SlaPeriod <Int32?>]: SLA Period in Days
  [SlaUseSystemDefaultSla <Boolean?>]: Flag to set to use System Default Service Level Agreement

INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
  [AccessPathId <Int32?>]: Id of the mount path whose access path has to be deleted
  [AgentId <Int32?>]: Id of the agent to be modified
  [BackupDestinationId <Int32?>]: Id of the backupDestination to be modified
  [BackupLocationId <Int32?>]: Id of the backup location whose details have to be fetched
  [BlackoutWindowId <Int32?>]: Id of the Blackout Window whose details have to be fetched
  [BucketId <Int32?>]: Id of Bucket
  [CloudStorageId <Int32?>]: Id of cloud Storage
  [CompanyId <Int32?>]: Id of the Company whose details have to be fetched
  [CredentialName <String>]: 
  [DomainId <Int32?>]: ID of the AD/LDAP domain
  [EntityId <Int32?>]: Unique id for the entity
  [EntityType <String>]: Type of the entity
  [GlobalSearchEntity <String>]: name of global search entity
  [HfsShareId <Int32?>]: Id of the HFS Share to fetch its status
  [HyperScaleStorageId <Int32?>]: Id of hyperscale storage
  [HypervisorId <Int32?>]: Id of the HYpervisor to get
  [Id <Int32?>]: 
  [InstanceId <Int32?>]: Id of the instance to modify
  [KmsId <Int32?>]: Id of Key Management Server
  [MediaAgentId <Int32?>]: Id of the Media Agent whose details have to be fetched
  [MetadataCacheId <Int32?>]: Id of metadata cache
  [Name <String>]: 
  [NodeId <Int32?>]: Id of node
  [PairId <Int32?>]: 
  [PlanId <Int32?>]: Id of the plan to fetch details
  [RecoveryTargetId <Int32?>]: id of recovery target
  [RegionId <String>]: 
  [RegionList <String>]: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  [ReplicationGroupId <String>]: 
  [RequestId <Int32?>]: Unique identifier for the request
  [RoleId <Int32?>]: Role Id
  [RpsId <String>]: 
  [RuleId <Int32?>]: Id of the rule to update in Plan
  [ScheduleId <String>]: 
  [SchedulePolicyId <String>]: 
  [ServerGroupId <Int32?>]: Id of the serverGroupId whose details have to be fetched
  [ServerId <Int32?>]: Id of the server to modify
  [StoragePoolId <Int32?>]: Id of the disk storage pool whose details have to be fetched
  [SubclientId <Int32?>]: Id of the subclient to modify
  [TopologyId <String>]: 
  [UserGroupId <Int32?>]: Id of the user-group whose details have to be fetched
  [UserId <Int32?>]: Id of the User whose details have to be fetched
  [VMGroupId <Int32?>]: Id of the VMgroup to update
  [VMUuid <String>]: The vmUUID can be obtained from GET /virtualMachines UUID property
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifylaptopplan
#>
function Invoke-ModifyLaptopPlan {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='ModifyExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Modify', Mandatory)]
    [Parameter(ParameterSetName='ModifyExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # Id of the plan
    ${PlanId},

    [Parameter(ParameterSetName='ModifyViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Path')]
    [Commvault.Powershell.Models.ICommvaultPowerShellIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Modify', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ModifyViaIdentity', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IUpdateLaptopPlan]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # .
    # To construct, see NOTES section for ALERTS properties and create a hash table.
    ${Alerts},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to enable overriding of plan
    ${AllowPlanOverride},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ILaptopPlanAllowedFeatures]
    # Create/modify allowed features of laptop plan
    # To construct, see NOTES section for ALLOWEDFEATURES properties and create a hash table.
    ${AllowedFeatures},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IPlanUserOrGroups[]]
    # .
    # To construct, see NOTES section for ASSOCIATEDUSERSANDUSERGROUPS properties and create a hash table.
    ${AssociatedUsersAndUserGroups},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Maximum number of gigabytes that you can store in the File System.
    # Giving value as -1 means infinite file system quota.
    ${BackupContentFileSystemQuota},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to exclude for Mac
    ${BackupContentMacExcludedPaths},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to include for Mac
    ${BackupContentMacIncludedPaths},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to exclude for UNIX
    ${BackupContentUnixExcludedPaths},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to include for UNIX
    ${BackupContentUnixIncludedPaths},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to exclude for Windows
    ${BackupContentWindowsExcludedPaths},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to include for Windows
    ${BackupContentWindowsIncludedPaths},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Custom version rule: Retain daily versions for this many day(s)
    ${FileVersionDailyVersions},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Retain files for this many days.
    # Year(s) or month(s) need to be converted to day(s)
    ${FileVersionDays},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Custom version rule: Retain monthly versions for this many month(s)
    ${FileVersionMonthlyVersions},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Retain this many file versions.
    # This is considered as default if no file retention rule is specified.
    ${FileVersionVersions},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Custom version rule: Retain weekly versions for this many week(s)
    ${FileVersionWeeklyVersions},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # This feature allows laptops to write backup directly to the cloud storage.
    # It helps to optimize scale by reducing server dependency and extra data hops.
    # Once the feature is enabled, the existing and the newly-added laptops use optimized backups.
    ${GeneralOptimizedForCloudBackups},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Maximum kilobits per second to throttle the receiving speed of data.
    # Giving value as -1 means infinite throttle send speed i.e.
    # no limit
    ${NetworkResourceThrottleReceive},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Maximum kilobits per second to throttle the emitting speed of data.
    # Giving value as -1 means infinite throttle send speed i.e.
    # no limit
    ${NetworkResourceThrottleSend},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # New plan name to update
    ${NewName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # The offline laptops are automatically deleted when the number of days are met.
    # -1 means never.
    ${OfflineLaptopDeleteAfterDays},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # The offline laptops are retired when the number of days are met.
    # -1 means never.
    ${OfflineLaptopRetireAfterDays},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionBackupContent},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionRetention},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionRpo},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionStoragePool},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${RegionToConfigureId},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${RegionToConfigureName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Amount of days after deletion of files to keep the items.
    # Giving value as -1 means to retain files indefinitely.
    ${RetentionDeletedItemRetention},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Specify incremental backup frequency in minutes.
    # Backup operation will start as per the time zone of the associated server.
    ${RpoBackupFrequency},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Time provided in Unix format.
    # Give 0 to reset any existing delay.
    ${SlaEnableAfterDelay},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to set to exclude plan from SLA
    ${SlaExcludeFromSla},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Reason for exclusion from SLA
    ${SlaExclusionReason},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # SLA Period in Days
    ${SlaPeriod},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to set to use System Default Service Level Agreement
    ${SlaUseSystemDefaultSla},

    [Parameter(DontShow)]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Commvault.Powershell.Category('Runtime')]
    [Commvault.Powershell.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Commvault.Powershell.Category('Runtime')]
    [Commvault.Powershell.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Commvault.Powershell.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Modify = 'CommvaultPowerShell.private\Invoke-ModifyLaptopPlan_Modify';
            ModifyExpanded = 'CommvaultPowerShell.private\Invoke-ModifyLaptopPlan_ModifyExpanded';
            ModifyViaIdentity = 'CommvaultPowerShell.private\Invoke-ModifyLaptopPlan_ModifyViaIdentity';
            ModifyViaIdentityExpanded = 'CommvaultPowerShell.private\Invoke-ModifyLaptopPlan_ModifyViaIdentityExpanded';
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
