---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/group-cv
schema: 2.0.0
---

# Group-CV

## SYNOPSIS
To restore the virtual machines in vmgroup

## SYNTAX

### Group1 (Default)
```
Group-CV -VMGroupId <Int64> [-BackupLevel <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Group
```
Group-CV -VMGroupId <Int64> -Body <IVMGroupRestoreRequest> [-FromTime <String>] [-MediaAgentId <String>]
 [-MediaAgentName <String>] [-ToTime <DateTime>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GroupExpanded
```
Group-CV -VMGroupId <Int64> [-FromTime <String>] [-MediaAgentId <String>] [-MediaAgentName <String>]
 [-ToTime <DateTime>] [-AccessNodeGroupId <Int64>] [-AccessNodeGroupName <String>] [-AccessNodeId <Int64>]
 [-AccessNodeName <String>] [-AwAwsInstanceInfoList <IAwsInstanceInfo[]>] [-AwNamePrefix <String>]
 [-AwNameSuffix <String>] [-AzureNamePrefix <String>] [-AzureNameSuffix <String>]
 [-AzureVMInfoList <IAzureVMInfo[]>] [-BackupSource <Int64>] [-DestinationId <Int64>]
 [-DestinationName <String>] [-GoogleCloudNamePrefix <String>] [-GoogleCloudNameSuffix <String>]
 [-GoogleCloudVMInfoList <IGoogleCloudVMInfo[]>] [-InPlaceRestore] [-NotifyOnJobCompletion] [-OverwriteVM]
 [-PowerOnVMAfterRestore] [-RestoreFlavour <String>] [-ReuseVMClient] [-TransportMode <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### GroupViaIdentity
```
Group-CV -InputObject <ICommvaultPowerShellIdentity> -Body <IVMGroupRestoreRequest> [-FromTime <String>]
 [-MediaAgentId <String>] [-MediaAgentName <String>] [-ToTime <DateTime>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### GroupViaIdentity1
```
Group-CV -InputObject <ICommvaultPowerShellIdentity> [-BackupLevel <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### GroupViaIdentityExpanded
```
Group-CV -InputObject <ICommvaultPowerShellIdentity> [-FromTime <String>] [-MediaAgentId <String>]
 [-MediaAgentName <String>] [-ToTime <DateTime>] [-AccessNodeGroupId <Int64>] [-AccessNodeGroupName <String>]
 [-AccessNodeId <Int64>] [-AccessNodeName <String>] [-AwAwsInstanceInfoList <IAwsInstanceInfo[]>]
 [-AwNamePrefix <String>] [-AwNameSuffix <String>] [-AzureNamePrefix <String>] [-AzureNameSuffix <String>]
 [-AzureVMInfoList <IAzureVMInfo[]>] [-BackupSource <Int64>] [-DestinationId <Int64>]
 [-DestinationName <String>] [-GoogleCloudNamePrefix <String>] [-GoogleCloudNameSuffix <String>]
 [-GoogleCloudVMInfoList <IGoogleCloudVMInfo[]>] [-InPlaceRestore] [-NotifyOnJobCompletion] [-OverwriteVM]
 [-PowerOnVMAfterRestore] [-RestoreFlavour <String>] [-ReuseVMClient] [-TransportMode <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
To restore the virtual machines in vmgroup

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

### -AccessNodeGroupId
.

```yaml
Type: System.Int64
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessNodeGroupName
.

```yaml
Type: System.String
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessNodeId
.

```yaml
Type: System.Int64
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessNodeName
.

```yaml
Type: System.String
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AwAwsInstanceInfoList
List of AWS instances that are to be restored

```yaml
Type: Commvault.Powershell.Models.IAwsInstanceInfo[]
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AwNamePrefix
Adds prefix for instance display name

```yaml
Type: System.String
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AwNameSuffix
Adds suffix for instance display name

```yaml
Type: System.String
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureNamePrefix
Adds prefix for VM display name

```yaml
Type: System.String
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureNameSuffix
Adds suffix for VM display name

```yaml
Type: System.String
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureVMInfoList
List of Azure VMs that are to be restored

```yaml
Type: Commvault.Powershell.Models.IAzureVMInfo[]
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupLevel
Backup level , Default :Incremental

```yaml
Type: System.String
Parameter Sets: Group1, GroupViaIdentity1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupSource
Backup source information from where you want to restore.
0 (Automatic), 1 (Snap Copy), 2 (Primary), 3 to N (Aux Copy)

```yaml
Type: System.Int64
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
VM or VMGroup restore request body

```yaml
Type: Commvault.Powershell.Models.IVMGroupRestoreRequest
Parameter Sets: Group, GroupViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DestinationId
.

```yaml
Type: System.Int64
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DestinationName
.

```yaml
Type: System.String
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FromTime
Restore window UTC from time.
Valid Formats: yyyy-MM-ddTHH:mm:ss or yyyy-MM-ddTHH:mm:sszzz or yyyy-MM-dd

```yaml
Type: System.String
Parameter Sets: Group, GroupExpanded, GroupViaIdentity, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GoogleCloudNamePrefix
Adds prefix for VM display name

```yaml
Type: System.String
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GoogleCloudNameSuffix
Adds suffix for VM display name

```yaml
Type: System.String
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GoogleCloudVMInfoList
List of Google Cloud VMs that are to be restored

```yaml
Type: Commvault.Powershell.Models.IGoogleCloudVMInfo[]
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InPlaceRestore
Flag to set if restore is in-place or out-of-place.
Defaults to false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
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
Parameter Sets: GroupViaIdentity, GroupViaIdentity1, GroupViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MediaAgentId
Media agent id

```yaml
Type: System.String
Parameter Sets: Group, GroupExpanded, GroupViaIdentity, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MediaAgentName
Media agent name

```yaml
Type: System.String
Parameter Sets: Group, GroupExpanded, GroupViaIdentity, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotifyOnJobCompletion
Enable email notificaiton for job status.
Defaults to false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OverwriteVM
Unconditionally overwrite VM during restore.
Defaults to false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PowerOnVMAfterRestore
Turn ON virtual machine after restore.
Defaults to false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestoreFlavour
Type of restore for virtual machine

```yaml
Type: System.String
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReuseVMClient
Reuse the existing VM client instance of creating new one after restore.
Defaults to true for inplace restore and false for out of place restore.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ToTime
Restore window UTC to time.
Valid Formats: yyyy-MM-ddTHH:mm:ss or yyyy-MM-ddTHH:mm:sszzz or yyyy-MM-dd

```yaml
Type: System.DateTime
Parameter Sets: Group, GroupExpanded, GroupViaIdentity, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TransportMode
Backup transport modes enum

```yaml
Type: System.String
Parameter Sets: GroupExpanded, GroupViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMGroupId
Id of the VMgroup to backup

```yaml
Type: System.Int64
Parameter Sets: Group, Group1, GroupExpanded
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

### Commvault.Powershell.Models.IVMGroupRestoreRequest

## OUTPUTS

### Commvault.Powershell.Models.ICreateTaskRespforBackup

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`AWAWSINSTANCEINFOLIST <IAwsInstanceInfo[]>`: List of AWS instances that are to be restored
  - `[EncryptionKeyDiskEncryptionSetId <String>]`: 
  - `[EncryptionKeyDiskEncryptionSetTypeId <String>]`: 
  - `[EncryptionKeyIsEncrypted <Boolean?>]`: 
  - `[InstanceId <String>]`: AWS instance ID
  - `[InstanceName <String>]`: AWS instance name to be set after restore. Defaults to source instance name.
  - `[InstanceSize <String>]`: Instance size to be after restore. Defaults to source instance size
  - `[KeyPairs <List<IVMKeyPairInfo>>]`: List of key pairs
    - `[KeyId <String>]`: 
    - `[KeyName <String>]`: 
  - `[Nics <List<IAwsNetworkInterfaceInfo>>]`: AWS instance network interface list
    - `[EniId <String>]`: 
    - `[NetworkName <String>]`: 
    - `[SubnetId <String>]`: 
    - `[VpcId <String>]`: 
  - `[Region <String>]`: 
  - `[RestoreSourceNetworkConfig <Boolean?>]`: If set to true, we will use the source network configuration during restore
  - `[RestoreSourceVMTags <Boolean?>]`: Restore source VM tags.
  - `[SecurityGroups <List<IVMSecurityGroupInfo>>]`: List of AWS security groups to be set for the instance.
    - `[GroupId <String>]`: 
    - `[GroupName <String>]`: 
  - `[VMTags <List<INameValue>>]`: AWS VM tag list
    - `[Name <String>]`: 
    - `[Value <String>]`: 
  - `[VolumeType <String>]`: 
  - `[VsaEncryptionOptionEncryptionKey <String>]`: 
  - `[Zone <String>]`: AWS Availability zone. Defaults to source instance availability zone.

`AZUREVMINFOLIST <IAzureVMInfo[]>`: List of Azure VMs that are to be restored
  - `StorageAccount <String>`: Azure staging storage account. Defaults to source storage account.
  - `[AvailabilityZone <String>]`: Azure availablity zones. Defaults to Auto. Values can be as follows: 'Auto' (Select from the source VM config), 'None' (Will not restore to any zone), '{Zone Number}' (Availablity zone number the restored VM should be in. Ex: 2).
  - `[CreatePublicIP <Boolean?>]`: Boolean to specify if VM should have publice IP. Defaults to false.
  - `[DiskEncryptionSetId <String>]`: Azure Disk Encryption Set ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Compute/diskEncryptionSets/{Disk Encryption Set}.
  - `[DiskEncryptionSetTypeId <String>]`: Azure Disk Encryption Type. Values can be: 'EncryptionAtRestWithCustomerKey' or 'EncryptionAtRestWithPlatformAndCustomerKeys' or 'EncryptionAtRestWithPlatformAndCustomerKeys'. For reference: learn.microsoft.com/en-us/dotnet/api/microsoft.azure.management.compute.models.encryptiontype?view=azure-dotnet&viewFallbackFrom=azure-dotnet
  - `[DiskType <String>]`: Disk type to set after restore. Ex: Standard_LRS.
  - `[Name <String>]`: Azure VM name to be set after restore. Defaults to source VM name.
  - `[Nics <List<IAzureDestinationInfoNic>>]`: Azure VM network interface list
    - `[NetworkId <String>]`: Azure network ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}.
    - `[PrivateIPAddress <String>]`: Azure private IP address.
    - `[PublicIPAddress <String>]`: Azure publice IP address.
    - `[PublicIPAddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
    - `[SubnetId <String>]`: Azure subnet ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}/subnets/{Subnet Name}.
  - `[Region <String>]`: Azure region name. Ex: For azure region (West US 3) the region value will be westus3. For reference: learn.microsoft.com/en-us/rest/api/resources/subscriptions/list-locations
  - `[ResourceGroup <String>]`: Azure Resource Group Name. Defaults to source VM resource group name.
  - `[RestoreAsManagedVM <Boolean?>]`: Boolean to specify if VM need to be restored as managed VM. Defaults to true.
  - `[RestoreSourceVMTags <Boolean?>]`: Restore source VM tags.
  - `[SecurityGroupId <String>]`: Azure security group to be set for the VM. Defaults to source configuration.
  - `[SourceVMGuid <String>]`: Azure VM ID
  - `[VMSize <String>]`: VM size to be after restore. Defaults to --Auto Select--. Ex: Standard_A1.
  - `[VMTags <List<INameValue>>]`: Azure VM tag list
    - `[Name <String>]`: 
    - `[Value <String>]`: 

`BODY <IVMGroupRestoreRequest>`: VM or VMGroup restore request body
  - `InPlaceRestore <Boolean>`: Flag to set if restore is in-place or out-of-place. Defaults to false.
  - `[AccessNodeGroupId <Int64?>]`: 
  - `[AccessNodeGroupName <String>]`: 
  - `[AccessNodeId <Int64?>]`: 
  - `[AccessNodeName <String>]`: 
  - `[AwAwsInstanceInfoList <List<IAwsInstanceInfo>>]`: List of AWS instances that are to be restored
    - `[EncryptionKeyDiskEncryptionSetId <String>]`: 
    - `[EncryptionKeyDiskEncryptionSetTypeId <String>]`: 
    - `[EncryptionKeyIsEncrypted <Boolean?>]`: 
    - `[InstanceId <String>]`: AWS instance ID
    - `[InstanceName <String>]`: AWS instance name to be set after restore. Defaults to source instance name.
    - `[InstanceSize <String>]`: Instance size to be after restore. Defaults to source instance size
    - `[KeyPairs <List<IVMKeyPairInfo>>]`: List of key pairs
      - `[KeyId <String>]`: 
      - `[KeyName <String>]`: 
    - `[Nics <List<IAwsNetworkInterfaceInfo>>]`: AWS instance network interface list
      - `[EniId <String>]`: 
      - `[NetworkName <String>]`: 
      - `[SubnetId <String>]`: 
      - `[VpcId <String>]`: 
    - `[Region <String>]`: 
    - `[RestoreSourceNetworkConfig <Boolean?>]`: If set to true, we will use the source network configuration during restore
    - `[RestoreSourceVMTags <Boolean?>]`: Restore source VM tags.
    - `[SecurityGroups <List<IVMSecurityGroupInfo>>]`: List of AWS security groups to be set for the instance.
      - `[GroupId <String>]`: 
      - `[GroupName <String>]`: 
    - `[VMTags <List<INameValue>>]`: AWS VM tag list
      - `[Name <String>]`: 
      - `[Value <String>]`: 
    - `[VolumeType <String>]`: 
    - `[VsaEncryptionOptionEncryptionKey <String>]`: 
    - `[Zone <String>]`: AWS Availability zone. Defaults to source instance availability zone.
  - `[AwNamePrefix <String>]`: Adds prefix for instance display name
  - `[AwNameSuffix <String>]`: Adds suffix for instance display name
  - `[AzureNamePrefix <String>]`: Adds prefix for VM display name
  - `[AzureNameSuffix <String>]`: Adds suffix for VM display name
  - `[AzureVMInfoList <List<IAzureVMInfo>>]`: List of Azure VMs that are to be restored
    - `StorageAccount <String>`: Azure staging storage account. Defaults to source storage account.
    - `[AvailabilityZone <String>]`: Azure availablity zones. Defaults to Auto. Values can be as follows: 'Auto' (Select from the source VM config), 'None' (Will not restore to any zone), '{Zone Number}' (Availablity zone number the restored VM should be in. Ex: 2).
    - `[CreatePublicIP <Boolean?>]`: Boolean to specify if VM should have publice IP. Defaults to false.
    - `[DiskEncryptionSetId <String>]`: Azure Disk Encryption Set ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Compute/diskEncryptionSets/{Disk Encryption Set}.
    - `[DiskEncryptionSetTypeId <String>]`: Azure Disk Encryption Type. Values can be: 'EncryptionAtRestWithCustomerKey' or 'EncryptionAtRestWithPlatformAndCustomerKeys' or 'EncryptionAtRestWithPlatformAndCustomerKeys'. For reference: learn.microsoft.com/en-us/dotnet/api/microsoft.azure.management.compute.models.encryptiontype?view=azure-dotnet&viewFallbackFrom=azure-dotnet
    - `[DiskType <String>]`: Disk type to set after restore. Ex: Standard_LRS.
    - `[Name <String>]`: Azure VM name to be set after restore. Defaults to source VM name.
    - `[Nics <List<IAzureDestinationInfoNic>>]`: Azure VM network interface list
      - `[NetworkId <String>]`: Azure network ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}.
      - `[PrivateIPAddress <String>]`: Azure private IP address.
      - `[PublicIPAddress <String>]`: Azure publice IP address.
      - `[PublicIPAddressId <String>]`: Azure public IP address ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/publicIPAddresses/{Public IP Address Name}.
      - `[SubnetId <String>]`: Azure subnet ID. Format: /subscriptions/{Subscription ID}/resourceGroups/{Resource Group Name}/providers/Microsoft.Network/virtualNetworks/{Network Name}/subnets/{Subnet Name}.
    - `[Region <String>]`: Azure region name. Ex: For azure region (West US 3) the region value will be westus3. For reference: learn.microsoft.com/en-us/rest/api/resources/subscriptions/list-locations
    - `[ResourceGroup <String>]`: Azure Resource Group Name. Defaults to source VM resource group name.
    - `[RestoreAsManagedVM <Boolean?>]`: Boolean to specify if VM need to be restored as managed VM. Defaults to true.
    - `[RestoreSourceVMTags <Boolean?>]`: Restore source VM tags.
    - `[SecurityGroupId <String>]`: Azure security group to be set for the VM. Defaults to source configuration.
    - `[SourceVMGuid <String>]`: Azure VM ID
    - `[VMSize <String>]`: VM size to be after restore. Defaults to --Auto Select--. Ex: Standard_A1.
    - `[VMTags <List<INameValue>>]`: Azure VM tag list
  - `[BackupSource <Int64?>]`: Backup source information from where you want to restore. 0 (Automatic), 1 (Snap Copy), 2 (Primary), 3 to N (Aux Copy)
  - `[DestinationId <Int64?>]`: 
  - `[DestinationName <String>]`: 
  - `[GoogleCloudNamePrefix <String>]`: Adds prefix for VM display name
  - `[GoogleCloudNameSuffix <String>]`: Adds suffix for VM display name
  - `[GoogleCloudVMInfoList <List<IGoogleCloudVMInfo>>]`: List of Google Cloud VMs that are to be restored
    - `[CreatePublicIP <Boolean?>]`: Flag to create external IP after restore. Defaults to false.
    - `[CustomMetadata <List<INameValue>>]`: GCP custom metadata key-value pairs
    - `[EncryptionKey <String>]`: Customer Managed Encryption Key
    - `[InstanceId <String>]`: Instance ID of the google cloud virtual machine to be restored. Ex: 123456789123456789.
    - `[KeyProtectionLevel <String>]`: Protection level of encryption key
    - `[MachineType <String>]`: GCP Machine Family. Ex: c2d-highmem-8. Defaults to --Auto Select--. For Reference: cloud.google.com/compute/docs/machine-resource
    - `[Name <String>]`: The new name of the instance after restore. Defaults to source name after restore.
    - `[NetworkInterfaces <List<IGoogleCloudNetworkInterfaceInfo>>]`: Google Cloud VM network interfaces list
      - `[ExternalIP <String>]`: External IP Address. Defaults to null and is not set after restore.
      - `[InternalIP <String>]`: Internal IP address. Defaults to the source internal IP after restore.
      - `[Name <String>]`: Name of the network interface card. Ex: nic0.
      - `[NetworkId <String>]`: Network self-link. Format: googleapis.com/compute/v1/projects/<Project ID>/global/networks/{Network Name}. Defaults to source network self-link.
      - `[NetworkName <String>]`: Network Name. Ex: default. Defaults to source network name.
      - `[SubnetId <String>]`: Subnet self-link. Format: googleapis.com/compute/v1/projects/<Project ID>/regions/<Region>/subnetworks/{Subnet Name}. Defaults to source subnet self-link.
    - `[NodeAffinities <List<INameValue>>]`: Node affinity for the virtual machine to provision virtual machine as sole tenanat VM. Defaults to no node affinity. Format: '[{name: compute.googleapis.com/node-group-name, value: {Node Group Name} }, {name: compute.googleapis.com/node-name, value: {Node Name} }]'
    - `[ProjectId <String>]`: GCP Project ID
    - `[Region <String>]`: GCP Region. Ex: asia-east1. Defaults to source instance region after restore. For reference: cloud.google.com/compute/docs/regions-zones#available
    - `[ServiceAccountEmail <String>]`: 
    - `[ServiceAccountId <String>]`: 
    - `[ServiceAccountName <String>]`: 
    - `[Zone <String>]`: GCP zones. Ex: asia-east1-a. Defaults to source instance zone after restore. For reference: cloud.google.com/compute/docs/regions-zones#available
  - `[NotifyOnJobCompletion <Boolean?>]`: Enable email notificaiton for job status. Defaults to false.
  - `[OverwriteVM <Boolean?>]`: Unconditionally overwrite VM during restore. Defaults to false.
  - `[PowerOnVMAfterRestore <Boolean?>]`: Turn ON virtual machine after restore. Defaults to false.
  - `[RestoreFlavour <String>]`: Type of restore for virtual machine
  - `[ReuseVMClient <Boolean?>]`: Reuse the existing VM client instance of creating new one after restore. Defaults to true for inplace restore and false for out of place restore.
  - `[TransportMode <String>]`: Backup transport modes enum

`GOOGLECLOUDVMINFOLIST <IGoogleCloudVMInfo[]>`: List of Google Cloud VMs that are to be restored
  - `[CreatePublicIP <Boolean?>]`: Flag to create external IP after restore. Defaults to false.
  - `[CustomMetadata <List<INameValue>>]`: GCP custom metadata key-value pairs
    - `[Name <String>]`: 
    - `[Value <String>]`: 
  - `[EncryptionKey <String>]`: Customer Managed Encryption Key
  - `[InstanceId <String>]`: Instance ID of the google cloud virtual machine to be restored. Ex: 123456789123456789.
  - `[KeyProtectionLevel <String>]`: Protection level of encryption key
  - `[MachineType <String>]`: GCP Machine Family. Ex: c2d-highmem-8. Defaults to --Auto Select--. For Reference: cloud.google.com/compute/docs/machine-resource
  - `[Name <String>]`: The new name of the instance after restore. Defaults to source name after restore.
  - `[NetworkInterfaces <List<IGoogleCloudNetworkInterfaceInfo>>]`: Google Cloud VM network interfaces list
    - `[ExternalIP <String>]`: External IP Address. Defaults to null and is not set after restore.
    - `[InternalIP <String>]`: Internal IP address. Defaults to the source internal IP after restore.
    - `[Name <String>]`: Name of the network interface card. Ex: nic0.
    - `[NetworkId <String>]`: Network self-link. Format: googleapis.com/compute/v1/projects/<Project ID>/global/networks/{Network Name}. Defaults to source network self-link.
    - `[NetworkName <String>]`: Network Name. Ex: default. Defaults to source network name.
    - `[SubnetId <String>]`: Subnet self-link. Format: googleapis.com/compute/v1/projects/<Project ID>/regions/<Region>/subnetworks/{Subnet Name}. Defaults to source subnet self-link.
  - `[NodeAffinities <List<INameValue>>]`: Node affinity for the virtual machine to provision virtual machine as sole tenanat VM. Defaults to no node affinity. Format: '[{name: compute.googleapis.com/node-group-name, value: {Node Group Name} }, {name: compute.googleapis.com/node-name, value: {Node Name} }]'
  - `[ProjectId <String>]`: GCP Project ID
  - `[Region <String>]`: GCP Region. Ex: asia-east1. Defaults to source instance region after restore. For reference: cloud.google.com/compute/docs/regions-zones#available
  - `[ServiceAccountEmail <String>]`: 
  - `[ServiceAccountId <String>]`: 
  - `[ServiceAccountName <String>]`: 
  - `[Zone <String>]`: GCP zones. Ex: asia-east1-a. Defaults to source instance zone after restore. For reference: cloud.google.com/compute/docs/regions-zones#available

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

## RELATED LINKS

