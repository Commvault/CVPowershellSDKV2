---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/set-cvplan
schema: 2.0.0
---

# Set-CVPlan

## SYNOPSIS
Used to modify an exsiting server plan

## SYNTAX

### UpdateExpanded (Default)
```
Set-CVPlan -PlanId <Int64> [-AllowPlanOverride] [-BackupContentBackupSystemState]
 [-BackupContentBackupSystemStateOnlyWithFullBackup] [-BackupContentForceUpdateProperties]
 [-BackupContentMacExcludedPaths <String[]>] [-BackupContentMacFilterToExcludePaths <String[]>]
 [-BackupContentMacIncludedPaths <String[]>] [-BackupContentUnixExcludedPaths <String[]>]
 [-BackupContentUnixFilterToExcludePaths <String[]>] [-BackupContentUnixIncludedPaths <String[]>]
 [-BackupContentUseVssForSystemState] [-BackupContentWindowsExcludedPaths <String[]>]
 [-BackupContentWindowsFilterToExcludePaths <String[]>] [-BackupContentWindowsIncludedPaths <String[]>]
 [-BackupCopyFrequency <Int64>] [-BackupCopyFrequencyDayOfMonth <Int64>]
 [-BackupCopyFrequencyDayOfWeek <String>] [-BackupCopyFrequencyMonthOfYear <String>]
 [-BackupCopyFrequencyScheduleFrequencyType <String>] [-BackupCopyFrequencyStartTime <Int64>]
 [-BackupCopyFrequencyWeeklyDays <String[]>] [-BackupCopyFrequencyWeekOfMonth <String>]
 [-BackupCopyOptionAction <String>] [-BackupCopyOptionAlertInHours <Int64>]
 [-BackupCopyOptionBackupFullToCopy <String>] [-BackupCopyOptionBackupTypeToCopy <String>]
 [-BackupCopyOptionEnableAlert] [-BackupCopyOptionSkipAfterThresholdDays <Int64>]
 [-BackupCopyOptionStartTime <Int64>] [-BackupDestinationIds <Int64[]>]
 [-BackupFrequencyOperationType <String>] [-BackupFrequencySchedules <IPlanSchedule[]>]
 [-DatabaseOptionCommitFrequencyInHours <Int64>] [-DatabaseOptionLogBackupRpoMins <Int64>]
 [-DatabaseOptionRunFullBackupEvery <Int64>] [-DatabaseOptionUseDiskCacheForLogBackups] [-FileSearchEnabled]
 [-FileSearchErrors <IPlanFileSearchSetupError[]>] [-FileSearchStatus <String>]
 [-FileSearchStatusMessage <String>] [-FilesystemAddon] [-MacNumberOfDataReaderCount <Int64>]
 [-MacNumberOfDataReaderUseOptimal] [-NewName <String>] [-OverrideInheritSettingBackupContent]
 [-OverrideInheritSettingBackupDestination] [-OverrideInheritSettingRpo]
 [-OverrideRestrictionBackupContent <String>] [-OverrideRestrictionRpo <String>]
 [-OverrideRestrictionStoragePool <String>] [-RegionToConfigureId <Int64>] [-RegionToConfigureName <String>]
 [-RpoBackupWindow <IDayAndTime[]>] [-RpoFullBackupWindow <IDayAndTime[]>] [-SettingDeviceStreams <Int64>]
 [-SettingEnableAdvancedView] [-SlaEnableAfterDelay <Int64>] [-SlaExcludeFromSla]
 [-SlaExclusionReason <String>] [-SlaLogSlaMinutes <Int64>] [-SlaPeriod <Int64>] [-SlaUseSystemDefaultSla]
 [-SnapshotOptionBackupCopyRpoMins <Int64>] [-SnapshotOptionEnableBackupCopy]
 [-SnapshotOptionEnableSnapCatalog] [-UnixNumberOfDataReaderCount <Int64>] [-UnixNumberOfDataReaderUseOptimal]
 [-WindowNumberOfDataReaderCount <Int64>] [-WindowNumberOfDataReaderUseOptimal]
 [-WorkloadGroupTypes <String[]>] [-WorkloadSolutions <IIdName[]>] [-WorkloadTypes <IIdName[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Set-CVPlan -InputObject <ICommvaultPowerShellIdentity> [-AllowPlanOverride] [-BackupContentBackupSystemState]
 [-BackupContentBackupSystemStateOnlyWithFullBackup] [-BackupContentForceUpdateProperties]
 [-BackupContentMacExcludedPaths <String[]>] [-BackupContentMacFilterToExcludePaths <String[]>]
 [-BackupContentMacIncludedPaths <String[]>] [-BackupContentUnixExcludedPaths <String[]>]
 [-BackupContentUnixFilterToExcludePaths <String[]>] [-BackupContentUnixIncludedPaths <String[]>]
 [-BackupContentUseVssForSystemState] [-BackupContentWindowsExcludedPaths <String[]>]
 [-BackupContentWindowsFilterToExcludePaths <String[]>] [-BackupContentWindowsIncludedPaths <String[]>]
 [-BackupCopyFrequency <Int64>] [-BackupCopyFrequencyDayOfMonth <Int64>]
 [-BackupCopyFrequencyDayOfWeek <String>] [-BackupCopyFrequencyMonthOfYear <String>]
 [-BackupCopyFrequencyScheduleFrequencyType <String>] [-BackupCopyFrequencyStartTime <Int64>]
 [-BackupCopyFrequencyWeeklyDays <String[]>] [-BackupCopyFrequencyWeekOfMonth <String>]
 [-BackupCopyOptionAction <String>] [-BackupCopyOptionAlertInHours <Int64>]
 [-BackupCopyOptionBackupFullToCopy <String>] [-BackupCopyOptionBackupTypeToCopy <String>]
 [-BackupCopyOptionEnableAlert] [-BackupCopyOptionSkipAfterThresholdDays <Int64>]
 [-BackupCopyOptionStartTime <Int64>] [-BackupDestinationIds <Int64[]>]
 [-BackupFrequencyOperationType <String>] [-BackupFrequencySchedules <IPlanSchedule[]>]
 [-DatabaseOptionCommitFrequencyInHours <Int64>] [-DatabaseOptionLogBackupRpoMins <Int64>]
 [-DatabaseOptionRunFullBackupEvery <Int64>] [-DatabaseOptionUseDiskCacheForLogBackups] [-FileSearchEnabled]
 [-FileSearchErrors <IPlanFileSearchSetupError[]>] [-FileSearchStatus <String>]
 [-FileSearchStatusMessage <String>] [-FilesystemAddon] [-MacNumberOfDataReaderCount <Int64>]
 [-MacNumberOfDataReaderUseOptimal] [-NewName <String>] [-OverrideInheritSettingBackupContent]
 [-OverrideInheritSettingBackupDestination] [-OverrideInheritSettingRpo]
 [-OverrideRestrictionBackupContent <String>] [-OverrideRestrictionRpo <String>]
 [-OverrideRestrictionStoragePool <String>] [-RegionToConfigureId <Int64>] [-RegionToConfigureName <String>]
 [-RpoBackupWindow <IDayAndTime[]>] [-RpoFullBackupWindow <IDayAndTime[]>] [-SettingDeviceStreams <Int64>]
 [-SettingEnableAdvancedView] [-SlaEnableAfterDelay <Int64>] [-SlaExcludeFromSla]
 [-SlaExclusionReason <String>] [-SlaLogSlaMinutes <Int64>] [-SlaPeriod <Int64>] [-SlaUseSystemDefaultSla]
 [-SnapshotOptionBackupCopyRpoMins <Int64>] [-SnapshotOptionEnableBackupCopy]
 [-SnapshotOptionEnableSnapCatalog] [-UnixNumberOfDataReaderCount <Int64>] [-UnixNumberOfDataReaderUseOptimal]
 [-WindowNumberOfDataReaderCount <Int64>] [-WindowNumberOfDataReaderUseOptimal]
 [-WorkloadGroupTypes <String[]>] [-WorkloadSolutions <IIdName[]>] [-WorkloadTypes <IIdName[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Used to modify an exsiting server plan

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

### -BackupContentForceUpdateProperties
Do you want to sync properties on associated subclients even if properties are overriden at subclient level

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

### -BackupContentMacFilterToExcludePaths
Paths that are exception to excluded paths for Mac

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

### -BackupContentUnixFilterToExcludePaths
Paths that are exception to excluded paths for Unix

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

### -BackupContentWindowsFilterToExcludePaths
Paths that are exception to excluded paths for Windows

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

### -BackupCopyFrequency
Frequency of the schedule based on schedule frequency type eg.
for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days.
for Monthly 2 is it repeats every 2 months

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

### -BackupCopyFrequencyDayOfMonth
Day on which to run the schedule, applicable for monthly, yearly

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

### -BackupCopyFrequencyDayOfWeek
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

### -BackupCopyFrequencyMonthOfYear
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

### -BackupCopyFrequencyScheduleFrequencyType
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

### -BackupCopyFrequencyStartTime
start time of schedule in seconds for daily, weekly, monthly, yearly frequency

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

### -BackupCopyFrequencyWeeklyDays
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

### -BackupCopyFrequencyWeekOfMonth
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

### -BackupDestinationIds
Primary Backup Destination Ids (which were created before plan creation).

```yaml
Type: System.Int64[]
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

