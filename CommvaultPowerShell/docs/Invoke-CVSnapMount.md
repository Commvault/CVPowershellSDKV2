---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/invoke-cvsnapmount
schema: 2.0.0
---

# Invoke-CVSnapMount

## SYNOPSIS
Mounting a snapshot from the Storage Array

## SYNTAX

### SnapExpanded (Default)
```
Invoke-CVSnapMount -ArrayId <Int64> [-AppId <IAny>] [-DestinationClientId <Int64>]
 [-DestinationClientPath <String>] [-ProtectSnap <Int64>] [-ScsiServerId <Int64>] [-ScsiServerName <String>]
 [-Server <IAny>] [-UserName <String>] [-Volumes <IVolumeSnap[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Snap
```
Invoke-CVSnapMount -ArrayId <Int64> -Body <IMountReq> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SnapViaIdentity
```
Invoke-CVSnapMount -InputObject <ICommvaultPowerShellIdentity> -Body <IMountReq> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### SnapViaIdentityExpanded
```
Invoke-CVSnapMount -InputObject <ICommvaultPowerShellIdentity> [-AppId <IAny>] [-DestinationClientId <Int64>]
 [-DestinationClientPath <String>] [-ProtectSnap <Int64>] [-ScsiServerId <Int64>] [-ScsiServerName <String>]
 [-Server <IAny>] [-UserName <String>] [-Volumes <IVolumeSnap[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Mounting a snapshot from the Storage Array

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

### -AppId
Anything

```yaml
Type: Commvault.Powershell.Models.IAny
Parameter Sets: SnapExpanded, SnapViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ArrayId
.

```yaml
Type: System.Int64
Parameter Sets: Snap, SnapExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Request template for Mounting Snapshots.
scsiServer refers to the iSCSI server which the user can choose while mounting.

```yaml
Type: Commvault.Powershell.Models.IMountReq
Parameter Sets: Snap, SnapViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DestinationClientId
Id of the MA where the Snap is mounted

```yaml
Type: System.Int64
Parameter Sets: SnapExpanded, SnapViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DestinationClientPath
Path where the snap is mounted

```yaml
Type: System.String
Parameter Sets: SnapExpanded, SnapViaIdentityExpanded
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
Parameter Sets: SnapViaIdentity, SnapViaIdentityExpanded
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

### -ProtectSnap
Enable or disable VSS protection on Snaps while mounting

```yaml
Type: System.Int64
Parameter Sets: SnapExpanded, SnapViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScsiServerId
.

```yaml
Type: System.Int64
Parameter Sets: SnapExpanded, SnapViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScsiServerName
.

```yaml
Type: System.String
Parameter Sets: SnapExpanded, SnapViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Server
Anything

```yaml
Type: Commvault.Powershell.Models.IAny
Parameter Sets: SnapExpanded, SnapViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserName
.

```yaml
Type: System.String
Parameter Sets: SnapExpanded, SnapViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Volumes
Volumes of the snap you want to mount

```yaml
Type: Commvault.Powershell.Models.IVolumeSnap[]
Parameter Sets: SnapExpanded, SnapViaIdentityExpanded
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

### Commvault.Powershell.Models.IMountReq

## OUTPUTS

### Commvault.Powershell.Models.ISnapReconResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IMountReq>`: Request template for Mounting Snapshots. scsiServer refers to the iSCSI server which the user can choose while mounting.
  - `[AppId <IAny>]`: Anything
  - `[DestinationClientId <Int64?>]`: Id of the MA where the Snap is mounted
  - `[DestinationClientPath <String>]`: Path where the snap is mounted
  - `[ProtectSnap <Int64?>]`: Enable or disable VSS protection on Snaps while mounting
  - `[ScsiServerId <Int64?>]`: 
  - `[ScsiServerName <String>]`: 
  - `[Server <IAny>]`: Anything
  - `[UserName <String>]`: 
  - `[Volumes <List<IVolumeSnap>>]`: Volumes of the snap you want to mount
    - `[Flags <Int64?>]`: Volume flags to be set for snap Operations.
    - `[SmVolumeId <Int64?>]`: smVolumeId of the snaps you want to mount/unmount/delete

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

`VOLUMES <IVolumeSnap[]>`: Volumes of the snap you want to mount
  - `[Flags <Int64?>]`: Volume flags to be set for snap Operations.
  - `[SmVolumeId <Int64?>]`: smVolumeId of the snaps you want to mount/unmount/delete

## RELATED LINKS

