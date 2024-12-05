---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/set-cvcyberresilience
schema: 2.0.0
---

# Set-CVCyberResilience

## SYNOPSIS
Configures Cyber Resilience in the environment

## SYNTAX

### ConfigureExpanded (Default)
```
Set-CVCyberResilience [-Credentials <Int64[]>] [-IndexServer <Int64>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Configure
```
Set-CVCyberResilience -Body <ICyberResilienceConfigureRequest> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Configures Cyber Resilience in the environment

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
CyberResilienceConfigureRequest

```yaml
Type: Commvault.Powershell.Models.ICyberResilienceConfigureRequest
Parameter Sets: Configure
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Credentials
List of Credential ids to be analysed

```yaml
Type: System.Int64[]
Parameter Sets: ConfigureExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IndexServer
Pseudo client id of the Index Server

```yaml
Type: System.Int64
Parameter Sets: ConfigureExpanded
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

### Commvault.Powershell.Models.ICyberResilienceConfigureRequest

## OUTPUTS

### Commvault.Powershell.Models.ICyberResilienceGenericResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <ICyberResilienceConfigureRequest>`: CyberResilienceConfigureRequest
  - `[Credentials <List<Int64>>]`: List of Credential ids to be analysed
  - `[IndexServer <Int64?>]`: Pseudo client id of the Index Server

## RELATED LINKS

