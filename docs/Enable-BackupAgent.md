---
external help file:
Module Name: CommvaultPowerShell
online version: https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/enable-backupagent
schema: 2.0.0
---

# Enable-BackupAgent

## SYNOPSIS
Used to enable backup property for an agent\nTypes of available agentIds are:\n41-Active Directory,\n21-AIX File System,\n64-Big Data Apps,\n134-Cloud Apps,\n37-DB2,\n103-DB2 MultiNode,\n62-DB2 on Unix,\n128-Documentum,\n90-Domino Mailbox Archiver,\n91-DPM,\n67-Exchange Compliance Archiver,\n53-Exchange Database,\n45-Exchange Mailbox,\n54-Exchange Mailbox (Classic),\n56-Exchange Mailbox Archiver,\n82-Exchange PF Archiver,\n35-Exchange Public Folder,\n73-File Share Archiver,\n33-File System,\n74-FreeBSD,\n71-GroupWise DB,\n17-HP-UX Files System,\n65-Image Level,\n75-Image Level On Unix,\n76-Image Level ProxyHost,\n87-Image Level ProxyHost on Unix,\n3-Informix Database,\n29-Linux File System,\n89-MS SharePoint Archiver,\n104-MySQL,\n13-NAS,\n83-Netware File Archiver,\n12-Netware File System,\n10-Novell Directory Services,\n124-Object Link,\n131-Object Store,\n86-OES File System on Linux,\n22-Oracle,\n80-Oracle RAC,\n130-Other External Agent,\n125-PostgreSQL,\n38-Proxy Client File System,\n87-ProxyHost on Unix,\n61-SAP for Oracle,\n135-SAP HANA,\n78-SharePoint Server,\n20-Solaris 64bit File System,\n19-Solaris File System,\n81-SQL Server,\n5-Sybase Database,\n66-Unix File Archiver,\n36-Unix Tru64 64-bit File System,\n106-Virtual Server,\n58- Windows File Archiver

## SYNTAX

### Enable (Default)
```
Enable-BackupAgent -AgentId <Int32> -ServerId <Int32> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### EnableViaIdentity
```
Enable-BackupAgent -InputObject <ICommvaultPowerShellIdentity> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Used to enable backup property for an agent\nTypes of available agentIds are:\n41-Active Directory,\n21-AIX File System,\n64-Big Data Apps,\n134-Cloud Apps,\n37-DB2,\n103-DB2 MultiNode,\n62-DB2 on Unix,\n128-Documentum,\n90-Domino Mailbox Archiver,\n91-DPM,\n67-Exchange Compliance Archiver,\n53-Exchange Database,\n45-Exchange Mailbox,\n54-Exchange Mailbox (Classic),\n56-Exchange Mailbox Archiver,\n82-Exchange PF Archiver,\n35-Exchange Public Folder,\n73-File Share Archiver,\n33-File System,\n74-FreeBSD,\n71-GroupWise DB,\n17-HP-UX Files System,\n65-Image Level,\n75-Image Level On Unix,\n76-Image Level ProxyHost,\n87-Image Level ProxyHost on Unix,\n3-Informix Database,\n29-Linux File System,\n89-MS SharePoint Archiver,\n104-MySQL,\n13-NAS,\n83-Netware File Archiver,\n12-Netware File System,\n10-Novell Directory Services,\n124-Object Link,\n131-Object Store,\n86-OES File System on Linux,\n22-Oracle,\n80-Oracle RAC,\n130-Other External Agent,\n125-PostgreSQL,\n38-Proxy Client File System,\n87-ProxyHost on Unix,\n61-SAP for Oracle,\n135-SAP HANA,\n78-SharePoint Server,\n20-Solaris 64bit File System,\n19-Solaris File System,\n81-SQL Server,\n5-Sybase Database,\n66-Unix File Archiver,\n36-Unix Tru64 64-bit File System,\n106-Virtual Server,\n58- Windows File Archiver

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

### -AgentId
Id of the agent to be modified

```yaml
Type: System.Int32
Parameter Sets: Enable
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Commvault.Powershell.Models.ICommvaultPowerShellIdentity
Parameter Sets: EnableViaIdentity
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

### -ServerId
Id of the server to modify

```yaml
Type: System.Int32
Parameter Sets: Enable
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

### Commvault.Powershell.Models.ICommvaultPowerShellIdentity

## OUTPUTS

### Commvault.Powershell.Models.IGenericResp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
  - `[AccessPathId <Int32?>]`: Id of the mount path whose access path has to be deleted
  - `[AgentId <Int32?>]`: Id of the agent to be modified
  - `[BackupDestinationId <Int32?>]`: Id of the backupDestination to be modified
  - `[BackupLocationId <Int32?>]`: Id of the backup location whose details have to be fetched
  - `[BlackoutWindowId <Int32?>]`: Id of the Blackout Window whose details have to be fetched
  - `[BucketId <Int32?>]`: Id of Bucket
  - `[CloudStorageId <Int32?>]`: Id of cloud Storage
  - `[CompanyId <Int32?>]`: Id of the Company whose details have to be fetched
  - `[CredentialName <String>]`: 
  - `[DomainId <Int32?>]`: ID of the AD/LDAP domain
  - `[EntityId <Int32?>]`: Unique id for the entity
  - `[EntityType <String>]`: Type of the entity
  - `[GlobalSearchEntity <String>]`: name of global search entity
  - `[HfsShareId <Int32?>]`: Id of the HFS Share to fetch its status
  - `[HyperScaleStorageId <Int32?>]`: Id of hyperscale storage
  - `[HypervisorId <Int32?>]`: Id of the HYpervisor to get
  - `[Id <Int32?>]`: 
  - `[InstanceId <Int32?>]`: Id of the instance to modify
  - `[KmsId <Int32?>]`: Id of Key Management Server
  - `[MediaAgentId <Int32?>]`: Id of the Media Agent whose details have to be fetched
  - `[MetadataCacheId <Int32?>]`: Id of metadata cache
  - `[Name <String>]`: 
  - `[NodeId <Int32?>]`: Id of node
  - `[PairId <Int32?>]`: 
  - `[PlanId <Int32?>]`: Id of the plan to fetch details
  - `[RecoveryTargetId <Int32?>]`: id of recovery target
  - `[RegionId <String>]`: 
  - `[RegionList <String>]`: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  - `[ReplicationGroupId <String>]`: 
  - `[RequestId <Int32?>]`: Unique identifier for the request
  - `[RoleId <Int32?>]`: Role Id
  - `[RpsId <String>]`: 
  - `[RuleId <Int32?>]`: Id of the rule to update in Plan
  - `[ScheduleId <String>]`: 
  - `[SchedulePolicyId <String>]`: 
  - `[ServerGroupId <Int32?>]`: Id of the serverGroupId whose details have to be fetched
  - `[ServerId <Int32?>]`: Id of the server to modify
  - `[StoragePoolId <Int32?>]`: Id of the disk storage pool whose details have to be fetched
  - `[SubclientId <Int32?>]`: Id of the subclient to modify
  - `[TopologyId <String>]`: 
  - `[UserGroupId <Int32?>]`: Id of the user-group whose details have to be fetched
  - `[UserId <Int32?>]`: Id of the User whose details have to be fetched
  - `[VMGroupId <Int32?>]`: Id of the VMgroup to update
  - `[VMUuid <String>]`: The vmUUID can be obtained from GET /virtualMachines UUID property

## RELATED LINKS

