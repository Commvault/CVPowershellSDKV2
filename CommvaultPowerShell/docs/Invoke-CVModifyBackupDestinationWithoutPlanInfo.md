---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-cvmodifybackupdestinationwithoutplaninfo
schema: 2.0.0
---

# Invoke-CVModifyBackupDestinationWithoutPlanInfo

## SYNOPSIS
Modify Backup Destination.
Only primary backup destination will be considered for region updation.\nIf the primary backup destination is not associated with a plan, only then the region associaion can be modified.

## SYNTAX

### ModifyExpanded (Default)
```
Invoke-CVModifyBackupDestinationWithoutPlanInfo -BackupDestinationId <Int64> [-BackupStartTime <Int64>]
 [-BackupsToCopy <String>] [-EnableDataAging] [-FirstExtendedRetentionRuleIsInfiniteRetention]
 [-FirstExtendedRetentionRuleRetentionPeriodDays <Int64>] [-FirstExtendedRetentionRuleType <String>]
 [-Mappings <ISnapshotCopyMapping[]>] [-Name <String>] [-OverrideRetentionSettings] [-RegionId <Int64>]
 [-RegionName <String>] [-RetentionPeriodDays <Int64>] [-RetentionRuleType <String>]
 [-SecondExtendedRetentionRuleIsInfiniteRetention] [-SecondExtendedRetentionRuleRetentionPeriodDays <Int64>]
 [-SecondExtendedRetentionRuleType <String>] [-SnapRecoveryPoints <Int64>] [-SourceCopyId <Int64>]
 [-SourceCopyName <String>] [-ThirdExtendedRetentionRuleIsInfiniteRetention]
 [-ThirdExtendedRetentionRuleRetentionPeriodDays <Int64>] [-ThirdExtendedRetentionRuleType <String>]
 [-UseExtendedRetentionRules] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Modify
```
Invoke-CVModifyBackupDestinationWithoutPlanInfo -BackupDestinationId <Int64> -Body <IUpdateBackupDestination>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentity
```
Invoke-CVModifyBackupDestinationWithoutPlanInfo -InputObject <ICommvaultPowerShellIdentity>
 -Body <IUpdateBackupDestination> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentityExpanded
```
Invoke-CVModifyBackupDestinationWithoutPlanInfo -InputObject <ICommvaultPowerShellIdentity>
 [-BackupStartTime <Int64>] [-BackupsToCopy <String>] [-EnableDataAging]
 [-FirstExtendedRetentionRuleIsInfiniteRetention] [-FirstExtendedRetentionRuleRetentionPeriodDays <Int64>]
 [-FirstExtendedRetentionRuleType <String>] [-Mappings <ISnapshotCopyMapping[]>] [-Name <String>]
 [-OverrideRetentionSettings] [-RegionId <Int64>] [-RegionName <String>] [-RetentionPeriodDays <Int64>]
 [-RetentionRuleType <String>] [-SecondExtendedRetentionRuleIsInfiniteRetention]
 [-SecondExtendedRetentionRuleRetentionPeriodDays <Int64>] [-SecondExtendedRetentionRuleType <String>]
 [-SnapRecoveryPoints <Int64>] [-SourceCopyId <Int64>] [-SourceCopyName <String>]
 [-ThirdExtendedRetentionRuleIsInfiniteRetention] [-ThirdExtendedRetentionRuleRetentionPeriodDays <Int64>]
 [-ThirdExtendedRetentionRuleType <String>] [-UseExtendedRetentionRules] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Modify Backup Destination.
Only primary backup destination will be considered for region updation.\nIf the primary backup destination is not associated with a plan, only then the region associaion can be modified.

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

### -BackupDestinationId
Id of the backupDestination to be modified

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

### -BackupStartTime
Specify the Backup start time in seconds.
The time is provided in unix time format.

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

### -BackupsToCopy
All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.

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
Region can be modified only when the backup destination does not belong to a region already
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IUpdateBackupDestination
Parameter Sets: Modify, ModifyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EnableDataAging
Tells if this copy has data aging enabled

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

### -FirstExtendedRetentionRuleIsInfiniteRetention
If this is set as true, no need to specify retentionPeriodDays.

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

### -FirstExtendedRetentionRuleRetentionPeriodDays
If this is set, no need to specify isInfiniteRetention as false.

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

