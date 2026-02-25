$REST_HTTP_STATUS_CODES = @(200, 201, 202, 203, 204, 205, 206, 206, 207, 208);

$CVPS_ERROR_ID = @{
    202  = 'REST API response [Accepted] error: The request has been received but not yet acted upon'
    1000 = 'Empty or null user name: Please provide a user name for web service login'
    1001 = 'Empty or null secure password: Please provide secure password for web service login'
    1002 = 'Invalid CommServe session token: Please login to CommServe with Invoke-SetupLogin'
}

# Initialize certificate validation bypass for PS 5.1
if ($PSVersionTable.PSVersion.Major -lt 6) {
    if (-not ([System.Management.Automation.PSTypeName]'TrustAllCertsPolicy').Type) {
        Add-Type @"
            using System.Net;
            using System.Security.Cryptography.X509Certificates;
            public class TrustAllCertsPolicy : ICertificatePolicy {
                public bool CheckValidationResult(
                    ServicePoint srvPoint, X509Certificate certificate,
                    WebRequest request, int certificateProblem) {
                    return true;
                }
            }
"@
    }
    [System.Net.ServicePointManager]::CertificatePolicy = New-Object TrustAllCertsPolicy
    [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.SecurityProtocolType]::Tls12
}

function ProcessRequest () {
    
    param (
        [HashTable] $Header, 
        [String] $Body, 
        [String] $BaseUrl, 
        [String] $Endpoint, 
        [String] $Method, 
        [String] $ContentType = 'application/json'
    )

    try {
        $output = @{ }
        $url = "$BaseUrl/$Endpoint"

        $output.Add('Status', '')
        $output.Add('Message', '')
        $output.Add('ErrorMessage', '')
        $output.Add('RecommendedAction', '')
        $output.Add('Body', $null)
        if ($Method.ToLower() -eq 'post' -or $Method.ToLower() -eq 'put' -or $Method.ToLower() -eq 'delete') {
            Write-Debug $url
            Write-Debug $method
            Write-Debug $body
            if ($PSVersionTable.PSVersion.Major -ge 6) {
                $response = Invoke-WebRequest -Uri $url -Method $Method -Body $Body -Headers $Header -ContentType $ContentType -ErrorAction Stop -SkipCertificateCheck
            }
            else {
                $response = Invoke-WebRequest -Uri $url -Method $Method -Body $Body -Headers $Header -ContentType $ContentType -ErrorAction Stop -UseBasicParsing
            }
            Write-Debug $response
        }
        elseif ($Method.ToLower() -eq 'get') {
            if ($PSVersionTable.PSVersion.Major -ge 6) {
                $response = Invoke-WebRequest -Uri $url -Headers $Header -ContentType $ContentType -ErrorAction Stop -SkipCertificateCheck
            }
            else {
                $response = Invoke-WebRequest -Uri $url -Headers $Header -ContentType $ContentType -ErrorAction Stop -UseBasicParsing
            }
        }
    
        $output['Status'] = $response.StatusCode

        if ($REST_HTTP_STATUS_CODES.Contains($response.StatusCode)) {
            $output['Body'] = $response
        }
        else {
            $output['Error'] = $response.Message
        }
    }
    catch {
        if (HasProperty $_.Exception 'Status') { $output['Status'] = $_.Exception.Status }
        if (HasProperty $_.Exception 'Message') { $output['Message'] = $_.Exception.Message }
        if ((HasProperty $_ 'ErrorDetails') -and ($null -ne $_.ErrorDetails)) {
            if (HasProperty $_.ErrorDetails 'Message') { $output['ErrorMessage'] = $_.ErrorDetails.Message }
            if (HasProperty $_.ErrorDetails 'RecommendedAction') { $output['RecommendedAction'] = $_.ErrorDetails.RecommendedAction }
        }
    }
    finally {
        Write-Output $output
    }
}

function HasProperty($Object, $PropertyName)
{
    $PropertyName -in $Object.PSobject.Properties.Name
}