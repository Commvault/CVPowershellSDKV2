---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-cvplanrule
schema: 2.0.0
---

# Set-CVPlanRule

## SYNOPSIS
Api to update existing plan rules.
Request body will suggest which rule need to be updated and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.

## SYNTAX

```
Set-CVPlanRule [-PlanId <Int64>] [-PlanName <String>] [-Rank <Int64>] [-Regions <IIdName[]>] [-RuleId <Int64>]
 [-RuleName <String>] [-ServerGroups <IIdName[]>] [-Solutions <IIdName[]>] [-Tags <IPlanEntityRuleTag[]>]
 [-Workloads <IIdName[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Api to update existing plan rules.
Request body will suggest which rule need to be updated and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -PlanId
.

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

### -PlanName
.

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

### -Rank
[Optional] - This field will suggest rank/priority of rule.

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

### -Regions
This will include list of regions that should be evaluated against workload region for plan association.
To construct, see NOTES section for REGIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RuleId
.

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

### -RuleName
.

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

### -ServerGroups
This will include list of Server groups that should be evaluated against workload server group for plan association.
To construct, see NOTES section for SERVERGROUPS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Solutions
This will include list of solutions that should be evaluated against workload for plan association.
To construct, see NOTES section for SOLUTIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tags
This will include list of tags that should be evaluated against workload for plan association
To construct, see NOTES section for TAGS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IPlanEntityRuleTag[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Workloads
This will include list of apptypes that should be evaluated against workload apptype for plan association.
To construct, see NOTES section for WORKLOADS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
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

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


REGIONS <IIdName[]>: This will include list of regions that should be evaluated against workload region for plan association.
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

SERVERGROUPS <IIdName[]>: This will include list of Server groups that should be evaluated against workload server group for plan association.
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

SOLUTIONS <IIdName[]>: This will include list of solutions that should be evaluated against workload for plan association.
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

TAGS <IPlanEntityRuleTag[]>: This will include list of tags that should be evaluated against workload for plan association
  - `[Id <Int64?>]`: Id for the tag
  - `[Name <String>]`: Name for the plan rule tag which need to be matched against tag of the workload.
  - `[Value <String>]`: Possible value that need to matched against value of tag associated to workload.

WORKLOADS <IIdName[]>: This will include list of apptypes that should be evaluated against workload apptype for plan association.
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

