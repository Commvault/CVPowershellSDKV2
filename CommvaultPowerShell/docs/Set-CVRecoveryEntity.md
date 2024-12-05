---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/set-cvrecoveryentity
schema: 2.0.0
---

# Set-CVRecoveryEntity

## SYNOPSIS
Updating the entity in the recovery group

## SYNTAX

### UpdateExpanded (Default)
```
Set-CVRecoveryEntity -RecoveryGroupId <Int64> [-Entities <IRecoveryEntity[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update1
```
Set-CVRecoveryEntity -EntityId <Int64> -RecoveryGroupId <Int64> -Body <IRecoveryEntity> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateExpanded1
```
Set-CVRecoveryEntity -EntityId <Int64> -RecoveryGroupId <Int64> [-BackupSetId <Int64>]
 [-BackupSetName <String>] [-BlockSysrepForRecovery] [-ClientId <Int64>] [-ClientName <String>]
 [-ConnectionDetails <IVMConnectionDetails>] [-CopyAvailableTime <Int64>] [-EntityName <String>]
 [-ExecutionOrderGroup <Int64>] [-ExecutionOrderOrder <Int64>] [-ExecutionOrderPriority <Int64>] [-Id <Int64>]
 [-IdNameId <Int64>] [-InstalledWorkloads <String[]>] [-InstanceId <Int64>] [-InstanceName <String>]
 [-LastRecoveryJobId <Int64>] [-Name <String>] [-OSType <String>]
 [-PostRecoveryActions <IDrOperationScript[]>] [-PreRecoveryActions <IDrOperationScript[]>]
 [-RecoveryConfiguration <IRecoveryConfiguration>] [-RecoveryFailureReason <String>]
 [-RecoveryGroupId1 <Int64>] [-RecoveryGroupName <String>] [-RecoveryPoint <Int64>]
 [-RecoveryPointDetailEntityRecoveryPoint <Int64>] [-RecoveryPointDetailEntityRecoveryPointCategory <String>]
 [-RecoveryPointDetailInheritedFrom <String>] [-RecoveryPointDetailTimeZoneId <Int64>]
 [-RecoveryStatus <String>] [-RecoveryStatusNotReadyCategory <String>]
 [-RecoveryStatusNotReadyReason <String>] [-SourceVendor <String>] [-TargetId <Int64>] [-TargetName <String>]
 [-ValidationFailureReason <String>] [-ValidationResults <IValidationResult[]>] [-ValidationStatus <String>]
 [-VirtualMachineGuid <String>] [-VirtualMachineName <String>] [-VMGroupId <Int64>] [-VMGroupName <String>]
 [-Workload <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Set-CVRecoveryEntity -InputObject <ICommvaultPowerShellIdentity> -Body <IRecoveryEntity> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Set-CVRecoveryEntity -InputObject <ICommvaultPowerShellIdentity> [-Entities <IRecoveryEntity[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Set-CVRecoveryEntity -InputObject <ICommvaultPowerShellIdentity> [-EntityId <Int64>]
 [-RecoveryGroupId <Int64>] [-BackupSetId <Int64>] [-BackupSetName <String>] [-BlockSysrepForRecovery]
 [-ClientId <Int64>] [-ClientName <String>] [-ConnectionDetails <IVMConnectionDetails>]
 [-CopyAvailableTime <Int64>] [-EntityName <String>] [-ExecutionOrderGroup <Int64>]
 [-ExecutionOrderOrder <Int64>] [-ExecutionOrderPriority <Int64>] [-Id <Int64>]
 [-InstalledWorkloads <String[]>] [-InstanceId <Int64>] [-InstanceName <String>] [-LastRecoveryJobId <Int64>]
 [-Name <String>] [-OSType <String>] [-PostRecoveryActions <IDrOperationScript[]>]
 [-PreRecoveryActions <IDrOperationScript[]>] [-RecoveryConfiguration <IRecoveryConfiguration>]
 [-RecoveryFailureReason <String>] [-RecoveryGroupName <String>] [-RecoveryPoint <Int64>]
 [-RecoveryPointDetailEntityRecoveryPoint <Int64>] [-RecoveryPointDetailEntityRecoveryPointCategory <String>]
 [-RecoveryPointDetailInheritedFrom <String>] [-RecoveryPointDetailTimeZoneId <Int64>]
 [-RecoveryStatus <String>] [-RecoveryStatusNotReadyCategory <String>]
 [-RecoveryStatusNotReadyReason <String>] [-SourceVendor <String>] [-TargetId <Int64>] [-TargetName <String>]
 [-ValidationFailureReason <String>] [-ValidationResults <IValidationResult[]>] [-ValidationStatus <String>]
 [-VirtualMachineGuid <String>] [-VirtualMachineName <String>] [-VMGroupId <Int64>] [-VMGroupName <String>]
 [-Workload <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Updating the entity in the recovery group

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

### -BackupSetId
.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupSetName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlockSysrepForRecovery
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
The payload for the creation of recovery entity

```yaml
Type: Commvault.Powershell.Models.IRecoveryEntity
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClientId
.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConnectionDetails
VMConnectionDetails

