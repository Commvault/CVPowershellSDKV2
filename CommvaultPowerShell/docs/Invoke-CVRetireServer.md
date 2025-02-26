---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/invoke-cvretireserver
schema: 2.0.0
---

# Invoke-CVRetireServer

## SYNOPSIS
Retire multiple servers

## SYNTAX

### RetireExpanded (Default)
```
Invoke-CVRetireServer [-Servers <IIdName[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Retire
```
Invoke-CVRetireServer -Body <IRetireServersRequest> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Retire multiple servers

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

### -Body
RetireServersRequest

```yaml
Type: Commvault.Powershell.Models.IRetireServersRequest
Parameter Sets: Retire
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

### -Servers
.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: RetireExpanded
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

### Commvault.Powershell.Models.IRetireServersRequest

## OUTPUTS

### Commvault.Powershell.Models.IRetireServersResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IRetireServersRequest>`: RetireServersRequest
  - `[Servers <List<IIdName>>]`: 
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 

`SERVERS <IIdName[]>`: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

