Add-AEnums
function New-CVLdap{
    <#
    .Synopsis
        Create LDAP/Active directory for user authentication
    .Description
        Create LDAP/Active directory for user authentication
    .Parameter Properties
        Hashtable containing the properties of the Ldap server. Please refer to the swagger documentation for the payload structure
    #>
    [OutputType([PSCustomObject])]
    param(
        [Parameter(Mandatory=$True)]
        [ValidateNotNullorEmpty()]
        [Hashtable] $Properties
    )

    begin {Write-Debug "$($MyInvocation.MyCommand): begin"
        try{
            $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
            $endpointSave = $sessionObj.requestProps.endpoint
        }
        catch {
            throw $_
        }
    }
    process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
        try {
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
}