---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/new-cvarray
schema: 2.0.0
---

# New-CVArray

## SYNOPSIS
Creating a Storage Array

## SYNTAX

```
New-CVArray [-AccessNodes <IArrayAccessNodes[]>] [-CredentialPassword <String>] [-CredentialUserName <String>]
 [-GeneralControlHost <String>] [-GeneralDescription <String>] [-GeneralName <String>]
 [-GeneralSnapVendor <String>] [-SavedCredentialId <Int64>] [-SavedCredentialName <String>]
 [-SnapConfigurations <IArrayConfigsBasic[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Creating a Storage Array

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

### -AccessNodes
MAs that can access the array

```yaml
Type: Commvault.Powershell.Models.IArrayAccessNodes[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CredentialPassword
Base 64 encoded Password to access the array

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

### -CredentialUserName
Username to access the array

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

### -GeneralControlHost
Host Name of the array

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

### -GeneralDescription
Description of the array

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

### -GeneralName
Name of the array

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

### -GeneralSnapVendor
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

### -SavedCredentialId
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

### -SavedCredentialName
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

### -SnapConfigurations
Configurations related to a snap engine

```yaml
Type: Commvault.Powershell.Models.IArrayConfigsBasic[]
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

### Commvault.Powershell.Models.IGenericResp

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACCESSNODES <IArrayAccessNodes[]>`: MAs that can access the array
  - `[DisplayName <String>]`: The display name of the corresponding Media Agent
  - `[Id <Int64?>]`: Id of the MediaAgent
  - `[Name <String>]`: Name of the MediaAgent
  - `[Pruning <Boolean?>]`: Enable/Disable pruning of snapshots on the selected Media Agent

`SNAPCONFIGURATIONS <IArrayConfigsBasic[]>`: Configurations related to a snap engine
  - `MasterConfigId <Int64>`: This is the masterConfigId, which is available for each vendor's configs
  - `Name <String>`: This is the name of the config which is displayed on the Command Center Console
  - `Type <Int64>`: Type of the config value. type can accept 7 values [1,2,8,10,12,13,14], 1: boolean, 2: integer, 8: text, 10: array[string] are common configs, the rest three are special keys, 12 is for password type key for NetApp E-Series and HPE Nimble, 13 is Private Key for GCP, 14 is a config to select type of Disk for GCP
  - `[Value <String>]`: Takes a single value for all types except 10 and for type 14 it holds the id of the selected value from values
  - `[Values <List<IIdName>>]`: Values to be entered. for type 10 and 14. For HPE 3PAR StoreServ, pass MA Id in name field to configure that MA as remote snap MA.
    - `[Id <Int64?>]`: 
    - `[Name <String>]`: 

## RELATED LINKS

