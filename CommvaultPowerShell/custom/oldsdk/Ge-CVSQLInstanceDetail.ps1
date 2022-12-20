Add-AEnums
function Get-CVSQLInstanceDetail { 
    <#
    .SYNOPSIS
        Method to retrieve SQL instance details.
    .DESCRIPTION
        Method to retrieve SQL instance details specified by instance name or pipeline input of an SQL instance object.
        
    .PARAMETER Name
        Get SQL instance details for the instance specified by Name.
    .PARAMETER InstanceObject
        Get SQL instance details for the instance object input from the pipeline.
    .PARAMETER AllProperties
        Get all properties for the specified SQL instance.
    .EXAMPLE
        Get-CVSQLInstanceDetail
        
    .EXAMPLE
        Get-CVSQLInstanceDetail -Name SNOWSQL1\SQL2008R2
        
    .EXAMPLE
        Get-CVSQLInstance | Get-CVSQLInstanceDetail -AllProperties
    .OUTPUTS
        Outputs [PSCustomObject] containing SQL instance details.
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
            [System.Object] $InstanceObject,
    
            [Parameter(Mandatory = $False)]
            [Switch] $AllProperties
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
                    $instanceObj = Get-CVSQLInstance -Name $Name
                    if ($null -ne $instanceObj) { 
                        $InstanceObject = $instanceObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): instance not found having name [$Name]"      
                        return
                    }
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $InstanceObject.insId)
    
                if ($AllProperties) {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{propertyLevel}', 11)
                }
                else {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{propertyLevel}', $null)
                }
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{}
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'SqlInstance'
    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    foreach ($instance in $response.Content.SqlInstance) {
                        Write-Output $instance
                    }
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): SQL instance details not found"      
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
    