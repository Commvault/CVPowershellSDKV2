---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvsubclient
schema: 2.0.0
---

# Get-CVSubclient

## SYNOPSIS
Method to retrieve the list of subclients or a named subclient for a given client from the CommServe.

## SYNTAX

### ByClientName (Default)
```
Get-CVSubclient -ClientName <String> [-AllProperties] [-Id <Int32>] [-Name <String>] [<CommonParameters>]
```

### ByClientObject
```
Get-CVSubclient -ClientObject <Object> [-AllProperties] [-Id <Int32>] [-Name <String>] [<CommonParameters>]
```

## DESCRIPTION
Method to retrieve the list of subclients or a named subclient for a given client from the CommServe.

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

### -AllProperties
Retrieves all properties for subclients.

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

### -ClientName
Get list of subclient properties for ClientName.

```yaml
Type: System.String
Parameter Sets: ByClientName
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
Parameter Sets: ByClientObject
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -Id


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
Get properties for the subclient specified by Name.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: SubclientName

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

### Get-CVSubclientProps

## RELATED LINKS

