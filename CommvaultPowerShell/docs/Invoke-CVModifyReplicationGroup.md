---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-cvmodifyreplicationgroup
schema: 2.0.0
---

# Invoke-CVModifyReplicationGroup

## SYNOPSIS
Modify the properties of an existing replication group

## SYNTAX

### ModifyExpanded (Default)
```
Invoke-CVModifyReplicationGroup -ReplicationGroupId <String> [-AdvancedOptionContinueOnFailure]
 [-AdvancedOptionDelayBetweenPriorityMachines <Int64>] [-AdvancedOptionScript <IReplicationGroupScript>]
 [-Disable] [-Enable] [-NewName <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Modify
```
Invoke-CVModifyReplicationGroup -ReplicationGroupId <String> -Body <IUpdateReplicationGroup> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentity
```
Invoke-CVModifyReplicationGroup -InputObject <ICommvaultPowerShellIdentity> -Body <IUpdateReplicationGroup>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentityExpanded
```
Invoke-CVModifyReplicationGroup -InputObject <ICommvaultPowerShellIdentity> [-AdvancedOptionContinueOnFailure]
 [-AdvancedOptionDelayBetweenPriorityMachines <Int64>] [-AdvancedOptionScript <IReplicationGroupScript>]
 [-Disable] [-Enable] [-NewName <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Modify the properties of an existing replication group

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

### -AdvancedOptionContinueOnFailure
Set to true to continue to the next priority machines on failure.

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

### -AdvancedOptionDelayBetweenPriorityMachines
The delay between machines in different priorities.
Mention in minutes

```yaml
Type: System.Int64
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdvancedOptionScript
All the scripts of replication group
To construct, see NOTES section for ADVANCEDOPTIONSCRIPT properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IReplicationGroupScript
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
UpdateReplicationGroupReq
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IUpdateReplicationGroup
Parameter Sets: Modify, ModifyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Disable
Used to disable a replication group

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

### -Enable
Used to enable a replication group

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

### -NewName
Used to change the name of a replication group

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

### -ReplicationGroupId
.

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

### Commvault.Powershell.Models.IUpdateReplicationGroup

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADVANCEDOPTIONSCRIPT <IReplicationGroupScript>: All the scripts of replication group
  - `[PostFailbackGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailbackGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailbackGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailbackGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailbackPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PostFailbackReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PostFailbackScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailbackScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailbackScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailbackScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailbackType <String>]`: The type of path being used for DR operation script
  - `[PostFailoverGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailoverGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailoverGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailoverGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailoverPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PostFailoverReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PostFailoverScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailoverScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailoverScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailoverScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailoverType <String>]`: The type of path being used for DR operation script
  - `[PreFailbackGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailbackGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailbackGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailbackGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailbackPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PreFailbackReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PreFailbackScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailbackScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailbackScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailbackScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailbackType <String>]`: The type of path being used for DR operation script
  - `[PreFailoverGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailoverGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailoverGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailoverGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailoverPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PreFailoverReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PreFailoverScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailoverScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailoverScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailoverScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailoverType <String>]`: The type of path being used for DR operation script

BODY <IUpdateReplicationGroup>: UpdateReplicationGroupReq
  - `[AdvancedOptionContinueOnFailure <Boolean?>]`: Set to true to continue to the next priority machines on failure.
  - `[AdvancedOptionDelayBetweenPriorityMachines <Int64?>]`: The delay between machines in different priorities. Mention in minutes
  - `[AdvancedOptionScript <IReplicationGroupScript>]`: All the scripts of replication group
    - `[PostFailbackGuestCredentialsCredentialsName <String>]`: username to access the network path
    - `[PostFailbackGuestCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[PostFailbackGuestCredentialsSavedCredentialsId <Int64?>]`: 
    - `[PostFailbackGuestCredentialsSavedCredentialsName <String>]`: 
    - `[PostFailbackPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
    - `[PostFailbackReset <Boolean?>]`: On set to true, resets the script to empty
    - `[PostFailbackScriptCredentialsCredentialsName <String>]`: username to access the network path
    - `[PostFailbackScriptCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[PostFailbackScriptCredentialsSavedCredentialsId <Int64?>]`: 
    - `[PostFailbackScriptCredentialsSavedCredentialsName <String>]`: 
    - `[PostFailbackType <String>]`: The type of path being used for DR operation script
    - `[PostFailoverGuestCredentialsCredentialsName <String>]`: username to access the network path
    - `[PostFailoverGuestCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[PostFailoverGuestCredentialsSavedCredentialsId <Int64?>]`: 
    - `[PostFailoverGuestCredentialsSavedCredentialsName <String>]`: 
    - `[PostFailoverPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
    - `[PostFailoverReset <Boolean?>]`: On set to true, resets the script to empty
    - `[PostFailoverScriptCredentialsCredentialsName <String>]`: username to access the network path
    - `[PostFailoverScriptCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[PostFailoverScriptCredentialsSavedCredentialsId <Int64?>]`: 
    - `[PostFailoverScriptCredentialsSavedCredentialsName <String>]`: 
    - `[PostFailoverType <String>]`: The type of path being used for DR operation script
    - `[PreFailbackGuestCredentialsCredentialsName <String>]`: username to access the network path
    - `[PreFailbackGuestCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[PreFailbackGuestCredentialsSavedCredentialsId <Int64?>]`: 
    - `[PreFailbackGuestCredentialsSavedCredentialsName <String>]`: 
    - `[PreFailbackPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
    - `[PreFailbackReset <Boolean?>]`: On set to true, resets the script to empty
    - `[PreFailbackScriptCredentialsCredentialsName <String>]`: username to access the network path
    - `[PreFailbackScriptCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[PreFailbackScriptCredentialsSavedCredentialsId <Int64?>]`: 
    - `[PreFailbackScriptCredentialsSavedCredentialsName <String>]`: 
    - `[PreFailbackType <String>]`: The type of path being used for DR operation script
    - `[PreFailoverGuestCredentialsCredentialsName <String>]`: username to access the network path
    - `[PreFailoverGuestCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[PreFailoverGuestCredentialsSavedCredentialsId <Int64?>]`: 
    - `[PreFailoverGuestCredentialsSavedCredentialsName <String>]`: 
    - `[PreFailoverPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
    - `[PreFailoverReset <Boolean?>]`: On set to true, resets the script to empty
    - `[PreFailoverScriptCredentialsCredentialsName <String>]`: username to access the network path
    - `[PreFailoverScriptCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[PreFailoverScriptCredentialsSavedCredentialsId <Int64?>]`: 
    - `[PreFailoverScriptCredentialsSavedCredentialsName <String>]`: 
    - `[PreFailoverType <String>]`: The type of path being used for DR operation script
  - `[Disable <Boolean?>]`: Used to disable a replication group
  - `[Enable <Boolean?>]`: Used to enable a replication group
  - `[NewName <String>]`: Used to change the name of a replication group

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

