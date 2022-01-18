
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
API to create laptop owner mappings
.Description
API to create laptop owner mappings
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICreateLaptopOwnerMapping
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ICreateLaptopOwnerMapping>: POST request for adding new laptop owner mapping, The mandotary fields are combination of multiple properties SerialNumber AND (host OR laptopName) AND (ownerEmail OR ownerUPN)
  [LaptopOwnerMapping <ICreateLaptopOwnerInfo[]>]: 
    [CompanyId <Int32?>]: 
    [CompanyName <String>]: 
    [Host <String>]: Host name of the laptop
    [LaptopName <String>]: Display name of the laptop
    [OSType <String>]: Operating system of the owner
    [OwnerEmail <String>]: Email address of the owner
    [OwnerUpn <String>]: UPN of the owner
    [SerialNumber <String>]: Serial number of the laptop

LAPTOPOWNERMAPPING <ICreateLaptopOwnerInfo[]>: .
  [CompanyId <Int32?>]: 
  [CompanyName <String>]: 
  [Host <String>]: Host name of the laptop
  [LaptopName <String>]: Display name of the laptop
  [OSType <String>]: Operating system of the owner
  [OwnerEmail <String>]: Email address of the owner
  [OwnerUpn <String>]: UPN of the owner
  [SerialNumber <String>]: Serial number of the laptop
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-laptopownermapping
#>
function Invoke-LaptopOwnerMapping {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='PostExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Post', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ICreateLaptopOwnerMapping]
    # POST request for adding new laptop owner mapping, The mandotary fields are combination of multiple properties SerialNumber AND (host OR laptopName) AND (ownerEmail OR ownerUPN)
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PostExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ICreateLaptopOwnerInfo[]]
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
            Post = 'CommvaultPowerShell.private\Invoke-LaptopOwnerMapping_Post';
            PostExpanded = 'CommvaultPowerShell.private\Invoke-LaptopOwnerMapping_PostExpanded';
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
