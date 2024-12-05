---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/get-cvschedulepolicy
schema: 2.0.0
---

# Get-CVSchedulePolicy

## SYNOPSIS
Method to retrieve schedule policies from the CommServe.

## SYNTAX

### Default (Default)
```
Get-CVSchedulePolicy [-ScheduleType <CVSchedulePolicyType>] [<CommonParameters>]
```

### ById
```
Get-CVSchedulePolicy [-Id <Int32>] [-ScheduleType <CVSchedulePolicyType>] [<CommonParameters>]
```

### ByName
```
Get-CVSchedulePolicy [-Name <String>] [-ScheduleType <CVSchedulePolicyType>] [<CommonParameters>]
```

### BySubclient
```
Get-CVSchedulePolicy -ClientName <String> -SubclientName <String> [-ScheduleType <CVSchedulePolicyType>]
 [<CommonParameters>]
```

## DESCRIPTION
Method to retrieve schedule policies from the CommServe.
Output can be filtered by client/subclient or by policy name or id.

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
Filter output by ClientName associated with SubclientName.

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
Filter output by policy Id.

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

### -Name
Filter output by policy Name.

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

### -ScheduleType
Filter by ScheduleType: All (default), DataProtection, AuxiliaryCopy, BackupCopy, OfflineContentIndexing, DDBVerification, ContentIndexing, or Workflow.

```yaml
Type: CVSchedulePolicyType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubclientName
Filter output by SubclientName.

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

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

## RELATED LINKS

