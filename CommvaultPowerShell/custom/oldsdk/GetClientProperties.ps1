Add-AEnums
function GetClientProperties ([System.Object] $ClientObject) {

    try {
        $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientObject.clientId)

        $headerObj = Get-CVRESTHeader $sessionObj
        $body = ''
        $payload = @{ }
        $payload.Add('headerObject', $headerObj)
        $payload.Add('body', $body)
        $validate = 'clientProperties'

        $response = Submit-CVRESTRequest $payload $validate

        Write-Output $response
    }
    catch {
        throw $_
    }
}

function GetSubclientProperties ([System.Object] $SubclientObject) {

    try {
        $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{subclientId}', $SubclientObject.subclientId)

        $headerObj = Get-CVRESTHeader $sessionObj
        $body = ''
        $payload = @{ }
        $payload.Add('headerObject', $headerObj)
        $payload.Add('body', $body)
        $validate = $null

        $response = Submit-CVRESTRequest $payload $validate

        if ($response.IsValid) {
            Write-Output $response.Content
        }
    }
    catch {
        throw $_
    }
}

function GetClientAdditionalSettings ([String] $ClientId) {

    try {
        $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientId)

        $headerObj = Get-CVRESTHeader $sessionObj
        $body = ''
        $payload = @{ }
        $payload.Add('headerObject', $headerObj)
        $payload.Add('body', $body)
        $validate = $null

        $response = Submit-CVRESTRequest $payload $validate

        if ($response.IsValid) {
            if ('regKeys' -in $response.Content.PSObject.Properties.Name) {
                    Write-Output $response.Content.regKeys
            }
            else { 
                Write-Output $response.Content
            }
        }
    }
    catch {
        throw $_
    }
}