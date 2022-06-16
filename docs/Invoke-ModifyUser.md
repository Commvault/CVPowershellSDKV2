---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifyuser
schema: 2.0.0
---

# Invoke-ModifyUser

## SYNOPSIS
Used to modify an existing user

## SYNTAX

### ModifyExpanded (Default)
```
Invoke-ModifyUser -UserId <Int32> [-Email <String>] [-Enabled] [-FullName <String>] [-NewName <String>]
 [-NewPassword <String>] [-PlanId <Int32>] [-PlanName <String>] [-UserGroupOperation <String>]
 [-UserGroups <IIdName[]>] [-UserPrincipalName <String>] [-ValidationPassword <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Modify
```
Invoke-ModifyUser -UserId <Int32> -Body <IUpdateUser> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentity
```
Invoke-ModifyUser -InputObject <ICommvaultPowerShellIdentity> -Body <IUpdateUser> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentityExpanded
```
Invoke-ModifyUser -InputObject <ICommvaultPowerShellIdentity> [-Email <String>] [-Enabled]
 [-FullName <String>] [-NewName <String>] [-NewPassword <String>] [-PlanId <Int32>] [-PlanName <String>]
 [-UserGroupOperation <String>] [-UserGroups <IIdName[]>] [-UserPrincipalName <String>]
 [-ValidationPassword <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Used to modify an existing user

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

### -Body
Used to update an existing user.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IUpdateUser
Parameter Sets: Modify, ModifyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Email
Change email-id for existing user.
This email-id can be used for logging-in.

```yaml
Type: System.String
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Enabled
enable or disable the user.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FullName
Change name for existing user

```yaml
Type: System.String
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICommvaultPowerShellIdentity
Parameter Sets: ModifyViaIdentity, ModifyViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NewName
Change user name for existing user.
Username can be used for logging-in as an alternate to email-id if duplicate email-ids are present.

```yaml
Type: System.String
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewPassword
Change existing password for user.
validationPassword must also be provided when changing password.
Password should be in provided in Base64 format.

```yaml
Type: System.String
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
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

### -PlanId
.

```yaml
Type: System.Int32
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserGroupOperation
Allows adding to, overwriting and deleting existing user groups.
default is adding to existing userGroups

```yaml
Type: System.String
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserGroups
Provide a list of userGroups that the user should be a part of.
Note that for external users, user groups cannot be modified.
To construct, see NOTES section for USERGROUPS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
Id of the User to update

```yaml
Type: System.Int32
Parameter Sets: Modify, ModifyExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPrincipalName
Change User Principal Name(UPN) for existing user.
This User Principal Name can be used for logging-in.

```yaml
Type: System.String
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ValidationPassword
Provide the old password in Base64 format when updating the password.
The new password has to be provided in the password tag.

```yaml
Type: System.String
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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

### Commvault.Powershell.Models.ICommvaultPowerShellIdentity

### Commvault.Powershell.Models.IUpdateUser

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IUpdateUser>: Used to update an existing user.
  - `[Email <String>]`: Change email-id for existing user. This email-id can be used for logging-in.
  - `[Enabled <Boolean?>]`: enable or disable the user.
  - `[FullName <String>]`: Change name for existing user
  - `[NewName <String>]`: Change user name for existing user. Username can be used for logging-in as an alternate to email-id if duplicate email-ids are present.
  - `[NewPassword <String>]`: Change existing password for user. validationPassword must also be provided when changing password. Password should be in provided in Base64 format.
  - `[PlanId <Int32?>]`: 
  - `[PlanName <String>]`: 
  - `[UserGroupOperation <String>]`: Allows adding to, overwriting and deleting existing user groups. default is adding to existing userGroups
  - `[UserGroups <IIdName[]>]`: Provide a list of userGroups that the user should be a part of. Note that for external users, user groups cannot be modified.
    - `[Id <Int32?>]`: 
    - `[Name <String>]`: 
  - `[UserPrincipalName <String>]`: Change User Principal Name(UPN) for existing user. This User Principal Name can be used for logging-in.
  - `[ValidationPassword <String>]`: Provide the old password in Base64 format when updating the password. The new password has to be provided in the password tag.

INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
  - `[AccessPathId <Int32?>]`: Id of the mount path whose access path has to be deleted
  - `[AgentId <Int32?>]`: Id of the agent to be modified
  - `[BackupDestinationId <Int32?>]`: Id of the backupDestination to be modified
  - `[BackupLocationId <Int32?>]`: Id of the backup location whose details have to be fetched
  - `[BlackoutWindowId <Int32?>]`: Id of the Blackout Window whose details have to be fetched
  - `[BucketId <Int32?>]`: Id of Bucket
  - `[CloudStorageId <Int32?>]`: Id of cloud Storage
  - `[CompanyId <Int32?>]`: Id of the Company whose details have to be fetched
  - `[CredentialName <String>]`: 
  - `[DomainId <Int32?>]`: ID of the AD/LDAP domain
  - `[EntityId <Int32?>]`: Unique id for the entity
  - `[EntityType <Int32?>]`: Type of the entity
  - `[GlobalSearchEntity <String>]`: name of global search entity
  - `[HfsShareId <Int32?>]`: Id of the HFS Share to fetch its status
  - `[HyperScaleStorageId <Int32?>]`: Id of hyperscale storage
  - `[HypervisorId <Int32?>]`: Id of the Hypervisor to update
  - `[Id <Int32?>]`: 
  - `[InstanceId <Int32?>]`: Id of the instance to modify
  - `[InventoryEntityName <String>]`: Name of the inventory entity that needs to be browsed like ESX Host name in VCenter
  - `[KmsId <Int32?>]`: Id of Key Management Server
  - `[MediaAgentId <Int32?>]`: Id of the Media Agent whose details have to be fetched
  - `[MetadataCacheId <Int32?>]`: Id of metadata cache
  - `[Name <String>]`: 
  - `[NodeId <Int32?>]`: Id of node
  - `[PairId <Int32?>]`: 
  - `[PlanId <Int32?>]`: Id of the plan to fetch details
  - `[RecoveryTargetId <Int32?>]`: id of recovery target
  - `[RegionId <Int32?>]`: 
  - `[RegionList <String>]`: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  - `[ReplicationGroupId <String>]`: 
  - `[RequestId <Int32?>]`: Unique identifier for the request
  - `[RoleId <Int32?>]`: Role Id
  - `[RpsId <String>]`: 
  - `[RuleId <Int32?>]`: Id of the rule to update in Plan
  - `[ScheduleId <String>]`: 
  - `[SchedulePolicyId <String>]`: 
  - `[ServerGroupId <Int32?>]`: Id of the serverGroupId whose details have to be fetched
  - `[ServerId <Int32?>]`: Id of the server to modify
  - `[StoragePoolId <Int32?>]`: Id of the disk storage pool whose details have to be fetched
  - `[SubclientId <Int32?>]`: Id of the subclient to modify
  - `[TopologyId <String>]`: 
  - `[UserGroupId <Int32?>]`: Id of the user-group whose details have to be fetched
  - `[UserId <Int32?>]`: Id of the User whose details have to be fetched
  - `[VMGroupId <Int32?>]`: Id of the VMgroup to update
  - `[VMUuid <String>]`: The vmUUID can be obtained from GET /virtualMachines UUID property

USERGROUPS <IIdName[]>: Provide a list of userGroups that the user should be a part of. Note that for external users, user groups cannot be modified.
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

