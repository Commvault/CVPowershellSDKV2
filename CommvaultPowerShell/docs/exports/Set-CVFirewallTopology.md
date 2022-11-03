---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-cvfirewalltopology
schema: 2.0.0
---

# Set-CVFirewallTopology

## SYNOPSIS
This endpoint is used to edit network topology.

## SYNTAX

### PutExpanded (Default)
```
Set-CVFirewallTopology -TopologyId <String> [-ClientType <String>] [-EncryptTraffic]
 [-FirewallGroups <IFirewallTopologyGroups[]>] [-TopologyName <String>] [-TopologyType <String>]
 [-TunnelProtocol <String>] [-TunnelsPerRoute <Int64>] [-UseWildCardProxy] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Put
```
Set-CVFirewallTopology -TopologyId <String> -Body <IFirewallTopologyCreateReq> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### PutViaIdentity
```
Set-CVFirewallTopology -InputObject <ICommvaultPowerShellIdentity> -Body <IFirewallTopologyCreateReq>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PutViaIdentityExpanded
```
Set-CVFirewallTopology -InputObject <ICommvaultPowerShellIdentity> [-ClientType <String>] [-EncryptTraffic]
 [-FirewallGroups <IFirewallTopologyGroups[]>] [-TopologyName <String>] [-TopologyType <String>]
 [-TunnelProtocol <String>] [-TunnelsPerRoute <Int64>] [-UseWildCardProxy] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint is used to edit network topology.

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
FirewallTopologyReq
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IFirewallTopologyCreateReq
Parameter Sets: Put, PutViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClientType
The type of clients associated with the topology.

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EncryptTraffic
Flag determining if we want the data from tunnel to use HTTPS protocol

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FirewallGroups
.
To construct, see NOTES section for FIREWALLGROUPS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IFirewallTopologyGroups[]
Parameter Sets: PutExpanded, PutViaIdentityExpanded
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
Parameter Sets: PutViaIdentity, PutViaIdentityExpanded
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

### -TopologyId
.

```yaml
Type: System.String
Parameter Sets: Put, PutExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TopologyName
.

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TopologyType
The type of topology of client groups (and sometimes network gateway) for this instance.

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TunnelProtocol
The protocol for outgoing communication

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TunnelsPerRoute
The number of tunnel connections per route

```yaml
Type: System.Int64
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UseWildCardProxy
Flag determining wether network gateways are used to connect all infrastructure machines

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
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

### Commvault.Powershell.Models.IFirewallTopologyCreateReq

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IFirewallTopologyCreateReq>`: FirewallTopologyReq
  - `[ClientType <String>]`: The type of clients associated with the topology.
  - `[EncryptTraffic <Boolean?>]`: Flag determining if we want the data from tunnel to use HTTPS protocol
  - `[FirewallGroups <IFirewallTopologyGroups[]>]`: 
    - `[AdvancedOptionKeepAliveInterval <Int64?>]`: The interval in seconds for sending keep-alive packets, to maintain the session if backup traffic has an extended pause.
    - `[AdvancedOptionTunnelPort <Int64?>]`: The port defined for communications
    - `[ClientGroupId <Int64?>]`: The id of the client group
    - `[GroupType <String>]`: FirewallFwGroupType
    - `[Mnemonic <String>]`: Custom names(mnemonics) given to pre-defined smart client groups
  - `[TopologyName <String>]`: 
  - `[TopologyType <String>]`: The type of topology of client groups (and sometimes network gateway) for this instance.
  - `[TunnelProtocol <String>]`: The protocol for outgoing communication
  - `[TunnelsPerRoute <Int64?>]`: The number of tunnel connections per route
  - `[UseWildCardProxy <Boolean?>]`: Flag determining wether network gateways are used to connect all infrastructure machines

`FIREWALLGROUPS <IFirewallTopologyGroups[]>`: .
  - `[AdvancedOptionKeepAliveInterval <Int64?>]`: The interval in seconds for sending keep-alive packets, to maintain the session if backup traffic has an extended pause.
  - `[AdvancedOptionTunnelPort <Int64?>]`: The port defined for communications
  - `[ClientGroupId <Int64?>]`: The id of the client group
  - `[GroupType <String>]`: FirewallFwGroupType
  - `[Mnemonic <String>]`: Custom names(mnemonics) given to pre-defined smart client groups

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

