---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/new-cvrecoverygroup
schema: 2.0.0
---

# New-CVRecoveryGroup

## SYNOPSIS
Create Recovery group

## SYNTAX

```
New-CVRecoveryGroup [-Action <String>] [-ContinueOnFailure] [-DelayBetweenPriorityMachines <Int64>]
 [-Id <Int64>] [-Name <String>] [-PostRecoveryActions <IDrOperationScript[]>]
 [-RecoveryExpirationOptionDaysToExpire <Int64>] [-RecoveryExpirationOptionEnableExpirationOption]
 [-RecoveryExpirationOptionExpirationTime <Int64>] [-RecoveryExpirationOptionIsRescuedCommServe]
 [-RecoveryPoint <Int64>] [-RecoveryPointDetailRecoveryPoint <Int64>]
 [-RecoveryPointDetailRecoveryPointCategory <String>] [-TargetId <Int64>] [-TargetName <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create Recovery group

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

### -Action
Recovery Action

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

### -ContinueOnFailure
Set to true to continue to the next priority machines on failure

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

### -DelayBetweenPriorityMachines
The delay between machines in different priorities in minutes

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
Id of the recovery group

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

### -Name
Name of the recovery group

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

### -PostRecoveryActions
.

```yaml
Type: Commvault.Powershell.Models.IDrOperationScript[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryExpirationOptionDaysToExpire
Number of days after which recovered VMs are automatically cleaned up

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

### -RecoveryExpirationOptionEnableExpirationOption
If true, cleans up recovered VMs after the set daysToExpire value

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

### -RecoveryExpirationOptionExpirationTime
Timestamp when the clean up of all recovered VMs happens on the rescued CommServe.
It happens 4 hours before the CommServe expiration time

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

### -RecoveryExpirationOptionIsRescuedCommServe
Whether the CommServe is rescued or not

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

### -RecoveryPoint
Timestamp for group restore in case of disaster, default value is 0 as latest recovery point

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

### -RecoveryPointDetailRecoveryPoint
Timestamp for group restore in case of disaster, default value is 0 as latest recovery point

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

### -RecoveryPointDetailRecoveryPointCategory
Type of recovery point category that can be selected.
Default is Latest

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

### -TargetId
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

### -TargetName
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

### Commvault.Powershell.Models.ICreateRecoveryGroupResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`POSTRECOVERYACTIONS <IDrOperationScript[]>`: .
  - `[GuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[GuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[GuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[GuestCredentialsSavedCredentialsName <String>]`: 
  - `[Guid <String>]`: Unique script identifier string
  - `[OSType <String>]`: OS types
  - `[Path <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[Reset <Boolean?>]`: On set to true, resets the script to empty
  - `[ScriptContent <String>]`: Content of the script to be executed
  - `[ScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[ScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[ScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[ScriptCredentialsSavedCredentialsName <String>]`: 
  - `[ScriptName <String>]`: Name of the script
  - `[Type <String>]`: The type of path being used for DR operation script

## RELATED LINKS

