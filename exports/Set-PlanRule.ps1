
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
Api to update existing plan rules.
Request body will suggest which rule need to be updated and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.
.Description
Api to update existing plan rules.
Request body will suggest which rule need to be updated and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.IUpdatePlanEntityRule
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IUpdatePlanEntityRule>: Plan entity rule update object. Fields in this object need to be populated to suggest what need to be changed in the rule.         User can provide all rule options or can specify a specific rule group. Be default, for rule to be applicable for association to a workload, ALL specified rules in that Rule need to be matched.
  [PlanId <Int32?>]: 
  [PlanName <String>]: 
  [Rank <Int32?>]: [Optional] - This field will suggest rank/priority of rule.
  [Regions <IIdName[]>]: This will include list of regions that should be evaluated against workload region for plan association.
    [Id <Int32?>]: 
    [Name <String>]: 
  [RuleId <Int32?>]: 
  [RuleName <String>]: 
  [ServerGroups <IIdName[]>]: This will include list of Server groups that should be evaluated against workload server group for plan association.
  [Solutions <IIdName[]>]: This will include list of solutions that should be evaluated against workload for plan association.
  [Tags <IPlanEntityRuleTag[]>]: This will include list of tags that should be evaluated against workload for plan association
    [Id <Int32?>]: Id for the tag
    [Name <String>]: Name for the plan rule tag which need to be matched against tag of the workload.
    [Value <String>]: Possible value that need to matched against value of tag associated to workload.
  [Workloads <IIdName[]>]: This will include list of apptypes that should be evaluated against workload apptype for plan association.

REGIONS <IIdName[]>: This will include list of regions that should be evaluated against workload region for plan association.
  [Id <Int32?>]: 
  [Name <String>]: 

SERVERGROUPS <IIdName[]>: This will include list of Server groups that should be evaluated against workload server group for plan association.
  [Id <Int32?>]: 
  [Name <String>]: 

SOLUTIONS <IIdName[]>: This will include list of solutions that should be evaluated against workload for plan association.
  [Id <Int32?>]: 
  [Name <String>]: 

TAGS <IPlanEntityRuleTag[]>: This will include list of tags that should be evaluated against workload for plan association
  [Id <Int32?>]: Id for the tag
  [Name <String>]: Name for the plan rule tag which need to be matched against tag of the workload.
  [Value <String>]: Possible value that need to matched against value of tag associated to workload.

WORKLOADS <IIdName[]>: This will include list of apptypes that should be evaluated against workload apptype for plan association.
  [Id <Int32?>]: 
  [Name <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-planrule
#>
function Set-PlanRule {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IUpdatePlanEntityRule]
    # Plan entity rule update object.
    # Fields in this object need to be populated to suggest what need to be changed in the rule.
    # User can provide all rule options or can specify a specific rule group.
    # Be default, for rule to be applicable for association to a workload, ALL specified rules in that Rule need to be matched.
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${PlanId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${PlanName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # [Optional] - This field will suggest rank/priority of rule.
    ${Rank},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # This will include list of regions that should be evaluated against workload region for plan association.
    # To construct, see NOTES section for REGIONS properties and create a hash table.
    ${Regions},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${RuleId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${RuleName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # This will include list of Server groups that should be evaluated against workload server group for plan association.
    # To construct, see NOTES section for SERVERGROUPS properties and create a hash table.
    ${ServerGroups},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # This will include list of solutions that should be evaluated against workload for plan association.
    # To construct, see NOTES section for SOLUTIONS properties and create a hash table.
    ${Solutions},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IPlanEntityRuleTag[]]
    # This will include list of tags that should be evaluated against workload for plan association
    # To construct, see NOTES section for TAGS properties and create a hash table.
    ${Tags},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # This will include list of apptypes that should be evaluated against workload apptype for plan association.
    # To construct, see NOTES section for WORKLOADS properties and create a hash table.
    ${Workloads},

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
            Update = 'CommvaultPowerShell.private\Set-PlanRule_Update';
            UpdateExpanded = 'CommvaultPowerShell.private\Set-PlanRule_UpdateExpanded';
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
