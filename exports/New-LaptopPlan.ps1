
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
Create Laptop Plan
.Description
Create Laptop Plan
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Commvault.Powershell.Models.IGenericResp
.Outputs
Commvault.Powershell.Models.IPlanResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ALERTS <IIdName[]>: .
  [Id <Int32?>]: 
  [Name <String>]: 

ALLOWEDFEATURES <ILaptopPlanAllowedFeatures>: Create/modify allowed features of laptop plan
  [Archiving <Boolean?>]: Flag to enable archiving of laptop data
  [ArchivingRuleAfterArchiving <String>]: After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving rules
  [ArchivingRuleArchiveReadOnlyFiles <Boolean?>]: To archive files based on the Read-Only attribute, set to TRUE
  [ArchivingRuleFileAccessTimeOlderThan <Int32?>]: To archive files based on the last accessed date of each file within the folder, specify the number of days
  [ArchivingRuleFileCreatedTimeOlderThan <Int32?>]: To archive files based on the time the files were created within the folder, specify the number of days
  [ArchivingRuleFileModifiedTimeOlderThan <Int32?>]: To archive files based on the last modified date of each file within the folder, specify the number of days
  [ArchivingRuleFileSizeGreaterThan <Int32?>]: To archive files based on the size of the file, specify the minimum file size in KB. All files whose size ranges between the minimum and maximum values are archived.
  [ArchivingRuleMaximumFileSize <Int32?>]: To archive files based on the size of the file, specify the maximum file size in KB. All files whose size ranges between the minimum and maximum values are archived.
  [ArchivingRuleStartCleaningIfLessThan <Int32?>]: When free disk space falls below specified amount (in percentage), start cleaning up the disk
  [ArchivingRuleStopCleaningIfupto <Int32?>]: When free disk space more than specified amount (in percentage), stop cleaning up the disk
  [ClientId <Int32?>]: 
  [ClientName <String>]: 
  [Dlp <Boolean?>]: Flag to enable Data loss protection
  [EdgeDrive <Boolean?>]: Flag to enable Edge Drive
  [EdgeDriveSettingAuditDriveOperations <Boolean?>]: Enable auditing which logs the activities based on user interaction like creating, editing, moving, renaming, downloading or deleting files.
  [EdgeDriveSettingCreateNewIndexServer <Boolean?>]: If set to false, uses existing edge index server and requires IndexServer IdName to be passed. If set to true, requires client IdName and indexCachePath to create a new Index Server.
  [EdgeDriveSettingEdgeDriveQuota <Int32?>]: Maximum number of gigabytes that you can store in the Edge Drive. Giving value as -1 means no quota.
  [EdgeDriveSettingIndexCachePath <String>]: 
  [EdgeDriveSettingNotificationsForShares <Boolean?>]: Enables alert notification feature which allows the share user or share owner to subscribe for share notifications when any activities are performed on the Edge Drive or the Collaborative share. The user can receive the notifications on the Web Console or as an email notification.
  [IndexServerId <Int32?>]: 
  [IndexServerName <String>]: 

INVITEUSERSORGROUPS <IPlanUserOrGroups[]>: The users and user groups who should install the end-user Endpoint package on their devices.
  [Id <Int32?>]: This gives Id of user or user group or external user group
  [Name <String>]: This gives name of user or user group or external user group
  [SendInvite <Boolean?>]: If set to true, will send an invite email to the user or group. Default is true.
  [Type <String>]: Tells what kind of user or user group it is
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-laptopplan
#>
function New-LaptopPlan {
[OutputType([Commvault.Powershell.Models.IPlanResp], [Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${PlanName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # .
    # To construct, see NOTES section for ALERTS properties and create a hash table.
    ${Alerts},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to enable overriding of plan.
    # Plan cannot be overriden by default.
    ${AllowPlanOverride},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ILaptopPlanAllowedFeatures]
    # Create/modify allowed features of laptop plan
    # To construct, see NOTES section for ALLOWEDFEATURES properties and create a hash table.
    ${AllowedFeatures},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Maximum number of gigabytes that you can store in the File System.
    # Giving value as -1 means infinite file system quota.
    ${BackupContentFileSystemQuota},

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
    [System.Int32]
    # Custom version rule: Retain daily versions for this many day(s)
    ${FileVersionDailyVersions},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Retain files for this many days.
    # Year(s) or month(s) need to be converted to day(s)
    ${FileVersionDays},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Custom version rule: Retain monthly versions for this many month(s)
    ${FileVersionMonthlyVersions},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Retain this many file versions.
    # This is considered as default if no file retention rule is specified.
    ${FileVersionVersions},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Custom version rule: Retain weekly versions for this many week(s)
    ${FileVersionWeeklyVersions},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IPlanUserOrGroups[]]
    # The users and user groups who should install the end-user Endpoint package on their devices.
    # To construct, see NOTES section for INVITEUSERSORGROUPS properties and create a hash table.
    ${InviteUsersOrGroups},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Maximum kilobits per second to throttle the receiving speed of data.
    # Giving value as -1 means infinite throttle send speed i.e.
    # no limit
    ${NetworkResourceThrottleReceive},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Maximum kilobits per second to throttle the emitting speed of data.
    # Giving value as -1 means infinite throttle send speed i.e.
    # no limit
    ${NetworkResourceThrottleSend},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionBackupContent},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OverrideRestrictionRetention},

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
    [System.Int32]
    # .
    ${ParentPlanId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${ParentPlanName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${PrimaryStorageId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${PrimaryStorageName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Amount of days after deletion of files to keep the items.
    # Giving value as -1 means to retain files indefinitely.
    ${RetentionDeletedItemRetention},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${SecondaryStorageId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${SecondaryStorageName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Recovery Point Objective (RPO) is the maximum amount of time that data can be lost during a service disruption.
    # Your RPO determines the frequency of your backup jobs.
    # Your RPO is met through automatic options.
    # The time specified in minutes here is your RPO if none of the automatic options are met.
    # Default is 480 minutes (8 hours).
    ${StorageAndScheduleBackupFrequency},

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
            CreateExpanded = 'CommvaultPowerShell.private\New-LaptopPlan_CreateExpanded';
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
