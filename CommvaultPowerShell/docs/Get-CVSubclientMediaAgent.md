---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/get-cvsubclientmediaagent
schema: 2.0.0
---

# Get-CVSubclientMediaAgent

## SYNOPSIS
Method to retrieve subclient media agent instances from the CommServe.

## SYNTAX

### ByName (Default)
```
Get-CVSubclientMediaAgent -ClientName <String> -Name <String> [<CommonParameters>]
```

### ById
```
Get-CVSubclientMediaAgent -ClientName <String> -Id <Int32> [<CommonParameters>]
```

### ByObject
```
Get-CVSubclientMediaAgent -SubclientObject <Object> [<CommonParameters>]
```

## DESCRIPTION
Method to retrieve subclient media agent instances from the CommServe.

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

### -ClientName
Provide ClientName for subclient lookup.

```yaml
Type: System.String
Parameter Sets: ById, ByName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Retrieve media agent instances for subclient identified by Id.

```yaml
Type: System.Int32
Parameter Sets: ById
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Retrieve media agent instances for subclient identified by Name.

```yaml
Type: System.String
Parameter Sets: ByName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubclientObject
Retrieve media agent instances by piped SubclientObject.

```yaml
Type: System.Object
Parameter Sets: ByObject
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Object

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

## RELATED LINKS

