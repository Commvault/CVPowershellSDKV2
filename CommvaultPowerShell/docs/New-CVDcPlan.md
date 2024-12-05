---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/new-cvdcplan
schema: 2.0.0
---

# New-CVDcPlan

## SYNOPSIS
Create a Data Classification Plan

## SYNTAX

```
New-CVDcPlan [-Application <String>] [-ContentAnalyzer <IIdName[]>]
 [-ContentIndexingBackupCopy <IDcBackupCopy[]>] [-ContentIndexingContentLanguage <String>]
 [-ContentIndexingCopyPrecedence <Int64>] [-ContentIndexingExactSearch] [-ContentIndexingExtractTextFromImage]
 [-ContentIndexingSearchType <String>] [-EntityDetectionClassifiers <IIdName[]>]
 [-EntityDetectionCopyPrecendence <Int64>] [-EntityDetectionEntities <IIdName[]>]
 [-FileFilterExcludePaths <String[]>] [-FileFilterIncludeDocTypes <String>] [-FileFilterMaxDocSize <Int64>]
 [-FileFilterMinDocSize <Int64>] [-IndexServerId <Int64>] [-IndexServerName <String>] [-Name <String>]
 [-PatternDayOfMonth <Int64>] [-PatternDayOfWeek <String>] [-PatternExceptions <IScheduleRunException[]>]
 [-PatternFrequency <Int64>] [-PatternMonthOfYear <String>] [-PatternScheduleFrequencyType <String>]
 [-PatternStartDate <Int64>] [-PatternStartTime <Int64>] [-PatternWeeklyDays <String[]>]
 [-PatternWeekOfMonth <String>] [-ScheduleName <String>] [-ThreatAnalysis] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create a Data Classification Plan

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

### -Application
Content indexing target app

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

### -ContentAnalyzer
Content Analyzer Id`s for Entity Detection

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentIndexingBackupCopy
.

```yaml
Type: Commvault.Powershell.Models.IDcBackupCopy[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentIndexingContentLanguage
OCR Languages Supported By DC Plan

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

### -ContentIndexingCopyPrecedence
Set Content Indexing Copy Precedence

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

### -ContentIndexingExactSearch
Enable Exact Seach in Data Classification Plan

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

### -ContentIndexingExtractTextFromImage
Enable OCR in Data Classification Plan

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

### -ContentIndexingSearchType
Describes the Content Indexing Operation Type for Data Classification Plan

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

### -EntityDetectionClassifiers
Classifier TagId For Extraction

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EntityDetectionCopyPrecendence
.

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

### -EntityDetectionEntities
Entity TagId for Extraction

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileFilterExcludePaths
.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileFilterIncludeDocTypes
.

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

### -FileFilterMaxDocSize
.

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

### -FileFilterMinDocSize
.

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

### -IndexServerId
.

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

### -IndexServerName
.

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

### -Name
Name of Data Classification Plan

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

### -PassThru
Returns true when the command succeeds

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

### -PatternDayOfMonth
Day on which to run the schedule, applicable for monthly, yearly

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

### -PatternDayOfWeek
.

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

### -PatternExceptions
Exceptions to when a schedule should not run, either in dates or week of month and day

```yaml
Type: Commvault.Powershell.Models.IScheduleRunException[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PatternFrequency
Frequency of the schedule based on schedule frequency type eg.
for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days.
for Monthly 2 is it repeats every 2 months

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

### -PatternMonthOfYear
.

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

### -PatternScheduleFrequencyType
schedule frequency type

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

### -PatternStartDate
start date of schedule in epoch format

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

### -PatternStartTime
start time of schedule in seconds for daily, weekly, monthly, yearly frequency

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

### -PatternWeeklyDays
Days of the week for weekly frequency

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PatternWeekOfMonth
Specific week of a month

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

### -ScheduleName
.

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

### -ThreatAnalysis
Enables\Disables Threat Analysis support for DC Plan

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

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

### Commvault.Powershell.Models.IPlanResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`CONTENTANALYZER <IIdName[]>`: Content Analyzer Id`s for Entity Detection
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`CONTENTINDEXINGBACKUPCOPY <IDcBackupCopy[]>`: .
  - `[CopyId <Int64?>]`: 
  - `[StoragePoolId <Int64?>]`: 

`ENTITYDETECTIONCLASSIFIERS <IIdName[]>`: Classifier TagId For Extraction
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`ENTITYDETECTIONENTITIES <IIdName[]>`: Entity TagId for Extraction
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`PATTERNEXCEPTIONS <IScheduleRunException[]>`: Exceptions to when a schedule should not run, either in dates or week of month and day
  - `[OnDates <List<Int64>>]`: list of dates in a month. For ex: 1, 20
  - `[OnDayOfTheWeek <List<String>>]`: On which days, for ex: MONDAY, FRIDAY
  - `[OnWeekOfTheMonth <List<String>>]`: On which week of month, for ex: FIRST, LAST

## RELATED LINKS

