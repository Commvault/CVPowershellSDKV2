---
external help file:
Module Name: CommvaultPowershell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-cvbackupdestinationwithoutplaninfo
schema: 2.0.0
---

# New-CVBackupDestinationWithoutPlanInfo

## SYNOPSIS
Create backup destination(s) for a plan before creating the plan.\nThe primary backup destination can be then associated with the plan to associate all secondary copies also.\n

## SYNTAX

```
New-CVBackupDestinationWithoutPlanInfo -BackupDestinations <ICreateBackupDestination[]> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create backup destination(s) for a plan before creating the plan.\nThe primary backup destination can be then associated with the plan to associate all secondary copies also.\n

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

### -BackupDestinations
List of backup destinations to create
To construct, see NOTES section for BACKUPDESTINATIONS properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICreateBackupDestination[]
Parameter Sets: (All)
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

## OUTPUTS

### Commvault.Powershell.Models.ICreatePlanBackupDestinationResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BACKUPDESTINATIONS <ICreateBackupDestination[]>: List of backup destinations to create
  - `Name <String>`: Name of backup destination
  - `[BackupStartTime <Int64?>]`: Backup start time in seconds. The time is provided in unix time format.
  - `[BackupsToCopy <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[FirstExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[FirstExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[FirstExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[FullBackupTypesToCopy <String>]`: Which type of backup type should be copied for the given backup destination when backup type is not all jobs. Default is LAST while adding new backup destination.
  - `[IsMirrorCopy <Boolean?>]`: Is this a mirror copy? Only considered when isSnapCopy is true.
  - `[IsSnapCopy <Boolean?>]`: Is this a snap copy? If isMirrorCopy is not set, then default is Vault/Replica.
  - `[Mappings <ISnapshotCopyMapping[]>]`: 
    - `[SourceId <Int64?>]`: 
    - `[SourceName <String>]`: 
    - `[SourceVendorId <Int64?>]`: 
    - `[SourceVendorName <String>]`: 
    - `[TargetId <Int64?>]`: 
    - `[TargetName <String>]`: 
    - `[TargetVendorId <Int64?>]`: 
    - `[TargetVendorName <String>]`: 
    - `[Vendor <String>]`: Snapshot vendors available for Snap Copy mappings
  - `[NetAppCloudTarget <Boolean?>]`: Only for snap copy. Enabling this changes SVM Mapping  to NetApp cloud targets only.
  - `[OptimizeForInstantClone <Boolean?>]`: Flag to specify if primary storage is copy data management enabled.
  - `[OverrideRetentionSettings <Boolean?>]`: Tells if this copy should use storage pool retention period days or the retention defined for this copy. Set as true to use retention defined on this copy.
  - `[RegionId <Int64?>]`: 
  - `[RegionName <String>]`: 
  - `[RetentionPeriodDays <Int64?>]`: Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified, this takes  precedence.
  - `[RetentionRuleType <String>]`: Which type of retention rule should be used for the given backup destination
  - `[SecondExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[SecondExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[SecondExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[SnapRecoveryPoints <Int64?>]`: Number of snap recovery points for snap copy for retention. Can be specified instead of retention period in Days for snap copy.
  - `[SourceCopyId <Int64?>]`: 
  - `[SourceCopyName <String>]`: 
  - `[StoragePoolId <Int64?>]`: 
  - `[StoragePoolName <String>]`: 
  - `[StorageType <String>]`: StorageType
  - `[ThirdExtendedRetentionRuleIsInfiniteRetention <Boolean?>]`: If this is set as true, no need to specify retentionPeriodDays.
  - `[ThirdExtendedRetentionRuleRetentionPeriodDays <Int64?>]`: If this is set, no need to specify isInfiniteRetention as false.
  - `[ThirdExtendedRetentionRuleType <String>]`: All_JOBS means SYNCHRONOUS copy type, others are applicable for SELECTIVE copy Type only.
  - `[UseExtendedRetentionRules <Boolean?>]`: Use extended retention rules

## RELATED LINKS

