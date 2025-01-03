---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/remove-cvmultipleuser
schema: 2.0.0
---

# Remove-CVMultipleUser

## SYNOPSIS
Delete multiple users

## SYNTAX

### DeleteExpanded (Default)
```
Remove-CVMultipleUser [-Users <IDeleteUsers[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Delete
```
Remove-CVMultipleUser -Body <IDeleteMultipleUsers> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Delete multiple users

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
Used to delete multiple users and carry out property transfership of deleted users

```yaml
Type: Commvault.Powershell.Models.IDeleteMultipleUsers
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

### -Users
.

```yaml
Type: Commvault.Powershell.Models.IDeleteUsers[]
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

### Commvault.Powershell.Models.IDeleteMultipleUsers

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IDeleteMultipleUsers>`: Used to delete multiple users and carry out property transfership of deleted users
  - `[Users <List<IDeleteUsers>>]`: 
    - `[NewUserGroupId <Int64?>]`: 
    - `[NewUserGroupName <String>]`: 
    - `[NewUserId <Int64?>]`: 
    - `[NewUserName <String>]`: 
    - `[SkipOwnerTransfer <Boolean?>]`: 
    - `[UserId <Int64?>]`: 
    - `[UserName <String>]`: 

`USERS <IDeleteUsers[]>`: .
  - `[NewUserGroupId <Int64?>]`: 
  - `[NewUserGroupName <String>]`: 
  - `[NewUserId <Int64?>]`: 
  - `[NewUserName <String>]`: 
  - `[SkipOwnerTransfer <Boolean?>]`: 
  - `[UserId <Int64?>]`: 
  - `[UserName <String>]`: 

## RELATED LINKS

