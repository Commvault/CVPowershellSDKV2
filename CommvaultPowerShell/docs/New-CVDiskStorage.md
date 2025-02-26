---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/new-cvdiskstorage
schema: 2.0.0
---

# New-CVDiskStorage

## SYNOPSIS
Create a new disk storage pool

## SYNTAX

```
New-CVDiskStorage [-DeduplicationDbStorage <IDedupePath[]>] [-EnableDeduplication] [-Name <String>]
 [-Storage <IPath[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new disk storage pool

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

### -DeduplicationDbStorage
A list of dedupe locations can be provided for the storage pool being created.
This provides an efficient way to save/store data by eliminating duplicate blocks of data during backups.

```yaml
Type: Commvault.Powershell.Models.IDedupePath[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableDeduplication
enables or disables deduplication

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

### -Name
Name of the Disk Storage to be created.

```yaml
Type: System.String
Parameter Sets: (All)
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

### -Storage
A list of backup locations can be provided for the storage pool being created.

```yaml
Type: Commvault.Powershell.Models.IPath[]
Parameter Sets: (All)
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

## OUTPUTS

### Commvault.Powershell.Models.IIdName

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`DEDUPLICATIONDBSTORAGE <IDedupePath[]>`: A list of dedupe locations can be provided for the storage pool being created. This provides an efficient way to save/store data by eliminating duplicate blocks of data during backups.
  - `[MediaAgentId <Int64?>]`: 
  - `[MediaAgentName <String>]`: 
  - `[Path <String>]`: 

`STORAGE <IPath[]>`: A list of backup locations can be provided for the storage pool being created.
  - `[BackupLocation <String>]`: 
  - `[CredentialsName <String>]`: username to access the network path
  - `[CredentialsPassword <String>]`: password to access the network path
  - `[MediaAgentId <Int64?>]`: 
  - `[MediaAgentName <String>]`: 
  - `[SavedCredentialsId <Int64?>]`: 
  - `[SavedCredentialsName <String>]`: 

## RELATED LINKS

