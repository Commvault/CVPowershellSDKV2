---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/new-cvvmgroup
schema: 2.0.0
---

# New-CVVMGroup

## SYNOPSIS
Create a VM Group

## SYNTAX

### CreateExpanded (Default)
```
New-CVVMGroup [-ContentOverwrite] [-ContentRuleGroups <IRuleGroupContent[]>]
 [-ContentVirtualMachines <IVirtualMachinecontent[]>] [-EnableIntellisnap] [-HypervisorId <Int64>]
 [-HypervisorName <String>] [-MeditechListenerIP <String>] [-MeditechListenerPort <Int64>]
 [-MeditechMbFtimeout <Int64>] [-MeditechSystemName <String>] [-Name <String>] [-PlanId <Int64>]
 [-PlanName <String>] [-StorageId <Int64>] [-StorageName <String>] [-UserAccountName <String>]
 [-UserAccountPassword <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-CVVMGroup -Body <ICreatevmGroupReq> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded1
```
New-CVVMGroup [-ContentOverwrite] [-ContentRuleGroups <IRuleGroupContent[]>]
 [-ContentVirtualMachines <IVirtualMachinecontent[]>] [-EnableIntellisnap] [-HypervisorId <Int64>]
 [-HypervisorName <String>] [-MeditechListenerIP <String>] [-MeditechListenerPort <Int64>]
 [-MeditechMbFtimeout <Int64>] [-MeditechSystemName <String>] [-Name <String>] [-PlanId <Int64>]
 [-PlanName <String>] [-StorageId <Int64>] [-StorageName <String>] [-UserAccountName <String>]
 [-UserAccountPassword <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a VM Group

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

### -Body
CreatevmGroupReq

```yaml
Type: Commvault.Powershell.Models.ICreatevmGroupReq
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentOverwrite
True if content in vmgroup has to be overwritten, by default it will append the content

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1
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
Parameter Sets: CreateExpanded, CreateExpanded1
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
Parameter Sets: CreateExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableIntellisnap
True if Intellisnap has to be enabled

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HypervisorId
.

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HypervisorName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MeditechListenerIP
Meditech Listener IP of FQDN name

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MeditechListenerPort
Meditech Listener Port

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MeditechMbFtimeout
MBF timeout (in seconds)

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded, CreateExpanded1
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
Parameter Sets: CreateExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
subclient name

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1
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
Parameter Sets: CreateExpanded, CreateExpanded1
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
Parameter Sets: CreateExpanded, CreateExpanded1
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
Parameter Sets: CreateExpanded, CreateExpanded1
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
Parameter Sets: CreateExpanded, CreateExpanded1
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
Parameter Sets: CreateExpanded, CreateExpanded1
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
Parameter Sets: CreateExpanded, CreateExpanded1
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

### Commvault.Powershell.Models.ICreatevmGroupReq

## OUTPUTS

### Commvault.Powershell.Models.ICreateVMGroupResp

### Commvault.Powershell.Models.IGenericResp

### Commvault.Powershell.Models.IGenericResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <ICreatevmGroupReq>`: CreatevmGroupReq
  - `Name <String>`: subclient name 
  - `[ContentOverwrite <Boolean?>]`: True if content in vmgroup has to be overwritten, by default it will append the content
  - `[ContentRuleGroups <List<IRuleGroupContent>>]`: 
    - `[MatchRule <String>]`: Enum which specifies the whether to match all rules or any of the rules
    - `[Rules <List<IRuleContent>>]`: 
      - `[Condition <String>]`: Operation type for VM rules/filters
      - `[DisplayName <String>]`: The display name of the entity to be added
      - `[Guid <String>]`: GUID of the entity to be added as content
      - `[Name <String>]`: name of the VM to be added as content
      - `[Type <String>]`: 
      - `[Value <String>]`: value for the few type of VM Content like powerstate
  - `[ContentVirtualMachines <List<IVirtualMachinecontent>>]`: 
    - `[ExistingCredentialId <Int64?>]`: 
    - `[ExistingCredentialName <String>]`: 
    - `[GuestCredentialAssocId <Int64?>]`: Credential association ID given to link entity with credential id.
    - `[GuestCredentialsPassword <String>]`: 
    - `[GuestCredentialsUserName <String>]`: 
    - `[Guid <String>]`: GUID of the VM to be added as content
    - `[Name <String>]`: name of the VM to be added as content
    - `[Type <String>]`: 
  - `[EnableIntellisnap <Boolean?>]`: True if Intellisnap has to be  enabled
  - `[HypervisorId <Int64?>]`: 
  - `[HypervisorName <String>]`: 
  - `[MeditechListenerIP <String>]`: Meditech Listener IP of FQDN name
  - `[MeditechListenerPort <Int64?>]`: Meditech Listener Port
  - `[MeditechMbFtimeout <Int64?>]`: MBF timeout (in seconds)
  - `[MeditechSystemName <String>]`: Meditech system name
  - `[PlanId <Int64?>]`: 
  - `[PlanName <String>]`: 
  - `[StorageId <Int64?>]`: 
  - `[StorageName <String>]`: 
  - `[UserAccountName <String>]`: username to access the network path
  - `[UserAccountPassword <String>]`: password to access the network path

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

## RELATED LINKS

