---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/new-cvalertdefinition
schema: 2.0.0
---

# New-CVAlertDefinition

## SYNOPSIS
Create Alert Definitions

## SYNTAX

```
New-CVAlertDefinition [-AlertTargetRecipientsOperationType <String>] [-AlertTargetSendAlertTo <String[]>]
 [-AlertTypeCategory <String>] [-AlertTypeCriteria <String>]
 [-AlertTypeParamsList <IAlertDefinitionsCriteriaParams[]>] [-Associations <IAlertAssociationIdNameType1[]>]
 [-EventCriterionDetailConditions <IConditionDetails[]>] [-EventCriterionDetailCriteriaName <String>]
 [-EventCriterionDetailOpBetweenConditions <Int64>] [-GlobalConfigInfoActionOnLocalEntity <String>]
 [-GlobalConfigInfoApplyOnAllCommCells] [-GlobalConfigInfoCommcells <IGlobalConfigCommcellInfo[]>]
 [-GlobalConfigInfoName <String>] [-GlobalConfigInfoScope <String>]
 [-GlobalConfigInfoScopeFilterQuery <String>] [-LocaleId <Int64>] [-LocaleName <String>] [-Name <String>]
 [-NotificationCriterionDelayTime <Int64>] [-NotificationCriterionPersistTime <Int64>]
 [-NotificationCriterionValue <Int64>] [-ProcessDiscoveredVMS] [-RecipientBcc <IAlertTargetIdNameType1[]>]
 [-RecipientCc <IAlertTargetIdNameType1[]>] [-RecipientTo <IAlertTargetIdNameType1[]>]
 [-RecipientWebHookId <Int64>] [-SendIndividualNotifications] [-SubscriptionBasedAlert]
 [-TemplateConsole <String>] [-TemplateEmail <String>] [-TemplateEventViewer <String>]
 [-TemplateWebhook <String>] [-TemplateWorkflowInputDetails <String>] [-TokenMatch <String>]
 [-TokenRuleGroups <ITokenRuleGroup[]>] [-WorkflowClientId <Int64>] [-WorkflowClientName <String>]
 [-WorkflowId <Int64>] [-WorkflowName <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create Alert Definitions

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
Parameter Sets: (All)
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertTypeCategory
Defines the category of the alert

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertTypeCriteria
Defines the criteria of the alert

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertTypeParamsList
.

```yaml
Type: Commvault.Powershell.Models.IAlertDefinitionsCriteriaParams[]
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoActionOnLocalEntity
Action that will be taken on the local entity that has the same name as the global entity that needs to be created

```yaml
Type: System.String
Parameter Sets: (All)
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoCommcells
List of Service CommCells where the global configuration should be applied

```yaml
Type: Commvault.Powershell.Models.IGlobalConfigCommcellInfo[]
Parameter Sets: (All)
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoScope
The entity level at which the config has to be applied.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoScopeFilterQuery
CommCellEntityCache filter query string using for filtering the scope

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocaleId
.

```yaml
Type: System.Int64
Parameter Sets: (All)
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationCriterionDelayTime
Delayed time in seconds when the notification criteria value contains delayed flag

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationCriterionPersistTime
Persisting time in seconds when the notification criteria value contains repeated flag

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationCriterionValue
Bit flag indicating notification criteria value.
1 means immediate, 2 means repeated and 8 means delayed

```yaml
Type: System.Int64
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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

## OUTPUTS

### Commvault.Powershell.Models.IIdNameGuid

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ALERTTYPEPARAMSLIST <IAlertDefinitionsCriteriaParams[]>`: .
  - `[ParamIndex <Int64?>]`: Param order index
  - `[Type <Int64?>]`: Input value type (default 0 = no input required)
  - `[Unit <Int64?>]`: Unit of the criteria(For eg. :Hrs,min)
  - `[Value <Int64?>]`: Value of the criteria (deefault 0 : if no value required)

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

`EVENTCRITERIONDETAILCONDITIONS <IConditionDetails[]>`: .
  - `Id <Int64>`: Unique identifier for the condition column
  - `Name <String>`: Name of the condition column
  - `Operation <String>`: Operation type value for the condition column
  - `[AdvancedCriteria <List<String>>]`: List of advanced criteria options
  - `[FromValue <String>]`: First value associated with the column when the operation type is BETWEEN
  - `[ToValue <String>]`: Second value associated with the column when the operation type is BETWEEN
  - `[Value <String>]`: Value associated with the column
  - `[ValuesList <List<Int64>>]`: List of the values associated with the column in case of multiple values selection

`GLOBALCONFIGINFOCOMMCELLS <IGlobalConfigCommcellInfo[]>`: List of Service CommCells where the global configuration should be applied
  - `[Guid <String>]`: 
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

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

