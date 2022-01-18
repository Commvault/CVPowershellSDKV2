---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-planruleassociatedentity
schema: 2.0.0
---

# Set-PlanRuleAssociatedEntity

## SYNOPSIS
API to send request to process plan rules against specific set of entities.

## SYNTAX

### PutExpanded (Default)
```
Set-PlanRuleAssociatedEntity [-Backupsets <IIdName[]>] [-Clients <IIdName[]>] [-IgnorePreviousPlanAssociation]
 [-Instances <IIdName[]>] [-IsPreviewOnly] [-Subclients <IIdName[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Put
```
Set-PlanRuleAssociatedEntity -Body <IExecutePlanRules> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to send request to process plan rules against specific set of entities.

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

### -Backupsets
List of backupsets against which plan rules need to be executed and evaluated.
To construct, see NOTES section for BACKUPSETS properties and create a hash table.

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

### -Body
Message object to hold information of entities against which plan rule need to be analyzed
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IExecutePlanRules
Parameter Sets: Put
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Clients
List of clients against which plan rules need to be executed and evaluated.
To construct, see NOTES section for CLIENTS properties and create a hash table.

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

### -IgnorePreviousPlanAssociation
Boolean to indicate if we want to evaluate rule for entities associated to plan.
Default is false.
Only entities with no plan associated will be evaluated.

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

### -Instances
List of instances against which plan rules need to be executed and evaluated.
To construct, see NOTES section for INSTANCES properties and create a hash table.

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

### -IsPreviewOnly
Boolean to indicate if request is to preview list of subclients that will be associated via plan rules

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

### -Subclients
List of subclients against which plan rules need to be executed and evaluated.
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

### Commvault.Powershell.Models.IExecutePlanRules

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BACKUPSETS <IIdName[]>: List of backupsets against which plan rules need to be executed and evaluated.
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

BODY <IExecutePlanRules>: Message object to hold information of entities against which plan rule need to be analyzed
  - `[Backupsets <IIdName[]>]`: List of backupsets against which plan rules need to be  executed and evaluated.
    - `[Id <Int32?>]`: 
    - `[Name <String>]`: 
  - `[Clients <IIdName[]>]`: List of clients against which plan rules need to be  executed and evaluated.
  - `[IgnorePreviousPlanAssociation <Boolean?>]`: Boolean to indicate if we want to evaluate rule for entities associated to plan. Default is false. Only entities with no plan associated will be evaluated.
  - `[Instances <IIdName[]>]`: List of instances against which plan rules need to be  executed and evaluated.
  - `[IsPreviewOnly <Boolean?>]`: Boolean to indicate if request is to preview list of subclients that will be associated via plan rules
  - `[Subclients <IIdName[]>]`: List of subclients against which plan rules need to be  executed and evaluated.

CLIENTS <IIdName[]>: List of clients against which plan rules need to be executed and evaluated.
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

INSTANCES <IIdName[]>: List of instances against which plan rules need to be executed and evaluated.
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

SUBCLIENTS <IIdName[]>: List of subclients against which plan rules need to be executed and evaluated.
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

