---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/new-cvfailovergroupschedule
schema: 2.0.0
---

# New-CVFailoverGroupSchedule

## SYNOPSIS
API to create failover group DR operation schedule

## SYNTAX

### CreateExpanded (Default)
```
New-CVFailoverGroupSchedule -FailoverGroupId <Int64> [-AdditionalInfo <String>] [-BackupType <String>]
 [-ForDatabasesOnly] [-IsRetentionBasedSyntheticFull] [-PolicyId <Int64>] [-ScheduleId <Int64>]
 [-ScheduleName <String>] [-ScheduleOperation <String>] [-ScheduleOptionCommitFrequencyInHours <Int64>]
 [-ScheduleOptionDaysBetweenAutoConvert <Int64>] [-ScheduleOptionJobRunningTimeInMins <Int64>]
 [-ScheduleOptionLogFilesThreshold <Int64>] [-ScheduleOptionLogsDiskUtilizationPercent <Int64>]
 [-ScheduleOptionMinBackupIntervalInMins <Int64>] [-ScheduleOptionO365ItemSelectionOption <String>]
 [-ScheduleOptionUseDiskCacheForLogBackups] [-SchedulePatternDayOfMonth <Int64>]
 [-SchedulePatternDayOfWeek <String>] [-SchedulePatternDaysBetweenSyntheticFulls <Int64>]
 [-SchedulePatternEndDate <Int64>] [-SchedulePatternExceptions <IScheduleRunException[]>]
 [-SchedulePatternFrequency <Int64>] [-SchedulePatternMaxBackupIntervalInMins <Int64>]
 [-SchedulePatternMonthOfYear <String>] [-SchedulePatternNoOfTimes <Int64>]
 [-SchedulePatternRepeatIntervalInMinutes <Int64>] [-SchedulePatternRepeatUntilTime <Int64>]
 [-SchedulePatternScheduleFrequencyType <String>] [-SchedulePatternStartDate <Int64>]
 [-SchedulePatternStartTime <Int64>] [-SchedulePatternWeeklyDays <String[]>]
 [-SchedulePatternWeekOfMonth <String>] [-TimezoneId <Int64>] [-TimezoneName <String>]
 [-VMOperationType <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-CVFailoverGroupSchedule -InputObject <ICommvaultPowerShellIdentity> [-AdditionalInfo <String>]
 [-BackupType <String>] [-ForDatabasesOnly] [-IsRetentionBasedSyntheticFull] [-PolicyId <Int64>]
 [-ScheduleId <Int64>] [-ScheduleName <String>] [-ScheduleOperation <String>]
 [-ScheduleOptionCommitFrequencyInHours <Int64>] [-ScheduleOptionDaysBetweenAutoConvert <Int64>]
 [-ScheduleOptionJobRunningTimeInMins <Int64>] [-ScheduleOptionLogFilesThreshold <Int64>]
 [-ScheduleOptionLogsDiskUtilizationPercent <Int64>] [-ScheduleOptionMinBackupIntervalInMins <Int64>]
 [-ScheduleOptionO365ItemSelectionOption <String>] [-ScheduleOptionUseDiskCacheForLogBackups]
 [-SchedulePatternDayOfMonth <Int64>] [-SchedulePatternDayOfWeek <String>]
 [-SchedulePatternDaysBetweenSyntheticFulls <Int64>] [-SchedulePatternEndDate <Int64>]
 [-SchedulePatternExceptions <IScheduleRunException[]>] [-SchedulePatternFrequency <Int64>]
 [-SchedulePatternMaxBackupIntervalInMins <Int64>] [-SchedulePatternMonthOfYear <String>]
 [-SchedulePatternNoOfTimes <Int64>] [-SchedulePatternRepeatIntervalInMinutes <Int64>]
 [-SchedulePatternRepeatUntilTime <Int64>] [-SchedulePatternScheduleFrequencyType <String>]
 [-SchedulePatternStartDate <Int64>] [-SchedulePatternStartTime <Int64>]
 [-SchedulePatternWeeklyDays <String[]>] [-SchedulePatternWeekOfMonth <String>] [-TimezoneId <Int64>]
 [-TimezoneName <String>] [-VMOperationType <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to create failover group DR operation schedule

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

### -AdditionalInfo
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

### -BackupType
Schedule Backup level

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

### -FailoverGroupId
Id of the failover group

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ForDatabasesOnly
Boolean to indicate if schedule is for database agents

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
Parameter Sets: CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsRetentionBasedSyntheticFull
Boolean to indicate if synthetic full schedule is based on retention rules

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

### -PolicyId
Schedule policy Id to which the schedule belongs

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

### -ScheduleId
Id of the schedule if available, required for modifying, deleting schedule

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

### -ScheduleName
Name of the schedule, for modify

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

### -ScheduleOperation
Operation being performed on schedule

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

### -ScheduleOptionCommitFrequencyInHours
Commit frequency in hours for disk cache backups from automatic schedules

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

### -ScheduleOptionDaysBetweenAutoConvert
Number of days between auto conversion of backup level applicable for databases on incremental and differential schedules of server plan

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

### -ScheduleOptionJobRunningTimeInMins
total job running time in minutes

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

### -ScheduleOptionLogFilesThreshold
The min number of archived log files before a backup job should start

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

### -ScheduleOptionLogsDiskUtilizationPercent
The min log destination disk threshold percentage

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

### -ScheduleOptionMinBackupIntervalInMins
The min number of mins to check for file activity on automatic schedule.

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

### -ScheduleOptionO365ItemSelectionOption
item backup option for O365 V2 backup jobs

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

### -ScheduleOptionUseDiskCacheForLogBackups
Used to enable disk caching feature on databases for automatic schedules on server plan

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

### -SchedulePatternDayOfMonth
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

### -SchedulePatternDayOfWeek
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

### -SchedulePatternDaysBetweenSyntheticFulls
No of days between two synthetic full jobs

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

### -SchedulePatternEndDate
Schedule end date in epoch format

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

### -SchedulePatternExceptions
Exceptions to when a schedule should not run, either in dates or week of month and days

```yaml
Type: Commvault.Powershell.Models.IScheduleRunException[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SchedulePatternFrequency
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

### -SchedulePatternMaxBackupIntervalInMins
The number of mins to force a backup on automatic schedule.

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

### -SchedulePatternMonthOfYear
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

### -SchedulePatternNoOfTimes
The number of times you want the schedule to run.

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

### -SchedulePatternRepeatIntervalInMinutes
How often in minutes in a day the schedule runs, applicable for daily, weekly, monthly and yearly frequency types.

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

### -SchedulePatternRepeatUntilTime
Until what time to repeat the schedule in a day, requires repeatIntervalInMinutes

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

### -SchedulePatternScheduleFrequencyType
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

### -SchedulePatternStartDate
start date of schedule in epoch format

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

### -SchedulePatternStartTime
start time of schedule in seconds

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

### -SchedulePatternWeeklyDays
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

### -SchedulePatternWeekOfMonth
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

### -TimezoneId
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

### -TimezoneName
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

### -VMOperationType
Type of DR operation (only applicable for Failover groups)

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

### Commvault.Powershell.Models.IPlanSchedule

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

`SCHEDULEPATTERNEXCEPTIONS <IScheduleRunException[]>`: Exceptions to when a schedule should not run, either in dates or week of month and days
  - `[OnDates <List<Int64>>]`: list of dates in a month. For ex: 1, 20
  - `[OnDayOfTheWeek <List<String>>]`: On which days, for ex: MONDAY, FRIDAY
  - `[OnWeekOfTheMonth <List<String>>]`: On which week of month, for ex: FIRST, LAST

## RELATED LINKS

