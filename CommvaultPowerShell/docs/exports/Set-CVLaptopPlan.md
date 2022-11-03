---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-cvlaptopplan
schema: 2.0.0
---

# Set-CVLaptopPlan

## SYNOPSIS
Modify existing laptop plan details

## SYNTAX

### UpdateExpanded (Default)
```
Set-CVLaptopPlan -PlanId <Int64> [-Alerts <IIdName[]>] [-AllowedFeatures <ILaptopPlanAllowedFeatures>]
 [-AllowPlanOverride] [-AssociatedUsersAndUserGroups <IPlanUserOrGroups[]>]
 [-BackupContentFileSystemQuota <Int64>] [-BackupContentMacExcludedPaths <String[]>]
 [-BackupContentMacIncludedPaths <String[]>] [-BackupContentUnixExcludedPaths <String[]>]
 [-BackupContentUnixIncludedPaths <String[]>] [-BackupContentWindowsExcludedPaths <String[]>]
 [-BackupContentWindowsIncludedPaths <String[]>] [-FileVersionDailyVersions <Int64>]
 [-FileVersionDays <Int64>] [-FileVersionMonthlyVersions <Int64>] [-FileVersionVersions <Int64>]
 [-FileVersionWeeklyVersions <Int64>] [-GeneralOptimizedForCloudBackups]
 [-NetworkResourceThrottleReceive <Int64>] [-NetworkResourceThrottleSend <Int64>] [-NewName <String>]
 [-OfflineLaptopDeleteAfterDays <Int64>] [-OfflineLaptopRetireAfterDays <Int64>]
 [-OverrideRestrictionBackupContent <String>] [-OverrideRestrictionRetention <String>]
 [-OverrideRestrictionRpo <String>] [-OverrideRestrictionStoragePool <String>] [-RegionToConfigureId <Int64>]
 [-RegionToConfigureName <String>] [-RetentionDeletedItemRetention <Int64>] [-RpoBackupFrequency <Int64>]
 [-SlaEnableAfterDelay <Int64>] [-SlaExcludeFromSla] [-SlaExclusionReason <String>] [-SlaPeriod <Int64>]
 [-SlaUseSystemDefaultSla] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Set-CVLaptopPlan -InputObject <ICommvaultPowerShellIdentity> [-Alerts <IIdName[]>]
 [-AllowedFeatures <ILaptopPlanAllowedFeatures>] [-AllowPlanOverride]
 [-AssociatedUsersAndUserGroups <IPlanUserOrGroups[]>] [-BackupContentFileSystemQuota <Int64>]
 [-BackupContentMacExcludedPaths <String[]>] [-BackupContentMacIncludedPaths <String[]>]
 [-BackupContentUnixExcludedPaths <String[]>] [-BackupContentUnixIncludedPaths <String[]>]
 [-BackupContentWindowsExcludedPaths <String[]>] [-BackupContentWindowsIncludedPaths <String[]>]
 [-FileVersionDailyVersions <Int64>] [-FileVersionDays <Int64>] [-FileVersionMonthlyVersions <Int64>]
 [-FileVersionVersions <Int64>] [-FileVersionWeeklyVersions <Int64>] [-GeneralOptimizedForCloudBackups]
 [-NetworkResourceThrottleReceive <Int64>] [-NetworkResourceThrottleSend <Int64>] [-NewName <String>]
 [-OfflineLaptopDeleteAfterDays <Int64>] [-OfflineLaptopRetireAfterDays <Int64>]
 [-OverrideRestrictionBackupContent <String>] [-OverrideRestrictionRetention <String>]
 [-OverrideRestrictionRpo <String>] [-OverrideRestrictionStoragePool <String>] [-RegionToConfigureId <Int64>]
 [-RegionToConfigureName <String>] [-RetentionDeletedItemRetention <Int64>] [-RpoBackupFrequency <Int64>]
 [-SlaEnableAfterDelay <Int64>] [-SlaExcludeFromSla] [-SlaExclusionReason <String>] [-SlaPeriod <Int64>]
 [-SlaUseSystemDefaultSla] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Modify existing laptop plan details

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -Alerts
.
To construct, see NOTES section for ALERTS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedFeatures
Create/modify allowed features of laptop plan
To construct, see NOTES section for ALLOWEDFEATURES properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ILaptopPlanAllowedFeatures
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowPlanOverride
Flag to enable overriding of plan

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssociatedUsersAndUserGroups
.
To construct, see NOTES section for ASSOCIATEDUSERSANDUSERGROUPS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IPlanUserOrGroups[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupContentFileSystemQuota
Maximum number of gigabytes that you can store in the File System.
Giving value as -1 means infinite file system quota.

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupContentMacExcludedPaths
Paths to exclude for Mac

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupContentMacIncludedPaths
Paths to include for Mac

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupContentUnixExcludedPaths
Paths to exclude for UNIX

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupContentUnixIncludedPaths
Paths to include for UNIX

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupContentWindowsExcludedPaths
Paths to exclude for Windows

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupContentWindowsIncludedPaths
Paths to include for Windows

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileVersionDailyVersions
Custom version rule: Retain daily versions for this many day(s)

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileVersionDays
Retain files for this many days.
Year(s) or month(s) need to be converted to day(s)

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileVersionMonthlyVersions
Custom version rule: Retain monthly versions for this many month(s)

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileVersionVersions
Retain this many file versions.
This is considered as default if no file retention rule is specified.

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileVersionWeeklyVersions
Custom version rule: Retain weekly versions for this many week(s)

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GeneralOptimizedForCloudBackups
This feature allows laptops to write backup directly to the cloud storage.
It helps to optimize scale by reducing server dependency and extra data hops.
Once the feature is enabled, the existing and the newly-added laptops use optimized backups.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICommvaultPowerShellIdentity
Parameter Sets: UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NetworkResourceThrottleReceive
Maximum kilobits per second to throttle the receiving speed of data.
Giving value as -1 means infinite throttle send speed i.e.
no limit

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkResourceThrottleSend
Maximum kilobits per second to throttle the emitting speed of data.
Giving value as -1 means infinite throttle send speed i.e.
no limit

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewName
New plan name to update

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OfflineLaptopDeleteAfterDays
The offline laptops are automatically deleted when the number of days are met.
-1 means never.

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OfflineLaptopRetireAfterDays
The offline laptops are retired when the number of days are met.
-1 means never.

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OverrideRestrictionBackupContent
.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OverrideRestrictionRetention
.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OverrideRestrictionRpo
.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OverrideRestrictionStoragePool
.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanId
Id of the plan

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegionToConfigureId
.

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegionToConfigureName
.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RetentionDeletedItemRetention
Amount of days after deletion of files to keep the items.
Giving value as -1 means to retain files indefinitely.

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RpoBackupFrequency
Specify incremental backup frequency in minutes.
Backup operation will start as per the time zone of the associated server.

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SlaEnableAfterDelay
Time provided in Unix format.
Give 0 to reset any existing delay.

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SlaExcludeFromSla
Flag to set to exclude plan from SLA

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SlaExclusionReason
Reason for exclusion from SLA

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SlaPeriod
SLA Period in Days

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SlaUseSystemDefaultSla
Flag to set to use System Default Service Level Agreement

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Commvault.Powershell.Models.ICommvaultPowerShellIdentity

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ALERTS <IIdName[]>`: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`ALLOWEDFEATURES <ILaptopPlanAllowedFeatures>`: Create/modify allowed features of laptop plan
  - `[Archiving <Boolean?>]`: Flag to enable archiving of laptop data
  - `[ArchivingRuleAfterArchiving <String>]`: After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving rules
  - `[ArchivingRuleArchiveReadOnlyFiles <Boolean?>]`: To archive files based on the Read-Only attribute, set to TRUE
  - `[ArchivingRuleFileAccessTimeOlderThan <Int64?>]`: To archive files based on the last accessed date of each file within the folder, specify the number of days
  - `[ArchivingRuleFileCreatedTimeOlderThan <Int64?>]`: To archive files based on the time the files were created within the folder, specify the number of days
  - `[ArchivingRuleFileModifiedTimeOlderThan <Int64?>]`: To archive files based on the last modified date of each file within the folder, specify the number of days
  - `[ArchivingRuleFileSizeGreaterThan <Int64?>]`: To archive files based on the size of the file, specify the minimum file size in KB. All files whose size ranges between the minimum and maximum values are archived.
  - `[ArchivingRuleMaximumFileSize <Int64?>]`: To archive files based on the size of the file, specify the maximum file size in KB. All files whose size ranges between the minimum and maximum values are archived.
  - `[ArchivingRuleStartCleaningIfLessThan <Int64?>]`: When free disk space falls below specified amount (in percentage), start cleaning up the disk
  - `[ArchivingRuleStopCleaningIfupto <Int64?>]`: When free disk space more than specified amount (in percentage), stop cleaning up the disk
  - `[ClientId <Int64?>]`: 
  - `[ClientName <String>]`: 
  - `[Dlp <Boolean?>]`: Flag to enable Data loss protection
  - `[EdgeDrive <Boolean?>]`: Flag to enable Edge Drive
  - `[EdgeDriveSettingAuditDriveOperations <Boolean?>]`: Enable auditing which logs the activities based on user interaction like creating, editing, moving, renaming, downloading or deleting files.
  - `[EdgeDriveSettingCreateNewIndexServer <Boolean?>]`: If set to false, uses existing edge index server and requires IndexServer IdName to be passed. If set to true, requires client IdName and indexCachePath to create a new Index Server.
  - `[EdgeDriveSettingEdgeDriveQuota <Int64?>]`: Maximum number of gigabytes that you can store in the Edge Drive. Giving value as -1 means no quota.
  - `[EdgeDriveSettingIndexCachePath <String>]`: 
  - `[EdgeDriveSettingNotificationsForShares <Boolean?>]`: Enables alert notification feature which allows the share user or share owner to subscribe for share notifications when any activities are performed on the Edge Drive or the Collaborative share. The user can receive the notifications on the Web Console or as an email notification.
  - `[IndexServerId <Int64?>]`: 
  - `[IndexServerName <String>]`: 

