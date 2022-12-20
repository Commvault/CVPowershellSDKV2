Add-AEnums
function Get-CVSQLClone { 
    <#
    .SYNOPSIS
        Method to retrieve SQL clone information.
    .DESCRIPTION
        Method to retrieve SQL clone information.
        
    .PARAMETER ClientName
        Get clone information filtered by ClientName.
    .PARAMETER ClientId
        Get clone information filtered by ClientId.
    .PARAMETER ClientObject
        Get clone information filtered by piping ClientObject.
    .PARAMETER InstanceName
        Get clone information filtered by InstanceName.
    .PARAMETER InstanceId
        Get clone information filtered by InstanceId.
    .EXAMPLE
        Get-CVSQLClone -ClientName vosql7
    .EXAMPLE
        Get-CVSQLClone -ClientId 104
    .EXAMPLE
        Get-CVSQLClone -ClientId 104 -InstanceId 109
    .EXAMPLE
        Get-CVClient | Get-CVSQLClone
    .OUTPUTS
        Outputs [PSCustomObject] containing SQL clone information.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'Default')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $False, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $InstanceName,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $ClientId,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $InstanceId,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $ClientObject
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
    
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientId)
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $InstanceId)
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    if (-not [String]::IsNullOrEmpty($ClientName)) {
                        $clientObj = Get-CVClient -Name $ClientName
                        if ($null -ne $clientObj) { 
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $clientObj.clientId)
                        }
                        else {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$ClientName]"      
                            return
                        }
                    }
    
                    if (-not [String]::IsNullOrEmpty($InstanceName)) {
                        $instanceObj = Get-CVSQLInstance -Name $InstanceName
                        if ($null -ne $instanceObj) { 
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $instanceObj.insId)
                        }
                        else {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): instance not found having name [$InstanceName]"      
                            return
                        }
                    }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByObject') {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientObject.clientId)
                }
    
                # noop here if already replaced
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $null)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $null)
                
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{}
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'rpObjectList'
    
                $response = Submit-CVRESTRequest $payload $validate
                
                if ($response.IsValid) {
                    foreach ($item in $response.Content.rpObjectList) {
                        Write-Output $item
                    }
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no clones found"      
                }
            }
            catch
            {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }