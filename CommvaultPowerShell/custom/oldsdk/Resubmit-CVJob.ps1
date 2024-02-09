Add-AEnums
function Restart-CVJob {
    <#
    .SYNOPSIS
        Restart the job specified by job Id.
    
    .DESCRIPTION
        Restart the job specified by job Id. 
    
    .PARAMETER JobId
        Restart the job specified by JobId.
    
    .EXAMPLE
        Restart-CVJob -JobId 78
        
    .OUTPUTS
        Outputs [PSCustomObject] containing result.
    
    .NOTES
        Author: Jnanesh D
        Company: Commvault
    #>
        [CmdletBinding()]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True)]
            [ValidateNotNullorEmpty()]
            [Int32] $JobId
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
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{jobId}', $JobId)
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                
                $response = Submit-CVRESTRequest $payload 'jobIds'
    
                if ($response.IsValid) { 
                    Write-Output $response.Content
                }
                else { 
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): resume request was not succesfully submitted for job [$JobId]"
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
}