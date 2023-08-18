---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/edit-cvsubclientsnapconfig
schema: 2.0.0
---

# Edit-CVSubclientSnapConfig

## SYNOPSIS
API to edit Snap Configurations at Subclient level

## SYNTAX

### EditExpanded (Default)
```
Edit-CVSubclientSnapConfig -ArrayId <Int64> -SubclientId <Int64>
 [-SnapConfigurations <ISnapConfigsOverrideEdit[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Edit
```
Edit-CVSubclientSnapConfig -ArrayId <Int64> -SubclientId <Int64> -Body <ISnapConfigOverrideEditReq> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### EditViaIdentity
```
Edit-CVSubclientSnapConfig -InputObject <ICommvaultPowerShellIdentity> -Body <ISnapConfigOverrideEditReq>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### EditViaIdentityExpanded
```
Edit-CVSubclientSnapConfig -InputObject <ICommvaultPowerShellIdentity>
 [-SnapConfigurations <ISnapConfigsOverrideEdit[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to edit Snap Configurations at Subclient level

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

### -ArrayId
.

```yaml
Type: System.Int64
Parameter Sets: Edit, EditExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Request Template to edit Snap Config
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ISnapConfigOverrideEditReq
Parameter Sets: Edit, EditViaIdentity
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
Parameter Sets: EditViaIdentity, EditViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SnapConfigurations
.
To construct, see NOTES section for SNAPCONFIGURATIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ISnapConfigsOverrideEdit[]
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubclientId
.

```yaml
Type: System.Int64
Parameter Sets: Edit, EditExpanded
Aliases:

Required: True
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

### Commvault.Powershell.Models.ISnapConfigOverrideEditReq

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <ISnapConfigOverrideEditReq>: Request Template to edit Snap Config
  - `[SnapConfigurations <ISnapConfigsOverrideEdit[]>]`: 
    - `Flags <Int64>`: Flag regarding placement of config in the CC page
    - `IsOverridden <Boolean>`: whether the config is overridden or not
    - `MasterConfigId <Int64>`: This is the masterConfigId, which is available for each vendors configs
    - `Name <String>`: This is the name of the config which is displayed on the Command Center Console
    - `Type <Int64>`: Type of the config value. type can accept 7 values [1,2,8,10,12,13,14], 1: boolean, 2: integer, 8: text, 10: array[string] are common configs, the rest three are special keys, 12 is for password type key for NetApp E-Series and HPE Nimble, 13 is Private Key for GCP, 14 is a hidden config to select type of Disk for GCP
    - `[Id <Int64?>]`: This is the id of the config which is required during config override
    - `[IsUpdated <Boolean?>]`: Whether the config is updated or not
    - `[Value <String>]`: Value of the config
    - `[Values <IIdName[]>]`: Holds a single value for types except 10, for 10 it holds one or more values.
      - `[Id <Int64?>]`: 
      - `[Name <String>]`: 

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

SNAPCONFIGURATIONS <ISnapConfigsOverrideEdit[]>: .
  - `Flags <Int64>`: Flag regarding placement of config in the CC page
  - `IsOverridden <Boolean>`: whether the config is overridden or not
  - `MasterConfigId <Int64>`: This is the masterConfigId, which is available for each vendors configs
  - `Name <String>`: This is the name of the config which is displayed on the Command Center Console
  - `Type <Int64>`: Type of the config value. type can accept 7 values [1,2,8,10,12,13,14], 1: boolean, 2: integer, 8: text, 10: array[string] are common configs, the rest three are special keys, 12 is for password type key for NetApp E-Series and HPE Nimble, 13 is Private Key for GCP, 14 is a hidden config to select type of Disk for GCP
  - `[Id <Int64?>]`: This is the id of the config which is required during config override
  - `[IsUpdated <Boolean?>]`: Whether the config is updated or not
  - `[Value <String>]`: Value of the config
  - `[Values <IIdName[]>]`: Holds a single value for types except 10, for 10 it holds one or more values.
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 

## RELATED LINKS

