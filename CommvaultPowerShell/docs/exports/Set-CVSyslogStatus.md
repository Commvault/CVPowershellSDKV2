---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-cvsyslogstatus
schema: 2.0.0
---

# Set-CVSyslogStatus

## SYNOPSIS
This endpoint configures a syslog server.

## SYNTAX

### ConfigureExpanded (Default)
```
Set-CVSyslogStatus -Hostname <String> [-CertificateAuthorityContent <String>]
 [-CertificateAuthorityName <String>] [-ForwardToSyslogAlerts] [-ForwardToSyslogAudit]
 [-ForwardToSyslogEvents] [-Port <Int64>] [-SecureMessaging] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Configure
```
Set-CVSyslogStatus -Body <ISyslogConfigure> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint configures a syslog server.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -Body
This operation configures a syslog server.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ISyslogConfigure
Parameter Sets: Configure
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CertificateAuthorityContent
Content of the uploaded certificate authority file.
It should be base64 encoded.
Accepted fileTypes are key,crt,pem.

```yaml
Type: System.String
Parameter Sets: ConfigureExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CertificateAuthorityName
File name of the uploaded certificate authority file

```yaml
Type: System.String
Parameter Sets: ConfigureExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ForwardToSyslogAlerts
Forward the system log for alerts to the server.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ConfigureExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ForwardToSyslogAudit
Forward the system log for audit trails to the server.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ConfigureExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ForwardToSyslogEvents
Forward the system log for events to the server.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ConfigureExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Hostname
The hostname or the IP address of the syslog server.

```yaml
Type: System.String
Parameter Sets: ConfigureExpanded
Aliases:

Required: True
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

### -Port
The port on which the syslog server accepts the logs.

```yaml
Type: System.Int64
Parameter Sets: ConfigureExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecureMessaging
When false UDP port will be used, when true TLS encryption will be used to connect to Syslog Server.
To upload Certificate Authority file it should be enabled.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ConfigureExpanded
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

### Commvault.Powershell.Models.ISyslogConfigure

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <ISyslogConfigure>`: This operation configures a syslog server.
  - `Hostname <String>`: The hostname or the IP address of the syslog server.
  - `[CertificateAuthorityContent <String>]`: Content of the uploaded certificate authority file. It should be base64 encoded. Accepted fileTypes are key,crt,pem.
  - `[CertificateAuthorityName <String>]`: File name of the uploaded certificate authority file
  - `[ForwardToSyslogAlerts <Boolean?>]`: Forward the system log for alerts to the server.
  - `[ForwardToSyslogAudit <Boolean?>]`: Forward the system log for audit trails to the server.
  - `[ForwardToSyslogEvents <Boolean?>]`: Forward the system log for events to the server.
  - `[Port <Int64?>]`: The port on which the syslog server accepts the logs.
  - `[SecureMessaging <Boolean?>]`: When false UDP port will be used, when true TLS encryption will be used to connect to Syslog Server. To upload Certificate Authority file it should be enabled.

## RELATED LINKS

