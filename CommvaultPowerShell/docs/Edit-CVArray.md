---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/edit-cvarray
schema: 2.0.0
---

# Edit-CVArray

## SYNOPSIS
Editing Array details

## SYNTAX

### EditExpanded (Default)
```
Edit-CVArray -ArrayId <Int64> [-AccessNodes <IArrayAccessNodes[]>] [-CredentialPassword <String>]
 [-CredentialUserName <String>] [-GeneralControlHost <String>] [-GeneralDescription <String>]
 [-GeneralFlags <Int64>] [-RegionId <Int64>] [-RegionName <String>] [-RoleId <Int64>] [-RoleName <String>]
 [-SavedCredentialId <Int64>] [-SavedCredentialName <String>] [-SnapConfigurations <IArrayConfigsEdit[]>]
 [-UserGroupId <Int64>] [-UserGroupName <String>] [-UserId <Int64>] [-UserName <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Edit
```
Edit-CVArray -ArrayId <Int64> -Body <IEditArray> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### EditViaIdentity
```
Edit-CVArray -InputObject <ICommvaultPowerShellIdentity> -Body <IEditArray> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### EditViaIdentityExpanded
```
Edit-CVArray -InputObject <ICommvaultPowerShellIdentity> [-AccessNodes <IArrayAccessNodes[]>]
 [-CredentialPassword <String>] [-CredentialUserName <String>] [-GeneralControlHost <String>]
 [-GeneralDescription <String>] [-GeneralFlags <Int64>] [-RegionId <Int64>] [-RegionName <String>]
 [-RoleId <Int64>] [-RoleName <String>] [-SavedCredentialId <Int64>] [-SavedCredentialName <String>]
 [-SnapConfigurations <IArrayConfigsEdit[]>] [-UserGroupId <Int64>] [-UserGroupName <String>]
 [-UserId <Int64>] [-UserName <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Editing Array details

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

### -AccessNodes
.

```yaml
Type: Commvault.Powershell.Models.IArrayAccessNodes[]
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ArrayId
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

### -Body
Request to pass for Edit Array

```yaml
Type: Commvault.Powershell.Models.IEditArray
Parameter Sets: Edit, EditViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CredentialPassword
Base 64 encoded Password to access the array

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

### -CredentialUserName
Username to access the array

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

### -GeneralControlHost
Host name of the array

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

### -GeneralDescription
Description about the Array

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

### -GeneralFlags
Flags to be set for array

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

### -InputObject
Identity Parameter

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

### -RegionId
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

### -RegionName
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

### -RoleId
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

### -RoleName
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

### -SavedCredentialId
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

### -SavedCredentialName
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

### -SnapConfigurations
Configurations related to a snap engine

```yaml
Type: Commvault.Powershell.Models.IArrayConfigsEdit[]
Parameter Sets: EditExpanded, EditViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserGroupId
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

### -UserGroupName
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

### -UserId
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

### -UserName
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

### Commvault.Powershell.Models.IEditArray

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACCESSNODES <IArrayAccessNodes[]>`: .
  - `[DisplayName <String>]`: The display name of the corresponding Media Agent
  - `[Id <Int64?>]`: Id of the MediaAgent
  - `[Name <String>]`: Name of the MediaAgent
  - `[Pruning <Boolean?>]`: Enable/Disable pruning of snapshots on the selected Media Agent

`BODY <IEditArray>`: Request to pass for Edit Array
  - `[AccessNodes <List<IArrayAccessNodes>>]`: 
    - `[DisplayName <String>]`: The display name of the corresponding Media Agent
    - `[Id <Int64?>]`: Id of the MediaAgent
    - `[Name <String>]`: Name of the MediaAgent
    - `[Pruning <Boolean?>]`: Enable/Disable pruning of snapshots on the selected Media Agent
  - `[CredentialPassword <String>]`: Base 64 encoded Password to access the array
  - `[CredentialUserName <String>]`: Username to access the array
  - `[GeneralControlHost <String>]`: Host name of the array
  - `[GeneralDescription <String>]`: Description about the Array
  - `[GeneralFlags <Int64?>]`: Flags to be set for array
  - `[RegionId <Int64?>]`: 
  - `[RegionName <String>]`: 
  - `[RoleId <Int64?>]`: 
  - `[RoleName <String>]`: 
  - `[SavedCredentialId <Int64?>]`: 
  - `[SavedCredentialName <String>]`: 
  - `[SnapConfigurations <List<IArrayConfigsEdit>>]`: Configurations related to a snap engine
    - `Flags <Int64>`: Flag regarding placement of config in the CC page
    - `IsUpdated <Boolean>`: Whether the config is updated/edited or not
    - `MasterConfigId <Int64>`: This is the masterConfigId, which is available for each vendor's configs
    - `Name <String>`: This is the name of the config which is displayed on the Command Center Console
    - `Type <Int64>`: Type of the config value. type can accept 7 values [1,2,8,10,12,13,14], 1: boolean, 2: integer, 8: text, 10: array[string] are common configs, the rest three are special keys, 12 is for password type key for NetApp E-Series and HPE Nimble, 13 is Private Key for GCP, 14 is a hidden config to select type of Disk for GCP
    - `[Value <String>]`: Takes a single value for all types and for type 14 it holds the id of the selected value from values
    - `[Values <List<IIdName>>]`: For type 10 and 14, it can take one or more value of idname type where id by default is 0 for 10. For HPE 3PAR StoreServ, pass MA Id in name field to configure that MA as remote snap MA.
      - `[Id <Int64?>]`: 
      - `[Name <String>]`: 
  - `[UserGroupId <Int64?>]`: 
  - `[UserGroupName <String>]`: 
  - `[UserId <Int64?>]`: 
  - `[UserName <String>]`: 

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

`SNAPCONFIGURATIONS <IArrayConfigsEdit[]>`: Configurations related to a snap engine
  - `Flags <Int64>`: Flag regarding placement of config in the CC page
  - `IsUpdated <Boolean>`: Whether the config is updated/edited or not
  - `MasterConfigId <Int64>`: This is the masterConfigId, which is available for each vendor's configs
  - `Name <String>`: This is the name of the config which is displayed on the Command Center Console
  - `Type <Int64>`: Type of the config value. type can accept 7 values [1,2,8,10,12,13,14], 1: boolean, 2: integer, 8: text, 10: array[string] are common configs, the rest three are special keys, 12 is for password type key for NetApp E-Series and HPE Nimble, 13 is Private Key for GCP, 14 is a hidden config to select type of Disk for GCP
  - `[Value <String>]`: Takes a single value for all types and for type 14 it holds the id of the selected value from values
  - `[Values <List<IIdName>>]`: For type 10 and 14, it can take one or more value of idname type where id by default is 0 for 10. For HPE 3PAR StoreServ, pass MA Id in name field to configure that MA as remote snap MA.
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 

## RELATED LINKS
