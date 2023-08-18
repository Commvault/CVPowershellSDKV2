---
external help file:
Module Name: CommvaultPowershell
online version: https://documentation.commvault.com/11.24/essential/48824_rest_api_post_schedule_policy_add_entity.html
schema: 2.0.0
---

# Add-CVEntitytoSchedulePolicy

## SYNOPSIS
Method to add an entity to a schedule policy

## SYNTAX

### Default (Default)
```
Add-CVEntitytoSchedulePolicy -Body <PSObject> [-Force] [<CommonParameters>]
```

### ById
```
Add-CVEntitytoSchedulePolicy -Body <PSObject> -taskId <Int64> [-Force] [<CommonParameters>]
```

### ByObject
```
Add-CVEntitytoSchedulePolicy -Body <PSObject> -taskObject <Object> [-Force] [<CommonParameters>]
```

## DESCRIPTION
Method to add an entity to a schedule policy

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

### -Body


```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: RequestBody

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Force


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

### -taskId
Schedule policy ID

```yaml
Type: System.Int64
Parameter Sets: ById
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -taskObject


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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Object

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

ALIASES

## RELATED LINKS

