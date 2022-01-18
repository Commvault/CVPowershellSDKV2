---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-hyperscalestorage
schema: 2.0.0
---

# New-HyperScaleStorage

## SYNOPSIS
Create a HyperScale Storage

## SYNTAX

### Create (Default)
```
New-HyperScaleStorage -Body <IHyperScaleStorage> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded
```
New-HyperScaleStorage -Name <String> -Nodes <IIdName[]> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a HyperScale Storage

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
HyperScaleStorage
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IHyperScaleStorage
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
Name of HyperScale Storage

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Nodes
List of Nodes (MediaAgents) of the HyperScale Storage
To construct, see NOTES section for NODES properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: CreateExpanded
Aliases:

Required: True
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

### Commvault.Powershell.Models.IHyperScaleStorage

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

### Commvault.Powershell.Models.IHyperScaleStorageResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IHyperScaleStorage>: HyperScaleStorage
  - `Name <String>`: Name of HyperScale Storage
  - `Nodes <IIdName[]>`: List of Nodes (MediaAgents) of the HyperScale Storage
    - `[Id <Int32?>]`: 
    - `[Name <String>]`: 

NODES <IIdName[]>: List of Nodes (MediaAgents) of the HyperScale Storage
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

