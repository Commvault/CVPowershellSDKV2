---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-cvmodifyentitysetting
schema: 2.0.0
---

# Invoke-CVModifyEntitySetting

## SYNOPSIS
Modify entity settings used to change default behaviour for linked entity like servers or server groups

## SYNTAX

### ModifyExpanded (Default)
```
Invoke-CVModifyEntitySetting [-EntitySettings <IModifyEntitySettingsItem[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Modify
```
Invoke-CVModifyEntitySetting -Body <IModifyEntitySettings> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Modify entity settings used to change default behaviour for linked entity like servers or server groups

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
ModifyEntitySettings
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IModifyEntitySettings
Parameter Sets: Modify
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EntitySettings
.
To construct, see NOTES section for ENTITYSETTINGS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IModifyEntitySettingsItem[]
Parameter Sets: ModifyExpanded
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

### Commvault.Powershell.Models.IModifyEntitySettings

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IModifyEntitySettings>: ModifyEntitySettings
  - `[EntitySettings <IModifyEntitySettingsItem[]>]`: 
    - `Category <String>`: Category of the setting to be modified. This cannot be modified but is required to identify the setting for which the new value is to be set.
    - `Name <String>`: Name of the setting to be modified. This cannot be modified but is required to identify the setting for which the new value is to be set.
    - `Type <String>`: Type of the setting to be modified. This cannot be modified but is required to identify the setting for which the new value is to be set.
    - `[Comment <String>]`: Comment to specify why this value was set for the specified setting
    - `[NewValue <String>]`: New value which will be set for the specified setting, there can be fixed acceptables values for some settings. To get more details about what are acceptable value for a setting, use GET GlobalSettings or GET EntitySettings.
    - `[Reset <Boolean?>]`: To reset the value of any already modified setting, set this to true to reset the value and regain default behaviour
    - `[EntityId <Int64?>]`: 
    - `[EntityType <String>]`: 

ENTITYSETTINGS <IModifyEntitySettingsItem[]>: .
  - `Category <String>`: Category of the setting to be modified. This cannot be modified but is required to identify the setting for which the new value is to be set.
  - `Name <String>`: Name of the setting to be modified. This cannot be modified but is required to identify the setting for which the new value is to be set.
  - `Type <String>`: Type of the setting to be modified. This cannot be modified but is required to identify the setting for which the new value is to be set.
  - `[Comment <String>]`: Comment to specify why this value was set for the specified setting
  - `[NewValue <String>]`: New value which will be set for the specified setting, there can be fixed acceptables values for some settings. To get more details about what are acceptable value for a setting, use GET GlobalSettings or GET EntitySettings.
  - `[Reset <Boolean?>]`: To reset the value of any already modified setting, set this to true to reset the value and regain default behaviour
  - `[EntityId <Int64?>]`: 
  - `[EntityType <String>]`: 

## RELATED LINKS

