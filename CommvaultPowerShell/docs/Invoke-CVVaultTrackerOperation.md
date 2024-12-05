---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/invoke-cvvaulttrackeroperation
schema: 2.0.0
---

# Invoke-CVVaultTrackerOperation

## SYNOPSIS
Perform VaultTracker Operations

## SYNTAX

### VaultExpanded (Default)
```
Invoke-CVVaultTrackerOperation [-OpType <String>] [-VtActionList <IVaultTrackerOperationInfo[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Vault
```
Invoke-CVVaultTrackerOperation -Body <IVaultTrackerOperationReq> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Perform VaultTracker Operations

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
Payload for VaultTracker Operation

```yaml
Type: Commvault.Powershell.Models.IVaultTrackerOperationReq
Parameter Sets: Vault
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OpType
Supported operations for VaultTracker Action

```yaml
Type: System.String
Parameter Sets: VaultExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VtActionList
.

```yaml
Type: Commvault.Powershell.Models.IVaultTrackerOperationInfo[]
Parameter Sets: VaultExpanded
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

### Commvault.Powershell.Models.IVaultTrackerOperationReq

## OUTPUTS

### Commvault.Powershell.Models.IGenericResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IVaultTrackerOperationReq>`: Payload for VaultTracker Operation
  - `[OpType <String>]`: Supported operations for VaultTracker Action
  - `[VtActionList <List<IVaultTrackerOperationInfo>>]`: 
    - `[ActionId <Int64?>]`: Id of action
    - `[ContainerId <Int64?>]`: 
    - `[ContainerName <String>]`: 
    - `[HistoryId <Int64?>]`: Id of history
    - `[MediaList <List<Int64>>]`: List of mediaIds

`VTACTIONLIST <IVaultTrackerOperationInfo[]>`: .
  - `[ActionId <Int64?>]`: Id of action
  - `[ContainerId <Int64?>]`: 
  - `[ContainerName <String>]`: 
  - `[HistoryId <Int64?>]`: Id of history
  - `[MediaList <List<Int64>>]`: List of mediaIds

## RELATED LINKS

