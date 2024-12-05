function Submit-CVRESTRequest {
    [CmdletBinding()]
    [OutputType([PSCustomObject])]
    param (
        [Parameter(Mandatory = $True)]
        [ValidateNotNullorEmpty()]
        [HashTable] $Payload,

        [Parameter(Mandatory = $False)]
        [String] $ValidateProperty,

        [Switch] $DryRun
    )

    begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"

        try {
            [PSCustomObject] $output = New-Object PSObject
            $output | Add-Member -NotePropertyName 'IsValid' -NotePropertyValue ([String]::IsNullOrEmpty($ValidateProperty))
        }
        catch {
            throw $_
        }
    }

    process { Write-Debug -Message "$($MyInvocation.MyCommand): process"

        try {

            # Metallic API gateway needs lhAccountId if user if a service principle or MSP admin 
            $envLhAccountId = [System.Environment]::GetEnvironmentVariable("lhAccountId")
            if ($envLhAccountId) {
                if (-not $Payload.headerObject.header.ContainsKey('lhAccountId')) {
                    $Payload.headerObject.header.Add('lhAccountId', $envLhAccountId)
                    Write-Debug -Message "$($MyInvocation.MyCommand): Added lhAccountId to headers from environment variable: $envLhAccountId"
                }
            }

            $Payload.headerObject.header.GetEnumerator() | Foreach-Object { 
                if ($_.Key -eq 'Authtoken') {
                    Write-Debug -Message "$($MyInvocation.MyCommand): header: $($_.Key): QSDK..." 
                }
                else {
                    Write-Debug -Message "$($MyInvocation.MyCommand): header: $($_.Key): $($_.Value)" 
                }
            }    

            if ($DryRun) {
                if ($Payload.body.Length -gt 0) { Write-Host "$($MyInvocation.MyCommand): body:`n $($Payload.body)" }
                else { Write-Host "$($MyInvocation.MyCommand): body: $($Payload.body)" }
                Write-Host "$($MyInvocation.MyCommand): baseUrl: $($Payload.headerObject.baseUrl)"      
                Write-Host "$($MyInvocation.MyCommand): endpoint: $($Payload.headerObject.endpoint)"      
                Write-Host "$($MyInvocation.MyCommand): method: $($Payload.headerObject.method)"      
            }
            else {
                if ($Payload.body.Length -gt 0) { Write-Debug -Message "$($MyInvocation.MyCommand): body:`n $($Payload.body)" }
                else { Write-Debug -Message "$($MyInvocation.MyCommand): body: $($Payload.body)" }
                Write-Debug -Message "$($MyInvocation.MyCommand): baseUrl: $($Payload.headerObject.baseUrl)"      
                Write-Debug -Message "$($MyInvocation.MyCommand): endpoint: $($Payload.headerObject.endpoint)"      
                Write-Debug -Message "$($MyInvocation.MyCommand): method: $($Payload.headerObject.method)" 
                if (-not $Payload.headerObject.ContainsKey('ContentType')) {
                    $response = (ProcessRequest $Payload.headerObject.header $Payload.body $Payload.headerObject.baseUrl $Payload.headerObject.endpoint $Payload.headerObject.method)
                }
                else {
                    $response = (ProcessRequest $Payload.headerObject.header $Payload.body $Payload.headerObject.baseUrl $Payload.headerObject.endpoint $Payload.headerObject.method $Payload.headerObject.ContentType)
                }

                ValidateResponse $response $output $ValidateProperty
            }
        }
        catch {
            throw $_
        }
        finally {
            Write-Output $output
        }
    }

    end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
    }
}
