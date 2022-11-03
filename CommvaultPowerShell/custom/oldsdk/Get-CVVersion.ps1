Add-AEnums
function Get-CVVersionInfo {
    <#
    .SYNOPSIS
        Method to retrieve the current version, service pack level, and time zone settings on the CommServe.
    .DESCRIPTION
        Method to retrieve the current version, service pack level, and time zone settings on the CommServe.
    .PARAMETER None
    .EXAMPLE
        Get-CVVersionInfo
        
    .OUTPUTS
        Outputs [PSCustomObject] containing CommServe configuration data.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding()]
        [OutputType([PSCustomObject])]
        param()
        
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
    
                $body = ''
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = $null
    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): unable to retrieve CommServe version information"
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }