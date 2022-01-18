
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
API to update existing laptop owner mapping
.Description
API to update existing laptop owner mapping
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ILaptopOwnerMapping
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ILaptopOwnerMapping>: List of laptop owner info
  [LaptopOwnerMapping1 <ILaptopOwnerInfo[]>]: 
    Id <Int32>: Unique Id
    [CompanyId <Int32?>]: 
    [CompanyName <String>]: 
    [Host <String>]: host name of the laptop
    [LaptopName <String>]: name of the laptop
    [OSType <String>]: OS type of the laptop. Can be LINUX or MAC
    [OwnerEmail <String>]: Email address of the owner
    [OwnerUpn <String>]: UPN of the owner
    [SerialNumber <String>]: This is the serial number

LAPTOPOWNERMAPPING <ILaptopOwnerInfo[]>: .
  Id <Int32>: Unique Id
  [CompanyId <Int32?>]: 
  [CompanyName <String>]: 
  [Host <String>]: host name of the laptop
  [LaptopName <String>]: name of the laptop
  [OSType <String>]: OS type of the laptop. Can be LINUX or MAC
  [OwnerEmail <String>]: Email address of the owner
  [OwnerUpn <String>]: UPN of the owner
  [SerialNumber <String>]: This is the serial number
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-laptopownermapping
#>
function Set-LaptopOwnerMapping {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Put', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ILaptopOwnerMapping]
    # List of laptop owner info
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ILaptopOwnerInfo[]]
    # .
    # To construct, see NOTES section for LAPTOPOWNERMAPPING properties and create a hash table.
    ${LaptopOwnerMapping},

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
            Put = 'CommvaultPowerShell.private\Set-LaptopOwnerMapping_Put';
            PutExpanded = 'CommvaultPowerShell.private\Set-LaptopOwnerMapping_PutExpanded';
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
