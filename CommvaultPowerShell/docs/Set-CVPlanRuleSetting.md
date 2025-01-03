---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/set-cvplanrulesetting
schema: 2.0.0
---

# Set-CVPlanRuleSetting

## SYNOPSIS
API to set plan rule execution settings

## SYNTAX

### PutExpanded (Default)
```
Set-CVPlanRuleSetting [-EnableAlertNotification] [-ExecutionInterval <Int64>] [-ExecutionMode <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Put
```
Set-CVPlanRuleSetting -Body <IPlanRuleExecutionSettings> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to set plan rule execution settings

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
Message object to hold settings for plan rule execution.

```yaml
Type: Commvault.Powershell.Models.IPlanRuleExecutionSettings
Parameter Sets: Put
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EnableAlertNotification
Set this to enable/disable notification over email for subclients pending plan associationover 24 hours.
By default, notification will be enabled.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExecutionInterval
Setting to suggest evaluation frequency in case of evaluation mode being Automatic.

```yaml
Type: System.Int64
Parameter Sets: PutExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExecutionMode
Plan rule execution mode

```yaml
Type: System.String
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

### Commvault.Powershell.Models.IPlanRuleExecutionSettings

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IPlanRuleExecutionSettings>`: Message object to hold settings for plan rule execution.
  - `[EnableAlertNotification <Boolean?>]`: Set this to enable/disable notification over email for subclients pending plan associationover 24 hours. By default, notification will be enabled.
  - `[ExecutionInterval <Int64?>]`: Setting to suggest evaluation frequency in case of evaluation mode being Automatic.
  - `[ExecutionMode <String>]`: Plan rule execution mode

## RELATED LINKS

