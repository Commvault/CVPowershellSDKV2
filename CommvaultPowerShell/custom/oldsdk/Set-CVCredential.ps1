Add-AEnums
function Set-CVCredential {
    <#
    .Synopsis
        Edit credential whose name has been provided by credential owner
    .Description
        Edit credential whose name has been provided by credential owner
    .Example
        {{ Add code here }}
    .Example
        {{ Add code here }}      
    .PARAMETER Name
        Get Credential Details by Name.
    .PARAMETER Properties
        PSObject containing the properties of the credential. Use Get-CVCredentialDetail to get the PSObject of an existing creds.
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
            [String] $Name,

            [Parameter(Mandatory = $True)]
            [ValidateNotNullorEmpty()]
            [PSObject] $Properties
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
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{name}', $Name)
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
