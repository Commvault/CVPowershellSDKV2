---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifyvirtualmachine
schema: 2.0.0
---

# Invoke-ModifyVirtualMachine

## SYNOPSIS
Modify the properties of an existing virtual machine

## SYNTAX

### ModifyExpanded (Default)
```
Invoke-ModifyVirtualMachine -VMUuid <String> [-AuthKeyRestoreAuthOpType]
 [-AuthKeyRestoreExpirationTime <Int32>] [-AuthKeyRestorePassKey <String>] [-PlanId <Int32>]
 [-PlanName <String>] [-RequirePasskeyForRestoreConfirmPassKey <String>]
 [-RequirePasskeyForRestoreCurrentPassKey <String>] [-RequirePasskeyForRestoreNewPassKey <String>]
 [-RequirePasskeyForRestoreOperationType <String>] [-SecurityAssociations <IVMSecurityAssoc[]>]
 [-SecurityOwners <ISecurityOwnersAssoc[]>] [-SecurityPermissions <IPermissionResp[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Modify
```
Invoke-ModifyVirtualMachine -VMUuid <String> -Body <IUpdateVMProperties> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ModifyViaIdentity
```
Invoke-ModifyVirtualMachine -InputObject <ICommvaultPowerShellIdentity> -Body <IUpdateVMProperties>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentityExpanded
```
Invoke-ModifyVirtualMachine -InputObject <ICommvaultPowerShellIdentity> [-AuthKeyRestoreAuthOpType]
 [-AuthKeyRestoreExpirationTime <Int32>] [-AuthKeyRestorePassKey <String>] [-PlanId <Int32>]
 [-PlanName <String>] [-RequirePasskeyForRestoreConfirmPassKey <String>]
 [-RequirePasskeyForRestoreCurrentPassKey <String>] [-RequirePasskeyForRestoreNewPassKey <String>]
 [-RequirePasskeyForRestoreOperationType <String>] [-SecurityAssociations <IVMSecurityAssoc[]>]
 [-SecurityOwners <ISecurityOwnersAssoc[]>] [-SecurityPermissions <IPermissionResp[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Modify the properties of an existing virtual machine

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

### -AuthKeyRestoreAuthOpType
The type of authorize for restore operation

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthKeyRestoreExpirationTime
The duration(in unix time) for which a user can continue browsing and restoring backup data without being prompted to enter the passkey, again.

```yaml
Type: System.Int32
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthKeyRestorePassKey
The existing passkey for restricting backup restores.

```yaml
Type: System.String
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
UpdateVMProperties
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IUpdateVMProperties
Parameter Sets: Modify, ModifyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICommvaultPowerShellIdentity
Parameter Sets: ModifyViaIdentity, ModifyViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -PlanId
.

```yaml
Type: System.Int32
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanName
.

```yaml
Type: System.String
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequirePasskeyForRestoreConfirmPassKey
Confirm the new passkey for restricting backup restores.

```yaml
Type: System.String
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequirePasskeyForRestoreCurrentPassKey
The current passkey for restricting backup restores.

```yaml
Type: System.String
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequirePasskeyForRestoreNewPassKey
The new passkey for restricting backup restores.

```yaml
Type: System.String
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequirePasskeyForRestoreOperationType
The type of passkey operation

```yaml
Type: System.String
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityAssociations
.
To construct, see NOTES section for SECURITYASSOCIATIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IVMSecurityAssoc[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityOwners
.
To construct, see NOTES section for SECURITYOWNERS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ISecurityOwnersAssoc[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityPermissions
.
To construct, see NOTES section for SECURITYPERMISSIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IPermissionResp[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMUuid
The vmUUID can be obtained from GET /virtualMachines UUID property

```yaml
Type: System.String
Parameter Sets: Modify, ModifyExpanded
Aliases:

Required: True
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

### Commvault.Powershell.Models.ICommvaultPowerShellIdentity

### Commvault.Powershell.Models.IUpdateVMProperties

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IUpdateVMProperties>: UpdateVMProperties
  - `[AuthKeyRestoreAuthOpType <Boolean?>]`: The type of authorize for restore operation
  - `[AuthKeyRestoreExpirationTime <Int32?>]`: The duration(in unix time) for which a user can continue browsing and restoring backup data without being prompted to enter the passkey, again.
  - `[AuthKeyRestorePassKey <String>]`: The existing passkey for restricting backup restores.
  - `[PlanId <Int32?>]`: 
  - `[PlanName <String>]`: 
  - `[RequirePasskeyForRestoreConfirmPassKey <String>]`: Confirm the new passkey for restricting backup restores.
  - `[RequirePasskeyForRestoreCurrentPassKey <String>]`: The current passkey for restricting backup restores.
  - `[RequirePasskeyForRestoreNewPassKey <String>]`: The new passkey for restricting backup restores.
  - `[RequirePasskeyForRestoreOperationType <String>]`: The type of passkey operation
  - `[SecurityAssociations <IVMSecurityAssoc[]>]`: 
    - `[RoleId <Int32?>]`: 
    - `[RoleName <String>]`: 
    - `[UseGroupCompanyId <Int32?>]`: 
    - `[UseGroupCompanyName <String>]`: 
    - `[UseGroupId <Int32?>]`: 
    - `[UseGroupName <String>]`: 
    - `[UserCompanyId <Int32?>]`: 
    - `[UserCompanyName <String>]`: 
    - `[UserId <Int32?>]`: 
    - `[UserName <String>]`: 
  - `[SecurityOwners <ISecurityOwnersAssoc[]>]`: 
    - `[UserGroupId <Int32?>]`: 
    - `[UserGroupName <String>]`: 
    - `[UserId <Int32?>]`: 
    - `[UserName <String>]`: 
  - `[SecurityPermissions <IPermissionResp[]>]`: 
    - `[CategoryId <Int32?>]`: 
    - `[CategoryName <String>]`: 
    - `[PermissionId <Int32?>]`: 
    - `[PermissionName <String>]`: 
    - `[Type <String>]`: Returns the type of association.

INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
  - `[AccessPathId <Int32?>]`: Id of the mount path whose access path has to be deleted
  - `[AgentId <Int32?>]`: Id of the agent to be modified
  - `[BackupDestinationId <Int32?>]`: Id of the backupDestination to be modified
  - `[BackupLocationId <Int32?>]`: Id of the backup location whose details have to be fetched
  - `[BlackoutWindowId <Int32?>]`: Id of the Blackout Window whose details have to be fetched
  - `[BucketId <Int32?>]`: Id of Bucket
  - `[CloudStorageId <Int32?>]`: Id of cloud Storage
  - `[CompanyId <Int32?>]`: Id of the Company whose details have to be fetched
  - `[CredentialName <String>]`: 
  - `[DomainId <Int32?>]`: ID of the AD/LDAP domain
  - `[EntityId <Int32?>]`: Unique id for the entity
  - `[EntityType <Int32?>]`: Type of the entity
  - `[GlobalSearchEntity <String>]`: name of global search entity
  - `[HfsShareId <Int32?>]`: Id of the HFS Share to fetch its status
  - `[HyperScaleStorageId <Int32?>]`: Id of hyperscale storage
  - `[HypervisorId <Int32?>]`: Id of the Hypervisor to update
  - `[Id <Int32?>]`: 
  - `[InstanceId <Int32?>]`: Id of the instance to modify
  - `[InventoryEntityName <String>]`: Name of the inventory entity that needs to be browsed like ESX Host name in VCenter
  - `[KmsId <Int32?>]`: Id of Key Management Server
  - `[MediaAgentId <Int32?>]`: Id of the Media Agent whose details have to be fetched
  - `[MetadataCacheId <Int32?>]`: Id of metadata cache
  - `[Name <String>]`: 
  - `[NodeId <Int32?>]`: Id of node
  - `[PairId <Int32?>]`: 
  - `[PlanId <Int32?>]`: Id of the plan to fetch details
  - `[RecoveryTargetId <Int32?>]`: id of recovery target
  - `[RegionId <Int32?>]`: 
  - `[RegionList <String>]`: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  - `[ReplicationGroupId <String>]`: 
  - `[RequestId <Int32?>]`: Unique identifier for the request
  - `[RoleId <Int32?>]`: Role Id
  - `[RpsId <String>]`: 
  - `[RuleId <Int32?>]`: Id of the rule to update in Plan
  - `[ScheduleId <String>]`: 
  - `[SchedulePolicyId <String>]`: 
  - `[ServerGroupId <Int32?>]`: Id of the serverGroupId whose details have to be fetched
  - `[ServerId <Int32?>]`: Id of the server to modify
  - `[StoragePoolId <Int32?>]`: Id of the disk storage pool whose details have to be fetched
  - `[SubclientId <Int32?>]`: Id of the subclient to modify
  - `[TopologyId <String>]`: 
  - `[UserGroupId <Int32?>]`: Id of the user-group whose details have to be fetched
  - `[UserId <Int32?>]`: Id of the User whose details have to be fetched
  - `[VMGroupId <Int32?>]`: Id of the VMgroup to update
  - `[VMUuid <String>]`: The vmUUID can be obtained from GET /virtualMachines UUID property

SECURITYASSOCIATIONS <IVMSecurityAssoc[]>: .
  - `[RoleId <Int32?>]`: 
  - `[RoleName <String>]`: 
  - `[UseGroupCompanyId <Int32?>]`: 
  - `[UseGroupCompanyName <String>]`: 
  - `[UseGroupId <Int32?>]`: 
  - `[UseGroupName <String>]`: 
  - `[UserCompanyId <Int32?>]`: 
  - `[UserCompanyName <String>]`: 
  - `[UserId <Int32?>]`: 
  - `[UserName <String>]`: 

SECURITYOWNERS <ISecurityOwnersAssoc[]>: .
  - `[UserGroupId <Int32?>]`: 
  - `[UserGroupName <String>]`: 
  - `[UserId <Int32?>]`: 
  - `[UserName <String>]`: 

SECURITYPERMISSIONS <IPermissionResp[]>: .
  - `[CategoryId <Int32?>]`: 
  - `[CategoryName <String>]`: 
  - `[PermissionId <Int32?>]`: 
  - `[PermissionName <String>]`: 
  - `[Type <String>]`: Returns the type of association.

## RELATED LINKS

