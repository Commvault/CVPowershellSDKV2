---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/new-cvplanrule
schema: 2.0.0
---

# New-CVPlanRule

## SYNOPSIS
Api to create plan rules.
Request body will suggest plan against which rule need to be created and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.

## SYNTAX

```
New-CVPlanRule [-CompanyId <Int64>] [-CompanyName <String>] [-GlobalConfigInfoActionOnLocalEntity <String>]
 [-GlobalConfigInfoApplyOnAllCommCells] [-GlobalConfigInfoCommcells <IGlobalConfigCommcellInfo[]>]
 [-GlobalConfigInfoName <String>] [-GlobalConfigInfoScope <String>]
 [-GlobalConfigInfoScopeFilterQuery <String>] [-PlanGuid <String>] [-PlanId <Int64>] [-PlanName <String>]
 [-Rank <Int64>] [-Regions <IIdNameGuid[]>] [-ServerGroups <IIdNameGuid[]>] [-Solutions <IIdName[]>]
 [-Tags <IPlanEntityRuleTag[]>] [-Workloads <IIdName[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Api to create plan rules.
Request body will suggest plan against which rule need to be created and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.

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

### -GlobalConfigInfoActionOnLocalEntity
Action that will be taken on the local entity that has the same name as the global entity that needs to be created

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

### -GlobalConfigInfoApplyOnAllCommCells
Decides whether the global configuration should be applied to all the Service commcells, including the newly created ones

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

### -GlobalConfigInfoCommcells
List of Service CommCells where the global configuration should be applied

```yaml
Type: Commvault.Powershell.Models.IGlobalConfigCommcellInfo[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoName
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

### -GlobalConfigInfoScope
The entity level at which the config has to be applied.

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

### -GlobalConfigInfoScopeFilterQuery
CommCellEntityCache filter query string using for filtering the scope

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

### -PlanGuid
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

```yaml
Type: Commvault.Powershell.Models.IIdNameGuid[]
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

```yaml
Type: Commvault.Powershell.Models.IIdNameGuid[]
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

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`GLOBALCONFIGINFOCOMMCELLS <IGlobalConfigCommcellInfo[]>`: List of Service CommCells where the global configuration should be applied
  - `[Guid <String>]`: 
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`REGIONS <IIdNameGuid[]>`: This will include list of regions that should be evaluated against workload region for plan association.
  - `[Guid <String>]`: 
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`SERVERGROUPS <IIdNameGuid[]>`: This will include list of Server groups that should be evaluated against workload server group for plan association.
  - `[Guid <String>]`: 
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`SOLUTIONS <IIdName[]>`: This will include list of solutions that should be evaluated against workload for plan association
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`TAGS <IPlanEntityRuleTag[]>`: This will include list of tags that should be evaluated against workload for plan association
  - `[Guid <String>]`: GUID for the tag
  - `[Id <Int64?>]`: Id for the tag
  - `[Name <String>]`: Name for the plan rule tag which need to be matched against tag of the workload.
  - `[Value <String>]`: Possible value that need to matched against value of tag associated to workload.

`WORKLOADS <IIdName[]>`: This will include list of apptypes that should be evaluated against workload apptype for plan association.
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

