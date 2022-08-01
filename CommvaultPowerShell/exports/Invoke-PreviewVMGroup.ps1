
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
Preview of the vm to be protected in VMGroup
.Description
Preview of the vm to be protected in VMGroup
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.IVMGroupPreviewReq
.Outputs
Commvault.Powershell.Models.IGenericResp
.Outputs
Commvault.Powershell.Models.IVMGroupPreviewResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IVMGroupPreviewReq>: vmGroupPreviewReq
  [ContentOverwrite <Boolean?>]: True if content in vmgroup has to be overwritten, by default it will append the content
  [ContentRuleGroups <IRuleGroupContent[]>]: 
    [MatchRule <String>]: Enum which specifies the whether to match all rules or any of the rules
    [Rules <IRuleContent[]>]: 
      [Condition <String>]: Operation type for VM rules/filters
      [DisplayName <String>]: The display name of the entity to be added
      [Guid <String>]: GUID of the entity to be added as content
      [Name <String>]: name of the VM to be added as content
      [Type <String>]: 
      [Value <String>]: value for the few type of VM Content like powerstate
  [ContentVirtualMachines <IVirtualMachinecontent[]>]: 
    [Guid <String>]: GUID of the VM to be added as content
    [Name <String>]: name of the VM to be added as content
    [Type <String>]: 

CONTENTRULEGROUPS <IRuleGroupContent[]>: .
  [MatchRule <String>]: Enum which specifies the whether to match all rules or any of the rules
  [Rules <IRuleContent[]>]: 
    [Condition <String>]: Operation type for VM rules/filters
    [DisplayName <String>]: The display name of the entity to be added
    [Guid <String>]: GUID of the entity to be added as content
    [Name <String>]: name of the VM to be added as content
    [Type <String>]: 
    [Value <String>]: value for the few type of VM Content like powerstate

CONTENTVIRTUALMACHINES <IVirtualMachinecontent[]>: .
  [Guid <String>]: GUID of the VM to be added as content
  [Name <String>]: name of the VM to be added as content
  [Type <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-previewvmgroup
#>
function Invoke-PreviewVMGroup {
[OutputType([Commvault.Powershell.Models.IVMGroupPreviewResp], [Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='PreviewExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter()]
    [Commvault.Powershell.Category('Query')]
    [System.Int64]
    # Hypervisor Id of VMGroup
    ${HypervisorId},

    [Parameter(ParameterSetName='Preview', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IVMGroupPreviewReq]
    # vmGroupPreviewReq
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PreviewExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if content in vmgroup has to be overwritten, by default it will append the content
    ${ContentOverwrite},

    [Parameter(ParameterSetName='PreviewExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IRuleGroupContent[]]
    # .
    # To construct, see NOTES section for CONTENTRULEGROUPS properties and create a hash table.
    ${ContentRuleGroups},

    [Parameter(ParameterSetName='PreviewExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IVirtualMachinecontent[]]
    # .
    # To construct, see NOTES section for CONTENTVIRTUALMACHINES properties and create a hash table.
    ${ContentVirtualMachines},

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
            Preview = 'CommvaultPowerShell.private\Invoke-PreviewVMGroup_Preview';
            PreviewExpanded = 'CommvaultPowerShell.private\Invoke-PreviewVMGroup_PreviewExpanded';
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
