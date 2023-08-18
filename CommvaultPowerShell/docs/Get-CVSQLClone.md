---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvsqlclone
schema: 2.0.0
---

# Get-CVSQLClone

## SYNOPSIS
Method to retrieve SQL clone information.

## SYNTAX

### Default (Default)
```
Get-CVSQLClone [<CommonParameters>]
```

### ById
```
Get-CVSQLClone [-ClientId <Int32>] [-InstanceId <Int32>] [<CommonParameters>]
```

### ByName
```
Get-CVSQLClone [-ClientName <String>] [-InstanceName <String>] [<CommonParameters>]
```

### ByObject
```
Get-CVSQLClone [-ClientObject <Object>] [<CommonParameters>]
```

## DESCRIPTION
Method to retrieve SQL clone information.

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

### -ClientId
Get clone information filtered by ClientId.

```yaml
Type: System.Int32
Parameter Sets: ById
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientName
Get clone information filtered by ClientName.

```yaml
Type: System.String
Parameter Sets: ByName
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientObject
Get clone information filtered by piping ClientObject.

```yaml
Type: System.Object
Parameter Sets: ByObject
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -InstanceId
Get clone information filtered by InstanceId.

```yaml
Type: System.Int32
Parameter Sets: ById
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstanceName
Get clone information filtered by InstanceName.

```yaml
Type: System.String
Parameter Sets: ByName
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

