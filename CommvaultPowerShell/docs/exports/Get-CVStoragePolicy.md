---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvstoragepolicy
schema: 2.0.0
---

# Get-CVStoragePolicy

## SYNOPSIS
Method to retrieve storage policies from the CommServe.

## SYNTAX

### Default (Default)
```
Get-CVStoragePolicy [-AllProperties] [-Name <String>] [<CommonParameters>]
```

### ByName
```
Get-CVStoragePolicy [-AllProperties] [-MediaAgentName <String>] [-Name <String>] [<CommonParameters>]
```

### ByObject
```
Get-CVStoragePolicy [-AllProperties] [-MediaAgentObject <Object>] [-Name <String>] [<CommonParameters>]
```

## DESCRIPTION
Method to retrieve storage policies from the CommServe.
Output can be filtered by media agent and policy Name.
Note: detail information is

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

### -AllProperties
Output AllProperties for each schedule policy.

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

### -MediaAgentName
Specify storage policy instances to be output by MediaAgentName.

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

### -MediaAgentObject
Specify storage policy instances to be output pipeline input of MediaAgentObject.

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

### -Name
Specify storage policy instances to be output by Name.

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