```yaml
Type: Commvault.Powershell.Models.IVMConnectionDetails
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CopyAvailableTime
Timestamp of the latest backup job start time present in the copy that would be used for recovery.
Value would be -1 if no valid copy is present for recovery.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Entities
.

```yaml
Type: Commvault.Powershell.Models.IRecoveryEntity[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EntityId
Recovery entity Id

```yaml
Type: System.Int64
Parameter Sets: Update1, UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EntityName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExecutionOrderGroup
Group ID to group similar entities together

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExecutionOrderOrder
Decides the priority of entites within a group

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExecutionOrderPriority
Decides the priority of group execution

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Id of the recovery entity

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdNameId
.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1
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
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InstalledWorkloads
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstanceId
.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstanceName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastRecoveryJobId
Last recovery job Id of the entity

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Name of the recovery entity

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OSType
OS types

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PostRecoveryActions
.

```yaml
Type: Commvault.Powershell.Models.IDrOperationScript[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreRecoveryActions
.

```yaml
Type: Commvault.Powershell.Models.IDrOperationScript[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryConfiguration
RecoveryConfiguration

```yaml
Type: Commvault.Powershell.Models.IRecoveryConfiguration
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryFailureReason
Reason for last recovery job failure

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryGroupId
Recovery group Id

```yaml
Type: System.Int64
Parameter Sets: Update1, UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryGroupId1
.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryGroupName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryPoint
Timestamp for entity restore in case of disaster, default value is 0 as latest recovery point

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryPointDetailEntityRecoveryPoint
Timestamp for entity restore in case of disaster, default value is 0 as latest recovery point

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryPointDetailEntityRecoveryPointCategory
Type of recovery point category that can be selected.
Default is Latest

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryPointDetailInheritedFrom
Describes from where the recovery point is inherited from.
If not provided, recovery point will be used as if it is set at recovery group level

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryPointDetailTimeZoneId
TimeZone Id of the CS

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryStatus
Status of recovery entity

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryStatusNotReadyCategory
Recovery status not ready category

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryStatusNotReadyReason
Recovery status not ready reason

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceVendor
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetId
.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ValidationFailureReason
Reason for last validation failure

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ValidationResults
.

```yaml
Type: Commvault.Powershell.Models.IValidationResult[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ValidationStatus
Validation status of recovery entity

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VirtualMachineGuid
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VirtualMachineName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMGroupId
.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMGroupName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Workload
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Commvault.Powershell.Models.IRecoveryEntity

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IRecoveryEntity>`: The payload for the creation of recovery entity
  - `[BackupSetId <Int64?>]`: 
  - `[BackupSetName <String>]`: 
  - `[BlockSysrepForRecovery <Boolean?>]`: 
  - `[ClientId <Int64?>]`: 
  - `[ClientName <String>]`: 
  - `[ConnectionDetails <IVMConnectionDetails>]`: VMConnectionDetails
    - `[CsCredsCredentialsName <String>]`: username to access the network path
    - `[CsCredsCredentialsPassword <String>]`: password to access the network path
    - `[CsCredsSavedCredentialsId <Int64?>]`: 
    - `[CsCredsSavedCredentialsName <String>]`: 
    - `[DomainCredsCredentialsName <String>]`: username to access the network path
    - `[DomainCredsCredentialsPassword <String>]`: password to access the network path
    - `[DomainCredsSavedCredentialsId <Int64?>]`: 
    - `[DomainCredsSavedCredentialsName <String>]`: 
    - `[GuestCredsCredentialsName <String>]`: username to access the network path
    - `[GuestCredsCredentialsPassword <String>]`: password to access the network path
    - `[GuestCredsSavedCredentialsId <Int64?>]`: 
    - `[GuestCredsSavedCredentialsName <String>]`: 
    - `[TopologyDetailNetworkGateway <List<IGatewayConnectionInfo>>]`: 
      - `[Hostname <String>]`: Gateway machine hostname
      - `[Port <Int64?>]`: 
    - `[TopologyDetailServerGroups <List<IIdName>>]`: 
      - `[Id <Int64?>]`: 
      - `[Name <String>]`: 
    - `[VMClientName <String>]`: VM client name
    - `[VMHostName <String>]`: VM host name
  - `[CopyAvailableTime <Int64?>]`: Timestamp of the latest backup job start time present in the copy that would be used for recovery. Value would be -1 if no valid copy is present for recovery.
  - `[EntityId <Int64?>]`: 
  - `[EntityName <String>]`: 
  - `[ExecutionOrderGroup <Int64?>]`: Group ID to group similar entities together
  - `[ExecutionOrderOrder <Int64?>]`: Decides the priority of entites within a group
  - `[ExecutionOrderPriority <Int64?>]`: Decides the priority of group execution
  - `[Id <Int64?>]`: Id of the recovery entity
  - `[InstalledWorkloads <List<String>>]`: 
  - `[InstanceId <Int64?>]`: 
  - `[InstanceName <String>]`: 
  - `[LastRecoveryJobId <Int64?>]`: Last recovery job Id of the entity
  - `[Name <String>]`: Name of the recovery entity
  - `[OSType <String>]`: OS types
  - `[PostRecoveryActions <List<IDrOperationScript>>]`: 
    - `[GuestCredentialsCredentialsName <String>]`: username to access the network path
    - `[GuestCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[GuestCredentialsSavedCredentialsId <Int64?>]`: 
    - `[GuestCredentialsSavedCredentialsName <String>]`: 
    - `[Guid <String>]`: Unique script identifier string
    - `[OSType <String>]`: OS types
    - `[Path <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
    - `[Reset <Boolean?>]`: On set to true, resets the script to empty
    - `[ScriptContent <String>]`: Content of the script to be executed
    - `[ScriptCredentialsCredentialsName <String>]`: username to access the network path
    - `[ScriptCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[ScriptCredentialsSavedCredentialsId <Int64?>]`: 
    - `[ScriptCredentialsSavedCredentialsName <String>]`: 
    - `[ScriptName <String>]`: Name of the script
    - `[Type <String>]`: The type of path being used for DR operation script
  - `[PreRecoveryActions <List<IDrOperationScript>>]`: 
  - `[RecoveryConfiguration <IRecoveryConfiguration>]`: RecoveryConfiguration
    - `[AzureCreatePublicIP <Boolean?>]`: Create a public IP.
    - `[AzureDeployVMOnlyDuringfailover <Boolean?>]`: Select this option to deploy a VM only when a failover operation is requested
    - `[AzureDestinationVM <String>]`: Destination VM
    - `[AzureDiskType <String>]`: Type of the disk
    - `[AzureOverrideReplicationOptions <IOverrideReplicationOptionsAzure>]`: Replication options for Azure
      - `[AvailabilityZone <String>]`: VM availability zone
      - `[SecurityGroupId <String>]`: Security group id
      - `[SecurityGroupName <String>]`: security group name
      - `[TestFailoverVirtualNetworkDisplayName <String>]`: Display Name of network
      - `[TestFailoverVirtualNetworkId <String>]`: Network unique identifier
      - `[TestFailoverVirtualNetworkName <String>]`: Name of the network
      - `[TestFailoverVirtualNetworkNetworkAddressDetailsNetworkId <String>]`: Azure network ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}.
      - `[TestFailoverVirtualNetworkNetworkAddressDetailsPrivateIPAddress <String>]`: Azure private IP address.
      - `[TestFailoverVirtualNetworkNetworkAddressDetailsPublicIPAddress <String>]`: Azure publice IP address.
      - `[TestFailoverVirtualNetworkNetworkAddressDetailsPublicIPAddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
      - `[TestFailoverVirtualNetworkNetworkAddressDetailsSubnetId <String>]`: Azure subnet ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}/subnets/{Subnet Name}.
      - `[TestFailoverVirtualNetworkPrivateIPaddress <String>]`: Private IP address of the network
      - `[TestFailoverVirtualNetworkPublicIPAddress <String>]`: Public IP address of the network
      - `[TestFailoverVirtualNetworkPublicIPaddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
      - `[TestFailoverVirtualNetworkSubnetId <String>]`: subnet id of network
      - `[VirtualNetworkDisplayName <String>]`: Display Name of network
      - `[VirtualNetworkId <String>]`: Network unique identifier
      - `[VirtualNetworkName <String>]`: Name of the network
      - `[VirtualNetworkNetworkAddressDetailsNetworkId <String>]`: Azure network ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}.
      - `[VirtualNetworkNetworkAddressDetailsPrivateIPAddress <String>]`: Azure private IP address.
      - `[VirtualNetworkNetworkAddressDetailsPublicIPAddress <String>]`: Azure publice IP address.
      - `[VirtualNetworkNetworkAddressDetailsPublicIPAddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
      - `[VirtualNetworkNetworkAddressDetailsSubnetId <String>]`: Azure subnet ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}/subnets/{Subnet Name}.
      - `[VirtualNetworkPrivateIPaddress <String>]`: Private IP address of the network
      - `[VirtualNetworkPublicIPAddress <String>]`: Public IP address of the network
      - `[VirtualNetworkPublicIPaddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
      - `[VirtualNetworkSubnetId <String>]`: subnet id of network
    - `[AzureRegion <String>]`: region of the VM
    - `[AzureResourceGroup <String>]`: Resource group in which the converted virtual machine should be created.
    - `[AzureRestoreAsManagedVM <Boolean?>]`: Restore the VM as a managed disk for the destination VMs.
    - `[AzureSourceVM <String>]`: Source VM
    - `[AzureSourceVMGuid <String>]`: GUID of the source VM
    - `[AzureStorageAccount <String>]`: Azure Standard or Premium general-purpose storage account.
    - `[AzureTestFailoverVMSize <String>]`: Vm size to be used during the test failover operation
    - `[AzureUnconditionalOverwrite <Boolean?>]`: This will replace the instance at the destination if the instance with the same name already exists.
    - `[AzureVMSize <String>]`: VM size
    - `[CopyPrecedence <Int64?>]`: Copy precedence for the copy used for the restore
    - `[CredentialsSavedCredentialsId <Int64?>]`: 
    - `[CredentialsSavedCredentialsName <String>]`: 
    - `[DbConfigDatabases <List<IDbRecoveryConfigurationDatabase>>]`: 
      - `[DestinationName <String>]`: Name of the destination database
      - `[FileMappings <List<IDbRecoveryConfigurationDatabaseFileMapping>>]`: 
        - `[DestinationLogicalName <String>]`: Logical name of the file
        - `[DestinationPhysicalPath <String>]`: Physical path of the file
        - `[SourceLogicalName <String>]`: Logical name of the file
        - `[SourcePhysicalPath <String>]`: Physical path of the file
      - `[Id <Int64?>]`: ID of the source database
      - `[SourceName <String>]`: Name of the source database
    - `[HardwareConfigurationDataDiskConfiguration <List<IDiskConfiguration>>]`: 
      - `[DiskSize <Int64?>]`: Disk size in bytes
      - `[DiskType <String>]`: Type of disk controller
      - `[Name <String>]`: Name of the disk
      - `[ProvisioningType <String>]`: Disk provisioning type
    - `[HardwareConfigurationVolumeConfiguration <List<IVolumeConfiguration>>]`: 
      - `[Disks <List<IDiskConfiguration>>]`: 
      - `[Enabled <Boolean?>]`: Determine if volume is enabled or not
      - `[Name <String>]`: Name of the volume
      - `[TotalSize <Int64?>]`: Size for volume in bytes
    - `[ImageDetailSkipOSDisk <Boolean?>]`: Determine if OS disk should be attached to new VM during the disk attach restore
    - `[ImageDetailsVmCredsCredentialsName <String>]`: username to access the network path
    - `[ImageDetailsVmCredsCredentialsPassword <String>]`: password to access the network path
    - `[ImageDetailsVmCredsSavedCredentialsId <Int64?>]`: 
    - `[ImageDetailsVmCredsSavedCredentialsName <String>]`: 
    - `[InstanceId <Int64?>]`: 
    - `[InstanceName <String>]`: 
    - `[MediaAgentId <Int64?>]`: 
    - `[MediaAgentName <String>]`: 
    - `[Name <String>]`: username to access the network path
    - `[Password <String>]`: password to access the network path
    - `[ServerId <Int64?>]`: 
    - `[ServerName <String>]`: 
    - `[SystemDiskConfigurationDiskSize <Int64?>]`: Disk size in bytes
    - `[SystemDiskConfigurationDiskType <String>]`: Type of disk controller
    - `[SystemDiskConfigurationName <String>]`: Name of the disk
    - `[SystemDiskConfigurationProvisioningType <String>]`: Disk provisioning type
    - `[VMTemplateGuid <String>]`: 
    - `[VMTemplateName <String>]`: 
  - `[RecoveryFailureReason <String>]`: Reason for last recovery job failure
  - `[RecoveryGroupId <Int64?>]`: 
  - `[RecoveryGroupName <String>]`: 
  - `[RecoveryPoint <Int64?>]`: Timestamp for entity restore in case of disaster, default value is 0 as latest recovery point
  - `[RecoveryPointDetailEntityRecoveryPoint <Int64?>]`: Timestamp for entity restore in case of disaster, default value is 0 as latest recovery point
  - `[RecoveryPointDetailEntityRecoveryPointCategory <String>]`: Type of recovery point category that can be selected. Default is Latest
  - `[RecoveryPointDetailInheritedFrom <String>]`: Describes from where the recovery point is inherited from. If not provided, recovery point will be used as if it is set at recovery group level
  - `[RecoveryPointDetailTimeZoneId <Int64?>]`: TimeZone Id of the CS
  - `[RecoveryStatus <String>]`: Status of recovery entity
  - `[RecoveryStatusNotReadyCategory <String>]`: Recovery status not ready category
  - `[RecoveryStatusNotReadyReason <String>]`: Recovery status not ready reason
  - `[SourceVendor <String>]`: 
  - `[TargetId <Int64?>]`: 
  - `[TargetName <String>]`: 
  - `[VMGroupId <Int64?>]`: 
  - `[VMGroupName <String>]`: 
  - `[ValidationFailureReason <String>]`: Reason for last validation failure
  - `[ValidationResults <List<IValidationResult>>]`: 
    - `[FailureReason <String>]`: Script validation failure reason
    - `[Name <String>]`: Name of the script executed
    - `[Output <String>]`: Output of the script executed
    - `[ValidationStatus <String>]`: Validation status of recovery entity
  - `[ValidationStatus <String>]`: Validation status of recovery entity
  - `[VirtualMachineGuid <String>]`: 
  - `[VirtualMachineName <String>]`: 
  - `[Workload <String>]`: 

`CONNECTIONDETAILS <IVMConnectionDetails>`: VMConnectionDetails
  - `[CsCredsCredentialsName <String>]`: username to access the network path
  - `[CsCredsCredentialsPassword <String>]`: password to access the network path
  - `[CsCredsSavedCredentialsId <Int64?>]`: 
  - `[CsCredsSavedCredentialsName <String>]`: 
  - `[DomainCredsCredentialsName <String>]`: username to access the network path
  - `[DomainCredsCredentialsPassword <String>]`: password to access the network path
  - `[DomainCredsSavedCredentialsId <Int64?>]`: 
  - `[DomainCredsSavedCredentialsName <String>]`: 
  - `[GuestCredsCredentialsName <String>]`: username to access the network path
  - `[GuestCredsCredentialsPassword <String>]`: password to access the network path
  - `[GuestCredsSavedCredentialsId <Int64?>]`: 
  - `[GuestCredsSavedCredentialsName <String>]`: 
  - `[TopologyDetailNetworkGateway <List<IGatewayConnectionInfo>>]`: 
    - `[Hostname <String>]`: Gateway machine hostname
    - `[Port <Int64?>]`: 
  - `[TopologyDetailServerGroups <List<IIdName>>]`: 
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 
  - `[VMClientName <String>]`: VM client name
  - `[VMHostName <String>]`: VM host name

`ENTITIES <IRecoveryEntity[]>`: .
  - `[BackupSetId <Int64?>]`: 
  - `[BackupSetName <String>]`: 
  - `[BlockSysrepForRecovery <Boolean?>]`: 
  - `[ClientId <Int64?>]`: 
  - `[ClientName <String>]`: 
  - `[ConnectionDetails <IVMConnectionDetails>]`: VMConnectionDetails
    - `[CsCredsCredentialsName <String>]`: username to access the network path
    - `[CsCredsCredentialsPassword <String>]`: password to access the network path
    - `[CsCredsSavedCredentialsId <Int64?>]`: 
    - `[CsCredsSavedCredentialsName <String>]`: 
    - `[DomainCredsCredentialsName <String>]`: username to access the network path
    - `[DomainCredsCredentialsPassword <String>]`: password to access the network path
    - `[DomainCredsSavedCredentialsId <Int64?>]`: 
    - `[DomainCredsSavedCredentialsName <String>]`: 
    - `[GuestCredsCredentialsName <String>]`: username to access the network path
    - `[GuestCredsCredentialsPassword <String>]`: password to access the network path
    - `[GuestCredsSavedCredentialsId <Int64?>]`: 
    - `[GuestCredsSavedCredentialsName <String>]`: 
    - `[TopologyDetailNetworkGateway <List<IGatewayConnectionInfo>>]`: 
      - `[Hostname <String>]`: Gateway machine hostname
      - `[Port <Int64?>]`: 
    - `[TopologyDetailServerGroups <List<IIdName>>]`: 
      - `[Id <Int64?>]`: 
      - `[Name <String>]`: 
    - `[VMClientName <String>]`: VM client name
    - `[VMHostName <String>]`: VM host name
  - `[CopyAvailableTime <Int64?>]`: Timestamp of the latest backup job start time present in the copy that would be used for recovery. Value would be -1 if no valid copy is present for recovery.
  - `[EntityId <Int64?>]`: 
  - `[EntityName <String>]`: 
  - `[ExecutionOrderGroup <Int64?>]`: Group ID to group similar entities together
  - `[ExecutionOrderOrder <Int64?>]`: Decides the priority of entites within a group
  - `[ExecutionOrderPriority <Int64?>]`: Decides the priority of group execution
  - `[Id <Int64?>]`: Id of the recovery entity
  - `[InstalledWorkloads <List<String>>]`: 
  - `[InstanceId <Int64?>]`: 
  - `[InstanceName <String>]`: 
  - `[LastRecoveryJobId <Int64?>]`: Last recovery job Id of the entity
  - `[Name <String>]`: Name of the recovery entity
  - `[OSType <String>]`: OS types
  - `[PostRecoveryActions <List<IDrOperationScript>>]`: 
    - `[GuestCredentialsCredentialsName <String>]`: username to access the network path
    - `[GuestCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[GuestCredentialsSavedCredentialsId <Int64?>]`: 
    - `[GuestCredentialsSavedCredentialsName <String>]`: 
    - `[Guid <String>]`: Unique script identifier string
    - `[OSType <String>]`: OS types
    - `[Path <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
    - `[Reset <Boolean?>]`: On set to true, resets the script to empty
    - `[ScriptContent <String>]`: Content of the script to be executed
    - `[ScriptCredentialsCredentialsName <String>]`: username to access the network path
    - `[ScriptCredentialsCredentialsPassword <String>]`: password to access the network path
    - `[ScriptCredentialsSavedCredentialsId <Int64?>]`: 
    - `[ScriptCredentialsSavedCredentialsName <String>]`: 
    - `[ScriptName <String>]`: Name of the script
    - `[Type <String>]`: The type of path being used for DR operation script
  - `[PreRecoveryActions <List<IDrOperationScript>>]`: 
  - `[RecoveryConfiguration <IRecoveryConfiguration>]`: RecoveryConfiguration
    - `[AzureCreatePublicIP <Boolean?>]`: Create a public IP.
    - `[AzureDeployVMOnlyDuringfailover <Boolean?>]`: Select this option to deploy a VM only when a failover operation is requested
    - `[AzureDestinationVM <String>]`: Destination VM
    - `[AzureDiskType <String>]`: Type of the disk
    - `[AzureOverrideReplicationOptions <IOverrideReplicationOptionsAzure>]`: Replication options for Azure
      - `[AvailabilityZone <String>]`: VM availability zone
      - `[SecurityGroupId <String>]`: Security group id
      - `[SecurityGroupName <String>]`: security group name
      - `[TestFailoverVirtualNetworkDisplayName <String>]`: Display Name of network
      - `[TestFailoverVirtualNetworkId <String>]`: Network unique identifier
      - `[TestFailoverVirtualNetworkName <String>]`: Name of the network
      - `[TestFailoverVirtualNetworkNetworkAddressDetailsNetworkId <String>]`: Azure network ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}.
      - `[TestFailoverVirtualNetworkNetworkAddressDetailsPrivateIPAddress <String>]`: Azure private IP address.
      - `[TestFailoverVirtualNetworkNetworkAddressDetailsPublicIPAddress <String>]`: Azure publice IP address.
      - `[TestFailoverVirtualNetworkNetworkAddressDetailsPublicIPAddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
      - `[TestFailoverVirtualNetworkNetworkAddressDetailsSubnetId <String>]`: Azure subnet ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}/subnets/{Subnet Name}.
      - `[TestFailoverVirtualNetworkPrivateIPaddress <String>]`: Private IP address of the network
      - `[TestFailoverVirtualNetworkPublicIPAddress <String>]`: Public IP address of the network
      - `[TestFailoverVirtualNetworkPublicIPaddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
      - `[TestFailoverVirtualNetworkSubnetId <String>]`: subnet id of network
      - `[VirtualNetworkDisplayName <String>]`: Display Name of network
      - `[VirtualNetworkId <String>]`: Network unique identifier
      - `[VirtualNetworkName <String>]`: Name of the network
      - `[VirtualNetworkNetworkAddressDetailsNetworkId <String>]`: Azure network ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}.
      - `[VirtualNetworkNetworkAddressDetailsPrivateIPAddress <String>]`: Azure private IP address.
      - `[VirtualNetworkNetworkAddressDetailsPublicIPAddress <String>]`: Azure publice IP address.
      - `[VirtualNetworkNetworkAddressDetailsPublicIPAddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
      - `[VirtualNetworkNetworkAddressDetailsSubnetId <String>]`: Azure subnet ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}/subnets/{Subnet Name}.
      - `[VirtualNetworkPrivateIPaddress <String>]`: Private IP address of the network
      - `[VirtualNetworkPublicIPAddress <String>]`: Public IP address of the network
      - `[VirtualNetworkPublicIPaddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
      - `[VirtualNetworkSubnetId <String>]`: subnet id of network
    - `[AzureRegion <String>]`: region of the VM
    - `[AzureResourceGroup <String>]`: Resource group in which the converted virtual machine should be created.
    - `[AzureRestoreAsManagedVM <Boolean?>]`: Restore the VM as a managed disk for the destination VMs.
    - `[AzureSourceVM <String>]`: Source VM
    - `[AzureSourceVMGuid <String>]`: GUID of the source VM
    - `[AzureStorageAccount <String>]`: Azure Standard or Premium general-purpose storage account.
    - `[AzureTestFailoverVMSize <String>]`: Vm size to be used during the test failover operation
    - `[AzureUnconditionalOverwrite <Boolean?>]`: This will replace the instance at the destination if the instance with the same name already exists.
    - `[AzureVMSize <String>]`: VM size
    - `[CopyPrecedence <Int64?>]`: Copy precedence for the copy used for the restore
    - `[CredentialsSavedCredentialsId <Int64?>]`: 
    - `[CredentialsSavedCredentialsName <String>]`: 
    - `[DbConfigDatabases <List<IDbRecoveryConfigurationDatabase>>]`: 
      - `[DestinationName <String>]`: Name of the destination database
      - `[FileMappings <List<IDbRecoveryConfigurationDatabaseFileMapping>>]`: 
        - `[DestinationLogicalName <String>]`: Logical name of the file
        - `[DestinationPhysicalPath <String>]`: Physical path of the file
        - `[SourceLogicalName <String>]`: Logical name of the file
        - `[SourcePhysicalPath <String>]`: Physical path of the file
      - `[Id <Int64?>]`: ID of the source database
      - `[SourceName <String>]`: Name of the source database
    - `[HardwareConfigurationDataDiskConfiguration <List<IDiskConfiguration>>]`: 
      - `[DiskSize <Int64?>]`: Disk size in bytes
      - `[DiskType <String>]`: Type of disk controller
      - `[Name <String>]`: Name of the disk
      - `[ProvisioningType <String>]`: Disk provisioning type
    - `[HardwareConfigurationVolumeConfiguration <List<IVolumeConfiguration>>]`: 
      - `[Disks <List<IDiskConfiguration>>]`: 
      - `[Enabled <Boolean?>]`: Determine if volume is enabled or not
      - `[Name <String>]`: Name of the volume
      - `[TotalSize <Int64?>]`: Size for volume in bytes
    - `[ImageDetailSkipOSDisk <Boolean?>]`: Determine if OS disk should be attached to new VM during the disk attach restore
    - `[ImageDetailsVmCredsCredentialsName <String>]`: username to access the network path
    - `[ImageDetailsVmCredsCredentialsPassword <String>]`: password to access the network path
    - `[ImageDetailsVmCredsSavedCredentialsId <Int64?>]`: 
    - `[ImageDetailsVmCredsSavedCredentialsName <String>]`: 
    - `[InstanceId <Int64?>]`: 
    - `[InstanceName <String>]`: 
    - `[MediaAgentId <Int64?>]`: 
    - `[MediaAgentName <String>]`: 
    - `[Name <String>]`: username to access the network path
    - `[Password <String>]`: password to access the network path
    - `[ServerId <Int64?>]`: 
    - `[ServerName <String>]`: 
    - `[SystemDiskConfigurationDiskSize <Int64?>]`: Disk size in bytes
    - `[SystemDiskConfigurationDiskType <String>]`: Type of disk controller
    - `[SystemDiskConfigurationName <String>]`: Name of the disk
    - `[SystemDiskConfigurationProvisioningType <String>]`: Disk provisioning type
    - `[VMTemplateGuid <String>]`: 
    - `[VMTemplateName <String>]`: 
  - `[RecoveryFailureReason <String>]`: Reason for last recovery job failure
  - `[RecoveryGroupId <Int64?>]`: 
  - `[RecoveryGroupName <String>]`: 
  - `[RecoveryPoint <Int64?>]`: Timestamp for entity restore in case of disaster, default value is 0 as latest recovery point
  - `[RecoveryPointDetailEntityRecoveryPoint <Int64?>]`: Timestamp for entity restore in case of disaster, default value is 0 as latest recovery point
  - `[RecoveryPointDetailEntityRecoveryPointCategory <String>]`: Type of recovery point category that can be selected. Default is Latest
  - `[RecoveryPointDetailInheritedFrom <String>]`: Describes from where the recovery point is inherited from. If not provided, recovery point will be used as if it is set at recovery group level
  - `[RecoveryPointDetailTimeZoneId <Int64?>]`: TimeZone Id of the CS
  - `[RecoveryStatus <String>]`: Status of recovery entity
  - `[RecoveryStatusNotReadyCategory <String>]`: Recovery status not ready category
  - `[RecoveryStatusNotReadyReason <String>]`: Recovery status not ready reason
  - `[SourceVendor <String>]`: 
  - `[TargetId <Int64?>]`: 
  - `[TargetName <String>]`: 
  - `[VMGroupId <Int64?>]`: 
  - `[VMGroupName <String>]`: 
  - `[ValidationFailureReason <String>]`: Reason for last validation failure
  - `[ValidationResults <List<IValidationResult>>]`: 
    - `[FailureReason <String>]`: Script validation failure reason
    - `[Name <String>]`: Name of the script executed
    - `[Output <String>]`: Output of the script executed
    - `[ValidationStatus <String>]`: Validation status of recovery entity
  - `[ValidationStatus <String>]`: Validation status of recovery entity
  - `[VirtualMachineGuid <String>]`: 
  - `[VirtualMachineName <String>]`: 
  - `[Workload <String>]`: 

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

`POSTRECOVERYACTIONS <IDrOperationScript[]>`: .
  - `[GuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[GuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[GuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[GuestCredentialsSavedCredentialsName <String>]`: 
  - `[Guid <String>]`: Unique script identifier string
  - `[OSType <String>]`: OS types
  - `[Path <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[Reset <Boolean?>]`: On set to true, resets the script to empty
  - `[ScriptContent <String>]`: Content of the script to be executed
  - `[ScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[ScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[ScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[ScriptCredentialsSavedCredentialsName <String>]`: 
  - `[ScriptName <String>]`: Name of the script
  - `[Type <String>]`: The type of path being used for DR operation script

`PRERECOVERYACTIONS <IDrOperationScript[]>`: .
  - `[GuestCredentialsCredentialsName <String>]`: username to access the network path
  - `[GuestCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[GuestCredentialsSavedCredentialsId <Int64?>]`: 
  - `[GuestCredentialsSavedCredentialsName <String>]`: 
  - `[Guid <String>]`: Unique script identifier string
  - `[OSType <String>]`: OS types
  - `[Path <String>]`: The path of the script to be executed. Can be local path on VM or UNC path accessible by access node
  - `[Reset <Boolean?>]`: On set to true, resets the script to empty
  - `[ScriptContent <String>]`: Content of the script to be executed
  - `[ScriptCredentialsCredentialsName <String>]`: username to access the network path
  - `[ScriptCredentialsCredentialsPassword <String>]`: password to access the network path
  - `[ScriptCredentialsSavedCredentialsId <Int64?>]`: 
  - `[ScriptCredentialsSavedCredentialsName <String>]`: 
  - `[ScriptName <String>]`: Name of the script
  - `[Type <String>]`: The type of path being used for DR operation script

`RECOVERYCONFIGURATION <IRecoveryConfiguration>`: RecoveryConfiguration
  - `[AzureCreatePublicIP <Boolean?>]`: Create a public IP.
  - `[AzureDeployVMOnlyDuringfailover <Boolean?>]`: Select this option to deploy a VM only when a failover operation is requested
  - `[AzureDestinationVM <String>]`: Destination VM
  - `[AzureDiskType <String>]`: Type of the disk
  - `[AzureOverrideReplicationOptions <IOverrideReplicationOptionsAzure>]`: Replication options for Azure
    - `[AvailabilityZone <String>]`: VM availability zone
    - `[SecurityGroupId <String>]`: Security group id
    - `[SecurityGroupName <String>]`: security group name
    - `[TestFailoverVirtualNetworkDisplayName <String>]`: Display Name of network
    - `[TestFailoverVirtualNetworkId <String>]`: Network unique identifier
    - `[TestFailoverVirtualNetworkName <String>]`: Name of the network
    - `[TestFailoverVirtualNetworkNetworkAddressDetailsNetworkId <String>]`: Azure network ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}.
    - `[TestFailoverVirtualNetworkNetworkAddressDetailsPrivateIPAddress <String>]`: Azure private IP address.
    - `[TestFailoverVirtualNetworkNetworkAddressDetailsPublicIPAddress <String>]`: Azure publice IP address.
    - `[TestFailoverVirtualNetworkNetworkAddressDetailsPublicIPAddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
    - `[TestFailoverVirtualNetworkNetworkAddressDetailsSubnetId <String>]`: Azure subnet ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}/subnets/{Subnet Name}.
    - `[TestFailoverVirtualNetworkPrivateIPaddress <String>]`: Private IP address of the network
    - `[TestFailoverVirtualNetworkPublicIPAddress <String>]`: Public IP address of the network
    - `[TestFailoverVirtualNetworkPublicIPaddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
    - `[TestFailoverVirtualNetworkSubnetId <String>]`: subnet id of network
    - `[VirtualNetworkDisplayName <String>]`: Display Name of network
    - `[VirtualNetworkId <String>]`: Network unique identifier
    - `[VirtualNetworkName <String>]`: Name of the network
    - `[VirtualNetworkNetworkAddressDetailsNetworkId <String>]`: Azure network ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}.
    - `[VirtualNetworkNetworkAddressDetailsPrivateIPAddress <String>]`: Azure private IP address.
    - `[VirtualNetworkNetworkAddressDetailsPublicIPAddress <String>]`: Azure publice IP address.
    - `[VirtualNetworkNetworkAddressDetailsPublicIPAddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
    - `[VirtualNetworkNetworkAddressDetailsSubnetId <String>]`: Azure subnet ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}/subnets/{Subnet Name}.
    - `[VirtualNetworkPrivateIPaddress <String>]`: Private IP address of the network
    - `[VirtualNetworkPublicIPAddress <String>]`: Public IP address of the network
    - `[VirtualNetworkPublicIPaddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
    - `[VirtualNetworkSubnetId <String>]`: subnet id of network
  - `[AzureRegion <String>]`: region of the VM
  - `[AzureResourceGroup <String>]`: Resource group in which the converted virtual machine should be created.
  - `[AzureRestoreAsManagedVM <Boolean?>]`: Restore the VM as a managed disk for the destination VMs.
  - `[AzureSourceVM <String>]`: Source VM
  - `[AzureSourceVMGuid <String>]`: GUID of the source VM
  - `[AzureStorageAccount <String>]`: Azure Standard or Premium general-purpose storage account.
  - `[AzureTestFailoverVMSize <String>]`: Vm size to be used during the test failover operation
  - `[AzureUnconditionalOverwrite <Boolean?>]`: This will replace the instance at the destination if the instance with the same name already exists.
  - `[AzureVMSize <String>]`: VM size
  - `[CopyPrecedence <Int64?>]`: Copy precedence for the copy used for the restore
  - `[CredentialsSavedCredentialsId <Int64?>]`: 
  - `[CredentialsSavedCredentialsName <String>]`: 
  - `[DbConfigDatabases <List<IDbRecoveryConfigurationDatabase>>]`: 
    - `[DestinationName <String>]`: Name of the destination database
    - `[FileMappings <List<IDbRecoveryConfigurationDatabaseFileMapping>>]`: 
      - `[DestinationLogicalName <String>]`: Logical name of the file
      - `[DestinationPhysicalPath <String>]`: Physical path of the file
      - `[SourceLogicalName <String>]`: Logical name of the file
      - `[SourcePhysicalPath <String>]`: Physical path of the file
    - `[Id <Int64?>]`: ID of the source database
    - `[SourceName <String>]`: Name of the source database
  - `[HardwareConfigurationDataDiskConfiguration <List<IDiskConfiguration>>]`: 
    - `[DiskSize <Int64?>]`: Disk size in bytes
    - `[DiskType <String>]`: Type of disk controller
    - `[Name <String>]`: Name of the disk
    - `[ProvisioningType <String>]`: Disk provisioning type
  - `[HardwareConfigurationVolumeConfiguration <List<IVolumeConfiguration>>]`: 
    - `[Disks <List<IDiskConfiguration>>]`: 
    - `[Enabled <Boolean?>]`: Determine if volume is enabled or not
    - `[Name <String>]`: Name of the volume
    - `[TotalSize <Int64?>]`: Size for volume in bytes
  - `[ImageDetailSkipOSDisk <Boolean?>]`: Determine if OS disk should be attached to new VM during the disk attach restore
  - `[ImageDetailsVmCredsCredentialsName <String>]`: username to access the network path
  - `[ImageDetailsVmCredsCredentialsPassword <String>]`: password to access the network path
  - `[ImageDetailsVmCredsSavedCredentialsId <Int64?>]`: 
  - `[ImageDetailsVmCredsSavedCredentialsName <String>]`: 
  - `[InstanceId <Int64?>]`: 
  - `[InstanceName <String>]`: 
  - `[MediaAgentId <Int64?>]`: 
  - `[MediaAgentName <String>]`: 
  - `[Name <String>]`: username to access the network path
  - `[Password <String>]`: password to access the network path
  - `[ServerId <Int64?>]`: 
  - `[ServerName <String>]`: 
  - `[SystemDiskConfigurationDiskSize <Int64?>]`: Disk size in bytes
  - `[SystemDiskConfigurationDiskType <String>]`: Type of disk controller
  - `[SystemDiskConfigurationName <String>]`: Name of the disk
  - `[SystemDiskConfigurationProvisioningType <String>]`: Disk provisioning type
  - `[VMTemplateGuid <String>]`: 
  - `[VMTemplateName <String>]`: 

`VALIDATIONRESULTS <IValidationResult[]>`: .
  - `[FailureReason <String>]`: Script validation failure reason
  - `[Name <String>]`: Name of the script executed
  - `[Output <String>]`: Output of the script executed
  - `[ValidationStatus <String>]`: Validation status of recovery entity

## RELATED LINKS

