---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/edit-cvalertdefinition
schema: 2.0.0
---

# Edit-CVAlertDefinition

## SYNOPSIS
Edit Alert Definition details

## SYNTAX

### EditExpanded (Default)
```
Edit-CVAlertDefinition -Id <Int64> [-AlertTargetSendAlertTo <String[]>]
 [-Associations <IAlertAssociationIdNameType1[]>] [-LocaleId <Int64>] [-LocaleName <String>]
 [-NewName <String>] [-RecipientBcc <IAlertTargetIdNameType1[]>] [-RecipientCc <IAlertTargetIdNameType1[]>]
 [-RecipientTo <IAlertTargetIdNameType1[]>] [-RecipientWebHookId <Int64>] [-SendIndividualNotifications]
 [-TemplateConsoleMessage <String>] [-TemplateEmailMessage <String>] [-TemplateEventViewerMessage <String>]
 [-TemplateWebhookMessage <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
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
Edit-CVAlertDefinition -InputObject <ICommvaultPowerShellIdentity> [-AlertTargetSendAlertTo <String[]>]
 [-Associations <IAlertAssociationIdNameType1[]>] [-LocaleId <Int64>] [-LocaleName <String>]
 [-NewName <String>] [-RecipientBcc <IAlertTargetIdNameType1[]>] [-RecipientCc <IAlertTargetIdNameType1[]>]
 [-RecipientTo <IAlertTargetIdNameType1[]>] [-RecipientWebHookId <Int64>] [-SendIndividualNotifications]
 [-TemplateConsoleMessage <String>] [-TemplateEmailMessage <String>] [-TemplateEventViewerMessage <String>]
 [-TemplateWebhookMessage <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Edit Alert Definition details

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

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
To construct, see NOTES section for ASSOCIATIONS properties and create a hash table.

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

### -Body
AlertDefinitionsEdit
To construct, see NOTES section for BODY properties and create a hash table.

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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

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

### -RecipientBcc
.
To construct, see NOTES section for RECIPIENTBCC properties and create a hash table.

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
To construct, see NOTES section for RECIPIENTCC properties and create a hash table.

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
To construct, see NOTES section for RECIPIENTTO properties and create a hash table.

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
.

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

### -TemplateConsoleMessage
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

### -TemplateEmailMessage
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

### -TemplateEventViewerMessage
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

### -TemplateWebhookMessage
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

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSOCIATIONS <IAlertAssociationIdNameType1[]>: AlertDefinitionsAssociations
  - `[Id <Int64?>]`: id of the associated entity
  - `[Name <String>]`: name of the associated entity
  - `[Type <String>]`: 

BODY <IAlertDefinitionsEdit>: AlertDefinitionsEdit
  - `[AlertTargetSendAlertTo <String[]>]`: 
  - `[Associations <IAlertAssociationIdNameType1[]>]`: AlertDefinitionsAssociations
    - `[Id <Int64?>]`: id of the associated entity
    - `[Name <String>]`: name of the associated entity
    - `[Type <String>]`: 
  - `[LocaleId <Int64?>]`: 
  - `[LocaleName <String>]`: 
  - `[NewName <String>]`: The new name of the alert definition
  - `[RecipientBcc <IAlertTargetIdNameType1[]>]`: 
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 
    - `[Type <String>]`: 
  - `[RecipientCc <IAlertTargetIdNameType1[]>]`: 
  - `[RecipientTo <IAlertTargetIdNameType1[]>]`: 
  - `[RecipientWebHookId <Int64?>]`: id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list of webhooks, use api GET Webhook
  - `[SendIndividualNotifications <Boolean?>]`: 
  - `[TemplateConsoleMessage <String>]`: the message template for the console notification
  - `[TemplateEmailMessage <String>]`: the message template for the email notification. Contains both email subject as well as body
  - `[TemplateEventViewerMessage <String>]`: the message template for the event viewer notification
  - `[TemplateWebhookMessage <String>]`: the message template for the webhook notification

INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
  - `[AccessPathId <Int64?>]`: Id of the mount path whose access path has to be deleted
  - `[AgentId <Int64?>]`: Id of the agent to be modified
  - `[BackupDestinationId <Int64?>]`: Id of the backupDestination to be modified
  - `[BackupLocationId <Int64?>]`: Id of the backup location whose details have to be fetched
  - `[BlackoutWindowId <Int64?>]`: Id of the Blackout Window whose details have to be fetched
  - `[BucketId <Int64?>]`: Id of Bucket
  - `[CloudStorageId <Int64?>]`: Id of cloud Storage
  - `[CompanyId <Int64?>]`: Id of the Company whose details have to be fetched
  - `[CredentialName <String>]`: 
  - `[DomainId <Int64?>]`: ID of the AD/LDAP domain
  - `[EntityId <Int64?>]`: Unique id for the entity
  - `[EntityType <Int64?>]`: Type of the entity
  - `[GlobalSearchEntity <String>]`: name of global search entity
  - `[HfsShareId <Int64?>]`: Id of the HFS Share to fetch its status
  - `[HyperScaleStorageId <Int64?>]`: Id of hyperscale storage
  - `[HypervisorId <Int64?>]`: Id of the HYpervisor to get
  - `[Id <Int64?>]`: 
  - `[InstanceId <Int64?>]`: Id of the instance to modify
  - `[KmsId <Int64?>]`: Id of Key Management Server
  - `[MediaAgentId <Int64?>]`: Id of the Media Agent whose details have to be fetched
  - `[MetadataCacheId <Int64?>]`: Id of metadata cache
  - `[Name <String>]`: 
  - `[NodeId <Int64?>]`: Id of node
  - `[PairId <Int64?>]`: 
  - `[PlanId <Int64?>]`: Id of the plan to fetch details
  - `[RecoveryTargetId <Int64?>]`: id of recovery target
  - `[RegionId <Int64?>]`: 
  - `[RegionList <String>]`: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  - `[ReplicationGroupId <String>]`: 
  - `[RequestId <Int64?>]`: Unique identifier for the request
  - `[RoleId <Int64?>]`: Role Id
  - `[RpsId <String>]`: 
  - `[RuleId <Int64?>]`: Id of the rule to update in Plan
  - `[ScheduleId <String>]`: 
  - `[SchedulePolicyId <String>]`: 
  - `[ServerGroupId <Int64?>]`: Id of the serverGroupId whose details have to be fetched
  - `[ServerId <Int64?>]`: Id of the server to modify
  - `[StoragePoolId <Int64?>]`: Id of the disk storage pool whose details have to be fetched
  - `[SubclientId <Int64?>]`: Id of the subclient to modify
  - `[TopologyId <String>]`: 
  - `[UserGroupId <Int64?>]`: Id of the user-group whose details have to be fetched
  - `[UserId <Int64?>]`: Id of the User whose details have to be fetched
  - `[VMGroupId <Int64?>]`: Id of the VMgroup to update
  - `[VMUuid <String>]`: The vmUUID can be obtained from GET /virtualMachines UUID property

RECIPIENTBCC <IAlertTargetIdNameType1[]>: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 
  - `[Type <String>]`: 

RECIPIENTCC <IAlertTargetIdNameType1[]>: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 
  - `[Type <String>]`: 

RECIPIENTTO <IAlertTargetIdNameType1[]>: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 
  - `[Type <String>]`: 

## RELATED LINKS

