
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
Api to set region for an entity.
.Description
Api to set region for an entity.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICommvaultPowerShellIdentity
.Inputs
Commvault.Powershell.Models.IEntityRegionInfo
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IEntityRegionInfo>: .
  [EntityRegionType <String>]: 
  [RegionId <Int64?>]: 
  [RegionName <String>]: 

INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
  [AccessPathId <Int64?>]: Id of the mount path whose access path has to be deleted
  [AgentId <Int64?>]: Id of the agent to be modified
  [BackupDestinationId <Int64?>]: Id of the backupDestination to be modified
  [BackupLocationId <Int64?>]: Id of the backup location whose details have to be fetched
  [BlackoutWindowId <Int64?>]: Id of the Blackout Window whose details have to be fetched
  [BucketId <Int64?>]: Id of Bucket
  [CloudStorageId <Int64?>]: Id of cloud Storage
  [CompanyId <Int64?>]: Id of the Company whose details have to be fetched
  [CredentialName <String>]: 
  [DomainId <Int64?>]: ID of the AD/LDAP domain
  [EntityId <Int64?>]: Unique id for the entity
  [EntityType <Int64?>]: Type of the entity
  [GlobalSearchEntity <String>]: name of global search entity
  [HfsShareId <Int64?>]: Id of the HFS Share to fetch its status
  [HyperScaleStorageId <Int64?>]: Id of hyperscale storage
  [HypervisorId <Int64?>]: Id of the Hypervisor to update
  [Id <Int64?>]: 
  [InstanceId <Int64?>]: Id of the instance to modify
  [InventoryEntityName <String>]: Name of the inventory entity that needs to be browsed like ESX Host name in VCenter
  [KmsId <Int64?>]: Id of Key Management Server
  [MediaAgentId <Int64?>]: Id of the Media Agent whose details have to be fetched
  [MetadataCacheId <Int64?>]: Id of metadata cache
  [Name <String>]: 
  [NodeId <Int64?>]: Id of node
  [PairId <Int64?>]: 
  [PlanId <Int64?>]: Id of the plan to fetch details
  [RecoveryTargetId <Int64?>]: id of recovery target
  [RegionId <Int64?>]: 
  [RegionList <String>]: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  [ReplicationGroupId <String>]: 
  [RequestId <Int64?>]: Unique identifier for the request
  [RoleId <Int64?>]: Role Id
  [RpsId <String>]: 
  [RuleId <Int64?>]: Id of the rule to update in Plan
  [ScheduleId <String>]: 
  [SchedulePolicyId <String>]: 
  [ServerGroupId <Int64?>]: Id of the serverGroupId whose details have to be fetched
  [ServerId <Int64?>]: Id of the server to modify
  [StoragePoolId <Int64?>]: Id of the disk storage pool whose details have to be fetched
  [SubclientId <Int64?>]: Id of the subclient to modify
  [TopologyId <String>]: 
  [UserGroupId <Int64?>]: Id of the user-group whose details have to be fetched
  [UserId <Int64?>]: Id of the User whose details have to be fetched
  [VMGroupId <Int64?>]: Id of the VMgroup to update
  [VMUuid <String>]: The vmUUID can be obtained from GET /virtualMachines UUID property
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-region
#>
function Set-Region {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Set', Mandatory)]
    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int64]
    # Unique id for the entity
    ${EntityId},

    [Parameter(ParameterSetName='Set', Mandatory)]
    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int64]
    # Type of the entity
    ${EntityType},

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int64]
    # .
    ${RegionId},

    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Path')]
    [Commvault.Powershell.Models.ICommvaultPowerShellIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Set', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IEntityRegionInfo]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${EntityRegionType},

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${RegionName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Name of city for the location
    ${LocationCity},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Name of continent for the location
    ${LocationContinent},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Name of country for the location
    ${LocationCountry},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Double]
    # Latitude for the location
    ${LocationLatitude},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Double]
    # Longitude for the location
    ${LocationLongitude},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Name of state for the location
    ${LocationState},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Type of operation to be performed for locations
    ${LocationsOperationType},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # New name for the region
    ${NewName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # .
    ${ZoneId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${ZoneName},

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
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Set = 'CommvaultPowerShell.private\Set-Region_Set';
            SetExpanded = 'CommvaultPowerShell.private\Set-Region_SetExpanded';
            SetViaIdentity = 'CommvaultPowerShell.private\Set-Region_SetViaIdentity';
            SetViaIdentityExpanded = 'CommvaultPowerShell.private\Set-Region_SetViaIdentityExpanded';
            UpdateExpanded = 'CommvaultPowerShell.private\Set-Region_UpdateExpanded';
            UpdateViaIdentityExpanded = 'CommvaultPowerShell.private\Set-Region_UpdateViaIdentityExpanded';
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