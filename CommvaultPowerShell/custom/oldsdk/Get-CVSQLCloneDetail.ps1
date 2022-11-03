Add-AEnums
function Get-CVSQLCloneDetail { 
    <#
    .SYNOPSIS
        Method to retrieve SQL clone detail information.
    .DESCRIPTION
        Method to retrieve SQL clone detail information.
        
    .PARAMETER Id
        Get clone detail information for clone Id.
    .EXAMPLE
        Get-CVSQLCloneDetail -Id 57
    .EXAMPLE
        Get-CVClient | Get-CVSQLClone | Get-CVCloneDetail
    .OUTPUTS
        Outputs [PSCustomObject] containing SQL clone detail information.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ById')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $Id,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $CloneObject
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
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{cloneId}', $Id)
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByObject') {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{cloneId}', $CloneObject.Id)
                }
                
                #noop here if already replaced
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{propertyLevel}', $null)
        
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
              