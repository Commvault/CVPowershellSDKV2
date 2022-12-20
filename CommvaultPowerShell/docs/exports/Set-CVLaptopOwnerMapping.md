---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-cvlaptopownermapping
schema: 2.0.0
---

# Set-CVLaptopOwnerMapping

## SYNOPSIS
API to update existing laptop owner mapping

## SYNTAX

### PutExpanded (Default)
```
Set-CVLaptopOwnerMapping [-LaptopOwnerMapping <ILaptopOwnerInfo[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Put
```
Set-CVLaptopOwnerMapping -Body <ILaptopOwnerMapping> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to update existing laptop owner mapping

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

### -Body
List of laptop owner info
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ILaptopOwnerMapping
Parameter Sets: Put
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
Type: Commvault.Powershell.Models.ILaptopOwnerInfo[]
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

### Commvault.Powershell.Models.ILaptopOwnerMapping

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <ILaptopOwnerMapping>`: List of laptop owner info
  - `[LaptopOwnerMapping1 <ILaptopOwnerInfo[]>]`: 
    - `Id <Int64>`: Unique Id
    - `[CompanyId <Int64?>]`: 
    - `[CompanyName <String>]`: 
    - `[Host <String>]`: host name of the laptop
    - `[LaptopName <String>]`: name of the laptop
    - `[OSType <String>]`: OS type of the laptop. Can be LINUX or MAC
    - `[OwnerEmail <String>]`: Email address of the owner
    - `[OwnerUpn <String>]`: UPN of the owner
    - `[SerialNumber <String>]`: This is the serial number

`LAPTOPOWNERMAPPING <ILaptopOwnerInfo[]>`: .
  - `Id <Int64>`: Unique Id
  - `[CompanyId <Int64?>]`: 
  - `[CompanyName <String>]`: 
  - `[Host <String>]`: host name of the laptop
  - `[LaptopName <String>]`: name of the laptop
  - `[OSType <String>]`: OS type of the laptop. Can be LINUX or MAC
  - `[OwnerEmail <String>]`: Email address of the owner
  - `[OwnerUpn <String>]`: UPN of the owner
  - `[SerialNumber <String>]`: This is the serial number

## RELATED LINKS

