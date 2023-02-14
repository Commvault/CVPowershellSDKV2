---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-cvlaptopplan
schema: 2.0.0
---

# New-CVLaptopPlan

## SYNOPSIS
Create Laptop Plan

## SYNTAX

```
New-CVLaptopPlan -PlanName <String> [-Alerts <IIdName[]>] [-AllowedFeatures <ILaptopPlanAllowedFeatures>]
 [-AllowPlanOverride] [-BackupContentFileSystemQuota <Int64>] [-BackupContentMacExcludedPaths <String[]>]
 [-BackupContentMacIncludedPaths <String[]>] [-BackupContentUnixExcludedPaths <String[]>]
 [-BackupContentUnixIncludedPaths <String[]>] [-BackupContentWindowsExcludedPaths <String[]>]
 [-BackupContentWindowsIncludedPaths <String[]>] [-FileVersionDailyVersions <Int64>]
 [-FileVersionDays <Int64>] [-FileVersionMonthlyVersions <Int64>] [-FileVersionVersions <Int64>]
 [-FileVersionWeeklyVersions <Int64>] [-InviteUsersOrGroups <IPlanUserOrGroups[]>]
 [-NetworkResourceThrottleReceive <Int64>] [-NetworkResourceThrottleSend <Int64>]
 [-OverrideRestrictionBackupContent <String>] [-OverrideRestrictionRetention <String>]
 [-OverrideRestrictionRpo <String>] [-OverrideRestrictionStoragePool <String>] [-ParentPlanId <Int64>]
 [-ParentPlanName <String>] [-PrimaryStorageId <Int64>] [-PrimaryStorageName <String>]
 [-RetentionDeletedItemRetention <Int64>] [-SecondaryStorageId <Int64>] [-SecondaryStorageName <String>]
 [-StorageAndScheduleBackupFrequency <Int64>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create Laptop Plan

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

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

### -InviteUsersOrGroups
The users and user groups who should install the end-user Endpoint package on their devices.
To construct, see NOTES section for INVITEUSERSORGROUPS properties and create a hash table.

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

### -ParentPlanId
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

### -PrimaryStorageId
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

### -PrimaryStorageName
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

### -SecondaryStorageId
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

### -SecondaryStorageName
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

### -StorageAndScheduleBackupFrequency
Recovery Point Objective (RPO) is the maximum amount of time that data can be lost during a service disruption.
Your RPO determines the frequency of your backup jobs.
Your RPO is met through automatic options.
The time specified in minutes here is your RPO if none of the automatic options are met.
Default is 480 minutes (8 hours).

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

### Commvault.Powershell.Models.IGenericResp

### Commvault.Powershell.Models.IPlanResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALERTS <IIdName[]>: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

ALLOWEDFEATURES <ILaptopPlanAllowedFeatures>: Create/modify allowed features of laptop plan
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

INVITEUSERSORGROUPS <IPlanUserOrGroups[]>: The users and user groups who should install the end-user Endpoint package on their devices.
  - `[Id <Int64?>]`: This gives Id of user or user group or external user group
  - `[Name <String>]`: This gives name of user or user group or external user group
  - `[SendInvite <Boolean?>]`: If set to true, will send an invite email to the user or group. Default is true.
  - `[Type <String>]`: Tells what kind of user or user group it is

## RELATED LINKS

