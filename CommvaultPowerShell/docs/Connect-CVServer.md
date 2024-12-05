---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/connect-cvserver
schema: 2.0.0
---

# Connect-CVServer

## SYNOPSIS
Method to get CommServe authorization token.

## SYNTAX

### Default (Default)
```
Connect-CVServer -Server <String> [-Password <SecureString>] [-User <String>] [<CommonParameters>]
```

### PSCredential
```
Connect-CVServer -Server <String> [-Credential <PSCredential>] [<CommonParameters>]
```

## DESCRIPTION
Method to get CommServe authorization token.

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

### -Credential
Powershell credential object.
Used as alternative to -User \<user\> -Password \<password\>

```yaml
Type: System.Management.Automation.PSCredential
Parameter Sets: PSCredential
Aliases: PSCreds

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Password
Secure password for login.

```yaml
Type: System.Security.SecureString
Parameter Sets: Default
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Server
The CommServe URL to connect to.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -User
User name for login.

```yaml
Type: System.String
Parameter Sets: Default
Aliases:

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

### Outputs <String> indicating success or failure of login attempt.

## NOTES

## RELATED LINKS

