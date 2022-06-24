
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
Modify the properties of an existing company
.Description
Modify the properties of an existing company
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICommvaultPowerShellIdentity
.Inputs
Commvault.Powershell.Models.IUpdateCompany
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IUpdateCompany>: Used to update the properties of an existing company
  [DefaultPlans <IDefaultPlan[]>]: Refers to default data protection plans to use for the company.
    [Id <Int32?>]: Id of the default plan. Either id or name can be provided. If both id and name are provided, id is given first preference.
    [Name <String>]: Name of the default plan. Either id or name can be provided. If both id and name are provided, id is given first preference.
    [Subtype <String>]: 
  [EmailSettingSenderEmail <String>]: Email id of the sender
  [EmailSettingSenderName <String>]: Name of the sender sending the email
  [FileExceptionUnix <String>]: Unix file paths to be excluded.Comma separated string.
  [FileExceptionUseCompanyGlobalFilter <Boolean?>]: Enable or disable the use of the file path filters on all subclients. By default, it is enabled when filters are added for either Windows or Unix or both.
  [FileExceptionWindows <String>]: Window file paths to be excluded.Comma separated string.
  [GeneralAssignLaptopOwners <String>]: Used to assign owners to laptops automatically after installation. The owners can be all the logged in active directory users, the first user to login into the laptop after installation or the users belonging to the laptop's local user group list. The option to assign automatically can also be disabled.
  [GeneralAuthcodeForInstallation <Boolean?>]: Enable or disable authcode for installation.
  [GeneralAutoDiscoverApp <Boolean?>]: Enable or Disable Auto Discover Applications.When Auto discover applications is enabled, each member server of this company is searched once every 24 hours to discover any applications that need to be backed up. For any newly-discovered and unprotected applications, the agent software is automatically installed on the server.
  [GeneralEmailSuffix <String>]: Supported domains for the company
  [GeneralEnableDataEncryption <Boolean?>]: Enable or disable data encryption
  [GeneralInfrastructureType <String>]: These are different types of infrastructure provided for storage in companies. It can be rented from the provider, owned or can be a hybrid. Cannot move back to rented storage from owned storage and cannot move back to rented storage/owned storage from rented and owned storage.
  [GeneralNewAlias <String>]: The company domain or NetBIOS name
  [GeneralResellerMode <Boolean?>]: Enable reseller mode. A reseller is a user or user groups who can operate multiple tenant environments. The service provider can assign one or more resellers as the tenant operator for a company. The reseller can switch to any of their assigned tenant environment and operate on the company as a tenant user. Once enabled, the reseller mode cannot be disabled.
  [GeneralServiceCommcells <IIdName[]>]: Service commcells associated with the master commcell.
    [Id <Int32?>]: 
    [Name <String>]: 
  [GeneralSupportedSolutions <String[]>]: 
  [GeneralUpnInsteadOfEmail <Boolean?>]: Enable or disable the use of User Pricipal Name in place of an email address.
  [NewName <String>]: Used to change the name of a company
  [OptionDisableBackup <Boolean?>]: Enable or disable backup. This option can only be set or unset for a deactivated company.
  [OptionDisableLogin <Boolean?>]: Enable or disable login. This option can only be set or unset for a deactivated company.
  [OptionDisableRestore <Boolean?>]: Enable or disable restore. This option can only be set or unset for a deactivated company.
  [Plans <IIdName[]>]: Provide a list of data protection plans to use for the company. The plans that are provided are the plans that the tenant administrator can choose from.
  [Security <IUpdateSecurityAssoc[]>]: 
    [RoleId <Int32?>]: 
    [RoleName <String>]: 
    [UserGroupId <Int32?>]: 
    [UserGroupName <String>]: 
    [UserId <Int32?>]: 
    [UserName <String>]: 
  [SitePrimarySiteName <String>]: Primary site name
  [SiteSecondarySiteNames <String[]>]: Secondary site names
  [StatusDeactivate <Boolean?>]: Used to activate or deactivate the company.
  [TenantOperators <ITenantOperator[]>]: 
    [RoleId <Int32?>]: 
    [RoleName <String>]: 
    [UserGroupId <Int32?>]: 
    [UserGroupName <String>]: 
    [UserId <Int32?>]: 
    [UserName <String>]: 
  [TwoFactorAuthAll <Boolean?>]: enable two factor authentication for every entity. if set to false when Two factor authentication is enabled, provide userGroupId or userGroupName. If both are provided, userGroupId is taken
  [TwoFactorAuthEnable <Boolean?>]: enable or disable two factor authentication. if enabled, all or userGroups value should be provided.
  [TwoFactorAuthUserGroups <IIdName[]>]: 

DEFAULTPLANS <IDefaultPlan[]>: Refers to default data protection plans to use for the company.
  [Id <Int32?>]: Id of the default plan. Either id or name can be provided. If both id and name are provided, id is given first preference.
  [Name <String>]: Name of the default plan. Either id or name can be provided. If both id and name are provided, id is given first preference.
  [Subtype <String>]: 

GENERALSERVICECOMMCELLS <IIdName[]>: Service commcells associated with the master commcell.
  [Id <Int32?>]: 
  [Name <String>]: 

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

PLANS <IIdName[]>: Provide a list of data protection plans to use for the company. The plans that are provided are the plans that the tenant administrator can choose from.
  [Id <Int32?>]: 
  [Name <String>]: 

