
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
Edit Alert Definition details
.Description
Edit Alert Definition details
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.IAlertDefinitionsEdit
.Inputs
Commvault.Powershell.Models.ICommvaultPowerShellIdentity
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ASSOCIATIONS <IAlertAssociationIdNameType1[]>: AlertDefinitionsAssociations
  [Id <Int32?>]: id of the associated entity
  [Name <String>]: name of the associated entity
  [Type <String>]: 

BODY <IAlertDefinitionsEdit>: AlertDefinitionsEdit
  [AlertTargetSendAlertTo <String[]>]: 
  [Associations <IAlertAssociationIdNameType1[]>]: AlertDefinitionsAssociations
    [Id <Int32?>]: id of the associated entity
    [Name <String>]: name of the associated entity
    [Type <String>]: 
  [LocaleId <Int32?>]: 
  [LocaleName <String>]: 
  [NewName <String>]: The new name of the alert definition
  [RecipientBcc <IAlertTargetIdNameType1[]>]: 
    [Id <Int32?>]: 
    [Name <String>]: 
    [Type <String>]: 
  [RecipientCc <IAlertTargetIdNameType1[]>]: 
  [RecipientTo <IAlertTargetIdNameType1[]>]: 
  [RecipientWebHookId <Int32?>]: id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list of webhooks, use api GET Webhook
  [SendIndividualNotifications <Boolean?>]: 
  [TemplateConsoleMessage <String>]: the message template for the console notification
  [TemplateEmailMessage <String>]: the message template for the email notification. Contains both email subject as well as body
  [TemplateEventViewerMessage <String>]: the message template for the event viewer notification
  [TemplateWebhookMessage <String>]: the message template for the webhook notification

INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
  [AccessPathId <Int32?>]: Id of the mount path whose access path has to be deleted
  [AgentId <Int32?>]: Id of the agent to be modified
  [BackupDestinationId <Int32?>]: Id of the backupDestination to be modified
  [BackupLocationId <Int32?>]: Id of the backup location whose details have to be fetched
  [BlackoutWindowId <Int32?>]: Id of the Blackout Window whose details have to be fetched
  [BucketId <Int32?>]: Id of Bucket
  [CloudStorageId <Int32?>]: Id of cloud Storage
  [CompanyId <Int32?>]: Id of the Company whose details have to be fetched
  [CredentialName <String>]: 
  [DomainId <Int32?>]: ID of the AD/LDAP domain
  [EntityId <Int32?>]: Unique id for the entity
  [EntityType <String>]: Type of the entity
  [GlobalSearchEntity <String>]: name of global search entity
  [HfsShareId <Int32?>]: Id of the HFS Share to fetch its status
  [HyperScaleStorageId <Int32?>]: Id of hyperscale storage
  [HypervisorId <Int32?>]: Id of the HYpervisor to get
  [Id <Int32?>]: 
  [InstanceId <Int32?>]: Id of the instance to modify
  [KmsId <Int32?>]: Id of Key Management Server
  [MediaAgentId <Int32?>]: Id of the Media Agent whose details have to be fetched
  [MetadataCacheId <Int32?>]: Id of metadata cache
  [Name <String>]: 
  [NodeId <Int32?>]: Id of node
  [PairId <Int32?>]: 
  [PlanId <Int32?>]: Id of the plan to fetch details
  [RecoveryTargetId <Int32?>]: id of recovery target
  [RegionId <String>]: 
  [RegionList <String>]: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  [ReplicationGroupId <String>]: 
  [RequestId <Int32?>]: Unique identifier for the request
  [RoleId <Int32?>]: Role Id
  [RpsId <String>]: 
  [RuleId <Int32?>]: Id of the rule to update in Plan
  [ScheduleId <String>]: 
  [SchedulePolicyId <String>]: 
  [ServerGroupId <Int32?>]: Id of the serverGroupId whose details have to be fetched
  [ServerId <Int32?>]: Id of the server to modify
  [StoragePoolId <Int32?>]: Id of the disk storage pool whose details have to be fetched
  [SubclientId <Int32?>]: Id of the subclient to modify
  [TopologyId <String>]: 
  [UserGroupId <Int32?>]: Id of the user-group whose details have to be fetched
  [UserId <Int32?>]: Id of the User whose details have to be fetched
  [VMGroupId <Int32?>]: Id of the VMgroup to update
  [VMUuid <String>]: The vmUUID can be obtained from GET /virtualMachines UUID property

RECIPIENTBCC <IAlertTargetIdNameType1[]>: .
  [Id <Int32?>]: 
  [Name <String>]: 
  [Type <String>]: 

RECIPIENTCC <IAlertTargetIdNameType1[]>: .
  [Id <Int32?>]: 
  [Name <String>]: 
  [Type <String>]: 

RECIPIENTTO <IAlertTargetIdNameType1[]>: .
  [Id <Int32?>]: 
  [Name <String>]: 
  [Type <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/edit-alertdefinition
#>
function Edit-AlertDefinition {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='EditExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Edit', Mandatory)]
    [Parameter(ParameterSetName='EditExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # .
    ${Id},

    [Parameter(ParameterSetName='EditViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='EditViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Path')]
    [Commvault.Powershell.Models.ICommvaultPowerShellIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Edit', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='EditViaIdentity', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IAlertDefinitionsEdit]
    # AlertDefinitionsEdit
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # .
    ${AlertTargetSendAlertTo},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IAlertAssociationIdNameType1[]]
    # AlertDefinitionsAssociations
    # To construct, see NOTES section for ASSOCIATIONS properties and create a hash table.
    ${Associations},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${LocaleId},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${LocaleName},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The new name of the alert definition
    ${NewName},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IAlertTargetIdNameType1[]]
    # .
    # To construct, see NOTES section for RECIPIENTBCC properties and create a hash table.
    ${RecipientBcc},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IAlertTargetIdNameType1[]]
    # .
    # To construct, see NOTES section for RECIPIENTCC properties and create a hash table.
    ${RecipientCc},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IAlertTargetIdNameType1[]]
    # .
    # To construct, see NOTES section for RECIPIENTTO properties and create a hash table.
    ${RecipientTo},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # id of the webhook to be associated with the alert definition.
    # Only needed incase of webhook notif selected.
    # To get a list of webhooks, use api GET Webhook
    ${RecipientWebHookId},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${SendIndividualNotifications},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # the message template for the console notification
    ${TemplateConsoleMessage},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # the message template for the email notification.
    # Contains both email subject as well as body
    ${TemplateEmailMessage},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # the message template for the event viewer notification
    ${TemplateEventViewerMessage},

    [Parameter(ParameterSetName='EditExpanded')]
    [Parameter(ParameterSetName='EditViaIdentityExpanded')]
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
            Edit = 'CommvaultPowerShell.private\Edit-AlertDefinition_Edit';
            EditExpanded = 'CommvaultPowerShell.private\Edit-AlertDefinition_EditExpanded';
            EditViaIdentity = 'CommvaultPowerShell.private\Edit-AlertDefinition_EditViaIdentity';
            EditViaIdentityExpanded = 'CommvaultPowerShell.private\Edit-AlertDefinition_EditViaIdentityExpanded';
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
