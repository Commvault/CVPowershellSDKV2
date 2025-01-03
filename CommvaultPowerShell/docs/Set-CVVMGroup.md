---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/set-cvvmgroup
schema: 2.0.0
---

# Set-CVVMGroup

## SYNOPSIS
Update the VM Group

## SYNTAX

### UpdateExpanded (Default)
```
Set-CVVMGroup -VMGroupId <Int64> [-AccessNode <IAccessNodeModel[]>] [-ActivityControlEnableBackup]
 [-ActivityControlEnableRestore] [-ApplicationValidation <IVMAppValidation>]
 [-BackupActivityControlOptionActivityType <String>] [-BackupActivityControlOptionEnableActivityType]
 [-BackupActivityControlOptionEnableAfterADelay] [-BackupActivityControlOptionsDelayTime <Int64>]
 [-BackupActivityControlOptionsDelayTimeValue <String>] [-BackupActivityControlOptionsDelayTimeZoneId <Int64>]
 [-BackupActivityControlOptionsDelayTimeZoneName <String>] [-ContentOverwrite]
 [-ContentRuleGroups <IRuleGroupContent[]>] [-ContentVirtualMachines <IVirtualMachinecontent[]>]
 [-DiskFilterOverwrite] [-DiskFilterRules <IVMDiskFilter[]>] [-EnableFileIndexing] [-FilterOverwrite]
 [-FilterRuleGroups <IRuleGroupContent[]>] [-FilterVirtualMachines <IVirtualMachinecontent[]>]
 [-MeditechSystemListenerIP <String>] [-MeditechSystemListenerPort <Int64>]
 [-MeditechSystemMbFtimeout <Int64>] [-MeditechSystemName <String>] [-NewName <String>] [-PlanId <Int64>]
 [-PlanName <String>] [-RestoreActivityControlOptionActivityType <String>]
 [-RestoreActivityControlOptionEnableActivityType] [-RestoreActivityControlOptionEnableAfterADelay]
 [-RestoreActivityControlOptionsDelayTime <Int64>] [-RestoreActivityControlOptionsDelayTimeValue <String>]
 [-RestoreActivityControlOptionsDelayTimeZoneId <Int64>]
 [-RestoreActivityControlOptionsDelayTimeZoneName <String>] [-SecurityAssociations <ISecurityAssoc[]>]
 [-Settings <IVMGroupSettings>] [-SnapEngineId <Int64>] [-SnapEngineName <String>] [-SnapMountProxyId <Int64>]
 [-SnapMountProxyName <String>] [-SnapshotManagementBackupCopyInterface <String>]
 [-SnapshotManagementEnableHardwareSnapshot] [-SnapshotManagementIsIndependentDisksEnabled]
 [-SnapshotManagementIsRawDeviceMapsEnabled] [-SnapshotManagementSnapMountEsxHost <String>]
 [-SnapshotManagementUseSeparateProxyForSnapToTape] [-SnapshotManagementVMApplicationUserName <String>]
 [-StorageId <Int64>] [-StorageName <String>] [-TimeZoneId <Int64>] [-TimeZoneName <String>]
 [-UserAccountName <String>] [-UserAccountPassword <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Set-CVVMGroup -InputObject <ICommvaultPowerShellIdentity> [-AccessNode <IAccessNodeModel[]>]
 [-ActivityControlEnableBackup] [-ActivityControlEnableRestore] [-ApplicationValidation <IVMAppValidation>]
 [-BackupActivityControlOptionActivityType <String>] [-BackupActivityControlOptionEnableActivityType]
 [-BackupActivityControlOptionEnableAfterADelay] [-BackupActivityControlOptionsDelayTime <Int64>]
 [-BackupActivityControlOptionsDelayTimeValue <String>] [-BackupActivityControlOptionsDelayTimeZoneId <Int64>]
 [-BackupActivityControlOptionsDelayTimeZoneName <String>] [-ContentOverwrite]
 [-ContentRuleGroups <IRuleGroupContent[]>] [-ContentVirtualMachines <IVirtualMachinecontent[]>]
 [-DiskFilterOverwrite] [-DiskFilterRules <IVMDiskFilter[]>] [-EnableFileIndexing] [-FilterOverwrite]
 [-FilterRuleGroups <IRuleGroupContent[]>] [-FilterVirtualMachines <IVirtualMachinecontent[]>]
 [-MeditechSystemListenerIP <String>] [-MeditechSystemListenerPort <Int64>]
 [-MeditechSystemMbFtimeout <Int64>] [-MeditechSystemName <String>] [-NewName <String>] [-PlanId <Int64>]
 [-PlanName <String>] [-RestoreActivityControlOptionActivityType <String>]
 [-RestoreActivityControlOptionEnableActivityType] [-RestoreActivityControlOptionEnableAfterADelay]
 [-RestoreActivityControlOptionsDelayTime <Int64>] [-RestoreActivityControlOptionsDelayTimeValue <String>]
 [-RestoreActivityControlOptionsDelayTimeZoneId <Int64>]
 [-RestoreActivityControlOptionsDelayTimeZoneName <String>] [-SecurityAssociations <ISecurityAssoc[]>]
 [-Settings <IVMGroupSettings>] [-SnapEngineId <Int64>] [-SnapEngineName <String>] [-SnapMountProxyId <Int64>]
 [-SnapMountProxyName <String>] [-SnapshotManagementBackupCopyInterface <String>]
 [-SnapshotManagementEnableHardwareSnapshot] [-SnapshotManagementIsIndependentDisksEnabled]
 [-SnapshotManagementIsRawDeviceMapsEnabled] [-SnapshotManagementSnapMountEsxHost <String>]
 [-SnapshotManagementUseSeparateProxyForSnapToTape] [-SnapshotManagementVMApplicationUserName <String>]
 [-StorageId <Int64>] [-StorageName <String>] [-TimeZoneId <Int64>] [-TimeZoneName <String>]
 [-UserAccountName <String>] [-UserAccountPassword <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the VM Group

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

### -AccessNode
.

```yaml
Type: Commvault.Powershell.Models.IAccessNodeModel[]
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

