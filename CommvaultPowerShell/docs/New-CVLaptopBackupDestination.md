---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-cvlaptopbackupdestination
schema: 2.0.0
---

# New-CVLaptopBackupDestination

## SYNOPSIS
Create a Backup Destination for a Plan

## SYNTAX

### CreateExpanded (Default)
```
New-CVLaptopBackupDestination -PlanId <Int64> -Destinations <ICreatePlanBackupDestination[]>
 [-RegionId <Int64>] [-RegionName <String>] [-SnapshotOptionBackupCopyRpoMins <Int64>]
 [-SnapshotOptionEnableBackupCopy] [-SnapshotOptionRetentionPeriodDays <Int64>]
 [-SnapshotOptionSnapRecoveryPoints <Int64>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-CVLaptopBackupDestination -InputObject <ICommvaultPowerShellIdentity>
 -Destinations <ICreatePlanBackupDestination[]> [-RegionId <Int64>] [-RegionName <String>]
 [-SnapshotOptionBackupCopyRpoMins <Int64>] [-SnapshotOptionEnableBackupCopy]
 [-SnapshotOptionRetentionPeriodDays <Int64>] [-SnapshotOptionSnapRecoveryPoints <Int64>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a Backup Destination for a Plan

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

### -Destinations
List of backup destinations to create
To construct, see NOTES section for DESTINATIONS properties and create a hash table.

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

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
Id of the Plan to modify

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

### -RegionId
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

### -RegionName
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

### Commvault.Powershell.Models.ICommvaultPowerShellIdentity

## OUTPUTS

### Commvault.Powershell.Models.IPlanBackupDestinationResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


DESTINATIONS <ICreatePlanBackupDestination[]>: List of backup destinations to create
  - `BackupDestinationName <String>`: Backup destination details. Enter the name during creation.
  - `[BackupStartTime <Int64?>]`: Backup start time in seconds. The time is provided in unix time format.
  - `[BackupsToCopy <String>]`: 
  - `[FirstExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: 
  - `[FirstExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
  - `[FirstExtendedRetentionRuleType <String>]`: 
  - `[IsMirrorCopy <Boolean?>]`: Is this a mirror copy? Only considered when isSnapCopy is true.
  - `[IsSnapCopy <Boolean?>]`: Is this a snap copy? If isMirrorCopy is not set, then default is Vault/Replica.
  - `[Mappings <ISnapshotCopyMapping[]>]`: 
    - `[SourceId <Int64?>]`: 
    - `[SourceName <String>]`: 
    - `[TargetId <Int64?>]`: 
    - `[TargetName <String>]`: 
    - `[Vendor <String>]`: Snapshot vendors available for Snap Copy mappings
  - `[NetAppCloudTarget <Boolean?>]`: Only for snap copy. Enabling this changes SVM Mapping  to NetApp cloud targets only.
  - `[OptimizeForInstantClone <Boolean?>]`: Flag to specify if primary storage is copy data management enabled.
  - `[RegionId <Int64?>]`: 
  - `[RegionName <String>]`: 
  - `[RetentionPeriodDays <Int64?>]`: Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified, this takes  precedence.
  - `[RetentionRuleType <String>]`: Which type of retention rule should be used for the given backup destination
  - `[SecondExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: 
  - `[SecondExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
  - `[SecondExtendedRetentionRuleType <String>]`: 
  - `[SnapRecoveryPoints <Int64?>]`: Number of snap recovery points for snap copy for retention. Can be specified instead of retention period in Days for snap copy.
  - `[SourceCopyId <Int64?>]`: 
  - `[SourceCopyName <String>]`: 
  - `[StoragePoolId <Int64?>]`: 
  - `[StoragePoolName <String>]`: 
  - `[ThirdExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: 
  - `[ThirdExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
  - `[ThirdExtendedRetentionRuleType <String>]`: 
  - `[UseExtendedRetentionRules <Boolean?>]`: Use extended retention rules

INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
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
  - `[HypervisorId <Int64?>]`: Id of the HYpervisor to get
  - `[Id <Int64?>]`: 
  - `[InstanceId <Int64?>]`: Id of the instance to modify
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

## RELATED LINKS

