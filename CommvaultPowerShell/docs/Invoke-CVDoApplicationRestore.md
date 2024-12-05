---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/invoke-cvdoapplicationrestore
schema: 2.0.0
---

# Invoke-CVDoApplicationRestore

## SYNOPSIS
API to run Full Application Restore for an application group

## SYNTAX

### DoExpanded (Default)
```
Invoke-CVDoApplicationRestore -ApplicationGroupId <Int64> [-AccessNodeId <Int64>] [-AccessNodeName <String>]
 [-Applications <IKubernetesApplicationRestoreItem[]>] [-DestinationClusterId <Int64>]
 [-DestinationClusterName <String>] [-InPlace] [-Modifier <String>] [-Overwrite] [-TimeRangeFromTime <String>]
 [-TimeRangeToTime <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Do
```
Invoke-CVDoApplicationRestore -ApplicationGroupId <Int64> -Body <IKubernetesAppGroupApplicationRestore>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DoViaIdentity
```
Invoke-CVDoApplicationRestore -InputObject <ICommvaultPowerShellIdentity>
 -Body <IKubernetesAppGroupApplicationRestore> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DoViaIdentityExpanded
```
Invoke-CVDoApplicationRestore -InputObject <ICommvaultPowerShellIdentity> [-AccessNodeId <Int64>]
 [-AccessNodeName <String>] [-Applications <IKubernetesApplicationRestoreItem[]>]
 [-DestinationClusterId <Int64>] [-DestinationClusterName <String>] [-InPlace] [-Modifier <String>]
 [-Overwrite] [-TimeRangeFromTime <String>] [-TimeRangeToTime <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
API to run Full Application Restore for an application group

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

### -AccessNodeId
.

```yaml
Type: System.Int64
Parameter Sets: DoExpanded, DoViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessNodeName
.

```yaml
Type: System.String
Parameter Sets: DoExpanded, DoViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationGroupId
ID of the application group to restore from

```yaml
Type: System.Int64
Parameter Sets: Do, DoExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Applications
.

```yaml
Type: Commvault.Powershell.Models.IKubernetesApplicationRestoreItem[]
Parameter Sets: DoExpanded, DoViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Request body for Full Application Restore of Application Group

```yaml
Type: Commvault.Powershell.Models.IKubernetesAppGroupApplicationRestore
Parameter Sets: Do, DoViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DestinationClusterId
.

```yaml
Type: System.Int64
Parameter Sets: DoExpanded, DoViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DestinationClusterName
.

```yaml
Type: System.String
Parameter Sets: DoExpanded, DoViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InPlace
Run In-Place restore job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: DoExpanded, DoViaIdentityExpanded
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
Parameter Sets: DoViaIdentity, DoViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Modifier
Specify list of resource modifier YAML as a string

```yaml
Type: System.String
Parameter Sets: DoExpanded, DoViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Overwrite
Overwrite if already present

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: DoExpanded, DoViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeRangeFromTime
From time value in unix timestamp format

```yaml
Type: System.String
Parameter Sets: DoExpanded, DoViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeRangeToTime
To time value in unix timestamp format

```yaml
Type: System.String
Parameter Sets: DoExpanded, DoViaIdentityExpanded
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

### Commvault.Powershell.Models.IKubernetesAppGroupApplicationRestore

## OUTPUTS

### Commvault.Powershell.Models.ICreateTaskRespforBackup

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`APPLICATIONS <IKubernetesApplicationRestoreItem[]>`: .
  - `[Guid <String>]`: 
  - `[Name <String>]`: 
  - `[NameSpace <String>]`: Specify destination namespace of the Application (Picks the source namespace if not specified)
  - `[StorageClass <String>]`: Specify destination storage class to use for restoring PVC (Picks the source storage class if not specified)

`BODY <IKubernetesAppGroupApplicationRestore>`: Request body for Full Application Restore of Application Group
  - `[AccessNodeId <Int64?>]`: 
  - `[AccessNodeName <String>]`: 
  - `[DestinationClusterId <Int64?>]`: 
  - `[DestinationClusterName <String>]`: 
  - `[InPlace <Boolean?>]`: Run In-Place restore job
  - `[Modifier <String>]`: Specify list of resource modifier YAML as a string
  - `[Overwrite <Boolean?>]`: Overwrite if already present
  - `[TimeRangeFromTime <String>]`: From time value in unix timestamp format
  - `[TimeRangeToTime <String>]`: To time value in unix timestamp format
  - `[Applications <List<IKubernetesApplicationRestoreItem>>]`: 
    - `[NameSpace <String>]`: Specify destination namespace of the Application (Picks the source namespace if not specified)
    - `[StorageClass <String>]`: Specify destination storage class to use for restoring PVC (Picks the source storage class if not specified)

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

