---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvworkflow
schema: 2.0.0
---

# Get-CVWorkflow

## SYNOPSIS
Method to retrieve workflows from the CommServe.

## SYNTAX

### ByList (Default)
```
Get-CVWorkflow [<CommonParameters>]
```

### ById
```
Get-CVWorkflow [-Id <Int32>] [<CommonParameters>]
```

### ByName
```
Get-CVWorkflow [-Name <String>] [<CommonParameters>]
```

## DESCRIPTION
Method to retrieve workflows from the CommServe.
Output can be filtered by workflow Name or Id.

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

### -Id
Specify the workflow to be output by Id.

```yaml
Type: System.Int32
Parameter Sets: ById
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -Name
Specify the workflow to be output by Name.

```yaml
Type: System.String
Parameter Sets: ByName
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

ALIASES

## RELATED LINKS

