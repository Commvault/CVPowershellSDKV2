---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/copy-cvsoftware
schema: 2.0.0
---

# Copy-CVSoftware

## SYNOPSIS
Download or Copy Software

## SYNTAX

### CopyExpanded (Default)
```
Copy-CVSoftware [-CopyConfigurationDownloadPath <String>] [-CopyConfigurationPassword <String>]
 [-CopyConfigurationUsername <String>] [-DownloadConfigurationFeatureRelease <String>]
 [-DownloadConfigurationLatestFixesForCurrentRelease] [-DownloadConfigurationUnixDownloadOptions <String[]>]
 [-DownloadConfigurationUpgradeToLatestRelease] [-DownloadConfigurationWindowsDownloadOptions <String[]>]
 [-NotifyWhenJobCompletes] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Copy
```
Copy-CVSoftware -Body <IDownloadOrCopySoftware> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Download or Copy Software

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
Request body for download or copy software

```yaml
Type: Commvault.Powershell.Models.IDownloadOrCopySoftware
Parameter Sets: Copy
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CopyConfigurationDownloadPath
Path from where the software has to be downloaded.

```yaml
Type: System.String
Parameter Sets: CopyExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CopyConfigurationPassword
Corresponding password of the user

```yaml
Type: System.String
Parameter Sets: CopyExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CopyConfigurationUsername
If impersonation a user the, give the username of the user.

```yaml
Type: System.String
Parameter Sets: CopyExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DownloadConfigurationFeatureRelease
Which specific feature release to download.

```yaml
Type: System.String
Parameter Sets: CopyExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DownloadConfigurationLatestFixesForCurrentRelease
Boolean which determines whether to download latest fixews for current release.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CopyExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DownloadConfigurationUnixDownloadOptions
gives list of all the target unix and MAC operating systems to download software for.

```yaml
Type: System.String[]
Parameter Sets: CopyExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DownloadConfigurationUpgradeToLatestRelease
Boolean which determines whether to upgrade to latest release.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CopyExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DownloadConfigurationWindowsDownloadOptions
gives list of all the target windows operating systems to download software for.

```yaml
Type: System.String[]
Parameter Sets: CopyExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotifyWhenJobCompletes
Boolean which determines whether to notify when software is downloaded or copied.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CopyExpanded
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

### Commvault.Powershell.Models.IDownloadOrCopySoftware

## OUTPUTS

### Commvault.Powershell.Models.IJobIdResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IDownloadOrCopySoftware>`: Request body for download or copy software
  - `[CopyConfigurationDownloadPath <String>]`: Path from where the software has to be downloaded.
  - `[CopyConfigurationPassword <String>]`: Corresponding password of the user
  - `[CopyConfigurationUsername <String>]`: If impersonation a user the, give the username of the user.
  - `[DownloadConfigurationFeatureRelease <String>]`: Which specific feature release to download.
  - `[DownloadConfigurationLatestFixesForCurrentRelease <Boolean?>]`: Boolean which determines whether to download latest fixews for current release.
  - `[DownloadConfigurationUnixDownloadOptions <List<String>>]`: gives list of all the target unix and MAC operating systems to download software for.
  - `[DownloadConfigurationUpgradeToLatestRelease <Boolean?>]`: Boolean which determines whether to upgrade to latest release.
  - `[DownloadConfigurationWindowsDownloadOptions <List<String>>]`: gives list of all the target windows operating systems to download software for.
  - `[NotifyWhenJobCompletes <Boolean?>]`: Boolean which determines whether to notify when software is downloaded or copied.

## RELATED LINKS

