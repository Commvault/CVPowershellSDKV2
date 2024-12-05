function Connect-CVServer {
<#
.SYNOPSIS
    Method to get CommServe authorization token.

.DESCRIPTION
    Method to get CommServe authorization token.

.PARAMETER Server
    The CommServe URL to connect to.

.PARAMETER User
    User name for login.

.PARAMETER Password
    Secure password for login.

.PARAMETER Credential
    Powershell credential object. Used as alternative to -User <user> -Password <password>

.EXAMPLE
    Connect-CVServer -Server <CVWebserver name> -User <admin>

.EXAMPLE
    Connect-CVServer -Server <CVWebserver name> -User <admin> -Password (ConvertTo-SecureString 'password' -AsPlainText -Force)

.EXAMPLE
    Connect-CVServer -Server <CVWebserver name> -User <admin> -Password (ConvertTo-SecureString 'password' -AsPlainText -Force) -Port [port]

.EXAMPLE
    $Credential= New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList 'admin',('plainTextPassword' | ConvertTo-SecureString -AsPlainText -Force)
    Connect-CVServer -Credential $Credential -Server <CVWebserver name>

.OUTPUTS
    Outputs <String> indicating success or failure of login attempt.

.NOTES
    Author: Gary Stoops
    Company: Commvault
#>
    [CmdletBinding(DefaultParameterSetName = 'Default')]
    Param (
        [Parameter(Mandatory = $True)]
        [ValidateNotNullorEmpty()]
        [String] $Server,

        [Parameter(Mandatory = $False, ParameterSetName = 'Default')]
        [ValidateNotNullorEmpty()]
        [String] $User,

        [Parameter(Mandatory = $False, ParameterSetName = 'Default')]
        [SecureString] ${Password},

        [Alias('PSCreds')]
        [Parameter(ParameterSetName = 'PSCredential')]
        [ValidateNotNull()]
        [PSCredential]
        [Credential()]
        $Credential = [PSCredential]::Empty        
    )
    
    begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"

        try {
            if ($Credential -ne [PSCredential]::Empty) {
                Write-Debug -Message "$($MyInvocation.MyCommand): extracting password from PSCredential object"
                $User = $Credential.UserName
                $Password = $Credential.Password
            }
            
            if ([String]::IsNullOrEmpty($User)) {
                $User = Read-Host 'User'
                if ($User.Length -eq 0) {
                    $errorRecord = New-Object ErrorRecord (
                        (New-Object Exception $CVPS_ERROR_ID.1000),
                        'CVPS_ERROR_ID.1000',
                        [ErrorCategory]::OperationStopped,
                        $User
                        )
                        throw $errorRecord
                }
            }
            
            if ($null -eq $Password -or $Password.Length -eq 0) {
                $Password = Read-Host 'Password' -AsSecureString
                if ($Password.Length -eq 0) {
                    $errorRecord = New-Object ErrorRecord (
                        (New-Object Exception $CVPS_ERROR_ID.1001),
                        'CVPS_ERROR_ID.1001',
                        [ErrorCategory]::OperationStopped,
                        $Password
                        )
                        throw $errorRecord
                }
            }
        }
        catch {
            $PSCmdlet.ThrowTerminatingError($_) 
        }
    }
        
    process { Write-Debug -Message "$($MyInvocation.MyCommand): process"

        try {
            $response = (GetSessionToken $Server $User $Password)

            if ($response.IsValid) {
                Write-Verbose $response.Content
                [System.Environment]::SetEnvironmentVariable('CVToken', $response.Content.token)
                $baseUrl = (PrepareBaseUrlForLogin $Server)
                [System.Environment]::SetEnvironmentVariable('WebServerUrl', $baseUrl)

                # $global:CVConnectionPool = @{
                #     server = $Server
                #     token  = $response.Content.token
                #     user   = $User
                # }
        
                # $global:CVConnectionPool.GetEnumerator() | Where-Object -FilterScript {
                #     $_.name -notmatch 'token' | Out-Null
                # }
            }
            else {
                if (HasProperty $response 'Content') {
                    Write-Host $response.Content
                    if (HasProperty $response.Content 'errList') {
                        Write-Host $response.Content.errList[0]
                    }
                }
            }
        }
        catch {
            $PSCmdlet.ThrowTerminatingError($_) 
        }
    }

    end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
    }
}


