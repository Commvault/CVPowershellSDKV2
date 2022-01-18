---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-alertdefinition
schema: 2.0.0
---

# New-AlertDefinition

## SYNOPSIS
Create Alert Definitions

## SYNTAX

### CreateExpanded (Default)
```
New-AlertDefinition [-AlertTargetSendAlertTo <String[]>] [-AlertTypeCategory <String>]
 [-AlertTypeCriteria <String>] [-AlertTypeParamsList <IAlertDefinitionsCriteriaParams[]>]
 [-Associations <IAlertAssociationIdNameType1[]>] [-LocaleId <Int32>] [-LocaleName <String>] [-Name <String>]
 [-RecipientBcc <IAlertTargetIdNameType1[]>] [-RecipientCc <IAlertTargetIdNameType1[]>]
 [-RecipientTo <IAlertTargetIdNameType1[]>] [-RecipientWebHookId <Int32>] [-SendIndividualNotifications]
 [-TemplateConsoleMessage <String>] [-TemplateEmailMessage <String>] [-TemplateEventViewerMessage <String>]
 [-TemplateWebhookMessage <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-AlertDefinition -Body <IAlertDefinitonsCreate> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create Alert Definitions

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AlertTargetSendAlertTo
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertTypeParamsList
.
To construct, see NOTES section for ALERTTYPEPARAMSLIST properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IAlertDefinitionsCriteriaParams[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Associations
AlertDefinitionsAssociations
To construct, see NOTES section for ASSOCIATIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IAlertAssociationIdNameType1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
AlertDefinitonsCreate
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IAlertDefinitonsCreate
Parameter Sets: Create
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
Type: System.Int32
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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

### -RecipientBcc
.
To construct, see NOTES section for RECIPIENTBCC properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IAlertTargetIdNameType1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecipientCc
.
To construct, see NOTES section for RECIPIENTCC properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IAlertTargetIdNameType1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecipientTo
.
To construct, see NOTES section for RECIPIENTTO properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IAlertTargetIdNameType1[]
Parameter Sets: CreateExpanded
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
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SendIndividualNotifications
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateConsoleMessage
the message template for the console notification

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateEmailMessage
the message template for the email notification.
Contains both email subject as well as body

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateEventViewerMessage
the message template for the event viewer notification

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateWebhookMessage
the message template for the webhook notification

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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

### Commvault.Powershell.Models.IAlertDefinitonsCreate

## OUTPUTS

### Commvault.Powershell.Models.IIdName

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALERTTYPEPARAMSLIST <IAlertDefinitionsCriteriaParams[]>: .
  - `[ParamIndex <Int32?>]`: Param order index
  - `[Type <Int32?>]`: Input value type (default 0 = no input required)
  - `[Unit <Int32?>]`: Unit of the criteria(For eg. :Hrs,min)
  - `[Value <Int32?>]`: Value of the criteria (deefault 0 : if no value required)

ASSOCIATIONS <IAlertAssociationIdNameType1[]>: AlertDefinitionsAssociations
  - `[Id <Int32?>]`: id of the associated entity
  - `[Name <String>]`: name of the associated entity
  - `[Type <String>]`: 

BODY <IAlertDefinitonsCreate>: AlertDefinitonsCreate
  - `[AlertTargetSendAlertTo <String[]>]`: 
  - `[AlertTypeCategory <String>]`: Defines the category of the alert
  - `[AlertTypeCriteria <String>]`: Defines the criteria of the alert
  - `[AlertTypeParamsList <IAlertDefinitionsCriteriaParams[]>]`: 
    - `[ParamIndex <Int32?>]`: Param order index
    - `[Type <Int32?>]`: Input value type (default 0 = no input required)
    - `[Unit <Int32?>]`: Unit of the criteria(For eg. :Hrs,min)
    - `[Value <Int32?>]`: Value of the criteria (deefault 0 : if no value required)
  - `[Associations <IAlertAssociationIdNameType1[]>]`: AlertDefinitionsAssociations
    - `[Id <Int32?>]`: id of the associated entity
    - `[Name <String>]`: name of the associated entity
    - `[Type <String>]`: 
  - `[LocaleId <Int32?>]`: 
  - `[LocaleName <String>]`: 
  - `[Name <String>]`: 
  - `[RecipientBcc <IAlertTargetIdNameType1[]>]`: 
    - `[Id <Int32?>]`: 
    - `[Name <String>]`: 
    - `[Type <String>]`: 
  - `[RecipientCc <IAlertTargetIdNameType1[]>]`: 
  - `[RecipientTo <IAlertTargetIdNameType1[]>]`: 
  - `[RecipientWebHookId <Int32?>]`: id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list of webhooks, use api GET Webhook
  - `[SendIndividualNotifications <Boolean?>]`: 
  - `[TemplateConsoleMessage <String>]`: the message template for the console notification
  - `[TemplateEmailMessage <String>]`: the message template for the email notification. Contains both email subject as well as body
  - `[TemplateEventViewerMessage <String>]`: the message template for the event viewer notification
  - `[TemplateWebhookMessage <String>]`: the message template for the webhook notification

RECIPIENTBCC <IAlertTargetIdNameType1[]>: .
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 
  - `[Type <String>]`: 

RECIPIENTCC <IAlertTargetIdNameType1[]>: .
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 
  - `[Type <String>]`: 

RECIPIENTTO <IAlertTargetIdNameType1[]>: .
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 
  - `[Type <String>]`: 

## RELATED LINKS

