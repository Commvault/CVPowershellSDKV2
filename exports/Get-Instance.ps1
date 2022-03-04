
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
This endpoint is used to return the list of instances.
.Description
This endpoint is used to return the list of instances.
.Example
PS C:\> Get-Instance

ApplicationSize DatabaseEngine Id Name                  NotReadyReason                                               Server                  Status    Vendor
--------------- -------------- -- ----                  --------------                                               ------                  ------    ------
0               SQL_SERVER     14 SUJEETHEDGE\COMMVAULT Instance is not associated to a valid plan or storage policy DN_sujeethedge_3_sql_DN NOT_READY NOT_APPLICABLE
0               SQL_SERVER     16 NewmanInstance        Instance not configured with authentication information      bdcsrvtest05            NOT_READY NOT_APPLICABLE
.Example
PS C:\> Get-Instance | Format-List

ApplicationSize         : 0
ClientId                : 65
ClientName              : sujeethedge_3_sql
CommcellName            : 
CompanyId               : 0
CompanyName             : 
DatabaseEngine          : SQL_SERVER
Id                      : 14
LastBackupFailureReason : 
LastBackupJobId         : 0
LastBackupStatus        : NEVER_BACKED_UP
LastBackupTime          : 
Name                    : SUJEETHEDGE\COMMVAULT
NotReadyReason          : Instance is not associated to a valid plan or storage policy
PlanId                  : 0
PlanName                : Not Assigned
Server                  : DN_sujeethedge_3_sql_DN
SlaReasonList           : 
SlaStatus               : 
Status                  : NOT_READY
Vendor                  : NOT_APPLICABLE

ApplicationSize         : 0
ClientId                : 2
ClientName              : bdcsrvtest05
CommcellName            : 
CompanyId               : 0
CompanyName             : 
DatabaseEngine          : SQL_SERVER
Id                      : 16
LastBackupFailureReason : 
LastBackupJobId         : 0
LastBackupStatus        : NEVER_BACKED_UP
LastBackupTime          : 
Name                    : NewmanInstance
NotReadyReason          : Instance not configured with authentication information
PlanId                  : 0
PlanName                : Not Assigned
Server                  : bdcsrvtest05
SlaReasonList           : 
SlaStatus               : 
Status                  : NOT_READY
Vendor                  : NOT_APPLICABLE

.Outputs
Commvault.Powershell.Models.IInstanceSummary
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/get-instance
#>
function Get-Instance {
[OutputType([Commvault.Powershell.Models.IInstanceSummary])]
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
            Get = 'CommvaultPowerShell.private\Get-Instance_Get';
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
