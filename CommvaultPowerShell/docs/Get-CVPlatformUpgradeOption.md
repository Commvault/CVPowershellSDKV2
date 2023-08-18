---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvplatformupgradeoption
schema: 2.0.0
---

# Get-CVPlatformUpgradeOption

## SYNOPSIS
API to get eligibility for install job option at different entity level

## SYNTAX

```
Get-CVPlatformUpgradeOption [-ClientId <Int64>] [-Option <Int64>] [<CommonParameters>]
```

## DESCRIPTION
API to get eligibility for install job option at different entity level

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -ClientId
Id of the client or client group for which to fetch install job options

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Option
Specify the entity level for which to fetch install jobs options.
Accepted values [ 2 = Client, 3 = Client Group, 4 = Commcell]

```yaml
Type: System.Int64
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

### Commvault.Powershell.Models.IGetSetWindowsMssqlPatchingMsg

## NOTES

ALIASES

## RELATED LINKS

