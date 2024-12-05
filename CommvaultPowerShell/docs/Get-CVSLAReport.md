---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/get-cvslareport
schema: 2.0.0
---

# Get-CVSLAReport

## SYNOPSIS
Gets SLA report for specific client or entire CommCell.

## SYNTAX

### Default (Default)
```
Get-CVSLAReport [-AllProperties] [-Category <Int32>] [-EmailAddr <String>] [-Status <Int32>] [-Type <Int32>]
 [<CommonParameters>]
```

### ById
```
Get-CVSLAReport [-AllProperties] [-Category <Int32>] [-ClientId <Int32>] [-EmailAddr <String>]
 [-Status <Int32>] [-Type <Int32>] [<CommonParameters>]
```

### ByName
```
Get-CVSLAReport [-AllProperties] [-Category <Int32>] [-ClientName <String>] [-EmailAddr <String>]
 [-Status <Int32>] [-Type <Int32>] [<CommonParameters>]
```

### ByObject
```
Get-CVSLAReport [-AllProperties] [-Category <Int32>] [-ClientObject <Object>] [-EmailAddr <String>]
 [-Status <Int32>] [-Type <Int32>] [<CommonParameters>]
```

## DESCRIPTION
Gets SLA report for specific client or entire CommCell.

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

### -AllProperties
Use this switch for extended detail.

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

### -Category
Any = 0 (default), Protected = 1, Failed = 2, NoJobFound = 3, NoSchedule = 4.

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

### -ClientId
Filter SLA report by ClientId.

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
Filter SLA report by ClientName.

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
Filter SLA report by piped ClientObject.

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

### -EmailAddr
EmailAddr for notification purpose.

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

### -Status
Any = 0 (default), Protected = 1, Unprotected = 2, Excluded = 3.

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

### -Type
Client = 1 (default), Agent = 2.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Object

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

ALIASES

Get-CVSLA

## RELATED LINKS

