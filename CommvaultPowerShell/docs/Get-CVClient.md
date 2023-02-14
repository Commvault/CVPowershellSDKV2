---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvclient
schema: 2.0.0
---

# Get-CVClient

## SYNOPSIS
Method to retrieve the list of clients or detailed client properties from the CommServe.

## SYNTAX

### Default (Default)
```
Get-CVClient [-AdditionalSettings] [-AllProperties] [-TimeZone] [-Version] [<CommonParameters>]
```

### ById
```
Get-CVClient [-AdditionalSettings] [-AllProperties] [-Id <Int32>] [-TimeZone] [-Version] [<CommonParameters>]
```

### ByName
```
Get-CVClient [-AdditionalSettings] [-AllProperties] [-Name <String>] [-TimeZone] [-Version]
 [<CommonParameters>]
```

## DESCRIPTION
If the Name parameter is not provided, this method will output a list of clients from the CommServe.
If the Name parameter is provided, a default subset of client properties will be output for the specified client.

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

### -AdditionalSettings
Retrieves additional setting properties for each client in the list.

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

### -AllProperties
Retrieves all properties for the specified client.

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

### -Id
Get detail properties for client specified by Id.

```yaml
Type: System.Int32
Parameter Sets: ById
Aliases: ClientId

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Get detail properties for client specified by Name.

```yaml
Type: System.String
Parameter Sets: ByName
Aliases: Client

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeZone
Retrieves timezone properties for the specified client.

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

### -Version
Retrieves package version properties for the specified client.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

ALIASES

### Get-CVClientProps

### Get-CVClientAdditionalSettings

## RELATED LINKS

