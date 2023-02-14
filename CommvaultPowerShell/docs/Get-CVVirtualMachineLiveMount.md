---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvvirtualmachinelivemount
schema: 2.0.0
---

# Get-CVVirtualMachineLiveMount

## SYNOPSIS
Method to retrieve list of active mounts for specified source virtual machine.

## SYNTAX

### ByName (Default)
```
Get-CVVirtualMachineLiveMount -ClientName <String> -Name <String> [-SubclientName <String>]
 [<CommonParameters>]
```

### ById
```
Get-CVVirtualMachineLiveMount -Id <String> [-SubclientName <String>] [<CommonParameters>]
```

### ByObject
```
Get-CVVirtualMachineLiveMount -ClientObject <Object> [-SubclientName <String>] [<CommonParameters>]
```

## DESCRIPTION
Method to retrieve list of active mounts for specified source virtual machine.

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

### -ClientName
Source virtual machine associated ClientName.

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

### -Id
Specify Id representing source virtual machine GUID.

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
Source virtual machine Name.

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

### -SubclientName
Specify SubclientName to override the default behavior.

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

