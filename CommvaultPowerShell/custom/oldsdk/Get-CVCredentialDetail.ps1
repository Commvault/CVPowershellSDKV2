Add-AEnums
function Get-CVCredentialDetail {
    <#
    .Synopsis
        Get details of the credential whose credential name is provided
    .Description
        Get details of the credential whose credential name is provided
    .Example
        {{ Add code here }}
    .Example
        {{ Add code here }}      
    .PARAMETER Name
        Get Credential Details by Name.
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
            [String] $Name
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
                $payload.Add('body', $body)
    
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
