---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/new-cvkuberneteapplicationgroup
schema: 2.0.0
---

# New-CVKuberneteApplicationGroup

## SYNOPSIS
API to create new Kubernetes application group

## SYNTAX

```
New-CVKuberneteApplicationGroup [-ClusterId <Int64>] [-ClusterName <String>]
 [-ContentApplications <IKubernetesContentApplications[]>]
 [-ContentLabelSelectors <IKubernetesContentSelectors[]>] [-ContentOverwrite]
 [-FilterApplications <IKubernetesContentApplications[]>]
 [-FilterLabelSelectors <IKubernetesContentSelectors[]>] [-FilterOverwrite] [-FilterSkipStatelessApps]
 [-Name <String>] [-PlanId <Int64>] [-PlanName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to create new Kubernetes application group

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

### -ClusterId
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

### -ClusterName
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

### -ContentApplications
List of applications to be added as content

```yaml
Type: Commvault.Powershell.Models.IKubernetesContentApplications[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentLabelSelectors
List of label selectors to be added as content

```yaml
Type: Commvault.Powershell.Models.IKubernetesContentSelectors[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentOverwrite
Specifies whether content has to be overwritten or appended

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

### -FilterApplications
List of applications to be added as content

```yaml
Type: Commvault.Powershell.Models.IKubernetesContentApplications[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilterLabelSelectors
List of label selectors to be added as content

```yaml
Type: Commvault.Powershell.Models.IKubernetesContentSelectors[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilterOverwrite
Specifies whether content has to be overwritten or appended

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

### -FilterSkipStatelessApps
Specify whether to skip backup of stateless applications

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

### -Name
Specify new name to rename an Application Group

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


`CONTENTAPPLICATIONS <IKubernetesContentApplications[]>`: List of applications to be added as content
  - `Guid <String>`: GUID value of the Kubernetes Application to be associated as content
  - `Type <String>`: Type of the Kubernetes application
  - `[Name <String>]`: Name of the application

`CONTENTLABELSELECTORS <IKubernetesContentSelectors[]>`: List of label selectors to be added as content
  - `SelectorLevel <String>`: Selector level of the label selector
  - `SelectorValue <String>`: Value of the label selector in key=value format

`FILTERAPPLICATIONS <IKubernetesContentApplications[]>`: List of applications to be added as content
  - `Guid <String>`: GUID value of the Kubernetes Application to be associated as content
  - `Type <String>`: Type of the Kubernetes application
  - `[Name <String>]`: Name of the application

`FILTERLABELSELECTORS <IKubernetesContentSelectors[]>`: List of label selectors to be added as content
  - `SelectorLevel <String>`: Selector level of the label selector
  - `SelectorValue <String>`: Value of the label selector in key=value format

## RELATED LINKS

