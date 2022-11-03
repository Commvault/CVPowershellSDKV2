---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-cvmediaagent
schema: 2.0.0
---

# Set-CVMediaAgent

## SYNOPSIS
Modify the properties of an existing media agent

## SYNTAX

### UpdateExpanded (Default)
```
Set-CVMediaAgent -MediaAgentId <Int64> [-ControlEnabled] [-ControlMaintenanceMode]
 [-ControlOptimizeForConcurrentLanBackups] [-ControlParallelDataTransferOperations <Int64>]
 [-ControlRansomwareProtection] [-Description <String>] [-IndexCachePath <String>] [-LogCacheEnabled]
 [-LogCachePath <String>] [-RoleId <Int64>] [-RoleName <String>] [-UserGroupId <Int64>]
 [-UserGroupName <String>] [-UserId <Int64>] [-UserName <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Set-CVMediaAgent -InputObject <ICommvaultPowerShellIdentity> [-ControlEnabled] [-ControlMaintenanceMode]
 [-ControlOptimizeForConcurrentLanBackups] [-ControlParallelDataTransferOperations <Int64>]
 [-ControlRansomwareProtection] [-Description <String>] [-IndexCachePath <String>] [-LogCacheEnabled]
 [-LogCachePath <String>] [-RoleId <Int64>] [-RoleName <String>] [-UserGroupId <Int64>]
 [-UserGroupName <String>] [-UserId <Int64>] [-UserName <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Modify the properties of an existing media agent

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

### -ControlEnabled
Determines if the media agent is currently enabled or disabled.

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

### -ControlMaintenanceMode
Specifies whether the MediaAgent is available for data protection, data recovery and auxiliary copy operations.

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

### -ControlOptimizeForConcurrentLanBackups
Allows optimization for concurrent LAN backups.
If set to true, default value for parallel data transfer operations will be 100.
If set to false, default value of parallel data transfer operations will be set to 25.

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

### -ControlParallelDataTransferOperations
Specifies the number of parallel data operations that can take place.

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

### -ControlRansomwareProtection
If set to true, ransomware protection against the media agent is enabled.
If set to false, ransomware protection against media agent is disabled.

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

### -Description
Provides the media agent with a new description.

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

### -IndexCachePath
Path where the index cache is maintained.

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICommvaultPowerShellIdentity
Parameter Sets: UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LogCacheEnabled
This tag determines if the logs cache has been enabled or not.

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

### -LogCachePath
If the logs cache is enabled, this tag gives the path to store the logs cache.

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

### -MediaAgentId
Id of the mediaAgent to update

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded
Aliases:

Required: True
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

### -RoleId
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

### -RoleName
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

### -UserGroupId
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

### -UserGroupName
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

### -UserId
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

### -UserName
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

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

