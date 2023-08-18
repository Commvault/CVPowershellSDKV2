---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/select-cvclientfilesystem
schema: 2.0.0
---

# Select-CVClientFileSystem

## SYNOPSIS
Retrieve list of protected files in client file system by search pattern.

## SYNTAX

### ByName (Default)
```
Select-CVClientFileSystem -FilePattern <String> -Name <String> [<CommonParameters>]
```

### ById
```
Select-CVClientFileSystem -FilePattern <String> -Id <Int32> [<CommonParameters>]
```

### ByObject
```
Select-CVClientFileSystem -ClientObject <Object> -FilePattern <String> [<CommonParameters>]
```

## DESCRIPTION
Retrieve list of protected files in client file system by search pattern.

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

### -ClientObject
Retrieve file list for client specified by piped ClientObject.

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

### -FilePattern
Provide file pattern for search e.g.
'*.txt'.

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

### -Id
Retrieve file list for client specified by Id.

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

### -Name
Retrieve file list for client specified by Name.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Object

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

ALIASES

## RELATED LINKS

