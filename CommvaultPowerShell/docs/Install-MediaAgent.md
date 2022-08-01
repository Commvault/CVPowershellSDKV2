---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/install-mediaagent
schema: 2.0.0
---

# Install-MediaAgent

## SYNOPSIS
To install MediaAgent package on a server

## SYNTAX

### InstallExpanded (Default)
```
Install-MediaAgent -HostNames <String[]> -Username <String> [-InstallLocation <String>] [-OSType <String>]
 [-Password <String>] [-RebootIfRequired] [-SshKeyFilePassphrase <String>] [-SshKeyPath <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Install
```
Install-MediaAgent -Body <IInstallMediaAgent> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
To install MediaAgent package on a server

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
.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IInstallMediaAgent
Parameter Sets: Install
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -HostNames
Host names where MediaAgent package is required to be installed

```yaml
Type: System.String[]
Parameter Sets: InstallExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstallLocation
Holds install path according to the chosen OSType

```yaml
Type: System.String
Parameter Sets: InstallExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OSType
.

```yaml
Type: System.String
Parameter Sets: InstallExpanded
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

### -Password
password should be in base64 encoded string.
password is optional only if SSHKeyFilePassphrase is specified

```yaml
Type: System.String
Parameter Sets: InstallExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RebootIfRequired
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: InstallExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SshKeyFilePassphrase
Applicable only for Unix OSType and should be in base64 encoded string

```yaml
Type: System.String
Parameter Sets: InstallExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SshKeyPath
Applicable only for Unix OSType.
Path provided should be valid on the CommServ Client

```yaml
Type: System.String
Parameter Sets: InstallExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Username
Username to access hostnames

```yaml
Type: System.String
Parameter Sets: InstallExpanded
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

### Commvault.Powershell.Models.IInstallMediaAgent

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IInstallMediaAgent>: .
  - `HostNames <String[]>`: Host names where MediaAgent package is required to be installed
  - `Username <String>`: Username to access hostnames
  - `[InstallLocation <String>]`: Holds install path according to the chosen OSType
  - `[OSType <String>]`: 
  - `[Password <String>]`: password should be in base64 encoded string. password is optional only if SSHKeyFilePassphrase is specified
  - `[RebootIfRequired <Boolean?>]`: 
  - `[SshKeyFilePassphrase <String>]`: Applicable only for Unix OSType and should be in base64 encoded string
  - `[SshKeyPath <String>]`: Applicable only for Unix OSType. Path provided should be valid on the CommServ Client

## RELATED LINKS

