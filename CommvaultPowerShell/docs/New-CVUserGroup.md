---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/new-cvusergroup
schema: 2.0.0
---

# New-CVUserGroup

## SYNOPSIS
Create a new user-group

## SYNTAX

```
New-CVUserGroup [-Description <String>] [-EnforceFsQuota] [-GlobalConfigInfoActionOnLocalEntity <String>]
 [-GlobalConfigInfoApplyOnAllCommCells] [-GlobalConfigInfoCommcells <IGlobalConfigCommcellInfo[]>]
 [-GlobalConfigInfoName <String>] [-GlobalConfigInfoScope <String>]
 [-GlobalConfigInfoScopeFilterQuery <String>] [-LocalUserGroups <IIdName[]>] [-Name <String>]
 [-QuotaLimitInGb <Int64>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new user-group

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

### -EnforceFsQuota
Used to determine if a backup data limit will be set for the user group being created

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

### -LocalUserGroups
This option is for AD user groups being created.
Local user groups can be added to the active directory user groups.

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
To create an active directory usergroup, the domain name should be mentioned along with the usergroup name (domainName\\usergroupName) and localUserGroup value must be given.

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

### -QuotaLimitInGb
if enforceFSQuota is set to true, the quota limit can be set in GBs

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

### Commvault.Powershell.Models.IIdNameGuid

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`GLOBALCONFIGINFOCOMMCELLS <IGlobalConfigCommcellInfo[]>`: List of Service CommCells where the global configuration should be applied
  - `[Guid <String>]`: 
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

`LOCALUSERGROUPS <IIdName[]>`: This option is for AD user groups being created. Local user groups can be added to the active directory user groups.
  - `[Id <Int64?>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

