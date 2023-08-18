---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-cvplanruleentityassociate
schema: 2.0.0
---

# Set-CVPlanRuleEntityAssociate

## SYNOPSIS
API to associate workloads to selected plan and plan rule

## SYNTAX

### PutExpanded (Default)
```
Set-CVPlanRuleEntityAssociate [-Entities <IAssociatePlanRuleEntity[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Put
```
Set-CVPlanRuleEntityAssociate -Body <IAssociatePlanRuleEntityList> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
API to associate workloads to selected plan and plan rule

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

### -Body
List of entities that are will be associated to provided plan and said rule
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IAssociatePlanRuleEntityList
Parameter Sets: Put
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Entities
Details of entity that will be associated to plan and rule.
To construct, see NOTES section for ENTITIES properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IAssociatePlanRuleEntity[]
Parameter Sets: PutExpanded
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

### Commvault.Powershell.Models.IAssociatePlanRuleEntityList

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IAssociatePlanRuleEntityList>: List of entities that are will be associated to provided plan and said rule
  - `[Entities <IAssociatePlanRuleEntity[]>]`: Details of entity that will be associated to plan and rule.
    - `[PlanId <Int64?>]`: 
    - `[PlanName <String>]`: 
    - `[RuleId <Int64?>]`: 
    - `[RuleName <String>]`: 
    - `[SubclientId <Int64?>]`: 
    - `[SubclientName <String>]`: 

ENTITIES <IAssociatePlanRuleEntity[]>: Details of entity that will be associated to plan and rule.
  - `[PlanId <Int64?>]`: 
  - `[PlanName <String>]`: 
  - `[RuleId <Int64?>]`: 
  - `[RuleName <String>]`: 
  - `[SubclientId <Int64?>]`: 
  - `[SubclientName <String>]`: 

## RELATED LINKS

