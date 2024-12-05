---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/restore-cvvirtualmachine
schema: 2.0.0
---

# Restore-CVVirtualMachine

## SYNOPSIS
Method to initiate restore/recovery of specified virtual machine.

## SYNTAX

### ByName (Default)
```
Restore-CVVirtualMachine -ClientName <String> -Name <String> [-CopyPrecedence <Int32>] [-Force]
 [-JobId <Int32>] [-OutofPlace] [-OverwriteExisting] [-PowerOnAfterRestore] [-Requestbody <Object>]
 [-RestoreType <CVVSARestoreType>] [-SubclientName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ById
```
Restore-CVVirtualMachine -Id <String> [-CopyPrecedence <Int32>] [-Force] [-JobId <Int32>] [-OutofPlace]
 [-OverwriteExisting] [-PowerOnAfterRestore] [-Requestbody <Object>] [-RestoreType <CVVSARestoreType>]
 [-SubclientName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ByObject
```
Restore-CVVirtualMachine -ClientObject <Object> [-CopyPrecedence <Int32>] [-Force] [-JobId <Int32>]
 [-OutofPlace] [-OverwriteExisting] [-PowerOnAfterRestore] [-Requestbody <Object>]
 [-RestoreType <CVVSARestoreType>] [-SubclientName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Method to initiate restore/recovery of specified virtual machine.

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

### -ClientName
Source virtual machine associated ClientName

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

### -CopyPrecedence
Specify CopyPrecedence from which the restore should occur: Primary, secondary or cloud.

```yaml
Type: System.Int32
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

### -Id
Specify the virtual machine to be restored by GUID.

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

### -JobId
Specify JobId from which to restore.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Specify the virtual machine to be restored by Name.

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

### -OutofPlace
Switch to create an out-of-place virtual machine restore.

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

### -OverwriteExisting
Switch to OverwriteExisting.

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

### -PowerOnAfterRestore
Switch to PowerOnAfterRestore.

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

### -Requestbody
PSCustom object with request body which contains destination client and destination info or vmFileLevelRestoreOptions for out-of-place restore

```yaml
Type: System.Object
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestoreType
Specify RestoreType: FullVirtualMachine or VirtualMachineFiles.

```yaml
Type: CVVSARestoreType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubclientName
Specify SubclientName to override the default behaviour.

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

Restore-CVVM

Restore-CVVMOut

## RELATED LINKS

