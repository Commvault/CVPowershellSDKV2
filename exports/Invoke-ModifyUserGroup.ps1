
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
Modify the properties of an existing user-group
.Description
Modify the properties of an existing user-group
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICommvaultPowerShellIdentity
.Inputs
Commvault.Powershell.Models.IUpdateUserGroup
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ASSOCIATEDEXTERNALGROUPS <IIdName[]>: .
  [Id <Int32?>]: 
  [Name <String>]: 

ASSOCIATEDLOCALGROUPS <IIdName[]>: .
  [Id <Int32?>]: 
  [Name <String>]: 

BODY <IUpdateUserGroup>: .
  [AllowMultipleCompanyMembers <Boolean?>]: This property can be used to allow addition of users/groups from child companies. Only applicable for commcell and reseller company group.
  [AssociatedExternalGroups <IIdName[]>]: 
    [Id <Int32?>]: 
    [Name <String>]: 
  [AssociatedLocalGroups <IIdName[]>]: 
  [ConsoleType <String[]>]: 
  [ConsoleTypeOperationType <String>]: 
  [EnableTwoFactorAuthentication <String>]: Allows two-factor authentication to be enabled for the specific types of usergroups. it can be turned on or off based on user preferences. There will be usergroups that will not have this option.
  [Enabled <Boolean?>]: allows the enabling/disabling of the user group.
  [EnforceFsQuota <Boolean?>]: determines if a data limit will be set for the user group.
  [ExternalUserGroupsOperationType <String>]: Allows adding, deleting or overwriting associated external user groups of a user group. Default is adding associated external user groups
  [LaptopAdmins <Boolean?>]: When set to true, users in this group cannot activate or be set as server owner
  [LaptopPlanId <Int32?>]: 
  [LaptopPlanName <String>]: 
  [LocalUserGroupsOperationType <String>]: Allows adding, deleting or overwriting associated local user groups of a user group. Default is adding associated local user groups
  [NewDescription <String>]: gives a new description to the user group.
  [NewName <String>]: gives a new name to the user group.
  [PlanOperationType <String>]: determines if an existing user has to be added to the user group or removed from the user group
  [QuotaLimitInGb <Int32?>]: if enforceFSquota is enabled, the quota limit can be provided in GBs
  [UserOperationType <String>]: determines if an existing user has to be added to the user group or removed from the user group
  [Users <IIdName[]>]: 

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
  [EntityType <String>]: Type of the entity
  [GlobalSearchEntity <String>]: name of global search entity
  [HfsShareId <Int32?>]: Id of the HFS Share to fetch its status
  [HyperScaleStorageId <Int32?>]: Id of hyperscale storage
  [HypervisorId <Int32?>]: Id of the HYpervisor to get
  [Id <Int32?>]: 
  [InstanceId <Int32?>]: Id of the instance to modify
  [KmsId <Int32?>]: Id of Key Management Server
  [MediaAgentId <Int32?>]: Id of the Media Agent whose details have to be fetched
  [MetadataCacheId <Int32?>]: Id of metadata cache
  [Name <String>]: 
  [NodeId <Int32?>]: Id of node
  [PairId <Int32?>]: 
  [PlanId <Int32?>]: Id of the plan to fetch details
  [RecoveryTargetId <Int32?>]: id of recovery target
  [RegionId <String>]: 
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

USERS <IIdName[]>: .
  [Id <Int32?>]: 
  [Name <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifyusergroup
#>
function Invoke-ModifyUserGroup {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='ModifyExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Modify', Mandatory)]
    [Parameter(ParameterSetName='ModifyExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # Id of the user-group to update
    ${UserGroupId},

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
    [Commvault.Powershell.Models.IUpdateUserGroup]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # This property can be used to allow addition of users/groups from child companies.
    # Only applicable for commcell and reseller company group.
    ${AllowMultipleCompanyMembers},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # .
    # To construct, see NOTES section for ASSOCIATEDEXTERNALGROUPS properties and create a hash table.
    ${AssociatedExternalGroups},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # .
    # To construct, see NOTES section for ASSOCIATEDLOCALGROUPS properties and create a hash table.
    ${AssociatedLocalGroups},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # .
    ${ConsoleType},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${ConsoleTypeOperationType},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Allows two-factor authentication to be enabled for the specific types of usergroups.
    # it can be turned on or off based on user preferences.
    # There will be usergroups that will not have this option.
    ${EnableTwoFactorAuthentication},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # allows the enabling/disabling of the user group.
    ${Enabled},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # determines if a data limit will be set for the user group.
    ${EnforceFsQuota},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Allows adding, deleting or overwriting associated external user groups of a user group.
    # Default is adding associated external user groups
    ${ExternalUserGroupsOperationType},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # When set to true, users in this group cannot activate or be set as server owner
    ${LaptopAdmins},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${LaptopPlanId},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${LaptopPlanName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Allows adding, deleting or overwriting associated local user groups of a user group.
    # Default is adding associated local user groups
    ${LocalUserGroupsOperationType},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # gives a new description to the user group.
    ${NewDescription},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # gives a new name to the user group.
    ${NewName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # determines if an existing user has to be added to the user group or removed from the user group
    ${PlanOperationType},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # if enforceFSquota is enabled, the quota limit can be provided in GBs
    ${QuotaLimitInGb},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # determines if an existing user has to be added to the user group or removed from the user group
    ${UserOperationType},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # .
    # To construct, see NOTES section for USERS properties and create a hash table.
    ${Users},

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
            Modify = 'CommvaultPowerShell.private\Invoke-ModifyUserGroup_Modify';
            ModifyExpanded = 'CommvaultPowerShell.private\Invoke-ModifyUserGroup_ModifyExpanded';
            ModifyViaIdentity = 'CommvaultPowerShell.private\Invoke-ModifyUserGroup_ModifyViaIdentity';
            ModifyViaIdentityExpanded = 'CommvaultPowerShell.private\Invoke-ModifyUserGroup_ModifyViaIdentityExpanded';
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
