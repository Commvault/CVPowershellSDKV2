Add-AEnums
function New-CVReplicationGroup{
    <#
    .Synopsis
        Create a replication group
    .Description
        Create a replication group
    .Parameter Properties
        Hashtable containing the properties of the Replication Group . Please refer to the swagger documentation for the payload structure PATH /V4/ReplicationGroup
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