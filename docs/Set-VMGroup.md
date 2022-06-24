---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-vmgroup
schema: 2.0.0
---

# Set-VMGroup

## SYNOPSIS
Updates the VM Group

## SYNTAX

### UpdateExpanded (Default)
```
Set-VMGroup -VMGroupId <Int32> [-AccessNode <IIdName[]>] [-ActivityControlEnableBackup]
 [-ActivityControlEnableRestore] [-ApplicationValidation <IVMAppValidation>]
 [-BackupActivityControlOptionDelayTime <String>] [-BackupActivityControlOptionEnableAfterDelay]
 [-BackupActivityControlOptionsTimeZoneId <Int32>] [-BackupActivityControlOptionsTimeZoneName <String>]
 [-ContentOverwrite] [-ContentRuleGroups <IRuleGroupContent[]>]
 [-ContentVirtualMachines <IVirtualMachinecontent[]>] [-CredentialsName <String>]
 [-CredentialsPassword <String>] [-CrossAccountCopyDestinationClientId <Int32>]
 [-CrossAccountCopyDestinationClientName <String>] [-DiskFilters <IVMDiskFilter[]>] [-EnableFileIndexing]
 [-FilterOverwrite] [-FilterRuleGroups <IRuleGroupContent[]>]
 [-FilterVirtualMachines <IVirtualMachinecontent[]>] [-NewName <String>] [-PlanId <Int32>]
 [-PlanName <String>] [-RestoreActivityControlOptionDelayTime <String>]
 [-RestoreActivityControlOptionEnableAfterDelay] [-RestoreActivityControlOptionsTimeZoneId <Int32>]
 [-RestoreActivityControlOptionsTimeZoneName <String>] [-SavedCredentialsId <Int32>]
 [-SavedCredentialsName <String>] [-SecurityAssociations <ISecurityAssoc[]>] [-SettingAutoDetectVMOwner]
 [-SettingCollectFileDetailsforGranularRecovery] [-SettingCollectFileDetailsFromSnapshotCopy]
 [-SettingCustomSnapshotResourceGroup <String>] [-SettingDatastoreFreespaceCheck]
 [-SettingDatastoreFreespaceRequired <Int32>] [-SettingIsApplicationAware] [-SettingJobStartTime <Int32>]
 [-SettingNoOfReaders <Int32>] [-SettingTransportMode <String>] [-SettingUseChangedBlockTrackingOnVM]
 [-SettingUseVMCheckpointSetting] [-SettingVMBackupType <String>] [-SnapEngineId <Int32>]
 [-SnapEngineName <String>] [-SnapMountProxyId <Int32>] [-SnapMountProxyName <String>]
 [-SnapshotManagementBackupCopyInterface <String>] [-SnapshotManagementEnableHardwareSnapshot]
 [-SnapshotManagementIsCrossAccountCopyEnabled] [-SnapshotManagementIsCrossAccountEnabled]
 [-SnapshotManagementIsIndependentDisksEnabled] [-SnapshotManagementIsRawDeviceMapsEnabled]
 [-SnapshotManagementSnapMountEsxHost <String>] [-SnapshotManagementUseSeparateProxyForSnapToTape]
 [-SnapshotManagementVMApplicationUserName <String>] [-StorageId <Int32>] [-StorageName <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Set-VMGroup -InputObject <ICommvaultPowerShellIdentity> [-AccessNode <IIdName[]>]
 [-ActivityControlEnableBackup] [-ActivityControlEnableRestore] [-ApplicationValidation <IVMAppValidation>]
 [-BackupActivityControlOptionDelayTime <String>] [-BackupActivityControlOptionEnableAfterDelay]
 [-BackupActivityControlOptionsTimeZoneId <Int32>] [-BackupActivityControlOptionsTimeZoneName <String>]
 [-ContentOverwrite] [-ContentRuleGroups <IRuleGroupContent[]>]
 [-ContentVirtualMachines <IVirtualMachinecontent[]>] [-CredentialsName <String>]
 [-CredentialsPassword <String>] [-CrossAccountCopyDestinationClientId <Int32>]
 [-CrossAccountCopyDestinationClientName <String>] [-DiskFilters <IVMDiskFilter[]>] [-EnableFileIndexing]
 [-FilterOverwrite] [-FilterRuleGroups <IRuleGroupContent[]>]
 [-FilterVirtualMachines <IVirtualMachinecontent[]>] [-NewName <String>] [-PlanId <Int32>]
 [-PlanName <String>] [-RestoreActivityControlOptionDelayTime <String>]
 [-RestoreActivityControlOptionEnableAfterDelay] [-RestoreActivityControlOptionsTimeZoneId <Int32>]
 [-RestoreActivityControlOptionsTimeZoneName <String>] [-SavedCredentialsId <Int32>]
 [-SavedCredentialsName <String>] [-SecurityAssociations <ISecurityAssoc[]>] [-SettingAutoDetectVMOwner]
 [-SettingCollectFileDetailsforGranularRecovery] [-SettingCollectFileDetailsFromSnapshotCopy]
 [-SettingCustomSnapshotResourceGroup <String>] [-SettingDatastoreFreespaceCheck]
 [-SettingDatastoreFreespaceRequired <Int32>] [-SettingIsApplicationAware] [-SettingJobStartTime <Int32>]
 [-SettingNoOfReaders <Int32>] [-SettingTransportMode <String>] [-SettingUseChangedBlockTrackingOnVM]
 [-SettingUseVMCheckpointSetting] [-SettingVMBackupType <String>] [-SnapEngineId <Int32>]
 [-SnapEngineName <String>] [-SnapMountProxyId <Int32>] [-SnapMountProxyName <String>]
 [-SnapshotManagementBackupCopyInterface <String>] [-SnapshotManagementEnableHardwareSnapshot]
 [-SnapshotManagementIsCrossAccountCopyEnabled] [-SnapshotManagementIsCrossAccountEnabled]
 [-SnapshotManagementIsIndependentDisksEnabled] [-SnapshotManagementIsRawDeviceMapsEnabled]
 [-SnapshotManagementSnapMountEsxHost <String>] [-SnapshotManagementUseSeparateProxyForSnapToTape]
 [-SnapshotManagementVMApplicationUserName <String>] [-StorageId <Int32>] [-StorageName <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Updates the VM Group

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

### -AccessNode
.
To construct, see NOTES section for ACCESSNODE properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActivityControlEnableBackup
true if Backup is enabled

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

### -ActivityControlEnableRestore
true if Restore is enabled

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

### -ApplicationValidation
vmAppValidation
To construct, see NOTES section for APPLICATIONVALIDATION properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IVMAppValidation
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupActivityControlOptionDelayTime
Delayed by n Hrs

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

### -BackupActivityControlOptionEnableAfterDelay
True if the activity will be enabled after a delay time interval

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

### -BackupActivityControlOptionsTimeZoneId
.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupActivityControlOptionsTimeZoneName
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

### -ContentOverwrite
True if content in vmgroup has to be overwritten, by default it will append the content

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

### -ContentRuleGroups
.
To construct, see NOTES section for CONTENTRULEGROUPS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IRuleGroupContent[]
Parameter Sets: (All)
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CredentialsName
username to access the network path

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

### -CredentialsPassword
password to access the network path

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

### -CrossAccountCopyDestinationClientId
.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CrossAccountCopyDestinationClientName
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

### -DiskFilters
.
To construct, see NOTES section for DISKFILTERS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IVMDiskFilter[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableFileIndexing
True if file indexing needs to be enabled

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

### -FilterOverwrite
True if content in vmgroup has to be overwritten, by default it will append the content

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

### -FilterRuleGroups
.
To construct, see NOTES section for FILTERRULEGROUPS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IRuleGroupContent[]
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NewName
subclient name

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

### -PlanId
.

```yaml
Type: System.Int32
Parameter Sets: (All)
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestoreActivityControlOptionDelayTime
Delayed by n Hrs

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

