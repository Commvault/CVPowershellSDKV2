
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
Add your QSDK Authenticated token to your Postman Environment by providing the details in the pre-request script.\n\nYou only need to run this one time because these values are stored in your Postman Environment.
.Description
Add your QSDK Authenticated token to your Postman Environment by providing the details in the pre-request script.\n\nYou only need to run this one time because these values are stored in your Postman Environment.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.IEnvironmentSetupRequest
.Outputs
Commvault.Powershell.Models.ILoginResponse
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER <IEnvironmentSetupRequest>: EnvironmentSetupRequest
  Password <String>: 
  Username <String>: 
  WebServerUrl <String>: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-setuplogin
#>
function Invoke-SetupLogin {
[OutputType([Commvault.Powershell.Models.ILoginResponse])]
[CmdletBinding(DefaultParameterSetName='PostExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Post', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IEnvironmentSetupRequest]
    # EnvironmentSetupRequest
    # To construct, see NOTES section for BODYPARAMETER properties and create a hash table.
    ${BodyParameter},

    [Parameter(ParameterSetName='PostExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${Password},

    [Parameter(ParameterSetName='PostExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${Username},

    [Parameter(ParameterSetName='PostExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${WebServerUrl},

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
            Post = 'CommvaultPowershell.private\Invoke-SetupLogin_Post';
            PostExpanded = 'CommvaultPowershell.private\Invoke-SetupLogin_PostExpanded';
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
