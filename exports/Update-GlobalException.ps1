
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
Add/Edit/Delete global execptions
.Description
Add/Edit/Delete global execptions
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ISetGlobalExceptions
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISetGlobalExceptions>: Used to set global exceptions
  [UnixGlobalExceptionExceptions <String[]>]: Array of exceptions which will be operated upon based on the operation type
  [UnixGlobalExceptionOperationType <String>]: The operations on global exceptions provided would be executed based on the operation type provided
  [UseGlobalExceptionsOnAllSubclients <Boolean?>]: Boolean value which updates the property useGlobalExceptionsOnAllSubclients
  [WindowGlobalExceptionExceptions <String[]>]: Array of exceptions which will be operated upon based on the operation type
  [WindowGlobalExceptionOperationType <String>]: The operations on global exceptions provided would be executed based on the operation type provided
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/update-globalexception
#>
function Update-GlobalException {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ISetGlobalExceptions]
    # Used to set global exceptions
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Array of exceptions which will be operated upon based on the operation type
    ${UnixGlobalExceptionExceptions},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The operations on global exceptions provided would be executed based on the operation type provided
    ${UnixGlobalExceptionOperationType},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Boolean value which updates the property useGlobalExceptionsOnAllSubclients
    ${UseGlobalExceptionsOnAllSubclients},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String[]]
    # Array of exceptions which will be operated upon based on the operation type
    ${WindowGlobalExceptionExceptions},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The operations on global exceptions provided would be executed based on the operation type provided
    ${WindowGlobalExceptionOperationType},

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
            Update = 'CommvaultPowerShell.private\Update-GlobalException_Update';
            UpdateExpanded = 'CommvaultPowerShell.private\Update-GlobalException_UpdateExpanded';
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
