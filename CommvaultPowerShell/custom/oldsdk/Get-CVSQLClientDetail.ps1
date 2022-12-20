Add-AEnums
function Get-CVSQLClientDetail { 
    <#
    .SYNOPSIS
        Method to retrieve protected SQL client details.
    .DESCRIPTION
        Method to retrieve protected SQL client details.
        
    .PARAMETER Name
        Get detail properties for SQL client by Name.
    .PARAMETER ClientObject
        Get detail properties for SQL client by piping ClientObject.
    .PARAMETER InstanceName
        Filter output by SQL InstanceName.
    .PARAMETER InstanceId
        Filter output by SQL InstanceId.
    .EXAMPLE
        Get-CVSQLClientDetail
    .EXAMPLE
        Get-CVSQLClientDetail -Name SNOWSQL1
    .EXAMPLE
        Get-CVClient | Get-CVSQLClientDetail
    .EXAMPLE
        Get-CVSQLClientDetail -Name SNOWSQL1 -InstanceId 50
    .EXAMPLE
        Get-CVSQLClientDetail -Name SNOWSQL1 | Select-Object -ExpandProperty SqlInstance
    .OUTPUTS
        Outputs [PSCustomObject] containing SQL client details.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByName')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $ClientObject,
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $InstanceName,
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [Int32] $InstanceId
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
    
                if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    $clientObj = Get-CVClient -Name $Name
                    if ($null -eq $clientObj) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$Name]"
                        return
                    }
                    else {
                        $ClientObject = $clientObj
                    }
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientObject.clientId)
                
                if (-not [String]::IsNullOrEmpty($InstanceName)) {
                    $instanceObj = Get-CVSQLInstance -Name $InstanceName
                    if ($null -eq $instanceObj) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): instance not found having name [$InstanceName]"
                        return
                    }
                    else {
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $instanceObj.insId)
                    }
                }
                elseif ($InstanceId -gt 0) {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $InstanceId)
                }
                else {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $null)
                }
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{}
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'SqlClient'
    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    foreach ($sqlClient in $response.Content.SqlClient) {
                        Write-Output $sqlClient
                    }
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): SQL client not found"      
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }
    