---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/remove-cvmultipleusergroup
schema: 2.0.0
---

# Remove-CVMultipleUserGroup

## SYNOPSIS
Delete multiple userGroups

## SYNTAX

### DeleteExpanded (Default)
```
Remove-CVMultipleUserGroup [-UserGroups <IDeleteUserGroups[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Delete
```
Remove-CVMultipleUserGroup -Body <IDeleteMultipleUserGroups> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Delete multiple userGroups

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IDeleteMultipleUserGroups
Parameter Sets: Delete
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -UserGroups
List of userGroups that have to be deleted.
Either name or id can be provided.
If name and id are both provided, id will be taken into consideration.
To construct, see NOTES section for USERGROUPS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IDeleteUserGroups[]
Parameter Sets: DeleteExpanded
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

### Commvault.Powershell.Models.IDeleteMultipleUserGroups

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IDeleteMultipleUserGroups>: .
  - `[UserGroups <IDeleteUserGroups[]>]`: List of userGroups that have to be deleted. Either name or id can be provided. If name and id are both provided, id will be taken into consideration.
    - `[NewUserGroupId <Int64?>]`: 
    - `[NewUserGroupName <String>]`: 
    - `[NewUserId <Int64?>]`: 
    - `[NewUserName <String>]`: 
    - `[SkipOwnerTransfer <Boolean?>]`: 
    - `[UserGroupId <Int64?>]`: 
    - `[UserGroupName <String>]`: 

USERGROUPS <IDeleteUserGroups[]>: List of userGroups that have to be deleted. Either name or id can be provided. If name and id are both provided, id will be taken into consideration.
  - `[NewUserGroupId <Int64?>]`: 
  - `[NewUserGroupName <String>]`: 
  - `[NewUserId <Int64?>]`: 
  - `[NewUserName <String>]`: 
  - `[SkipOwnerTransfer <Boolean?>]`: 
  - `[UserGroupId <Int64?>]`: 
  - `[UserGroupName <String>]`: 

## RELATED LINKS

