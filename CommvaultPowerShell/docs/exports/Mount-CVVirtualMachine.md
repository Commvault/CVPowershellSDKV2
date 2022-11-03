---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/mount-cvvirtualmachine
schema: 2.0.0
---

# Mount-CVVirtualMachine

## SYNOPSIS
Method to initiate live mount of specified virtual machine.

## SYNTAX

### ByName (Default)
```
Mount-CVVirtualMachine -ClientName <String> -Name <String> [-ExpirationInHours <String>] [-Force]
 [-JobId <String>] [-LiveMountVMName <String>] [-NetworkName <String>] [-PolicyName <String>]
 [-SubclientName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ById
```
Mount-CVVirtualMachine -Id <String> [-ExpirationInHours <String>] [-Force] [-JobId <String>]
 [-LiveMountVMName <String>] [-NetworkName <String>] [-PolicyName <String>] [-SubclientName <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ByObject
```
Mount-CVVirtualMachine -ClientObject <Object> [-ExpirationInHours <String>] [-Force] [-JobId <String>]
 [-LiveMountVMName <String>] [-NetworkName <String>] [-PolicyName <String>] [-SubclientName <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Method to initiate live mount of specified virtual machine from specified media.

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

### -ClientName
Source virtual machine associated ClientName.

```yaml
Type: System.String
Parameter Sets: ByName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientObject


```yaml
Type: System.Object
Parameter Sets: ByObject
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -ExpirationInHours
Specify ExpirationInHours for in-place live mount.

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

### -Force
Switch to Force override of default 'WhatIf' confirmation behavior.

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

### -Id
Specify Id representing source virtual machine GUID.

```yaml
Type: System.String
Parameter Sets: ById
Aliases: VMName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobId
Specify JobId to live mount from particular backup job.

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

### -LiveMountVMName
Specify LiveMountVMName to override default naming behavior.

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

### -Name
Source virtual machine Name.

```yaml
Type: System.String
Parameter Sets: ByName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkName
Specify NetworkName for live mount operation.

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

### -PolicyName
Specify PolicyName for live mount operation.

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

### -SubclientName
Specify SubclientName to override the default behaviour.

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

### System.Object

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

ALIASES

Mount-CVVM

## RELATED LINKS

