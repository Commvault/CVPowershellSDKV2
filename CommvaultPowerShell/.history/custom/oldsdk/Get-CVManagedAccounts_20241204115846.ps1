Add-Enums;
function Get-CVManagedAccounts {
    <#
    .SYNOPSIS
        Get the list of partner managed accounts.
    .DESCRIPTION
        Get the list of partner managed accounts in lighthouse portal.
    .PARAMETER
        None
    .OUTPUTS
        Outputs [PSCustomObject] containing managed accounts details.
    .NOTES
        Pass
    #>
    [OutputType([PSCustomObject])]
    begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                $processCount = 0
            }
            catch {
                throw $_
            }
        }
    
    process { Write-Debug -Message "$($MyInvocation.MyCommand): process"

        try {
            

            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{scheduleType}', $null)
            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{subclientId}', $null)

            $headerObj = Get-CVRESTHeader $sessionObj
            $body = ''
            $payload = @{ }
            $payload.Add("headerObject", $headerObj)
            $response = Submit-CVRESTRequest $payload $validate
        }
        catch {
            $PSCmdlet.ThrowTerminatingError($_) 
        }
        finally {
            Write-Output $output
        }
    }
    
    end { Write-Debug -Message "$($MyInvocation.MyCommand): end"

        if ($response.Content.data.Count -gt 0) {
            Write-Output $response.Content.data
            # Your existing code to handle the case where there is at least one managed account
        } else {
            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no managed accounts found"
        }
    }
}