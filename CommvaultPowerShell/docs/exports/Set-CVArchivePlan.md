---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-cvarchiveplan
schema: 2.0.0
---

# Set-CVArchivePlan

## SYNOPSIS
Modify existing archive plan details

## SYNTAX

### UpdateExpanded (Default)
```
Set-CVArchivePlan -PlanId <Int64> [-AllowPlanOverride] [-ArchivingRuleAfterArchiving <String>]
 [-ArchivingRuleFileSize <Int64>] [-ArchivingRuleFileTimestamp <Int64>]
 [-ArchivingRuleFileTimestampMethod <String>] [-BackupFrequency <Int64>] [-BackupFrequencyDayOfMonth <Int64>]
 [-BackupFrequencyDayOfWeek <String>] [-BackupFrequencyMonthOfYear <String>]
 [-BackupFrequencyScheduleFrequencyType <String>] [-BackupFrequencyStartTime <Int64>]
 [-BackupFrequencyWeeklyDays <String[]>] [-BackupFrequencyWeekOfMonth <String>] [-NewName <String>]
 [-OverrideRestrictionArchivingRules <String>] [-OverrideRestrictionRpo <String>]
 [-OverrideRestrictionStoragePool <String>] [-RegionToConfigureId <Int64>] [-RegionToConfigureName <String>]
 [-RpoBackupWindow <IDayAndTime[]>] [-SlaEnableAfterDelay <Int64>] [-SlaExcludeFromSla]
 [-SlaExclusionReason <String>] [-SlaPeriod <Int64>] [-SlaUseSystemDefaultSla] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Set-CVArchivePlan -InputObject <ICommvaultPowerShellIdentity> [-AllowPlanOverride]
 [-ArchivingRuleAfterArchiving <String>] [-ArchivingRuleFileSize <Int64>]
 [-ArchivingRuleFileTimestamp <Int64>] [-ArchivingRuleFileTimestampMethod <String>] [-BackupFrequency <Int64>]
 [-BackupFrequencyDayOfMonth <Int64>] [-BackupFrequencyDayOfWeek <String>]
 [-BackupFrequencyMonthOfYear <String>] [-BackupFrequencyScheduleFrequencyType <String>]
 [-BackupFrequencyStartTime <Int64>] [-BackupFrequencyWeeklyDays <String[]>]
 [-BackupFrequencyWeekOfMonth <String>] [-NewName <String>] [-OverrideRestrictionArchivingRules <String>]
 [-OverrideRestrictionRpo <String>] [-OverrideRestrictionStoragePool <String>] [-RegionToConfigureId <Int64>]
 [-RegionToConfigureName <String>] [-RpoBackupWindow <IDayAndTime[]>] [-SlaEnableAfterDelay <Int64>]
 [-SlaExcludeFromSla] [-SlaExclusionReason <String>] [-SlaPeriod <Int64>] [-SlaUseSystemDefaultSla] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Modify existing archive plan details

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
Type: System.Int64
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
Type: System.Int64
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

### -BackupFrequency
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

### -BackupFrequencyDayOfMonth
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

### -BackupFrequencyDayOfWeek
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

### -BackupFrequencyMonthOfYear
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

### -BackupFrequencyScheduleFrequencyType
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

### -BackupFrequencyStartTime
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

### -BackupFrequencyWeeklyDays
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

### -BackupFrequencyWeekOfMonth
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

### -RpoBackupWindow
Archive job will run only in the specified archive window
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

`RPOBACKUPWINDOW <IDayAndTime[]>`: Archive job will run only in the specified archive window
  - `[DayOfWeek <String[]>]`: 
  - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day

## RELATED LINKS