### -FileSearchEnabled
Flag for enabling indexing

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

### -FileSearchErrors
File search was enabled on plan but failed to process some of the storage pool(s) with these errors

```yaml
Type: Commvault.Powershell.Models.IPlanFileSearchSetupError[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileSearchStatus
Type of indexing status.

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

### -FileSearchStatusMessage
Tells what is happening behind the scene, so that user can knows why indexing is not enabled or if its in progress

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

### -FilesystemAddon
flag to enable backup content association for applicable file system workload.

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

### -MacNumberOfDataReaderCount
Number of data readers.

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

### -MacNumberOfDataReaderUseOptimal
Set optimal number of data readers.
if it is set to true, count will be ignored.

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

### -SettingDeviceStreams
For each region, the data to backup is divided into these many streams while writing to backup destination.

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

### -SettingEnableAdvancedView
Setting to suggest plan has some advanced settings present.
Setting is OEM specific and not applicable for all cases.

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

### -SlaLogSlaMinutes
Database log SLA period in Minutes

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

### -UnixNumberOfDataReaderCount
Number of data readers.

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

### -UnixNumberOfDataReaderUseOptimal
Set optimal number of data readers.
if it is set to true, count will be ignored.

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

### -WindowNumberOfDataReaderCount
Number of data readers.

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

### -WindowNumberOfDataReaderUseOptimal
Set optimal number of data readers.
if it is set to true, count will be ignored.

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

### -WorkloadGroupTypes
.

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

### -WorkloadSolutions
.

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

### -WorkloadTypes
.

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

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

`FILESEARCHERRORS <IPlanFileSearchSetupError[]>`: File search was enabled on plan but failed to process some of the storage pool(s) with these errors
  - `[ErrorCode <Int64?>]`: 
  - `[ErrorMessage <String>]`: Tells about the error occured during file search setup for given storage pool
  - `[StorageId <Int64?>]`: 
  - `[StorageName <String>]`: 

`INPUTOBJECT <ICommvaultPowerShellIdentity>`: Identity Parameter
  - `[AccessPathId <Int64?>]`: Id of the mount path whose access path has to be deleted
  - `[AgentId <Int64?>]`: Id of the agent to be modified
  - `[AlertRuleId <Int64?>]`: Unique Id of the alert custom rule to get details
  - `[AppGuid <String>]`: GUID of the Application to get details
  - `[AppId <Int64?>]`: Commvault exchange app id
  - `[ApplicationGroupId <Int64?>]`: applicationGroupId is the ID of the Kubernetes application group
  - `[ArrayId <Int64?>]`: 
  - `[AssetId <String>]`: FQDN of the asset
  - `[BackupDestinationId <Int64?>]`: Id of the backupDestination to be modified
  - `[BackupDestionationId <Int64?>]`: 
  - `[BackupLocationId <Int64?>]`: Id of the backup location whose details have to be fetched
  - `[BlackoutWindowId <Int64?>]`: Id of the Blackout Window whose details have to be fetched
  - `[BucketId <Int64?>]`: Id of Bucket
  - `[ClientId <Int64?>]`: 
  - `[CloneId <Int64?>]`: ID of the cloned bucket
  - `[CloudStorageId <Int64?>]`: Id of cloud Storage
  - `[ClusterId <Int64?>]`: Id of the cluster whose modifier has to be listed.
  - `[CompanyId <Int64?>]`: Id of the Company whose details have to be fetched
  - `[CopyId <Int64?>]`: 
  - `[CredentialId <String>]`: 
  - `[CredentialName <String>]`: 
  - `[DomainId <Int64?>]`: ID of the AD/LDAP domain
  - `[DrOperation <String>]`: Name of DR operation. Case insensitive
  - `[DriveId <Int64?>]`: Id of the Drive of which the drive details has to be displayed
  - `[EntityId <Int64?>]`: Recovery entity Id
  - `[EntityType <String>]`: Type of the entity
  - `[FailoverGroupId <Int64?>]`: Id of the failover group
  - `[GlobalSearchEntity <String>]`: name of global search entity
  - `[HfsShareId <Int64?>]`: Id of the HFS Share to fetch its status
  - `[HyperScaleStorageId <Int64?>]`: Id of hyperscale storage
  - `[HypervisorId <Int64?>]`: Id of the HYpervisor to get
  - `[Id <Int64?>]`: 
  - `[IndexServerClientId <Int64?>]`: Pseudo client id of the index server
  - `[InstanceId <Int64?>]`: Id of the instance to modify
  - `[InventoryId <Int64?>]`: Inventory id
  - `[JobId <Int64?>]`: 
  - `[KmsId <Int64?>]`: Id of Key Management Server
  - `[LibraryId <Int64?>]`: Id of the library to view the data
  - `[MediaAgentId <Int64?>]`: Id of the Media Agent whose details have to be fetched
  - `[MetadataCacheId <Int64?>]`: Id of metadata cache
  - `[ModifierName <String>]`: Name of the modifier to be read.
  - `[Name <String>]`: 
  - `[NameSpace <String>]`: Name of the namespace to browse for content
  - `[NodeId <Int64?>]`: Id of node
  - `[PairId <Int64?>]`: 
  - `[PlanId <Int64?>]`: Id of the object store plan to fetch details
  - `[RecoveryEntityId <Int64?>]`: Recovery entity Id
  - `[RecoveryGroupId <Int64?>]`: Recovery group Id
  - `[RecoveryTargetId <Int64?>]`: id of recovery target
  - `[RegionId <Int64?>]`: Region id to be deleted.
  - `[RegionList <String>]`: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  - `[ReplicationGroupId <String>]`: 
  - `[ReplicationPairId <Int64?>]`: Replication pair id of the Pair
  - `[RequestId <Int64?>]`: Unique identifier for the request
  - `[RoleId <Int64?>]`: Role Id
  - `[RpsId <String>]`: 
  - `[RuleId <Int64?>]`: Id of the rule to update in Plan
  - `[ScheduleId <Int64?>]`: ID of the DR operation schedule
  - `[SchedulePolicyId <Int64?>]`: 
  - `[ServerGroupId <Int64?>]`: Id of the serverGroupId whose details have to be fetched
  - `[ServerId <Int64?>]`: Id of the server to modify
  - `[SnapEngineId <Int64?>]`: Snap Engine Id
  - `[SpareGroupId <Int64?>]`: Id of the Spare group whose properties need to be fetched. spareGroupId can be fetched from GET V4/Storage/Tape/{libraryId}/MediaType
  - `[StoragePoolId <Int64?>]`: Id of the storage pool whose associated copies have to be fetched
  - `[SubclientId <Int64?>]`: Id of the subclient to modify
  - `[TagId <Int64?>]`: Id of the tag to delete
  - `[TagValue <String>]`: tag value to delete
  - `[TopologyId <String>]`: 
  - `[UserGroupId <Int64?>]`: Id of the user-group whose details have to be fetched
  - `[UserId <Int64?>]`: Id of the User whose details have to be fetched
  - `[VMGroupId <Int64?>]`: Id of the VMgroup to update
  - `[VMGuid <String>]`: 
  - `[VMUuid <String>]`: The vmUUID can be obtained from GET /virtualMachines UUID property
  - `[VendorId <Int64?>]`: 

`RPOBACKUPWINDOW <IDayAndTime[]>`: Backup window for incremental backup
  - `[DayOfWeek <List<String>>]`: 
  - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day

`RPOFULLBACKUPWINDOW <IDayAndTime[]>`: Backup window for full backup
  - `[DayOfWeek <List<String>>]`: 
  - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day

`WORKLOADSOLUTIONS <IIdName[]>`: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`WORKLOADTYPES <IIdName[]>`: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

