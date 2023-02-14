---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/backup-cvvirtualmachine
schema: 2.0.0
---

# Backup-CVVirtualMachine

## SYNOPSIS
Method to initiate backup of specified virtual machine.

## SYNTAX

### ByName (Default)
```
Backup-CVVirtualMachine -ClientName <String> -Name <String> [-BackupType <CVBackupType>] [-Force] [-Protected]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ById
```
Backup-CVVirtualMachine -Id <String> [-BackupType <CVBackupType>] [-Force] [-Protected] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ByObject
```
Backup-CVVirtualMachine -ClientObject <Object> [-BackupType <CVBackupType>] [-Force] [-Protected] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Method to initiate backup of specified virtual machine.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BackupType
Backup Type for the backup of Virtual Machine , default is INCREMENTAL .
Supported values are FULL, INCREMENTAL, DIFFERENTIAL, SYNTHETIC_FULL

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
Virtual machine associated ClientName.

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

### -ClientObject
Virtual machine associated client specified by piped ClientObject.

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
Virtual machine Id: this is the virtual machine GUID.

```yaml
Type: System.String
Parameter Sets: ById
Aliases: VMName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Virtual machine Name.

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

### -Protected
Use this switch to filter legacy, unprotected virtual machines when specifed by Name.

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

### Backup-CVVM

## RELATED LINKS