SECURITY <IUpdateSecurityAssoc[]>: .
  [RoleId <Int32?>]: 
  [RoleName <String>]: 
  [UserGroupId <Int32?>]: 
  [UserGroupName <String>]: 
  [UserId <Int32?>]: 
  [UserName <String>]: 

TENANTOPERATORS <ITenantOperator[]>: .
  [RoleId <Int32?>]: 
  [RoleName <String>]: 
  [UserGroupId <Int32?>]: 
  [UserGroupName <String>]: 
  [UserId <Int32?>]: 
  [UserName <String>]: 

TWOFACTORAUTHUSERGROUPS <IIdName[]>: .
  [Id <Int32?>]: 
  [Name <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifycompany
#>
function Invoke-ModifyCompany {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='ModifyExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Modify', Mandatory)]
    [Parameter(ParameterSetName='ModifyExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # Id of the company to update
    ${CompanyId},

    [Parameter(ParameterSetName='ModifyViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Path')]
    [Commvault.Powershell.Models.ICommvaultPowerShellIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Modify', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ModifyViaIdentity', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IUpdateCompany]
    # Used to update the properties of an existing company
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IDefaultPlan[]]
    # Refers to default data protection plans to use for the company.
    # To construct, see NOTES section for DEFAULTPLANS properties and create a hash table.
    ${DefaultPlans},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Email id of the sender
    ${EmailSettingSenderEmail},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Name of the sender sending the email
    ${EmailSettingSenderName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Unix file paths to be excluded.Comma separated string.
    ${FileExceptionUnix},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable the use of the file path filters on all subclients.
    # By default, it is enabled when filters are added for either Windows or Unix or both.
    ${FileExceptionUseCompanyGlobalFilter},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Window file paths to be excluded.Comma separated string.
    ${FileExceptionWindows},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Used to assign owners to laptops automatically after installation.
    # The owners can be all the logged in active directory users, the first user to login into the laptop after installation or the users belonging to the laptop's local user group list.
    # The option to assign automatically can also be disabled.
    ${GeneralAssignLaptopOwners},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable authcode for installation.
    ${GeneralAuthcodeForInstallation},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or Disable Auto Discover Applications.When Auto discover applications is enabled, each member server of this company is searched once every 24 hours to discover any applications that need to be backed up.
    # For any newly-discovered and unprotected applications, the agent software is automatically installed on the server.
    ${GeneralAutoDiscoverApp},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Supported domains for the company
    ${GeneralEmailSuffix},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable data encryption
    ${GeneralEnableDataEncryption},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # These are different types of infrastructure provided for storage in companies.
    # It can be rented from the provider, owned or can be a hybrid.
    # Cannot move back to rented storage from owned storage and cannot move back to rented storage/owned storage from rented and owned storage.
    ${GeneralInfrastructureType},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The company domain or NetBIOS name
    ${GeneralNewAlias},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable reseller mode.
    # A reseller is a user or user groups who can operate multiple tenant environments.
    # The service provider can assign one or more resellers as the tenant operator for a company.
    # The reseller can switch to any of their assigned tenant environment and operate on the company as a tenant user.
    # Once enabled, the reseller mode cannot be disabled.
    ${GeneralResellerMode},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # Service commcells associated with the master commcell.
    # To construct, see NOTES section for GENERALSERVICECOMMCELLS properties and create a hash table.
    ${GeneralServiceCommcells},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # .
    ${GeneralSupportedSolutions},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable the use of User Pricipal Name in place of an email address.
    ${GeneralUpnInsteadOfEmail},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Used to change the name of a company
    ${NewName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable backup.
    # This option can only be set or unset for a deactivated company.
    ${OptionDisableBackup},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable login.
    # This option can only be set or unset for a deactivated company.
    ${OptionDisableLogin},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Enable or disable restore.
    # This option can only be set or unset for a deactivated company.
    ${OptionDisableRestore},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # Provide a list of data protection plans to use for the company.
    # The plans that are provided are the plans that the tenant administrator can choose from.
    # To construct, see NOTES section for PLANS properties and create a hash table.
    ${Plans},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IUpdateSecurityAssoc[]]
    # .
    # To construct, see NOTES section for SECURITY properties and create a hash table.
    ${Security},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Primary site name
    ${SitePrimarySiteName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Secondary site names
    ${SiteSecondarySiteNames},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Used to activate or deactivate the company.
    ${StatusDeactivate},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ITenantOperator[]]
    # .
    # To construct, see NOTES section for TENANTOPERATORS properties and create a hash table.
    ${TenantOperators},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # enable two factor authentication for every entity.
    # if set to false when Two factor authentication is enabled, provide userGroupId or userGroupName.
    # If both are provided, userGroupId is taken
    ${TwoFactorAuthAll},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # enable or disable two factor authentication.
    # if enabled, all or userGroups value should be provided.
    ${TwoFactorAuthEnable},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # .
    # To construct, see NOTES section for TWOFACTORAUTHUSERGROUPS properties and create a hash table.
    ${TwoFactorAuthUserGroups},

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

    [Parameter()]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

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
            Modify = 'CommvaultPowerShell.private\Invoke-ModifyCompany_Modify';
            ModifyExpanded = 'CommvaultPowerShell.private\Invoke-ModifyCompany_ModifyExpanded';
            ModifyViaIdentity = 'CommvaultPowerShell.private\Invoke-ModifyCompany_ModifyViaIdentity';
            ModifyViaIdentityExpanded = 'CommvaultPowerShell.private\Invoke-ModifyCompany_ModifyViaIdentityExpanded';
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
