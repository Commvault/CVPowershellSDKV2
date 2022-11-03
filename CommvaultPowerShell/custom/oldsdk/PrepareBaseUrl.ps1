
$REST_HTTP_STATUS_CODES = @(200, 201, 202, 203, 204, 205, 206, 206, 207, 208);

$CVPS_ERROR_ID = @{
    202  = 'REST API response [Accepted] error: The request has been received but not yet acted upon'
    1000 = 'Empty or null user name: Please provide a user name for web service login'
    1001 = 'Empty or null secure password: Please provide secure password for web service login'
    1002 = 'Invalid CommServe session token: Please login to CommServe with Connect-CVServer'
}

function  PrepareBaseUrl ([String] $Server) {
    
    try {       
        #Remove whitespace
        Write-Output ($Server).Replace(" ", "")
    }
    catch {
        throw $_
    }
}