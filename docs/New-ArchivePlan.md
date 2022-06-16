---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-archiveplan
schema: 2.0.0
---

# New-ArchivePlan

## SYNOPSIS
Create Archive Plan

## SYNTAX

```
New-ArchivePlan -PlanName <String> [-AllowPlanOverride] [-ArchiveFrequency <Int32>]
 [-ArchiveFrequencyDayOfMonth <Int32>] [-ArchiveFrequencyDayOfWeek <String>]
 [-ArchiveFrequencyMonthOfYear <String>] [-ArchiveFrequencyScheduleFrequencyType <String>]
 [-ArchiveFrequencyStartTime <Int32>] [-ArchiveFrequencyWeeklyDays <String[]>]
 [-ArchiveFrequencyWeekOfMonth <String>] [-ArchivingRuleAfterArchiving <String>]
 [-ArchivingRuleFileSize <Int32>] [-ArchivingRuleFileTimestamp <Int32>]
 [-ArchivingRuleFileTimestampMethod <String>] [-BackupDestinations <ICreateArchivePlanBackupDestination[]>]
 [-OverrideRestrictionArchivingRules <String>] [-OverrideRestrictionRpo <String>]
 [-OverrideRestrictionStoragePool <String>] [-ParentPlanId <Int32>] [-ParentPlanName <String>]
 [-RpoArchiveWindow <IDayAndTime[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create Archive Plan

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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ArchiveFrequency
Frequency of the schedule based on schedule frequency type eg.
for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days.
for Monthly 2 is it repeats every 2 months

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

### -ArchiveFrequencyDayOfMonth
Day on which to run the schedule, applicable for monthly, yearly

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

### -ArchiveFrequencyDayOfWeek
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

### -ArchiveFrequencyMonthOfYear
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

### -ArchiveFrequencyScheduleFrequencyType
schedule frequency type

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

### -ArchiveFrequencyStartTime
start time of schedule in seconds for daily, weekly, monthly, yearly frequency

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

### -ArchiveFrequencyWeeklyDays
Days of the week for weekly frequency

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

### -ArchiveFrequencyWeekOfMonth
Specific week of a month

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

### -ArchivingRuleAfterArchiving
After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving rules

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

### -ArchivingRuleFileSize
To archive files based on the size of the file, specify the minimum file size in KB.

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

### -ArchivingRuleFileTimestamp
To archive files based on the last accessed or modified date of each file within the folder, specify the number of days.
Should be supplied with fileTimestampMethod.

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

### -ArchivingRuleFileTimestampMethod
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

### -BackupDestinations
.
To construct, see NOTES section for BACKUPDESTINATIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICreateArchivePlanBackupDestination[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OverrideRestrictionArchivingRules
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

### -ParentPlanId
.

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

### -ParentPlanName
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

### -PlanName
.

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

### -RpoArchiveWindow
Archive job will run only in the specified archive window
To construct, see NOTES section for RPOARCHIVEWINDOW properties and create a hash table.

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

### Commvault.Powershell.Models.IGenericResp

### Commvault.Powershell.Models.IPlanResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BACKUPDESTINATIONS <ICreateArchivePlanBackupDestination[]>: .
  - `BackupDestinationName <String>`: Backup destination details. Enter the name during creation.
  - `[BackupStartTime <Int32?>]`: Backup start time in seconds. The time is provided in unix time format.
  - `[RegionId <Int32?>]`: 
  - `[RegionName <String>]`: 
  - `[RetentionPeriodDays <Int32?>]`: Retention period in days. -1 can be specified for infinite retention.
  - `[SourceCopyId <Int32?>]`: 
  - `[SourceCopyName <String>]`: 
  - `[StoragePoolId <Int32?>]`: 
  - `[StoragePoolName <String>]`: 

RPOARCHIVEWINDOW <IDayAndTime[]>: Archive job will run only in the specified archive window
  - `[DayOfWeek <String[]>]`: 
  - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day

## RELATED LINKS

