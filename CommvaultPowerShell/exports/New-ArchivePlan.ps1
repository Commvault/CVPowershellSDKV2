
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
Create Archive Plan
.Description
Create Archive Plan
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

BACKUPDESTINATIONS <ICreateArchivePlanBackupDestination[]>: .
  BackupDestinationName <String>: Backup destination details. Enter the name during creation.
  [BackupStartTime <Int64?>]: Backup start time in seconds. The time is provided in unix time format.
  [RegionId <Int64?>]: 
  [RegionName <String>]: 
  [RetentionPeriodDays <Int64?>]: Retention period in days. -1 can be specified for infinite retention.
  [SourceCopyId <Int64?>]: 
  [SourceCopyName <String>]: 
  [StoragePoolId <Int64?>]: 
  [StoragePoolName <String>]: 

RPOARCHIVEWINDOW <IDayAndTime[]>: Archive job will run only in the specified archive window
  [DayOfWeek <String[]>]: 
  [EndTime <Int64?>]: Time in seconds since the beginning of the day
  [StartTime <Int64?>]: Time in seconds since the beginning of the day
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-archiveplan
#>
function New-ArchivePlan {
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
    [System.Management.Automation.SwitchParameter]
    # Flag to enable overriding of plan.
    # Plan cannot be overriden by default.
    ${AllowPlanOverride},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # Frequency of the schedule based on schedule frequency type eg.
    # for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days.
    # for Monthly 2 is it repeats every 2 months
    ${ArchiveFrequency},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # Day on which to run the schedule, applicable for monthly, yearly
    ${ArchiveFrequencyDayOfMonth},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${ArchiveFrequencyDayOfWeek},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${ArchiveFrequencyMonthOfYear},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # schedule frequency type
    ${ArchiveFrequencyScheduleFrequencyType},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # start time of schedule in seconds for daily, weekly, monthly, yearly frequency
    ${ArchiveFrequencyStartTime},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Specific week of a month
    ${ArchiveFrequencyWeekOfMonth},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Days of the week for weekly frequency
    ${ArchiveFrequencyWeeklyDays},

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
    [Commvault.Powershell.Models.ICreateArchivePlanBackupDestination[]]
    # .
    # To construct, see NOTES section for BACKUPDESTINATIONS properties and create a hash table.
    ${BackupDestinations},

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
    ${ParentPlanId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${ParentPlanName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IDayAndTime[]]
    # Archive job will run only in the specified archive window
    # To construct, see NOTES section for RPOARCHIVEWINDOW properties and create a hash table.
    ${RpoArchiveWindow},

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
            CreateExpanded = 'CommvaultPowerShell.private\New-ArchivePlan_CreateExpanded';
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
