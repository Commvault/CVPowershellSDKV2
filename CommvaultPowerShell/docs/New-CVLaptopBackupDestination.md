---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/new-cvlaptopbackupdestination
schema: 2.0.0
---

# New-CVLaptopBackupDestination

## SYNOPSIS
Create a Backup Destination for a Plan

## SYNTAX

### CreateExpanded (Default)
```
New-CVLaptopBackupDestination -PlanId <Int64> [-BackupCopyOptionAction <String>]
 [-BackupCopyOptionAlertInHours <Int64>] [-BackupCopyOptionBackupFullToCopy <String>]
 [-BackupCopyOptionBackupTypeToCopy <String>] [-BackupCopyOptionEnableAlert]
 [-BackupCopyOptionSkipAfterThresholdDays <Int64>] [-BackupCopyOptionStartTime <Int64>]
 [-Destinations <ICreatePlanBackupDestination[]>] [-RegionGuid <String>] [-RegionId <Int64>]
 [-RegionName <String>] [-SnapshotOptionBackupCopyRpoMins <Int64>] [-SnapshotOptionEnableBackupCopy]
 [-SnapshotOptionEnableSnapCatalog] [-SnapshotOptionRetentionPeriodDays <Int64>]
 [-SnapshotOptionSnapRecoveryPoints <Int64>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-CVLaptopBackupDestination -InputObject <ICommvaultPowerShellIdentity> [-BackupCopyOptionAction <String>]
 [-BackupCopyOptionAlertInHours <Int64>] [-BackupCopyOptionBackupFullToCopy <String>]
 [-BackupCopyOptionBackupTypeToCopy <String>] [-BackupCopyOptionEnableAlert]
 [-BackupCopyOptionSkipAfterThresholdDays <Int64>] [-BackupCopyOptionStartTime <Int64>]
 [-Destinations <ICreatePlanBackupDestination[]>] [-RegionGuid <String>] [-RegionId <Int64>]
 [-RegionName <String>] [-SnapshotOptionBackupCopyRpoMins <Int64>] [-SnapshotOptionEnableBackupCopy]
 [-SnapshotOptionEnableSnapCatalog] [-SnapshotOptionRetentionPeriodDays <Int64>]
 [-SnapshotOptionSnapRecoveryPoints <Int64>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a Backup Destination for a Plan

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

### -Destinations
List of backup destinations to create

```yaml
Type: Commvault.Powershell.Models.ICreatePlanBackupDestination[]
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

### -RegionGuid
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

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`DESTINATIONS <ICreatePlanBackupDestination[]>`: List of backup destinations to create
  - `BackupDestinationName <String>`: Backup destination details. Enter the name during creation.
  - `[BackupStartTime <Int64?>]`: Backup start time in seconds. The time is provided in unix time format.
  - `[BackupsToCopy <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[FirstExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[FirstExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[FirstExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[FullBackupTypesToCopy <String>]`: Which type of backup type should be copied for the given backup destination when backup type is not all jobs. Default is LAST while adding new backup destination.
  - `[IsConfiguredForReplication <Boolean?>]`: Used if the copy is used for replication group
  - `[IsMirrorCopy <Boolean?>]`: Is this a mirror copy? Only considered when isSnapCopy is true.
  - `[IsSnapCopy <Boolean?>]`: Is this a snap copy? If isMirrorCopy is not set, then default is Vault/Replica.
  - `[Mappings <List<ISnapshotCopyMapping>>]`: 
    - `[MappingType <String>]`: Mapping type for pure storage replicaton
    - `[SourceId <Int64?>]`: 
    - `[SourceName <String>]`: 
    - `[SourceVendorId <Int64?>]`: 
    - `[SourceVendorName <String>]`: 
    - `[Subclients <List<IIdName>>]`: 
      - `[Id <Int64?>]`: 
      - `[Name <String>]`: 
    - `[TargetId <Int64?>]`: 
    - `[TargetName <String>]`: 
    - `[TargetVendorId <Int64?>]`: 
    - `[TargetVendorName <String>]`: 
    - `[Vendor <String>]`: Snapshot vendors available for Snap Copy mappings
  - `[NetAppCloudTarget <Boolean?>]`: Only for snap copy. Enabling this changes SVM Mapping  to NetApp cloud targets only.
  - `[OptimizeForInstantClone <Boolean?>]`: Flag to specify if primary storage is copy data management enabled.
  - `[OverrideRetentionSettings <Boolean?>]`: Tells if this copy should use storage pool retention period days or the retention defined for this copy. Set as true to use retention defined on this copy.
  - `[RegionGuid <String>]`: 
  - `[RegionId <Int64?>]`: 
  - `[RegionName <String>]`: 
  - `[RetentionPeriodDays <Int64?>]`: Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified, this takes  precedence.
  - `[RetentionRuleType <String>]`: Which type of retention rule should be used for the given backup destination
  - `[SecondExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[SecondExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[SecondExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[SnapRecoveryPoints <Int64?>]`: Number of snap recovery points for snap copy for retention. Can be specified instead of retention period in Days for snap copy.
  - `[SourceCopyId <Int64?>]`: 
  - `[SourceCopyName <String>]`: 
  - `[StoragePoolId <Int64?>]`: 
  - `[StoragePoolName <String>]`: 
  - `[StorageTemplateTags <List<IIdNameValue>>]`: It is used in Global config template plan creation. Needs in plan creation on global commcell
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 
    - `[Value <String>]`: 
  - `[StorageType <String>]`: StorageType
  - `[ThirdExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[ThirdExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[ThirdExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[UseExtendedRetentionRules <Boolean?>]`: Use extended retention rules

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

## RELATED LINKS
