---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-cvlaptopownermapping
schema: 2.0.0
---

# Invoke-CVLaptopOwnerMapping

## SYNOPSIS
API to create laptop owner mappings

## SYNTAX

### PostExpanded (Default)
```
Invoke-CVLaptopOwnerMapping [-LaptopOwnerMapping <ICreateLaptopOwnerInfo[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Post
```
Invoke-CVLaptopOwnerMapping -Body <ICreateLaptopOwnerMapping> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to create laptop owner mappings

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

### -Body
POST request for adding new laptop owner mapping, The mandotary fields are combination of multiple properties SerialNumber AND (host OR laptopName) AND (ownerEmail OR ownerUPN)
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICreateLaptopOwnerMapping
Parameter Sets: Post
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LaptopOwnerMapping
.
To construct, see NOTES section for LAPTOPOWNERMAPPING properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICreateLaptopOwnerInfo[]
Parameter Sets: PostExpanded
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

### Commvault.Powershell.Models.ICreateLaptopOwnerMapping

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <ICreateLaptopOwnerMapping>: POST request for adding new laptop owner mapping, The mandotary fields are combination of multiple properties SerialNumber AND (host OR laptopName) AND (ownerEmail OR ownerUPN)
  - `[LaptopOwnerMapping <ICreateLaptopOwnerInfo[]>]`: 
    - `[CompanyId <Int64?>]`: 
    - `[CompanyName <String>]`: 
    - `[Host <String>]`: Host name of the laptop
    - `[LaptopName <String>]`: Display name of the laptop
    - `[OSType <String>]`: Operating system of the owner
    - `[OwnerEmail <String>]`: Email address of the owner
    - `[OwnerUpn <String>]`: UPN of the owner
    - `[SerialNumber <String>]`: Serial number of the laptop

LAPTOPOWNERMAPPING <ICreateLaptopOwnerInfo[]>: .
  - `[CompanyId <Int64?>]`: 
  - `[CompanyName <String>]`: 
  - `[Host <String>]`: Host name of the laptop
  - `[LaptopName <String>]`: Display name of the laptop
  - `[OSType <String>]`: Operating system of the owner
  - `[OwnerEmail <String>]`: Email address of the owner
  - `[OwnerUpn <String>]`: UPN of the owner
  - `[SerialNumber <String>]`: Serial number of the laptop

## RELATED LINKS

