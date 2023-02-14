---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvlibrary
schema: 2.0.0
---

# Get-CVLibrary

## SYNOPSIS
Method to retrieve storage resource library instances from the CommServe.

## SYNTAX

```
Get-CVLibrary [-AllProperties] [-MediaAgentName <String>] [-Name <String>] [<CommonParameters>]
```

## DESCRIPTION
Method to retrieve storage resource library instances from the CommServe.
Output can be filtered by both library Name and associated MediaAgentName.

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

### -AllProperties
Output library instances with full detail.

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

### -MediaAgentName
Filter library instances to be output by associated MediaAgentName.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: MAName

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -Name
Filter library instances to be output by Name.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: LibraryName

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

ALIASES

## RELATED LINKS

