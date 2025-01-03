---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/get-cvclientgroup
schema: 2.0.0
---

# Get-CVClientGroup

## SYNOPSIS
Method to retrieve client groups from the CommServe.

## SYNTAX

### Default (Default)
```
Get-CVClientGroup [-AllProperties] [<CommonParameters>]
```

### ByName
```
Get-CVClientGroup [-AllProperties] [-Name <String>] [<CommonParameters>]
```

## DESCRIPTION
Method to retrieve client groups or a single specified group from the CommServe.

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

### -AllProperties
Get detail properties for each client group.

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
Get a client group by Name.

```yaml
Type: System.String
Parameter Sets: ByName
Aliases: ClientGroupName

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

Get-CVClientGroupProps

## RELATED LINKS

