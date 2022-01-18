---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-planrule
schema: 2.0.0
---

# New-PlanRule

## SYNOPSIS
Api to create plan rules.
Request body will suggest plan against which rule need to be created and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.

## SYNTAX

### CreateExpanded (Default)
```
New-PlanRule [-CompanyId <Int32>] [-CompanyName <String>] [-PlanId <Int32>] [-PlanName <String>]
 [-Rank <Int32>] [-Regions <IIdName[]>] [-ServerGroups <IIdName[]>] [-Solutions <IIdName[]>]
 [-Tags <IPlanEntityRuleTag[]>] [-Workloads <IIdName[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-PlanRule -Body <ICreatePlanEntityRule> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Api to create plan rules.
Request body will suggest plan against which rule need to be created and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.

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
This object will send details to create new plan rule.
User can provide all rule options or can specify a specific rule group.
Be default, for rule to be applicable for association to a workload, ALL specified rules in that Rule need to be matched.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICreatePlanEntityRule
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyId
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Type: System.Int32
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Type: System.Int32
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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

### Commvault.Powershell.Models.ICreatePlanEntityRule

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

### Commvault.Powershell.Models.IIdName

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <ICreatePlanEntityRule>: This object will send details to create new plan rule. User can provide all rule options or can specify a specific rule group. Be default, for rule to be applicable for association to a workload, ALL specified rules in that Rule need to be matched.
  - `[CompanyId <Int32?>]`: 
  - `[CompanyName <String>]`: 
  - `[PlanId <Int32?>]`: 
  - `[PlanName <String>]`: 
  - `[Rank <Int32?>]`: Optional field to suggest priority/rank of the rule. If not present, we will process rule in the same order they are created.
  - `[Regions <IIdName[]>]`: This will include list of regions that should be evaluated against workload region for plan association.
    - `[Id <Int32?>]`: 
    - `[Name <String>]`: 
  - `[ServerGroups <IIdName[]>]`: This will include list of Server groups that should be evaluated against workload server group for plan association.
  - `[Solutions <IIdName[]>]`: This will include list of solutions that should be evaluated against workload for plan association
  - `[Tags <IPlanEntityRuleTag[]>]`: This will include list of tags that should be evaluated against workload for plan association
    - `[Id <Int32?>]`: Id for the tag
    - `[Name <String>]`: Name for the plan rule tag which need to be matched against tag of the workload.
    - `[Value <String>]`: Possible value that need to matched against value of tag associated to workload.
  - `[Workloads <IIdName[]>]`: This will include list of apptypes that should be evaluated against workload apptype for plan association.

REGIONS <IIdName[]>: This will include list of regions that should be evaluated against workload region for plan association.
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

SERVERGROUPS <IIdName[]>: This will include list of Server groups that should be evaluated against workload server group for plan association.
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

SOLUTIONS <IIdName[]>: This will include list of solutions that should be evaluated against workload for plan association
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

TAGS <IPlanEntityRuleTag[]>: This will include list of tags that should be evaluated against workload for plan association
  - `[Id <Int32?>]`: Id for the tag
  - `[Name <String>]`: Name for the plan rule tag which need to be matched against tag of the workload.
  - `[Value <String>]`: Possible value that need to matched against value of tag associated to workload.

WORKLOADS <IIdName[]>: This will include list of apptypes that should be evaluated against workload apptype for plan association.
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

