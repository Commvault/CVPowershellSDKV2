
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
.Inputs
Commvault.Powershell.Models.IUpdateServerPlan
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
  [PolicyId <Int32?>]: Schedule policy Id to which the schedule belongs
  [ScheduleId <Int32?>]: Id of the schedule if available, required for modifying, deleting schedule
  [ScheduleName <String>]: Name of the schedule, for modify
  [SchedulePatternDayOfMonth <Int32?>]: Day on which to run the schedule, applicable for monthly, yearly
  [SchedulePatternDayOfWeek <String>]: 
  [SchedulePatternDaysBetweenSyntheticFulls <Int32?>]: No of days between two synthetic full jobs
  [SchedulePatternEndDate <Int32?>]: Schedule end date in epoch format
  [SchedulePatternExceptions <IScheduleRunException[]>]: Exceptions to when a schedule should not run, either in dates or week of month and days
    [OnDates <Int32[]>]: list of dates in a month. For ex: 1, 20
    [OnDayOfTheWeek <String[]>]: On which days, for ex: MONDAY, FRIDAY
    [OnWeekOfTheMonth <String[]>]: On which week of month, for ex: FIRST, LAST
  [SchedulePatternFrequency <Int32?>]: Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
  [SchedulePatternMonthOfYear <String>]: 
  [SchedulePatternNoOfTimes <Int32?>]: The number of times you want the schedule to run.
  [SchedulePatternRepeatIntervalInMinutes <Int32?>]: How often in minutes in a day the schedule runs, applicable for daily, weekly, monthly and yearly frequency types.
  [SchedulePatternRepeatUntilTime <Int32?>]: Until what time to repeat the schedule in a day, requires repeatIntervalInMinutes
  [SchedulePatternStartDate <Int32?>]: start date of schedule in epoch format
  [SchedulePatternStartTime <Int32?>]: start time of schedule in seconds
  [SchedulePatternWeekOfMonth <String>]: Specific week of a month
  [SchedulePatternWeeklyDays <String[]>]: Days of the week for weekly frequency
  [TimezoneId <Int32?>]: 
  [TimezoneName <String>]: 

BODY <IUpdateServerPlan>: .
  [AllowPlanOverride <Boolean?>]: Flag to enable overriding of plan. Once enabled, cannot be disabled.
  [BackupContentBackupSystemState <Boolean?>]: Do you want to back up the system state? Applicable only for Windows
  [BackupContentBackupSystemStateOnlyWithFullBackup <Boolean?>]: Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true
  [BackupContentMacExcludedPaths <String[]>]: Paths to exclude for Mac
  [BackupContentMacIncludedPaths <String[]>]: Paths to include for Mac
  [BackupContentUnixExcludedPaths <String[]>]: Paths to exclude for UNIX
  [BackupContentUnixIncludedPaths <String[]>]: Paths to include for UNIX
  [BackupContentUseVssForSystemState <Boolean?>]: Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true
  [BackupContentWindowsExcludedPaths <String[]>]: Paths to exclude for Windows
  [BackupContentWindowsIncludedPaths <String[]>]: Paths to include for Windows
  [BackupFrequencySchedules <IPlanSchedule[]>]: 
    BackupType <String>: Schedule Backup level
    ForDatabasesOnly <Boolean>: Boolean to indicate if schedule is for database agents
    ScheduleOperation <String>: Operation being performed on schedule
    SchedulePatternScheduleFrequencyType <String>: schedule frequency type
    [PolicyId <Int32?>]: Schedule policy Id to which the schedule belongs
    [ScheduleId <Int32?>]: Id of the schedule if available, required for modifying, deleting schedule
    [ScheduleName <String>]: Name of the schedule, for modify
    [SchedulePatternDayOfMonth <Int32?>]: Day on which to run the schedule, applicable for monthly, yearly
    [SchedulePatternDayOfWeek <String>]: 
    [SchedulePatternDaysBetweenSyntheticFulls <Int32?>]: No of days between two synthetic full jobs
    [SchedulePatternEndDate <Int32?>]: Schedule end date in epoch format
    [SchedulePatternExceptions <IScheduleRunException[]>]: Exceptions to when a schedule should not run, either in dates or week of month and days
      [OnDates <Int32[]>]: list of dates in a month. For ex: 1, 20
      [OnDayOfTheWeek <String[]>]: On which days, for ex: MONDAY, FRIDAY
      [OnWeekOfTheMonth <String[]>]: On which week of month, for ex: FIRST, LAST
    [SchedulePatternFrequency <Int32?>]: Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
    [SchedulePatternMonthOfYear <String>]: 
    [SchedulePatternNoOfTimes <Int32?>]: The number of times you want the schedule to run.
    [SchedulePatternRepeatIntervalInMinutes <Int32?>]: How often in minutes in a day the schedule runs, applicable for daily, weekly, monthly and yearly frequency types.
    [SchedulePatternRepeatUntilTime <Int32?>]: Until what time to repeat the schedule in a day, requires repeatIntervalInMinutes
    [SchedulePatternStartDate <Int32?>]: start date of schedule in epoch format
    [SchedulePatternStartTime <Int32?>]: start time of schedule in seconds
    [SchedulePatternWeekOfMonth <String>]: Specific week of a month
    [SchedulePatternWeeklyDays <String[]>]: Days of the week for weekly frequency
    [TimezoneId <Int32?>]: 
    [TimezoneName <String>]: 
  [DatabaseOptionCommitFrequencyInHours <Int32?>]: Commit frequency in hours
  [DatabaseOptionLogBackupRpoMins <Int32?>]: Log backup RPO in minutes
  [DatabaseOptionRunFullBackupEvery <Int32?>]: Full backup frequency in days
  [DatabaseOptionUseDiskCacheForLogBackups <Boolean?>]: Use disk cache for log backups
  [NewName <String>]: New plan name to update
  [OverrideInheritSettingBackupContent <Boolean?>]: Flag to specify if parent or derived plan backupContent should be used when inherit mode is optional. True - derived, False - Base.
  [OverrideInheritSettingBackupDestination <Boolean?>]: Flag to specify if parent or derived plan backupDestination should be used when inherit mode is optional. True - derived, False - Base.
  [OverrideInheritSettingRpo <Boolean?>]: Flag to specify if parent or derived plan rpo should be used when inherit mode is optional. True - derived, False - Base.
  [OverrideRestrictionBackupContent <String>]: 
  [OverrideRestrictionRpo <String>]: 
  [OverrideRestrictionStoragePool <String>]: 
  [RegionToConfigureId <Int32?>]: 
  [RegionToConfigureName <String>]: 
  [RpoBackupWindow <IDayAndTime[]>]: Backup window for incremental backup
    [DayOfWeek <String[]>]: 
    [EndTime <Int64?>]: Time in seconds since the beginning of the day
    [StartTime <Int64?>]: Time in seconds since the beginning of the day
  [RpoFullBackupWindow <IDayAndTime[]>]: Backup window for full backup
  [SlaEnableAfterDelay <Int32?>]: Time provided in Unix format. Give 0 to reset any existing delay.
  [SlaExcludeFromSla <Boolean?>]: Flag to set to exclude plan from SLA
  [SlaExclusionReason <String>]: Reason for exclusion from SLA
  [SlaPeriod <Int32?>]: SLA Period in Days
  [SlaUseSystemDefaultSla <Boolean?>]: Flag to set to use System Default Service Level Agreement
  [SnapshotOptionBackupCopyRpoMins <Int32?>]: Backup copy RPO in minutes
  [SnapshotOptionEnableBackupCopy <Boolean?>]: Flag to enable backup copy

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

