---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/new-cvcdmplan
schema: 2.0.0
---

# New-CVCdmPlan

## SYNOPSIS
Create a CDM Plan

## SYNTAX

```
New-CVCdmPlan [-BackupCopyOptionAction <String>] [-BackupCopyOptionAlertInHours <Int64>]
 [-BackupCopyOptionBackupFullToCopy <String>] [-BackupCopyOptionBackupTypeToCopy <String>]
 [-BackupCopyOptionEnableAlert] [-BackupCopyOptionSkipAfterThresholdDays <Int64>]
 [-BackupCopyOptionStartTime <Int64>] [-BackupDestinations <ICreatePlanBackupDestination[]>]
 [-BackupFrequencyOperationType <String>] [-BackupFrequencySchedules <IPlanSchedule[]>]
 [-DatabaseOptionCommitFrequencyInHours <Int64>] [-DatabaseOptionLogBackupRpoMins <Int64>]
 [-DatabaseOptionUseDiskCacheForLogBackups] [-PlanName <String>] [-RpoBackupWindow <IDayAndTime[]>]
 [-RpoFullBackupWindow <IDayAndTime[]>] [-SnapshotOptionBackupCopyRpoMins <Int64>]
 [-SnapshotOptionEnableBackupCopy] [-SnapshotOptionEnableSnapCatalog]
 [-SnapshotOptionRetentionPeriodDays <Int64>] [-SnapshotOptionSnapRecoveryPoints <Int64>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a CDM Plan

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

{{ Add description here }}

## PARAMETERS

### -BackupCopyOptionAction
Which type of action should be followed if backup copy falls behind

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

### -BackupCopyOptionAlertInHours
Alert to throw when backup copy falls behind in hours

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

### -BackupCopyOptionBackupFullToCopy
Which type of backup type should be copied for the given backup destination when backup type is not all jobs.
Default is LAST while adding new backup destination.

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

### -BackupCopyOptionBackupTypeToCopy
Backup type to copy for backup copy operation

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

### -BackupCopyOptionEnableAlert
Flag to enable backup copy fallen behind alert

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

### -BackupCopyOptionSkipAfterThresholdDays
The allowable delay in days before a backup copy job is considered overdue

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

### -BackupCopyOptionStartTime
Snapshots to be copied from a particular time in unix time format.
By default, 0 means since the inception of the snap copy.

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

### -BackupDestinations
Copy destinations for the plan.
Specify where you want to store your data.

```yaml
Type: Commvault.Powershell.Models.ICreatePlanBackupDestination[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupFrequencyOperationType
Operation type for the list

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

### -BackupFrequencySchedules
.

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

### -PlanName
Name of the new plan

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

### -SnapshotOptionEnableSnapCatalog
Flag to enable deferred snapshot cataloging

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

### -SnapshotOptionRetentionPeriodDays
Retention period in days.
-1 can be specified for infinite retention.
If this and snapRecoveryPoints both are not specified, this takes precedence.

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

### -SnapshotOptionSnapRecoveryPoints
Number of snap recovery points for default snap copy for retention.
Can be specified instead of retention period in Days for default snap copy.

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

## OUTPUTS

### Commvault.Powershell.Models.IPlanResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BACKUPDESTINATIONS <ICreatePlanBackupDestination[]>`: Copy destinations for the plan. Specify where you want to store your data.
  - `BackupDestinationName <String>`: Backup destination details. Enter the name during creation.
  - `[BackupStartTime <Int64?>]`: Backup start time in seconds. The time is provided in unix time format.
  - `[BackupsToCopy <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[FirstExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[FirstExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[FirstExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[FullBackupTypesToCopy <String>]`: Which type of backup type should be copied for the given backup destination when backup type is not all jobs. Default is LAST while adding new backup destination.
  - `[IsConfiguredForReplication <Boolean?>]`: Used if the copy is used for replication group
  - `[IsMirrorCopy <Boolean?>]`: Is this a mirror copy? Only considered when isSnapCopy is true.
  - `[IsSnapCopy <Boolean?>]`: Is this a snap copy? If isMirrorCopy is not set, then default is Vault/Replica.
  - `[Mappings <List<ISnapshotCopyMapping>>]`: 
    - `[MappingType <String>]`: Mapping type for pure storage replicaton
    - `[SourceId <Int64?>]`: 
    - `[SourceName <String>]`: 
    - `[SourceVendorId <Int64?>]`: 
    - `[SourceVendorName <String>]`: 
    - `[Subclients <List<IIdName>>]`: 
      - `[Id <Int64?>]`: 
      - `[Name <String>]`: 
    - `[TargetId <Int64?>]`: 
    - `[TargetName <String>]`: 
    - `[TargetVendorId <Int64?>]`: 
    - `[TargetVendorName <String>]`: 
    - `[Vendor <String>]`: Snapshot vendors available for Snap Copy mappings
  - `[NetAppCloudTarget <Boolean?>]`: Only for snap copy. Enabling this changes SVM Mapping  to NetApp cloud targets only.
  - `[OptimizeForInstantClone <Boolean?>]`: Flag to specify if primary storage is copy data management enabled.
  - `[OverrideRetentionSettings <Boolean?>]`: Tells if this copy should use storage pool retention period days or the retention defined for this copy. Set as true to use retention defined on this copy.
  - `[RegionGuid <String>]`: 
  - `[RegionId <Int64?>]`: 
  - `[RegionName <String>]`: 
  - `[RetentionPeriodDays <Int64?>]`: Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified, this takes  precedence.
  - `[RetentionRuleType <String>]`: Which type of retention rule should be used for the given backup destination
  - `[SecondExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[SecondExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[SecondExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[SnapRecoveryPoints <Int64?>]`: Number of snap recovery points for snap copy for retention. Can be specified instead of retention period in Days for snap copy.
  - `[SourceCopyId <Int64?>]`: 
  - `[SourceCopyName <String>]`: 
  - `[StoragePoolId <Int64?>]`: 
  - `[StoragePoolName <String>]`: 
  - `[StorageTemplateTags <List<IIdNameValue>>]`: It is used in Global config template plan creation. Needs in plan creation on global commcell
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 
    - `[Value <String>]`: 
  - `[StorageType <String>]`: StorageType
  - `[ThirdExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[ThirdExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[ThirdExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[UseExtendedRetentionRules <Boolean?>]`: Use extended retention rules

`BACKUPFREQUENCYSCHEDULES <IPlanSchedule[]>`: .
  - `BackupType <String>`: Schedule Backup level
  - `SchedulePatternScheduleFrequencyType <String>`: schedule frequency type
  - `[AdditionalInfo <String>]`: 
  - `[ForDatabasesOnly <Boolean?>]`: Boolean to indicate if schedule is for database agents
  - `[IsRetentionBasedSyntheticFull <Boolean?>]`: Boolean to indicate if synthetic full schedule is based on retention rules
  - `[PolicyId <Int64?>]`: Schedule policy Id to which the schedule belongs
  - `[ScheduleId <Int64?>]`: Id of the schedule if available, required for modifying, deleting schedule
  - `[ScheduleName <String>]`: Name of the schedule, for modify
  - `[ScheduleOperation <String>]`: Operation being performed on schedule
  - `[ScheduleOptionCommitFrequencyInHours <Int64?>]`: Commit frequency in hours for disk cache backups from automatic schedules
  - `[ScheduleOptionDaysBetweenAutoConvert <Int64?>]`: Number of days between auto conversion of backup level applicable for databases on incremental and differential schedules of server plan
  - `[ScheduleOptionJobRunningTimeInMins <Int64?>]`: total job running time in minutes
  - `[ScheduleOptionLogFilesThreshold <Int64?>]`: The min number of archived log files before a backup job should start
  - `[ScheduleOptionLogsDiskUtilizationPercent <Int64?>]`: The min log destination disk threshold percentage
  - `[ScheduleOptionMinBackupIntervalInMins <Int64?>]`: The min number of mins to check for file activity on automatic schedule.
  - `[ScheduleOptionO365ItemSelectionOption <String>]`: item backup option for O365 V2 backup jobs
  - `[ScheduleOptionUseDiskCacheForLogBackups <Boolean?>]`: Used to enable disk caching feature on databases for automatic schedules on server plan
  - `[SchedulePatternDayOfMonth <Int64?>]`: Day on which to run the schedule, applicable for monthly, yearly
  - `[SchedulePatternDayOfWeek <String>]`: 
  - `[SchedulePatternDaysBetweenSyntheticFulls <Int64?>]`: No of days between two synthetic full jobs
  - `[SchedulePatternEndDate <Int64?>]`: Schedule end date in epoch format
  - `[SchedulePatternExceptions <List<IScheduleRunException>>]`: Exceptions to when a schedule should not run, either in dates or week of month and days
    - `[OnDates <List<Int64>>]`: list of dates in a month. For ex: 1, 20
    - `[OnDayOfTheWeek <List<String>>]`: On which days, for ex: MONDAY, FRIDAY
    - `[OnWeekOfTheMonth <List<String>>]`: On which week of month, for ex: FIRST, LAST
  - `[SchedulePatternFrequency <Int64?>]`: Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
  - `[SchedulePatternMaxBackupIntervalInMins <Int64?>]`: The number of mins to force a backup on automatic schedule.
  - `[SchedulePatternMonthOfYear <String>]`: 
  - `[SchedulePatternNoOfTimes <Int64?>]`: The number of times you want the schedule to run.
  - `[SchedulePatternRepeatIntervalInMinutes <Int64?>]`: How often in minutes in a day the schedule runs, applicable for daily, weekly, monthly and yearly frequency types.
  - `[SchedulePatternRepeatUntilTime <Int64?>]`: Until what time to repeat the schedule in a day, requires repeatIntervalInMinutes
  - `[SchedulePatternStartDate <Int64?>]`: start date of schedule in epoch format
  - `[SchedulePatternStartTime <Int64?>]`: start time of schedule in seconds
  - `[SchedulePatternWeekOfMonth <String>]`: Specific week of a month
  - `[SchedulePatternWeeklyDays <List<String>>]`: Days of the week for weekly frequency
  - `[TimezoneId <Int64?>]`: 
  - `[TimezoneName <String>]`: 
  - `[VMOperationType <String>]`: Type of DR operation (only applicable for Failover groups)

`RPOBACKUPWINDOW <IDayAndTime[]>`: Backup window for incremental backup
  - `[DayOfWeek <List<String>>]`: 
  - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day

`RPOFULLBACKUPWINDOW <IDayAndTime[]>`: Backup window for full backup
  - `[DayOfWeek <List<String>>]`: 
  - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day

## RELATED LINKS

