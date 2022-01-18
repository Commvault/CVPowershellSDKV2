---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifycompany
schema: 2.0.0
---

# Invoke-ModifyCompany

## SYNOPSIS
Modify the properties of an existing company

## SYNTAX

### ModifyExpanded (Default)
```
Invoke-ModifyCompany -CompanyId <Int32> [-DefaultPlans <IDefaultPlan[]>] [-EmailSettingSenderEmail <String>]
 [-EmailSettingSenderName <String>] [-FileExceptionUnix <String>] [-FileExceptionUseCompanyGlobalFilter]
 [-FileExceptionWindows <String>] [-GeneralAssignLaptopOwners <String>] [-GeneralAuthcodeForInstallation]
 [-GeneralAutoDiscoverApp] [-GeneralEmailSuffix <String>] [-GeneralEnableDataEncryption]
 [-GeneralInfrastructureType <String>] [-GeneralNewAlias <String>] [-GeneralResellerMode]
 [-GeneralServiceCommcells <IIdName[]>] [-GeneralSupportedSolutions <String[]>] [-GeneralUpnInsteadOfEmail]
 [-NewName <String>] [-OptionDisableBackup] [-OptionDisableLogin] [-OptionDisableRestore] [-Plans <IIdName[]>]
 [-Security <IUpdateSecurityAssoc[]>] [-SitePrimarySiteName <String>] [-SiteSecondarySiteNames <String[]>]
 [-StatusDeactivate] [-TenantOperators <ITenantOperator[]>] [-TwoFactorAuthAll] [-TwoFactorAuthEnable]
 [-TwoFactorAuthUserGroups <IIdName[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Modify
```
Invoke-ModifyCompany -CompanyId <Int32> -Body <IUpdateCompany> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ModifyViaIdentity
```
Invoke-ModifyCompany -InputObject <ICommvaultPowerShellIdentity> -Body <IUpdateCompany> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentityExpanded
```
Invoke-ModifyCompany -InputObject <ICommvaultPowerShellIdentity> [-DefaultPlans <IDefaultPlan[]>]
 [-EmailSettingSenderEmail <String>] [-EmailSettingSenderName <String>] [-FileExceptionUnix <String>]
 [-FileExceptionUseCompanyGlobalFilter] [-FileExceptionWindows <String>] [-GeneralAssignLaptopOwners <String>]
 [-GeneralAuthcodeForInstallation] [-GeneralAutoDiscoverApp] [-GeneralEmailSuffix <String>]
 [-GeneralEnableDataEncryption] [-GeneralInfrastructureType <String>] [-GeneralNewAlias <String>]
 [-GeneralResellerMode] [-GeneralServiceCommcells <IIdName[]>] [-GeneralSupportedSolutions <String[]>]
 [-GeneralUpnInsteadOfEmail] [-NewName <String>] [-OptionDisableBackup] [-OptionDisableLogin]
 [-OptionDisableRestore] [-Plans <IIdName[]>] [-Security <IUpdateSecurityAssoc[]>]
 [-SitePrimarySiteName <String>] [-SiteSecondarySiteNames <String[]>] [-StatusDeactivate]
 [-TenantOperators <ITenantOperator[]>] [-TwoFactorAuthAll] [-TwoFactorAuthEnable]
 [-TwoFactorAuthUserGroups <IIdName[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Modify the properties of an existing company

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
Used to update the properties of an existing company
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IUpdateCompany
Parameter Sets: Modify, ModifyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyId
Id of the company to update

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

### -DefaultPlans
Refers to default data protection plans to use for the company.
To construct, see NOTES section for DEFAULTPLANS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IDefaultPlan[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailSettingSenderEmail
Email id of the sender

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

### -EmailSettingSenderName
Name of the sender sending the email

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

### -FileExceptionUnix
Unix file paths to be excluded.Comma separated string.

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

### -FileExceptionUseCompanyGlobalFilter
Enable or disable the use of the file path filters on all subclients.
By default, it is enabled when filters are added for either Windows or Unix or both.

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

### -FileExceptionWindows
Window file paths to be excluded.Comma separated string.

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

### -GeneralAssignLaptopOwners
Used to assign owners to laptops automatically after installation.
The owners can be all the logged in active directory users, the first user to login into the laptop after installation or the users belonging to the laptop's local user group list.
The option to assign automatically can also be disabled.

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

### -GeneralAuthcodeForInstallation
Enable or disable authcode for installation.

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

### -GeneralAutoDiscoverApp
Enable or Disable Auto Discover Applications.When Auto discover applications is enabled, each member server of this company is searched once every 24 hours to discover any applications that need to be backed up.
For any newly-discovered and unprotected applications, the agent software is automatically installed on the server.

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

### -GeneralEmailSuffix
Supported domains for the company

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

### -GeneralEnableDataEncryption
Enable or disable data encryption

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

### -GeneralInfrastructureType
These are different types of infrastructure provided for storage in companies.
It can be rented from the provider, owned or can be a hybrid.
Cannot move back to rented storage from owned storage and cannot move back to rented storage/owned storage from rented and owned storage.

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

### -GeneralNewAlias
The company domain or NetBIOS name

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

### -GeneralResellerMode
Enable reseller mode.
A reseller is a user or user groups who can operate multiple tenant environments.
The service provider can assign one or more resellers as the tenant operator for a company.
The reseller can switch to any of their assigned tenant environment and operate on the company as a tenant user.
Once enabled, the reseller mode cannot be disabled.

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

### -GeneralServiceCommcells
Service commcells associated with the master commcell.
To construct, see NOTES section for GENERALSERVICECOMMCELLS properties and create a hash table.

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

### -GeneralSupportedSolutions
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

### -GeneralUpnInsteadOfEmail
Enable or disable the use of User Pricipal Name in place of an email address.

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
Used to change the name of a company

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

### -OptionDisableBackup
Enable or disable backup.
This option can only be set or unset for a deactivated company.

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

### -OptionDisableLogin
Enable or disable login.
This option can only be set or unset for a deactivated company.

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

### -OptionDisableRestore
Enable or disable restore.
This option can only be set or unset for a deactivated company.

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

### -Plans
Provide a list of data protection plans to use for the company.
The plans that are provided are the plans that the tenant administrator can choose from.
To construct, see NOTES section for PLANS properties and create a hash table.

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

### -Security
.
To construct, see NOTES section for SECURITY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IUpdateSecurityAssoc[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SitePrimarySiteName
Primary site name

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

### -SiteSecondarySiteNames
Secondary site names

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

### -StatusDeactivate
Used to activate or deactivate the company.

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

### -TenantOperators
.
To construct, see NOTES section for TENANTOPERATORS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ITenantOperator[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TwoFactorAuthAll
enable two factor authentication for every entity.
if set to false when Two factor authentication is enabled, provide userGroupId or userGroupName.
If both are provided, userGroupId is taken

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

### -TwoFactorAuthEnable
enable or disable two factor authentication.
if enabled, all or userGroups value should be provided.

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

### -TwoFactorAuthUserGroups
.
To construct, see NOTES section for TWOFACTORAUTHUSERGROUPS properties and create a hash table.

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

### Commvault.Powershell.Models.IUpdateCompany

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IUpdateCompany>: Used to update the properties of an existing company
  - `[DefaultPlans <IDefaultPlan[]>]`: Refers to default data protection plans to use for the company.
    - `[Id <Int32?>]`: Id of the default plan. Either id or name can be provided. If both id and name are provided, id is given first preference.
    - `[Name <String>]`: Name of the default plan. Either id or name can be provided. If both id and name are provided, id is given first preference.
    - `[Subtype <String>]`: 
  - `[EmailSettingSenderEmail <String>]`: Email id of the sender
  - `[EmailSettingSenderName <String>]`: Name of the sender sending the email
  - `[FileExceptionUnix <String>]`: Unix file paths to be excluded.Comma separated string.
  - `[FileExceptionUseCompanyGlobalFilter <Boolean?>]`: Enable or disable the use of the file path filters on all subclients. By default, it is enabled when filters are added for either Windows or Unix or both.
  - `[FileExceptionWindows <String>]`: Window file paths to be excluded.Comma separated string.
  - `[GeneralAssignLaptopOwners <String>]`: Used to assign owners to laptops automatically after installation. The owners can be all the logged in active directory users, the first user to login into the laptop after installation or the users belonging to the laptop's local user group list. The option to assign automatically can also be disabled.
  - `[GeneralAuthcodeForInstallation <Boolean?>]`: Enable or disable authcode for installation.
  - `[GeneralAutoDiscoverApp <Boolean?>]`: Enable or Disable Auto Discover Applications.When Auto discover applications is enabled, each member server of this company is searched once every 24 hours to discover any applications that need to be backed up. For any newly-discovered and unprotected applications, the agent software is automatically installed on the server.
  - `[GeneralEmailSuffix <String>]`: Supported domains for the company
  - `[GeneralEnableDataEncryption <Boolean?>]`: Enable or disable data encryption
  - `[GeneralInfrastructureType <String>]`: These are different types of infrastructure provided for storage in companies. It can be rented from the provider, owned or can be a hybrid. Cannot move back to rented storage from owned storage and cannot move back to rented storage/owned storage from rented and owned storage.
  - `[GeneralNewAlias <String>]`: The company domain or NetBIOS name
  - `[GeneralResellerMode <Boolean?>]`: Enable reseller mode. A reseller is a user or user groups who can operate multiple tenant environments. The service provider can assign one or more resellers as the tenant operator for a company. The reseller can switch to any of their assigned tenant environment and operate on the company as a tenant user. Once enabled, the reseller mode cannot be disabled.
  - `[GeneralServiceCommcells <IIdName[]>]`: Service commcells associated with the master commcell.
    - `[Id <Int32?>]`: 
    - `[Name <String>]`: 
  - `[GeneralSupportedSolutions <String[]>]`: 
  - `[GeneralUpnInsteadOfEmail <Boolean?>]`: Enable or disable the use of User Pricipal Name in place of an email address.
  - `[NewName <String>]`: Used to change the name of a company
  - `[OptionDisableBackup <Boolean?>]`: Enable or disable backup. This option can only be set or unset for a deactivated company.
  - `[OptionDisableLogin <Boolean?>]`: Enable or disable login. This option can only be set or unset for a deactivated company.
  - `[OptionDisableRestore <Boolean?>]`: Enable or disable restore. This option can only be set or unset for a deactivated company.
  - `[Plans <IIdName[]>]`: Provide a list of data protection plans to use for the company. The plans that are provided are the plans that the tenant administrator can choose from.
  - `[Security <IUpdateSecurityAssoc[]>]`: 
    - `[RoleId <Int32?>]`: 
    - `[RoleName <String>]`: 
    - `[UserGroupId <Int32?>]`: 
    - `[UserGroupName <String>]`: 
    - `[UserId <Int32?>]`: 
    - `[UserName <String>]`: 
  - `[SitePrimarySiteName <String>]`: Primary site name
  - `[SiteSecondarySiteNames <String[]>]`: Secondary site names
  - `[StatusDeactivate <Boolean?>]`: Used to activate or deactivate the company.
  - `[TenantOperators <ITenantOperator[]>]`: 
    - `[RoleId <Int32?>]`: 
    - `[RoleName <String>]`: 
    - `[UserGroupId <Int32?>]`: 
    - `[UserGroupName <String>]`: 
    - `[UserId <Int32?>]`: 
    - `[UserName <String>]`: 
  - `[TwoFactorAuthAll <Boolean?>]`: enable two factor authentication for every entity. if set to false when Two factor authentication is enabled, provide userGroupId or userGroupName. If both are provided, userGroupId is taken
  - `[TwoFactorAuthEnable <Boolean?>]`: enable or disable two factor authentication. if enabled, all or userGroups value should be provided.
  - `[TwoFactorAuthUserGroups <IIdName[]>]`: 

DEFAULTPLANS <IDefaultPlan[]>: Refers to default data protection plans to use for the company.
  - `[Id <Int32?>]`: Id of the default plan. Either id or name can be provided. If both id and name are provided, id is given first preference.
  - `[Name <String>]`: Name of the default plan. Either id or name can be provided. If both id and name are provided, id is given first preference.
  - `[Subtype <String>]`: 

GENERALSERVICECOMMCELLS <IIdName[]>: Service commcells associated with the master commcell.
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

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
  - `[EntityType <String>]`: Type of the entity
  - `[GlobalSearchEntity <String>]`: name of global search entity
  - `[HfsShareId <Int32?>]`: Id of the HFS Share to fetch its status
  - `[HyperScaleStorageId <Int32?>]`: Id of hyperscale storage
  - `[HypervisorId <Int32?>]`: Id of the HYpervisor to get
  - `[Id <Int32?>]`: 
  - `[InstanceId <Int32?>]`: Id of the instance to modify
  - `[KmsId <Int32?>]`: Id of Key Management Server
  - `[MediaAgentId <Int32?>]`: Id of the Media Agent whose details have to be fetched
  - `[MetadataCacheId <Int32?>]`: Id of metadata cache
  - `[Name <String>]`: 
  - `[NodeId <Int32?>]`: Id of node
  - `[PairId <Int32?>]`: 
  - `[PlanId <Int32?>]`: Id of the plan to fetch details
  - `[RecoveryTargetId <Int32?>]`: id of recovery target
  - `[RegionId <String>]`: 
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

PLANS <IIdName[]>: Provide a list of data protection plans to use for the company. The plans that are provided are the plans that the tenant administrator can choose from.
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

SECURITY <IUpdateSecurityAssoc[]>: .
  - `[RoleId <Int32?>]`: 
  - `[RoleName <String>]`: 
  - `[UserGroupId <Int32?>]`: 
  - `[UserGroupName <String>]`: 
  - `[UserId <Int32?>]`: 
  - `[UserName <String>]`: 

TENANTOPERATORS <ITenantOperator[]>: .
  - `[RoleId <Int32?>]`: 
  - `[RoleName <String>]`: 
  - `[UserGroupId <Int32?>]`: 
  - `[UserGroupName <String>]`: 
  - `[UserId <Int32?>]`: 
  - `[UserName <String>]`: 

TWOFACTORAUTHUSERGROUPS <IIdName[]>: .
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

