---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-cvmodifyblackoutwindow
schema: 2.0.0
---

# Invoke-CVModifyBlackoutWindow

## SYNOPSIS
Modify the properties of an existing Blackout Window

## SYNTAX

### ModifyExpanded (Default)
```
Invoke-CVModifyBlackoutWindow -BlackoutWindowId <Int64> [-AllDays <IDaysAndTimes[]>]
 [-BackupOperations <String[]>] [-BetweenDateEnd <Int64>] [-BetweenDateStart <Int64>] [-CompanyId <Int64>]
 [-CompanyName <String>] [-DoNotSubmitJob] [-NewName <String>] [-Weeks <String[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Modify
```
Invoke-CVModifyBlackoutWindow -BlackoutWindowId <Int64> -Body <IUpdateBlackoutWindow> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentity
```
Invoke-CVModifyBlackoutWindow -InputObject <ICommvaultPowerShellIdentity> -Body <IUpdateBlackoutWindow>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ModifyViaIdentityExpanded
```
Invoke-CVModifyBlackoutWindow -InputObject <ICommvaultPowerShellIdentity> [-AllDays <IDaysAndTimes[]>]
 [-BackupOperations <String[]>] [-BetweenDateEnd <Int64>] [-BetweenDateStart <Int64>] [-CompanyId <Int64>]
 [-CompanyName <String>] [-DoNotSubmitJob] [-NewName <String>] [-Weeks <String[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Modify the properties of an existing Blackout Window

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

### -AllDays
Days of the week along with the time on which the black out window will be in effect.
To construct, see NOTES section for ALLDAYS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IDaysAndTimes[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupOperations
Refers to backup types to include in the blackout window

```yaml
Type: System.String[]
Parameter Sets: ModifyExpanded, ModifyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BetweenDateEnd
the blackout window is no longer in effect from this point on.

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

### -BetweenDateStart
the blackout window comes into effect at this point.

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

### -BlackoutWindowId
Id of the Blackout Window to update

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

### -Body
company-refers to company to which the blackout window is associated.Dates have to be provided in unix time format.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IUpdateBlackoutWindow
Parameter Sets: Modify, ModifyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyId
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

### -CompanyName
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

### -DoNotSubmitJob
Allows or Denies submitting a job when the blackout window is in effect.
If allowed, the job is submitted and resumed once the blackout window ends.

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
Refers to the newName given to the blackout Window.

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

### -Weeks
Refers to the weeks of the month that the blackout window will be in effect.

```yaml
Type: System.String[]
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

### Commvault.Powershell.Models.IUpdateBlackoutWindow

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALLDAYS <IDaysAndTimes[]>: Days of the week along with the time on which the black out window will be in effect.
  - `[Days <String[]>]`: Days of the week when the blackout window will be in effect.
  - `[TimeEnd <Int64?>]`: the blackout window is no longer in effect from this point on.
  - `[TimeStart <Int64?>]`: the blackout window comes into effect at this point.

BODY <IUpdateBlackoutWindow>: company-refers to company to which the blackout window is associated.Dates have to be provided in unix time format.
  - `[AllDays <IDaysAndTimes[]>]`: Days of the week along with the time on which the black out window will be in effect.
    - `[Days <String[]>]`: Days of the week when the blackout window will be in effect.
    - `[TimeEnd <Int64?>]`: the blackout window is no longer in effect from this point on.
    - `[TimeStart <Int64?>]`: the blackout window comes into effect at this point.
  - `[BackupOperations <String[]>]`: Refers to backup types to include in the blackout window
  - `[BetweenDateEnd <Int64?>]`: the blackout window is no longer in effect from this point on.
  - `[BetweenDateStart <Int64?>]`: the blackout window comes into effect at this point.
  - `[CompanyId <Int64?>]`: 
  - `[CompanyName <String>]`: 
  - `[DoNotSubmitJob <Boolean?>]`: Allows or Denies submitting a job when the blackout window is in effect. If allowed, the job is submitted and resumed once the blackout window ends.
  - `[NewName <String>]`: Refers to the newName given to the blackout Window.
  - `[Weeks <String[]>]`: Refers to the weeks of the month that the blackout window will be in effect.

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

