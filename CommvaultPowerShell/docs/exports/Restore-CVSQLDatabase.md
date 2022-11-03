---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/restore-cvsqldatabase
schema: 2.0.0
---

# Restore-CVSQLDatabase

## SYNOPSIS
Method to submit SQL database in-place or out-of-place restore job.

## SYNTAX

### ByName (Default)
```
Restore-CVSQLDatabase -Name <String> [-CopyPrecedence <Int32>] [-Force] [-OutofPlace] [-OverwriteExisting]
 [-PointInTime <Int32>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ByObject
```
Restore-CVSQLDatabase -DatabaseObject <Object> [-CopyPrecedence <Int32>] [-Force] [-OutofPlace]
 [-OverwriteExisting] [-PointInTime <Int32>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Method to submit SQL database in-place or out-of-place restore job.

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

### -CopyPrecedence
Specify the database files to be restored by the CopyPrecedence applicable to your environment.

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

### -DatabaseObject
Specify the database files to be restored by piping DatabaseObject.

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

### -Name
Specify the database files to be restored by database Name.

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
Switch to initiate an out-of-place restore.

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
Switch to control OverwriteExisting of the database files.

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

### -PointInTime
Specify the database files to be restored by PointInTime.

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

## RELATED LINKS

