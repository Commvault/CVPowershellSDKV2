
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
Modify global settings used to override system default behaviour
.Description
Modify global settings used to override system default behaviour
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.IModifyGlobalSettings
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IModifyGlobalSettings>: ModifyGlobalSettings
  [GlobalSettings <IModifyAdditionalSetting[]>]: 
    Category <String>: Category of the setting to be modified. This cannot be modified but is required to identify the setting for which the new value is to be set.
    Name <String>: Name of the setting to be modified. This cannot be modified but is required to identify the setting for which the new value is to be set.
    Type <String>: Type of the setting to be modified. This cannot be modified but is required to identify the setting for which the new value is to be set.
    [Comment <String>]: Comment to specify why this value was set for the specified setting
    [NewValue <String>]: New value which will be set for the specified setting, there can be fixed acceptables values for some settings. To get more details about what are acceptable value for a setting, use GET GlobalSettings or GET EntitySettings.
    [Reset <Boolean?>]: To reset the value of any already modified setting, set this to true to reset the value and regain default behaviour

GLOBALSETTINGS <IModifyAdditionalSetting[]>: .
  Category <String>: Category of the setting to be modified. This cannot be modified but is required to identify the setting for which the new value is to be set.
  Name <String>: Name of the setting to be modified. This cannot be modified but is required to identify the setting for which the new value is to be set.
  Type <String>: Type of the setting to be modified. This cannot be modified but is required to identify the setting for which the new value is to be set.
  [Comment <String>]: Comment to specify why this value was set for the specified setting
  [NewValue <String>]: New value which will be set for the specified setting, there can be fixed acceptables values for some settings. To get more details about what are acceptable value for a setting, use GET GlobalSettings or GET EntitySettings.
  [Reset <Boolean?>]: To reset the value of any already modified setting, set this to true to reset the value and regain default behaviour
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifyglobalsetting
#>
function Invoke-ModifyGlobalSetting {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='ModifyExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Modify', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IModifyGlobalSettings]
    # ModifyGlobalSettings
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IModifyAdditionalSetting[]]
    # .
    # To construct, see NOTES section for GLOBALSETTINGS properties and create a hash table.
    ${GlobalSettings},

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
            Modify = 'CommvaultPowerShell.private\Invoke-ModifyGlobalSetting_Modify';
            ModifyExpanded = 'CommvaultPowerShell.private\Invoke-ModifyGlobalSetting_ModifyExpanded';
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
