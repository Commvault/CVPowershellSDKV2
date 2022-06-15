
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
.Inputs
Commvault.Powershell.Models.IUpdateArchivePlan
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IUpdateArchivePlan>: .
  [AllowPlanOverride <Boolean?>]: Flag to enable overriding of plan. Once enabled, cannot be disabled.
  [ArchivingRuleAfterArchiving <String>]: After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving rules
  [ArchivingRuleFileSize <Int32?>]: To archive files based on the size of the file, specify the minimum file size in KB.
  [ArchivingRuleFileTimestamp <Int32?>]: To archive files based on the last accessed or modified date of each file within the folder, specify the number of days. Should be supplied with fileTimestampMethod.
  [ArchivingRuleFileTimestampMethod <String>]: 
  [BackupFrequency <Int32?>]: Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
  [BackupFrequencyDayOfMonth <Int32?>]: Day on which to run the schedule, applicable for monthly, yearly
  [BackupFrequencyDayOfWeek <String>]: 
  [BackupFrequencyMonthOfYear <String>]: 
  [BackupFrequencyScheduleFrequencyType <String>]: schedule frequency type
  [BackupFrequencyStartTime <Int32?>]: start time of schedule in seconds for daily, weekly, monthly, yearly frequency
  [BackupFrequencyWeekOfMonth <String>]: Specific week of a month
  [BackupFrequencyWeeklyDays <String[]>]: Days of the week for weekly frequency
  [NewName <String>]: New plan name to update
  [OverrideRestrictionArchivingRules <String>]: 
  [OverrideRestrictionRpo <String>]: 
  [OverrideRestrictionStoragePool <String>]: 
  [RegionToConfigureId <Int32?>]: 
  [RegionToConfigureName <String>]: 
  [RpoBackupWindow <IDayAndTime[]>]: Archive job will run only in the specified archive window
    [DayOfWeek <String[]>]: 
    [EndTime <Int64?>]: Time in seconds since the beginning of the day
    [StartTime <Int64?>]: Time in seconds since the beginning of the day
  [SlaEnableAfterDelay <Int32?>]: Time provided in Unix format. Give 0 to reset any existing delay.
  [SlaExcludeFromSla <Boolean?>]: Flag to set to exclude plan from SLA
  [SlaExclusionReason <String>]: Reason for exclusion from SLA
  [SlaPeriod <Int32?>]: SLA Period in Days
  [SlaUseSystemDefaultSla <Boolean?>]: Flag to set to use System Default Service Level Agreement

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

RPOBACKUPWINDOW <IDayAndTime[]>: Archive job will run only in the specified archive window
  [DayOfWeek <String[]>]: 
  [EndTime <Int64?>]: Time in seconds since the beginning of the day
  [StartTime <Int64?>]: Time in seconds since the beginning of the day
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifyarchiveplan
#>
function Invoke-ModifyArchivePlan {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='ModifyExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Modify', Mandatory)]
    [Parameter(ParameterSetName='ModifyExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # Id of the plan
    ${PlanId},

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
    [Commvault.Powershell.Models.IUpdateArchivePlan]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to enable overriding of plan.
    # Once enabled, cannot be disabled.
    ${AllowPlanOverride},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving rules
    ${ArchivingRuleAfterArchiving},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # To archive files based on the size of the file, specify the minimum file size in KB.
    ${ArchivingRuleFileSize},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # To archive files based on the last accessed or modified date of each file within the folder, specify the number of days.
    # Should be supplied with fileTimestampMethod.
    ${ArchivingRuleFileTimestamp},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${ArchivingRuleFileTimestampMethod},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Frequency of the schedule based on schedule frequency type eg.
    # for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days.
    # for Monthly 2 is it repeats every 2 months
    ${BackupFrequency},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Day on which to run the schedule, applicable for monthly, yearly
    ${BackupFrequencyDayOfMonth},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${BackupFrequencyDayOfWeek},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${BackupFrequencyMonthOfYear},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # schedule frequency type
    ${BackupFrequencyScheduleFrequencyType},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # start time of schedule in seconds for daily, weekly, monthly, yearly frequency
    ${BackupFrequencyStartTime},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Specific week of a month
    ${BackupFrequencyWeekOfMonth},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Days of the week for weekly frequency
    ${BackupFrequencyWeeklyDays},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # New plan name to update
    ${NewName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionArchivingRules},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionRpo},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionStoragePool},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${RegionToConfigureId},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${RegionToConfigureName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IDayAndTime[]]
    # Archive job will run only in the specified archive window
    # To construct, see NOTES section for RPOBACKUPWINDOW properties and create a hash table.
    ${RpoBackupWindow},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Time provided in Unix format.
    # Give 0 to reset any existing delay.
    ${SlaEnableAfterDelay},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to set to exclude plan from SLA
    ${SlaExcludeFromSla},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Reason for exclusion from SLA
    ${SlaExclusionReason},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # SLA Period in Days
    ${SlaPeriod},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
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
            Modify = 'CommvaultPowerShell.private\Invoke-ModifyArchivePlan_Modify';
            ModifyExpanded = 'CommvaultPowerShell.private\Invoke-ModifyArchivePlan_ModifyExpanded';
            ModifyViaIdentity = 'CommvaultPowerShell.private\Invoke-ModifyArchivePlan_ModifyViaIdentity';
            ModifyViaIdentityExpanded = 'CommvaultPowerShell.private\Invoke-ModifyArchivePlan_ModifyViaIdentityExpanded';
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
