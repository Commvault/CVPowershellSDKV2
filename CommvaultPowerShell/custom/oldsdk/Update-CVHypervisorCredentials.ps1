Add-AEnums
function Update-CVHyperVisorCredentials{
    <#
    .Synopsis
        Update the hypervisor credentials
    .Description
        Update the hypervisor credentials
    .Parameter Properties
        Hashtable containing the properties of the credentials. Please refer to the swagger documentation for the payload structure
    .Parameter HypervisorId
        Id of the Hypervisor
    #>
    [OutputType([PSCustomObject])]
    param(
        [Parameter(Mandatory=$True)]
        [ValidateNotNullorEmpty()]
        [Hashtable] $Properties,

        [Parameter(Mandatory=$True)]
        [ValidateNotNullorEmpty()]
        [Int64] $HypervisorId
        )
    begin {Write-Debug "$($MyInvocation.MyCommand): begin"
        try{
            $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{HypervisorId}', $HypervisorId)
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