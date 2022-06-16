
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
Updates details of existing SAML app
.Description
Updates details of existing SAML app
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICommvaultPowerShellIdentity
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ASSOCIATIONCOMPANIES <IIdName[]>: Companies associated with SAML
  [Id <Int32?>]: 
  [Name <String>]: 

ASSOCIATIONDOMAINS <IIdName[]>: Domains associated with SAML
  [Id <Int32?>]: 
  [Name <String>]: 

ASSOCIATIONUSERGROUPS <IIdName[]>: user groups associated with SAML
  [Id <Int32?>]: 
  [Name <String>]: 

ATTRIBUTEMAPPINGS <ISamlAttributes[]>: attribute mapping details
  [CustomAttribute <String>]: SAML custom attribute types
  [SamlAttribute <String>]: SAML attribute

INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
  [AccessPathId <Int32?>]: Id of the mount path whose access path has to be deleted
  [AgentId <Int32?>]: Id of the agent to be modified
  [BackupDestinationId <Int32?>]: Id of the backupDestination to be modified
  [BackupLocationId <Int32?>]: Id of the backup location whose details have to be fetched
  [BlackoutWindowId <Int32?>]: Id of the Blackout Window whose details have to be fetched
  [BucketId <Int32?>]: Id of Bucket
  [CloudStorageId <Int32?>]: Id of cloud Storage
  [CompanyId <Int32?>]: Id of the Company whose details have to be fetched
  [CredentialName <String>]: 
  [DomainId <Int32?>]: ID of the AD/LDAP domain
  [EntityId <Int32?>]: Unique id for the entity
  [EntityType <Int32?>]: Type of the entity
  [GlobalSearchEntity <String>]: name of global search entity
  [HfsShareId <Int32?>]: Id of the HFS Share to fetch its status
  [HyperScaleStorageId <Int32?>]: Id of hyperscale storage
  [HypervisorId <Int32?>]: Id of the Hypervisor to update
  [Id <Int32?>]: 
  [InstanceId <Int32?>]: Id of the instance to modify
  [InventoryEntityName <String>]: Name of the inventory entity that needs to be browsed like ESX Host name in VCenter
  [KmsId <Int32?>]: Id of Key Management Server
  [MediaAgentId <Int32?>]: Id of the Media Agent whose details have to be fetched
  [MetadataCacheId <Int32?>]: Id of metadata cache
  [Name <String>]: 
  [NodeId <Int32?>]: Id of node
  [PairId <Int32?>]: 
  [PlanId <Int32?>]: Id of the plan to fetch details
  [RecoveryTargetId <Int32?>]: id of recovery target
  [RegionId <Int32?>]: 
  [RegionList <String>]: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  [ReplicationGroupId <String>]: 
  [RequestId <Int32?>]: Unique identifier for the request
  [RoleId <Int32?>]: Role Id
  [RpsId <String>]: 
  [RuleId <Int32?>]: Id of the rule to update in Plan
  [ScheduleId <String>]: 
  [SchedulePolicyId <String>]: 
  [ServerGroupId <Int32?>]: Id of the serverGroupId whose details have to be fetched
  [ServerId <Int32?>]: Id of the server to modify
  [StoragePoolId <Int32?>]: Id of the disk storage pool whose details have to be fetched
  [SubclientId <Int32?>]: Id of the subclient to modify
  [TopologyId <String>]: 
  [UserGroupId <Int32?>]: Id of the user-group whose details have to be fetched
  [UserId <Int32?>]: Id of the User whose details have to be fetched
  [VMGroupId <Int32?>]: Id of the VMgroup to update
  [VMUuid <String>]: The vmUUID can be obtained from GET /virtualMachines UUID property

USERGROUPS <ICompanyWithUserGroupAssocDetails[]>: By default, auto-created users will be associated to the Tenant Users group of the company. Add mapping to override this behaviour for a company.
  [CompanyInfoId <Int32?>]: 
  [CompanyInfoName <String>]: 
  [UserGroupInfoId <Int32?>]: 
  [UserGroupInfoName <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-samlapp
#>
function Set-SamlApp {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.String]
    # .
    ${Name},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Path')]
    [Commvault.Powershell.Models.ICommvaultPowerShellIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

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
    [Commvault.Powershell.Models.ISamlAttributes[]]
    # attribute mapping details
    # To construct, see NOTES section for ATTRIBUTEMAPPINGS properties and create a hash table.
    ${AttributeMappings},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # This auto-creates non-existing user if the user detail match with the identity rule.
    ${AutoCreateUser},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # SAML description
    ${Description},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Boolean to indicate whether SAML is enabled.
    ${Enabled},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # IDP certificate public key
    ${IdentityProviderMetaDataCertificateData},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Identity provider entity
    ${IdentityProviderMetaDataEntityId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Identity Provider log-out URL
    ${IdentityProviderMetaDataLogoutUrl},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Identity provider redirect URL
    ${IdentityProviderMetaDataRedirectUrl},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # SAML Protocol version
    ${IdentityProviderMetaDataSamlProtocolVersion},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # nameID in SAML assertion subject is used to perform login.
    ${NameIdAttribute},

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

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ICompanyWithUserGroupAssocDetails[]]
    # By default, auto-created users will be associated to the Tenant Users group of the company.
    # Add mapping to override this behaviour for a company.
    # To construct, see NOTES section for USERGROUPS properties and create a hash table.
    ${UserGroups},

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
            UpdateExpanded = 'CommvaultPowerShell.private\Set-SamlApp_UpdateExpanded';
            UpdateViaIdentityExpanded = 'CommvaultPowerShell.private\Set-SamlApp_UpdateViaIdentityExpanded';
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
