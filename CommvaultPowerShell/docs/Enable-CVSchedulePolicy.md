---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/enable-cvschedulepolicy
schema: 2.0.0
---

# Enable-CVSchedulePolicy

## SYNOPSIS
Method to enable a schedule policy on the CommServe.

## SYNTAX

### ByPolicyName (Default)
```
Enable-CVSchedulePolicy -Name <String> [<CommonParameters>]
```

### ByPolicyId
```
Enable-CVSchedulePolicy -Id <Int32> [<CommonParameters>]
```

### ByPolicyObject
```
Enable-CVSchedulePolicy -PolicyObject <Object> [<CommonParameters>]
```

### BySubclient
```
Enable-CVSchedulePolicy -ClientName <String> -SubclientName <String> [<CommonParameters>]
```

## DESCRIPTION
Method to enable a schedule policy on the CommServe.

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

### -ClientName
Specify the ClientName associated with SubclientName.

```yaml
Type: System.String
Parameter Sets: BySubclient
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Specify the schedule policy to be enabled by Id (taskId).

```yaml
Type: System.Int32
Parameter Sets: ByPolicyId
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Specify the schedule policy to be enabled by Name.

```yaml
Type: System.String
Parameter Sets: ByPolicyName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyObject
Specify the schedule policy to be enabled by piping the PolicyObject.

```yaml
Type: System.Object
Parameter Sets: ByPolicyObject
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -SubclientName
Specify the SubclientName.

```yaml
Type: System.String
Parameter Sets: BySubclient
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

## RELATED LINKS