`ASSOCIATEDUSERSANDUSERGROUPS <IPlanUserOrGroups[]>`: .
  - `[Id <Int64?>]`: This gives Id of user or user group or external user group
  - `[Name <String>]`: This gives name of user or user group or external user group
  - `[SendInvite <Boolean?>]`: If set to true, will send an invite email to the user or group. Default is true.
  - `[Type <String>]`: Tells what kind of user or user group it is

`INPUTOBJECT <ICommvaultPowerShellIdentity>`: Identity Parameter
  - `[AccessPathId <Int64?>]`: Id of the mount path whose access path has to be deleted
  - `[AgentId <Int64?>]`: Id of the agent to be modified
  - `[BackupDestinationId <Int64?>]`: Id of the backupDestination to be modified
  - `[BackupLocationId <Int64?>]`: Id of the backup location whose details have to be fetched
  - `[BlackoutWindowId <Int64?>]`: Id of the Blackout Window whose details have to be fetched
  - `[BucketId <Int64?>]`: Id of Bucket
  - `[CloudStorageId <Int64?>]`: Id of cloud Storage
  - `[CompanyId <Int64?>]`: Id of the Company whose details have to be fetched
  - `[CredentialName <String>]`: 
  - `[DomainId <Int64?>]`: ID of the AD/LDAP domain
  - `[EntityId <Int64?>]`: Unique id for the entity
  - `[EntityType <Int64?>]`: Type of the entity
  - `[GlobalSearchEntity <String>]`: name of global search entity
  - `[HfsShareId <Int64?>]`: Id of the HFS Share to fetch its status
  - `[HyperScaleStorageId <Int64?>]`: Id of hyperscale storage
  - `[HypervisorId <Int64?>]`: Id of the Hypervisor to update
  - `[Id <Int64?>]`: 
  - `[InstanceId <Int64?>]`: Id of the instance to modify
  - `[InventoryEntityName <String>]`: Name of the inventory entity that needs to be browsed like ESX Host name in VCenter
  - `[KmsId <Int64?>]`: Id of Key Management Server
  - `[MediaAgentId <Int64?>]`: Id of the Media Agent whose details have to be fetched
  - `[MetadataCacheId <Int64?>]`: Id of metadata cache
  - `[Name <String>]`: 
  - `[NodeId <Int64?>]`: Id of node
  - `[PairId <Int64?>]`: 
  - `[PlanId <Int64?>]`: Id of the plan to fetch details
  - `[RecoveryTargetId <Int64?>]`: id of recovery target
  - `[RegionId <Int64?>]`: 
  - `[RegionList <String>]`: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  - `[ReplicationGroupId <String>]`: 
  - `[RequestId <Int64?>]`: Unique identifier for the request
  - `[RoleId <Int64?>]`: Role Id
  - `[RpsId <String>]`: 
  - `[RuleId <Int64?>]`: Id of the rule to update in Plan
  - `[ScheduleId <String>]`: 
  - `[SchedulePolicyId <String>]`: 
  - `[ServerGroupId <Int64?>]`: Id of the serverGroupId whose details have to be fetched
  - `[ServerId <Int64?>]`: Id of the server to modify
  - `[StoragePoolId <Int64?>]`: Id of the disk storage pool whose details have to be fetched
  - `[SubclientId <Int64?>]`: Id of the subclient to modify
  - `[TopologyId <String>]`: 
  - `[UserGroupId <Int64?>]`: Id of the user-group whose details have to be fetched
  - `[UserId <Int64?>]`: Id of the User whose details have to be fetched
  - `[VMGroupId <Int64?>]`: Id of the VMgroup to update
  - `[VMUuid <String>]`: The vmUUID can be obtained from GET /virtualMachines UUID property

## RELATED LINKS

