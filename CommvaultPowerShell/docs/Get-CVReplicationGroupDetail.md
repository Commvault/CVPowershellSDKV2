---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-cvreplicationgroupdetail
schema: 2.0.0
---

# Get-CVReplicationGroupDetail

## SYNOPSIS
Get details of a replication group based on replicationGroupId

## SYNTAX

```
Get-CVReplicationGroupDetail [-ReplicationGroupId] <Int64> [[-OverrideReplicationOptions] <Boolean>]
 [[-viewReplicationOptions] <Boolean>] [<CommonParameters>]
```

## DESCRIPTION
Get details of a replication group based on replicationGroupId

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

### -OverrideReplicationOptions
Set to true if you want to see override replication options for a periodic replication group

```yaml
Type: System.Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReplicationGroupId
ID of the replicationGroup

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -viewReplicationOptions
Set to true if want to show replication options for a continuous replication group

```yaml
Type: System.Boolean
Parameter Sets: (All)
Aliases:

Required: False
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

