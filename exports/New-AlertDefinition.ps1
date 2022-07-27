
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
Create Alert Definitions
.Description
Create Alert Definitions
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Commvault.Powershell.Models.IIdName
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ALERTTYPEPARAMSLIST <IAlertDefinitionsCriteriaParams[]>: .
  [ParamIndex <Int64?>]: Param order index
  [Type <Int64?>]: Input value type (default 0 = no input required)
  [Unit <Int64?>]: Unit of the criteria(For eg. :Hrs,min)
  [Value <Int64?>]: Value of the criteria (deefault 0 : if no value required)

ASSOCIATIONS <IAlertAssociationIdNameType1[]>: AlertDefinitionsAssociations
  [Id <Int64?>]: id of the associated entity
  [Name <String>]: name of the associated entity
  [Type <String>]: 

RECIPIENTBCC <IAlertTargetIdNameType1[]>: .
  [Id <Int64?>]: 
  [Name <String>]: 
  [Type <String>]: 

RECIPIENTCC <IAlertTargetIdNameType1[]>: .
  [Id <Int64?>]: 
  [Name <String>]: 
  [Type <String>]: 

RECIPIENTTO <IAlertTargetIdNameType1[]>: .
  [Id <Int64?>]: 
  [Name <String>]: 
  [Type <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-alertdefinition
#>
function New-AlertDefinition {
[OutputType([Commvault.Powershell.Models.IIdName])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # .
    ${AlertTargetSendAlertTo},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Defines the category of the alert
    ${AlertTypeCategory},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Defines the criteria of the alert
    ${AlertTypeCriteria},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IAlertDefinitionsCriteriaParams[]]
    # .
    # To construct, see NOTES section for ALERTTYPEPARAMSLIST properties and create a hash table.
    ${AlertTypeParamsList},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IAlertAssociationIdNameType1[]]
    # AlertDefinitionsAssociations
    # To construct, see NOTES section for ASSOCIATIONS properties and create a hash table.
    ${Associations},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # .
    ${LocaleId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${LocaleName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${Name},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IAlertTargetIdNameType1[]]
    # .
    # To construct, see NOTES section for RECIPIENTBCC properties and create a hash table.
    ${RecipientBcc},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IAlertTargetIdNameType1[]]
    # .
    # To construct, see NOTES section for RECIPIENTCC properties and create a hash table.
    ${RecipientCc},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IAlertTargetIdNameType1[]]
    # .
    # To construct, see NOTES section for RECIPIENTTO properties and create a hash table.
    ${RecipientTo},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int64]
    # id of the webhook to be associated with the alert definition.
    # Only needed incase of webhook notif selected.
    # To get a list of webhooks, use api GET Webhook
    ${RecipientWebHookId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${SendIndividualNotifications},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # the message template for the console notification
    ${TemplateConsoleMessage},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # the message template for the email notification.
    # Contains both email subject as well as body
    ${TemplateEmailMessage},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # the message template for the event viewer notification
    ${TemplateEventViewerMessage},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # the message template for the webhook notification
    ${TemplateWebhookMessage},

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
            CreateExpanded = 'CommvaultPowerShell.private\New-AlertDefinition_CreateExpanded';
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