### -FirstExtendedRetentionRuleType
All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.

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

### -Mappings
.
To construct, see NOTES section for MAPPINGS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ISnapshotCopyMapping[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Name of backup destination

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

### -OverrideRetentionSettings
Tells if this copy should use storage pool retention period days or the retention defined for this copy.
Set as true to use retention defined on this copy.

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

### -RegionId
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

### -RegionName
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

### -RetentionPeriodDays
Retention period in days.
-1 can be specified for infinite retention.

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

### -RetentionRuleType
Which type of retention rule should be used for the given backup destination

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

### -SecondExtendedRetentionRuleIsInfiniteRetention
If this is set as true, no need to specify retentionPeriodDays.

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

### -SecondExtendedRetentionRuleRetentionPeriodDays
If this is set, no need to specify isInfiniteRetention as false.

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

### -SecondExtendedRetentionRuleType
All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.

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

### -SnapRecoveryPoints
Number of snap recovery points for snap copy for retention.
Can be specified instead of retention period in Days for snap copy.

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

### -SourceCopyId
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

### -SourceCopyName
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

### -ThirdExtendedRetentionRuleIsInfiniteRetention
If this is set as true, no need to specify retentionPeriodDays.

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

### -ThirdExtendedRetentionRuleRetentionPeriodDays
If this is set, no need to specify isInfiniteRetention as false.

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

### -ThirdExtendedRetentionRuleType
All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.

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

### -UseExtendedRetentionRules
Use extended retention rules.
Must specify if updating extended retention rules.

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

### Commvault.Powershell.Models.IUpdateBackupDestination

## OUTPUTS

### Commvault.Powershell.Models.IPlanBackupDestinationResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IUpdateBackupDestination>: Region can be modified only when the backup destination does not belong to a region already
  - `[BackupStartTime <Int64?>]`: Specify the Backup start time in seconds. The time is provided in unix time format.
  - `[BackupsToCopy <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[EnableDataAging <Boolean?>]`: Tells if this copy has data aging enabled
  - `[FirstExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[FirstExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[FirstExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[Mappings <ISnapshotCopyMapping[]>]`: 
    - `[SourceId <Int64?>]`: 
    - `[SourceName <String>]`: 
    - `[SourceVendorId <Int64?>]`: 
    - `[SourceVendorName <String>]`: 
    - `[TargetId <Int64?>]`: 
    - `[TargetName <String>]`: 
    - `[TargetVendorId <Int64?>]`: 
    - `[TargetVendorName <String>]`: 
    - `[Vendor <String>]`: Snapshot vendors available for Snap Copy mappings
  - `[Name <String>]`: Name of backup destination
  - `[OverrideRetentionSettings <Boolean?>]`: Tells if this copy should use storage pool retention period days or the retention defined for this copy. Set as true to use retention defined on this copy.
  - `[RegionId <Int64?>]`: 
  - `[RegionName <String>]`: 
  - `[RetentionPeriodDays <Int64?>]`: Retention period in days. -1 can be specified for infinite retention.
  - `[RetentionRuleType <String>]`: Which type of retention rule should be used for the given backup destination
  - `[SecondExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[SecondExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[SecondExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[SnapRecoveryPoints <Int64?>]`: Number of snap recovery points for snap copy for retention. Can be specified instead of retention period in Days for snap copy.
  - `[SourceCopyId <Int64?>]`: 
  - `[SourceCopyName <String>]`: 
  - `[ThirdExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[ThirdExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[ThirdExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[UseExtendedRetentionRules <Boolean?>]`: Use extended retention rules. Must specify if updating extended retention rules.

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

MAPPINGS <ISnapshotCopyMapping[]>: .
  - `[SourceId <Int64?>]`: 
  - `[SourceName <String>]`: 
  - `[SourceVendorId <Int64?>]`: 
  - `[SourceVendorName <String>]`: 
  - `[TargetId <Int64?>]`: 
  - `[TargetName <String>]`: 
  - `[TargetVendorId <Int64?>]`: 
  - `[TargetVendorName <String>]`: 
  - `[Vendor <String>]`: Snapshot vendors available for Snap Copy mappings

## RELATED LINKS

