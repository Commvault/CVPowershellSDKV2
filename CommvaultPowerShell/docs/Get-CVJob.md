---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/get-cvjob
schema: 2.0.0
---

# Get-CVJob

## SYNOPSIS
Get list of jobs from the CommServe.

## SYNTAX

### Default (Default)
```
Get-CVJob [-ClientName <String>] [-CompletedTime <Int32>] [-Details] [-First <UInt64>] [-JobCategory <String>]
 [-JobFilter <String>] [-limit <Int32>] [-Skip <UInt64>] [-SubclientName <String>] [<CommonParameters>]
```

### ById
```
Get-CVJob [-Details] [-First <UInt64>] [-Id <Int32>] [-Skip <UInt64>] [<CommonParameters>]
```

## DESCRIPTION
Get the list of all jobs.
Based on parameters this commandlet filters the output.
This method is implemented with Powershell paging support.

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
Filter output based on ClientName.

```yaml
Type: System.String
Parameter Sets: Default
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CompletedTime
Filter output based on completed job lookup time expressed in hours.

```yaml
Type: System.Int32
Parameter Sets: Default
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Details
Retrieves the details for a job.

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

### -Id


```yaml
Type: System.Int32
Parameter Sets: ById
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -JobCategory
Filter output based on JobCategory.
Example Active, Finished, All.

```yaml
Type: System.String
Parameter Sets: Default
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobFilter
Filter output based on JobFilter.
Example Snapbackup, DATA_VERIFICATION or SYNTHFULL etc.

```yaml
Type: System.String
Parameter Sets: Default
Aliases: Filter

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -limit
The number of results to be listed in a page.
Used for changing the paging limits.
By default, the limit is 100 results per page.

```yaml
Type: System.Int32
Parameter Sets: Default
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

### -SubclientName
Filter output based on SubclientName: requires ClientName parameter.

```yaml
Type: System.String
Parameter Sets: Default
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

### System.Int32

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

## RELATED LINKS

