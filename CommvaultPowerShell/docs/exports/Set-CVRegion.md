---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-cvregion
schema: 2.0.0
---

# Set-CVRegion

## SYNOPSIS
Api to set region for an entity.

## SYNTAX

### UpdateExpanded (Default)
```
Set-CVRegion -RegionId <Int64> [-LocationCity <String>] [-LocationContinent <String>]
 [-LocationCountry <String>] [-LocationLatitude <Double>] [-LocationLongitude <Double>]
 [-LocationsOperationType <String>] [-LocationState <String>] [-NewName <String>] [-ZoneId <Int64>]
 [-ZoneName <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-CVRegion -EntityId <Int64> -EntityType <Int64> -Body <IEntityRegionInfo> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetExpanded
```
Set-CVRegion -EntityId <Int64> -EntityType <Int64> [-RegionId <Int64>] [-EntityRegionType <String>]
 [-RegionName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-CVRegion -InputObject <ICommvaultPowerShellIdentity> -Body <IEntityRegionInfo> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-CVRegion -InputObject <ICommvaultPowerShellIdentity> [-RegionId <Int64>] [-EntityRegionType <String>]
 [-RegionName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Set-CVRegion -InputObject <ICommvaultPowerShellIdentity> [-LocationCity <String>]
 [-LocationContinent <String>] [-LocationCountry <String>] [-LocationLatitude <Double>]
 [-LocationLongitude <Double>] [-LocationsOperationType <String>] [-LocationState <String>]
 [-NewName <String>] [-ZoneId <Int64>] [-ZoneName <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Api to set region for an entity.

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

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IEntityRegionInfo
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EntityId
Unique id for the entity

```yaml
Type: System.Int64
Parameter Sets: Set, SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EntityRegionType
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EntityType
Type of the entity

```yaml
Type: System.Int64
Parameter Sets: Set, SetExpanded
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
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LocationCity
Name of city for the location

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationContinent
Name of continent for the location

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationCountry
Name of country for the location

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationLatitude
Latitude for the location

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationLongitude
Longitude for the location

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationsOperationType
Type of operation to be performed for locations

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationState
Name of state for the location

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewName
New name for the region

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegionName
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ZoneId
.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ZoneName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Commvault.Powershell.Models.IEntityRegionInfo

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IEntityRegionInfo>`: .
  - `[EntityRegionType <String>]`: 
  - `[RegionId <Int64?>]`: 
  - `[RegionName <String>]`: 

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

## RELATED LINKS

