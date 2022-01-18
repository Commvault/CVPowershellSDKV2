---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/update-globalexception
schema: 2.0.0
---

# Update-GlobalException

## SYNOPSIS
Add/Edit/Delete global execptions

## SYNTAX

### UpdateExpanded (Default)
```
Update-GlobalException [-UnixGlobalExceptionExceptions <String[]>]
 [-UnixGlobalExceptionOperationType <String>] [-UseGlobalExceptionsOnAllSubclients]
 [-WindowGlobalExceptionExceptions <String[]>] [-WindowGlobalExceptionOperationType <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-GlobalException -Body <ISetGlobalExceptions> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add/Edit/Delete global execptions

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
Used to set global exceptions
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ISetGlobalExceptions
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -UnixGlobalExceptionExceptions
Array of exceptions which will be operated upon based on the operation type

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnixGlobalExceptionOperationType
The operations on global exceptions provided would be executed based on the operation type provided

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UseGlobalExceptionsOnAllSubclients
Boolean value which updates the property useGlobalExceptionsOnAllSubclients

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

### -WindowGlobalExceptionExceptions
Array of exceptions which will be operated upon based on the operation type

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowGlobalExceptionOperationType
The operations on global exceptions provided would be executed based on the operation type provided

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
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

### Commvault.Powershell.Models.ISetGlobalExceptions

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <ISetGlobalExceptions>: Used to set global exceptions
  - `[UnixGlobalExceptionExceptions <String[]>]`: Array of exceptions which will be operated upon based on the operation type
  - `[UnixGlobalExceptionOperationType <String>]`: The operations on global exceptions provided would be executed based on the operation type provided
  - `[UseGlobalExceptionsOnAllSubclients <Boolean?>]`: Boolean value which updates the property useGlobalExceptionsOnAllSubclients
  - `[WindowGlobalExceptionExceptions <String[]>]`: Array of exceptions which will be operated upon based on the operation type
  - `[WindowGlobalExceptionOperationType <String>]`: The operations on global exceptions provided would be executed based on the operation type provided

## RELATED LINKS

