function Stop-CVJob {
    <#
    .SYNOPSIS
        Stops/kills the job specified by job Id.
    .DESCRIPTION
        Stops/kills the job specified by job Id. If the job cannot be killed, this command has no effect.
    .PARAMETER JobId
        Stop/kill the job specified by JobId.
    .EXAMPLE
        Stop-CVJob -JobId 78
        
    .OUTPUTS
        Outputs [PSCustomObject] containing result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Kill-CVJob')]
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
                $validate = 'errors'
                
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) { 
                    Write-Output ($response.Content.errors[0].errList | Select-Object errLogMessage)
                }
                else { 
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): stop request was not succesfully submitted for job [$JobId]"
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }