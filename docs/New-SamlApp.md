---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-samlapp
schema: 2.0.0
---

# New-SamlApp

## SYNOPSIS
Creates SAML app

## SYNTAX

```
New-SamlApp -Description <String> -IdentityProviderMetaDataCertificateData <String>
 -IdentityProviderMetaDataEntityId <String> -IdentityProviderMetaDataLogoutUrl <String>
 -IdentityProviderMetaDataRedirectUrl <String> -IdentityProviderMetaDataSamlProtocolVersion <String>
 -Name <String> [-AssociationCompanies <IIdName[]>] [-AssociationDomains <IIdName[]>]
 [-AssociationEmailSuffixes <String[]>] [-AssociationUserGroups <IIdName[]>]
 [-ServiceProviderMetaDataAliasName <String>] [-ServiceProviderMetaDataAutoGenerateSpMetaData]
 [-ServiceProviderMetaDataCertificateData <String>] [-ServiceProviderMetaDataJksFileContents <String[]>]
 [-ServiceProviderMetaDataJksPrivateKey <String>] [-ServiceProviderMetaDataKeyStorePassword <String>]
 [-ServiceProviderMetaDataPrivateKeyPassword <String>]
 [-ServiceProviderMetaDataServiceProviderEndpoint <String>] [-ServiceProviderMetaDataSpAliases <String[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Creates SAML app

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
To construct, see NOTES section for ASSOCIATIONDOMAINS properties and create a hash table.

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
To construct, see NOTES section for ASSOCIATIONUSERGROUPS properties and create a hash table.

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

### -Description
SAML description

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
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

Required: True
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

Required: True
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

Required: True
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

Required: True
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

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
SAML name.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
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

## RELATED LINKS

