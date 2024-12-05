Add-AEnums
function Get-CVManagedAccount {
    <#
    .SYNOPSIS
        Get the list of partner-managed accounts.
    .DESCRIPTION
        Retrieves the list of partner-managed accounts in the Lighthouse portal.
    .PARAMETER None
        No parameters are required.
    .OUTPUTS
        [PSCustomObject] containing managed accounts details.
    .NOTES
        Pass
    #>
    [CmdletBinding()]
    [OutputType([PSCustomObject])]
    param ()

    begin {
        Write-Debug -Message "$($MyInvocation.MyCommand): begin"
        try {
            $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
        }
        catch {
            Write-Error -Message "Failed to retrieve session details: $_"
            throw $_
        }
    }

    process {
        Write-Debug -Message "$($MyInvocation.MyCommand): process"
        try {
            # Sanitize endpoint in session request properties
            if ($sessionObj -and $sessionObj.requestProps -and $sessionObj.requestProps.endpoint) {
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace '{scheduleType}', $null
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace '{subclientId}', $null
            }

            # Prepare REST headers and payload
            $headerObj = Get-CVRESTHeader $sessionObj
            $payload = @{
                headerObject = $headerObj
            }

            # Submit REST request
            $response = Submit-CVRESTRequest -Payload $payload -Validate $true
        }
        catch {
            Write-Error -Message "Error during API request: $_"
            throw $_
        }
    }

    end {
        Write-Debug -Message "$($MyInvocation.MyCommand): end"
        try {
            # Check if response contains data
            if ($response -and $response.Content.data -and $response.Content.data.Count -gt 0) {
                # Output each managed account as a PSCustomObject
                $response.Content.data | ForEach-Object {
                    [PSCustomObject]@{
                        AccountName = $_.name
                        AccountId   = $_.id
                        Status      = $_.status
                    }
                }
            }
            else {
                Write-Information -MessageData "INFO: No managed accounts found."
            }
        }
        catch {
            Write-Error -Message "Error processing response: $_"
            throw $_
        }
    }
}
