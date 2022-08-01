
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
Configure SMTP server settings.
.Description
Configure SMTP server settings.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.IConfigureSmtpServerReq
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IConfigureSmtpServerReq>: ConfigureSMTPServerReq
  SenderEmail <String>: The sender email address used for emails sent from the software.
  SenderName <String>: The sender name used for emails sent from the software.
  SmtpPort <Int64>: The port number that connects to the mail server.
  SmtpServerName <String>: The name of the mail server that sends alerts, scheduled reports, log files, and additional information.
  [EncryptionAlgorithm <String>]: 
  [Password <String>]: Password must be in base64 encoded format. Similar to username, if authentication on the mail server is required, this option is required.
  [Username <String>]: This option is used when authentication on the mail server is required
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-emailserver
#>
function Set-EmailServer {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Configure', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IConfigureSmtpServerReq]
    # ConfigureSMTPServerReq
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='ConfigureExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The sender email address used for emails sent from the software.
    ${SenderEmail},

    [Parameter(ParameterSetName='ConfigureExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The sender name used for emails sent from the software.
    ${SenderName},

    [Parameter(ParameterSetName='ConfigureExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # The port number that connects to the mail server.
    ${SmtpPort},

    [Parameter(ParameterSetName='ConfigureExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The name of the mail server that sends alerts, scheduled reports, log files, and additional information.
    ${SmtpServerName},

    [Parameter(ParameterSetName='ConfigureExpanded')]
    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${EncryptionAlgorithm},

    [Parameter(ParameterSetName='ConfigureExpanded')]
    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Password must be in base64 encoded format.
    # Similar to username, if authentication on the mail server is required, this option is required.
    ${Password},

    [Parameter(ParameterSetName='ConfigureExpanded')]
    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # This option is used when authentication on the mail server is required
    ${Username},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # The option to use authentication on the mail server.
    # This is typically used in external or internet mail server configurations.
    ${UseAuthentication},

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
            Configure = 'CommvaultPowerShell.private\Set-EmailServer_Configure';
            ConfigureExpanded = 'CommvaultPowerShell.private\Set-EmailServer_ConfigureExpanded';
            UpdateExpanded = 'CommvaultPowerShell.private\Set-EmailServer_UpdateExpanded';
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
