Add-AEnums
function New-CVCloudStorage{
    <#
    .Synopsis
        Create new Cloud storage 
    .Description
        Create new Cloud storage 
    .Parameter Properties
        Hashtable containing the properties of the Cloud Storage. Please refer to the swagger documentation for the payload structure : URL /v4/CloudStorage
    #>
    [OutputType([PSCustomObject])]
    param(
        [Parameter(Mandatory=$True)]
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