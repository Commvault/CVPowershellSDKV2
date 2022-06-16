---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-cdmplan
schema: 2.0.0
---

# New-CdmPlan

## SYNOPSIS
Create a CDM Plan

## SYNTAX

```
New-CdmPlan -BackupDestinations <ICreatePlanBackupDestination[]> -PlanName <String>
 [-BackupFrequencySchedules <IPlanSchedule[]>] [-DatabaseOptionCommitFrequencyInHours <Int32>]
 [-DatabaseOptionLogBackupRpoMins <Int32>] [-DatabaseOptionUseDiskCacheForLogBackups]
 [-RpoBackupWindow <IDayAndTime[]>] [-RpoFullBackupWindow <IDayAndTime[]>]
 [-SnapshotOptionBackupCopyRpoMins <Int32>] [-SnapshotOptionEnableBackupCopy]
 [-SnapshotOptionRetentionPeriodDays <Int32>] [-SnapshotOptionSnapRecoveryPoints <Int32>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a CDM Plan

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

### -BackupDestinations
Copy destinations for the plan.
Specify where you want to store your data.
To construct, see NOTES section for BACKUPDESTINATIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICreatePlanBackupDestination[]
Parameter Sets: (All)
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
Type: System.Int32
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
Type: System.Int32
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

### -SnapshotOptionBackupCopyRpoMins
Backup copy RPO in minutes

```yaml
Type: System.Int32
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

### -SnapshotOptionRetentionPeriodDays
Retention period in days.
-1 can be specified for infinite retention.
If this and snapRecoveryPoints both are not specified, this takes precedence.

```yaml
Type: System.Int32
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
Type: System.Int32
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

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BACKUPDESTINATIONS <ICreatePlanBackupDestination[]>: Copy destinations for the plan. Specify where you want to store your data.
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

RPOBACKUPWINDOW <IDayAndTime[]>: Backup window for incremental backup
  - `[DayOfWeek <String[]>]`: 
  - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day

RPOFULLBACKUPWINDOW <IDayAndTime[]>: Backup window for full backup
  - `[DayOfWeek <String[]>]`: 
  - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day

## RELATED LINKS

