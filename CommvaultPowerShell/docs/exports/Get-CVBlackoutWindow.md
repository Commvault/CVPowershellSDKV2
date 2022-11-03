---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvblackoutwindow
schema: 2.0.0
---

# Get-CVBlackoutWindow

## SYNOPSIS
Get All Blackout Windows

## SYNTAX

### ByList (Default)
```
Get-CVBlackoutWindow [-CommcellId <String>] [-CompanyId <Int64>] [-AppTypeId <Int64>] [-BackupsetId <Int64>]
 [-ClientgroupId <Int64>] [-ClientId <Int64>] [-InstanceId <Int64>] [-SchedulePolicyId <Int64>]
 [-SubclientId <Int64>] [<CommonParameters>]
```

### ById
```
Get-CVBlackoutWindow [-CommcellId <String>] [-CompanyId <Int64>] [-AppTypeId <Int64>] [-BackupsetId <Int64>]
 [-ClientgroupId <Int64>] [-ClientId <Int64>] [-Id <Int64>] [-InstanceId <Int64>] [-SchedulePolicyId <Int64>]
 [-SubclientId <Int64>] [<CommonParameters>]
```

### ByName
```
Get-CVBlackoutWindow [-CommcellId <String>] [-CompanyId <Int64>] [-AppTypeId <Int64>] [-BackupsetId <Int64>]
 [-ClientgroupId <Int64>] [-ClientId <Int64>] [-InstanceId <Int64>] [-Name <String>]
 [-SchedulePolicyId <Int64>] [-SubclientId <Int64>] [<CommonParameters>]
```

### Get
```
Get-CVBlackoutWindow [-CommcellId <String>] [-CompanyId <Int64>] [-ServerGroupId <String>]
 [-ShowOnlyCommcellLevel] [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
Get All Blackout Windows

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

### -AppTypeId
Specify blackout window rule subset by AppTypeId.

```yaml
Type: System.Int64
Parameter Sets: ById, ByList, ByName
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -BackupsetId
Specify blackout window rule subset by BackupsetId.

```yaml
Type: System.Int64
Parameter Sets: ById, ByList, ByName
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -ClientgroupId
Specify blackout window rule subset by ClientgroupId.

```yaml
Type: System.Int64
Parameter Sets: ById, ByList, ByName
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -ClientId
Specify blackout window rule subset by ClientId.

```yaml
Type: System.Int64
Parameter Sets: ById, ByList, ByName
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -CommcellId
Shows blackout windows associated with the commcell whose id has been provided.

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

### -CompanyId
Shows blackout windows associated with the company whose id has been provided.

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Specify blackout window rule to be output by Id.

```yaml
Type: System.Int64
Parameter Sets: ById
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -InstanceId
Specify blackout window rule subset by InstanceId.

```yaml
Type: System.Int64
Parameter Sets: ById, ByList, ByName
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -Name
Specify blackout window rules to be output by Name.

```yaml
Type: System.String
Parameter Sets: ByName
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: Get
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SchedulePolicyId
Specify blackout window rule subset by SchedulePolicyId.

```yaml
Type: System.Int64
Parameter Sets: ById, ByList, ByName
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -ServerGroupId
Shows blackout windows associated with the server group whose id has been provided.

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShowOnlyCommcellLevel
Shows blackout window at commcell level if set to true.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: Get
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubclientId
Specify blackout window rule subset by SubclientId.

```yaml
Type: System.Int64
Parameter Sets: ById, ByList, ByName
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Int64

### System.String

## OUTPUTS

### Commvault.Powershell.Models.IBlackoutWindowSummary

### System.Management.Automation.PSObject

## NOTES

ALIASES

## RELATED LINKS

