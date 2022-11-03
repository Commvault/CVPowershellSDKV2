---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/backup-cvsqlinstance
schema: 2.0.0
---

# Backup-CVSQLInstance

## SYNOPSIS
Method to submit backup job for SQL instance.

## SYNTAX

### ByName (Default)
```
Backup-CVSQLInstance -Name <String> [-BackupType <CVSQLBackupType>] [-Force] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ByObject
```
Backup-CVSQLInstance -InstanceObject <Object> [-BackupType <CVSQLBackupType>] [-Force] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Method to submit backup job for SQL instance.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -BackupType
The BackupType: full, incremental (default), differential.

```yaml
Type: CVSQLBackupType
Parameter Sets: (All)
Aliases:

Required: False
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

### -InstanceObject
The SQL InstanceObject.

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

### -Name
The SQL instance Name.

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

### System.Management.Automation.PSObject

## NOTES

ALIASES

## RELATED LINKS

