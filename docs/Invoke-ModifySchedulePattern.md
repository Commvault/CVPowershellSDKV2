---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifyschedulepattern
schema: 2.0.0
---

# Invoke-ModifySchedulePattern

## SYNOPSIS
API to update pattern for schedule in schedule policy

## SYNTAX

### ModifyExpanded (Default)
```
Invoke-ModifySchedulePattern -ScheduleId <String> -SchedulePolicyId <String> [-DailyFrequency <Int32>]
 [-HourlyFrequency <Int32>] [-MinuteFrequency <Int32>] [-MonthlyFrequency <Int32>]
 [-MonthlyFrequencyDayOfMonth <Int32>] [-MonthlyFrequencyDayOfWeek <String>]
 [-MonthlyFrequencyWeekOfMonth <String>] [-StartTime <Int32>] [-WeeklyFrequency <Int32>]
 [-WeeklyFrequencyDays <String[]>] [-YearlyFrequencyDayOfMonth <Int32>] [-YearlyFrequencyDayOfWeek <String>]
 [-YearlyFrequencyMonthOfYear <String>] [-YearlyFrequencyWeekOfMonth <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Modify
```
Invoke-ModifySchedulePattern -ScheduleId <String> -SchedulePolicyId <String> -Body <IPlanPattern> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentity
```
Invoke-ModifySchedulePattern -InputObject <ICommvaultPowerShellIdentity> -Body <IPlanPattern> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentityExpanded
```
Invoke-ModifySchedulePattern -InputObject <ICommvaultPowerShellIdentity> [-DailyFrequency <Int32>]
 [-HourlyFrequency <Int32>] [-MinuteFrequency <Int32>] [-MonthlyFrequency <Int32>]
 [-MonthlyFrequencyDayOfMonth <Int32>] [-MonthlyFrequencyDayOfWeek <String>]
 [-MonthlyFrequencyWeekOfMonth <String>] [-StartTime <Int32>] [-WeeklyFrequency <Int32>]
 [-WeeklyFrequencyDays <String[]>] [-YearlyFrequencyDayOfMonth <Int32>] [-YearlyFrequencyDayOfWeek <String>]
 [-YearlyFrequencyMonthOfYear <String>] [-YearlyFrequencyWeekOfMonth <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
API to update pattern for schedule in schedule policy

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

### -Body
If updating pattern, the value which needs to be retained also needs to be provided along with the updated value
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IPlanPattern
Parameter Sets: Modify, ModifyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DailyFrequency
Frequency in days

```yaml
Type: System.Int32
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HourlyFrequency
Frequency in hours per day.
Precedence is hourly, daily, weekly and monthly, in that order.

```yaml
Type: System.Int32
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyViaIdentity, ModifyViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MinuteFrequency
Frequency in minutes

```yaml
Type: System.Int32
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MonthlyFrequency
Frequency in months.
Only for incremental backup frequency.

```yaml
Type: System.Int32
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MonthlyFrequencyDayOfMonth
Only available for incremental backup frequency

```yaml
Type: System.Int32
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MonthlyFrequencyDayOfWeek
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

### -MonthlyFrequencyWeekOfMonth
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

### -ScheduleId
.

```yaml
Type: System.String
Parameter Sets: Modify, ModifyExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SchedulePolicyId
.

```yaml
Type: System.String
Parameter Sets: Modify, ModifyExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTime
Time in seconds from the beginning of the day when the backup starts.
This is a mandatory field for daily, weekly, monthly, yearly frequencies

```yaml
Type: System.Int32
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WeeklyFrequency
Frequency in weeks.
Only for incremental backup frequency.

```yaml
Type: System.Int32
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WeeklyFrequencyDays
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

### -YearlyFrequencyDayOfMonth
Only available for incremental backup frequency

```yaml
Type: System.Int32
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -YearlyFrequencyDayOfWeek
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

### -YearlyFrequencyMonthOfYear
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

### -YearlyFrequencyWeekOfMonth
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

### Commvault.Powershell.Models.IPlanPattern

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IPlanPattern>: If updating pattern, the value which needs to be retained also needs to be provided along with the updated value
  - `[DailyFrequency <Int32?>]`: Frequency in days
  - `[HourlyFrequency <Int32?>]`: Frequency in hours per day. Precedence is hourly, daily, weekly and monthly, in that order.
  - `[MinuteFrequency <Int32?>]`: Frequency in minutes
  - `[MonthlyFrequency <Int32?>]`: Frequency in months. Only for incremental backup frequency.
  - `[MonthlyFrequencyDayOfMonth <Int32?>]`: Only available for incremental backup frequency
  - `[MonthlyFrequencyDayOfWeek <String>]`: 
  - `[MonthlyFrequencyWeekOfMonth <String>]`: Specific week of a month
  - `[StartTime <Int32?>]`: Time in seconds from the beginning of the day when the backup starts. This is a mandatory field for daily, weekly, monthly, yearly frequencies
  - `[WeeklyFrequency <Int32?>]`: Frequency in weeks. Only for incremental backup frequency.
  - `[WeeklyFrequencyDays <String[]>]`: Days of the week for weekly frequency
  - `[YearlyFrequencyDayOfMonth <Int32?>]`: Only available for incremental backup frequency
  - `[YearlyFrequencyDayOfWeek <String>]`: 
  - `[YearlyFrequencyMonthOfYear <String>]`: 
  - `[YearlyFrequencyWeekOfMonth <String>]`: Specific week of a month

INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
  - `[AccessPathId <Int32?>]`: Id of the mount path whose access path has to be deleted
  - `[AgentId <Int32?>]`: Id of the agent to be modified
  - `[BackupDestinationId <Int32?>]`: Id of the backupDestination to be modified
  - `[BackupLocationId <Int32?>]`: Id of the backup location whose details have to be fetched
  - `[BlackoutWindowId <Int32?>]`: Id of the Blackout Window whose details have to be fetched
  - `[BucketId <Int32?>]`: Id of Bucket
  - `[CloudStorageId <Int32?>]`: Id of cloud Storage
  - `[CompanyId <Int32?>]`: Id of the Company whose details have to be fetched
  - `[CredentialName <String>]`: 
  - `[DomainId <Int32?>]`: ID of the AD/LDAP domain
  - `[EntityId <Int32?>]`: Unique id for the entity
  - `[EntityType <String>]`: Type of the entity
  - `[GlobalSearchEntity <String>]`: name of global search entity
  - `[HfsShareId <Int32?>]`: Id of the HFS Share to fetch its status
  - `[HyperScaleStorageId <Int32?>]`: Id of hyperscale storage
  - `[HypervisorId <Int32?>]`: Id of the HYpervisor to get
  - `[Id <Int32?>]`: 
  - `[InstanceId <Int32?>]`: Id of the instance to modify
  - `[KmsId <Int32?>]`: Id of Key Management Server
  - `[MediaAgentId <Int32?>]`: Id of the Media Agent whose details have to be fetched
  - `[MetadataCacheId <Int32?>]`: Id of metadata cache
  - `[Name <String>]`: 
  - `[NodeId <Int32?>]`: Id of node
  - `[PairId <Int32?>]`: 
  - `[PlanId <Int32?>]`: Id of the plan to fetch details
  - `[RecoveryTargetId <Int32?>]`: id of recovery target
  - `[RegionId <String>]`: 
  - `[RegionList <String>]`: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  - `[ReplicationGroupId <String>]`: 
  - `[RequestId <Int32?>]`: Unique identifier for the request
  - `[RoleId <Int32?>]`: Role Id
  - `[RpsId <String>]`: 
  - `[RuleId <Int32?>]`: Id of the rule to update in Plan
  - `[ScheduleId <String>]`: 
  - `[SchedulePolicyId <String>]`: 
  - `[ServerGroupId <Int32?>]`: Id of the serverGroupId whose details have to be fetched
  - `[ServerId <Int32?>]`: Id of the server to modify
  - `[StoragePoolId <Int32?>]`: Id of the disk storage pool whose details have to be fetched
  - `[SubclientId <Int32?>]`: Id of the subclient to modify
  - `[TopologyId <String>]`: 
  - `[UserGroupId <Int32?>]`: Id of the user-group whose details have to be fetched
  - `[UserId <Int32?>]`: Id of the User whose details have to be fetched
  - `[VMGroupId <Int32?>]`: Id of the VMgroup to update
  - `[VMUuid <String>]`: The vmUUID can be obtained from GET /virtualMachines UUID property

## RELATED LINKS

