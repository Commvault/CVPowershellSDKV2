---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/search-cvclientfilesystem
schema: 2.0.0
---

# Search-CVClientFileSystem

## SYNOPSIS
Method to create a client file system browse query.

## SYNTAX

### ByName (Default)
```
Search-CVClientFileSystem -Name <String> [-BackupSetId <String>] [-CopyPrecedence <Int32>] [-JobId <String>]
 [-MediaAgent <String>] [-Path <String>] [-Proxy <String>] [-SubclientName <String>] [<CommonParameters>]
```

### ById
```
Search-CVClientFileSystem -Id <Int32> [-BackupSetId <String>] [-CopyPrecedence <Int32>] [-JobId <String>]
 [-MediaAgent <String>] [-Path <String>] [-Proxy <String>] [-SubclientName <String>] [<CommonParameters>]
```

### ByObject
```
Search-CVClientFileSystem -ClientObject <Object> [-BackupSetId <String>] [-CopyPrecedence <Int32>]
 [-JobId <String>] [-MediaAgent <String>] [-Path <String>] [-Proxy <String>] [-SubclientName <String>]
 [<CommonParameters>]
```

## DESCRIPTION
Method to create a client file system browse query.

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

### -BackupSetId
Specify BackupSetId for browse query.

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

### -ClientObject
Create a browse query for client specified by piped ClientObject.

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
Specify CopyPrecedence for browse query: Primary (default), Secondary, Cloud.

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

### -Id
Create a browse query for client specified by Id.

```yaml
Type: System.Int32
Parameter Sets: ById
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobId
Specify JobId for browse query.

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

### -MediaAgent
Specify MediaAgent for browse query.

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

### -Name
Create a browse query for client specified by Name.

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

### -Path
Specify Path for browse query.

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

### -Proxy
Specify Proxy for browse query.

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

### -SubclientName
Specify SubclientName for browse query.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Object

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

ALIASES

## RELATED LINKS

