Add-AEnums
function Get-CVSQLDatabase { 
    <#
    .SYNOPSIS
        Method to retrieve SQL databases protected within the CommServe.
    .DESCRIPTION
        This method is implemented with Powershell paging support.
        If the Name parameter is not provided, this method will output all protected SQL databases.
        If the Name parameter is provided, SQL databases matching the name will be output.
        
    .PARAMETER Name
        Get SQL database specified by Name.
    .PARAMETER Id
        Get SQL database specified by database Id.
    .PARAMETER ClientName
        Get SQL databases associated with ClientName.
    .PARAMETER InstanceName
        Get SQL databases associated with InstanceName.
    .PARAMETER InstanceId
        Get SQL databases associated with InstanceId.
    .PARAMETER InstanceObject
        Get SQL databases associated with piped InstanceObject.
    .PARAMETER First
        Get SQL instances with paging support -First 20 (20 per page).
    .PARAMETER Skip
        Get SQL instances with paging support -First 20 -Skip 5 (20 per page, skip first 5 pages).
    .PARAMETER IncludeTotalCount
        Include total count of result record set.
    .PARAMETER SortColumn
        Sort SQL databases by: bkpTime, bkpSize, insName, dbName, cName, planName.
    .PARAMETER SortDescending
        Sort SQL databases by specified column in descending order; Default is ascending order.
    .PARAMETER OnlySLA
        Get only SQL databases with missed SLAs.
    .PARAMETER ShowSysDB
        Get SQL databases including system databases.
    .PARAMETER AllProperties
        Get SQL databases with all properties.
    .EXAMPLE
        Get-CVSQLDatabase
    .EXAMPLE
        Get-CVSQLInstance | Get-CVSQLDatabase
    .EXAMPLE
        Get-CVClient | Get-CVSQLInstance | Get-CVSQLDatabase
    .EXAMPLE
        Get-CVSQLDatabase -IncludeTotalCount -First 20 -Skip 5 (20 per page, skip first 5 pages)
    .EXAMPLE
        Get-CVSQLDatabase -OnlySLA
    .EXAMPLE
        Get-CVSQLDatabase -Name space-end
    .EXAMPLE
        Get-CVSQLDatabase -Name space_end
    .EXAMPLE
        Get-CVSQLDatabase -SortColumn bkpSize
    .EXAMPLE
        Get-CVSQLDatabase -SortColumn bkpSize -SortDescending
    .EXAMPLE
        Get-CVSQLDatabase -AllProperties
    .OUTPUTS
        Outputs [PSCustomObject] containing SQL database properties.
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
            
            [Parameter(Mandatory = $False, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $Id,
            
            [Parameter(Mandatory = $False, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $InstanceName,
            
            [Parameter(Mandatory = $False, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $InstanceId,
            
            [Parameter(Mandatory = $False, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $InstanceObject,
            
            [Parameter(Mandatory = $False)]
            [CVSQLDatabaseSortColumn] $SortColumn = 'dbName', # by what column the result should be sorted
    
            [Switch] $SortDescending,
            [Switch] $OnlySLA, # limit response to databases with missed SLA
            [Switch] $ShowSysDB,
            [Switch] $AllProperties
            <#
            [Parameter(Mandatory = $False, Position = 0)]
            [ValidateNotNullorEmpty()]
            [Int32] $ToTime,
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $SearchTerm
            #>
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
    
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    if ($Id -gt 0) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{databaseId}', $Id) }
                    if ($InstanceId -gt 0) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $InstanceId) }
                }
                if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    if (-not [String]::IsNullOrEmpty($ClientName)) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientName}', $ClientName) }
                    if (-not [String]::IsNullOrEmpty($InstanceName)) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceName}', $InstanceName) }
                    if (-not [String]::IsNullOrEmpty($Name)) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{databaseName}', $Name) }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByObject') {
                    if ($null -ne $InstanceObject) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $InstanceObject.insId) }
                }
                
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{paging}', 1)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{startPage}', 0)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{pageSize}', 0)
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{sortBy}', $SortColumn)
    
                if ($SortDescending) { 
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{sortDir}', 'DESC') 
                }
                else {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{sortDir}', 'ASC') 
                }
    
                if ($OnlySLA) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{onlySLA}', 1) } 
                if ($ShowSysDB) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{showSysDB}', 1) }
                if ($AllProperties) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{propertyLevel}', 11) }
    
                $sessionObj.requestProps.endpoint = NullifyGetSQLDatabaseEndpointParams -Endpoint $sessionObj.requestProps.endpoint
                
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
        
                        if ($PSCmdlet.ParameterSetName -eq 'ById') {
                            if ($Id -gt 0) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{databaseId}', $Id) }
                            if ($InstanceId -gt 0) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $InstanceId) }
                        }
                        if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                            if (-not [String]::IsNullOrEmpty($ClientName)) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientName}', $ClientName) }
                            if (-not [String]::IsNullOrEmpty($InstanceName)) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceName}', $InstanceName) }
                            if (-not [String]::IsNullOrEmpty($Name)) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{databaseName}', $Name) }
                        }
                        elseif ($PSCmdlet.ParameterSetName -eq 'ByObject') {
                            if ($null -ne $InstanceObject) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $InstanceObject.insId) }
                        }
                        
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{paging}', $pagingObj.paging)
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{startPage}', $pagingObj.startPage)
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{pageSize}', $pagingObj.pageSize)
                        if ($pagingObj.paging) { $pagingObj.startPage++ }
        
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{sortBy}', $SortColumn)
        
                        if ($SortDescending) { 
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{sortDir}', 'DESC') 
                        }
                        else {
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{sortDir}', 'ASC') 
                        }
        
                        if ($OnlySLA) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{onlySLA}', 1) } 
                        if ($ShowSysDB) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{showSysDB}', 1) }
                        if ($AllProperties) { $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{propertyLevel}', 11) }
            
                        $sessionObj.requestProps.endpoint = NullifyGetSQLDatabaseEndpointParams -Endpoint $sessionObj.requestProps.endpoint
        
                        $headerObj = Get-CVRESTHeader $sessionObj
                        $body = ''
                        $payload = @{}
                        $payload.Add('headerObject', $headerObj)
                        $payload.Add('body', $body)
                        $validate = 'SqlDatabase'
        
                        $response = Submit-CVRESTRequest $payload $validate
            
                        if ($response.IsValid) {
                            foreach ($database in $response.Content.SqlDatabase) {
                                Write-Output $database
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
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no SQL databases found for instance [$($InstanceObject.insName)]"      
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
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no SQL databases found with missed SLA"      
                    }
                    else {
                        if ($PSCmdlet.ParameterSetName -eq 'ById') {
                            if ($Id -gt 0) {
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): database not found having ID [$Id]"      
                            }
                            elseif ($InstanceId -gt 0) {
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no SQL databases found for instance ID [$InstanceId]"      
                            }
                        }
                        elseif ($PSCmdlet.ParameterSetName -eq 'ByName') {
                            if (-not [String]::IsNullOrEmpty($Name)) {
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): database not found having name [$Name]"      
                            }
                            elseif (-not [String]::IsNullOrEmpty($InstanceName)) {
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no SQL databases found for instance [$InstanceName]"      
                            }
                            elseif (-not [String]::IsNullOrEmpty($ClientName)) {
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no SQL databases found for client [$ClientName]"      
                            }
                        }
                        elseif ($PSCmdlet.ParameterSetName -ne 'ByObject') {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no SQL databases found"      
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
    