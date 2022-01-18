---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-planrulerank
schema: 2.0.0
---

# Set-PlanRuleRank

## SYNOPSIS
API to update rank for multiple rules at a time.

## SYNTAX

### UpdateExpanded (Default)
```
Set-PlanRuleRank [-Rules <IPlanEntityRuleRank[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Set-PlanRuleRank -Body <IUpdatePlanEntityRuleRanks> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to update rank for multiple rules at a time.

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
Plan entity rule update rank object.
Fields in this object need to be populated to suggest what rank need to be set for the said rule.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IUpdatePlanEntityRuleRanks
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Rules
Lits of plan entity rule object suggesting their ranks.
To construct, see NOTES section for RULES properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IPlanEntityRuleRank[]
Parameter Sets: UpdateExpanded
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

### Commvault.Powershell.Models.IUpdatePlanEntityRuleRanks

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IUpdatePlanEntityRuleRanks>: Plan entity rule update rank object. Fields in this object need to be populated to suggest what rank need to be set for the said rule.
  - `[Rules <IPlanEntityRuleRank[]>]`: Lits of plan entity rule object suggesting their ranks.
    - `[Rank <Int32?>]`: This will suggest rank/priority of the plan rule.
    - `[RuleId <Int32?>]`: 
    - `[RuleName <String>]`: 

RULES <IPlanEntityRuleRank[]>: Lits of plan entity rule object suggesting their ranks.
  - `[Rank <Int32?>]`: This will suggest rank/priority of the plan rule.
  - `[RuleId <Int32?>]`: 
  - `[RuleName <String>]`: 

## RELATED LINKS