### -BackupActivityControlOptionActivityType
denotes the activity type being considered

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

### -BackupActivityControlOptionEnableActivityType
True if the activity type is enabled

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

### -BackupActivityControlOptionEnableAfterADelay
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

### -BackupActivityControlOptionsDelayTime
delay time in unix timestamp

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

### -BackupActivityControlOptionsDelayTimeValue
actual delay time value in string format according to the timezone

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

### -BackupActivityControlOptionsDelayTimeZoneId
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

### -BackupActivityControlOptionsDelayTimeZoneName
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

### -DiskFilterOverwrite
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

### -DiskFilterRules
.

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

### -MeditechSystemListenerIP
Meditech Listener IP of FQDN name

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

### -MeditechSystemListenerPort
Meditech Listener Port

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

### -MeditechSystemMbFtimeout
MBF timeout (in seconds)

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

### -MeditechSystemName
Meditech system name

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
Type: System.Int64
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

### -RestoreActivityControlOptionActivityType
denotes the activity type being considered

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

### -RestoreActivityControlOptionEnableActivityType
True if the activity type is enabled

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

### -RestoreActivityControlOptionEnableAfterADelay
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

### -RestoreActivityControlOptionsDelayTime
delay time in unix timestamp

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

### -RestoreActivityControlOptionsDelayTimeValue
actual delay time value in string format according to the timezone

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

### -RestoreActivityControlOptionsDelayTimeZoneId
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

### -RestoreActivityControlOptionsDelayTimeZoneName
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

### -Settings
.

```yaml
Type: Commvault.Powershell.Models.IVMGroupSettings
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
Type: System.Int64
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
Type: System.Int64
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
Type: System.Int64
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

### -TimeZoneId
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

### -TimeZoneName
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

### -UserAccountName
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

### -UserAccountPassword
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

### -VMGroupId
Id of the VMgroup to update

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

### Commvault.Powershell.Models.IGenericRespWithWarning

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACCESSNODE <IAccessNodeModel[]>`: .
  - `[DisplayName <String>]`: Display name of the access node
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 
  - `[Type <Int64?>]`: Type of access node , Ex: 3 - access Node , 28 - Access Node Groups

