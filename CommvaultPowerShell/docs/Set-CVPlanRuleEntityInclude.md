---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/set-cvplanruleentityinclude
schema: 2.0.0
---

# Set-CVPlanRuleEntityInclude

## SYNOPSIS
API to include workloads to be applicable for plan rule evaluation.

## SYNTAX

### PutExpanded (Default)
```
Set-CVPlanRuleEntityInclude [-Subclients <IIdName[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Put
```
Set-CVPlanRuleEntityInclude -Body <IIncludeEntitiesForPlanRuleEvaluation> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
API to include workloads to be applicable for plan rule evaluation.

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
Entities that need to be included for plan rule evaluation

```yaml
Type: Commvault.Powershell.Models.IIncludeEntitiesForPlanRuleEvaluation
Parameter Sets: Put
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Subclients
.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: PutExpanded
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

### Commvault.Powershell.Models.IIncludeEntitiesForPlanRuleEvaluation

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IIncludeEntitiesForPlanRuleEvaluation>`: Entities that need to be included for plan rule evaluation
  - `[Subclients <List<IIdName>>]`: 
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 

`SUBCLIENTS <IIdName[]>`: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

