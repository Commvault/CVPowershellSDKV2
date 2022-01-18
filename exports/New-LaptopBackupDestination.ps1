
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
.Inputs
Commvault.Powershell.Models.ICreatePlanBackupDestinations
.Outputs
Commvault.Powershell.Models.IPlanBackupDestinationResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ICreatePlanBackupDestinations>: .
  Destinations <ICreatePlanBackupDestination[]>: List of backup destinations to create
    BackupDestinationName <String>: Backup destination details. Enter the name during creation.
    [BackupStartTime <Int32?>]: Backup start time in seconds. The time is provided in unix time format.
    [BackupsToCopy <String>]: 
    [FirstExtendedRetentionRuleIsInfiniteRetention <Boolean?>]: 
    [FirstExtendedRetentionRuleRetentionPeriodDays <Int32?>]: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
    [FirstExtendedRetentionRuleType <String>]: 
    [IsMirrorCopy <Boolean?>]: Is this a mirror copy? Only considered when isSnapCopy is true.
    [IsSnapCopy <Boolean?>]: Is this a snap copy? If isMirrorCopy is not set, then default is Vault/Replica.
    [Mappings <ISnapshotCopyMapping[]>]: 
      [SourceId <Int32?>]: 
      [SourceName <String>]: 
      [TargetId <Int32?>]: 
      [TargetName <String>]: 
      [Vendor <String>]: Snapshot vendors available for Snap Copy mappings
    [NetAppCloudTarget <Boolean?>]: Only for snap copy. Enabling this changes SVM Mapping  to NetApp cloud targets only.
    [OptimizeForInstantClone <Boolean?>]: Flag to specify if primary storage is copy data management enabled.
    [RegionId <Int32?>]: 
    [RegionName <String>]: 
    [RetentionPeriodDays <Int32?>]: Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified, this takes  precedence.
    [RetentionRuleType <String>]: Which type of retention rule should be used for the given backup destination
    [SecondExtendedRetentionRuleIsInfiniteRetention <Boolean?>]: 
    [SecondExtendedRetentionRuleRetentionPeriodDays <Int32?>]: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
    [SecondExtendedRetentionRuleType <String>]: 
    [SnapRecoveryPoints <Int32?>]: Number of snap recovery points for snap copy for retention. Can be specified instead of retention period in Days for snap copy.
    [SourceCopyId <Int32?>]: 
    [SourceCopyName <String>]: 
    [StoragePoolId <Int32?>]: 
    [StoragePoolName <String>]: 
    [ThirdExtendedRetentionRuleIsInfiniteRetention <Boolean?>]: 
    [ThirdExtendedRetentionRuleRetentionPeriodDays <Int32?>]: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
    [ThirdExtendedRetentionRuleType <String>]: 
    [UseExtendedRetentionRules <Boolean?>]: Use extended retention rules
  [RegionId <Int32?>]: 
  [RegionName <String>]: 
  [SnapshotOptionBackupCopyRpoMins <Int32?>]: Backup copy RPO in minutes
  [SnapshotOptionEnableBackupCopy <Boolean?>]: Flag to enable backup copy
  [SnapshotOptionRetentionPeriodDays <Int32?>]: Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified, this takes precedence.
  [SnapshotOptionSnapRecoveryPoints <Int32?>]: Number of snap recovery points for default snap copy for retention. Can be specified instead of retention period in Days for default snap copy.

DESTINATIONS <ICreatePlanBackupDestination[]>: List of backup destinations to create
  BackupDestinationName <String>: Backup destination details. Enter the name during creation.
  [BackupStartTime <Int32?>]: Backup start time in seconds. The time is provided in unix time format.
  [BackupsToCopy <String>]: 
  [FirstExtendedRetentionRuleIsInfiniteRetention <Boolean?>]: 
  [FirstExtendedRetentionRuleRetentionPeriodDays <Int32?>]: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
  [FirstExtendedRetentionRuleType <String>]: 
  [IsMirrorCopy <Boolean?>]: Is this a mirror copy? Only considered when isSnapCopy is true.
  [IsSnapCopy <Boolean?>]: Is this a snap copy? If isMirrorCopy is not set, then default is Vault/Replica.
  [Mappings <ISnapshotCopyMapping[]>]: 
    [SourceId <Int32?>]: 
    [SourceName <String>]: 
    [TargetId <Int32?>]: 
    [TargetName <String>]: 
    [Vendor <String>]: Snapshot vendors available for Snap Copy mappings
  [NetAppCloudTarget <Boolean?>]: Only for snap copy. Enabling this changes SVM Mapping  to NetApp cloud targets only.
  [OptimizeForInstantClone <Boolean?>]: Flag to specify if primary storage is copy data management enabled.
  [RegionId <Int32?>]: 
  [RegionName <String>]: 
  [RetentionPeriodDays <Int32?>]: Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified, this takes  precedence.
  [RetentionRuleType <String>]: Which type of retention rule should be used for the given backup destination
  [SecondExtendedRetentionRuleIsInfiniteRetention <Boolean?>]: 
  [SecondExtendedRetentionRuleRetentionPeriodDays <Int32?>]: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
  [SecondExtendedRetentionRuleType <String>]: 
  [SnapRecoveryPoints <Int32?>]: Number of snap recovery points for snap copy for retention. Can be specified instead of retention period in Days for snap copy.
  [SourceCopyId <Int32?>]: 
  [SourceCopyName <String>]: 
  [StoragePoolId <Int32?>]: 
  [StoragePoolName <String>]: 
  [ThirdExtendedRetentionRuleIsInfiniteRetention <Boolean?>]: 
  [ThirdExtendedRetentionRuleRetentionPeriodDays <Int32?>]: Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
  [ThirdExtendedRetentionRuleType <String>]: 
  [UseExtendedRetentionRules <Boolean?>]: Use extended retention rules

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
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-laptopbackupdestination
#>
function New-LaptopBackupDestination {
[OutputType([Commvault.Powershell.Models.IPlanBackupDestinationResp])]
[CmdletBinding(DefaultParameterSetName='Create', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory)]
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # Id of the Plan to modify
    ${PlanId},

    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Path')]
    [Commvault.Powershell.Models.ICommvaultPowerShellIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ICreatePlanBackupDestinations]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ICreatePlanBackupDestination[]]
    # List of backup destinations to create
    # To construct, see NOTES section for DESTINATIONS properties and create a hash table.
    ${Destinations},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${RegionId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${RegionName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Backup copy RPO in minutes
    ${SnapshotOptionBackupCopyRpoMins},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to enable backup copy
    ${SnapshotOptionEnableBackupCopy},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Retention period in days.
    # -1 can be specified for infinite retention.
    # If this and snapRecoveryPoints both are not specified, this takes precedence.
    ${SnapshotOptionRetentionPeriodDays},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
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
            Create = 'CommvaultPowerShell.private\New-LaptopBackupDestination_Create';
            CreateExpanded = 'CommvaultPowerShell.private\New-LaptopBackupDestination_CreateExpanded';
            CreateViaIdentity = 'CommvaultPowerShell.private\New-LaptopBackupDestination_CreateViaIdentity';
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
