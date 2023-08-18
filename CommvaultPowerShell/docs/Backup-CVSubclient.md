---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/backup-cvsubclient
schema: 2.0.0
---

# Backup-CVSubclient

## SYNOPSIS
Create backup task for specific subclient.

## SYNTAX

### ByName (Default)
```
Backup-CVSubclient -ClientName <String> -Name <String> [-BackupType <CVBackupType>] [-Force] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ById
```
Backup-CVSubclient -ClientName <String> -Id <Int32> [-BackupType <CVBackupType>] [-Force] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ByObject
```
Backup-CVSubclient -SubclientObject <Object> [-BackupType <CVBackupType>] [-Force] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create backup task for specific subclient.

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

### -BackupType
The BackupType: full, incremental (default), differential, synthFull.

```yaml
Type: CVBackupType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientName
Provide ClientName for subclient lookup.

```yaml
Type: System.String
Parameter Sets: ById, ByName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Force
Switch to Force override of default 'WhatIf' confirmation behavior.

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

### -Id
Create backup task for subclient identified by Id.

```yaml
Type: System.Int32
Parameter Sets: ById
Aliases: SubclientId

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Create backup task for subclient identified by Name.

```yaml
Type: System.String
Parameter Sets: ByName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubclientObject
Create backup task for subclient identified by SubclientObject.

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

### System.Object

## OUTPUTS

### System.String

## NOTES

ALIASES

### Protect-CVSubclient

## RELATED LINKS

