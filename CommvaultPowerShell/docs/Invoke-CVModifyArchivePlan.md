---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-cvmodifyarchiveplan
schema: 2.0.0
---

# Invoke-CVModifyArchivePlan

## SYNOPSIS
Modify existing archive plan details

## SYNTAX

### ModifyExpanded (Default)
```
Invoke-CVModifyArchivePlan -PlanId <Int64> [-AllowPlanOverride] [-ArchivingRuleAfterArchiving <String>]
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

### Modify
```
Invoke-CVModifyArchivePlan -PlanId <Int64> -Body <IUpdateArchivePlan> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ModifyViaIdentity
```
Invoke-CVModifyArchivePlan -InputObject <ICommvaultPowerShellIdentity> -Body <IUpdateArchivePlan> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentityExpanded
```
Invoke-CVModifyArchivePlan -InputObject <ICommvaultPowerShellIdentity> [-AllowPlanOverride]
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
Once enabled, cannot be disabled.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Type: Commvault.Powershell.Models.IUpdateArchivePlan
Parameter Sets: Modify, ModifyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICommvaultPowerShellIdentity
Parameter Sets: ModifyViaIdentity, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: Modify, ModifyExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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

### Commvault.Powershell.Models.IUpdateArchivePlan

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IUpdateArchivePlan>: .
  - `[AllowPlanOverride <Boolean?>]`: Flag to enable overriding of plan. Once enabled, cannot be disabled.
  - `[ArchivingRuleAfterArchiving <String>]`: After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving rules
  - `[ArchivingRuleFileSize <Int64?>]`: To archive files based on the size of the file, specify the minimum file size in KB.
  - `[ArchivingRuleFileTimestamp <Int64?>]`: To archive files based on the last accessed or modified date of each file within the folder, specify the number of days. Should be supplied with fileTimestampMethod.
  - `[ArchivingRuleFileTimestampMethod <String>]`: 
  - `[BackupFrequency <Int64?>]`: Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
  - `[BackupFrequencyDayOfMonth <Int64?>]`: Day on which to run the schedule, applicable for monthly, yearly
  - `[BackupFrequencyDayOfWeek <String>]`: 
  - `[BackupFrequencyMonthOfYear <String>]`: 
  - `[BackupFrequencyScheduleFrequencyType <String>]`: schedule frequency type
  - `[BackupFrequencyStartTime <Int64?>]`: start time of schedule in seconds for daily, weekly, monthly, yearly frequency
  - `[BackupFrequencyWeekOfMonth <String>]`: Specific week of a month
  - `[BackupFrequencyWeeklyDays <String[]>]`: Days of the week for weekly frequency
  - `[NewName <String>]`: New plan name to update
  - `[OverrideRestrictionArchivingRules <String>]`: 
  - `[OverrideRestrictionRpo <String>]`: 
  - `[OverrideRestrictionStoragePool <String>]`: 
  - `[RegionToConfigureId <Int64?>]`: 
  - `[RegionToConfigureName <String>]`: 
  - `[RpoBackupWindow <IDayAndTime[]>]`: Archive job will run only in the specified archive window
    - `[DayOfWeek <String[]>]`: 
    - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
    - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[SlaEnableAfterDelay <Int64?>]`: Time provided in Unix format. Give 0 to reset any existing delay.
  - `[SlaExcludeFromSla <Boolean?>]`: Flag to set to exclude plan from SLA
  - `[SlaExclusionReason <String>]`: Reason for exclusion from SLA
  - `[SlaPeriod <Int64?>]`: SLA Period in Days
  - `[SlaUseSystemDefaultSla <Boolean?>]`: Flag to set to use System Default Service Level Agreement

INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
  - `[AccessPathId <Int64?>]`: Id of the mount path whose access path has to be deleted
  - `[AgentId <Int64?>]`: Id of the agent to be modified
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
  - `[CloudStorageId <Int64?>]`: Id of cloud Storage
  - `[ClusterId <Int64?>]`: 
  - `[CompanyId <Int64?>]`: Id of the Company whose details have to be fetched
  - `[CopyId <Int64?>]`: 
  - `[CredentialId <String>]`: 
  - `[CredentialName <String>]`: 
  - `[DomainId <Int64?>]`: ID of the AD/LDAP domain
  - `[DrOperation <String>]`: Name of DR operation. Case insensitive
  - `[DriveId <Int64?>]`: Id of the Drive of which the drive details has to be displayed
  - `[EntityId <Int64?>]`: Unique id for the entity
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
  - `[Name <String>]`: 
  - `[NameSpace <String>]`: Name of the namespace to browse for content
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
  - `[ScheduleId <Int64?>]`: ID of the DR operation schedule
  - `[SchedulePolicyId <Int64?>]`: 
  - `[ServerGroupId <Int64?>]`: Id of the serverGroupId whose details have to be fetched
  - `[ServerId <Int64?>]`: Id of the server to modify
  - `[StoragePoolId <Int64?>]`: Id of the storage pool whose associated copies have to be fetched
  - `[SubclientId <Int64?>]`: Id of the subclient to modify
  - `[TagId <Int64?>]`: Id of the tag to delete
  - `[TagValue <String>]`: tag value to delete
  - `[TopologyId <String>]`: 
  - `[UserGroupId <Int64?>]`: Id of the user-group whose details have to be fetched
  - `[UserId <Int64?>]`: Id of the User whose details have to be fetched
  - `[VMGroupId <Int64?>]`: Id of the VMgroup to update
  - `[VMGuid <String>]`: GUID of the Provisioned VM
  - `[VMUuid <String>]`: The vmUUID can be obtained from GET /virtualMachines UUID property
  - `[VendorId <Int64?>]`: 

RPOBACKUPWINDOW <IDayAndTime[]>: Archive job will run only in the specified archive window
  - `[DayOfWeek <String[]>]`: 
  - `[EndTime <Int64?>]`: Time in seconds since the beginning of the day
  - `[StartTime <Int64?>]`: Time in seconds since the beginning of the day

## RELATED LINKS

