---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-serverplan
schema: 2.0.0
---

# New-ServerPlan

## SYNOPSIS
Create a Server Plan

## SYNTAX

### Create (Default)
```
New-ServerPlan -Body <ICreateServerPlan> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded
```
New-ServerPlan -BackupDestinations <ICreatePlanBackupDestination[]> -PlanName <String> [-AllowPlanOverride]
 [-BackupContentBackupSystemState] [-BackupContentBackupSystemStateOnlyWithFullBackup]
 [-BackupContentMacExcludedPaths <String[]>] [-BackupContentMacIncludedPaths <String[]>]
 [-BackupContentUnixExcludedPaths <String[]>] [-BackupContentUnixIncludedPaths <String[]>]
 [-BackupContentUseVssForSystemState] [-BackupContentWindowsExcludedPaths <String[]>]
 [-BackupContentWindowsIncludedPaths <String[]>] [-BackupFrequencySchedules <IPlanSchedule[]>]
 [-DatabaseOptionCommitFrequencyInHours <Int32>] [-DatabaseOptionLogBackupRpoMins <Int32>]
 [-DatabaseOptionUseDiskCacheForLogBackups] [-OverrideRestrictionBackupContent <String>]
 [-OverrideRestrictionRpo <String>] [-OverrideRestrictionStoragePool <String>] [-ParentPlanId <Int32>]
 [-ParentPlanName <String>] [-RpoBackupWindow <IDayAndTime[]>] [-RpoFullBackupWindow <IDayAndTime[]>]
 [-SnapshotOptionBackupCopyRpoMins <Int32>] [-SnapshotOptionEnableBackupCopy]
 [-SnapshotOptionRetentionPeriodDays <Int32>] [-SnapshotOptionSnapRecoveryPoints <Int32>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a Server Plan

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AllowPlanOverride
Flag to enable overriding of plan.
Plan cannot be overriden by default.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupDestinations
Backup destinations for the plan.
Specify where you want to store your backup data.
To construct, see NOTES section for BACKUPDESTINATIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICreatePlanBackupDestination[]
Parameter Sets: CreateExpanded
Aliases:

Required: True
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICreateServerPlan
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DatabaseOptionCommitFrequencyInHours
Commit frequency in hours

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
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
Type: System.Int32
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentPlanId
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentPlanName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: True
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Type: System.Int32
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Type: System.Int32
Parameter Sets: CreateExpanded
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
Type: System.Int32
Parameter Sets: CreateExpanded
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

### Commvault.Powershell.Models.ICreateServerPlan

## OUTPUTS

### Commvault.Powershell.Models.IPlanResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BACKUPDESTINATIONS <ICreatePlanBackupDestination[]>: Backup destinations for the plan. Specify where you want to store your backup data.
  - `BackupDestinationName <String>`: Backup destination details. Enter the name during creation.
  - `[BackupStartTime <Int32?>]`: Backup start time in seconds. The time is provided in unix time format.
  - `[BackupsToCopy <String>]`: 
  - `[FirstExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: 
  - `[FirstExtendedRetentionRuleRetentionPeriodDays <Int32?>]`: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
  - `[FirstExtendedRetentionRuleType <String>]`: 
  - `[IsMirrorCopy <Boolean?>]`: Is this a mirror copy? Only considered when isSnapCopy is true.
  - `[IsSnapCopy <Boolean?>]`: Is this a snap copy? If isMirrorCopy is not set, then default is Vault/Replica.
  - `[Mappings <ISnapshotCopyMapping[]>]`: 
    - `[SourceId <Int32?>]`: 
    - `[SourceName <String>]`: 
    - `[TargetId <Int32?>]`: 
    - `[TargetName <String>]`: 
    - `[Vendor <String>]`: Snapshot vendors available for Snap Copy mappings
  - `[NetAppCloudTarget <Boolean?>]`: Only for snap copy. Enabling this changes SVM Mapping  to NetApp cloud targets only.
  - `[OptimizeForInstantClone <Boolean?>]`: Flag to specify if primary storage is copy data management enabled.
  - `[RegionId <Int32?>]`: 
  - `[RegionName <String>]`: 
  - `[RetentionPeriodDays <Int32?>]`: Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified, this takes  precedence.
  - `[RetentionRuleType <String>]`: Which type of retention rule should be used for the given backup destination
  - `[SecondExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: 
  - `[SecondExtendedRetentionRuleRetentionPeriodDays <Int32?>]`: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
  - `[SecondExtendedRetentionRuleType <String>]`: 
  - `[SnapRecoveryPoints <Int32?>]`: Number of snap recovery points for snap copy for retention. Can be specified instead of retention period in Days for snap copy.
  - `[SourceCopyId <Int32?>]`: 
  - `[SourceCopyName <String>]`: 
  - `[StoragePoolId <Int32?>]`: 
  - `[StoragePoolName <String>]`: 
  - `[ThirdExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: 
  - `[ThirdExtendedRetentionRuleRetentionPeriodDays <Int32?>]`: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
  - `[ThirdExtendedRetentionRuleType <String>]`: 
  - `[UseExtendedRetentionRules <Boolean?>]`: Use extended retention rules

BACKUPFREQUENCYSCHEDULES <IPlanSchedule[]>: .
  - `BackupType <String>`: Schedule Backup level
  - `ForDatabasesOnly <Boolean>`: Boolean to indicate if schedule is for database agents
  - `ScheduleOperation <String>`: Operation being performed on schedule
  - `SchedulePatternScheduleFrequencyType <String>`: schedule frequency type
  - `[PolicyId <Int32?>]`: Schedule policy Id to which the schedule belongs
  - `[ScheduleId <Int32?>]`: Id of the schedule if available, required for modifying, deleting schedule
  - `[ScheduleName <String>]`: Name of the schedule, for modify
  - `[SchedulePatternDayOfMonth <Int32?>]`: Day on which to run the schedule, applicable for monthly, yearly
  - `[SchedulePatternDayOfWeek <String>]`: 
  - `[SchedulePatternDaysBetweenSyntheticFulls <Int32?>]`: No of days between two synthetic full jobs
  - `[SchedulePatternEndDate <Int32?>]`: Schedule end date in epoch format
  - `[SchedulePatternExceptions <IScheduleRunException[]>]`: Exceptions to when a schedule should not run, either in dates or week of month and days
    - `[OnDates <Int32[]>]`: list of dates in a month. For ex: 1, 20
    - `[OnDayOfTheWeek <String[]>]`: On which days, for ex: MONDAY, FRIDAY
    - `[OnWeekOfTheMonth <String[]>]`: On which week of month, for ex: FIRST, LAST
  - `[SchedulePatternFrequency <Int32?>]`: Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
  - `[SchedulePatternMonthOfYear <String>]`: 
  - `[SchedulePatternNoOfTimes <Int32?>]`: The number of times you want the schedule to run.
  - `[SchedulePatternRepeatIntervalInMinutes <Int32?>]`: How often in minutes in a day the schedule runs, applicable for daily, weekly, monthly and yearly frequency types.
  - `[SchedulePatternRepeatUntilTime <Int32?>]`: Until what time to repeat the schedule in a day, requires repeatIntervalInMinutes
  - `[SchedulePatternStartDate <Int32?>]`: start date of schedule in epoch format
  - `[SchedulePatternStartTime <Int32?>]`: start time of schedule in seconds
  - `[SchedulePatternWeekOfMonth <String>]`: Specific week of a month
  - `[SchedulePatternWeeklyDays <String[]>]`: Days of the week for weekly frequency
  - `[TimezoneId <Int32?>]`: 
  - `[TimezoneName <String>]`: 

BODY <ICreateServerPlan>: .
  - `BackupDestinations <ICreatePlanBackupDestination[]>`: Backup destinations for the plan. Specify where you want to store your backup data.
    - `BackupDestinationName <String>`: Backup destination details. Enter the name during creation.
    - `[BackupStartTime <Int32?>]`: Backup start time in seconds. The time is provided in unix time format.
    - `[BackupsToCopy <String>]`: 
    - `[FirstExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: 
    - `[FirstExtendedRetentionRuleRetentionPeriodDays <Int32?>]`: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
    - `[FirstExtendedRetentionRuleType <String>]`: 
    - `[IsMirrorCopy <Boolean?>]`: Is this a mirror copy? Only considered when isSnapCopy is true.
    - `[IsSnapCopy <Boolean?>]`: Is this a snap copy? If isMirrorCopy is not set, then default is Vault/Replica.
    - `[Mappings <ISnapshotCopyMapping[]>]`: 
      - `[SourceId <Int32?>]`: 
      - `[SourceName <String>]`: 
      - `[TargetId <Int32?>]`: 
      - `[TargetName <String>]`: 
      - `[Vendor <String>]`: Snapshot vendors available for Snap Copy mappings
    - `[NetAppCloudTarget <Boolean?>]`: Only for snap copy. Enabling this changes SVM Mapping  to NetApp cloud targets only.
    - `[OptimizeForInstantClone <Boolean?>]`: Flag to specify if primary storage is copy data management enabled.
    - `[RegionId <Int32?>]`: 
    - `[RegionName <String>]`: 
    - `[RetentionPeriodDays <Int32?>]`: Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified, this takes  precedence.
    - `[RetentionRuleType <String>]`: Which type of retention rule should be used for the given backup destination
    - `[SecondExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: 
    - `[SecondExtendedRetentionRuleRetentionPeriodDays <Int32?>]`: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
    - `[SecondExtendedRetentionRuleType <String>]`: 
    - `[SnapRecoveryPoints <Int32?>]`: Number of snap recovery points for snap copy for retention. Can be specified instead of retention period in Days for snap copy.
    - `[SourceCopyId <Int32?>]`: 
    - `[SourceCopyName <String>]`: 
    - `[StoragePoolId <Int32?>]`: 
    - `[StoragePoolName <String>]`: 
    - `[ThirdExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: 
    - `[ThirdExtendedRetentionRuleRetentionPeriodDays <Int32?>]`: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
    - `[ThirdExtendedRetentionRuleType <String>]`: 
    - `[UseExtendedRetentionRules <Boolean?>]`: Use extended retention rules
  - `PlanName <String>`: Name of the new plan
  - `[AllowPlanOverride <Boolean?>]`: Flag to enable overriding of plan. Plan cannot be overriden by default.
  - `[BackupContentBackupSystemState <Boolean?>]`: Do you want to back up the system state? Applicable only for Windows
  - `[BackupContentBackupSystemStateOnlyWithFullBackup <Boolean?>]`: Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true
  - `[BackupContentMacExcludedPaths <String[]>]`: Paths to exclude for Mac
  - `[BackupContentMacIncludedPaths <String[]>]`: Paths to include for Mac
  - `[BackupContentUnixExcludedPaths <String[]>]`: Paths to exclude for UNIX
  - `[BackupContentUnixIncludedPaths <String[]>]`: Paths to include for UNIX
  - `[BackupContentUseVssForSystemState <Boolean?>]`: Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true
  - `[BackupContentWindowsExcludedPaths <String[]>]`: Paths to exclude for Windows
  - `[BackupContentWindowsIncludedPaths <String[]>]`: Paths to include for Windows
  - `[BackupFrequencySchedules <IPlanSchedule[]>]`: 
    - `BackupType <String>`: Schedule Backup level
    - `ForDatabasesOnly <Boolean>`: Boolean to indicate if schedule is for database agents
    - `ScheduleOperation <String>`: Operation being performed on schedule
    - `SchedulePatternScheduleFrequencyType <String>`: schedule frequency type
    - `[PolicyId <Int32?>]`: Schedule policy Id to which the schedule belongs
    - `[ScheduleId <Int32?>]`: Id of the schedule if available, required for modifying, deleting schedule
    - `[ScheduleName <String>]`: Name of the schedule, for modify
    - `[SchedulePatternDayOfMonth <Int32?>]`: Day on which to run the schedule, applicable for monthly, yearly
    - `[SchedulePatternDayOfWeek <String>]`: 
    - `[SchedulePatternDaysBetweenSyntheticFulls <Int32?>]`: No of days between two synthetic full jobs
    - `[SchedulePatternEndDate <Int32?>]`: Schedule end date in epoch format
    - `[SchedulePatternExceptions <IScheduleRunException[]>]`: Exceptions to when a schedule should not run, either in dates or week of month and days
      - `[OnDates <Int32[]>]`: list of dates in a month. For ex: 1, 20
      - `[OnDayOfTheWeek <String[]>]`: On which days, for ex: MONDAY, FRIDAY
      - `[OnWeekOfTheMonth <String[]>]`: On which week of month, for ex: FIRST, LAST
    - `[SchedulePatternFrequency <Int32?>]`: Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
    - `[SchedulePatternMonthOfYear <String>]`: 
    - `[SchedulePatternNoOfTimes <Int32?>]`: The number of times you want the schedule to run.
    - `[SchedulePatternRepeatIntervalInMinutes <Int32?>]`: How often in minutes in a day the schedule runs, applicable for daily, weekly, monthly and yearly frequency types.
    - `[SchedulePatternRepeatUntilTime <Int32?>]`: Until what time to repeat the schedule in a day, requires repeatIntervalInMinutes
    - `[SchedulePatternStartDate <Int32?>]`: start date of schedule in epoch format
    - `[SchedulePatternStartTime <Int32?>]`: start time of schedule in seconds
    - `[SchedulePatternWeekOfMonth <String>]`: Specific week of a month
    - `[SchedulePatternWeeklyDays <String[]>]`: Days of the week for weekly frequency
    - `[TimezoneId <Int32?>]`: 
    - `[TimezoneName <String>]`: 
  - `[DatabaseOptionCommitFrequencyInHours <Int32?>]`: Commit frequency in hours
  - `[DatabaseOptionLogBackupRpoMins <Int32?>]`: Log backup RPO in minutes
  - `[DatabaseOptionUseDiskCacheForLogBackups <Boolean?>]`: Use disk cache for log backups
  - `[OverrideRestrictionBackupContent <String>]`: 
  - `[OverrideRestrictionRpo <String>]`: 
  - `[OverrideRestrictionStoragePool <String>]`: 
  - `[ParentPlanId <Int32?>]`: 
  - `[ParentPlanName <String>]`: 
  - `[RpoBackupWindow <IDayAndTime[]>]`: Backup window for incremental backup
    - `[DayOfWeek <String[]>]`: 
    - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
    - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[RpoFullBackupWindow <IDayAndTime[]>]`: Backup window for full backup
  - `[SnapshotOptionBackupCopyRpoMins <Int32?>]`: Backup copy RPO in minutes
  - `[SnapshotOptionEnableBackupCopy <Boolean?>]`: Flag to enable backup copy
  - `[SnapshotOptionRetentionPeriodDays <Int32?>]`: Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified, this takes precedence.
  - `[SnapshotOptionSnapRecoveryPoints <Int32?>]`: Number of snap recovery points for default snap copy for retention. Can be specified instead of retention period in Days for default snap copy.

RPOBACKUPWINDOW <IDayAndTime[]>: Backup window for incremental backup
  - `[DayOfWeek <String[]>]`: 
  - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day

RPOFULLBACKUPWINDOW <IDayAndTime[]>: Backup window for full backup
  - `[DayOfWeek <String[]>]`: 
  - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day

## RELATED LINKS

