---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cveligiblemachinefailovergroup
schema: 2.0.0
---

# Get-CVEligibleMachineFailoverGroup

## SYNOPSIS
API to get list of machines eligible to be added to failover group

## SYNTAX

```
Get-CVEligibleMachineFailoverGroup -SourceEntityId <Int64> [-DestinationClientId <Int64>]
 [-FailoverGroupSource <String>] [-SourceEntityType <String>] [<CommonParameters>]
```

## DESCRIPTION
API to get list of machines eligible to be added to failover group

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

### -DestinationClientId
The client ID of the destination

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

### -FailoverGroupSource
The type of failover group source.
Default value is 'REPLICATION'

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

### -SourceEntityId
The ID of the source entity.
This is the ID for client or client group

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceEntityType
The type of source entity.
It can be 'CLIENT' or 'CLIENT_ENTITY'.
Default value is 'CLIENT'

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Commvault.Powershell.Models.IFailoverGroupEligibleMachineList

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

## RELATED LINKS

