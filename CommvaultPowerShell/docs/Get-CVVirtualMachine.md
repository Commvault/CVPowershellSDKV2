---
external help file:
Module Name: CommvaultPowerShell
online version: https://learn.microsoft.com/powershell/module/commvaultpowershell/get-cvvirtualmachine
schema: 2.0.0
---

# Get-CVVirtualMachine

## SYNOPSIS
Get all virtual machines

## SYNTAX

### Default (Default)
```
Get-CVVirtualMachine [-First <UInt64>] [-Name <String>] [-Protected] [-Skip <UInt64>] [-UnProtected]
 [<CommonParameters>]
```

### ByClientId
```
Get-CVVirtualMachine [-ClientId <Int32>] [-First <UInt64>] [-Name <String>] [-Protected] [-Skip <UInt64>]
 [-UnProtected] [<CommonParameters>]
```

### ByClientName
```
Get-CVVirtualMachine [-ClientName <String>] [-First <UInt64>] [-Name <String>] [-Protected] [-Skip <UInt64>]
 [-UnProtected] [<CommonParameters>]
```

### ByClientObject
```
Get-CVVirtualMachine [-ClientObject <Object>] [-First <UInt64>] [-Name <String>] [-Protected] [-Skip <UInt64>]
 [-UnProtected] [<CommonParameters>]
```

### ById
```
Get-CVVirtualMachine [-First <UInt64>] [-Id <String>] [-Name <String>] [-Protected] [-Skip <UInt64>]
 [-UnProtected] [<CommonParameters>]
```

### Get
```
Get-CVVirtualMachine [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
Get all virtual machines

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

### -ClientId
Filter output by active subclients of ClientId.

```yaml
Type: System.Int32
Parameter Sets: ByClientId
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientName
Filter output by active subclients of ClientName.

```yaml
Type: System.String
Parameter Sets: ByClientName
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
Parameter Sets: ByClientObject
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -First
Gets only the first 'n' objects.

```yaml
Type: System.UInt64
Parameter Sets: ByClientId, ByClientName, ByClientObject, ById, Default
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Specify Id representing virtual machine GUID.

```yaml
Type: System.String
Parameter Sets: ById
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Filter output to virtual machine Name.

```yaml
Type: System.String
Parameter Sets: ByClientId, ByClientName, ByClientObject, ById, Default
Aliases: VMName

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
Parameter Sets: Get
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Protected
Filter output by Protected virtual machines.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ByClientId, ByClientName, ByClientObject, ById, Default
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Ignores the first 'n' objects and then gets the remaining objects.

```yaml
Type: System.UInt64
Parameter Sets: ByClientId, ByClientName, ByClientObject, ById, Default
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnProtected
Filter output by UnProtected virtual machines.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ByClientId, ByClientName, ByClientObject, ById, Default
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

### System.Object

## OUTPUTS

### Commvault.Powershell.Models.IVirtualMachineListResp

## NOTES

ALIASES

Perform-CVVMBrowse

## RELATED LINKS

