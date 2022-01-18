
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
Updates owner permissions and/or automatic laptop ownership assignment
.Description
Updates owner permissions and/or automatic laptop ownership assignment
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.IAccessControl
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IAccessControl>: Owner permissions and laptop ownership details
  [AutomaticLaptopOwnershipAssignmentAssignLaptopOwnerAutomatically <Boolean?>]: Whether the laptop ownership assignment is automatic or not
  [AutomaticLaptopOwnershipAssignmentLaptopOwnerOption <String>]: Options to automatically assign laptop owners
  [AutomaticLaptopOwnershipAssignmentUserGroups <String>]: Comma seperated usergroups to add users from, when the laptopOwnerOption is 'ALL_USERS_OF_USERGROUPS'
  [OwnerPermissions <IIdName[]>]: List of owner permissions
    [Id <Int32?>]: 
    [Name <String>]: 

OWNERPERMISSIONS <IIdName[]>: List of owner permissions
  [Id <Int32?>]: 
  [Name <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-accesscontrol
#>
function Set-AccessControl {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Put', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IAccessControl]
    # Owner permissions and laptop ownership details
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Whether the laptop ownership assignment is automatic or not
    ${AutomaticLaptopOwnershipAssignmentAssignLaptopOwnerAutomatically},

    [Parameter(ParameterSetName='PutExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Options to automatically assign laptop owners
    ${AutomaticLaptopOwnershipAssignmentLaptopOwnerOption},

    [Parameter(ParameterSetName='PutExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Comma seperated usergroups to add users from, when the laptopOwnerOption is 'ALL_USERS_OF_USERGROUPS'
    ${AutomaticLaptopOwnershipAssignmentUserGroups},

    [Parameter(ParameterSetName='PutExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # List of owner permissions
    # To construct, see NOTES section for OWNERPERMISSIONS properties and create a hash table.
    ${OwnerPermissions},

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
            Put = 'CommvaultPowerShell.private\Set-AccessControl_Put';
            PutExpanded = 'CommvaultPowerShell.private\Set-AccessControl_PutExpanded';
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
