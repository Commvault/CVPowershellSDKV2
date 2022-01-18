---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-blackoutwindow
schema: 2.0.0
---

# New-BlackoutWindow

## SYNOPSIS
Create a Blackout Window

## SYNTAX

### CreateExpanded (Default)
```
New-BlackoutWindow -Name <String> [-BackupOperations <String[]>] [-BetweenDateEnd <Int64>]
 [-BetweenDateStart <Int64>] [-CompanyId <Int32>] [-CompanyName <String>] [-Days <String[]>] [-DoNotSubmitJob]
 [-Time <IStartEnd[]>] [-Weeks <String[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-BlackoutWindow -Body <ICreateBlackoutWindow> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a Blackout Window

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

### -BackupOperations
Refers to backup types to include in the blackout window

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BetweenDateEnd
the blackout window is no longer in effect from this point on.

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BetweenDateStart
the blackout window comes into effect at this point.

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
betweenDates refers to the dates where the blackout window will be in effect.
Dates have to be given in unix time format.
time has to be provided in seconds.
company refers to company to which the blackout window is associated.Id is given first preference if both are id and name are provided.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICreateBlackoutWindow
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyId
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CompanyName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Days
Days of the week when the blackout window will be in effect.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DoNotSubmitJob
Allows or Denies submitting a job when the blackout window is in effect.
If set to false, the job is submitted and resumed once the blackout window ends.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Name of the blackout window to be created.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
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

### -Time
Refers to the time between which the blackout window will be in effect.
It has to be provided in seconds
To construct, see NOTES section for TIME properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IStartEnd[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Weeks
Refers to the weeks of the month that the blackout window will be in effect.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
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

### Commvault.Powershell.Models.ICreateBlackoutWindow

## OUTPUTS

### Commvault.Powershell.Models.IIdName

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <ICreateBlackoutWindow>: betweenDates refers to the dates where the blackout window will be in effect. Dates have to be given in unix time format. time has to be provided in seconds. company refers to company to which the blackout window is associated.Id is given first preference if both are id and name are provided.
  - `Name <String>`: Name of the blackout window to be created.
  - `[BackupOperations <String[]>]`: Refers to backup types to include in the blackout window
  - `[BetweenDateEnd <Int64?>]`: the blackout window is no longer in effect from this point on.
  - `[BetweenDateStart <Int64?>]`: the blackout window comes into effect at this point.
  - `[CompanyId <Int32?>]`: 
  - `[CompanyName <String>]`: 
  - `[Days <String[]>]`: Days of the week when the blackout window will be in effect.
  - `[DoNotSubmitJob <Boolean?>]`: Allows or Denies submitting a job when the blackout window is in effect. If set to false, the job is submitted and resumed once the blackout window ends.
  - `[Time <IStartEnd[]>]`: Refers to the time between which the blackout window will be in effect. It has to be provided in seconds
    - `[End <Int64?>]`: the blackout window is no longer in effect from this point on.
    - `[Start <Int64?>]`: the blackout window comes into effect at this point.
  - `[Weeks <String[]>]`: Refers to the weeks of the month that the blackout window will be in effect.

TIME <IStartEnd[]>: Refers to the time between which the blackout window will be in effect. It has to be provided in seconds
  - `[End <Int64?>]`: the blackout window is no longer in effect from this point on.
  - `[Start <Int64?>]`: the blackout window comes into effect at this point.

## RELATED LINKS

