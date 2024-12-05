---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/start-cvjoboperationonplanbackupdestination
schema: 2.0.0
---

# Start-CVJobOperationOnPlanBackupDestination

## SYNOPSIS
Run different job operations for a plan backup destination

## SYNTAX

### RunExpanded (Default)
```
Start-CVJobOperationOnPlanBackupDestination [-CommcellId <Int64>] [-CopyId <Int64>] [-JobIds <Int64[]>]
 [-LoadArchiverJobs] [-LoadDependentJobs] [-OpType <String>] [-RetainUntilTime <Int64>]
 [-StoragePolicyId <Int64>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Run
```
Start-CVJobOperationOnPlanBackupDestination -Body <IJobOperationOnCopyReq> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Run different job operations for a plan backup destination

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

### -Body
JobOperationOnCopyReq

```yaml
Type: Commvault.Powershell.Models.IJobOperationOnCopyReq
Parameter Sets: Run
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CommcellId
ID for chosen commcell

```yaml
Type: System.Int64
Parameter Sets: RunExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CopyId
ID for chosen copy

```yaml
Type: System.Int64
Parameter Sets: RunExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobIds
Comma separated Job IDs to run job operation on

```yaml
Type: System.Int64[]
Parameter Sets: RunExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LoadArchiverJobs
Defines whether archiver jobs need to be computed.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: RunExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LoadDependentJobs
Defines whether dependent jobs need to be computed.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: RunExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OpType
.

```yaml
Type: System.String
Parameter Sets: RunExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RetainUntilTime
Job will be retained till specified time.
The time is provided in unix time format.

```yaml
Type: System.Int64
Parameter Sets: RunExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StoragePolicyId
ID for chosen storage policy

```yaml
Type: System.Int64
Parameter Sets: RunExpanded
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

### Commvault.Powershell.Models.IJobOperationOnCopyReq

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

### Commvault.Powershell.Models.IJobOperationOnCopyResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IJobOperationOnCopyReq>`: JobOperationOnCopyReq
  - `CommcellId <Int64>`: ID for chosen commcell
  - `CopyId <Int64>`: ID for chosen copy
  - `JobIds <List<Int64>>`: Comma separated Job IDs to run job operation on
  - `OpType <String>`: 
  - `StoragePolicyId <Int64>`: ID for chosen storage policy
  - `[LoadArchiverJobs <Boolean?>]`: Defines whether archiver jobs need to be computed.
  - `[LoadDependentJobs <Boolean?>]`: Defines whether dependent jobs need to be computed.
  - `[RetainUntilTime <Int64?>]`: Job will be retained till specified time. The time is provided in unix time format.

## RELATED LINKS

