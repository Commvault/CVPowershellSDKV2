
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
Used to modify an exsiting server plan
.Description
Used to modify an exsiting server plan
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

BACKUPFREQUENCYSCHEDULES <IPlanSchedule[]>: .
  BackupType <String>: Schedule Backup level
  ForDatabasesOnly <Boolean>: Boolean to indicate if schedule is for database agents
  ScheduleOperation <String>: Operation being performed on schedule
  SchedulePatternScheduleFrequencyType <String>: schedule frequency type
  [PolicyId <Int64?>]: Schedule policy Id to which the schedule belongs
  [ScheduleId <Int64?>]: Id of the schedule if available, required for modifying, deleting schedule
  [ScheduleName <String>]: Name of the schedule, for modify
  [SchedulePatternDayOfMonth <Int64?>]: Day on which to run the schedule, applicable for monthly, yearly
  [SchedulePatternDayOfWeek <String>]: 
  [SchedulePatternDaysBetweenSyntheticFulls <Int64?>]: No of days between two synthetic full jobs
  [SchedulePatternEndDate <Int64?>]: Schedule end date in epoch format
  [SchedulePatternExceptions <IScheduleRunException[]>]: Exceptions to when a schedule should not run, either in dates or week of month and days
    [OnDates <Int64[]>]: list of dates in a month. For ex: 1, 20
    [OnDayOfTheWeek <String[]>]: On which days, for ex: MONDAY, FRIDAY
    [OnWeekOfTheMonth <String[]>]: On which week of month, for ex: FIRST, LAST
  [SchedulePatternFrequency <Int64?>]: Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
  [SchedulePatternMonthOfYear <String>]: 
  [SchedulePatternNoOfTimes <Int64?>]: The number of times you want the schedule to run.
  [SchedulePatternRepeatIntervalInMinutes <Int64?>]: How often in minutes in a day the schedule runs, applicable for daily, weekly, monthly and yearly frequency types.
  [SchedulePatternRepeatUntilTime <Int64?>]: Until what time to repeat the schedule in a day, requires repeatIntervalInMinutes
  [SchedulePatternStartDate <Int64?>]: start date of schedule in epoch format
  [SchedulePatternStartTime <Int64?>]: start time of schedule in seconds
  [SchedulePatternWeekOfMonth <String>]: Specific week of a month
  [SchedulePatternWeeklyDays <String[]>]: Days of the week for weekly frequency
  [TimezoneId <Int64?>]: 
  [TimezoneName <String>]: 

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

RPOBACKUPWINDOW <IDayAndTime[]>: Backup window for incremental backup
  [DayOfWeek <String[]>]: 
  [EndTime <Int64?>]: Time in seconds since the beginning of the day
  [StartTime <Int64?>]: Time in seconds since the beginning of the day

RPOFULLBACKUPWINDOW <IDayAndTime[]>: Backup window for full backup
  [DayOfWeek <String[]>]: 
  [EndTime <Int64?>]: Time in seconds since the beginning of the day
  [StartTime <Int64?>]: Time in seconds since the beginning of the day
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-plan
#>
function Set-Plan {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int64]
    # Id of the Plan to update
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
    [System.Management.Automation.SwitchParameter]
    # Do you want to back up the system state Applicable only for Windows
    ${BackupContentBackupSystemState},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Do you want to back up system state only with full backup Applicable only if the value of backupSystemState is true
    ${BackupContentBackupSystemStateOnlyWithFullBackup},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to exclude for Mac
    ${BackupContentMacExcludedPaths},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to include for Mac
    ${BackupContentMacIncludedPaths},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to exclude for UNIX
    ${BackupContentUnixExcludedPaths},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to include for UNIX
    ${BackupContentUnixIncludedPaths},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Do you want to back up system state with VSS Applicable only if the value of backupSystemState is true
    ${BackupContentUseVssForSystemState},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to exclude for Windows
    ${BackupContentWindowsExcludedPaths},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to include for Windows
    ${BackupContentWindowsIncludedPaths},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IPlanSchedule[]]
    # .
    # To construct, see NOTES section for BACKUPFREQUENCYSCHEDULES properties and create a hash table.
    ${BackupFrequencySchedules},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # Commit frequency in hours
    ${DatabaseOptionCommitFrequencyInHours},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # Log backup RPO in minutes
    ${DatabaseOptionLogBackupRpoMins},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # Full backup frequency in days
    ${DatabaseOptionRunFullBackupEvery},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Use disk cache for log backups
    ${DatabaseOptionUseDiskCacheForLogBackups},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # New plan name to update
    ${NewName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to specify if parent or derived plan backupContent should be used when inherit mode is optional.
    # True - derived, False - Base.
    ${OverrideInheritSettingBackupContent},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to specify if parent or derived plan backupDestination should be used when inherit mode is optional.
    # True - derived, False - Base.
    ${OverrideInheritSettingBackupDestination},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to specify if parent or derived plan rpo should be used when inherit mode is optional.
    # True - derived, False - Base.
    ${OverrideInheritSettingRpo},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionBackupContent},

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
    # Backup window for incremental backup
    # To construct, see NOTES section for RPOBACKUPWINDOW properties and create a hash table.
    ${RpoBackupWindow},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IDayAndTime[]]
    # Backup window for full backup
    # To construct, see NOTES section for RPOFULLBACKUPWINDOW properties and create a hash table.
    ${RpoFullBackupWindow},

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
            UpdateExpanded = 'CommvaultPowerShell.private\Set-Plan_UpdateExpanded';
            UpdateViaIdentityExpanded = 'CommvaultPowerShell.private\Set-Plan_UpdateViaIdentityExpanded';
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
