---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-cvmodifybackupdestinationdetail
schema: 2.0.0
---

# Invoke-CVModifyBackupDestinationDetail

## SYNOPSIS
Modify Backup Destination details for a Plan

## SYNTAX

### ModifyExpanded (Default)
```
Invoke-CVModifyBackupDestinationDetail -BackupDestinationId <Int64> -PlanId <Int64>
 [-BackupTypeBackupTypesCopiedFrom <Int64>] [-BackupTypeBackupTypesToCopy <String>]
 [-BackupTypeFullBackupTypesToCopy <String>] [-FirstExtendedRetentionRuleIsInfiniteRetention]
 [-FirstExtendedRetentionRuleRetentionPeriodDays <Int64>] [-FirstExtendedRetentionRuleType <String>]
 [-GeneralIsActive] [-Mappings <ISnapshotCopyMapping[]>] [-NewName <String>] [-RetentionRuleEnableDataAging]
 [-RetentionRuleFullBackupTypesToBeRetained <String>] [-RetentionRuleOverrideRetentionSettings]
 [-RetentionRuleRetentionPeriodDays <Int64>] [-RetentionRuleSnapRecoveryPoints <Int64>]
 [-RetentionRuleType <String>] [-RetentionRuleUseExtendedRetentionRules]
 [-SecondExtendedRetentionRuleIsInfiniteRetention] [-SecondExtendedRetentionRuleRetentionPeriodDays <Int64>]
 [-SecondExtendedRetentionRuleType <String>] [-SourceId <Int64>] [-SourceName <String>]
 [-ThirdExtendedRetentionRuleIsInfiniteRetention] [-ThirdExtendedRetentionRuleRetentionPeriodDays <Int64>]
 [-ThirdExtendedRetentionRuleType <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Modify
```
Invoke-CVModifyBackupDestinationDetail -BackupDestinationId <Int64> -PlanId <Int64>
 -Body <IUpdatePlanBackupDestinationDetails> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentity
```
Invoke-CVModifyBackupDestinationDetail -InputObject <ICommvaultPowerShellIdentity>
 -Body <IUpdatePlanBackupDestinationDetails> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentityExpanded
```
Invoke-CVModifyBackupDestinationDetail -InputObject <ICommvaultPowerShellIdentity>
 [-BackupTypeBackupTypesCopiedFrom <Int64>] [-BackupTypeBackupTypesToCopy <String>]
 [-BackupTypeFullBackupTypesToCopy <String>] [-FirstExtendedRetentionRuleIsInfiniteRetention]
 [-FirstExtendedRetentionRuleRetentionPeriodDays <Int64>] [-FirstExtendedRetentionRuleType <String>]
 [-GeneralIsActive] [-Mappings <ISnapshotCopyMapping[]>] [-NewName <String>] [-RetentionRuleEnableDataAging]
 [-RetentionRuleFullBackupTypesToBeRetained <String>] [-RetentionRuleOverrideRetentionSettings]
 [-RetentionRuleRetentionPeriodDays <Int64>] [-RetentionRuleSnapRecoveryPoints <Int64>]
 [-RetentionRuleType <String>] [-RetentionRuleUseExtendedRetentionRules]
 [-SecondExtendedRetentionRuleIsInfiniteRetention] [-SecondExtendedRetentionRuleRetentionPeriodDays <Int64>]
 [-SecondExtendedRetentionRuleType <String>] [-SourceId <Int64>] [-SourceName <String>]
 [-ThirdExtendedRetentionRuleIsInfiniteRetention] [-ThirdExtendedRetentionRuleRetentionPeriodDays <Int64>]
 [-ThirdExtendedRetentionRuleType <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Modify Backup Destination details for a Plan

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

### -BackupTypeBackupTypesCopiedFrom
Tells what start date, backup types should be copied from.
The date is provided in unix time format in number of seconds.
-1 means initial backup date.

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

### -BackupTypeBackupTypesToCopy
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

### -BackupTypeFullBackupTypesToCopy
Which type of backup type should be copied for the given backup destination when backup type is not all jobs.
Default is LAST while adding new backup destination.

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
Type: Commvault.Powershell.Models.IUpdatePlanBackupDestinationDetails
Parameter Sets: Modify, ModifyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -GeneralIsActive
Toggle to keep backup destination active

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

### -NewName
New name for backup destination

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
Parameter Sets: Modify, ModifyExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RetentionRuleEnableDataAging
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

### -RetentionRuleFullBackupTypesToBeRetained
Which type of backup type should be copied for the given backup destination when backup type is not all jobs.
Default is LAST while adding new backup destination.

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

### -RetentionRuleOverrideRetentionSettings
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

### -RetentionRuleRetentionPeriodDays
Retention period in days

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

### -RetentionRuleSnapRecoveryPoints
Number of snap recovery points for snap copy for retention

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

### -RetentionRuleUseExtendedRetentionRules
Should extended retention rules be used

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

### -SourceId
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

### -SourceName
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

### Commvault.Powershell.Models.IUpdatePlanBackupDestinationDetails

## OUTPUTS

### Commvault.Powershell.Models.IPlanBackupDestinationResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IUpdatePlanBackupDestinationDetails>: .
  - `[BackupTypeBackupTypesCopiedFrom <Int64?>]`: Tells what start date, backup types should be copied from. The date is provided in unix time format in number of seconds. -1 means initial backup date.
  - `[BackupTypeBackupTypesToCopy <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[BackupTypeFullBackupTypesToCopy <String>]`: Which type of backup type should be copied for the given backup destination when backup type is not all jobs. Default is LAST while adding new backup destination.
  - `[FirstExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[FirstExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[FirstExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[GeneralIsActive <Boolean?>]`: Toggle to keep backup destination active
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
  - `[NewName <String>]`: New name for backup destination
  - `[RetentionRuleEnableDataAging <Boolean?>]`: Tells if this copy has data aging enabled
  - `[RetentionRuleFullBackupTypesToBeRetained <String>]`: Which type of backup type should be copied for the given backup destination when backup type is not all jobs. Default is LAST while adding new backup destination.
  - `[RetentionRuleOverrideRetentionSettings <Boolean?>]`: Tells if this copy should use storage pool retention period days or the retention defined for this copy. Set as true to use retention defined on this copy.
  - `[RetentionRuleRetentionPeriodDays <Int64?>]`: Retention period in days
  - `[RetentionRuleSnapRecoveryPoints <Int64?>]`: Number of snap recovery points for snap copy for retention
  - `[RetentionRuleType <String>]`: Which type of retention rule should be used for the given backup destination
  - `[RetentionRuleUseExtendedRetentionRules <Boolean?>]`: Should extended retention rules be used
  - `[SecondExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[SecondExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[SecondExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[SourceId <Int64?>]`: 
  - `[SourceName <String>]`: 
  - `[ThirdExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[ThirdExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[ThirdExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.

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

