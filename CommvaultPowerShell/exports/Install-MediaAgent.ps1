
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
To install MediaAgent package on a server
.Description
To install MediaAgent package on a server
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.IInstallMediaAgent
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IInstallMediaAgent>: .
  HostNames <String[]>: Host names where MediaAgent package is required to be installed
  Username <String>: Username to access hostnames
  [InstallLocation <String>]: Holds install path according to the chosen OSType
  [OSType <String>]: 
  [Password <String>]: password should be in base64 encoded string. password is optional only if SSHKeyFilePassphrase is specified
  [RebootIfRequired <Boolean?>]: 
  [SshKeyFilePassphrase <String>]: Applicable only for Unix OSType and should be in base64 encoded string
  [SshKeyPath <String>]: Applicable only for Unix OSType. Path provided should be valid on the CommServ Client
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/install-mediaagent
#>
function Install-MediaAgent {
[OutputType([System.String])]
[CmdletBinding(DefaultParameterSetName='InstallExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Install', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IInstallMediaAgent]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='InstallExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Host names where MediaAgent package is required to be installed
    ${HostNames},

    [Parameter(ParameterSetName='InstallExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Username to access hostnames
    ${Username},

    [Parameter(ParameterSetName='InstallExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Holds install path according to the chosen OSType
    ${InstallLocation},

    [Parameter(ParameterSetName='InstallExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${OSType},

    [Parameter(ParameterSetName='InstallExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # password should be in base64 encoded string.
    # password is optional only if SSHKeyFilePassphrase is specified
    ${Password},

    [Parameter(ParameterSetName='InstallExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${RebootIfRequired},

    [Parameter(ParameterSetName='InstallExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Applicable only for Unix OSType and should be in base64 encoded string
    ${SshKeyFilePassphrase},

    [Parameter(ParameterSetName='InstallExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Applicable only for Unix OSType.
    # Path provided should be valid on the CommServ Client
    ${SshKeyPath},

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
            Install = 'CommvaultPowerShell.private\Install-MediaAgent_Install';
            InstallExpanded = 'CommvaultPowerShell.private\Install-MediaAgent_InstallExpanded';
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
