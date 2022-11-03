Add-AEnums
function Get-CVSQLInstance { 
    <#
    .SYNOPSIS
        Method to retrieve SQL instances protected within the CommServe.
    .DESCRIPTION
        This method is implemented with Powershell paging support.
        If the Name parameter is not provided, this method will output all protected SQL instances.
        If the Name parameter is provided, SQL instances matching the name will be output.
        
    .PARAMETER Name
        Get SQL instance specified by Name.
    .PARAMETER ClientName
        Get SQL instances associated with ClientName.
    .PARAMETER ClientObject
        Get SQL instances associated with piped ClientObject.
    .PARAMETER First
        Get SQL instances with paging support -First 20 (20 per page).
    .PARAMETER Skip
        Get SQL instances with paging support -First 20 -Skip 5 (20 per page, skip first 5 pages).
    .PARAMETER IncludeTotalCount
        Include total count of result record set.
    .PARAMETER OnlySLA
        Get only SQL instances with missed SLAs.
    .PARAMETER SortColumn
        Sort SQL instances by: insId, insName, version, cName, noDBs, or planName.
    .PARAMETER SortDescending
        Sort SQL instances by specified column in descending order; default is ascending order.
    .PARAMETER AllProperties
        Get SQL instances with all properties.
    .EXAMPLE
        Get-CVSQLInstance
        
    .EXAMPLE
        Get-CVClient | Get-CVSQLInstance
        
    .EXAMPLE
        Get-CVSQLInstance -IncludeTotalCount -First 20 -Skip 5 (20 per page, skip first 5 pages)
        
    .EXAMPLE
        Get-CVSQLInstance -OnlySLA
        
    .EXAMPLE
        Get-CVSQLInstance -Name SNOWSQL1\SQL2008R2
        
    .EXAMPLE
        Get-CVSQLInstance -SortColumn noDBs
        
    .EXAMPLE
        Get-CVSQLInstance -SortColumn insId -SortDescending
        
    .EXAMPLE
        Get-CVSQLInstance -AllProperties
        
    .EXAMPLE
        Get-CVSQLInstance -AllProperties | Select-Object -ExpandProperty auth
        
    .EXAMPLE
        Get-CVSQLInstance -AllProperties | Select-Object -ExpandProperty auth | Select-Object -ExpandProperty credential
    .OUTPUTS
        Outputs [PSCustomObject] containing SQL instance properties.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'Default', SupportsPaging = $True)]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $False, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $ClientObject,
    
            [Parameter(Mandatory = $False)]
            [CVSQLInstanceSortColumn] $SortColumn = 'insId', #  by what column the result should be sorted
    
            [Switch] $SortDescending,
            [Switch] $OnlySLA, # limit response to instances with missed SLA
            [Switch] $AllProperties
        )
    
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                $endpointSave = $sessionObj.requestProps.endpoint
                $outputCount = 0
                $totalCount = 0
            }
            catch {
                throw $_
            }
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
    
            try
            {
                # Get total record count first
                $sessionObj.requestProps.endpoint = $endpointSave
    
                if ($AllProperties) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{propertyLevel}', 11) }
                
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{paging}', 1)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{startPage}', 0)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{pageSize}', 0)
    
                if ($OnlySLA) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{onlySLA}', 1) } 
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{sortBy}', $SortColumn)
    
                if ($SortDescending) { 
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{sortDir}', 'DESC') 
                }
                else {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{sortDir}', 'ASC') 
                }
    
                if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    if (-not [String]::IsNullOrEmpty($Name)) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceName}', $Name) }
                    if (-not [String]::IsNullOrEmpty($ClientName)) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientName}', $ClientName) }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByObject') {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientName}', $ClientObject.clientName)
                }
                
                $sessionObj.requestProps.endpoint = NullifyGetSQLInstanceEndpointParams -Endpoint $sessionObj.requestProps.endpoint
                
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{}
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'response'
    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    $totalCount = $response.Content.response.total
                    $pagingObj = ValidatePagingParameters $PSCmdlet.PagingParameters $totalCount
                }
                
                if ($totalCount -gt 0 -and -not $pagingObj.badParams) {
                    do {
                        $sessionObj.requestProps.endpoint = $endpointSave
        
                        if ($AllProperties) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{propertyLevel}', 11) }
                        
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{paging}', $pagingObj.paging)
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{startPage}', $pagingObj.startPage)
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{pageSize}', $pagingObj.pageSize)
                        if ($pagingObj.paging) { $pagingObj.startPage++ }
        
                        if ($OnlySLA) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{onlySLA}', 1) } 
        
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{sortBy}', $SortColumn)
        
                        if ($SortDescending) { 
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{sortDir}', 'DESC') 
                        }
                        else {
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{sortDir}', 'ASC') 
                        }
        
                        if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                            if (-not [String]::IsNullOrEmpty($Name)) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceName}', $Name) }
                            if (-not [String]::IsNullOrEmpty($ClientName)) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientName}', $ClientName) }
                        }
                        elseif ($PSCmdlet.ParameterSetName -eq 'ByObject') {
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientName}', $ClientObject.clientName)
                        }
                        
                        $sessionObj.requestProps.endpoint = NullifyGetSQLInstanceEndpointParams -Endpoint $sessionObj.requestProps.endpoint
        
                        $headerObj = Get-CVRESTHeader $sessionObj
                        $body = ''
                        $payload = @{}
                        $payload.Add('headerObject', $headerObj)
                        $payload.Add('body', $body)
                        $validate = 'SqlInstance'
        
                        $response = Submit-CVRESTRequest $payload $validate
                
                        if ($response.IsValid) {
                            foreach ($instance in $response.Content.SqlInstance) {
                                Write-Output $instance
                                $outputCount++
                            }
            
                            if ($pagingObj.paging) {
                                if (($pagingObj.startPage * $pagingObj.pageSize) -ge $totalCount) {
                                    $pagingObj.paging = 0
                                }
                                else {
                                    Read-Host '[Enter] for next page'
                                }
                            }
                        }
                        else {
                            $pagingObj.paging = 0
                        }
                    } until (-not $pagingObj.paging)
                }
    
                if ($outputCount -eq 0) {
                    if ($PSCmdlet.ParameterSetName -eq 'ByObject') {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no SQL instances found for client [$($ClientObject.ClientName)]"      
                    }
                }
            }
            catch
            {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
    
            try {
                if ($PSCmdlet.PagingParameters.IncludeTotalCount) {
                    [double] $accuracy = 1.0
                    $PSCmdlet.PagingParameters.NewTotalCount($totalCount, $accuracy)
                }
    
                if ($outputCount -eq 0) {
                    if ($OnlySLA) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no SQL instances found with missed SLA"      
                    }
                    else {
                        if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                            if (-not [String]::IsNullOrEmpty($Name)) {
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): instance not found having name [$Name]"      
                            }
                            elseif (-not [String]::IsNullOrEmpty($ClientName)) {
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no SQL instances found for client [$ClientName]"      
                            }
                        }
                        elseif ($PSCmdlet.ParameterSetName -ne 'ByObject') {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no SQL instances found"      
                        }
                    }
                }
            }
            catch {
                throw $_
            }
        }
    }

    function NullifyGetSQLDatabaseEndpointParams([String]$Endpoint) {

        try {
            $Endpoint = $Endpoint -creplace ('{paging}', $null)
            $Endpoint = $Endpoint -creplace ('{startPage}', $null)
            $Endpoint = $Endpoint -creplace ('{pageSize}', $null)
            $Endpoint = $Endpoint -creplace ('{clientName}', $null)
            $Endpoint = $Endpoint -creplace ('{instanceName}', $null)
            $Endpoint = $Endpoint -creplace ('{instanceId}', $null)
            $Endpoint = $Endpoint -creplace ('{databaseName}', $null)
            $Endpoint = $Endpoint -creplace ('{databaseId}', $null)
            $Endpoint = $Endpoint -creplace ('{sortBy}', $null)
            $Endpoint = $Endpoint -creplace ('{sortDir}', $null) 
            $Endpoint = $Endpoint -creplace ('{toTime}', $null)
            $Endpoint = $Endpoint -creplace ('{searchTerm}', $null)
            $Endpoint = $Endpoint -creplace ('{onlySLA}', $null)
            $Endpoint = $Endpoint -creplace ('{showSysDB}', $null)
            $Endpoint = $Endpoint -creplace ('{propertyLevel}', $null)
    
            Write-Output $Endpoint
        }
        catch {
            throw $_
        }
    }
    
    
    function NullifyGetSQLInstanceEndpointParams([String]$Endpoint) {
    
        try {
            $Endpoint = $Endpoint -creplace ('{paging}', $null)
            $Endpoint = $Endpoint -creplace ('{startPage}', $null)
            $Endpoint = $Endpoint -creplace ('{pageSize}', $null)
            $Endpoint = $Endpoint -creplace ('{propertyLevel}', $null)
            $Endpoint = $Endpoint -creplace ('{onlySLA}', $null)
            $Endpoint = $Endpoint -creplace ('{sortBy}', $null)
            $Endpoint = $Endpoint -creplace ('{sortDir}', $null) 
            $Endpoint = $Endpoint -creplace ('{searchTerm}', $null)
            $Endpoint = $Endpoint -creplace ('{instanceName}', $null)
            $Endpoint = $Endpoint -creplace ('{clientName}', $null)
            
            Write-Output $Endpoint
        }
        catch {
            throw $_
        }
    }