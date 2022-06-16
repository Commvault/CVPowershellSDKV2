---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifyhyperscalestorage
schema: 2.0.0
---

# Invoke-ModifyHyperScaleStorage

## SYNOPSIS
Modify details like name, encryption, security of a specific hyperscale storage

## SYNTAX

### ModifyExpanded (Default)
```
Invoke-ModifyHyperScaleStorage -HyperScaleStorageId <Int32> [-EncryptionCipher <String>] [-EncryptionEncrypt]
 [-EncryptionKeyLength <Int32>] [-KeyProviderId <Int32>] [-KeyProviderName <String>] [-NewName <String>]
 [-Security <IUpdateSecurityAssoc[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Modify
```
Invoke-ModifyHyperScaleStorage -HyperScaleStorageId <Int32> -Body <IUpdateHyperScaleStorage> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentity
```
Invoke-ModifyHyperScaleStorage -InputObject <ICommvaultPowerShellIdentity> -Body <IUpdateHyperScaleStorage>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentityExpanded
```
Invoke-ModifyHyperScaleStorage -InputObject <ICommvaultPowerShellIdentity> [-EncryptionCipher <String>]
 [-EncryptionEncrypt] [-EncryptionKeyLength <Int32>] [-KeyProviderId <Int32>] [-KeyProviderName <String>]
 [-NewName <String>] [-Security <IUpdateSecurityAssoc[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Modify details like name, encryption, security of a specific hyperscale storage

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

### -Body
UpdateHyperScaleStorage
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IUpdateHyperScaleStorage
Parameter Sets: Modify, ModifyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EncryptionCipher
The different types of encryption keys that can be used for encrypting the data.
The values are case sensitive

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

### -EncryptionEncrypt
.

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

### -EncryptionKeyLength
Different keylengths are present for different kinds of ciphers.
Blowfish,Twofish,AES and Serpent all accept both 128 and 256.
DES3 accepts only 192.
GOST accepts only 256.

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

### -HyperScaleStorageId
Id of hyperscale storage

```yaml
Type: System.Int32
Parameter Sets: Modify, ModifyExpanded
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
Parameter Sets: ModifyViaIdentity, ModifyViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -KeyProviderId
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

### -KeyProviderName
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

### -NewName
change the name of the HyperScale storage

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

### -Security
.
To construct, see NOTES section for SECURITY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IUpdateSecurityAssoc[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
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

### Commvault.Powershell.Models.ICommvaultPowerShellIdentity

### Commvault.Powershell.Models.IUpdateHyperScaleStorage

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IUpdateHyperScaleStorage>: UpdateHyperScaleStorage
  - `[EncryptionCipher <String>]`: The different types of encryption keys that can be used for encrypting the data. The values are case sensitive
  - `[EncryptionEncrypt <Boolean?>]`: 
  - `[EncryptionKeyLength <Int32?>]`: Different keylengths are present for different kinds of ciphers. Blowfish,Twofish,AES and Serpent all accept both 128 and 256. DES3 accepts only 192. GOST accepts only 256. 
  - `[KeyProviderId <Int32?>]`: 
  - `[KeyProviderName <String>]`: 
  - `[NewName <String>]`: change the name of the HyperScale storage
  - `[Security <IUpdateSecurityAssoc[]>]`: 
    - `[RoleId <Int32?>]`: 
    - `[RoleName <String>]`: 
    - `[UserGroupId <Int32?>]`: 
    - `[UserGroupName <String>]`: 
    - `[UserId <Int32?>]`: 
    - `[UserName <String>]`: 

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

SECURITY <IUpdateSecurityAssoc[]>: .
  - `[RoleId <Int32?>]`: 
  - `[RoleName <String>]`: 
  - `[UserGroupId <Int32?>]`: 
  - `[UserGroupName <String>]`: 
  - `[UserId <Int32?>]`: 
  - `[UserName <String>]`: 

## RELATED LINKS

