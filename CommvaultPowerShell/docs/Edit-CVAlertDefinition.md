---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/edit-cvalertdefinition
schema: 2.0.0
---

# Edit-CVAlertDefinition

## SYNOPSIS
Edit Alert Definition details

## SYNTAX

### EditExpanded (Default)
```
Edit-CVAlertDefinition -Id <Int64> [-AlertTargetRecipientsOperationType <String>]
 [-AlertTargetSendAlertTo <String[]>] [-Associations <IAlertAssociationIdNameType1[]>]
 [-AssociationsOperationType <String>] [-CriteriaList <IAlertCriteriaIdName1[]>]
 [-EventCriterionDetailConditions <IConditionDetails[]>] [-EventCriterionDetailCriteriaName <String>]
 [-EventCriterionDetailOpBetweenConditions <Int64>] [-GlobalConfigInfoApplyOnAllCommCells]
 [-GlobalConfigInfoCommcells <IGlobalConfigCommcellInfo[]>] [-GlobalConfigInfoId <String>]
 [-GlobalConfigInfoIsMarkedForDeletion] [-GlobalConfigInfoName <String>] [-GlobalConfigInfoScope <String>]
 [-GlobalConfigInfoScopeFilterQuery <String>] [-GlobalConfigInfoStatus <String>] [-LocaleId <Int64>]
 [-LocaleName <String>] [-NewName <String>] [-ProcessDiscoveredVMS]
 [-RecipientBcc <IAlertTargetIdNameType1[]>] [-RecipientCc <IAlertTargetIdNameType1[]>]
 [-RecipientTo <IAlertTargetIdNameType1[]>] [-RecipientWebHookId <Int64>] [-SendIndividualNotifications]
 [-SubscriptionBasedAlert] [-TemplateConsole <String>] [-TemplateEmail <String>]
 [-TemplateEventViewer <String>] [-TemplateWebhook <String>] [-TemplateWorkflowInputDetails <String>]
 [-TokenMatch <String>] [-TokenRuleGroups <ITokenRuleGroup[]>] [-WorkflowClientId <Int64>]
 [-WorkflowClientName <String>] [-WorkflowId <Int64>] [-WorkflowName <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Edit
```
Edit-CVAlertDefinition -Id <Int64> -Body <IAlertDefinitionsEdit> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### EditViaIdentity
```
Edit-CVAlertDefinition -InputObject <ICommvaultPowerShellIdentity> -Body <IAlertDefinitionsEdit> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### EditViaIdentityExpanded
```
Edit-CVAlertDefinition -InputObject <ICommvaultPowerShellIdentity>
 [-AlertTargetRecipientsOperationType <String>] [-AlertTargetSendAlertTo <String[]>]
 [-Associations <IAlertAssociationIdNameType1[]>] [-AssociationsOperationType <String>]
 [-CriteriaList <IAlertCriteriaIdName1[]>] [-EventCriterionDetailConditions <IConditionDetails[]>]
 [-EventCriterionDetailCriteriaName <String>] [-EventCriterionDetailOpBetweenConditions <Int64>]
 [-GlobalConfigInfoApplyOnAllCommCells] [-GlobalConfigInfoCommcells <IGlobalConfigCommcellInfo[]>]
 [-GlobalConfigInfoId <String>] [-GlobalConfigInfoIsMarkedForDeletion] [-GlobalConfigInfoName <String>]
 [-GlobalConfigInfoScope <String>] [-GlobalConfigInfoScopeFilterQuery <String>]
 [-GlobalConfigInfoStatus <String>] [-LocaleId <Int64>] [-LocaleName <String>] [-NewName <String>]
 [-ProcessDiscoveredVMS] [-RecipientBcc <IAlertTargetIdNameType1[]>]
 [-RecipientCc <IAlertTargetIdNameType1[]>] [-RecipientTo <IAlertTargetIdNameType1[]>]
 [-RecipientWebHookId <Int64>] [-SendIndividualNotifications] [-SubscriptionBasedAlert]
 [-TemplateConsole <String>] [-TemplateEmail <String>] [-TemplateEventViewer <String>]
 [-TemplateWebhook <String>] [-TemplateWorkflowInputDetails <String>] [-TokenMatch <String>]
 [-TokenRuleGroups <ITokenRuleGroup[]>] [-WorkflowClientId <Int64>] [-WorkflowClientName <String>]
 [-WorkflowId <Int64>] [-WorkflowName <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Edit Alert Definition details

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

{{ Add description here }}

## PARAMETERS

### -AlertTargetRecipientsOperationType
Allows adding to, overwriting and deleting existing recipients.
default is adding to existing recipients

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertTargetSendAlertTo
.

```yaml
Type: System.String[]
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Associations
AlertDefinitionsAssociations

```yaml
Type: Commvault.Powershell.Models.IAlertAssociationIdNameType1[]
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssociationsOperationType
Allows adding to, overwriting and deleting existing alert associations.
default is adding to existing alert associations

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
AlertDefinitionsEdit

```yaml
Type: Commvault.Powershell.Models.IAlertDefinitionsEdit
Parameter Sets: Edit, EditViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CriteriaList
List of alert criteria

```yaml
Type: Commvault.Powershell.Models.IAlertCriteriaIdName1[]
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventCriterionDetailConditions
.

```yaml
Type: Commvault.Powershell.Models.IConditionDetails[]
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventCriterionDetailCriteriaName
Alert criteria name

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventCriterionDetailOpBetweenConditions
Integer value for the operation type between conditions

```yaml
Type: System.Int64
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoApplyOnAllCommCells
Decides whether the global configuration should be applied to all the Service commcells, including the newly created ones

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoCommcells
List of Service CommCells where the global configuration is applied

```yaml
Type: Commvault.Powershell.Models.IGlobalConfigCommcellInfo[]
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoId
.

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoIsMarkedForDeletion
Indicates whether global configuration deletion has been started.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoName
.

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoScope
The entity level at which the config is applied.

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoScopeFilterQuery
CommCellEntityCache filter query string used for filtering the scope

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoStatus
.

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.Int64
Parameter Sets: Edit, EditExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Commvault.Powershell.Models.ICommvaultPowerShellIdentity
Parameter Sets: EditViaIdentity, EditViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LocaleId
.

```yaml
Type: System.Int64
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocaleName
.

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewName
The new name of the alert definition

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProcessDiscoveredVMS
Flag indicating the functionality to send individual notifications for each discovered virtual machine

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecipientBcc
.

```yaml
Type: Commvault.Powershell.Models.IAlertTargetIdNameType1[]
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecipientCc
.

```yaml
Type: Commvault.Powershell.Models.IAlertTargetIdNameType1[]
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecipientTo
.

```yaml
Type: Commvault.Powershell.Models.IAlertTargetIdNameType1[]
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecipientWebHookId
id of the webhook to be associated with the alert definition.
Only needed incase of webhook notif selected.
To get a list of webhooks, use api GET Webhook

```yaml
Type: System.Int64
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SendIndividualNotifications
Flag indicating the functionality to send individual notifications

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionBasedAlert
Flag to indicate whether its a subscription based alert.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateConsole
the message template for the console notification

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateEmail
the message template for the email notification.
Contains both email subject as well as body

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateEventViewer
the message template for the event viewer notification

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateWebhook
the message template for the webhook notification

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateWorkflowInputDetails
the template for the workflow input entries values (empty value means the configured workflow does not need any inputs value)

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TokenMatch
.

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TokenRuleGroups
List of rule groups

```yaml
Type: Commvault.Powershell.Models.ITokenRuleGroup[]
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkflowClientId
id of the client on which the workflow runs (zero value means it can run on any workflow engine)

```yaml
Type: System.Int64
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkflowClientName
name of the client on which the workflow runs (empty value means it can run on any workflow engine)

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkflowId
id of the workflow which runs when the alert is triggered

```yaml
Type: System.Int64
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkflowName
name of the workflow which runs when the alert is triggered

```yaml
Type: System.String
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Commvault.Powershell.Models.IAlertDefinitionsEdit

### Commvault.Powershell.Models.ICommvaultPowerShellIdentity

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ASSOCIATIONS <IAlertAssociationIdNameType1[]>`: AlertDefinitionsAssociations
  - `[Id <Int64?>]`: id of the associated entity
  - `[Name <String>]`: name of the associated entity
  - `[ParentEntity1Id <Int64?>]`: id of the associated entity
  - `[ParentEntity1Name <String>]`: name of the associated entity
  - `[ParentEntity1Type <String>]`: 
  - `[ParentEntity2Id <Int64?>]`: id of the associated entity
  - `[ParentEntity2Name <String>]`: name of the associated entity
  - `[ParentEntity2Type <String>]`: 
  - `[ParentEntity3Id <Int64?>]`: id of the associated entity
  - `[ParentEntity3Name <String>]`: name of the associated entity
  - `[ParentEntity3Type <String>]`: 
  - `[ParentEntity4Id <Int64?>]`: id of the associated entity
  - `[ParentEntity4Name <String>]`: name of the associated entity
  - `[ParentEntity4Type <String>]`: 
  - `[Type <String>]`: 

`BODY <IAlertDefinitionsEdit>`: AlertDefinitionsEdit
  - `[AlertTargetRecipientsOperationType <String>]`: Allows adding to, overwriting and deleting existing recipients. default is adding to existing recipients
  - `[AlertTargetSendAlertTo <List<String>>]`: 
  - `[Associations <List<IAlertAssociationIdNameType1>>]`: AlertDefinitionsAssociations
    - `[Id <Int64?>]`: id of the associated entity
    - `[Name <String>]`: name of the associated entity
    - `[ParentEntity1Id <Int64?>]`: id of the associated entity
    - `[ParentEntity1Name <String>]`: name of the associated entity
    - `[ParentEntity1Type <String>]`: 
    - `[ParentEntity2Id <Int64?>]`: id of the associated entity
    - `[ParentEntity2Name <String>]`: name of the associated entity
    - `[ParentEntity2Type <String>]`: 
    - `[ParentEntity3Id <Int64?>]`: id of the associated entity
    - `[ParentEntity3Name <String>]`: name of the associated entity
    - `[ParentEntity3Type <String>]`: 
    - `[ParentEntity4Id <Int64?>]`: id of the associated entity
    - `[ParentEntity4Name <String>]`: name of the associated entity
    - `[ParentEntity4Type <String>]`: 
    - `[Type <String>]`: 
  - `[AssociationsOperationType <String>]`: Allows adding to, overwriting and deleting existing alert associations. default is adding to existing alert associations
  - `[CriteriaList <List<IAlertCriteriaIdName1>>]`: List of alert criteria
    - `[Id <Int64?>]`: id of the criteria of detection for the alert definition
    - `[Name <String>]`: criteria of detection for the alert definition
    - `[NotificationCriterionDelayTime <Int64?>]`: Delayed time in seconds when the notification criteria value contains delayed flag
    - `[NotificationCriterionPersistTime <Int64?>]`: Persisting time in seconds when the notification criteria value contains repeated flag
    - `[NotificationCriterionValue <Int64?>]`: Bit flag indicating notification criteria value. 1 means immediate, 2 means repeated and 8 means delayed
    - `[ParamsList <List<IAlertDefinitionsCriteriaParams>>]`: 
      - `[ParamIndex <Int64?>]`: Param order index
      - `[Type <Int64?>]`: Input value type (default 0 = no input required)
      - `[Unit <Int64?>]`: Unit of the criteria(For eg. :Hrs,min)
      - `[Value <Int64?>]`: Value of the criteria (deefault 0 : if no value required)
  - `[EventCriterionDetailConditions <List<IConditionDetails>>]`: 
    - `Id <Int64>`: Unique identifier for the condition column
    - `Name <String>`: Name of the condition column
    - `Operation <String>`: Operation type value for the condition column
    - `[AdvancedCriteria <List<String>>]`: List of advanced criteria options
    - `[FromValue <String>]`: First value associated with the column when the operation type is BETWEEN
    - `[ToValue <String>]`: Second value associated with the column when the operation type is BETWEEN
    - `[Value <String>]`: Value associated with the column
    - `[ValuesList <List<Int64>>]`: List of the values associated with the column in case of multiple values selection
  - `[EventCriterionDetailCriteriaName <String>]`: Alert criteria name
  - `[EventCriterionDetailOpBetweenConditions <Int64?>]`: Integer value for the operation type between conditions
  - `[GlobalConfigInfoApplyOnAllCommCells <Boolean?>]`: Decides whether the global configuration should be applied to all the Service commcells, including the newly created ones
  - `[GlobalConfigInfoCommcells <List<IGlobalConfigCommcellInfo>>]`: List of Service CommCells where the global configuration is applied
    - `[Guid <String>]`: 
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 
  - `[GlobalConfigInfoId <String>]`: 
  - `[GlobalConfigInfoIsMarkedForDeletion <Boolean?>]`: Indicates whether global configuration deletion has been started.
  - `[GlobalConfigInfoName <String>]`: 
  - `[GlobalConfigInfoScope <String>]`: The entity level at which the config is applied.
  - `[GlobalConfigInfoScopeFilterQuery <String>]`: CommCellEntityCache filter query string used for filtering the scope
  - `[GlobalConfigInfoStatus <String>]`: 
  - `[LocaleId <Int64?>]`: 
  - `[LocaleName <String>]`: 
  - `[NewName <String>]`: The new name of the alert definition
  - `[ProcessDiscoveredVMS <Boolean?>]`: Flag indicating the functionality to send individual notifications for each discovered virtual machine
  - `[RecipientBcc <List<IAlertTargetIdNameType1>>]`: 
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 
    - `[Type <String>]`: 
  - `[RecipientCc <List<IAlertTargetIdNameType1>>]`: 
  - `[RecipientTo <List<IAlertTargetIdNameType1>>]`: 
  - `[RecipientWebHookId <Int64?>]`: id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list of webhooks, use api GET Webhook
  - `[SendIndividualNotifications <Boolean?>]`: Flag indicating the functionality to send individual notifications
  - `[SubscriptionBasedAlert <Boolean?>]`: Flag to indicate whether its a subscription based alert.
  - `[TemplateConsole <String>]`: the message template for the console notification
  - `[TemplateEmail <String>]`: the message template for the email notification. Contains both email subject as well as body
  - `[TemplateEventViewer <String>]`: the message template for the event viewer notification
  - `[TemplateWebhook <String>]`: the message template for the webhook notification
  - `[TemplateWorkflowInputDetails <String>]`: the template for the workflow input entries values (empty value means the configured workflow does not need any inputs value)
  - `[TokenMatch <String>]`: 
  - `[TokenRuleGroups <List<ITokenRuleGroup>>]`: List of rule groups
    - `[Match <String>]`: 
    - `[Rules <List<ITokenRule>>]`: List of rules
      - `[DateRangeFromDate <String>]`: From date value in unix timestamp format
      - `[DateRangeTimeRange <List<ITimeRange>>]`: Time range selection details
        - `[FromTime <String>]`: From time value in unix timestamp format
        - `[ToTime <String>]`: To time value in unix timestamp format
      - `[DateRangeToDate <String>]`: To date value in unix timestamp format
      - `[MatchCondition <String>]`: 
      - `[RuleSecValue <String>]`: Secondary value used for BETWEEN and NOT_BETWEEN matchCondition.
      - `[TimeRangeFromTime <String>]`: From time value in unix timestamp format
      - `[TimeRangeToTime <String>]`: To time value in unix timestamp format
      - `[TokenFormat <String>]`: 
      - `[TokenName <String>]`: Name of the token.
      - `[Value <String>]`: Value to be compared for the token
  - `[WorkflowClientId <Int64?>]`: id of the client on which the workflow runs (zero value means it can run on any workflow engine)
  - `[WorkflowClientName <String>]`: name of the client on which the workflow runs (empty value means it can run on any workflow engine)
  - `[WorkflowId <Int64?>]`: id of the workflow which runs when the alert is triggered
  - `[WorkflowName <String>]`: name of the workflow which runs when the alert is triggered

`CRITERIALIST <IAlertCriteriaIdName1[]>`: List of alert criteria
  - `[Id <Int64?>]`: id of the criteria of detection for the alert definition
  - `[Name <String>]`: criteria of detection for the alert definition
  - `[NotificationCriterionDelayTime <Int64?>]`: Delayed time in seconds when the notification criteria value contains delayed flag
  - `[NotificationCriterionPersistTime <Int64?>]`: Persisting time in seconds when the notification criteria value contains repeated flag
  - `[NotificationCriterionValue <Int64?>]`: Bit flag indicating notification criteria value. 1 means immediate, 2 means repeated and 8 means delayed
  - `[ParamsList <List<IAlertDefinitionsCriteriaParams>>]`: 
    - `[ParamIndex <Int64?>]`: Param order index
    - `[Type <Int64?>]`: Input value type (default 0 = no input required)
    - `[Unit <Int64?>]`: Unit of the criteria(For eg. :Hrs,min)
    - `[Value <Int64?>]`: Value of the criteria (deefault 0 : if no value required)

`EVENTCRITERIONDETAILCONDITIONS <IConditionDetails[]>`: .
  - `Id <Int64>`: Unique identifier for the condition column
  - `Name <String>`: Name of the condition column
  - `Operation <String>`: Operation type value for the condition column
  - `[AdvancedCriteria <List<String>>]`: List of advanced criteria options
  - `[FromValue <String>]`: First value associated with the column when the operation type is BETWEEN
  - `[ToValue <String>]`: Second value associated with the column when the operation type is BETWEEN
  - `[Value <String>]`: Value associated with the column
  - `[ValuesList <List<Int64>>]`: List of the values associated with the column in case of multiple values selection

`GLOBALCONFIGINFOCOMMCELLS <IGlobalConfigCommcellInfo[]>`: List of Service CommCells where the global configuration is applied
  - `[Guid <String>]`: 
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`INPUTOBJECT <ICommvaultPowerShellIdentity>`: Identity Parameter
  - `[AccessPathId <Int64?>]`: Id of the mount path whose access path has to be deleted
  - `[AgentId <Int64?>]`: Id of the agent to be modified
  - `[AlertRuleId <Int64?>]`: Unique Id of the alert custom rule to get details
  - `[AppGuid <String>]`: GUID of the Application to get details
  - `[AppId <Int64?>]`: Commvault exchange app id
  - `[ApplicationGroupId <Int64?>]`: applicationGroupId is the ID of the Kubernetes application group
  - `[ArrayId <Int64?>]`: 
  - `[AssetId <String>]`: FQDN of the asset
  - `[BackupDestinationId <Int64?>]`: Id of the backupDestination to be modified
  - `[BackupDestionationId <Int64?>]`: 
  - `[BackupLocationId <Int64?>]`: Id of the backup location whose details have to be fetched
  - `[BlackoutWindowId <Int64?>]`: Id of the Blackout Window whose details have to be fetched
  - `[BucketId <Int64?>]`: Id of Bucket
  - `[ClientId <Int64?>]`: 
  - `[CloneId <Int64?>]`: ID of the cloned bucket
  - `[CloudStorageId <Int64?>]`: Id of cloud Storage
  - `[ClusterId <Int64?>]`: Id of the cluster whose modifier has to be listed.
  - `[CompanyId <Int64?>]`: Id of the Company whose details have to be fetched
  - `[CopyId <Int64?>]`: 
  - `[CredentialId <String>]`: 
  - `[CredentialName <String>]`: 
  - `[DomainId <Int64?>]`: ID of the AD/LDAP domain
  - `[DrOperation <String>]`: Name of DR operation. Case insensitive
  - `[DriveId <Int64?>]`: Id of the Drive of which the drive details has to be displayed
  - `[EntityId <Int64?>]`: Recovery entity Id
  - `[EntityType <String>]`: Type of the entity
  - `[FailoverGroupId <Int64?>]`: Id of the failover group
  - `[GlobalSearchEntity <String>]`: name of global search entity
  - `[HfsShareId <Int64?>]`: Id of the HFS Share to fetch its status
  - `[HyperScaleStorageId <Int64?>]`: Id of hyperscale storage
  - `[HypervisorId <Int64?>]`: Id of the HYpervisor to get
  - `[Id <Int64?>]`: 
  - `[IndexServerClientId <Int64?>]`: Pseudo client id of the index server
  - `[InstanceId <Int64?>]`: Id of the instance to modify
  - `[InventoryId <Int64?>]`: Inventory id
  - `[JobId <Int64?>]`: 
  - `[KmsId <Int64?>]`: Id of Key Management Server
  - `[LibraryId <Int64?>]`: Id of the library to view the data
  - `[MediaAgentId <Int64?>]`: Id of the Media Agent whose details have to be fetched
  - `[MetadataCacheId <Int64?>]`: Id of metadata cache
  - `[ModifierName <String>]`: Name of the modifier to be read.
  - `[Name <String>]`: 
  - `[NameSpace <String>]`: Name of the namespace to browse for content
  - `[NodeId <Int64?>]`: Id of node
  - `[PairId <Int64?>]`: 
  - `[PlanId <Int64?>]`: Id of the object store plan to fetch details
  - `[RecoveryEntityId <Int64?>]`: Recovery entity Id
  - `[RecoveryGroupId <Int64?>]`: Recovery group Id
  - `[RecoveryTargetId <Int64?>]`: id of recovery target
  - `[RegionId <Int64?>]`: Region id to be deleted.
  - `[RegionList <String>]`: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  - `[ReplicationGroupId <String>]`: 
  - `[ReplicationPairId <Int64?>]`: Replication pair id of the Pair
  - `[RequestId <Int64?>]`: Unique identifier for the request
  - `[RoleId <Int64?>]`: Role Id
  - `[RpsId <String>]`: 
  - `[RuleId <Int64?>]`: Id of the rule to update in Plan
  - `[ScheduleId <Int64?>]`: ID of the DR operation schedule
  - `[SchedulePolicyId <Int64?>]`: 
  - `[ServerGroupId <Int64?>]`: Id of the serverGroupId whose details have to be fetched
  - `[ServerId <Int64?>]`: Id of the server to modify
  - `[SnapEngineId <Int64?>]`: Snap Engine Id
  - `[SpareGroupId <Int64?>]`: Id of the Spare group whose properties need to be fetched. spareGroupId can be fetched from GET V4/Storage/Tape/{libraryId}/MediaType
  - `[StoragePoolId <Int64?>]`: Id of the storage pool whose associated copies have to be fetched
  - `[SubclientId <Int64?>]`: Id of the subclient to modify
  - `[TagId <Int64?>]`: Id of the tag to delete
  - `[TagValue <String>]`: tag value to delete
  - `[TopologyId <String>]`: 
  - `[UserGroupId <Int64?>]`: Id of the user-group whose details have to be fetched
  - `[UserId <Int64?>]`: Id of the User whose details have to be fetched
  - `[VMGroupId <Int64?>]`: Id of the VMgroup to update
  - `[VMGuid <String>]`: 
  - `[VMUuid <String>]`: The vmUUID can be obtained from GET /virtualMachines UUID property
  - `[VendorId <Int64?>]`: 

`RECIPIENTBCC <IAlertTargetIdNameType1[]>`: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 
  - `[Type <String>]`: 

`RECIPIENTCC <IAlertTargetIdNameType1[]>`: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 
  - `[Type <String>]`: 

`RECIPIENTTO <IAlertTargetIdNameType1[]>`: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 
  - `[Type <String>]`: 

`TOKENRULEGROUPS <ITokenRuleGroup[]>`: List of rule groups
  - `[Match <String>]`: 
  - `[Rules <List<ITokenRule>>]`: List of rules
    - `[DateRangeFromDate <String>]`: From date value in unix timestamp format
    - `[DateRangeTimeRange <List<ITimeRange>>]`: Time range selection details
      - `[FromTime <String>]`: From time value in unix timestamp format
      - `[ToTime <String>]`: To time value in unix timestamp format
    - `[DateRangeToDate <String>]`: To date value in unix timestamp format
    - `[MatchCondition <String>]`: 
    - `[RuleSecValue <String>]`: Secondary value used for BETWEEN and NOT_BETWEEN matchCondition.
    - `[TimeRangeFromTime <String>]`: From time value in unix timestamp format
    - `[TimeRangeToTime <String>]`: To time value in unix timestamp format
    - `[TokenFormat <String>]`: 
    - `[TokenName <String>]`: Name of the token.
    - `[Value <String>]`: Value to be compared for the token

## RELATED LINKS

