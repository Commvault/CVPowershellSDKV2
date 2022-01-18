---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-kubernetescluster
schema: 2.0.0
---

# New-Kubernetescluster

## SYNOPSIS
Create Kubernetes cluster

## SYNTAX

### Create (Default)
```
New-Kubernetescluster -Body <ICreateKubernetesCluster> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded
```
New-Kubernetescluster -AccessNodes <IIdName[]> -CredentialsName <String> -Endpointurl <String> -Name <String>
 [-CredentialsId <Int32>] [-Password <String>] [-SecretKey <String>] [-ServiceName <String>]
 [-SkipCredentialValidation] [-UserName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create Kubernetes cluster

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

### -AccessNodes
.
To construct, see NOTES section for ACCESSNODES properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IIdName[]
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICreateKubernetesCluster
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CredentialsId
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CredentialsName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Endpointurl
Endpoint url to connect

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the hypervisor group being created

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Password
Username to connect in case authentication mode is Username and password

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecretKey
SecretKey to connect in case authentication mode is service account

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceName
Service Name to connect in case authentication mode is service account

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkipCredentialValidation
if credential validation has to be skipped.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserName
Username to connect in case authentication mode is Username and password

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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

### Commvault.Powershell.Models.ICreateKubernetesCluster

## OUTPUTS

### Commvault.Powershell.Models.ICreateClusterResp

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCESSNODES <IIdName[]>: .
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

BODY <ICreateKubernetesCluster>: .
  - `AccessNodes <IIdName[]>`: 
    - `[Id <Int32?>]`: 
    - `[Name <String>]`: 
  - `Name <String>`: The name of the hypervisor group being created
  - `Endpointurl <String>`: Endpoint url to connect
  - `[CredentialsId <Int32?>]`: 
  - `[CredentialsName <String>]`: 
  - `[SkipCredentialValidation <Boolean?>]`: if credential validation has to be skipped.
  - `[Password <String>]`: Username to connect in case authentication mode is Username and password
  - `[SecretKey <String>]`: SecretKey to connect in case authentication mode is service account
  - `[ServiceName <String>]`: Service Name to connect in case authentication mode is service account
  - `[UserName <String>]`: Username to connect in case authentication mode is Username and password

## RELATED LINKS

