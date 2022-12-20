Add-AEnums
function Get-CVId {
    <#
    .SYNOPSIS
        Method to retrieve the Id for a given Entity from the CommServe.
    
    .DESCRIPTION
        Method to retrieve the Id for a given Entity from the CommServe.
        
    .PARAMETER ClientName
        Get Client Id for ClientName.
    .PARAMETER AgentName
        Get Application Id for AgentName. Example 'File System', 'Active Directory Agent'
    .PARAMETER BackupSetName
        Get BackupSet Id for BackupSetName.
    .PARAMETER InstanceName
        Get Instance Id for InstanceName.
    .PARAMETER SubclientName
        Get Subclient Id for SubclientName.
    .EXAMPLE
        Get-CVId -ClientName 'YashClient'
    .EXAMPLE
        Get-CVId -ClientName 'YashClient' -AgentName 'File System'
    .EXAMPLE
        Get-CVId -ClientName 'YashClient' -AgentName 'File System'  -BackupSetName 'defaultBackupSet'
    .EXAMPLE
        Get-CVId -ClientName 'YashClient' -AgentName 'File System'  -InstanceName 'DefaultInstanceName'
    .EXAMPLE
        Get-CVId -ClientName 'YashClient' -AgentName 'File System'  -BackupSetName 'defaultBackupSet' -SubclientName 'default'
    .LINK
        All Agent Names: https://documentation.commvault.com/commvault/v11/article?p=45467.htm#o99081
    .OUTPUTS
        Outputs [PSCustomObject] Id of the specified client
    
    .NOTES
        Author: Commvault
        Company: Commvault
    #>
        [CmdletBinding()]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,

            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [String] $AgentName,

            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [String] $BackupSetName,

            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [String] $InstanceName,

            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [String] $SubclientName
        )
    
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                $endpointSave = $sessionObj.requestProps.endpoint
            }
            catch {
                throw $_
            }
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
    
            try {
                $sessionObj.requestProps.endpoint = $endpointSave
                $ClientName = [System.Web.HTTPUtility]::UrlEncode($ClientName)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientName}', $ClientName)

                if (-not [String]::IsNullOrEmpty($AgentName)) {
                    $AgentName = [System.Web.HTTPUtility]::UrlEncode($AgentName)
                    $sessionObj.requestProps.endpoint += '&agent=' + $AgentName
                }

                if (-not [String]::IsNullOrEmpty($BackupSetName)) {
                    $BackupSetName = [System.Web.HTTPUtility]::UrlEncode($BackupSetName)
                    if ([String]::IsNullOrEmpty($AgentName)) {
                        $AgentName = Read-Host 'AgentName'
                        $AgentName = [System.Web.HTTPUtility]::UrlEncode($AgentName)
                        $sessionObj.requestProps.endpoint += '&agent=' + $AgentName
                    }
                    $sessionObj.requestProps.endpoint += '&backupset=' + $BackupSetName
                }

                if (-not [String]::IsNullOrEmpty($InstanceName)) {
                    $InstanceName = [System.Web.HTTPUtility]::UrlEncode($InstanceName)
                    if ([String]::IsNullOrEmpty($AgentName)) {
                        $AgentName = Read-Host 'AgentName'
                        $AgentName = [System.Web.HTTPUtility]::UrlEncode($AgentName)
                        $sessionObj.requestProps.endpoint += '&agent=' + $AgentName
                    }
                    $sessionObj.requestProps.endpoint += '&instanceName=' + $InstanceName
                }

                if (-not [String]::IsNullOrEmpty($SubclientName)) {
                    $SubclientName = [System.Web.HTTPUtility]::UrlEncode($SubclientName)
                    if ([String]::IsNullOrEmpty($AgentName)) {
                        $AgentName = Read-Host 'AgentName'
                        $AgentName = [System.Web.HTTPUtility]::UrlEncode($AgentName)
                        $sessionObj.requestProps.endpoint += '&agent=' + $AgentName
                    }
                    if ([String]::IsNullOrEmpty($BackupSetName)) {
                        $BackupSetName = Read-Host 'BackupSetName'
                        $BackupSetName = [System.Web.HTTPUtility]::UrlEncode($BackupSetName)
                        $sessionObj.requestProps.endpoint += '&backupset=' + $BackupSetName
                    }
                    $sessionObj.requestProps.endpoint += '&subclient=' + $SubclientName
                }

                Write-Debug $sessionObj.requestProps.endpoint

                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = $null
    
                $response = Submit-CVRESTRequest $payload $validate
        
                if ($response.IsValid) {
                    if ($response.Content.clientId -eq -32000) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$ClientName]"
                    }
                    else {
                        Write-Output $response.Content
                    }
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): unable to retrieve Id for the Client"
                }
            }
            catch {
                throw $_
            }
        }
    
    end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
    }
}