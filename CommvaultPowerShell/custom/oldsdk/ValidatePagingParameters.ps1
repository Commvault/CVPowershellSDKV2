function ValidatePagingParameters($PagingParameters, [UInt64] $TotalCount) {

    try {
        $pagingObj = @{ 'paging' = 0; 'pageSize' = $null; 'startPage' = $null; 'badParams' = $False }

        [UInt64] $PageSize = [Math]::Max($PagingParameters.First, 0)
        [UInt64] $StartPage = [Math]::Max($PagingParameters.Skip, 0)

        if ($PageSize -lt [Uint64]::MaxValue) { # MaxValue is system default
            if ($PageSize -gt 0 -and $PageSize -le $TotalCount) {
                if ($StartPage -lt ($TotalCount / $PageSize)) {
                    $pagingObj['paging'] = 1
                    $pagingObj['pageSize'] = $PageSize
                    $pagingObj['startPage'] = $StartPage
                }
                elseif ($StartPage -gt 0) {
                    $pagingObj['badParams'] = $True
                    Write-Warning -Message "$($MyInvocation.MyCommand): paging parameter -Skip [$StartPage] beyond end of record set"
                }
            }
            elseif ($PageSize -gt 0) {
                $pagingObj['badParams'] = $True
                Write-Warning -Message "$($MyInvocation.MyCommand): paging parameter -First [$PageSize] exceeds total record count"
            }
        }

        Write-Output $pagingObj
    }
    catch {
        throw $_
    }
}

function HasProperty($Object, $PropertyName)
{
    $PropertyName -in $Object.PSobject.Properties.Name
}