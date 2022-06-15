---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifyusergroup
schema: 2.0.0
---

# Invoke-ModifyUserGroup

## SYNOPSIS
Modify the properties of an existing user-group

## SYNTAX

### ModifyExpanded (Default)
```
Invoke-ModifyUserGroup -UserGroupId <Int32> [-AllowMultipleCompanyMembers]
 [-AssociatedExternalGroups <IIdName[]>] [-AssociatedLocalGroups <IIdName[]>] [-ConsoleType <String[]>]
 [-ConsoleTypeOperationType <String>] [-Enabled] [-EnableTwoFactorAuthentication <String>] [-EnforceFsQuota]
 [-ExternalUserGroupsOperationType <String>] [-LaptopAdmins] [-LaptopPlanId <Int32>]
 [-LaptopPlanName <String>] [-LocalUserGroupsOperationType <String>] [-NewDescription <String>]
 [-NewName <String>] [-PlanOperationType <String>] [-QuotaLimitInGb <Int32>] [-UserOperationType <String>]
 [-Users <IIdName[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Modify
```
Invoke-ModifyUserGroup -UserGroupId <Int32> -Body <IUpdateUserGroup> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ModifyViaIdentity
```
Invoke-ModifyUserGroup -InputObject <ICommvaultPowerShellIdentity> -Body <IUpdateUserGroup> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentityExpanded
```
Invoke-ModifyUserGroup -InputObject <ICommvaultPowerShellIdentity> [-AllowMultipleCompanyMembers]
 [-AssociatedExternalGroups <IIdName[]>] [-AssociatedLocalGroups <IIdName[]>] [-ConsoleType <String[]>]
 [-ConsoleTypeOperationType <String>] [-Enabled] [-EnableTwoFactorAuthentication <String>] [-EnforceFsQuota]
 [-ExternalUserGroupsOperationType <String>] [-LaptopAdmins] [-LaptopPlanId <Int32>]
 [-LaptopPlanName <String>] [-LocalUserGroupsOperationType <String>] [-NewDescription <String>]
 [-NewName <String>] [-PlanOperationType <String>] [-QuotaLimitInGb <Int32>] [-UserOperationType <String>]
 [-Users <IIdName[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Modify the properties of an existing user-group

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

### -AllowMultipleCompanyMembers
This property can be used to allow addition of users/groups from child companies.
Only applicable for commcell and reseller company group.

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

### -AssociatedExternalGroups
.
To construct, see NOTES section for ASSOCIATEDEXTERNALGROUPS properties and create a hash table.

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

### -AssociatedLocalGroups
.
To construct, see NOTES section for ASSOCIATEDLOCALGROUPS properties and create a hash table.

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

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IUpdateUserGroup
Parameter Sets: Modify, ModifyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConsoleType
.

```yaml
Type: System.String[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConsoleTypeOperationType
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

### -Enabled
allows the enabling/disabling of the user group.

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

### -EnableTwoFactorAuthentication
Allows two-factor authentication to be enabled for the specific types of usergroups.
it can be turned on or off based on user preferences.
There will be usergroups that will not have this option.

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

### -EnforceFsQuota
determines if a data limit will be set for the user group.

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

### -ExternalUserGroupsOperationType
Allows adding, deleting or overwriting associated external user groups of a user group.
Default is adding associated external user groups

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

### -LaptopAdmins
When set to true, users in this group cannot activate or be set as server owner

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

### -LaptopPlanId
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

### -LaptopPlanName
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

### -LocalUserGroupsOperationType
Allows adding, deleting or overwriting associated local user groups of a user group.
Default is adding associated local user groups

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

### -NewDescription
gives a new description to the user group.

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

### -NewName
gives a new name to the user group.

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

### -PlanOperationType
determines if an existing user has to be added to the user group or removed from the user group

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

### -QuotaLimitInGb
if enforceFSquota is enabled, the quota limit can be provided in GBs

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

### -UserGroupId
Id of the user-group to update

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

### -UserOperationType
determines if an existing user has to be added to the user group or removed from the user group

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

### -Users
.
To construct, see NOTES section for USERS properties and create a hash table.

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

### Commvault.Powershell.Models.IUpdateUserGroup

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSOCIATEDEXTERNALGROUPS <IIdName[]>: .
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

ASSOCIATEDLOCALGROUPS <IIdName[]>: .
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

BODY <IUpdateUserGroup>: .
  - `[AllowMultipleCompanyMembers <Boolean?>]`: This property can be used to allow addition of users/groups from child companies. Only applicable for commcell and reseller company group.
  - `[AssociatedExternalGroups <IIdName[]>]`: 
    - `[Id <Int32?>]`: 
    - `[Name <String>]`: 
  - `[AssociatedLocalGroups <IIdName[]>]`: 
  - `[ConsoleType <String[]>]`: 
  - `[ConsoleTypeOperationType <String>]`: 
  - `[EnableTwoFactorAuthentication <String>]`: Allows two-factor authentication to be enabled for the specific types of usergroups. it can be turned on or off based on user preferences. There will be usergroups that will not have this option.
  - `[Enabled <Boolean?>]`: allows the enabling/disabling of the user group.
  - `[EnforceFsQuota <Boolean?>]`: determines if a data limit will be set for the user group.
  - `[ExternalUserGroupsOperationType <String>]`: Allows adding, deleting or overwriting associated external user groups of a user group. Default is adding associated external user groups
  - `[LaptopAdmins <Boolean?>]`: When set to true, users in this group cannot activate or be set as server owner
  - `[LaptopPlanId <Int32?>]`: 
  - `[LaptopPlanName <String>]`: 
  - `[LocalUserGroupsOperationType <String>]`: Allows adding, deleting or overwriting associated local user groups of a user group. Default is adding associated local user groups
  - `[NewDescription <String>]`: gives a new description to the user group.
  - `[NewName <String>]`: gives a new name to the user group.
  - `[PlanOperationType <String>]`: determines if an existing user has to be added to the user group or removed from the user group
  - `[QuotaLimitInGb <Int32?>]`: if enforceFSquota is enabled, the quota limit can be provided in GBs
  - `[UserOperationType <String>]`: determines if an existing user has to be added to the user group or removed from the user group
  - `[Users <IIdName[]>]`: 

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

USERS <IIdName[]>: .
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

