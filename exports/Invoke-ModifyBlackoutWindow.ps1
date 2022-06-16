
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
Modify the properties of an existing Blackout Window
.Description
Modify the properties of an existing Blackout Window
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICommvaultPowerShellIdentity
.Inputs
Commvault.Powershell.Models.IUpdateBlackoutWindow
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IUpdateBlackoutWindow>: company-refers to company to which the blackout window is associated.Dates have to be provided in unix time format.
  [BackupOperations <String[]>]: Refers to backup types to include in the blackout window
  [BetweenDateEnd <Int64?>]: the blackout window is no longer in effect from this point on.
  [BetweenDateStart <Int64?>]: the blackout window comes into effect at this point.
  [CompanyId <Int32?>]: 
  [CompanyName <String>]: 
  [Days <String[]>]: Days of the week when the blackout window will be in effect.
  [DoNotSubmitJob <Boolean?>]: Allows or Denies submitting a job when the blackout window is in effect. If allowed, the job is submitted and resumed once the blackout window ends.
  [NewName <String>]: Refers to the newName given to the blackout Window.
  [Time <IStartEnd[]>]: Refers to the time between which the blackout window will be in effect. It has to be provided in seconds
    [End <Int64?>]: the blackout window is no longer in effect from this point on.
    [Start <Int64?>]: the blackout window comes into effect at this point.
  [Weeks <String[]>]: Refers to the weeks of the month that the blackout window will be in effect.

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

TIME <IStartEnd[]>: Refers to the time between which the blackout window will be in effect. It has to be provided in seconds
  [End <Int64?>]: the blackout window is no longer in effect from this point on.
  [Start <Int64?>]: the blackout window comes into effect at this point.
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifyblackoutwindow
#>
function Invoke-ModifyBlackoutWindow {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='ModifyExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Modify', Mandatory)]
    [Parameter(ParameterSetName='ModifyExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # Id of the Blackout Window to update
    ${BlackoutWindowId},

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
    [Commvault.Powershell.Models.IUpdateBlackoutWindow]
    # company-refers to company to which the blackout window is associated.Dates have to be provided in unix time format.
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Refers to backup types to include in the blackout window
    ${BackupOperations},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # the blackout window is no longer in effect from this point on.
    ${BetweenDateEnd},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # the blackout window comes into effect at this point.
    ${BetweenDateStart},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${CompanyId},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${CompanyName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Days of the week when the blackout window will be in effect.
    ${Days},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Allows or Denies submitting a job when the blackout window is in effect.
    # If allowed, the job is submitted and resumed once the blackout window ends.
    ${DoNotSubmitJob},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Refers to the newName given to the blackout Window.
    ${NewName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IStartEnd[]]
    # Refers to the time between which the blackout window will be in effect.
    # It has to be provided in seconds
    # To construct, see NOTES section for TIME properties and create a hash table.
    ${Time},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Refers to the weeks of the month that the blackout window will be in effect.
    ${Weeks},

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
            Modify = 'CommvaultPowerShell.private\Invoke-ModifyBlackoutWindow_Modify';
            ModifyExpanded = 'CommvaultPowerShell.private\Invoke-ModifyBlackoutWindow_ModifyExpanded';
            ModifyViaIdentity = 'CommvaultPowerShell.private\Invoke-ModifyBlackoutWindow_ModifyViaIdentity';
            ModifyViaIdentityExpanded = 'CommvaultPowerShell.private\Invoke-ModifyBlackoutWindow_ModifyViaIdentityExpanded';
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
