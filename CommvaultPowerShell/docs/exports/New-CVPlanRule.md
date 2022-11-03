---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-cvplanrule
schema: 2.0.0
---

# New-CVPlanRule

## SYNOPSIS
Api to create plan rules.
Request body will suggest plan against which rule need to be created and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.

## SYNTAX

```
New-CVPlanRule [-CompanyId <Int64>] [-CompanyName <String>] [-PlanId <Int64>] [-PlanName <String>]
 [-Rank <Int64>] [-Regions <IIdName[]>] [-ServerGroups <IIdName[]>] [-Solutions <IIdName[]>]
 [-Tags <IPlanEntityRuleTag[]>] [-Workloads <IIdName[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Api to create plan rules.
Request body will suggest plan against which rule need to be created and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.

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

### -CompanyId
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

### -CompanyName
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
Optional field to suggest priority/rank of the rule.
If not present, we will process rule in the same order they are created.

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
This will include list of solutions that should be evaluated against workload for plan association
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

### Commvault.Powershell.Models.IIdName

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`REGIONS <IIdName[]>`: This will include list of regions that should be evaluated against workload region for plan association.
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`SERVERGROUPS <IIdName[]>`: This will include list of Server groups that should be evaluated against workload server group for plan association.
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`SOLUTIONS <IIdName[]>`: This will include list of solutions that should be evaluated against workload for plan association
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`TAGS <IPlanEntityRuleTag[]>`: This will include list of tags that should be evaluated against workload for plan association
  - `[Id <Int64?>]`: Id for the tag
  - `[Name <String>]`: Name for the plan rule tag which need to be matched against tag of the workload.
  - `[Value <String>]`: Possible value that need to matched against value of tag associated to workload.

`WORKLOADS <IIdName[]>`: This will include list of apptypes that should be evaluated against workload apptype for plan association.
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