RPOBACKUPWINDOW <IDayAndTime[]>: Backup window for incremental backup
  [DayOfWeek <String[]>]: 
  [EndTime <Int64?>]: Time in seconds since the beginning of the day
  [StartTime <Int64?>]: Time in seconds since the beginning of the day

RPOFULLBACKUPWINDOW <IDayAndTime[]>: Backup window for full backup
  [DayOfWeek <String[]>]: 
  [EndTime <Int64?>]: Time in seconds since the beginning of the day
  [StartTime <Int64?>]: Time in seconds since the beginning of the day
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifyplan
#>
function Invoke-ModifyPlan {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='ModifyExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Modify', Mandatory)]
    [Parameter(ParameterSetName='ModifyExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # Id of the Plan to update
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
    [Commvault.Powershell.Models.IUpdateServerPlan]
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
    [System.Management.Automation.SwitchParameter]
    # Do you want to back up the system state Applicable only for Windows
    ${BackupContentBackupSystemState},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Do you want to back up system state only with full backup Applicable only if the value of backupSystemState is true
    ${BackupContentBackupSystemStateOnlyWithFullBackup},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to exclude for Mac
    ${BackupContentMacExcludedPaths},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to include for Mac
    ${BackupContentMacIncludedPaths},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to exclude for UNIX
    ${BackupContentUnixExcludedPaths},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to include for UNIX
    ${BackupContentUnixIncludedPaths},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Do you want to back up system state with VSS Applicable only if the value of backupSystemState is true
    ${BackupContentUseVssForSystemState},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to exclude for Windows
    ${BackupContentWindowsExcludedPaths},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Paths to include for Windows
    ${BackupContentWindowsIncludedPaths},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IPlanSchedule[]]
    # .
    # To construct, see NOTES section for BACKUPFREQUENCYSCHEDULES properties and create a hash table.
    ${BackupFrequencySchedules},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Commit frequency in hours
    ${DatabaseOptionCommitFrequencyInHours},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Log backup RPO in minutes
    ${DatabaseOptionLogBackupRpoMins},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Full backup frequency in days
    ${DatabaseOptionRunFullBackupEvery},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Use disk cache for log backups
    ${DatabaseOptionUseDiskCacheForLogBackups},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # New plan name to update
    ${NewName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to specify if parent or derived plan backupContent should be used when inherit mode is optional.
    # True - derived, False - Base.
    ${OverrideInheritSettingBackupContent},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to specify if parent or derived plan backupDestination should be used when inherit mode is optional.
    # True - derived, False - Base.
    ${OverrideInheritSettingBackupDestination},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to specify if parent or derived plan rpo should be used when inherit mode is optional.
    # True - derived, False - Base.
    ${OverrideInheritSettingRpo},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionBackupContent},

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
    # Backup window for incremental backup
    # To construct, see NOTES section for RPOBACKUPWINDOW properties and create a hash table.
    ${RpoBackupWindow},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IDayAndTime[]]
    # Backup window for full backup
    # To construct, see NOTES section for RPOFULLBACKUPWINDOW properties and create a hash table.
    ${RpoFullBackupWindow},

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

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Backup copy RPO in minutes
    ${SnapshotOptionBackupCopyRpoMins},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
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
            Modify = 'CommvaultPowerShell.private\Invoke-ModifyPlan_Modify';
            ModifyExpanded = 'CommvaultPowerShell.private\Invoke-ModifyPlan_ModifyExpanded';
            ModifyViaIdentity = 'CommvaultPowerShell.private\Invoke-ModifyPlan_ModifyViaIdentity';
            ModifyViaIdentityExpanded = 'CommvaultPowerShell.private\Invoke-ModifyPlan_ModifyViaIdentityExpanded';
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
