function Get-CVRESTHeader {
    [CmdletBinding(DefaultParameterSetName = 'Default')]
    [OutputType([HashTable])]
    param (
        [Parameter(Position = 0, Mandatory = $True)]
        [ValidateNotNullorEmpty()]
        [HashTable] $SessionObject,

        [Parameter(Mandatory = $False, ParameterSetName = 'ByPagingInfo')]
        [ValidateNotNullorEmpty()]
        [String] $PagingInfo,

        [Parameter(Mandatory = $False, ParameterSetName = 'ByLimit')]
        [ValidateNotNullorEmpty()]
        [uint64] $Limit,

        [Parameter(Mandatory = $False, ParameterSetName = 'ByLimit')]
        [ValidateNotNullorEmpty()]
        [uint64] $Offset
    )

    begin { 
        Write-Debug -Message "$($MyInvocation.MyCommand): begin"

        try {
            $output = @{
                method = $SessionObject.requestProps.method
                baseUrl = $SessionObject.server
                endpoint = $SessionObject.requestProps.endpoint
            }
        }
        catch {
            throw $_
        }
    }

    process { 
        Write-Debug -Message "$($MyInvocation.MyCommand): process"

        try {
            $header = @{}

            if ($SessionObject.requestProps.ContainsKey('ContentType')) {
                $header.Add("Accept", $SessionObject.requestProps.ContentType)
            }
            else {
                $header.Add("Accept", 'application/json')
            }

            if ($SessionObject.server -like '*metallic*') {
                $header.Add("Authorization", 'Bearer ' + $SessionObject.sessionToken)
            }
            else {
                $header.Add("Authtoken", $SessionObject.sessionToken)
            }

            if ($PSCmdlet.ParameterSetName -eq 'ByPagingInfo') {
                $header.Add("pagingInfo", $PagingInfo)
            }
            elseif ($PSCmdlet.ParameterSetName -eq 'ByLimit') {
                $header.Add("limit", $Limit)
                $header.Add("offset", $Offset)
            }

            $output.Add("header", $header)
        }
        catch {
            throw $_
        }
        finally {
            Write-Output $output
        }
    }

    end { 
        Write-Debug -Message "$($MyInvocation.MyCommand): end"
    }
}
