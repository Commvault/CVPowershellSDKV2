
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
API to send request to process plan rules against specific set of entities.
.Description
API to send request to process plan rules against specific set of entities.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.IExecutePlanRules
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BACKUPSETS <IIdName[]>: List of backupsets against which plan rules need to be executed and evaluated.
  [Id <Int32?>]: 
  [Name <String>]: 

BODY <IExecutePlanRules>: Message object to hold information of entities against which plan rule need to be analyzed
  [Backupsets <IIdName[]>]: List of backupsets against which plan rules need to be  executed and evaluated.
    [Id <Int32?>]: 
    [Name <String>]: 
  [Clients <IIdName[]>]: List of clients against which plan rules need to be  executed and evaluated.
  [IgnorePreviousPlanAssociation <Boolean?>]: Boolean to indicate if we want to evaluate rule for entities associated to plan. Default is false. Only entities with no plan associated will be evaluated.
  [Instances <IIdName[]>]: List of instances against which plan rules need to be  executed and evaluated.
  [IsPreviewOnly <Boolean?>]: Boolean to indicate if request is to preview list of subclients that will be associated via plan rules
  [Subclients <IIdName[]>]: List of subclients against which plan rules need to be  executed and evaluated.

CLIENTS <IIdName[]>: List of clients against which plan rules need to be executed and evaluated.
  [Id <Int32?>]: 
  [Name <String>]: 

INSTANCES <IIdName[]>: List of instances against which plan rules need to be executed and evaluated.
  [Id <Int32?>]: 
  [Name <String>]: 

SUBCLIENTS <IIdName[]>: List of subclients against which plan rules need to be executed and evaluated.
  [Id <Int32?>]: 
  [Name <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-planruleassociatedentity
#>
function Set-PlanRuleAssociatedEntity {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Put', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IExecutePlanRules]
    # Message object to hold information of entities against which plan rule need to be analyzed
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # List of backupsets against which plan rules need to be executed and evaluated.
    # To construct, see NOTES section for BACKUPSETS properties and create a hash table.
    ${Backupsets},

    [Parameter(ParameterSetName='PutExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # List of clients against which plan rules need to be executed and evaluated.
    # To construct, see NOTES section for CLIENTS properties and create a hash table.
    ${Clients},

    [Parameter(ParameterSetName='PutExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Boolean to indicate if we want to evaluate rule for entities associated to plan.
    # Default is false.
    # Only entities with no plan associated will be evaluated.
    ${IgnorePreviousPlanAssociation},

    [Parameter(ParameterSetName='PutExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # List of instances against which plan rules need to be executed and evaluated.
    # To construct, see NOTES section for INSTANCES properties and create a hash table.
    ${Instances},

    [Parameter(ParameterSetName='PutExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Boolean to indicate if request is to preview list of subclients that will be associated via plan rules
    ${IsPreviewOnly},

    [Parameter(ParameterSetName='PutExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # List of subclients against which plan rules need to be executed and evaluated.
    # To construct, see NOTES section for SUBCLIENTS properties and create a hash table.
    ${Subclients},

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
            Put = 'CommvaultPowerShell.private\Set-PlanRuleAssociatedEntity_Put';
            PutExpanded = 'CommvaultPowerShell.private\Set-PlanRuleAssociatedEntity_PutExpanded';
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
