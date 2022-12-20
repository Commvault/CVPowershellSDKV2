---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-cvfirewalltopology
schema: 2.0.0
---

# New-CVFirewallTopology

## SYNOPSIS
This endpoint is used to create network topology.

## SYNTAX

```
New-CVFirewallTopology [-ClientType <String>] [-EncryptTraffic] [-FirewallGroups <IFirewallTopologyGroups[]>]
 [-TopologyName <String>] [-TopologyType <String>] [-TunnelProtocol <String>] [-TunnelsPerRoute <Int64>]
 [-UseWildCardProxy] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint is used to create network topology.

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

### -ClientType
The type of clients associated with the topology.

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

### -EncryptTraffic
Flag determining if we want the data from tunnel to use HTTPS protocol

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

### -FirewallGroups
.
To construct, see NOTES section for FIREWALLGROUPS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IFirewallTopologyGroups[]
Parameter Sets: (All)
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

### -TopologyName
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

### -TopologyType
The type of topology of client groups (and sometimes network gateway) for this instance.

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

### -TunnelProtocol
The protocol for outgoing communication

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

### -TunnelsPerRoute
The number of tunnel connections per route

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

### -UseWildCardProxy
Flag determining wether network gateways are used to connect all infrastructure machines

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

## OUTPUTS

### Commvault.Powershell.Models.IFirewallTopologyCreateResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`FIREWALLGROUPS <IFirewallTopologyGroups[]>`: .
  - `[AdvancedOptionKeepAliveInterval <Int64?>]`: The interval in seconds for sending keep-alive packets, to maintain the session if backup traffic has an extended pause.
  - `[AdvancedOptionTunnelPort <Int64?>]`: The port defined for communications
  - `[ClientGroupId <Int64?>]`: The id of the client group
  - `[GroupType <String>]`: FirewallFwGroupType
  - `[Mnemonic <String>]`: Custom names(mnemonics) given to pre-defined smart client groups

## RELATED LINKS

