---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-cvuser
schema: 2.0.0
---

# New-CVUser

## SYNOPSIS
Create a User

## SYNTAX

```
New-CVUser -Users <ICreateUser[]> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a User

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
To construct, see NOTES section for USERS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICreateUser[]
Parameter Sets: (All)
Aliases:

Required: True
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

### Commvault.Powershell.Models.IIdNameGuid

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


USERS <ICreateUser[]>: .
  - `Email <String>`: Used to provide an email-id to the new user. This email-id is used for logging in the user. Please note that email ids are compulsory for company and local users and optional for external users.
  - `[CompanyId <Int64?>]`: 
  - `[CompanyName <String>]`: 
  - `[ExternalProviderId <Int64?>]`: Please provide this entity only when creating an AD user. Not needed for local and company users.
  - `[FullName <String>]`: Used to provide a name to the new user.
  - `[InviteUser <Boolean?>]`: User will receive an email to install backup software package on their device if this is set to true.
  - `[Name <String>]`: Used to provide the new user with a username. This username can be used for logging in the user instead of email-id when duplicate email-ids are present. For external user, it is necessary to provide the domain name along with the username (domainName\\username). To create a company user, the company id or name needs to be provided in the company entity.
  - `[Password <String>]`: Used to provide a password to the user being created. This will be accepted when the useSystemGeneratePassword tag is false. The password has to be provided in Base64 format.
  - `[PlanId <Int64?>]`: 
  - `[PlanName <String>]`: 
  - `[UseSystemGeneratePassword <Boolean?>]`: Choose to provide a system generated password to the user instead of providing your own password. An email will be sent to the user to reset the password. If it is set to true, password tag need not be provided. If it is set to false, password needs to be provided in the password tag in Base64 format.
  - `[UserGroups <IIdName[]>]`: Provide a list of userGroups that the user should be a part of. Either id or name or both can be provided.
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 

## RELATED LINKS

