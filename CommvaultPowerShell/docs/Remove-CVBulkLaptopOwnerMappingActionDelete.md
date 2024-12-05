---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/remove-cvbulklaptopownermappingactiondelete
schema: 2.0.0
---

# Remove-CVBulkLaptopOwnerMappingActionDelete

## SYNOPSIS
API is used to delete multiple laptopowner mappings

## SYNTAX

### DeleteExpanded (Default)
```
Remove-CVBulkLaptopOwnerMappingActionDelete [-LaptopOwnerMapping <Int64[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Delete
```
Remove-CVBulkLaptopOwnerMappingActionDelete -Body <IDeleteLaptopOwnerMapping> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
API is used to delete multiple laptopowner mappings

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
This model accepts the list of laptop owner mapping to be deleted

```yaml
Type: Commvault.Powershell.Models.IDeleteLaptopOwnerMapping
Parameter Sets: Delete
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LaptopOwnerMapping
Accepts list of laptop owner mapping ids to be deleted

```yaml
Type: System.Int64[]
Parameter Sets: DeleteExpanded
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

### Commvault.Powershell.Models.IDeleteLaptopOwnerMapping

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IDeleteLaptopOwnerMapping>`: This model accepts the list of laptop owner mapping to be deleted
  - `LaptopOwnerMapping <List<Int64>>`: Accepts list of laptop owner mapping ids to be deleted

## RELATED LINKS

