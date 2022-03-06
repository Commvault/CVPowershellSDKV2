
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
This endpoint is used to return the list of file servers.
.Description
This endpoint is used to return the list of file servers.
.Example
PS C:\> Get-FileServer | Format-List

FileServerCount : 12
FileServers     : {JNANESH_CS_1, jnan_test_bdc, jnan_linux_3, jnancs_sp19_3…}

.Example
PS C:\> Get-FileServer | Select-object -ExpandProperty FileServers

ApplicationSize CommcellName Configured DisplayName     Guid                                 Id  Name            Status         Type
--------------- ------------ ---------- -----------     ----                                 --  ----            ------         ----
0                            True       jnanesh_cs_1    7861B9C2-661E-4CF3-A40E-C354F741E30A 2   JNANESH_CS_1    ONLINE         WINDOWS
0                            True       jnan_test_bdc   F08E2B1C-1857-4CDC-91A0-E6F30F3F8444 11  jnan_test_bdc   ONLINE         WINDOWS
0                            True       jnan_linux_3    922EB4D1-0BB8-475B-8FC7-BDED92410ABF 19  jnan_linux_3    ONLINE         UNIX
0                            True       jnancs_sp19_3   6BD14B11-57AA-4272-A447-A441B47DEBD1 56  jnancs_sp19_3   ONLINE         WINDOWS
3695499                      True       bdcdemo2_client 41DEB9CE-C715-4001-B877-EF86F24B75C5 86  bdcdemo2_client ONLINE         WINDOWS
0                            True       dockerwc        27FEAF97-56EC-4B5B-BECA-13A946210EB7 88  dockerwc        OFFLINE        WINDOWS
282477535                    True       Client2         0C3523CB-6F19-477E-9FDD-16F3F7780D7E 299 Client2         ONLINE         WINDOWS
0                            True       Client4         7F461D2D-BA53-4B46-8E08-56E8CA154663 300 Client4         ONLINE         WINDOWS
407652014                    True       Client3         B05F2D7F-9256-4424-B170-C30394038059 301 Client3         ONLINE         WINDOWS
26                           True       Client7         F6B00258-655B-4394-904A-1748CAEC7B52 305 Client7         OFFLINE        WINDOWS
0                            True       172.19.71.58    A6D635FB-7A7C-41BA-B1DD-7195AF6BB8BC 336 172.19.71.58    NOT_APPLICABLE NAS
0                            True       nfs_server_name 8DCB5C19-92B9-49B9-BB3B-4FC4DAD9A26B 337 nfs_server_name NOT_APPLICABLE NAS

.Outputs
Commvault.Powershell.Models.IFileServerListResp
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-fileserver
#>
function Get-FileServer {
[OutputType([Commvault.Powershell.Models.IFileServerListResp])]
[CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false)]
param(
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
            Get = 'CommvaultPowerShell.private\Get-FileServer_Get';
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
