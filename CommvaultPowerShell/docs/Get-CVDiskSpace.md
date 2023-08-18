---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvdiskspace
schema: 2.0.0
---

# Get-CVDiskSpace

## SYNOPSIS
Method to retrieve the available disk space of the library.

## SYNTAX

### ByLibraryName (Default)
```
Get-CVDiskSpace -LibraryName <String> [-MountPath <String>] [<CommonParameters>]
```

### ByLibraryObject
```
Get-CVDiskSpace -LibraryObject <Object> [-MountPath <String>] [<CommonParameters>]
```

### ByMediaAgentName
```
Get-CVDiskSpace -MediaAgentName <String> [-MountPath <String>] [<CommonParameters>]
```

## DESCRIPTION
Method to retrieve the available disk space of the library.
Requires either the LibraryName or an associated MediaAgentName.

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

### -LibraryName
Retrieve available disk space details for the library specified by LibraryName.

```yaml
Type: System.String
Parameter Sets: ByLibraryName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -LibraryObject


```yaml
Type: System.Object
Parameter Sets: ByLibraryObject
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -MediaAgentName
Retrieve available disk space details for libraries associated with MediaAgentName.

```yaml
Type: System.String
Parameter Sets: ByMediaAgentName
Aliases: MAName

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -MountPath
Filter output for a specific MountPath.

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

### System.String

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

ALIASES

## RELATED LINKS

