---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvnode
schema: 2.0.0
---

# Get-CVNode

## SYNOPSIS
API to deploy Access Node

## SYNTAX

### AccessExpanded (Default)
```
Get-CVNode -NetworkName <String> -UserCredentialsPassword <String> -UserCredentialsUserName <String>
 -VCenter <String> -VMLocationDataCenterName <String> -VMLocationDatastore <String> -VMLocationHost <String>
 -VMName <String> [-ClientGroup <String>] [-CommCellHostName <String>] [-CommCellName <String>]
 [-DeploymentType <Int64>] [-HardDiskType <Int64>] [-HostName <String>] [-Name <String>]
 [-NetworkDnsSearch <String>] [-NetworkGateway <String>] [-NetworkNameservers <String[]>]
 [-NetworkNetmask <String>] [-NetworkStaticIP <String>] [-NetworkUseDhcp <String>] [-OS <String>]
 [-VMLocationCluster <String>] [-VMLocationInventoryPath <String>] [-VMLocationResourcePool <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Access
```
Get-CVNode -Body <IAccessNodeDeployment> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
API to deploy Access Node

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

### -Body
AccessNodeDeployment
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IAccessNodeDeployment
Parameter Sets: Access
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClientGroup
.

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CommCellHostName
CommServer host name

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CommCellName
CommServer name

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentType
0: Access node deployment, 1: File recovery enabler for linux deployment

```yaml
Type: System.Int64
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HardDiskType
1: Thin Provision, 2: Thick provision lazy zeroed, 3: Thick provision eager zeroed

```yaml
Type: System.Int64
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostName
Host name for vm, if not provided it will be same as vmName

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Client name for vm, if not provided it will be same as vmName

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkDnsSearch
.

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkGateway
.

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkName
Destination network name

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkNameservers
.

```yaml
Type: System.String[]
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkNetmask
.

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkStaticIP
.

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkUseDhcp
If useDHCP is False then make sure to provide staticIP, netmask, gateway

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OS
.

```yaml
Type: System.String
Parameter Sets: AccessExpanded
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

### -UserCredentialsPassword
.

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserCredentialsUserName
.

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VCenter
vCenter server instance

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMLocationCluster
ESX-Cluster moref if cluster is selected for resource

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMLocationDataCenterName
.

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMLocationDatastore
If cluster is selected for storage then moref of datastore cluster else dataStoreName

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMLocationHost
If ESX-Host for resource the host moref or If ESX-Cluster then cluster moref and if resource pool is used for resource then first go for host moref then cluster moref

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMLocationInventoryPath
Folder path where you can locate vm, empty if Datacenter is selected for location.
Default is set to Datacenter

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMLocationResourcePool
Resource Pool moref if resource pool is selected for resource

```yaml
Type: System.String
Parameter Sets: AccessExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VMName
.

```yaml
Type: System.String
Parameter Sets: AccessExpanded
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

### Commvault.Powershell.Models.IAccessNodeDeployment

## OUTPUTS

### Commvault.Powershell.Models.ICreateTaskRespforBackup

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IAccessNodeDeployment>: AccessNodeDeployment
  - `NetworkName <String>`: Destination network name
  - `UserCredentialsPassword <String>`: 
  - `UserCredentialsUserName <String>`: 
  - `VCenter <String>`: vCenter server instance
  - `VMLocationDataCenterName <String>`: 
  - `VMLocationDatastore <String>`: If cluster is selected for storage then moref of datastore cluster else dataStoreName
  - `VMLocationHost <String>`: If ESX-Host for resource the host moref or If ESX-Cluster then cluster moref and if resource pool is used for resource then first go for host moref then cluster moref
  - `VMName <String>`: 
  - `[ClientGroup <String>]`: 
  - `[CommCellHostName <String>]`: CommServer host name
  - `[CommCellName <String>]`: CommServer name
  - `[DeploymentType <Int64?>]`: 0: Access node deployment, 1: File recovery enabler for linux deployment
  - `[HardDiskType <Int64?>]`: 1: Thin Provision, 2: Thick provision lazy zeroed, 3: Thick provision eager zeroed
  - `[HostName <String>]`: Host name for vm, if not provided it will be same as vmName
  - `[Name <String>]`: Client name for vm, if not provided it will be same as vmName
  - `[NetworkDnsSearch <String>]`: 
  - `[NetworkGateway <String>]`: 
  - `[NetworkNameservers <String[]>]`: 
  - `[NetworkNetmask <String>]`: 
  - `[NetworkStaticIP <String>]`: 
  - `[NetworkUseDhcp <String>]`: If useDHCP is False then make sure to provide staticIP, netmask, gateway
  - `[OS <String>]`: 
  - `[VMLocationCluster <String>]`: ESX-Cluster moref if cluster is selected for resource
  - `[VMLocationInventoryPath <String>]`: Folder path where you can locate vm, empty if Datacenter is selected for location. Default is set to Datacenter
  - `[VMLocationResourcePool <String>]`: Resource Pool moref if resource pool is selected for resource

## RELATED LINKS

