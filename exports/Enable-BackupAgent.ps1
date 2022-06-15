
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Used to enable backup property for an agent\nTypes of available agentIds are:\n41-Active Directory,\n21-AIX File System,\n64-Big Data Apps,\n134-Cloud Apps,\n37-DB2,\n103-DB2 MultiNode,\n62-DB2 on Unix,\n128-Documentum,\n90-Domino Mailbox Archiver,\n91-DPM,\n67-Exchange Compliance Archiver,\n53-Exchange Database,\n45-Exchange Mailbox,\n54-Exchange Mailbox (Classic),\n56-Exchange Mailbox Archiver,\n82-Exchange PF Archiver,\n35-Exchange Public Folder,\n73-File Share Archiver,\n33-File System,\n74-FreeBSD,\n71-GroupWise DB,\n17-HP-UX Files System,\n65-Image Level,\n75-Image Level On Unix,\n76-Image Level ProxyHost,\n87-Image Level ProxyHost on Unix,\n3-Informix Database,\n29-Linux File System,\n89-MS SharePoint Archiver,\n104-MySQL,\n13-NAS,\n83-Netware File Archiver,\n12-Netware File System,\n10-Novell Directory Services,\n124-Object Link,\n131-Object Store,\n86-OES File System on Linux,\n22-Oracle,\n80-Oracle RAC,\n130-Other External Agent,\n125-PostgreSQL,\n38-Proxy Client File System,\n87-ProxyHost on Unix,\n61-SAP for Oracle,\n135-SAP HANA,\n78-SharePoint Server,\n20-Solaris 64bit File System,\n19-Solaris File System,\n81-SQL Server,\n5-Sybase Database,\n66-Unix File Archiver,\n36-Unix Tru64 64-bit File System,\n106-Virtual Server,\n58- Windows File Archiver
.Description
Used to enable backup property for an agent\nTypes of available agentIds are:\n41-Active Directory,\n21-AIX File System,\n64-Big Data Apps,\n134-Cloud Apps,\n37-DB2,\n103-DB2 MultiNode,\n62-DB2 on Unix,\n128-Documentum,\n90-Domino Mailbox Archiver,\n91-DPM,\n67-Exchange Compliance Archiver,\n53-Exchange Database,\n45-Exchange Mailbox,\n54-Exchange Mailbox (Classic),\n56-Exchange Mailbox Archiver,\n82-Exchange PF Archiver,\n35-Exchange Public Folder,\n73-File Share Archiver,\n33-File System,\n74-FreeBSD,\n71-GroupWise DB,\n17-HP-UX Files System,\n65-Image Level,\n75-Image Level On Unix,\n76-Image Level ProxyHost,\n87-Image Level ProxyHost on Unix,\n3-Informix Database,\n29-Linux File System,\n89-MS SharePoint Archiver,\n104-MySQL,\n13-NAS,\n83-Netware File Archiver,\n12-Netware File System,\n10-Novell Directory Services,\n124-Object Link,\n131-Object Store,\n86-OES File System on Linux,\n22-Oracle,\n80-Oracle RAC,\n130-Other External Agent,\n125-PostgreSQL,\n38-Proxy Client File System,\n87-ProxyHost on Unix,\n61-SAP for Oracle,\n135-SAP HANA,\n78-SharePoint Server,\n20-Solaris 64bit File System,\n19-Solaris File System,\n81-SQL Server,\n5-Sybase Database,\n66-Unix File Archiver,\n36-Unix Tru64 64-bit File System,\n106-Virtual Server,\n58- Windows File Archiver
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICommvaultPowerShellIdentity
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
  [AccessPathId <Int32?>]: Id of the mount path whose access path has to be deleted
  [AgentId <Int32?>]: Id of the agent to be modified
  [BackupDestinationId <Int32?>]: Id of the backupDestination to be modified
  [BackupLocationId <Int32?>]: Id of the backup location whose details have to be fetched
  [BlackoutWindowId <Int32?>]: Id of the Blackout Window whose details have to be fetched
  [BucketId <Int32?>]: Id of Bucket
  [CloudStorageId <Int32?>]: Id of cloud Storage
  [CompanyId <Int32?>]: Id of the Company whose details have to be fetched
  [CredentialName <String>]: 
  [DomainId <Int32?>]: ID of the AD/LDAP domain
  [EntityId <Int32?>]: Unique id for the entity
  [EntityType <Int32?>]: Type of the entity
  [GlobalSearchEntity <String>]: name of global search entity
  [HfsShareId <Int32?>]: Id of the HFS Share to fetch its status
  [HyperScaleStorageId <Int32?>]: Id of hyperscale storage
  [HypervisorId <Int32?>]: Id of the Hypervisor to update
  [Id <Int32?>]: 
  [InstanceId <Int32?>]: Id of the instance to modify
  [InventoryEntityName <String>]: Name of the inventory entity that needs to be browsed like ESX Host name in VCenter
  [KmsId <Int32?>]: Id of Key Management Server
  [MediaAgentId <Int32?>]: Id of the Media Agent whose details have to be fetched
  [MetadataCacheId <Int32?>]: Id of metadata cache
  [Name <String>]: 
  [NodeId <Int32?>]: Id of node
  [PairId <Int32?>]: 
  [PlanId <Int32?>]: Id of the plan to fetch details
  [RecoveryTargetId <Int32?>]: id of recovery target
  [RegionId <Int32?>]: 
  [RegionList <String>]: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  [ReplicationGroupId <String>]: 
  [RequestId <Int32?>]: Unique identifier for the request
  [RoleId <Int32?>]: Role Id
  [RpsId <String>]: 
  [RuleId <Int32?>]: Id of the rule to update in Plan
  [ScheduleId <String>]: 
  [SchedulePolicyId <String>]: 
  [ServerGroupId <Int32?>]: Id of the serverGroupId whose details have to be fetched
  [ServerId <Int32?>]: Id of the server to modify
  [StoragePoolId <Int32?>]: Id of the disk storage pool whose details have to be fetched
  [SubclientId <Int32?>]: Id of the subclient to modify
  [TopologyId <String>]: 
  [UserGroupId <Int32?>]: Id of the user-group whose details have to be fetched
  [UserId <Int32?>]: Id of the User whose details have to be fetched
  [VMGroupId <Int32?>]: Id of the VMgroup to update
  [VMUuid <String>]: The vmUUID can be obtained from GET /virtualMachines UUID property
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/enable-backupagent
#>
function Enable-BackupAgent {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='Enable', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Enable', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # Id of the agent to be modified
    ${AgentId},

    [Parameter(ParameterSetName='Enable', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # Id of the server to modify
    ${ServerId},

    [Parameter(ParameterSetName='EnableViaIdentity', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Path')]
    [Commvault.Powershell.Models.ICommvaultPowerShellIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(DontShow)]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Commvault.Powershell.Category('Runtime')]
    [Commvault.Powershell.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Commvault.Powershell.Category('Runtime')]
    [Commvault.Powershell.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Commvault.Powershell.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Enable = 'CommvaultPowerShell.private\Enable-BackupAgent_Enable';
            EnableViaIdentity = 'CommvaultPowerShell.private\Enable-BackupAgent_EnableViaIdentity';
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
