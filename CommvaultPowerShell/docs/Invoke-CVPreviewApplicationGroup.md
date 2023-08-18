---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-cvpreviewapplicationgroup
schema: 2.0.0
---

# Invoke-CVPreviewApplicationGroup

## SYNOPSIS
API to preview application content

## SYNTAX

### PreviewExpanded (Default)
```
Invoke-CVPreviewApplicationGroup -ClusterId <Int64> [-ContentApplications <IKubernetesContentApplications[]>]
 [-ContentLabelSelectors <IKubernetesContentSelectors[]>]
 [-FilterApplications <IKubernetesContentApplications[]>]
 [-FilterLabelSelectors <IKubernetesContentSelectors[]>] [-FilterSkipStatelessApps] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Preview
```
Invoke-CVPreviewApplicationGroup -ClusterId <Int64> -Body <IKubernetesApplicationGroupPreviewReq> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to preview application content

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
Application Group Preview Request
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IKubernetesApplicationGroupPreviewReq
Parameter Sets: Preview
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClusterId
clusterId of the Kubernetes client to do a Preview

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentApplications
List of applications to be added as content
To construct, see NOTES section for CONTENTAPPLICATIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IKubernetesContentApplications[]
Parameter Sets: PreviewExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentLabelSelectors
List of label selectors to be added as content
To construct, see NOTES section for CONTENTLABELSELECTORS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IKubernetesContentSelectors[]
Parameter Sets: PreviewExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilterApplications
List of applications to be added as content
To construct, see NOTES section for FILTERAPPLICATIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IKubernetesContentApplications[]
Parameter Sets: PreviewExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilterLabelSelectors
List of label selectors to be added as content
To construct, see NOTES section for FILTERLABELSELECTORS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IKubernetesContentSelectors[]
Parameter Sets: PreviewExpanded
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

### Commvault.Powershell.Models.IKubernetesApplicationGroupPreviewReq

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

### Commvault.Powershell.Models.IKubernetesApplicationGroupPreviewResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IKubernetesApplicationGroupPreviewReq>: Application Group Preview Request
  - `[ContentApplications <IKubernetesContentApplications[]>]`: List of applications to be added as content
    - `Guid <String>`: GUID value of the Kubernetes Application to be associated as content
    - `Type <String>`: Type of the Kubernetes application
    - `[Name <String>]`: Name of the application
  - `[ContentLabelSelectors <IKubernetesContentSelectors[]>]`: List of label selectors to be added as content
    - `SelectorLevel <String>`: Selector level of the label selector
    - `SelectorValue <String>`: Value of the label selector in key=value format
  - `[FilterApplications <IKubernetesContentApplications[]>]`: List of applications to be added as content
  - `[FilterLabelSelectors <IKubernetesContentSelectors[]>]`: List of label selectors to be added as content
  - `[FilterSkipStatelessApps <Boolean?>]`: Specify whether to skip backup of stateless applications

CONTENTAPPLICATIONS <IKubernetesContentApplications[]>: List of applications to be added as content
  - `Guid <String>`: GUID value of the Kubernetes Application to be associated as content
  - `Type <String>`: Type of the Kubernetes application
  - `[Name <String>]`: Name of the application

CONTENTLABELSELECTORS <IKubernetesContentSelectors[]>: List of label selectors to be added as content
  - `SelectorLevel <String>`: Selector level of the label selector
  - `SelectorValue <String>`: Value of the label selector in key=value format

FILTERAPPLICATIONS <IKubernetesContentApplications[]>: List of applications to be added as content
  - `Guid <String>`: GUID value of the Kubernetes Application to be associated as content
  - `Type <String>`: Type of the Kubernetes application
  - `[Name <String>]`: Name of the application

FILTERLABELSELECTORS <IKubernetesContentSelectors[]>: List of label selectors to be added as content
  - `SelectorLevel <String>`: Selector level of the label selector
  - `SelectorValue <String>`: Value of the label selector in key=value format

## RELATED LINKS

