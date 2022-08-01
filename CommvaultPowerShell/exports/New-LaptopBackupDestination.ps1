
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
Create a Backup Destination for a Plan
.Description
Create a Backup Destination for a Plan
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICommvaultPowerShellIdentity
.Outputs
Commvault.Powershell.Models.IPlanBackupDestinationResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

DESTINATIONS <ICreatePlanBackupDestination[]>: List of backup destinations to create
  BackupDestinationName <String>: Backup destination details. Enter the name during creation.
  [BackupStartTime <Int64?>]: Backup start time in seconds. The time is provided in unix time format.
  [BackupsToCopy <String>]: 
  [FirstExtendedRetentionRuleIsInfiniteRetention <Boolean?>]: 
  [FirstExtendedRetentionRuleRetentionPeriodDays <Int64?>]: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
  [FirstExtendedRetentionRuleType <String>]: 
  [IsMirrorCopy <Boolean?>]: Is this a mirror copy? Only considered when isSnapCopy is true.
  [IsSnapCopy <Boolean?>]: Is this a snap copy? If isMirrorCopy is not set, then default is Vault/Replica.
  [Mappings <ISnapshotCopyMapping[]>]: 
    [SourceId <Int64?>]: 
    [SourceName <String>]: 
    [TargetId <Int64?>]: 
    [TargetName <String>]: 
    [Vendor <String>]: Snapshot vendors available for Snap Copy mappings
  [NetAppCloudTarget <Boolean?>]: Only for snap copy. Enabling this changes SVM Mapping  to NetApp cloud targets only.
  [OptimizeForInstantClone <Boolean?>]: Flag to specify if primary storage is copy data management enabled.
  [RegionId <Int64?>]: 
  [RegionName <String>]: 
  [RetentionPeriodDays <Int64?>]: Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified, this takes  precedence.
  [RetentionRuleType <String>]: Which type of retention rule should be used for the given backup destination
  [SecondExtendedRetentionRuleIsInfiniteRetention <Boolean?>]: 
  [SecondExtendedRetentionRuleRetentionPeriodDays <Int64?>]: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
  [SecondExtendedRetentionRuleType <String>]: 
  [SnapRecoveryPoints <Int64?>]: Number of snap recovery points for snap copy for retention. Can be specified instead of retention period in Days for snap copy.
  [SourceCopyId <Int64?>]: 
  [SourceCopyName <String>]: 
  [StoragePoolId <Int64?>]: 
  [StoragePoolName <String>]: 
  [ThirdExtendedRetentionRuleIsInfiniteRetention <Boolean?>]: 
  [ThirdExtendedRetentionRuleRetentionPeriodDays <Int64?>]: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
  [ThirdExtendedRetentionRuleType <String>]: 
  [UseExtendedRetentionRules <Boolean?>]: Use extended retention rules

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
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-laptopbackupdestination
#>
function New-LaptopBackupDestination {
[OutputType([Commvault.Powershell.Models.IPlanBackupDestinationResp])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int64]
    # Id of the Plan to modify
    ${PlanId},

    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Path')]
    [Commvault.Powershell.Models.ICommvaultPowerShellIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ICreatePlanBackupDestination[]]
    # List of backup destinations to create
    # To construct, see NOTES section for DESTINATIONS properties and create a hash table.
    ${Destinations},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # .
    ${RegionId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${RegionName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # Backup copy RPO in minutes
    ${SnapshotOptionBackupCopyRpoMins},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to enable backup copy
    ${SnapshotOptionEnableBackupCopy},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # Retention period in days.
    # -1 can be specified for infinite retention.
    # If this and snapRecoveryPoints both are not specified, this takes precedence.
    ${SnapshotOptionRetentionPeriodDays},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # Number of snap recovery points for default snap copy for retention.
    # Can be specified instead of retention period in Days for default snap copy.
    ${SnapshotOptionSnapRecoveryPoints},

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
            CreateExpanded = 'CommvaultPowerShell.private\New-LaptopBackupDestination_CreateExpanded';
            CreateViaIdentityExpanded = 'CommvaultPowerShell.private\New-LaptopBackupDestination_CreateViaIdentityExpanded';
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
