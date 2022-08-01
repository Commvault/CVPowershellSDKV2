---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-emailserver
schema: 2.0.0
---

# Set-EmailServer

## SYNOPSIS
Configure SMTP server settings.

## SYNTAX

### UpdateExpanded (Default)
```
Set-EmailServer [-EncryptionAlgorithm <String>] [-Password <String>] [-SenderEmail <String>]
 [-SenderName <String>] [-SmtpPort <Int64>] [-SmtpServerName <String>] [-UseAuthentication]
 [-Username <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Configure
```
Set-EmailServer -Body <IConfigureSmtpServerReq> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ConfigureExpanded
```
Set-EmailServer -SenderEmail <String> -SenderName <String> -SmtpPort <Int64> -SmtpServerName <String>
 [-EncryptionAlgorithm <String>] [-Password <String>] [-Username <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Configure SMTP server settings.

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
ConfigureSMTPServerReq
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IConfigureSmtpServerReq
Parameter Sets: Configure
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EncryptionAlgorithm
.

```yaml
Type: System.String
Parameter Sets: ConfigureExpanded, UpdateExpanded
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
Password must be in base64 encoded format.
Similar to username, if authentication on the mail server is required, this option is required.

```yaml
Type: System.String
Parameter Sets: ConfigureExpanded, UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SenderEmail
The sender email address used for emails sent from the software.

```yaml
Type: System.String
Parameter Sets: ConfigureExpanded, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SenderName
The sender name used for emails sent from the software.

```yaml
Type: System.String
Parameter Sets: ConfigureExpanded, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SmtpPort
The port number that connects to the mail server.

```yaml
Type: System.Int64
Parameter Sets: ConfigureExpanded, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SmtpServerName
The name of the mail server that sends alerts, scheduled reports, log files, and additional information.

```yaml
Type: System.String
Parameter Sets: ConfigureExpanded, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UseAuthentication
The option to use authentication on the mail server.
This is typically used in external or internet mail server configurations.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Username
This option is used when authentication on the mail server is required

```yaml
Type: System.String
Parameter Sets: ConfigureExpanded, UpdateExpanded
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

### Commvault.Powershell.Models.IConfigureSmtpServerReq

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IConfigureSmtpServerReq>: ConfigureSMTPServerReq
  - `SenderEmail <String>`: The sender email address used for emails sent from the software.
  - `SenderName <String>`: The sender name used for emails sent from the software.
  - `SmtpPort <Int64>`: The port number that connects to the mail server.
  - `SmtpServerName <String>`: The name of the mail server that sends alerts, scheduled reports, log files, and additional information.
  - `[EncryptionAlgorithm <String>]`: 
  - `[Password <String>]`: Password must be in base64 encoded format. Similar to username, if authentication on the mail server is required, this option is required.
  - `[Username <String>]`: This option is used when authentication on the mail server is required

## RELATED LINKS

