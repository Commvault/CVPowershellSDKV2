---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/set-cvmanagedaccount
schema: 2.0.0
---

# Set-CVManagedAccount

## SYNOPSIS
Sets or resets the environment variable for the specified Lighthouse Account ID.

## SYNTAX

### Set (Default)
```
Set-CVManagedAccount [-lhAccountId <String>] [<CommonParameters>]
```

### Reset
```
Set-CVManagedAccount -Reset [<CommonParameters>]
```

## DESCRIPTION
This cmdlet allows you to set the environment variable `lhAccountId` to the provided Lighthouse Account ID.
If the `-Reset` flag is specified, it clears the `lhAccountId` environment variable.

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

### -lhAccountId
The Lighthouse Account ID to set.

```yaml
Type: System.String
Parameter Sets: Set
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Reset
Clears the Lighthouse Account ID.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: Reset
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Writes a confirmation message to the console.

## NOTES

## RELATED LINKS

