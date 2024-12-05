---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/invoke-cvpreviewservergroupcreation
schema: 2.0.0
---

# Invoke-CVPreviewServerGroupCreation

## SYNOPSIS
Get a preview of servers affected with create server group operation

## SYNTAX

### PreviewExpanded (Default)
```
Invoke-CVPreviewServerGroupCreation [-ClientScopeType <String>] [-ConfirmRuleChange] [-EntityInfoId <Int64>]
 [-EntityInfoName <String>] [-ServerGroupRuleGroup <IServerRuleGroup[]>] [-ServerGroupRuleMatch <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Preview
```
Invoke-CVPreviewServerGroupCreation -Body <IAutomaticServerGroupAssociationDetails> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Get a preview of servers affected with create server group operation

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
.

```yaml
Type: Commvault.Powershell.Models.IAutomaticServerGroupAssociationDetails
Parameter Sets: Preview
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClientScopeType
.

```yaml
Type: System.String
Parameter Sets: PreviewExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConfirmRuleChange
Confirm that server group rule impacts server of a specific company smart client group only

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PreviewExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EntityInfoId
.

```yaml
Type: System.Int64
Parameter Sets: PreviewExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EntityInfoName
.

```yaml
Type: System.String
Parameter Sets: PreviewExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerGroupRuleGroup
List of rule groups

```yaml
Type: Commvault.Powershell.Models.IServerRuleGroup[]
Parameter Sets: PreviewExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerGroupRuleMatch
.

```yaml
Type: System.String
Parameter Sets: PreviewExpanded
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

### Commvault.Powershell.Models.IAutomaticServerGroupAssociationDetails

## OUTPUTS

### Commvault.Powershell.Models.ICreateServerGroupPreviewResp

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IAutomaticServerGroupAssociationDetails>`: .
  - `[ClientScopeType <String>]`: 
  - `[ConfirmRuleChange <Boolean?>]`: Confirm that server group rule impacts server of a specific company smart client group only
  - `[EntityInfoId <Int64?>]`: 
  - `[EntityInfoName <String>]`: 
  - `[ServerGroupRuleGroup <List<IServerRuleGroup>>]`: List of rule groups
    - `[Match <String>]`: 
    - `[Rules <List<IServerRule>>]`: List of rules
      - `[MatchCondition <String>]`: 
      - `[RuleName <String>]`: 
      - `[RuleSecValue <String>]`: Secondary value used for BETWEEN and NOT_BETWEEN matchCondition. For ruleName which have enum values (like OS_TYPE), this is used to store displayName.
      - `[RuleValue <String>]`: Primary value for the rule
  - `[ServerGroupRuleMatch <String>]`: 

`SERVERGROUPRULEGROUP <IServerRuleGroup[]>`: List of rule groups
  - `[Match <String>]`: 
  - `[Rules <List<IServerRule>>]`: List of rules
    - `[MatchCondition <String>]`: 
    - `[RuleName <String>]`: 
    - `[RuleSecValue <String>]`: Secondary value used for BETWEEN and NOT_BETWEEN matchCondition. For ruleName which have enum values (like OS_TYPE), this is used to store displayName.
    - `[RuleValue <String>]`: Primary value for the rule

## RELATED LINKS

