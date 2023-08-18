---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-setuplogin
schema: 2.0.0
---

# Invoke-SetupLogin

## SYNOPSIS
Add your QSDK Authenticated token to your Postman Environment by providing the details in the pre-request script.\n\nYou only need to run this one time because these values are stored in your Postman Environment.

## SYNTAX

### PostExpanded (Default)
```
Invoke-SetupLogin -Password <String> -Username <String> -WebServerUrl <String> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Post
```
Invoke-SetupLogin -BodyParameter <IEnvironmentSetupRequest> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add your QSDK Authenticated token to your Postman Environment by providing the details in the pre-request script.\n\nYou only need to run this one time because these values are stored in your Postman Environment.

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

### -BodyParameter
EnvironmentSetupRequest
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.IEnvironmentSetupRequest
Parameter Sets: Post
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Password
.

```yaml
Type: System.String
Parameter Sets: PostExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Username
.

```yaml
Type: System.String
Parameter Sets: PostExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WebServerUrl
.

```yaml
Type: System.String
Parameter Sets: PostExpanded
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

### Commvault.Powershell.Models.IEnvironmentSetupRequest

## OUTPUTS

### Commvault.Powershell.Models.ILoginResponse

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IEnvironmentSetupRequest>: EnvironmentSetupRequest
  - `Password <String>`: 
  - `Username <String>`: 
  - `WebServerUrl <String>`: 

## RELATED LINKS

