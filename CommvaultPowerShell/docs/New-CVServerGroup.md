---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/new-cvservergroup
schema: 2.0.0
---

# New-CVServerGroup

## SYNOPSIS
Create Server group

## SYNTAX

```
New-CVServerGroup [-AutomaticAssociationConfirmRuleChange] [-ClientScopeType <String>] [-Description <String>]
 [-EntityInfoId <Int64>] [-EntityInfoName <String>] [-GlobalConfigInfoActionOnLocalEntity <String>]
 [-GlobalConfigInfoApplyOnAllCommCells] [-GlobalConfigInfoCommcells <IGlobalConfigCommcellInfo[]>]
 [-GlobalConfigInfoName <String>] [-GlobalConfigInfoScope <String>]
 [-GlobalConfigInfoScopeFilterQuery <String>] [-ManualAssociationAssociatedservers <IIdName[]>]
 [-Name <String>] [-RuleMatchRule <String>] [-RuleRules <IRuleContent[]>]
 [-ServerGroupRuleGroup <IServerRuleGroup[]>] [-ServerGroupRuleMatch <String>] [-ServerGroupType <String>]
 [-VirtualAssociationClientAssociation <IClientAssociationServerGroupContent[]>]
 [-VirtualAssociationVirtualInstance <String>] [-VirtualAssociationVirtualServers <IIdName[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create Server group

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

### -AutomaticAssociationConfirmRuleChange
Confirm that server group rule impacts server of a specific company smart client group only

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

### -ClientScopeType
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

### -Description
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

### -EntityInfoId
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

### -EntityInfoName
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

### -GlobalConfigInfoActionOnLocalEntity
Action that will be taken on the local entity that has the same name as the global entity that needs to be created

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

### -GlobalConfigInfoApplyOnAllCommCells
Decides whether the global configuration should be applied to all the Service commcells, including the newly created ones

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

### -GlobalConfigInfoCommcells
List of Service CommCells where the global configuration should be applied

```yaml
Type: Commvault.Powershell.Models.IGlobalConfigCommcellInfo[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalConfigInfoName
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

### -GlobalConfigInfoScope
The entity level at which the config has to be applied.

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

### -GlobalConfigInfoScopeFilterQuery
CommCellEntityCache filter query string using for filtering the scope

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

### -ManualAssociationAssociatedservers
List of associated servers

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

### -Name
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

### -RuleMatchRule
Enum which specifies the whether to match all rules or any of the rules

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

### -RuleRules
.

```yaml
Type: Commvault.Powershell.Models.IRuleContent[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerGroupRuleGroup
List of rule groups

```yaml
Type: Commvault.Powershell.Models.IServerRuleGroup[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerGroupRuleMatch
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

### -ServerGroupType
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

### -VirtualAssociationClientAssociation
.

```yaml
Type: Commvault.Powershell.Models.IClientAssociationServerGroupContent[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VirtualAssociationVirtualInstance
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

### -VirtualAssociationVirtualServers
.

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

## OUTPUTS

### Commvault.Powershell.Models.ICreateServerGroupResp

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`GLOBALCONFIGINFOCOMMCELLS <IGlobalConfigCommcellInfo[]>`: List of Service CommCells where the global configuration should be applied
  - `[Guid <String>]`: 
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`MANUALASSOCIATIONASSOCIATEDSERVERS <IIdName[]>`: List of associated servers
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`RULERULES <IRuleContent[]>`: .
  - `[Condition <String>]`: Operation type for VM rules/filters
  - `[DisplayName <String>]`: The display name of the entity to be added
  - `[Guid <String>]`: GUID of the entity to be added as content
  - `[Name <String>]`: name of the VM to be added as content
  - `[Type <String>]`: 
  - `[Value <String>]`: value for the few type of VM Content like powerstate

`SERVERGROUPRULEGROUP <IServerRuleGroup[]>`: List of rule groups
  - `[Match <String>]`: 
  - `[Rules <List<IServerRule>>]`: List of rules
    - `[MatchCondition <String>]`: 
    - `[RuleName <String>]`: 
    - `[RuleSecValue <String>]`: Secondary value used for BETWEEN and NOT_BETWEEN matchCondition. For ruleName which have enum values (like OS_TYPE), this is used to store displayName.
    - `[RuleValue <String>]`: Primary value for the rule

`VIRTUALASSOCIATIONCLIENTASSOCIATION <IClientAssociationServerGroupContent[]>`: .
  - `[AssociatedClientId <Int64?>]`: 
  - `[AssociationRule <List<IVirtualMachinecontent>>]`: 
    - `[ExistingCredentialId <Int64?>]`: 
    - `[ExistingCredentialName <String>]`: 
    - `[GuestCredentialAssocId <Int64?>]`: Credential association ID given to link entity with credential id.
    - `[GuestCredentialsPassword <String>]`: 
    - `[GuestCredentialsUserName <String>]`: 
    - `[Guid <String>]`: GUID of the VM to be added as content
    - `[Name <String>]`: name of the VM to be added as content
    - `[Type <String>]`: 

`VIRTUALASSOCIATIONVIRTUALSERVERS <IIdName[]>`: .
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

