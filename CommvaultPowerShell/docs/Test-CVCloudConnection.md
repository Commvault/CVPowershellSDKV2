---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/test-cvcloudconnection
schema: 2.0.0
---

# Test-CVCloudConnection

## SYNOPSIS
Verifies cloud resource connectivity from a list of backup gateways to given hostname and port

## SYNTAX

### TestExpanded (Default)
```
Test-CVCloudConnection [-BackupGatewayIds <Int64[]>] [-Hostname <String>] [-Port <Int64>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Test
```
Test-CVCloudConnection -Body <ITestCloudConnectionReq> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Verifies cloud resource connectivity from a list of backup gateways to given hostname and port

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

### -BackupGatewayIds
Backup gateways list for connectivity verification

```yaml
Type: System.Int64[]
Parameter Sets: TestExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Request body for checking cloud resource connectivity

```yaml
Type: Commvault.Powershell.Models.ITestCloudConnectionReq
Parameter Sets: Test
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Hostname
Hostname / IP address of cloud resource

```yaml
Type: System.String
Parameter Sets: TestExpanded
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

### -Port
Connection port

```yaml
Type: System.Int64
Parameter Sets: TestExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Commvault.Powershell.Models.ITestCloudConnectionReq

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

### System.String

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <ITestCloudConnectionReq>`: Request body for checking cloud resource connectivity
  - `BackupGatewayIds <List<Int64>>`: Backup gateways list for connectivity verification
  - `Hostname <String>`: Hostname / IP address of cloud resource
  - `Port <Int64>`: Connection port

## RELATED LINKS

