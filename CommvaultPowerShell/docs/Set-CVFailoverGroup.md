---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/set-cvfailovergroup
schema: 2.0.0
---

# Set-CVFailoverGroup

## SYNOPSIS
API to modify failover group

## SYNTAX

### UpdateExpanded (Default)
```
Set-CVFailoverGroup -FailoverGroupId <Int64> [-ArrayReplicationPairs <IFailoverGroupArrayReplicationPair[]>]
 [-ContinueDrOnFailure] [-EsxServerMappings <IEsxServerMapping[]>] [-IsApprovalRequired] [-Name <String>]
 [-PriorityIntervalInMinutes <Int64>] [-RecoveryTargetId <Int64>] [-RecoveryTargetName <String>]
 [-ReplicationPairs <IFailoverGroupReplicationPair[]>] [-Script <IReplicationGroupScript>]
 [-UsersToNotify <IIdNameDisplayNameCompany[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Set-CVFailoverGroup -InputObject <ICommvaultPowerShellIdentity>
 [-ArrayReplicationPairs <IFailoverGroupArrayReplicationPair[]>] [-ContinueDrOnFailure]
 [-EsxServerMappings <IEsxServerMapping[]>] [-IsApprovalRequired] [-Name <String>]
 [-PriorityIntervalInMinutes <Int64>] [-RecoveryTargetId <Int64>] [-RecoveryTargetName <String>]
 [-ReplicationPairs <IFailoverGroupReplicationPair[]>] [-Script <IReplicationGroupScript>]
 [-UsersToNotify <IIdNameDisplayNameCompany[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to modify failover group

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

### -ArrayReplicationPairs
List of all array replication pairs for failover group

```yaml
Type: Commvault.Powershell.Models.IFailoverGroupArrayReplicationPair[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContinueDrOnFailure
Whether to continue to next priority on DR job failure

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

### -EsxServerMappings
The list of all ESX server mappings

```yaml
Type: Commvault.Powershell.Models.IEsxServerMapping[]
Parameter Sets: (All)
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
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsApprovalRequired
Whether a user approval is required for DR operations

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

### -Name
Failover Group name

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

### -PriorityIntervalInMinutes
The interval between DR operations of different priorities

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

### -RecoveryTargetId
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

### -RecoveryTargetName
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

### -ReplicationPairs
List of all replication pairs that are part of the failover group

```yaml
Type: Commvault.Powershell.Models.IFailoverGroupReplicationPair[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Script
Pre/post failover and failback scripts at group level

```yaml
Type: Commvault.Powershell.Models.IReplicationGroupScript
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UsersToNotify
Users to notify/for approval of DR operations

```yaml
Type: Commvault.Powershell.Models.IIdNameDisplayNameCompany[]
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

### Commvault.Powershell.Models.ICommvaultPowerShellIdentity

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ARRAYREPLICATIONPAIRS <IFailoverGroupArrayReplicationPair[]>`: List of all array replication pairs for failover group
  - `[DestinationId <Int64?>]`: The id of the destination machine
  - `[DestinationName <String>]`: The name of the destination machine
  - `[Guid <String>]`: The GUID of the source of array replication pair
  - `[Hostname <String>]`: The hostname specified for the destination machine
  - `[IPSettings <List<IIPAddressSettingVmwareCreate>>]`: The settings for IP address mapping
    - `[DestinationAlternateDns <String>]`: The alternate DNS server for the destination VM.  Provide only if DHCP is not enabled
    - `[DestinationAlternateWins <String>]`: The alternate WINS server for the destination VM.  Provide only if DHCP is not enabled
    - `[DestinationDefaultGateway <String>]`: The default gateway for the destination VM.  Provide only if DHCP is not enabled.
    - `[DestinationIP <String>]`: The full IP address or an IP address pattern for the destination VM. Provide only if DHCP is not enabled.
    - `[DestinationPreferredDns <String>]`: The preferred DNS server for the destination VM.  Provide only if DHCP is not enabled
    - `[DestinationPreferredWins <String>]`: The preferred WINS server for the destination VM.  Provide only if DHCP is not enabled
    - `[DestinationSubnetMask <String>]`: The subnet mask for the destination VM.  Provide only if DHCP is not enabled.
    - `[SourceDefaultGateway <String>]`: The default gateway of the source VM.
    - `[SourceIP <String>]`: The full IP address or an IP address pattern of the source VM.
    - `[SourceSubnetMask <String>]`: The subnet mask of the source VM.
    - `[UseDhcp <Boolean?>]`: Automatically assigns available IP addresses to be used with the specified destination network.
  - `[Id <Int64?>]`: The ID of the array replication pair
  - `[Priority <Int64?>]`: The priority of the array replication pair for DR operation in failover group. The lower values signify higher priority
  - `[SourceId <Int64?>]`: The id of the source machine
  - `[SourceName <String>]`: The name of the source machine

`ESXSERVERMAPPINGS <IEsxServerMapping[]>`: The list of all ESX server mappings
  - `[DestinationServer <String>]`: The name of destination ESX server
  - `[NetworkSettings <List<INetworkSetting>>]`: The list of all source network interface to destination network interface mapping
    - `[Destination <String>]`: Destination network name
    - `[Source <String>]`: Source network name
    - `[SourceId <String>]`: Source network ID
  - `[SourceServer <String>]`: The name of source ESX server

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

`REPLICATIONPAIRS <IFailoverGroupReplicationPair[]>`: List of all replication pairs that are part of the failover group
  - `[CopyPrecedence <Int64?>]`: The copy precedence of replication pair
  - `[DestinationId <Int64?>]`: The id of the destination machine
  - `[DestinationName <String>]`: The name of the destination machine
  - `[Guid <String>]`: The GUID of the source of replication pair
  - `[Id <Int64?>]`: The ID of the replication pair
  - `[PostFailbackScriptContent <String>]`: Content of the script to be executed
  - `[PostFailbackScriptGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailbackScriptGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailbackScriptGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailbackScriptGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailbackScriptGuid <String>]`: Unique script identifier string
  - `[PostFailbackScriptName <String>]`: Name of the script
  - `[PostFailbackScriptOSType <String>]`: OS types
  - `[PostFailbackScriptPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PostFailbackScriptReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PostFailbackScriptScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailbackScriptScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailbackScriptScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailbackScriptScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailbackScriptType <String>]`: The type of path being used for DR operation script
  - `[PostFailoverScriptContent <String>]`: Content of the script to be executed
  - `[PostFailoverScriptGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailoverScriptGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailoverScriptGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailoverScriptGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailoverScriptGuid <String>]`: Unique script identifier string
  - `[PostFailoverScriptName <String>]`: Name of the script
  - `[PostFailoverScriptOSType <String>]`: OS types
  - `[PostFailoverScriptPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PostFailoverScriptReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PostFailoverScriptScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailoverScriptScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailoverScriptScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailoverScriptScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailoverScriptType <String>]`: The type of path being used for DR operation script
  - `[PreFailbackScriptContent <String>]`: Content of the script to be executed
  - `[PreFailbackScriptGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailbackScriptGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailbackScriptGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailbackScriptGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailbackScriptGuid <String>]`: Unique script identifier string
  - `[PreFailbackScriptName <String>]`: Name of the script
  - `[PreFailbackScriptOSType <String>]`: OS types
  - `[PreFailbackScriptPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PreFailbackScriptReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PreFailbackScriptScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailbackScriptScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailbackScriptScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailbackScriptScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailbackScriptType <String>]`: The type of path being used for DR operation script
  - `[PreFailoverScriptContent <String>]`: Content of the script to be executed
  - `[PreFailoverScriptGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailoverScriptGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailoverScriptGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailoverScriptGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailoverScriptGuid <String>]`: Unique script identifier string
  - `[PreFailoverScriptName <String>]`: Name of the script
  - `[PreFailoverScriptOSType <String>]`: OS types
  - `[PreFailoverScriptPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PreFailoverScriptReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PreFailoverScriptScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailoverScriptScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailoverScriptScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailoverScriptScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailoverScriptType <String>]`: The type of path being used for DR operation script
  - `[Priority <Int64?>]`: The priority of the replication pair for DR operation in failover group. The lower values signify higher priority
  - `[SourceId <Int64?>]`: The id of the source machine
  - `[SourceName <String>]`: The name of the source machine

`SCRIPT <IReplicationGroupScript>`: Pre/post failover and failback scripts at group level
  - `[PostFailbackGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailbackGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailbackGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailbackGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailbackGuid <String>]`: Unique script identifier string
  - `[PostFailbackOSType <String>]`: OS types
  - `[PostFailbackPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PostFailbackReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PostFailbackScriptContent <String>]`: Content of the script to be executed
  - `[PostFailbackScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailbackScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailbackScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailbackScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailbackScriptName <String>]`: Name of the script
  - `[PostFailbackType <String>]`: The type of path being used for DR operation script
  - `[PostFailoverGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailoverGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailoverGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailoverGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailoverGuid <String>]`: Unique script identifier string
  - `[PostFailoverOSType <String>]`: OS types
  - `[PostFailoverPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PostFailoverReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PostFailoverScriptContent <String>]`: Content of the script to be executed
  - `[PostFailoverScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PostFailoverScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PostFailoverScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PostFailoverScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PostFailoverScriptName <String>]`: Name of the script
  - `[PostFailoverType <String>]`: The type of path being used for DR operation script
  - `[PreFailbackGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailbackGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailbackGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailbackGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailbackGuid <String>]`: Unique script identifier string
  - `[PreFailbackOSType <String>]`: OS types
  - `[PreFailbackPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PreFailbackReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PreFailbackScriptContent <String>]`: Content of the script to be executed
  - `[PreFailbackScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailbackScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailbackScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailbackScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailbackScriptName <String>]`: Name of the script
  - `[PreFailbackType <String>]`: The type of path being used for DR operation script
  - `[PreFailoverGuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailoverGuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailoverGuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailoverGuestCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailoverGuid <String>]`: Unique script identifier string
  - `[PreFailoverOSType <String>]`: OS types
  - `[PreFailoverPath <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[PreFailoverReset <Boolean?>]`: On set to true, resets the script to empty
  - `[PreFailoverScriptContent <String>]`: Content of the script to be executed
  - `[PreFailoverScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[PreFailoverScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[PreFailoverScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[PreFailoverScriptCredentialsSavedCredentialsName <String>]`: 
  - `[PreFailoverScriptName <String>]`: Name of the script
  - `[PreFailoverType <String>]`: The type of path being used for DR operation script

`USERSTONOTIFY <IIdNameDisplayNameCompany[]>`: Users to notify/for approval of DR operations
  - `[CompanyId <Int64?>]`: 
  - `[CompanyName <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

