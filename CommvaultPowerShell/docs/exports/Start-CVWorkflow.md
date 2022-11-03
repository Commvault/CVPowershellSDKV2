---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/start-cvworkflow
schema: 2.0.0
---

# Start-CVWorkflow

## SYNOPSIS
Method to start/execute a workflow on the CommServe.

## SYNTAX

### ByObject (Default)
```
Start-CVWorkflow -WorkflowObject <Object> [-Force] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ById
```
Start-CVWorkflow -Id <Int32> [-Force] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ByName
```
Start-CVWorkflow -Name <String> [-Force] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Method to start/execute a workflow on the CommServe.

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
Specify workflow to be started by Id.

```yaml
Type: System.Int32
Parameter Sets: ById
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -Name
Specify workflow to be started by Name.

```yaml
Type: System.String
Parameter Sets: ByName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue, ByPropertyName)
Accept wildcard characters: False
```

### -WorkflowObject
Specify workflow to be started by WorkflowObject.

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

### System.Int32

### System.Object

### System.String

## OUTPUTS

### Outputs [PSCustomObject] containing start workflow result.

## NOTES

ALIASES

## RELATED LINKS

