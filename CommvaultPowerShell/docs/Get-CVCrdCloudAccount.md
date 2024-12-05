---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/get-cvcrdcloudaccount
schema: 2.0.0
---

# Get-CVCrdCloudAccount

## SYNOPSIS
This endpoint is used to return the list of cloud accounts for Cloud Resource Discovery operation.

## SYNTAX

```
Get-CVCrdCloudAccount -Vendor <Int64> [-TargetApp <Int64>] [-TargetInstance <Int64>] [-PassThru]
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint is used to return the list of cloud accounts for Cloud Resource Discovery operation.

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

### -TargetApp
App type for which the Cloud Resorce Discovery instance is being configured.
Supported App type:
134-Cloud Apps

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

### -TargetInstance
Cloud apps instance type for which the Cloud Resorce Discovery instance is being configured.
Supported Cloud apps instance type:
6-Azure Blob

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

### -Vendor
Type of the cloud vendor.
Cloud accounts for the specified cloud vendor will be returned.
Supported Vendor type:
3-Azure

```yaml
Type: System.Int64
Parameter Sets: (All)
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

### Commvault.Powershell.Models.IGetCrdCloudAccountsResponse

## NOTES

## RELATED LINKS

