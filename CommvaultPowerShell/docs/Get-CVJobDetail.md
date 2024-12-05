---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/get-cvjobdetail
schema: 2.0.0
---

# Get-CVJobDetail

## SYNOPSIS
Gets extended details for a job.

## SYNTAX

### ById (Default)
```
Get-CVJobDetail -Id <Int32> [-InfoType <Int32>] [<CommonParameters>]
```

### ByObject
```
Get-CVJobDetail -JobObject <Object> [<CommonParameters>]
```

## DESCRIPTION
Gets extended details for a job.
JobId must be valid.

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

### -Id
Gets extended details for the job specified by Id.

```yaml
Type: System.Int32
Parameter Sets: ById
Aliases: JobId

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InfoType
Gets additional job information.

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

### -JobObject
Gets extended details for the job specified by piped JobObject.

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

### System.Int32

### System.Object

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

ALIASES

Get-CVJobDetails

## RELATED LINKS

