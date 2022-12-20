using namespace System.Management.Automation;

$REST_HTTP_STATUS_CODES = @(200, 201, 202, 203, 204, 205, 206, 206, 207, 208);

$CVPS_ERROR_ID = @{
    202  = 'REST API response [Accepted] error: The request has been received but not yet acted upon'
    1000 = 'Empty or null user name: Please provide a user name for web service login'
    1001 = 'Empty or null secure password: Please provide secure password for web service login'
    1002 = 'Invalid CommServe session token: Please login to CommServe with Invoke-SetupLogin'
}
function ValidateResponse ([HashTable] $Response, [PSCustomObject] $Output, [String] $ValidateProperty) {
    
    try {
        if ($Response.Status -eq 200 -and $null -ne $Response.Body) {
            try {
                $Output | Add-Member -NotePropertyName 'Content' -NotePropertyValue ($Response.Body | ConvertFrom-Json)
                if (-not $Output.IsValid -and -not[String]::IsNullOrEmpty($ValidateProperty)) {
                    $Output.IsValid = ($ValidateProperty -in $Output.Content.PSobject.Properties.Name)
                }
            }
            catch {
                if ($_.Exception.Message.Contains('Invalid JSON primitive: ')) { # Xml or plain text response body
                    $Output | Add-Member -NotePropertyName 'Content' -NotePropertyValue $Response.Body.Content
                    if (-not $Output.IsValid -and -not[String]::IsNullOrEmpty($ValidateProperty)) {
                        $Output.IsValid = ($Output.Content.Contains($ValidateProperty))
                    }
                }
            }
        }
        elseif ($Response.Status -eq 202) {
            $errorRecord = New-Object ErrorRecord (
                (New-Object Exception $CVPS_ERROR_ID.202),
                'CVPS_ERROR_ID.202',
                [ErrorCategory]::OperationStopped,
                $Response
            )
            throw $errorRecord
        }
        else {
            $errorMessage =  "`nStatus: $($Response.Status)"
            $errorMessage += "`nMessage: $($Response.Message)"
            $errorMessage += "`nErrorMessage: $($Response.ErrorMessage)"
            $errorMessage += "`nRecommendedAction: $($Response.RecommendedAction)"
            Write-Error -Message $errorMessage
        }
    }
    catch {
        if ($_.FullyQualifiedErrorId -ne 'PropertyNotFoundStrict') {
            throw $_
        }
    }
}