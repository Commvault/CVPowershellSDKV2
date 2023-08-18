---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-cvmodifyfailovergroup
schema: 2.0.0
---

# Invoke-CVModifyFailoverGroup

## SYNOPSIS
API to modify failover group

## SYNTAX

### ModifyExpanded (Default)
```
Invoke-CVModifyFailoverGroup -FailoverGroupId <Int64>
 [-ArrayReplicationPairs <IFailoverGroupArrayReplicationPair[]>] [-ContinueDrOnFailure] [-IsApprovalRequired]
 [-Name <String>] [-PriorityIntervalInMinutes <Int64>] [-RecoveryTargetId <Int64>]
 [-RecoveryTargetName <String>] [-ReplicationPairs <IFailoverGroupReplicationPair[]>]
 [-UsersToNotify <IIdNameDisplayNameCompany[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Modify
```
Invoke-CVModifyFailoverGroup -FailoverGroupId <Int64> -Body <IModifyFailoverGroupRequest> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ModifyViaIdentity
```
Invoke-CVModifyFailoverGroup -InputObject <ICommvaultPowerShellIdentity> -Body <IModifyFailoverGroupRequest>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentityExpanded
```
Invoke-CVModifyFailoverGroup -InputObject <ICommvaultPowerShellIdentity>
 [-ArrayReplicationPairs <IFailoverGroupArrayReplicationPair[]>] [-ContinueDrOnFailure] [-IsApprovalRequired]
 [-Name <String>] [-PriorityIntervalInMinutes <Int64>] [-RecoveryTargetId <Int64>]
 [-RecoveryTargetName <String>] [-ReplicationPairs <IFailoverGroupReplicationPair[]>]
 [-UsersToNotify <IIdNameDisplayNameCompany[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to modify failover group

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

### -ArrayReplicationPairs
List of all array replication pairs for failover group
To construct, see NOTES section for ARRAYREPLICATIONPAIRS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IFailoverGroupArrayReplicationPair[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Modify failover group request
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IModifyFailoverGroupRequest
Parameter Sets: Modify, ModifyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContinueDrOnFailure
Modify whether to continue to next priority on DR job failure

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

### -FailoverGroupId
Id of the failover group

```yaml
Type: System.Int64
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

### -IsApprovalRequired
Modify whether user approval is required for DR operation or not

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

### -Name
New name for failover group

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

### -PriorityIntervalInMinutes
Modify the time interval between DR operations of different priorities in minutes

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

### -RecoveryTargetId
.

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

### -RecoveryTargetName
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

### -ReplicationPairs
List of all replication pairs that are part of the failover group
To construct, see NOTES section for REPLICATIONPAIRS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IFailoverGroupReplicationPair[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UsersToNotify
Users to notify/for approval of DR operations
To construct, see NOTES section for USERSTONOTIFY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdNameDisplayNameCompany[]
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

### Commvault.Powershell.Models.IModifyFailoverGroupRequest

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ARRAYREPLICATIONPAIRS <IFailoverGroupArrayReplicationPair[]>: List of all array replication pairs for failover group
  - `[DestinationName <String>]`: The name of the destination machine
  - `[Guid <String>]`: The GUID of the source of array replication pair
  - `[Hostname <String>]`: The hostname specified for the destination machine
  - `[IPSettings <IIPAddressSettingVmwareCreate[]>]`: The settings for IP address mapping
    - `[DestinationAlternateDns <String>]`: The alternate DNS server for the destination VM.  Provide only if DHCP is not enabled
    - `[DestinationAlternateWins <String>]`: The alternate WINS server for the destination VM.  Provide only if DHCP is not enabled
    - `[DestinationIP <String>]`: The full IP address or an IP address pattern for the destination VM. Provide only if DHCP is not enabled.
    - `[DestinationPreferredDns <String>]`: The preferred DNS server for the destination VM.  Provide only if DHCP is not enabled
    - `[DestinationPreferredWins <String>]`: The preferred WINS server for the destination VM.  Provide only if DHCP is not enabled
    - `[DestinationSubnetMask <String>]`: The subnet mask for the destination VM.  Provide only if DHCP is not enabled.
    - `[DestinationdefaultGateway <String>]`: The default gateway for the destination VM.  Provide only if DHCP is not enabled.
    - `[Hostname <String>]`: The host name to be applied for the destination VM.
    - `[SourceDefaultGateway <String>]`: The default gateway of the source VM.
    - `[SourceIP <String>]`: The full IP address or an IP address pattern of the source VM.
    - `[SourceSubnetMask <String>]`: The subnet mask of the source VM.
    - `[UseDhcp <Boolean?>]`: Automatically assigns available IP addresses to be used with the specified destination network.
  - `[Id <Int64?>]`: The ID of the array replication pair
  - `[Priority <Int64?>]`: The priority of the array replication pair for DR operation in failover group. The lower values signify higher priority
  - `[SourceName <String>]`: The name of the source machine

BODY <IModifyFailoverGroupRequest>: Modify failover group request
  - `[ArrayReplicationPairs <IFailoverGroupArrayReplicationPair[]>]`: List of all array replication pairs for failover group
    - `[DestinationName <String>]`: The name of the destination machine
    - `[Guid <String>]`: The GUID of the source of array replication pair
    - `[Hostname <String>]`: The hostname specified for the destination machine
    - `[IPSettings <IIPAddressSettingVmwareCreate[]>]`: The settings for IP address mapping
      - `[DestinationAlternateDns <String>]`: The alternate DNS server for the destination VM.  Provide only if DHCP is not enabled
      - `[DestinationAlternateWins <String>]`: The alternate WINS server for the destination VM.  Provide only if DHCP is not enabled
      - `[DestinationIP <String>]`: The full IP address or an IP address pattern for the destination VM. Provide only if DHCP is not enabled.
      - `[DestinationPreferredDns <String>]`: The preferred DNS server for the destination VM.  Provide only if DHCP is not enabled
      - `[DestinationPreferredWins <String>]`: The preferred WINS server for the destination VM.  Provide only if DHCP is not enabled
      - `[DestinationSubnetMask <String>]`: The subnet mask for the destination VM.  Provide only if DHCP is not enabled.
      - `[DestinationdefaultGateway <String>]`: The default gateway for the destination VM.  Provide only if DHCP is not enabled.
      - `[Hostname <String>]`: The host name to be applied for the destination VM.
      - `[SourceDefaultGateway <String>]`: The default gateway of the source VM.
      - `[SourceIP <String>]`: The full IP address or an IP address pattern of the source VM.
      - `[SourceSubnetMask <String>]`: The subnet mask of the source VM.
      - `[UseDhcp <Boolean?>]`: Automatically assigns available IP addresses to be used with the specified destination network.
    - `[Id <Int64?>]`: The ID of the array replication pair
    - `[Priority <Int64?>]`: The priority of the array replication pair for DR operation in failover group. The lower values signify higher priority
    - `[SourceName <String>]`: The name of the source machine
  - `[ContinueDrOnFailure <Boolean?>]`: Modify whether to continue to next priority on DR job failure
  - `[IsApprovalRequired <Boolean?>]`: Modify whether user approval is required for DR operation or not
  - `[Name <String>]`: New name for failover group
  - `[PriorityIntervalInMinutes <Int64?>]`: Modify the time interval between DR operations of different priorities in minutes
  - `[RecoveryTargetId <Int64?>]`: 
  - `[RecoveryTargetName <String>]`: 
  - `[ReplicationPairs <IFailoverGroupReplicationPair[]>]`: List of all replication pairs that are part of the failover group
    - `[CopyPrecedence <Int64?>]`: The copy precedence of replication pair
    - `[DestinationName <String>]`: The name of the destination machine
    - `[Guid <String>]`: The GUID of the source of replication pair
    - `[Id <Int64?>]`: The ID of the replication pair
    - `[PostFailoverScriptGuestCredentialsCredentialsName <String>]`: username to access the network path
    - `[PostFailoverScriptGuestCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[PostFailoverScriptGuestCredentialsSavedCredentialsId <Int64?>]`: 
    - `[PostFailoverScriptGuestCredentialsSavedCredentialsName <String>]`: 
    - `[PostFailoverScriptPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
    - `[PostFailoverScriptReset <Boolean?>]`: On set to true, resets the script to empty
    - `[PostFailoverScriptScriptCredentialsCredentialsName <String>]`: username to access the network path
    - `[PostFailoverScriptScriptCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[PostFailoverScriptScriptCredentialsSavedCredentialsId <Int64?>]`: 
    - `[PostFailoverScriptScriptCredentialsSavedCredentialsName <String>]`: 
    - `[PostFailoverScriptType <String>]`: The type of path being used for DR operation script
    - `[PreFailoverScriptGuestCredentialsCredentialsName <String>]`: username to access the network path
    - `[PreFailoverScriptGuestCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[PreFailoverScriptGuestCredentialsSavedCredentialsId <Int64?>]`: 
    - `[PreFailoverScriptGuestCredentialsSavedCredentialsName <String>]`: 
    - `[PreFailoverScriptPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
    - `[PreFailoverScriptReset <Boolean?>]`: On set to true, resets the script to empty
    - `[PreFailoverScriptScriptCredentialsCredentialsName <String>]`: username to access the network path
    - `[PreFailoverScriptScriptCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[PreFailoverScriptScriptCredentialsSavedCredentialsId <Int64?>]`: 
    - `[PreFailoverScriptScriptCredentialsSavedCredentialsName <String>]`: 
    - `[PreFailoverScriptType <String>]`: The type of path being used for DR operation script
    - `[Priority <Int64?>]`: The priority of the replication pair for DR operation in failover group. The lower values signify higher priority
    - `[SourceName <String>]`: The name of the source machine
  - `[UsersToNotify <IIdNameDisplayNameCompany[]>]`: Users to notify/for approval of DR operations
    - `[CompanyId <Int64?>]`: 
    - `[CompanyName <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 

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

REPLICATIONPAIRS <IFailoverGroupReplicationPair[]>: List of all replication pairs that are part of the failover group
  - `[CopyPrecedence <Int64?>]`: The copy precedence of replication pair
  - `[DestinationName <String>]`: The name of the destination machine
  - `[Guid <String>]`: The GUID of the source of replication pair
  - `[Id <Int64?>]`: The ID of the replication pair
  - `[PostFailoverScriptGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailoverScriptGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailoverScriptGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailoverScriptGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailoverScriptPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PostFailoverScriptReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PostFailoverScriptScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailoverScriptScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailoverScriptScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailoverScriptScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailoverScriptType <String>]`: The type of path being used for DR operation script
  - `[PreFailoverScriptGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailoverScriptGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailoverScriptGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailoverScriptGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailoverScriptPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PreFailoverScriptReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PreFailoverScriptScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailoverScriptScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailoverScriptScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailoverScriptScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailoverScriptType <String>]`: The type of path being used for DR operation script
  - `[Priority <Int64?>]`: The priority of the replication pair for DR operation in failover group. The lower values signify higher priority
  - `[SourceName <String>]`: The name of the source machine

USERSTONOTIFY <IIdNameDisplayNameCompany[]>: Users to notify/for approval of DR operations
  - `[CompanyId <Int64?>]`: 
  - `[CompanyName <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

