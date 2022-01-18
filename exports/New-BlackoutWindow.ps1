
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
Create a Blackout Window
.Description
Create a Blackout Window
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICreateBlackoutWindow
.Outputs
Commvault.Powershell.Models.IIdName
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ICreateBlackoutWindow>: betweenDates refers to the dates where the blackout window will be in effect. Dates have to be given in unix time format. time has to be provided in seconds. company refers to company to which the blackout window is associated.Id is given first preference if both are id and name are provided.
  Name <String>: Name of the blackout window to be created.
  [BackupOperations <String[]>]: Refers to backup types to include in the blackout window
  [BetweenDateEnd <Int64?>]: the blackout window is no longer in effect from this point on.
  [BetweenDateStart <Int64?>]: the blackout window comes into effect at this point.
  [CompanyId <Int32?>]: 
  [CompanyName <String>]: 
  [Days <String[]>]: Days of the week when the blackout window will be in effect.
  [DoNotSubmitJob <Boolean?>]: Allows or Denies submitting a job when the blackout window is in effect. If set to false, the job is submitted and resumed once the blackout window ends.
  [Time <IStartEnd[]>]: Refers to the time between which the blackout window will be in effect. It has to be provided in seconds
    [End <Int64?>]: the blackout window is no longer in effect from this point on.
    [Start <Int64?>]: the blackout window comes into effect at this point.
  [Weeks <String[]>]: Refers to the weeks of the month that the blackout window will be in effect.

TIME <IStartEnd[]>: Refers to the time between which the blackout window will be in effect. It has to be provided in seconds
  [End <Int64?>]: the blackout window is no longer in effect from this point on.
  [Start <Int64?>]: the blackout window comes into effect at this point.
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-blackoutwindow
#>
function New-BlackoutWindow {
[OutputType([Commvault.Powershell.Models.IIdName])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ICreateBlackoutWindow]
    # betweenDates refers to the dates where the blackout window will be in effect.
    # Dates have to be given in unix time format.
    # time has to be provided in seconds.
    # company refers to company to which the blackout window is associated.Id is given first preference if both are id and name are provided.
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Name of the blackout window to be created.
    ${Name},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Refers to backup types to include in the blackout window
    ${BackupOperations},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # the blackout window is no longer in effect from this point on.
    ${BetweenDateEnd},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # the blackout window comes into effect at this point.
    ${BetweenDateStart},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${CompanyId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${CompanyName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Days of the week when the blackout window will be in effect.
    ${Days},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Allows or Denies submitting a job when the blackout window is in effect.
    # If set to false, the job is submitted and resumed once the blackout window ends.
    ${DoNotSubmitJob},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IStartEnd[]]
    # Refers to the time between which the blackout window will be in effect.
    # It has to be provided in seconds
    # To construct, see NOTES section for TIME properties and create a hash table.
    ${Time},

    [Parameter(ParameterSetName='CreateExpanded')]
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
            Create = 'CommvaultPowerShell.private\New-BlackoutWindow_Create';
            CreateExpanded = 'CommvaultPowerShell.private\New-BlackoutWindow_CreateExpanded';
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
