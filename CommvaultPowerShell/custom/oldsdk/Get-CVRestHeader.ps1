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

    begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"

        try {
            $output = @{ }
        }
        catch {
            throw $_
        }
    }

    process { Write-Debug -Message "$($MyInvocation.MyCommand): process"

        try {
            
            if ($PSCmdlet.ParameterSetName -eq 'Default') {
                if ($SessionObject.requestProps.ContainsKey('ContentType')) {
                    $output.Add("header", @{Accept = $SessionObject.requestProps.ContentType; Authtoken = $SessionObject.sessionToken })
                }
                else {
                    $output.Add("header", @{Accept = 'application/json'; Authtoken = $SessionObject.sessionToken })
                }
            }
            elseif ($PSCmdlet.ParameterSetName -eq 'ByPagingInfo') { # paging support with pagingInfo header '{startPage},{pageSize}'
                if ($SessionObject.requestProps.ContainsKey('ContentType')) {
                    $output.Add("header", @{Accept = $SessionObject.requestProps.ContentType; Authtoken = $SessionObject.sessionToken; pagingInfo = $PagingInfo })
                }
                else {
                    $output.Add("header", @{Accept = 'application/json'; Authtoken = $SessionObject.sessionToken; pagingInfo = $PagingInfo })
                }
            }
            elseif ($PSCmdlet.ParameterSetName -eq 'ByLimit') { # paging support with limit/offset header combo
                if ($SessionObject.requestProps.ContainsKey('ContentType')) {
                    $output.Add("header", @{Accept = $SessionObject.requestProps.ContentType; Authtoken = $SessionObject.sessionToken; limit = $Limit; offset = $Offset })
                }
                else {
                    $output.Add("header", @{Accept = 'application/json'; Authtoken = $SessionObject.sessionToken; limit = $Limit; offset = $Offset })
                }
            }
            
            if ($SessionObject.requestProps.ContainsKey('ContentType')) {
                $output.Add("ContentType", $SessionObject.requestProps.ContentType)
            }

            $output.Add("method", $SessionObject.requestProps.method)
            $output.Add("endpoint", $SessionObject.requestProps.endpoint)
                
            $baseUrl = $SessionObject.server
            $output.Add("baseUrl", $baseUrl)
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