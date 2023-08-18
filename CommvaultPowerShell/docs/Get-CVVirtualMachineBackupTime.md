---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvvirtualmachinebackuptime
schema: 2.0.0
---

# Get-CVVirtualMachineBackupTime

## SYNOPSIS
Method to retrieve the last backup details of virtual machines in the CommCell.

## SYNTAX

### Default (Default)
```
Get-CVVirtualMachineBackupTime [-Name <String>] [<CommonParameters>]
```

### ByClient
```
Get-CVVirtualMachineBackupTime [-ClientName <String>] [-ClientObject <Object>] [-Name <String>]
 [<CommonParameters>]
```

## DESCRIPTION
Method to retrieve the last backup details of virtual machines in the CommCell.

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

### -ClientName
Filter output by active subclients of ClientName.

```yaml
Type: System.String
Parameter Sets: ByClient
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientObject
Filter output by active subclients of ClientObject.

```yaml
Type: System.Object
Parameter Sets: ByClient
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -Name
Filter output to virtual machine Name.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: VMName

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Object

## OUTPUTS

### Outputs [PSCustomObject] representing virtual machine last backup details.

## NOTES

ALIASES

### Get-CVLastBackup

## RELATED LINKS

