---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/set-cvlaptopownermapping
schema: 2.0.0
---

# Set-CVLaptopOwnerMapping

## SYNOPSIS
API to update existing laptop owner mapping

## SYNTAX

### PutExpanded (Default)
```
Set-CVLaptopOwnerMapping [-ErrorCode <Int64>] [-ErrorMessage <String>]
 [-LaptopOwnerMapping <ILaptopOwnerInfo[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Put
```
Set-CVLaptopOwnerMapping -Body <ILaptopOwnerMapping> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to update existing laptop owner mapping

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
List of laptop owner info

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

### -ErrorCode
.

```yaml
Type: System.Int64
Parameter Sets: PutExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ErrorMessage
.

```yaml
Type: System.String
Parameter Sets: PutExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LaptopOwnerMapping
.

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

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <ILaptopOwnerMapping>`: List of laptop owner info
  - `[ErrorCode <Int64?>]`: 
  - `[ErrorMessage <String>]`: 
  - `[LaptopOwnerMapping1 <List<ILaptopOwnerInfo>>]`: 
    - `Id <Int64>`: Unique Id
    - `[ClientId <Int64?>]`: 
    - `[ClientName <String>]`: 
    - `[CompanyId <Int64?>]`: 
    - `[CompanyName <String>]`: 
    - `[Configured <Boolean?>]`: This indicates if the laptop has been installed or not
    - `[Host <String>]`: host name of the laptop
    - `[LaptopName <String>]`: name of the laptop
    - `[OSType <String>]`: OS type of the laptop. Can be LINUX or MAC
    - `[OwnerEmail <String>]`: Email address of the owner
    - `[OwnerUpn <String>]`: UPN of the owner
    - `[SerialNumber <String>]`: This is the serial number

`LAPTOPOWNERMAPPING <ILaptopOwnerInfo[]>`: .
  - `Id <Int64>`: Unique Id
  - `[ClientId <Int64?>]`: 
  - `[ClientName <String>]`: 
  - `[CompanyId <Int64?>]`: 
  - `[CompanyName <String>]`: 
  - `[Configured <Boolean?>]`: This indicates if the laptop has been installed or not
  - `[Host <String>]`: host name of the laptop
  - `[LaptopName <String>]`: name of the laptop
  - `[OSType <String>]`: OS type of the laptop. Can be LINUX or MAC
  - `[OwnerEmail <String>]`: Email address of the owner
  - `[OwnerUpn <String>]`: UPN of the owner
  - `[SerialNumber <String>]`: This is the serial number

## RELATED LINKS

