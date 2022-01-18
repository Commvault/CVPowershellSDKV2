---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-diskstorage
schema: 2.0.0
---

# New-DiskStorage

## SYNOPSIS
Create a new disk storage pool

## SYNTAX

### Create (Default)
```
New-DiskStorage -Body <ICreateDiskStorage> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded
```
New-DiskStorage -EnableDeduplication -Name <String> -Storage <IPath[]>
 [-DeduplicationDbStorage <IDedupePath[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new disk storage pool

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

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICreateDiskStorage
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeduplicationDbStorage
A list of dedupe locations can be provided for the storage pool being created.
This provides an efficient way to save/store data by eliminating duplicate blocks of data during backups.
To construct, see NOTES section for DEDUPLICATIONDBSTORAGE properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IDedupePath[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Name of the Disk Storage to be created.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
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
To construct, see NOTES section for STORAGE properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IPath[]
Parameter Sets: CreateExpanded
Aliases:

Required: True
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

### Commvault.Powershell.Models.ICreateDiskStorage

## OUTPUTS

### Commvault.Powershell.Models.IIdName

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <ICreateDiskStorage>: .
  - `EnableDeduplication <Boolean>`: enables or disables deduplication
  - `Name <String>`: Name of the Disk Storage to be created.
  - `Storage <IPath[]>`: A list of backup locations can be provided for the storage pool being created.
    - `[BackupLocation <String>]`: 
    - `[CredentialsName <String>]`: username to access the network path
    - `[CredentialsPassword <String>]`: password to access the network path
    - `[MediaAgentId <Int32?>]`: 
    - `[MediaAgentName <String>]`: 
    - `[SavedCredentialsId <Int32?>]`: 
    - `[SavedCredentialsName <String>]`: 
  - `[DeduplicationDbStorage <IDedupePath[]>]`: A list of dedupe locations can be provided for the storage pool being created. This provides an efficient way to save/store data by eliminating duplicate blocks of data during backups.
    - `[MediaAgentId <Int32?>]`: 
    - `[MediaAgentName <String>]`: 
    - `[Path <String>]`: 

DEDUPLICATIONDBSTORAGE <IDedupePath[]>: A list of dedupe locations can be provided for the storage pool being created. This provides an efficient way to save/store data by eliminating duplicate blocks of data during backups.
  - `[MediaAgentId <Int32?>]`: 
  - `[MediaAgentName <String>]`: 
  - `[Path <String>]`: 

STORAGE <IPath[]>: A list of backup locations can be provided for the storage pool being created.
  - `[BackupLocation <String>]`: 
  - `[CredentialsName <String>]`: username to access the network path
  - `[CredentialsPassword <String>]`: password to access the network path
  - `[MediaAgentId <Int32?>]`: 
  - `[MediaAgentName <String>]`: 
  - `[SavedCredentialsId <Int32?>]`: 
  - `[SavedCredentialsName <String>]`: 

## RELATED LINKS

