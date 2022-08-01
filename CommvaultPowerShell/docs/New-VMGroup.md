---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-vmgroup
schema: 2.0.0
---

# New-VMGroup

## SYNOPSIS
Create a VM Group

## SYNTAX

```
New-VMGroup -Name <String> [-ContentOverwrite] [-ContentRuleGroups <IRuleGroupContent[]>]
 [-ContentVirtualMachines <IVirtualMachinecontent[]>] [-HypervisorId <Int64>] [-HypervisorName <String>]
 [-PlanId <Int64>] [-PlanName <String>] [-StorageId <Int64>] [-StorageName <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create a VM Group

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

### -ContentOverwrite
True if content in vmgroup has to be overwritten, by default it will append the content

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

### -ContentRuleGroups
.
To construct, see NOTES section for CONTENTRULEGROUPS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IRuleGroupContent[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentVirtualMachines
.
To construct, see NOTES section for CONTENTVIRTUALMACHINES properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IVirtualMachinecontent[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HypervisorId
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

### -HypervisorName
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
subclient name

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanId
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

### -PlanName
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

### -StorageId
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

### -StorageName
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

### Commvault.Powershell.Models.ICreateVMGroupResp

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


CONTENTRULEGROUPS <IRuleGroupContent[]>: .
  - `[MatchRule <String>]`: Enum which specifies the whether to match all rules or any of the rules
  - `[Rules <IRuleContent[]>]`: 
    - `[Condition <String>]`: Operation type for VM rules/filters
    - `[DisplayName <String>]`: The display name of the entity to be added
    - `[Guid <String>]`: GUID of the entity to be added as content
    - `[Name <String>]`: name of the VM to be added as content
    - `[Type <String>]`: 
    - `[Value <String>]`: value for the few type of VM Content like powerstate

CONTENTVIRTUALMACHINES <IVirtualMachinecontent[]>: .
  - `[Guid <String>]`: GUID of the VM to be added as content
  - `[Name <String>]`: name of the VM to be added as content
  - `[Type <String>]`: 

## RELATED LINKS

