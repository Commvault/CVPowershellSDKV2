
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
This endpoint is used to create network topology.
.Description
This endpoint is used to create network topology.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.IFirewallTopologyCreateReq
.Outputs
Commvault.Powershell.Models.IFirewallTopologyCreateResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IFirewallTopologyCreateReq>: FirewallTopologyReq
  [ClientType <String>]: The type of clients associated with the topology.
  [EncryptTraffic <Boolean?>]: Flag determining if we want the data from tunnel to use HTTPS protocol
  [FirewallGroups <IFirewallTopologyGroups[]>]: 
    [AdvancedOptionKeepAliveInterval <Int32?>]: The interval in seconds for sending keep-alive packets, to maintain the session if backup traffic has an extended pause.
    [AdvancedOptionTunnelPort <Int32?>]: The port defined for communications
    [ClientGroupId <Int32?>]: The id of the client group
    [GroupType <String>]: FirewallFwGroupType
    [Mnemonic <String>]: Custom names(mnemonics) given to pre-defined smart client groups
  [TopologyName <String>]: 
  [TopologyType <String>]: The type of topology of client groups (and sometimes network gateway) for this instance.
  [TunnelProtocol <String>]: The protocol for outgoing communication
  [TunnelsPerRoute <Int32?>]: The number of tunnel connections per route
  [UseWildCardProxy <Boolean?>]: Flag determining wether network gateways are used to connect all infrastructure machines

FIREWALLGROUPS <IFirewallTopologyGroups[]>: .
  [AdvancedOptionKeepAliveInterval <Int32?>]: The interval in seconds for sending keep-alive packets, to maintain the session if backup traffic has an extended pause.
  [AdvancedOptionTunnelPort <Int32?>]: The port defined for communications
  [ClientGroupId <Int32?>]: The id of the client group
  [GroupType <String>]: FirewallFwGroupType
  [Mnemonic <String>]: Custom names(mnemonics) given to pre-defined smart client groups
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-firewalltopology
#>
function Invoke-FirewallTopology {
[OutputType([Commvault.Powershell.Models.IFirewallTopologyCreateResp])]
[CmdletBinding(DefaultParameterSetName='PostExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Post', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IFirewallTopologyCreateReq]
    # FirewallTopologyReq
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PostExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The type of clients associated with the topology.
    ${ClientType},

    [Parameter(ParameterSetName='PostExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag determining if we want the data from tunnel to use HTTPS protocol
    ${EncryptTraffic},

    [Parameter(ParameterSetName='PostExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IFirewallTopologyGroups[]]
    # .
    # To construct, see NOTES section for FIREWALLGROUPS properties and create a hash table.
    ${FirewallGroups},

    [Parameter(ParameterSetName='PostExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${TopologyName},

    [Parameter(ParameterSetName='PostExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The type of topology of client groups (and sometimes network gateway) for this instance.
    ${TopologyType},

    [Parameter(ParameterSetName='PostExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The protocol for outgoing communication
    ${TunnelProtocol},

    [Parameter(ParameterSetName='PostExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # The number of tunnel connections per route
    ${TunnelsPerRoute},

    [Parameter(ParameterSetName='PostExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag determining wether network gateways are used to connect all infrastructure machines
    ${UseWildCardProxy},

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
            Post = 'CommvaultPowerShell.private\Invoke-FirewallTopology_Post';
            PostExpanded = 'CommvaultPowerShell.private\Invoke-FirewallTopology_PostExpanded';
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