function Connect-CVCloud {
<#
.SYNOPSIS
    Method to get authorization token for Metallic Cloud.

.DESCRIPTION
    Method to get authorization token for Metallic Cloud.

.PARAMETER User
    User name for login.

.PARAMETER Password
    Secure password for login.

.PARAMETER isServicePrinciple
    Boolean flag to set if the credentials that is being tried is of service principle (Lighthouse)

.EXAMPLE
    Connect-CVCloud -User "username" -Password "password"

.OUTPUTS
    Outputs <String> indicating success or failure of login attempt.

.NOTES
    Author: Jnanesh D
    Company: Commvault
#>
    [CmdletBinding()]
    Param (
        [Parameter(Mandatory = $True)]
        [ValidateNotNullorEmpty()]
        [String] $User,

        [Parameter(Mandatory = $True)]
        [SecureString] $Password,

        [Parameter(Mandatory = $False)]
        [Boolean] $isServicePrinciple = $True,

        [Parameter(Mandatory = $False)]
        [String] $GatewayUrl = "https://api.commvault.com"
    )
    
    begin {
        Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    }
        
    process {
        Write-Debug -Message "$($MyInvocation.MyCommand): process"

        try {
            $server = 'https://apigateway-qa1.commvault.com'
            $response = (GetSessionToken $server $User $Password $isServicePrinciple)

            if ($response.IsValid) {
                [System.Environment]::SetEnvironmentVariable('CVToken', $response.Content.data.authToken)
                [System.Environment]::SetEnvironmentVariable('WebServerUrl', $server)
            }
            else {
                if (HasProperty $response 'Content') {
                    Write-Host $response.Content
                    if (HasProperty $response.Content 'errList') {
                        Write-Host $response.Content.errList[0]
                    }
                }
                else {
                    Write-Host "Login to cloud failed"
                }
            }
        }
        catch {
            $PSCmdlet.ThrowTerminatingError($_) 
        }
    }

    end {
        Write-Debug -Message "$($MyInvocation.MyCommand): end"
    }
}



function GetSessionToken {
    [CmdletBinding()]
    [OutputType([PSCustomObject])]
    param (
        [Parameter(Mandatory = $True)]
        [ValidateNotNullorEmpty()]
        [String] $Server,

        [Parameter(Mandatory = $True)]
        [ValidateNotNullorEmpty()]
        [String] $User,

        [Parameter(Mandatory = $True)]
        [ValidateNotNullorEmpty()]
        [SecureString] $SecurePassword,

        [Parameter(Mandatory = $False)]
        [ValidateNotNullorEmpty()]
        [Boolean] $isServicePrinciple
    )

    begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"

        try {

            # If server url contains metallic validate should be data
            if ($Server -like "*metallic*") {
                $validateProperty = 'data'
            }            
            else{
                $validateProperty = 'token'
            }
            
            [PSCustomObject] $output = New-Object PSObject
            $output | Add-Member -NotePropertyName 'IsValid' -NotePropertyValue ([String]::IsNullOrEmpty($validateProperty))
        }
        catch {
            throw $_
        }
    }

    process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
        try {
            $method = 'Post'
            $endpoint = 'Login'
            $header = @{Accept = 'application/json'}
            if ($isServicePrinciple -eq $True)
            {
                $encodedPassword = ConvertFromSecureString($SecurePassword)
            }
            else {
                $encodedPassword = ConvertToBase64String(ConvertFromSecureString($SecurePassword))

            }
            $creds = @{ 
                password = $encodedPassword
                username = $User
            }
            $body = (ConvertTo-Json $creds)
            $baseUrl = (PrepareBaseUrlForLogin $Server)
            $response = (ProcessRequest $header $body $baseUrl $endpoint $method)
            # This should be removed afterwards
            ValidateResponse $response $output $ValidateProperty
            Write-Output $output
        }
        catch {
            throw $_
        }
    }

    end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
    }
}


function  PrepareBaseUrlForLogin ([String] $Server) {
    
    try {
        #$prefix =  $REST_AUTH_URL_PREFIX_SECURE
        if ($server.ToLower().Contains("http"))
        {
            Write-Output $server
        }
        else{
            $prefix = $REST_AUTH_URL_PREFIX
            $url = $prefix + $REST_BASE_URL
            
            #Remove whitespace
            $Server = $Server -split '\s+'
            Write-Output ($url.Replace("Server", $Server)).Replace(" ", "")
    
        }
    }
    catch {
        throw $_
    }
}
function ConvertFromSecureString ([SecureString] $SecureString) {
    
    try {
        if ($null -ne $SecureString) {
            $BSTR = [System.Runtime.InteropServices.Marshal]::SecureStringToBSTR($SecureString)
            Write-Output ([System.Runtime.InteropServices.Marshal]::PtrToStringAuto($BSTR))
        }
    }
    catch {
        throw $_
    }
}


function ConvertToBase64String ([String] $PlainText) {
    
    try {
        if ($null -ne $PlainText) {
            Write-Output ([convert]::ToBase64String([Text.Encoding]::UTF8.GetBytes($PlainText)))
        }
    }
    catch {
        throw $_
    }
}

function HasProperty($Object, $PropertyName)
{
    $PropertyName -in $Object.PSobject.Properties.Name
}


$REST_AUTH_URL_PREFIX = 'https://';
$REST_DEFAULT_PORT = '81';
$REST_BASE_URL = 'Server/webconsole/api';
$REST_HTTP_STATUS_CODES = @(200, 201, 202, 203, 204, 205, 206, 206, 207, 208);
$WEBCONSOLE_ENDPOINT = 'Server/Webconsole/api';

$CVPS_ERROR_ID = @{
    202  = 'REST API response [Accepted] error: The request has been received but not yet acted upon'
    1000 = 'Empty or null user name: Please provide a user name for web service login'
    1001 = 'Empty or null secure password: Please provide secure password for web service login'
    1002 = 'Invalid CommServe session token: Please login to CommServe with Connect-CVServer'
}