`APPLICATIONVALIDATION <IVMAppValidation>`: vmAppValidation
  - `[BackupDestinationId <Int64?>]`: 
  - `[BackupDestinationName <String>]`: 
  - `[CopyId <Int64?>]`: Id of the source copy
  - `[CopyIsActive <Boolean?>]`: Is this an active backup destination?
  - `[CopyIsSnapCopy <Boolean?>]`: Is this a snap copy?
  - `[CopyName <String>]`: Name of the source copy
  - `[CopyPrecedence <Int64?>]`: Order of backup destinaion copy created in storage policy
  - `[CredentialsName <String>]`: username to access the network path
  - `[CredentialsPassword <String>]`: password to access the network path
  - `[KeepValidatedVMSRunning <Boolean?>]`: If true then validated VMs will be available until expiration time set on the recovery target
  - `[MaximumNoOfThreads <Int64?>]`: Number of backup Validation Threads
  - `[RecoveryTargetId <Int64?>]`: 
  - `[RecoveryTargetName <String>]`: 
  - `[SavedCredentialsId <Int64?>]`: 
  - `[SavedCredentialsName <String>]`: 
  - `[ScheduleDescription <String>]`: Description for validation schedule
  - `[ScheduleId <Int64?>]`: 
  - `[ScheduleIsScheduleEnabled <Boolean?>]`: True if application validation schedule is enabled
  - `[ScheduleTaskId <Int64?>]`: Job Id for the application validation task. 0 if schedule is disabled
  - `[UnixArguments <String>]`: Arguments for the script
  - `[UnixIsDisabled <Boolean?>]`: Is the script disabled
  - `[UnixIsLocal <Boolean?>]`: True if the script is local
  - `[UnixPath <String>]`: Path for the validation script
  - `[UnixUncCredentialsName <String>]`: username to access the network path
  - `[UnixUncCredentialsPassword <String>]`: password to access the network path
  - `[UnixUncSavedCredentialsId <Int64?>]`: 
  - `[UnixUncSavedCredentialsName <String>]`: 
  - `[UseSourceVMEsxToMount <Boolean?>]`: Use Source VM ESX To Mount
  - `[ValidateVMBackups <Boolean?>]`: True if VM Backup validation is enabled
  - `[WindowArguments <String>]`: Arguments for the script
  - `[WindowIsDisabled <Boolean?>]`: Is the script disabled
  - `[WindowIsLocal <Boolean?>]`: True if the script is local
  - `[WindowPath <String>]`: Path for the validation script
  - `[WindowsUncCredentialsName <String>]`: username to access the network path
  - `[WindowsUncCredentialsPassword <String>]`: password to access the network path
  - `[WindowsUncSavedCredentialsId <Int64?>]`: 
  - `[WindowsUncSavedCredentialsName <String>]`: 

`CONTENTRULEGROUPS <IRuleGroupContent[]>`: .
  - `[MatchRule <String>]`: Enum which specifies the whether to match all rules or any of the rules
  - `[Rules <List<IRuleContent>>]`: 
    - `[Condition <String>]`: Operation type for VM rules/filters
    - `[DisplayName <String>]`: The display name of the entity to be added
    - `[Guid <String>]`: GUID of the entity to be added as content
    - `[Name <String>]`: name of the VM to be added as content
    - `[Type <String>]`: 
    - `[Value <String>]`: value for the few type of VM Content like powerstate

`CONTENTVIRTUALMACHINES <IVirtualMachinecontent[]>`: .
  - `[ExistingCredentialId <Int64?>]`: 
  - `[ExistingCredentialName <String>]`: 
  - `[GuestCredentialAssocId <Int64?>]`: Credential association ID given to link entity with credential id.
  - `[GuestCredentialsPassword <String>]`: 
  - `[GuestCredentialsUserName <String>]`: 
  - `[Guid <String>]`: GUID of the VM to be added as content
  - `[Name <String>]`: name of the VM to be added as content
  - `[Type <String>]`: 

`DISKFILTERRULES <IVMDiskFilter[]>`: .
  - `[Condition <String>]`: Operation type for VM rules/filters
  - `[FilterType <String>]`: 
  - `[Name <String>]`: The string to be filtered
  - `[Overwrite <Boolean?>]`: True if disk filter in vmgroup has to be overwritten, by default it will append the content
  - `[VMGuid <String>]`: VM Guid of the Virtual Machine whose disk has to be filtered . This is optional. if not given, all disks of name and type from all Vms added in content will be filtered
  - `[VMName <String>]`: VM Name of the Virtual Machine whose disk has to be filtered . This is optional. if not given, all disks of name and type from all Vms added in content will be filtered
  - `[Value <String>]`: The value string to be filtered, in case of disk tag , value of tag to be filtered

`FILTERRULEGROUPS <IRuleGroupContent[]>`: .
  - `[MatchRule <String>]`: Enum which specifies the whether to match all rules or any of the rules
  - `[Rules <List<IRuleContent>>]`: 
    - `[Condition <String>]`: Operation type for VM rules/filters
    - `[DisplayName <String>]`: The display name of the entity to be added
    - `[Guid <String>]`: GUID of the entity to be added as content
    - `[Name <String>]`: name of the VM to be added as content
    - `[Type <String>]`: 
    - `[Value <String>]`: value for the few type of VM Content like powerstate

