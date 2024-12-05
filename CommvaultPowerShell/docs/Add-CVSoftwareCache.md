---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/add-cvsoftwarecache
schema: 2.0.0
---

# Add-CVSoftwareCache

## SYNOPSIS
Add a new software cache

## SYNTAX

### AddExpanded (Default)
```
Add-CVSoftwareCache [-Associations <IServerOrServerGroupAssociation[]>]
 [-CacheContents <ISoftwareCacheContent[]>] [-CacheDirectory <String>] [-CacheId <Int64>]
 [-CacheName <String>] [-Configurable] [-Enabled] [-Status <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Add
```
Add-CVSoftwareCache -Body <ISoftwareCacheDetail> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add a new software cache

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

### -Associations
List of servers and server groups.

```yaml
Type: Commvault.Powershell.Models.IServerOrServerGroupAssociation[]
Parameter Sets: AddExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Details of software cache server.

```yaml
Type: Commvault.Powershell.Models.ISoftwareCacheDetail
Parameter Sets: Add
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CacheContents
List of cache content details of software cache.

```yaml
Type: Commvault.Powershell.Models.ISoftwareCacheContent[]
Parameter Sets: AddExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CacheDirectory
The software cache directory path where the media will be located

```yaml
Type: System.String
Parameter Sets: AddExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CacheId
.

```yaml
Type: System.Int64
Parameter Sets: AddExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CacheName
.

```yaml
Type: System.String
Parameter Sets: AddExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Configurable
Whether the software cache is configurable

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: AddExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Enabled
Whether the software cache is enabled or not

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: AddExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
The status of the software cache for server.
Either In Sync or Out of Sync with CommServe cache

```yaml
Type: System.String
Parameter Sets: AddExpanded
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

### Commvault.Powershell.Models.ISoftwareCacheDetail

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ASSOCIATIONS <IServerOrServerGroupAssociation[]>`: List of servers and server groups.
  - `[Id <Int64?>]`: Id of server or server group
  - `[Name <String>]`: Name of server or server group
  - `[Type <String>]`: ServerOrServerGroupTypes

`BODY <ISoftwareCacheDetail>`: Details of software cache server.
  - `[Associations <List<IServerOrServerGroupAssociation>>]`: List of servers and server groups.
    - `[Id <Int64?>]`: Id of server or server group
    - `[Name <String>]`: Name of server or server group
    - `[Type <String>]`: ServerOrServerGroupTypes
  - `[CacheContents <List<ISoftwareCacheContent>>]`: List of cache content details of software cache.
    - `[AdditionalUpdates <String>]`: List of additional updates available in software cache
    - `[OSName <String>]`: OS Name of the media available in software cache
    - `[PackagesInCache <String>]`: List of packages available in the software cache
    - `[Version <String>]`: Version of the media available in software cache
  - `[CacheDirectory <String>]`: The software cache directory path where the media will be located
  - `[CacheId <Int64?>]`: 
  - `[CacheName <String>]`: 
  - `[Configurable <Boolean?>]`: Whether the software cache is configurable
  - `[Enabled <Boolean?>]`: Whether the software cache is enabled or not
  - `[Status <String>]`: The status of the software cache for server. Either In Sync or Out of Sync with CommServe cache

`CACHECONTENTS <ISoftwareCacheContent[]>`: List of cache content details of software cache.
  - `[AdditionalUpdates <String>]`: List of additional updates available in software cache
  - `[OSName <String>]`: OS Name of the media available in software cache
  - `[PackagesInCache <String>]`: List of packages available in the software cache
  - `[Version <String>]`: Version of the media available in software cache

## RELATED LINKS

