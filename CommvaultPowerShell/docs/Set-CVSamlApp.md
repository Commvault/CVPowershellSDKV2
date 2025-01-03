---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/set-cvsamlapp
schema: 2.0.0
---

# Set-CVSamlApp

## SYNOPSIS
Update details of existing SAML app

## SYNTAX

### UpdateExpanded (Default)
```
Set-CVSamlApp -Name <String> [-AssociationCompanies <IIdName[]>] [-AssociationDomains <IIdName[]>]
 [-AssociationEmailSuffixes <String[]>] [-AssociationUserGroups <IIdName[]>]
 [-AttributeMappings <ISamlAttributes[]>] [-AutoCreateUser] [-Description <String>] [-Enabled]
 [-IdentityProviderMetaDataCertificateData <String>] [-IdentityProviderMetaDataEntityId <String>]
 [-IdentityProviderMetaDataLogoutUrl <String>] [-IdentityProviderMetaDataRedirectUrl <String>]
 [-IdentityProviderMetaDataSamlProtocolVersion <String>]
 [-IdentityProviderMetaDataSecondaryCertificateData <String>] [-NameIdAttribute <String>]
 [-ServiceProviderMetaDataAliasName <String>] [-ServiceProviderMetaDataAutoGenerateSpMetaData]
 [-ServiceProviderMetaDataCertificateData <String>] [-ServiceProviderMetaDataJksFileContents <String[]>]
 [-ServiceProviderMetaDataJksPrivateKey <String>] [-ServiceProviderMetaDataKeyStorePassword <String>]
 [-ServiceProviderMetaDataPrivateKeyPassword <String>]
 [-ServiceProviderMetaDataServiceProviderEndpoint <String>] [-ServiceProviderMetaDataSpAliases <String[]>]
 [-UserGroups <ICompanyWithUserGroupAssocDetails[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Set-CVSamlApp -InputObject <ICommvaultPowerShellIdentity> [-AssociationCompanies <IIdName[]>]
 [-AssociationDomains <IIdName[]>] [-AssociationEmailSuffixes <String[]>] [-AssociationUserGroups <IIdName[]>]
 [-AttributeMappings <ISamlAttributes[]>] [-AutoCreateUser] [-Description <String>] [-Enabled]
 [-IdentityProviderMetaDataCertificateData <String>] [-IdentityProviderMetaDataEntityId <String>]
 [-IdentityProviderMetaDataLogoutUrl <String>] [-IdentityProviderMetaDataRedirectUrl <String>]
 [-IdentityProviderMetaDataSamlProtocolVersion <String>]
 [-IdentityProviderMetaDataSecondaryCertificateData <String>] [-NameIdAttribute <String>]
 [-ServiceProviderMetaDataAliasName <String>] [-ServiceProviderMetaDataAutoGenerateSpMetaData]
 [-ServiceProviderMetaDataCertificateData <String>] [-ServiceProviderMetaDataJksFileContents <String[]>]
 [-ServiceProviderMetaDataJksPrivateKey <String>] [-ServiceProviderMetaDataKeyStorePassword <String>]
 [-ServiceProviderMetaDataPrivateKeyPassword <String>]
 [-ServiceProviderMetaDataServiceProviderEndpoint <String>] [-ServiceProviderMetaDataSpAliases <String[]>]
 [-UserGroups <ICompanyWithUserGroupAssocDetails[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update details of existing SAML app

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

### -AssociationCompanies
Companies associated with SAML

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

### -AssociationDomains
Domains associated with SAML

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

### -AssociationEmailSuffixes
Email suffixes associated with SAML

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

### -AssociationUserGroups
user groups associated with SAML

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

### -AttributeMappings
attribute mapping details

```yaml
Type: Commvault.Powershell.Models.ISamlAttributes[]
Parameter Sets: (All)
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
SAML description

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

### -Enabled
Boolean to indicate whether SAML is enabled.

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

### -IdentityProviderMetaDataCertificateData
IDP certificate public key

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

### -IdentityProviderMetaDataEntityId
Identity provider entity

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

### -IdentityProviderMetaDataLogoutUrl
Identity Provider log-out URL

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

### -IdentityProviderMetaDataRedirectUrl
Identity provider redirect URL

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

### -IdentityProviderMetaDataSamlProtocolVersion
SAML Protocol version

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

### -IdentityProviderMetaDataSecondaryCertificateData
IDP's secondary certificate

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

### -Name
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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

```yaml
Type: Commvault.Powershell.Models.ICompanyWithUserGroupAssocDetails[]
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


`ASSOCIATIONCOMPANIES <IIdName[]>`: Companies associated with SAML
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`ASSOCIATIONDOMAINS <IIdName[]>`: Domains associated with SAML
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`ASSOCIATIONUSERGROUPS <IIdName[]>`: user groups associated with SAML
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`ATTRIBUTEMAPPINGS <ISamlAttributes[]>`: attribute mapping details
  - `[CustomAttribute <String>]`: SAML custom attribute types
  - `[SamlAttribute <String>]`: SAML attribute

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

`USERGROUPS <ICompanyWithUserGroupAssocDetails[]>`: By default, auto-created users will be associated to the Tenant Users group of the company. Add mapping to override this behaviour for a company.
  - `[CompanyInfoId <Int64?>]`: 
  - `[CompanyInfoName <String>]`: 
  - `[UserGroupInfoId <Int64?>]`: 
  - `[UserGroupInfoName <String>]`: 

## RELATED LINKS

