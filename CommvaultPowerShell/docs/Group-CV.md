---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/group-cv
schema: 2.0.0
---

# Group-CV

## SYNOPSIS
To Backup the virtual machines in vmgroup

## SYNTAX

### GroupExpanded (Default)
```
Group-CV [-HypervisorId <Int64>] [-ContentOverwrite] [-ContentRuleGroups <IRuleGroupContent[]>]
 [-ContentVirtualMachines <IVirtualMachinecontent[]>] [-DiskFilterOverwrite]
 [-DiskFilterRules <IVMDiskFilter[]>] [-FilterOverwrite] [-FilterRuleGroups <IRuleGroupContent[]>]
 [-FilterVirtualMachines <IVirtualMachinecontent[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Group
```
Group-CV -VMGroupId <Int64> [-BackupLevel <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Group1
```
Group-CV -Body <IVMGroupPreviewReq> [-HypervisorId <Int64>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GroupViaIdentity
```
Group-CV -InputObject <ICommvaultPowerShellIdentity> [-BackupLevel <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
To Backup the virtual machines in vmgroup

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

### -BackupLevel
Backup level , Default :Incremental

```yaml
Type: System.String
Parameter Sets: Group, GroupViaIdentity
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
vmGroupPreviewReq
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IVMGroupPreviewReq
Parameter Sets: Group1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentOverwrite
True if content in vmgroup has to be overwritten, by default it will append the content

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: GroupExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentRuleGroups
.
To construct, see NOTES section for CONTENTRULEGROUPS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IRuleGroupContent[]
Parameter Sets: GroupExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentVirtualMachines
.
To construct, see NOTES section for CONTENTVIRTUALMACHINES properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IVirtualMachinecontent[]
Parameter Sets: GroupExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DiskFilterOverwrite
True if content in vmgroup has to be overwritten, by default it will append the content

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: GroupExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DiskFilterRules
.
To construct, see NOTES section for DISKFILTERRULES properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IVMDiskFilter[]
Parameter Sets: GroupExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilterOverwrite
True if content in vmgroup has to be overwritten, by default it will append the content

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: GroupExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilterRuleGroups
.
To construct, see NOTES section for FILTERRULEGROUPS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IRuleGroupContent[]
Parameter Sets: GroupExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilterVirtualMachines
.
To construct, see NOTES section for FILTERVIRTUALMACHINES properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IVirtualMachinecontent[]
Parameter Sets: GroupExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HypervisorId
Hypervisor Id of VMGroup

```yaml
Type: System.Int64
Parameter Sets: Group1, GroupExpanded
Aliases:

Required: False
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
Parameter Sets: GroupViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -VMGroupId
Id of the VMgroup to backup

```yaml
Type: System.Int64
Parameter Sets: Group
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

### Commvault.Powershell.Models.IVMGroupPreviewReq

## OUTPUTS

### Commvault.Powershell.Models.ICreateTaskRespforBackup

### Commvault.Powershell.Models.IGenericResp

### Commvault.Powershell.Models.IVMGroupPreviewResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IVMGroupPreviewReq>: vmGroupPreviewReq
  - `[ContentOverwrite <Boolean?>]`: True if content in vmgroup has to be overwritten, by default it will append the content
  - `[ContentRuleGroups <IRuleGroupContent[]>]`: 
    - `[MatchRule <String>]`: Enum which specifies the whether to match all rules or any of the rules
    - `[Rules <IRuleContent[]>]`: 
      - `[Condition <String>]`: Operation type for VM rules/filters
      - `[DisplayName <String>]`: The display name of the entity to be added
      - `[Guid <String>]`: GUID of the entity to be added as content
      - `[Name <String>]`: name of the VM to be added as content
      - `[Type <String>]`: 
      - `[Value <String>]`: value for the few type of VM Content like powerstate
  - `[ContentVirtualMachines <IVirtualMachinecontent[]>]`: 
    - `[ExistingCredentialId <Int64?>]`: 
    - `[ExistingCredentialName <String>]`: 
    - `[GuestCredentialAssocId <Int64?>]`: Credential association ID given to link entity with credential id.
    - `[GuestCredentialsPassword <String>]`: 
    - `[GuestCredentialsUserName <String>]`: 
    - `[Guid <String>]`: GUID of the VM to be added as content
    - `[Name <String>]`: name of the VM to be added as content
    - `[Type <String>]`: 
  - `[DiskFilterOverwrite <Boolean?>]`: True if content in vmgroup has to be overwritten, by default it will append the content
  - `[DiskFilterRules <IVMDiskFilter[]>]`: 
    - `[Condition <String>]`: Operation type for VM rules/filters
    - `[FilterType <String>]`: 
    - `[Name <String>]`: The string to be filtered
    - `[Overwrite <Boolean?>]`: True if disk filter in vmgroup has to be overwritten, by default it will append the content
    - `[VMGuid <String>]`: VM Guid of the Virtual Machine whose disk has to be filtered . This is optional. if not given, all disks of name and type from all Vms added in content will be filtered
    - `[VMName <String>]`: VM Name of the Virtual Machine whose disk has to be filtered . This is optional. if not given, all disks of name and type from all Vms added in content will be filtered
    - `[Value <String>]`: The value string to be filtered, in case of disk tag , value of tag to be filtered
  - `[FilterOverwrite <Boolean?>]`: True if content in vmgroup has to be overwritten, by default it will append the content
  - `[FilterRuleGroups <IRuleGroupContent[]>]`: 
  - `[FilterVirtualMachines <IVirtualMachinecontent[]>]`: 

CONTENTRULEGROUPS <IRuleGroupContent[]>: .
  - `[MatchRule <String>]`: Enum which specifies the whether to match all rules or any of the rules
  - `[Rules <IRuleContent[]>]`: 
    - `[Condition <String>]`: Operation type for VM rules/filters
    - `[DisplayName <String>]`: The display name of the entity to be added
    - `[Guid <String>]`: GUID of the entity to be added as content
    - `[Name <String>]`: name of the VM to be added as content
    - `[Type <String>]`: 
    - `[Value <String>]`: value for the few type of VM Content like powerstate

CONTENTVIRTUALMACHINES <IVirtualMachinecontent[]>: .
  - `[ExistingCredentialId <Int64?>]`: 
  - `[ExistingCredentialName <String>]`: 
  - `[GuestCredentialAssocId <Int64?>]`: Credential association ID given to link entity with credential id.
  - `[GuestCredentialsPassword <String>]`: 
  - `[GuestCredentialsUserName <String>]`: 
  - `[Guid <String>]`: GUID of the VM to be added as content
  - `[Name <String>]`: name of the VM to be added as content
  - `[Type <String>]`: 

DISKFILTERRULES <IVMDiskFilter[]>: .
  - `[Condition <String>]`: Operation type for VM rules/filters
  - `[FilterType <String>]`: 
  - `[Name <String>]`: The string to be filtered
  - `[Overwrite <Boolean?>]`: True if disk filter in vmgroup has to be overwritten, by default it will append the content
  - `[VMGuid <String>]`: VM Guid of the Virtual Machine whose disk has to be filtered . This is optional. if not given, all disks of name and type from all Vms added in content will be filtered
  - `[VMName <String>]`: VM Name of the Virtual Machine whose disk has to be filtered . This is optional. if not given, all disks of name and type from all Vms added in content will be filtered
  - `[Value <String>]`: The value string to be filtered, in case of disk tag , value of tag to be filtered

FILTERRULEGROUPS <IRuleGroupContent[]>: .
  - `[MatchRule <String>]`: Enum which specifies the whether to match all rules or any of the rules
  - `[Rules <IRuleContent[]>]`: 
    - `[Condition <String>]`: Operation type for VM rules/filters
    - `[DisplayName <String>]`: The display name of the entity to be added
    - `[Guid <String>]`: GUID of the entity to be added as content
    - `[Name <String>]`: name of the VM to be added as content
    - `[Type <String>]`: 
    - `[Value <String>]`: value for the few type of VM Content like powerstate

FILTERVIRTUALMACHINES <IVirtualMachinecontent[]>: .
  - `[ExistingCredentialId <Int64?>]`: 
  - `[ExistingCredentialName <String>]`: 
  - `[GuestCredentialAssocId <Int64?>]`: Credential association ID given to link entity with credential id.
  - `[GuestCredentialsPassword <String>]`: 
  - `[GuestCredentialsUserName <String>]`: 
  - `[Guid <String>]`: GUID of the VM to be added as content
  - `[Name <String>]`: name of the VM to be added as content
  - `[Type <String>]`: 

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

## RELATED LINKS

