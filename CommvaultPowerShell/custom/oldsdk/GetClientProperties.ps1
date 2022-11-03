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
