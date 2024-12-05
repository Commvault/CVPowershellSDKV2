---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/set-cvsoftware
schema: 2.0.0
---

# Set-CVSoftware

## SYNOPSIS
Upgrade software for client and client group.

## SYNTAX

### UpgradeExpanded (Default)
```
Set-CVSoftware [-Entities <IIdNameGuidType[]>] [-InstallOSUpdates] [-InstallStorageUpdates <String>]
 [-NotifyWhenJobCompletes] [-RebootIfRequired] [-RunDbMaintenance] [-WaitForDownloadJobToComplete] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Upgrade
```
Set-CVSoftware -Body <IUpgradeSoftware> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Upgrade software for client and client group.

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
Request body for server and server group upgrade software

```yaml
Type: Commvault.Powershell.Models.IUpgradeSoftware
Parameter Sets: Upgrade
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Entities
List of all the client and client groups on which UpgradeSoftware should be run

```yaml
Type: Commvault.Powershell.Models.IIdNameGuidType[]
Parameter Sets: UpgradeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstallOSUpdates
Boolean which determines whether to install operating system updates.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpgradeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstallStorageUpdates
Enum which specifies the type of storage update

```yaml
Type: System.String
Parameter Sets: UpgradeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotifyWhenJobCompletes
Boolean which determines whether to notify when software is upgraded.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpgradeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RebootIfRequired
Boolean which determines whether to reboot if required.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpgradeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RunDbMaintenance
Boolean which determines whether or not to run a database maintenance.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpgradeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WaitForDownloadJobToComplete
Boolean which determines whether to wait for Download software job to complete before software is upgraded.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpgradeExpanded
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

### Commvault.Powershell.Models.IUpgradeSoftware

## OUTPUTS

### Commvault.Powershell.Models.IJobIdResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IUpgradeSoftware>`: Request body for server and server group upgrade software
  - `[Entities <List<IIdNameGuidType>>]`: List of all the client and client groups on which UpgradeSoftware should be run
    - `[Guid <String>]`: 
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 
    - `[Type <String>]`: 
  - `[InstallOSUpdates <Boolean?>]`: Boolean which determines whether to install operating system updates.
  - `[InstallStorageUpdates <String>]`: Enum which specifies the type of storage update
  - `[NotifyWhenJobCompletes <Boolean?>]`: Boolean which determines whether to notify when software is upgraded.
  - `[RebootIfRequired <Boolean?>]`: Boolean which determines whether to reboot if required.
  - `[RunDbMaintenance <Boolean?>]`: Boolean which determines whether or not to run a database maintenance.
  - `[WaitForDownloadJobToComplete <Boolean?>]`: Boolean which determines whether to wait for Download software job to complete before software is upgraded.

`ENTITIES <IIdNameGuidType[]>`: List of all the client and client groups on which UpgradeSoftware should be run
  - `[Guid <String>]`: 
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 
  - `[Type <String>]`: 

## RELATED LINKS

