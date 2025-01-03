---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/set-cvcompany
schema: 2.0.0
---

# Set-CVCompany

## SYNOPSIS
Modify the properties of an existing company

## SYNTAX

### UpdateExpanded (Default)
```
Set-CVCompany -CompanyId <Int64> [-DefaultPlans <IDefaultPlan[]>] [-EmailSettingSenderEmail <String>]
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

### UpdateViaIdentityExpanded
```
Set-CVCompany -InputObject <ICommvaultPowerShellIdentity> [-DefaultPlans <IDefaultPlan[]>]
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

### -CompanyId
Id of the company to update

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultPlans
Refers to default data protection plans to use for the company.

```yaml
Type: Commvault.Powershell.Models.IDefaultPlan[]
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GeneralServiceCommcells
Service commcells associated with the master commcell.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Commvault.Powershell.Models.ICommvaultPowerShellIdentity
Parameter Sets: UpdateViaIdentityExpanded
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Security
.

```yaml
Type: Commvault.Powershell.Models.IUpdateSecurityAssoc[]
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantOperators
.

```yaml
Type: Commvault.Powershell.Models.ITenantOperator[]
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TwoFactorAuthUserGroups
.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
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

### Commvault.Powershell.Models.ICommvaultPowerShellIdentity

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`DEFAULTPLANS <IDefaultPlan[]>`: Refers to default data protection plans to use for the company.
  - `[Id <Int64?>]`: Id of the default plan. Either id or name can be provided. If both id and name are provided, id is given first preference.
  - `[Name <String>]`: Name of the default plan. Either id or name can be provided. If both id and name are provided, id is given first preference.
  - `[Subtype <String>]`: 

`GENERALSERVICECOMMCELLS <IIdName[]>`: Service commcells associated with the master commcell.
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`INPUTOBJECT <ICommvaultPowerShellIdentity>`: Identity Parameter
  - `[AccessPathId <Int64?>]`: Id of the mount path whose access path has to be deleted
  - `[AgentId <Int64?>]`: Id of the agent to be modified
  - `[AlertRuleId <Int64?>]`: Unique Id of the alert custom rule to get details
  - `[AppGuid <String>]`: GUID of the Application to get details
  - `[AppId <Int64?>]`: Commvault exchange app id
  - `[ApplicationGroupId <Int64?>]`: applicationGroupId is the ID of the Kubernetes application group
  - `[ArrayId <Int64?>]`: 
  - `[AssetId <String>]`: FQDN of the asset
  - `[BackupDestinationId <Int64?>]`: Id of the backupDestination to be modified
  - `[BackupDestionationId <Int64?>]`: 
  - `[BackupLocationId <Int64?>]`: Id of the backup location whose details have to be fetched
  - `[BlackoutWindowId <Int64?>]`: Id of the Blackout Window whose details have to be fetched
  - `[BucketId <Int64?>]`: Id of Bucket
  - `[ClientId <Int64?>]`: 
  - `[CloneId <Int64?>]`: ID of the cloned bucket
  - `[CloudStorageId <Int64?>]`: Id of cloud Storage
  - `[ClusterId <Int64?>]`: Id of the cluster whose modifier has to be listed.
  - `[CompanyId <Int64?>]`: Id of the Company whose details have to be fetched
  - `[CopyId <Int64?>]`: 
  - `[CredentialId <String>]`: 
  - `[CredentialName <String>]`: 
  - `[DomainId <Int64?>]`: ID of the AD/LDAP domain
  - `[DrOperation <String>]`: Name of DR operation. Case insensitive
  - `[DriveId <Int64?>]`: Id of the Drive of which the drive details has to be displayed
  - `[EntityId <Int64?>]`: Recovery entity Id
  - `[EntityType <String>]`: Type of the entity
  - `[FailoverGroupId <Int64?>]`: Id of the failover group
  - `[GlobalSearchEntity <String>]`: name of global search entity
  - `[HfsShareId <Int64?>]`: Id of the HFS Share to fetch its status
  - `[HyperScaleStorageId <Int64?>]`: Id of hyperscale storage
  - `[HypervisorId <Int64?>]`: Id of the HYpervisor to get
  - `[Id <Int64?>]`: 
  - `[IndexServerClientId <Int64?>]`: Pseudo client id of the index server
  - `[InstanceId <Int64?>]`: Id of the instance to modify
  - `[InventoryId <Int64?>]`: Inventory id
  - `[JobId <Int64?>]`: 
  - `[KmsId <Int64?>]`: Id of Key Management Server
  - `[LibraryId <Int64?>]`: Id of the library to view the data
  - `[MediaAgentId <Int64?>]`: Id of the Media Agent whose details have to be fetched
  - `[MetadataCacheId <Int64?>]`: Id of metadata cache
  - `[ModifierName <String>]`: Name of the modifier to be read.
  - `[Name <String>]`: 
  - `[NameSpace <String>]`: Name of the namespace to browse for content
  - `[NodeId <Int64?>]`: Id of node
  - `[PairId <Int64?>]`: 
  - `[PlanId <Int64?>]`: Id of the object store plan to fetch details
  - `[RecoveryEntityId <Int64?>]`: Recovery entity Id
  - `[RecoveryGroupId <Int64?>]`: Recovery group Id
  - `[RecoveryTargetId <Int64?>]`: id of recovery target
  - `[RegionId <Int64?>]`: Region id to be deleted.
  - `[RegionList <String>]`: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  - `[ReplicationGroupId <String>]`: 
  - `[ReplicationPairId <Int64?>]`: Replication pair id of the Pair
  - `[RequestId <Int64?>]`: Unique identifier for the request
  - `[RoleId <Int64?>]`: Role Id
  - `[RpsId <String>]`: 
  - `[RuleId <Int64?>]`: Id of the rule to update in Plan
  - `[ScheduleId <Int64?>]`: ID of the DR operation schedule
  - `[SchedulePolicyId <Int64?>]`: 
  - `[ServerGroupId <Int64?>]`: Id of the serverGroupId whose details have to be fetched
  - `[ServerId <Int64?>]`: Id of the server to modify
  - `[SnapEngineId <Int64?>]`: Snap Engine Id
  - `[SpareGroupId <Int64?>]`: Id of the Spare group whose properties need to be fetched. spareGroupId can be fetched from GET V4/Storage/Tape/{libraryId}/MediaType
  - `[StoragePoolId <Int64?>]`: Id of the storage pool whose associated copies have to be fetched
  - `[SubclientId <Int64?>]`: Id of the subclient to modify
  - `[TagId <Int64?>]`: Id of the tag to delete
  - `[TagValue <String>]`: tag value to delete
  - `[TopologyId <String>]`: 
  - `[UserGroupId <Int64?>]`: Id of the user-group whose details have to be fetched
  - `[UserId <Int64?>]`: Id of the User whose details have to be fetched
  - `[VMGroupId <Int64?>]`: Id of the VMgroup to update
  - `[VMGuid <String>]`: 
  - `[VMUuid <String>]`: The vmUUID can be obtained from GET /virtualMachines UUID property
  - `[VendorId <Int64?>]`: 

`PLANS <IIdName[]>`: Provide a list of data protection plans to use for the company. The plans that are provided are the plans that the tenant administrator can choose from.
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`SECURITY <IUpdateSecurityAssoc[]>`: .
  - `[RoleId <Int64?>]`: 
  - `[RoleName <String>]`: 
  - `[UserGroupId <Int64?>]`: 
  - `[UserGroupName <String>]`: 
  - `[UserId <Int64?>]`: 
  - `[UserName <String>]`: 

`TENANTOPERATORS <ITenantOperator[]>`: .
  - `[RoleId <Int64?>]`: 
  - `[RoleName <String>]`: 
  - `[UserGroupId <Int64?>]`: 
  - `[UserGroupName <String>]`: 
  - `[UserId <Int64?>]`: 
  - `[UserName <String>]`: 

`TWOFACTORAUTHUSERGROUPS <IIdName[]>`: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

