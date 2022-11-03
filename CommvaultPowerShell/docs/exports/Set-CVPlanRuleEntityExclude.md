---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-cvplanruleentityexclude
schema: 2.0.0
---

# Set-CVPlanRuleEntityExclude

## SYNOPSIS
API to exclude workloads from plan rule evaluation framework

## SYNTAX

### PutExpanded (Default)
```
Set-CVPlanRuleEntityExclude [-Subclients <IIdName[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Put
```
Set-CVPlanRuleEntityExclude -Body <IExcludeEntitiesFromPlanRuleEvaluation> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
API to exclude workloads from plan rule evaluation framework

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
Entities that need to be excluded from plan rule evaluation
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IExcludeEntitiesFromPlanRuleEvaluation
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
To construct, see NOTES section for SUBCLIENTS properties and create a hash table.

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

### Commvault.Powershell.Models.IExcludeEntitiesFromPlanRuleEvaluation

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IExcludeEntitiesFromPlanRuleEvaluation>`: Entities that need to be excluded from plan rule evaluation
  - `[Subclients <IIdName[]>]`: 
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 

`SUBCLIENTS <IIdName[]>`: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

