---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/invoke-cvmanagecyberresiliencecredentials
schema: 2.0.0
---

# Invoke-CVManageCyberResilienceCredentials

## SYNOPSIS
Manage Credentials configured for Cyber Resilience

## SYNTAX

### ManageExpanded (Default)
```
Invoke-CVManageCyberResilienceCredentials [-Credentials <ICyberResilienceCredentialOperation[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Manage
```
Invoke-CVManageCyberResilienceCredentials -Body <ICyberResilienceManageCredentials> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Manage Credentials configured for Cyber Resilience

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

### -Body
CyberResilienceManageCredentials

```yaml
Type: Commvault.Powershell.Models.ICyberResilienceManageCredentials
Parameter Sets: Manage
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Credentials
.

```yaml
Type: Commvault.Powershell.Models.ICyberResilienceCredentialOperation[]
Parameter Sets: ManageExpanded
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

### Commvault.Powershell.Models.ICyberResilienceManageCredentials

## OUTPUTS

### Commvault.Powershell.Models.ICyberResilienceGenericResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <ICyberResilienceManageCredentials>`: CyberResilienceManageCredentials
  - `Credentials <List<ICyberResilienceCredentialOperation>>`: 
    - `Id <Int64>`: Credential ID
    - `Operation <String>`: Basic operation types

`CREDENTIALS <ICyberResilienceCredentialOperation[]>`: .
  - `Id <Int64>`: Credential ID
  - `Operation <String>`: Basic operation types

## RELATED LINKS

