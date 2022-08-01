
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
Create a Server Plan
.Description
Create a Server Plan
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Commvault.Powershell.Models.IPlanResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BACKUPDESTINATIONS <ICreatePlanBackupDestination[]>: Backup destinations for the plan. Specify where you want to store your backup data.
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

RPOBACKUPWINDOW <IDayAndTime[]>: Backup window for incremental backup
  [DayOfWeek <String[]>]: 
  [EndTime <Int64?>]: Time in seconds since the beginning of the day
  [StartTime <Int64?>]: Time in seconds since the beginning of the day

RPOFULLBACKUPWINDOW <IDayAndTime[]>: Backup window for full backup
  [DayOfWeek <String[]>]: 
  [EndTime <Int64?>]: Time in seconds since the beginning of the day
  [StartTime <Int64?>]: Time in seconds since the beginning of the day
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-serverplan
#>
function New-ServerPlan {
[OutputType([Commvault.Powershell.Models.IPlanResp])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ICreatePlanBackupDestination[]]
    # Backup destinations for the plan.
    # Specify where you want to store your backup data.
    # To construct, see NOTES section for BACKUPDESTINATIONS properties and create a hash table.
    ${BackupDestinations},

    [Parameter(Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Name of the new plan
    ${PlanName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to enable overriding of plan.
    # Plan cannot be overriden by default.
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
    [System.Management.Automation.SwitchParameter]
    # Use disk cache for log backups
    ${DatabaseOptionUseDiskCacheForLogBackups},

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
    ${ParentPlanId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${ParentPlanName},

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
            CreateExpanded = 'CommvaultPowerShell.private\New-ServerPlan_CreateExpanded';
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
