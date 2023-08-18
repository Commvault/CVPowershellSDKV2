---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/disable-cvschedulepolicy
schema: 2.0.0
---

# Disable-CVSchedulePolicy

## SYNOPSIS
Method to disable a schedule policy on the CommServe.

## SYNTAX

### ByPolicyName (Default)
```
Disable-CVSchedulePolicy -Name <String> [<CommonParameters>]
```

### ByPolicyId
```
Disable-CVSchedulePolicy -Id <Int32> [<CommonParameters>]
```

### ByPolicyObject
```
Disable-CVSchedulePolicy -PolicyObject <Object> [<CommonParameters>]
```

### BySubclient
```
Disable-CVSchedulePolicy -ClientName <String> -SubclientName <String> [<CommonParameters>]
```

## DESCRIPTION
Method to disable a schedule policy on the CommServe.

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
Specify the schedule policy to be disabled by Id (taskId).

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
Specify the schedule policy to be disabled by Name.

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
Specify the schedule policy to be disabled by piping the PolicyObject.

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

ALIASES

## RELATED LINKS

