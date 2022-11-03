---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-cvplan
schema: 2.0.0
---

# Set-CVPlan

## SYNOPSIS
Used to modify an exsiting server plan

## SYNTAX

### UpdateExpanded (Default)
```
Set-CVPlan -PlanId <Int64> [-AllowPlanOverride] [-BackupContentBackupSystemState]
 [-BackupContentBackupSystemStateOnlyWithFullBackup] [-BackupContentMacExcludedPaths <String[]>]
 [-BackupContentMacIncludedPaths <String[]>] [-BackupContentUnixExcludedPaths <String[]>]
 [-BackupContentUnixIncludedPaths <String[]>] [-BackupContentUseVssForSystemState]
 [-BackupContentWindowsExcludedPaths <String[]>] [-BackupContentWindowsIncludedPaths <String[]>]
 [-BackupFrequencySchedules <IPlanSchedule[]>] [-DatabaseOptionCommitFrequencyInHours <Int64>]
 [-DatabaseOptionLogBackupRpoMins <Int64>] [-DatabaseOptionRunFullBackupEvery <Int64>]
 [-DatabaseOptionUseDiskCacheForLogBackups] [-NewName <String>] [-OverrideInheritSettingBackupContent]
 [-OverrideInheritSettingBackupDestination] [-OverrideInheritSettingRpo]
 [-OverrideRestrictionBackupContent <String>] [-OverrideRestrictionRpo <String>]
 [-OverrideRestrictionStoragePool <String>] [-RegionToConfigureId <Int64>] [-RegionToConfigureName <String>]
 [-RpoBackupWindow <IDayAndTime[]>] [-RpoFullBackupWindow <IDayAndTime[]>] [-SlaEnableAfterDelay <Int64>]
 [-SlaExcludeFromSla] [-SlaExclusionReason <String>] [-SlaPeriod <Int64>] [-SlaUseSystemDefaultSla]
 [-SnapshotOptionBackupCopyRpoMins <Int64>] [-SnapshotOptionEnableBackupCopy] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Set-CVPlan -InputObject <ICommvaultPowerShellIdentity> [-AllowPlanOverride] [-BackupContentBackupSystemState]
 [-BackupContentBackupSystemStateOnlyWithFullBackup] [-BackupContentMacExcludedPaths <String[]>]
 [-BackupContentMacIncludedPaths <String[]>] [-BackupContentUnixExcludedPaths <String[]>]
 [-BackupContentUnixIncludedPaths <String[]>] [-BackupContentUseVssForSystemState]
 [-BackupContentWindowsExcludedPaths <String[]>] [-BackupContentWindowsIncludedPaths <String[]>]
 [-BackupFrequencySchedules <IPlanSchedule[]>] [-DatabaseOptionCommitFrequencyInHours <Int64>]
 [-DatabaseOptionLogBackupRpoMins <Int64>] [-DatabaseOptionRunFullBackupEvery <Int64>]
 [-DatabaseOptionUseDiskCacheForLogBackups] [-NewName <String>] [-OverrideInheritSettingBackupContent]
 [-OverrideInheritSettingBackupDestination] [-OverrideInheritSettingRpo]
 [-OverrideRestrictionBackupContent <String>] [-OverrideRestrictionRpo <String>]
 [-OverrideRestrictionStoragePool <String>] [-RegionToConfigureId <Int64>] [-RegionToConfigureName <String>]
 [-RpoBackupWindow <IDayAndTime[]>] [-RpoFullBackupWindow <IDayAndTime[]>] [-SlaEnableAfterDelay <Int64>]
 [-SlaExcludeFromSla] [-SlaExclusionReason <String>] [-SlaPeriod <Int64>] [-SlaUseSystemDefaultSla]
 [-SnapshotOptionBackupCopyRpoMins <Int64>] [-SnapshotOptionEnableBackupCopy] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Used to modify an exsiting server plan

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

### -AllowPlanOverride
Flag to enable overriding of plan.
Once enabled, cannot be disabled.

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

### -BackupContentBackupSystemState
Do you want to back up the system state Applicable only for Windows

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

### -BackupContentBackupSystemStateOnlyWithFullBackup
Do you want to back up system state only with full backup Applicable only if the value of backupSystemState is true

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

### -BackupContentUseVssForSystemState
Do you want to back up system state with VSS Applicable only if the value of backupSystemState is true

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

### -BackupFrequencySchedules
.
To construct, see NOTES section for BACKUPFREQUENCYSCHEDULES properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IPlanSchedule[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DatabaseOptionCommitFrequencyInHours
Commit frequency in hours

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

### -DatabaseOptionLogBackupRpoMins
Log backup RPO in minutes

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

### -DatabaseOptionRunFullBackupEvery
Full backup frequency in days

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

### -DatabaseOptionUseDiskCacheForLogBackups
Use disk cache for log backups

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

### -OverrideInheritSettingBackupContent
Flag to specify if parent or derived plan backupContent should be used when inherit mode is optional.
True - derived, False - Base.

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

### -OverrideInheritSettingBackupDestination
Flag to specify if parent or derived plan backupDestination should be used when inherit mode is optional.
True - derived, False - Base.

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

### -OverrideInheritSettingRpo
Flag to specify if parent or derived plan rpo should be used when inherit mode is optional.
True - derived, False - Base.

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

### -PassThru
Returns true when the command succeeds

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

### -PlanId
Id of the Plan to update

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

### -RpoBackupWindow
Backup window for incremental backup
To construct, see NOTES section for RPOBACKUPWINDOW properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IDayAndTime[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RpoFullBackupWindow
Backup window for full backup
To construct, see NOTES section for RPOFULLBACKUPWINDOW properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IDayAndTime[]
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

### -SnapshotOptionBackupCopyRpoMins
Backup copy RPO in minutes

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

### -SnapshotOptionEnableBackupCopy
Flag to enable backup copy

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


`BACKUPFREQUENCYSCHEDULES <IPlanSchedule[]>`: .
  - `BackupType <String>`: Schedule Backup level
  - `ForDatabasesOnly <Boolean>`: Boolean to indicate if schedule is for database agents
  - `ScheduleOperation <String>`: Operation being performed on schedule
  - `SchedulePatternScheduleFrequencyType <String>`: schedule frequency type
  - `[PolicyId <Int64?>]`: Schedule policy Id to which the schedule belongs
  - `[ScheduleId <Int64?>]`: Id of the schedule if available, required for modifying, deleting schedule
  - `[ScheduleName <String>]`: Name of the schedule, for modify
  - `[SchedulePatternDayOfMonth <Int64?>]`: Day on which to run the schedule, applicable for monthly, yearly
  - `[SchedulePatternDayOfWeek <String>]`: 
  - `[SchedulePatternDaysBetweenSyntheticFulls <Int64?>]`: No of days between two synthetic full jobs
  - `[SchedulePatternEndDate <Int64?>]`: Schedule end date in epoch format
  - `[SchedulePatternExceptions <IScheduleRunException[]>]`: Exceptions to when a schedule should not run, either in dates or week of month and days
    - `[OnDates <Int64[]>]`: list of dates in a month. For ex: 1, 20
    - `[OnDayOfTheWeek <String[]>]`: On which days, for ex: MONDAY, FRIDAY
    - `[OnWeekOfTheMonth <String[]>]`: On which week of month, for ex: FIRST, LAST
  - `[SchedulePatternFrequency <Int64?>]`: Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
  - `[SchedulePatternMonthOfYear <String>]`: 
  - `[SchedulePatternNoOfTimes <Int64?>]`: The number of times you want the schedule to run.
  - `[SchedulePatternRepeatIntervalInMinutes <Int64?>]`: How often in minutes in a day the schedule runs, applicable for daily, weekly, monthly and yearly frequency types.
  - `[SchedulePatternRepeatUntilTime <Int64?>]`: Until what time to repeat the schedule in a day, requires repeatIntervalInMinutes
  - `[SchedulePatternStartDate <Int64?>]`: start date of schedule in epoch format
  - `[SchedulePatternStartTime <Int64?>]`: start time of schedule in seconds
  - `[SchedulePatternWeekOfMonth <String>]`: Specific week of a month
  - `[SchedulePatternWeeklyDays <String[]>]`: Days of the week for weekly frequency
  - `[TimezoneId <Int64?>]`: 
  - `[TimezoneName <String>]`: 

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

`RPOBACKUPWINDOW <IDayAndTime[]>`: Backup window for incremental backup
  - `[DayOfWeek <String[]>]`: 
  - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day

`RPOFULLBACKUPWINDOW <IDayAndTime[]>`: Backup window for full backup
  - `[DayOfWeek <String[]>]`: 
  - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day

## RELATED LINKS

