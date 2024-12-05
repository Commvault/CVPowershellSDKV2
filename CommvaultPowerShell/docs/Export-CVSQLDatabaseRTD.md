---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/export-cvsqldatabasertd
schema: 2.0.0
---

# Export-CVSQLDatabaseRTD

## SYNOPSIS
Method to submit restore-to-disk SQL database export job.

## SYNTAX

### ByName (Default)
```
Export-CVSQLDatabaseRTD -DestClientName <String> -DestDiskPath <String> -Name <String> [-JobId <Int32>]
 [-OverwriteExisting] [<CommonParameters>]
```

### ByObject
```
Export-CVSQLDatabaseRTD -DatabaseObject <Object> -DestClientName <String> -DestDiskPath <String>
 [-JobId <Int32>] [-OverwriteExisting] [<CommonParameters>]
```

## DESCRIPTION
Method to submit restore-to-disk SQL database export job.

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

### -DatabaseObject
Specify the database files to be exported by piping DatabaseObject.

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

### -DestClientName
Export the SQL database files to DestClientName.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DestDiskPath
Export the SQL database files to DestDiskPath.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobId
Export the SQL database files for a given JobId.

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
Specify the database files to be exported by database Name.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Object

## OUTPUTS

### System.String

## NOTES

## RELATED LINKS

