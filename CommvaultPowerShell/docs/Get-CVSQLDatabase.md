---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvsqldatabase
schema: 2.0.0
---

# Get-CVSQLDatabase

## SYNOPSIS
Method to retrieve SQL databases protected within the CommServe.

## SYNTAX

### Default (Default)
```
Get-CVSQLDatabase [-AllProperties] [-OnlySLA] [-ShowSysDB] [-SortColumn <CVSQLDatabaseSortColumn>]
 [-SortDescending] [-First <UInt64>] [-IncludeTotalCount] [-Skip <UInt64>] [<CommonParameters>]
```

### ById
```
Get-CVSQLDatabase [-AllProperties] [-Id <Int32>] [-InstanceId <Int32>] [-OnlySLA] [-ShowSysDB]
 [-SortColumn <CVSQLDatabaseSortColumn>] [-SortDescending] [-First <UInt64>] [-IncludeTotalCount]
 [-Skip <UInt64>] [<CommonParameters>]
```

### ByName
```
Get-CVSQLDatabase [-AllProperties] [-ClientName <String>] [-InstanceName <String>] [-Name <String>] [-OnlySLA]
 [-ShowSysDB] [-SortColumn <CVSQLDatabaseSortColumn>] [-SortDescending] [-First <UInt64>] [-IncludeTotalCount]
 [-Skip <UInt64>] [<CommonParameters>]
```

### ByObject
```
Get-CVSQLDatabase [-AllProperties] [-InstanceObject <Object>] [-OnlySLA] [-ShowSysDB]
 [-SortColumn <CVSQLDatabaseSortColumn>] [-SortDescending] [-First <UInt64>] [-IncludeTotalCount]
 [-Skip <UInt64>] [<CommonParameters>]
```

## DESCRIPTION
This method is implemented with Powershell paging support.
If the Name parameter is not provided, this method will output all protected SQL databases.
If the Name parameter is provided, SQL databases matching the name will be output.

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
Get SQL databases with all properties.

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
Get SQL databases associated with ClientName.

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

### -Id
Get SQL database specified by database Id.

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

### -InstanceId
Get SQL databases associated with InstanceId.

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

### -InstanceName
Get SQL databases associated with InstanceName.

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

### -InstanceObject
Get SQL databases associated with piped InstanceObject.

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
Get SQL database specified by Name.

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
Get only SQL databases with missed SLAs.

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

### -ShowSysDB
Get SQL databases including system databases.

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
Sort SQL databases by: bkpTime, bkpSize, insName, dbName, cName, planName.

```yaml
Type: CVSQLDatabaseSortColumn
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SortDescending
Sort SQL databases by specified column in descending order; Default is ascending order.

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

