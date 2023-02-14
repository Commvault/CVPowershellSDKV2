---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvsqlinstance
schema: 2.0.0
---

# Get-CVSQLInstance

## SYNOPSIS
Method to retrieve SQL instances protected within the CommServe.

## SYNTAX

### Default (Default)
```
Get-CVSQLInstance [-AllProperties] [-OnlySLA] [-SortColumn <CVSQLInstanceSortColumn>] [-SortDescending]
 [-First <UInt64>] [-IncludeTotalCount] [-Skip <UInt64>] [<CommonParameters>]
```

### ByName
```
Get-CVSQLInstance [-AllProperties] [-ClientName <String>] [-Name <String>] [-OnlySLA]
 [-SortColumn <CVSQLInstanceSortColumn>] [-SortDescending] [-First <UInt64>] [-IncludeTotalCount]
 [-Skip <UInt64>] [<CommonParameters>]
```

### ByObject
```
Get-CVSQLInstance [-AllProperties] [-ClientObject <Object>] [-OnlySLA] [-SortColumn <CVSQLInstanceSortColumn>]
 [-SortDescending] [-First <UInt64>] [-IncludeTotalCount] [-Skip <UInt64>] [<CommonParameters>]
```

## DESCRIPTION
This method is implemented with Powershell paging support.
If the Name parameter is not provided, this method will output all protected SQL instances.
If the Name parameter is provided, SQL instances matching the name will be output.

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

### -AllProperties
Get SQL instances with all properties.

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
Get SQL instances associated with ClientName.

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
Get SQL instances associated with piped ClientObject.

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
Get SQL instance specified by Name.

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

### -OnlySLA
Get only SQL instances with missed SLAs.

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

### -SortColumn
Sort SQL instances by: insId, insName, version, cName, noDBs, or planName.

```yaml
Type: CVSQLInstanceSortColumn
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SortDescending
Sort SQL instances by specified column in descending order; default is ascending order.

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

### -First
Gets only the first 'n' objects.

```yaml
Type: System.UInt64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncludeTotalCount
Reports the number of objects in the data set (an integer) followed by the objects.
If the cmdlet cannot determine the total count, it returns "Unknown total count".

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

### -Skip
Ignores the first 'n' objects and then gets the remaining objects.

```yaml
Type: System.UInt64
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

