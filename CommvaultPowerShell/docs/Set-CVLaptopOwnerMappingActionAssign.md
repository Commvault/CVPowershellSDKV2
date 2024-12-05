---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/set-cvlaptopownermappingactionassign
schema: 2.0.0
---

# Set-CVLaptopOwnerMappingActionAssign

## SYNOPSIS
API to assign users specified in device owner mapping as owners of laptops presented in the request body.

## SYNTAX

### PutExpanded (Default)
```
Set-CVLaptopOwnerMappingActionAssign [-CompanyId <Int64>] [-ApplyAll] [-LaptopOwnerMapping <Int64[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Put
```
Set-CVLaptopOwnerMappingActionAssign -Body <IAssignLaptopOwnerMappingReq> [-CompanyId <Int64>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to assign users specified in device owner mapping as owners of laptops presented in the request body.

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

### -ApplyAll
This indicates if applying assign laptop owners to all device user mappings within a company

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

### -Body
Model used for assign laptop owner mapping

```yaml
Type: Commvault.Powershell.Models.IAssignLaptopOwnerMappingReq
Parameter Sets: Put
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyId
Id of the company that this operation will be performed for

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

### -LaptopOwnerMapping
Accepts list of laptop owner mapping ids to be applied

```yaml
Type: System.Int64[]
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

### Commvault.Powershell.Models.IAssignLaptopOwnerMappingReq

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IAssignLaptopOwnerMappingReq>`: Model used for assign laptop owner mapping
  - `[ApplyAll <Boolean?>]`: This indicates if applying assign laptop owners to all device user mappings within a company
  - `[LaptopOwnerMapping <List<Int64>>]`: Accepts list of laptop owner mapping ids to be applied

## RELATED LINKS

