Add-AEnums;
function Get-CVAlert {
    <#
    .SYNOPSIS
        Method to retrieve the list of alerts from the CommServe.
    .DESCRIPTION
        Method to retrieve the list of alerts from the CommServe.
        This method is implemented with Powershell paging support.
    .PARAMETER First
        Get alerts with paging support -First 20 (20 per page).
    .PARAMETER Skip
        Get alerts with paging support -First 20 -Skip 5 (20 per page, skip first 5 pages).
    .PARAMETER IncludeTotalCount
        Include total count of result record set.
    .EXAMPLE
        Get-CVAlert
        
    .EXAMPLE
        Get-CVAlert -IncludeTotalCount -First 5 -Skip 0 (5 per page, skip none)
    .OUTPUTS
        Outputs [PSCustomObject] containing CommServe alert data.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(SupportsPaging = $True)]
        [OutputType([PSCustomObject])]
        param()
        
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                $endpointSave = $sessionObj.requestProps.endpoint
            }
            catch {
                throw $_
            }
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
    
            try {
                $sessionObj.requestProps.endpoint = $endpointSave
    
                $body = ''
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'AlertList'
    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    $pagingObj = ValidatePagingParameters $PSCmdlet.PagingParameters $response.Content.AlertList.Length
                    if ($pagingObj.paging) {
                        $curPage = $pagingObj.startPage + 1
    
                        if ($pagingObj.startPage -eq 0) { $index = 0 }
                        else { $index = ($pagingObj.startPage * $pagingObj.pageSize) }
    
                        for (; $index -lt $response.Content.AlertList.Length; $index++) {
                            Write-Output $response.Content.AlertList[$index]
    
                            if ($index -eq $response.Content.AlertList.Length - 1) {
                                break
                            }
                            elseif ($index -eq (($curPage * $pagingObj.pageSize) - 1)) {
                                $curPage++
                                Read-Host '[Enter] for next page'
                            }
                        }
                    }
                    elseif (-not $pagingObj.badParams) {
                        foreach ($alert in $response.Content.AlertList) {
                            Write-Output $alert
                        }
                    }
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): alert list empty"
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
    
            try {
                if ($PSCmdlet.PagingParameters.IncludeTotalCount) {
                    [double] $accuracy = 1.0
                    $PSCmdlet.PagingParameters.NewTotalCount($response.Content.AlertList.Length, $accuracy)
                }
            }
            catch {
                throw $_
            }
        }
    }

    # Internal use: takes $PSCmdlet.PagingParameters and returns a hashtable paging flag, page size, and page start index
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