### -RestoreActivityControlOptionEnableAfterDelay
True if the activity will be enabled after a delay time interval

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

### -RestoreActivityControlOptionsTimeZoneId
.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestoreActivityControlOptionsTimeZoneName
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

### -SavedCredentialsId
.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SavedCredentialsName
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

### -SecurityAssociations
.
To construct, see NOTES section for SECURITYASSOCIATIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ISecurityAssoc[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingAutoDetectVMOwner
True if auto detect VM Owner enabled

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

### -SettingCollectFileDetailsforGranularRecovery
True if metadata collection is enabled.
Only applicable for Indexing v1

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

### -SettingCollectFileDetailsFromSnapshotCopy
True if metadata collection is enabled for intellisnap jobs.
Only applicable for Indexing v1

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

### -SettingCustomSnapshotResourceGroup
Custom snapshot resource group GUID for Azure

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

### -SettingDatastoreFreespaceCheck
True if Datastore Free space check is enabled

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

### -SettingDatastoreFreespaceRequired
precentage of datastore free space check value

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingIsApplicationAware
Is the VM App Aware

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

### -SettingJobStartTime
Start Time for the VM Group Job

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingNoOfReaders
Number of readers for backup

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingTransportMode
transport mode based on environment.
Values are case sensitive

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

### -SettingUseChangedBlockTrackingOnVM
True if Changed Block Tracking is enabled

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

### -SettingUseVMCheckpointSetting
True if use VM CheckPoint setting is enabled

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

### -SettingVMBackupType
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

### -SnapEngineId
.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SnapEngineName
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

### -SnapMountProxyId
.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SnapMountProxyName
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

### -SnapshotManagementBackupCopyInterface
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

### -SnapshotManagementEnableHardwareSnapshot
True if hardware snapshot is enabled

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

### -SnapshotManagementIsCrossAccountCopyEnabled
True if full copy of amazon snapshot to different amazon account is enabled

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

### -SnapshotManagementIsCrossAccountEnabled
True if replicate and copy or sharing of amazon snapshot to different amazon account in same or different geographic location is enabled

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

### -SnapshotManagementIsIndependentDisksEnabled
True if independent disk option is enabled

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

### -SnapshotManagementIsRawDeviceMapsEnabled
True if raw device maps option is enabled

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

### -SnapshotManagementSnapMountEsxHost
Name of ESX Host

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

### -SnapshotManagementUseSeparateProxyForSnapToTape
True if separate proxy client is used for snap to tape

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

### -SnapshotManagementVMApplicationUserName
Virtual machine application user name

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

### -StorageId
.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageName
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

### -VMGroupId
Id of the VMgroup to update

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
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

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

### Commvault.Powershell.Models.IGetVMGroupResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCESSNODE <IIdName[]>: .
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

APPLICATIONVALIDATION <IVMAppValidation>: vmAppValidation
  - `[CopyId <Int32?>]`: 
  - `[CopyName <String>]`: 
  - `[CredentialsName <String>]`: username to access the network path
  - `[CredentialsPassword <String>]`: password to access the network path
  - `[KeepValidatedVMSRunning <Boolean?>]`: If true then validated VMs will be available until expiration time set on the recovery target
  - `[MaximumNoOfThreads <Int32?>]`: Number of backup Validation Threads
  - `[RecoveryTarget <String>]`: Recovery Target for Application Validation
  - `[SavedCredentialsId <Int32?>]`: 
  - `[SavedCredentialsName <String>]`: 
  - `[ScheduleDescription <String>]`: Description for validation schedule
  - `[ScheduleId <Int32?>]`: 
  - `[ScheduleIsScheduleEnabled <Boolean?>]`: True if application validation schedule is enabled
  - `[ScheduleTaskId <Int32?>]`: Job Id for the application validation task. 0 if schedule is disabled
  - `[UnixArguments <String>]`: Arguments for the script
  - `[UnixIsDisabled <Boolean?>]`: Is the script disabled
  - `[UnixIsUnc <Boolean?>]`: True if the script is a UNC script, False if it is a local script
  - `[UnixPath <String>]`: Path for the validation script
  - `[UnixUncCredentialsName <String>]`: username to access the network path
  - `[UnixUncCredentialsPassword <String>]`: password to access the network path
  - `[UnixUncSavedCredentialsId <Int32?>]`: 
  - `[UnixUncSavedCredentialsName <String>]`: 
  - `[UseSourceVMEsxToMount <Boolean?>]`: Use Source VM ESX To Mount
  - `[ValidateVMBackups <Boolean?>]`: True if VM Backup validation is enabled
  - `[WindowArguments <String>]`: Arguments for the script
  - `[WindowIsDisabled <Boolean?>]`: Is the script disabled
  - `[WindowIsUnc <Boolean?>]`: True if the script is a UNC script, False if it is a local script
  - `[WindowPath <String>]`: Path for the validation script
  - `[WindowsUncCredentialsName <String>]`: username to access the network path
  - `[WindowsUncCredentialsPassword <String>]`: password to access the network path
  - `[WindowsUncSavedCredentialsId <Int32?>]`: 
  - `[WindowsUncSavedCredentialsName <String>]`: 

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
  - `[Guid <String>]`: GUID of the VM to be added as content
  - `[Name <String>]`: name of the VM to be added as content
  - `[Type <String>]`: 

DISKFILTERS <IVMDiskFilter[]>: .
  - `[Condition <String>]`: Operation type for VM rules/filters
  - `[FilterType <String>]`: 
  - `[Name <String>]`: The string to be filtered
  - `[VMGuid <String>]`: VM Guid of the Virtual Machine whose disk has to be filtered . This is optional. if not given, all disks of name and type from all Vms added in content will be filtered

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
  - `[Guid <String>]`: GUID of the VM to be added as content
  - `[Name <String>]`: name of the VM to be added as content
  - `[Type <String>]`: 

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

SECURITYASSOCIATIONS <ISecurityAssoc[]>: .
  - `[ExternalUserGroupId <Int32?>]`: User Group Id
  - `[ExternalUserGroupName <String>]`: External Group Name
  - `[ExternalUserGroupProviderId <Int32?>]`: Provider id
  - `[ExternalUserGroupProviderName <String>]`: Provider Name
  - `[IsCreatorAssociation <Boolean?>]`: 
  - `[PermissionList <IPermissionResp[]>]`: 
    - `[CategoryId <Int32?>]`: 
    - `[CategoryName <String>]`: 
    - `[PermissionId <Int32?>]`: 
    - `[PermissionName <String>]`: 
    - `[Type <String>]`: Returns the type of association.
  - `[RoleId <Int32?>]`: 
  - `[RoleName <String>]`: 
  - `[UserGroupId <Int32?>]`: 
  - `[UserGroupName <String>]`: 
  - `[UserId <Int32?>]`: 
  - `[UserName <String>]`: 

## RELATED LINKS

