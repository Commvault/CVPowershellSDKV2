---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-cvbrowsehypervisorinventory
schema: 2.0.0
---

# Invoke-CVBrowseHypervisorInventory

## SYNOPSIS
Browse the Inventory of your hypervisor

## SYNTAX

```
Invoke-CVBrowseHypervisorInventory [-hypervisorId] <Hashtable> [-InventoryEntityName] <String>
 [<CommonParameters>]
```

## DESCRIPTION
Browse the Inventory of your hypervisor : URL /V4/Hypervisor/{hypervisorId}/{InventoryEntityName}/Browse

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

### -hypervisorId
Hypervisor client ID to browse

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InventoryEntityName
Name of the inventory entity that needs to be browsed like ESX Host name in VCenter

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

ALIASES

## RELATED LINKS

