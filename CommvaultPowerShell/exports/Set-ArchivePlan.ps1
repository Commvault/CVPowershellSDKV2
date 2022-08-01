
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
Modify existing archive plan details
.Description
Modify existing archive plan details
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

RPOBACKUPWINDOW <IDayAndTime[]>: Archive job will run only in the specified archive window
  [DayOfWeek <String[]>]: 
  [EndTime <Int64?>]: Time in seconds since the beginning of the day
  [StartTime <Int64?>]: Time in seconds since the beginning of the day
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-archiveplan
#>
function Set-ArchivePlan {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int64]
    # Id of the plan
    ${PlanId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Path')]
    [Commvault.Powershell.Models.ICommvaultPowerShellIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to enable overriding of plan.
    # Once enabled, cannot be disabled.
    ${AllowPlanOverride},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving rules
    ${ArchivingRuleAfterArchiving},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # To archive files based on the size of the file, specify the minimum file size in KB.
    ${ArchivingRuleFileSize},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # To archive files based on the last accessed or modified date of each file within the folder, specify the number of days.
    # Should be supplied with fileTimestampMethod.
    ${ArchivingRuleFileTimestamp},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${ArchivingRuleFileTimestampMethod},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # Frequency of the schedule based on schedule frequency type eg.
    # for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days.
    # for Monthly 2 is it repeats every 2 months
    ${BackupFrequency},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # Day on which to run the schedule, applicable for monthly, yearly
    ${BackupFrequencyDayOfMonth},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${BackupFrequencyDayOfWeek},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${BackupFrequencyMonthOfYear},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # schedule frequency type
    ${BackupFrequencyScheduleFrequencyType},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # start time of schedule in seconds for daily, weekly, monthly, yearly frequency
    ${BackupFrequencyStartTime},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Specific week of a month
    ${BackupFrequencyWeekOfMonth},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Days of the week for weekly frequency
    ${BackupFrequencyWeeklyDays},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # New plan name to update
    ${NewName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionArchivingRules},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionRpo},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionStoragePool},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # .
    ${RegionToConfigureId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${RegionToConfigureName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IDayAndTime[]]
    # Archive job will run only in the specified archive window
    # To construct, see NOTES section for RPOBACKUPWINDOW properties and create a hash table.
    ${RpoBackupWindow},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # Time provided in Unix format.
    # Give 0 to reset any existing delay.
    ${SlaEnableAfterDelay},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to set to exclude plan from SLA
    ${SlaExcludeFromSla},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Reason for exclusion from SLA
    ${SlaExclusionReason},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # SLA Period in Days
    ${SlaPeriod},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to set to use System Default Service Level Agreement
    ${SlaUseSystemDefaultSla},

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
            UpdateExpanded = 'CommvaultPowerShell.private\Set-ArchivePlan_UpdateExpanded';
            UpdateViaIdentityExpanded = 'CommvaultPowerShell.private\Set-ArchivePlan_UpdateViaIdentityExpanded';
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
