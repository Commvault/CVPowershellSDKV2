
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
Create a new disk storage pool
.Description
Create a new disk storage pool
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICreateDiskStorage
.Outputs
Commvault.Powershell.Models.IIdName
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ICreateDiskStorage>: .
  EnableDeduplication <Boolean>: enables or disables deduplication
  Name <String>: Name of the Disk Storage to be created.
  Storage <IPath[]>: A list of backup locations can be provided for the storage pool being created.
    [BackupLocation <String>]: 
    [CredentialsName <String>]: username to access the network path
    [CredentialsPassword <String>]: password to access the network path
    [MediaAgentId <Int32?>]: 
    [MediaAgentName <String>]: 
    [SavedCredentialsId <Int32?>]: 
    [SavedCredentialsName <String>]: 
  [DeduplicationDbStorage <IDedupePath[]>]: A list of dedupe locations can be provided for the storage pool being created. This provides an efficient way to save/store data by eliminating duplicate blocks of data during backups.
    [MediaAgentId <Int32?>]: 
    [MediaAgentName <String>]: 
    [Path <String>]: 

DEDUPLICATIONDBSTORAGE <IDedupePath[]>: A list of dedupe locations can be provided for the storage pool being created. This provides an efficient way to save/store data by eliminating duplicate blocks of data during backups.
  [MediaAgentId <Int32?>]: 
  [MediaAgentName <String>]: 
  [Path <String>]: 

STORAGE <IPath[]>: A list of backup locations can be provided for the storage pool being created.
  [BackupLocation <String>]: 
  [CredentialsName <String>]: username to access the network path
  [CredentialsPassword <String>]: password to access the network path
  [MediaAgentId <Int32?>]: 
  [MediaAgentName <String>]: 
  [SavedCredentialsId <Int32?>]: 
  [SavedCredentialsName <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-diskstorage
#>
function New-DiskStorage {
[OutputType([Commvault.Powershell.Models.IIdName])]
[CmdletBinding(DefaultParameterSetName='Create', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ICreateDiskStorage]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # enables or disables deduplication
    ${EnableDeduplication},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Name of the Disk Storage to be created.
    ${Name},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IPath[]]
    # A list of backup locations can be provided for the storage pool being created.
    # To construct, see NOTES section for STORAGE properties and create a hash table.
    ${Storage},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IDedupePath[]]
    # A list of dedupe locations can be provided for the storage pool being created.
    # This provides an efficient way to save/store data by eliminating duplicate blocks of data during backups.
    # To construct, see NOTES section for DEDUPLICATIONDBSTORAGE properties and create a hash table.
    ${DeduplicationDbStorage},

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
            Create = 'CommvaultPowerShell.private\New-DiskStorage_Create';
            CreateExpanded = 'CommvaultPowerShell.private\New-DiskStorage_CreateExpanded';
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
