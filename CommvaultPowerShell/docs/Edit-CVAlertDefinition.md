---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/edit-cvalertdefinition
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
 [-AssociationsOperationType <String>] [-LocaleId <Int64>] [-LocaleName <String>] [-NewName <String>]
 [-RecipientBcc <IAlertTargetIdNameType1[]>] [-RecipientCc <IAlertTargetIdNameType1[]>]
 [-RecipientTo <IAlertTargetIdNameType1[]>] [-RecipientWebHookId <Int64>] [-SendIndividualNotifications]
 [-TemplateConsole <String>] [-TemplateEmail <String>] [-TemplateEventViewer <String>]
 [-TemplateWebhook <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
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
 [-Associations <IAlertAssociationIdNameType1[]>] [-AssociationsOperationType <String>] [-LocaleId <Int64>]
 [-LocaleName <String>] [-NewName <String>] [-RecipientBcc <IAlertTargetIdNameType1[]>]
 [-RecipientCc <IAlertTargetIdNameType1[]>] [-RecipientTo <IAlertTargetIdNameType1[]>]
 [-RecipientWebHookId <Int64>] [-SendIndividualNotifications] [-TemplateConsole <String>]
 [-TemplateEmail <String>] [-TemplateEventViewer <String>] [-TemplateWebhook <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Edit Alert Definition details

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

BODY <IAlertDefinitionsEdit>: AlertDefinitionsEdit
  - `[AlertTargetRecipientsOperationType <String>]`: Allows adding to, overwriting and deleting existing recipients. default is adding to existing recipients
  - `[AlertTargetSendAlertTo <String[]>]`: 
  - `[Associations <IAlertAssociationIdNameType1[]>]`: AlertDefinitionsAssociations
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
  - `[TemplateConsole <String>]`: the message template for the console notification
  - `[TemplateEmail <String>]`: the message template for the email notification. Contains both email subject as well as body
  - `[TemplateEventViewer <String>]`: the message template for the event viewer notification
  - `[TemplateWebhook <String>]`: the message template for the webhook notification

INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
  - `[AccessPathId <Int64?>]`: Id of the mount path whose access path has to be deleted
  - `[AgentId <Int64?>]`: Id of the agent to be modified
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
  - `[CloudStorageId <Int64?>]`: Id of cloud Storage
  - `[ClusterId <Int64?>]`: 
  - `[CompanyId <Int64?>]`: Id of the Company whose details have to be fetched
  - `[CopyId <Int64?>]`: 
  - `[CredentialId <String>]`: 
  - `[CredentialName <String>]`: 
  - `[DomainId <Int64?>]`: ID of the AD/LDAP domain
  - `[DrOperation <String>]`: Name of DR operation. Case insensitive
  - `[DriveId <Int64?>]`: Id of the Drive of which the drive details has to be displayed
  - `[EntityId <Int64?>]`: Unique id for the entity
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
  - `[Name <String>]`: 
  - `[NameSpace <String>]`: Name of the namespace to browse for content
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
  - `[ScheduleId <Int64?>]`: ID of the DR operation schedule
  - `[SchedulePolicyId <Int64?>]`: 
  - `[ServerGroupId <Int64?>]`: Id of the serverGroupId whose details have to be fetched
  - `[ServerId <Int64?>]`: Id of the server to modify
  - `[StoragePoolId <Int64?>]`: Id of the storage pool whose associated copies have to be fetched
  - `[SubclientId <Int64?>]`: Id of the subclient to modify
  - `[TagId <Int64?>]`: Id of the tag to delete
  - `[TagValue <String>]`: tag value to delete
  - `[TopologyId <String>]`: 
  - `[UserGroupId <Int64?>]`: Id of the user-group whose details have to be fetched
  - `[UserId <Int64?>]`: Id of the User whose details have to be fetched
  - `[VMGroupId <Int64?>]`: Id of the VMgroup to update
  - `[VMGuid <String>]`: GUID of the Provisioned VM
  - `[VMUuid <String>]`: The vmUUID can be obtained from GET /virtualMachines UUID property
  - `[VendorId <Int64?>]`: 

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

