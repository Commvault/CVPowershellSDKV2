---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-cvaccesscontrol
schema: 2.0.0
---

# Set-CVAccessControl

## SYNOPSIS
Updates owner permissions and/or automatic laptop ownership assignment

## SYNTAX

### PutExpanded (Default)
```
Set-CVAccessControl [-AutomaticLaptopOwnershipAssignmentAssignLaptopOwnerAutomatically]
 [-AutomaticLaptopOwnershipAssignmentLaptopOwnerOption <String>]
 [-AutomaticLaptopOwnershipAssignmentUserGroups <String>] [-OwnerPermissions <IIdName[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Put
```
Set-CVAccessControl -Body <IAccessControl> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Updates owner permissions and/or automatic laptop ownership assignment

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AutomaticLaptopOwnershipAssignmentAssignLaptopOwnerAutomatically
Whether the laptop ownership assignment is automatic or not

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutomaticLaptopOwnershipAssignmentLaptopOwnerOption
Options to automatically assign laptop owners

```yaml
Type: System.String
Parameter Sets: PutExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutomaticLaptopOwnershipAssignmentUserGroups
Comma seperated usergroups to add users from, when the laptopOwnerOption is 'ALL_USERS_OF_USERGROUPS'

```yaml
Type: System.String
Parameter Sets: PutExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Owner permissions and laptop ownership details
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IAccessControl
Parameter Sets: Put
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OwnerPermissions
List of owner permissions
To construct, see NOTES section for OWNERPERMISSIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: PutExpanded
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

### Commvault.Powershell.Models.IAccessControl

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IAccessControl>`: Owner permissions and laptop ownership details
  - `[AutomaticLaptopOwnershipAssignmentAssignLaptopOwnerAutomatically <Boolean?>]`: Whether the laptop ownership assignment is automatic or not
  - `[AutomaticLaptopOwnershipAssignmentLaptopOwnerOption <String>]`: Options to automatically assign laptop owners
  - `[AutomaticLaptopOwnershipAssignmentUserGroups <String>]`: Comma seperated usergroups to add users from, when the laptopOwnerOption is 'ALL_USERS_OF_USERGROUPS'
  - `[OwnerPermissions <IIdName[]>]`: List of owner permissions
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 

`OWNERPERMISSIONS <IIdName[]>`: List of owner permissions
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

