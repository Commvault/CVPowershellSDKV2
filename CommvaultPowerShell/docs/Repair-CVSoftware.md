---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/repair-cvsoftware
schema: 2.0.0
---

# Repair-CVSoftware

## SYNOPSIS
Repair software for client and clients for the given client group(s).

## SYNTAX

### RepairExpanded (Default)
```
Repair-CVSoftware [-Entities <IIdNameGuidType[]>] [-InvokedFrom <String>] [-NotifyWhenJobCompletes]
 [-Password <String>] [-RebootIfRequired] [-Username <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Repair
```
Repair-CVSoftware -Body <IRepairSoftware> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Repair software for client and clients for the given client group(s).

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
Request body for server and server group repair software

```yaml
Type: Commvault.Powershell.Models.IRepairSoftware
Parameter Sets: Repair
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Entities
List of all the client and client groups on which repair software should be run

```yaml
Type: Commvault.Powershell.Models.IIdNameGuidType[]
Parameter Sets: RepairExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InvokedFrom
invokedFrom

```yaml
Type: System.String
Parameter Sets: RepairExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotifyWhenJobCompletes
Boolean which determines whether to notify when software is repaired.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: RepairExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Password
Corresponding password of the user

```yaml
Type: System.String
Parameter Sets: RepairExpanded
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
Parameter Sets: RepairExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Username
If using system credentials, provide the user name

```yaml
Type: System.String
Parameter Sets: RepairExpanded
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

### Commvault.Powershell.Models.IRepairSoftware

## OUTPUTS

### Commvault.Powershell.Models.IJobIdResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IRepairSoftware>`: Request body for server and server group repair software
  - `Entities <List<IIdNameGuidType>>`: List of all the client and client groups on which repair software should be run
    - `[Guid <String>]`: 
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 
    - `[Type <String>]`: 
  - `InvokedFrom <String>`: invokedFrom
  - `[NotifyWhenJobCompletes <Boolean?>]`: Boolean which determines whether to notify when software is repaired.
  - `[Password <String>]`: Corresponding password of the user
  - `[RebootIfRequired <Boolean?>]`: Boolean which determines whether to reboot if required.
  - `[Username <String>]`: If using system credentials, provide the user name

`ENTITIES <IIdNameGuidType[]>`: List of all the client and client groups on which repair software should be run
  - `[Guid <String>]`: 
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 
  - `[Type <String>]`: 

## RELATED LINKS

