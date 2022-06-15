
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
Create a Company
.Description
Create a Company
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Commvault.Powershell.Models.IIdName
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

PLANS <IIdName[]>: Select data protection plans to use for the company. The plans that are selected are the plans that the tenant administrator can choose from.
  [Id <Int32?>]: 
  [Name <String>]: 

SERVICECOMMCELLS <IIdName[]>: Used to add service commcells to the master commcell. Either id or name can be provided. If both are provided, id will be taken into consideration.
  [Id <Int32?>]: 
  [Name <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-company
#>
function New-Company {
[OutputType([Commvault.Powershell.Models.IIdName])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The company domain or NetBIOS name
    ${Alias},

    [Parameter(Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # name of the company to be created.
    ${Name},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Name of the tenant administrator.
    # If provided, email also needs to be provided.
    ${ContactName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Email address for the tenant administrator.
    # If provided, contactName for the tenant administrator also needs to be provided
    ${Email},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Supported domains for the company
    ${EmailSuffix},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # Select data protection plans to use for the company.
    # The plans that are selected are the plans that the tenant administrator can choose from.
    # To construct, see NOTES section for PLANS properties and create a hash table.
    ${Plans},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The primary domain name of the company being created.
    # Can be added only if an external domain is already present.
    ${PrimaryDomain},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # send a welcome email on company creation to the tenant administrator.
    ${SendWelcomeEmail},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # Used to add service commcells to the master commcell.
    # Either id or name can be provided.
    # If both are provided, id will be taken into consideration.
    # To construct, see NOTES section for SERVICECOMMCELLS properties and create a hash table.
    ${ServiceCommcells},

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
            CreateExpanded = 'CommvaultPowerShell.private\New-Company_CreateExpanded';
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
