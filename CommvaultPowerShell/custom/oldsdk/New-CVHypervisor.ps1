Add-AEnums
function New-CVHypervisor {
    <#
    .Synopsis
        Create a New Hypervisor
    .Description
        Create a New Hypervisor
    .Example
        {{ Add code here }}
    .Example
        {{ Add code here }}      
    .PARAMETER Properties
        Hashtable containing the properties of the credential. Use Get-CVCredentialDetail to get the PSObject of an existing creds.
    .OUTPUTS
        Outputs [PSCustomObject] containing credential details.
    .NOTES
        Author: Jnanesh D
        Company: Commvault
    #>
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True)]
            [ValidateNotNullorEmpty()]
            [Hashtable] $Properties
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
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $Body = ConvertTo-Json $Properties -Depth 10
                $payload.Add('body', $Body)
    
                $response = Submit-CVRESTRequest $payload 
    
                Write-Output $response.Content
    

            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }
