---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/get-cvmediaagent
schema: 2.0.0
---

# Get-CVMediaAgent

## SYNOPSIS
Get All Media Agents

## SYNTAX

### Get (Default)
```
Get-CVMediaAgent [-PassThru] [<CommonParameters>]
```

### Get1
```
Get-CVMediaAgent [-FetchDdbDisks] [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
Get All Media Agents

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

### -FetchDdbDisks
If set to true then fetch the list of DDB disks hosted on each MediaAgent

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: Get1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

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

### Commvault.Powershell.Models.IMediaAgentForDdbListResponse

### Commvault.Powershell.Models.IMediaAgentListResponse

## NOTES

ALIASES

Get-CVBackupGateway

## RELATED LINKS

