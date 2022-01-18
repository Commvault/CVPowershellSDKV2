---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-samlapp
schema: 2.0.0
---

# Set-SamlApp

## SYNOPSIS
Updates details of existing SAML app

## SYNTAX

### UpdateExpanded (Default)
```
Set-SamlApp -Name <String> [-AssociationCompanies <IIdName[]>] [-AssociationDomains <IIdName[]>]
 [-AssociationEmailSuffixes <String[]>] [-AssociationUserGroups <IIdName[]>]
 [-AttributeMappings <ISamlAttributes[]>] [-AutoCreateUser] [-Description <String>] [-Enabled]
 [-IdentityProviderMetaDataCertificateData <String>] [-IdentityProviderMetaDataEntityId <String>]
 [-IdentityProviderMetaDataLogoutUrl <String>] [-IdentityProviderMetaDataRedirectUrl <String>]
 [-IdentityProviderMetaDataSamlProtocolVersion <String>] [-NameIdAttribute <String>]
 [-ServiceProviderMetaDataAliasName <String>] [-ServiceProviderMetaDataAutoGenerateSpMetaData]
 [-ServiceProviderMetaDataCertificateData <String>] [-ServiceProviderMetaDataJksFileContents <String[]>]
 [-ServiceProviderMetaDataJksPrivateKey <String>] [-ServiceProviderMetaDataKeyStorePassword <String>]
 [-ServiceProviderMetaDataPrivateKeyPassword <String>]
 [-ServiceProviderMetaDataServiceProviderEndpoint <String>] [-ServiceProviderMetaDataSpAliases <String[]>]
 [-UserGroups <ICompanyWithUserGroupAssocDetails[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Set-SamlApp -Name <String> -Body <ISamlUpdate> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Set-SamlApp -InputObject <ICommvaultPowerShellIdentity> -Body <ISamlUpdate> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Set-SamlApp -InputObject <ICommvaultPowerShellIdentity> [-AssociationCompanies <IIdName[]>]
 [-AssociationDomains <IIdName[]>] [-AssociationEmailSuffixes <String[]>] [-AssociationUserGroups <IIdName[]>]
 [-AttributeMappings <ISamlAttributes[]>] [-AutoCreateUser] [-Description <String>] [-Enabled]
 [-IdentityProviderMetaDataCertificateData <String>] [-IdentityProviderMetaDataEntityId <String>]
 [-IdentityProviderMetaDataLogoutUrl <String>] [-IdentityProviderMetaDataRedirectUrl <String>]
 [-IdentityProviderMetaDataSamlProtocolVersion <String>] [-NameIdAttribute <String>]
 [-ServiceProviderMetaDataAliasName <String>] [-ServiceProviderMetaDataAutoGenerateSpMetaData]
 [-ServiceProviderMetaDataCertificateData <String>] [-ServiceProviderMetaDataJksFileContents <String[]>]
 [-ServiceProviderMetaDataJksPrivateKey <String>] [-ServiceProviderMetaDataKeyStorePassword <String>]
 [-ServiceProviderMetaDataPrivateKeyPassword <String>]
 [-ServiceProviderMetaDataServiceProviderEndpoint <String>] [-ServiceProviderMetaDataSpAliases <String[]>]
 [-UserGroups <ICompanyWithUserGroupAssocDetails[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Updates details of existing SAML app

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

### -AssociationCompanies
Companies associated with SAML
To construct, see NOTES section for ASSOCIATIONCOMPANIES properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssociationDomains
Domains associated with SAML
To construct, see NOTES section for ASSOCIATIONDOMAINS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssociationEmailSuffixes
Email suffixes associated with SAML

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssociationUserGroups
user groups associated with SAML
To construct, see NOTES section for ASSOCIATIONUSERGROUPS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttributeMappings
attribute mapping details
To construct, see NOTES section for ATTRIBUTEMAPPINGS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ISamlAttributes[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoCreateUser
This auto-creates non-existing user if the user detail match with the identity rule.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Updates SAML details
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ISamlUpdate
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
SAML description

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Enabled
Boolean to indicate whether SAML is enabled.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityProviderMetaDataCertificateData
IDP certificate public key

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityProviderMetaDataEntityId
Identity provider entity

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityProviderMetaDataLogoutUrl
Identity Provider log-out URL

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityProviderMetaDataRedirectUrl
Identity provider redirect URL

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityProviderMetaDataSamlProtocolVersion
SAML Protocol version

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NameIdAttribute
nameID in SAML assertion subject is used to perform login.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceProviderMetaDataAliasName
certificate alias name

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceProviderMetaDataAutoGenerateSpMetaData
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceProviderMetaDataCertificateData
certificate alias name.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceProviderMetaDataJksFileContents
jks file contents as byte array

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceProviderMetaDataJksPrivateKey
key store password.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceProviderMetaDataKeyStorePassword
jks contents key store password.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceProviderMetaDataPrivateKeyPassword
certificate private key password

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceProviderMetaDataServiceProviderEndpoint
web console URL.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceProviderMetaDataSpAliases
web console URL list.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserGroups
By default, auto-created users will be associated to the Tenant Users group of the company.
Add mapping to override this behaviour for a company.
To construct, see NOTES section for USERGROUPS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICompanyWithUserGroupAssocDetails[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Commvault.Powershell.Models.ISamlUpdate

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSOCIATIONCOMPANIES <IIdName[]>: Companies associated with SAML
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

ASSOCIATIONDOMAINS <IIdName[]>: Domains associated with SAML
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

ASSOCIATIONUSERGROUPS <IIdName[]>: user groups associated with SAML
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

ATTRIBUTEMAPPINGS <ISamlAttributes[]>: attribute mapping details
  - `[CustomAttribute <String>]`: SAML custom attribute types
  - `[SamlAttribute <String>]`: SAML attribute

BODY <ISamlUpdate>: Updates SAML details
  - `[AssociationCompanies <IIdName[]>]`: Companies associated with SAML
    - `[Id <Int32?>]`: 
    - `[Name <String>]`: 
  - `[AssociationDomains <IIdName[]>]`: Domains associated with SAML
  - `[AssociationEmailSuffixes <String[]>]`: Email suffixes associated with SAML
  - `[AssociationUserGroups <IIdName[]>]`: user groups associated with SAML
  - `[AttributeMappings <ISamlAttributes[]>]`: attribute mapping details
    - `[CustomAttribute <String>]`: SAML custom attribute types
    - `[SamlAttribute <String>]`: SAML attribute
  - `[AutoCreateUser <Boolean?>]`: This auto-creates non-existing user if the user detail match with the identity rule.
  - `[Description <String>]`: SAML description
  - `[Enabled <Boolean?>]`: Boolean to indicate whether SAML is enabled.
  - `[IdentityProviderMetaDataCertificateData <String>]`: IDP certificate public key
  - `[IdentityProviderMetaDataEntityId <String>]`: Identity provider entity
  - `[IdentityProviderMetaDataLogoutUrl <String>]`: Identity Provider log-out URL
  - `[IdentityProviderMetaDataRedirectUrl <String>]`: Identity provider redirect URL
  - `[IdentityProviderMetaDataSamlProtocolVersion <String>]`: SAML Protocol version 
  - `[NameIdAttribute <String>]`: nameID in SAML assertion subject is used to perform login.
  - `[ServiceProviderMetaDataAliasName <String>]`: certificate alias name
  - `[ServiceProviderMetaDataAutoGenerateSpMetaData <Boolean?>]`: 
  - `[ServiceProviderMetaDataCertificateData <String>]`: certificate alias name.
  - `[ServiceProviderMetaDataJksFileContents <String[]>]`: jks file contents as byte array
  - `[ServiceProviderMetaDataJksPrivateKey <String>]`: key store password.
  - `[ServiceProviderMetaDataKeyStorePassword <String>]`: jks contents key store password.
  - `[ServiceProviderMetaDataPrivateKeyPassword <String>]`: certificate private key password
  - `[ServiceProviderMetaDataServiceProviderEndpoint <String>]`: web console URL.
  - `[ServiceProviderMetaDataSpAliases <String[]>]`: web console URL list.
  - `[UserGroups <ICompanyWithUserGroupAssocDetails[]>]`: By default, auto-created users will be associated to the Tenant Users group of the company. Add mapping to override this behaviour for a company.
    - `[CompanyInfoId <Int32?>]`: 
    - `[CompanyInfoName <String>]`: 
    - `[UserGroupInfoId <Int32?>]`: 
    - `[UserGroupInfoName <String>]`: 

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

USERGROUPS <ICompanyWithUserGroupAssocDetails[]>: By default, auto-created users will be associated to the Tenant Users group of the company. Add mapping to override this behaviour for a company.
  - `[CompanyInfoId <Int32?>]`: 
  - `[CompanyInfoName <String>]`: 
  - `[UserGroupInfoId <Int32?>]`: 
  - `[UserGroupInfoName <String>]`: 

## RELATED LINKS

