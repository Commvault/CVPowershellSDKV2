Add-AEnums
function New-CVBucketforCloudStorage {
    <#
    .Synopsis
        Create new Bucket for Cloud storage 
    .Description
        Create new Bucket for Cloud storage 
    .Parameter Properties
        Hashtable containing the properties of the Cloud Storage. Please refer to the swagger documentation for the payload structure : URL /V4/Storage/Cloud/{cloudStorageId}/Bucket
    .Parameter cloudStorageId
        Id of the cloud storage 
    #>
    [OutputType([PSCustomObject])]
    param(
        [Parameter(Mandatory=$True)]
        [ValidateNotNullorEmpty()]
        [Hashtable] $Properties,

        [Parameter(Mandatory=$True)]
        [ValidateNotNullorEmpty()]
        [Int64] $cloudStorageId
        )
    begin {Write-Debug "$($MyInvocation.MyCommand): begin"
        try{
            $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
            $endpointSave = $sessionObj.requestProps.endpoint
            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{cloudStorageId}', $cloudStorageId)
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
            $Properties = ConvertTo-Json $Properties -Depth 10
            $payload.Add('body', $Properties)

            $response = Submit-CVRESTRequest $payload 

            Write-Output $response.Content
        }
    
        catch {
            throw $_
        }
    }
}