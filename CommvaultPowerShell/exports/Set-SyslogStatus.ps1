
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
This endpoint configures a syslog server.
.Description
This endpoint configures a syslog server.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ISyslogConfigure
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISyslogConfigure>: This operation configures a syslog server.
  Hostname <String>: The hostname or the IP address of the syslog server.
  [CertificateAuthorityContent <String>]: Content of the uploaded certificate authority file. It should be base64 encoded. Accepted fileTypes are key,crt,pem.
  [CertificateAuthorityName <String>]: File name of the uploaded certificate authority file
  [ForwardToSyslogAlerts <Boolean?>]: Forward the system log for alerts to the server.
  [ForwardToSyslogAudit <Boolean?>]: Forward the system log for audit trails to the server.
  [ForwardToSyslogEvents <Boolean?>]: Forward the system log for events to the server.
  [Port <Int64?>]: The port on which the syslog server accepts the logs.
  [SecureMessaging <Boolean?>]: When false UDP port will be used, when true TLS encryption will be used to connect to Syslog Server. To upload Certificate Authority file it should be enabled.
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-syslogstatus
#>
function Set-SyslogStatus {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='ConfigureExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Configure', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ISyslogConfigure]
    # This operation configures a syslog server.
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='ConfigureExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The hostname or the IP address of the syslog server.
    ${Hostname},

    [Parameter(ParameterSetName='ConfigureExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Content of the uploaded certificate authority file.
    # It should be base64 encoded.
    # Accepted fileTypes are key,crt,pem.
    ${CertificateAuthorityContent},

    [Parameter(ParameterSetName='ConfigureExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # File name of the uploaded certificate authority file
    ${CertificateAuthorityName},

    [Parameter(ParameterSetName='ConfigureExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Forward the system log for alerts to the server.
    ${ForwardToSyslogAlerts},

    [Parameter(ParameterSetName='ConfigureExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Forward the system log for audit trails to the server.
    ${ForwardToSyslogAudit},

    [Parameter(ParameterSetName='ConfigureExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Forward the system log for events to the server.
    ${ForwardToSyslogEvents},

    [Parameter(ParameterSetName='ConfigureExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # The port on which the syslog server accepts the logs.
    ${Port},

    [Parameter(ParameterSetName='ConfigureExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # When false UDP port will be used, when true TLS encryption will be used to connect to Syslog Server.
    # To upload Certificate Authority file it should be enabled.
    ${SecureMessaging},

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
            Configure = 'CommvaultPowerShell.private\Set-SyslogStatus_Configure';
            ConfigureExpanded = 'CommvaultPowerShell.private\Set-SyslogStatus_ConfigureExpanded';
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
