
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Creates SAML app
.Description
Creates SAML app
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ASSOCIATIONCOMPANIES <IIdName[]>: Companies associated with SAML
  [Id <Int64?>]: 
  [Name <String>]: 

ASSOCIATIONDOMAINS <IIdName[]>: Domains associated with SAML
  [Id <Int64?>]: 
  [Name <String>]: 

ASSOCIATIONUSERGROUPS <IIdName[]>: user groups associated with SAML
  [Id <Int64?>]: 
  [Name <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-samlapp
#>
function New-SamlApp {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # SAML description
    ${Description},

    [Parameter(Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # IDP certificate public key
    ${IdentityProviderMetaDataCertificateData},

    [Parameter(Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Identity provider entity
    ${IdentityProviderMetaDataEntityId},

    [Parameter(Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Identity Provider log-out URL
    ${IdentityProviderMetaDataLogoutUrl},

    [Parameter(Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Identity provider redirect URL
    ${IdentityProviderMetaDataRedirectUrl},

    [Parameter(Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # SAML Protocol version
    ${IdentityProviderMetaDataSamlProtocolVersion},

    [Parameter(Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # SAML name.
    ${Name},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # Companies associated with SAML
    # To construct, see NOTES section for ASSOCIATIONCOMPANIES properties and create a hash table.
    ${AssociationCompanies},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # Domains associated with SAML
    # To construct, see NOTES section for ASSOCIATIONDOMAINS properties and create a hash table.
    ${AssociationDomains},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Email suffixes associated with SAML
    ${AssociationEmailSuffixes},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # user groups associated with SAML
    # To construct, see NOTES section for ASSOCIATIONUSERGROUPS properties and create a hash table.
    ${AssociationUserGroups},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # certificate alias name
    ${ServiceProviderMetaDataAliasName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${ServiceProviderMetaDataAutoGenerateSpMetaData},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # certificate alias name.
    ${ServiceProviderMetaDataCertificateData},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # jks file contents as byte array
    ${ServiceProviderMetaDataJksFileContents},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # key store password.
    ${ServiceProviderMetaDataJksPrivateKey},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # jks contents key store password.
    ${ServiceProviderMetaDataKeyStorePassword},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # certificate private key password
    ${ServiceProviderMetaDataPrivateKeyPassword},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # web console URL.
    ${ServiceProviderMetaDataServiceProviderEndpoint},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # web console URL list.
    ${ServiceProviderMetaDataSpAliases},

    [Parameter(DontShow)]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Commvault.Powershell.Category('Runtime')]
    [Commvault.Powershell.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Commvault.Powershell.Category('Runtime')]
    [Commvault.Powershell.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Commvault.Powershell.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'CommvaultPowerShell.private\New-SamlApp_CreateExpanded';
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