`FILTERVIRTUALMACHINES <IVirtualMachinecontent[]>`: .
  - `[ExistingCredentialId <Int64?>]`: 
  - `[ExistingCredentialName <String>]`: 
  - `[GuestCredentialAssocId <Int64?>]`: Credential association ID given to link entity with credential id.
  - `[GuestCredentialsPassword <String>]`: 
  - `[GuestCredentialsUserName <String>]`: 
  - `[Guid <String>]`: GUID of the VM to be added as content
  - `[Name <String>]`: name of the VM to be added as content
  - `[Type <String>]`: 

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

`SECURITYASSOCIATIONS <ISecurityAssoc[]>`: .
  - `[ExternalUserGroupId <Int64?>]`: User Group Id
  - `[ExternalUserGroupName <String>]`: External Group Name
  - `[ExternalUserGroupProviderId <Int64?>]`: Provider id
  - `[ExternalUserGroupProviderName <String>]`: Provider Name
  - `[IsCreatorAssociation <Boolean?>]`: 
  - `[PermissionList <List<IPermissionResp>>]`: 
    - `[CategoryId <Int64?>]`: 
    - `[CategoryName <String>]`: 
    - `[Exclude <Boolean?>]`: Flag to specify if this is included permission or excluded permission.
    - `[PermissionId <Int64?>]`: 
    - `[PermissionName <String>]`: 
    - `[Type <String>]`: Returns the type of association.
  - `[RoleId <Int64?>]`: 
  - `[RoleName <String>]`: 
  - `[UserGroupId <Int64?>]`: 
  - `[UserGroupName <String>]`: 
  - `[UserId <Int64?>]`: 
  - `[UserName <String>]`: 

`SETTINGS <IVMGroupSettings>`: .
  - `[AllowEmptySubclient <Boolean?>]`: True if empty subclient is allowed
  - `[AutoDetectVMOwner <Boolean?>]`: True if auto detect VM Owner enabled
  - `[CollectFileDetailsFromSnapshotCopy <Boolean?>]`: True if metadata collection is enabled for intellisnap jobs. Only applicable for Indexing v1
  - `[CollectFileDetailsforGranularRecovery <Boolean?>]`: True if metadata collection is enabled. Only applicable for Indexing v1
  - `[CredentialsName <String>]`: username to access the network path
  - `[CredentialsPassword <String>]`: password to access the network path
  - `[CrossAccountFullCopy <Boolean?>]`: True if full copy of amazon snapshot to different amazon account is enabled
  - `[CrossAccountShareOnly <Boolean?>]`: True if replicate and copy or sharing of amazon snapshot to different amazon account in same or different geographic location is enabled
  - `[CustomSnapshotResourceGroup <String>]`: Custom snapshot resource group name for Azure
  - `[CustomSnapshotTags <List<IResourceTag>>]`: represents custom tags to be set on snapshots
    - `[Name <String>]`: represents name of the tag
    - `[Value <String>]`: represents value of the tag
  - `[DatastoreFreespaceCheck <Boolean?>]`: True if Datastore Free space check is enabled
  - `[DatastoreFreespaceRequired <Int64?>]`: precentage of datastore free space check value
  - `[DestinationAccountId <Int64?>]`: 
  - `[DestinationAccountName <String>]`: 
  - `[IsApplicationAware <Boolean?>]`: Is the VM App Aware
  - `[IsVMGroupDiskFiltersIncluded <Boolean?>]`: Is VM group disk filters included in VM instance disk filters
  - `[JobStartTime <Int64?>]`: Start Time for the VM Group Job
  - `[NoOfReaders <Int64?>]`: Number of readers for backup
  - `[QuiesceGuestFileSystemAndApplications <Boolean?>]`: True if VM backup type is File system and application consistent
  - `[RegionalSnapshot <Boolean?>]`: True when snapshot storage location is regional
  - `[SavedCredentialsId <Int64?>]`: 
  - `[SavedCredentialsName <String>]`: 
  - `[TransportMode <String>]`: transport mode based on environment. Values are case sensitive
  - `[UseBackupsetDiskFilters <Boolean?>]`: True if use of backupset disk filters is allowed
  - `[UseChangedBlockTrackingOnVM <Boolean?>]`: True if Changed Block Tracking is enabled
  - `[UseVMCheckpointSetting <Boolean?>]`: True if use VM CheckPoint setting is enabled
  - `[VMBackupType <String>]`: 

## RELATED LINKS

