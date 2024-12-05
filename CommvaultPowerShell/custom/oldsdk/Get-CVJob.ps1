Add-AEnums
function Get-CVJob {
    <#
    .SYNOPSIS
        Get list of jobs from the CommServe.
    
    .DESCRIPTION
        Get the list of all jobs. Based on parameters this commandlet filters the output.
        This method is implemented with Powershell paging support.
    
    .PARAMETER ClientName
        Filter output based on ClientName.
    
    .PARAMETER SubclientName
        Filter output based on SubclientName: requires ClientName parameter.
        
    .PARAMETER JobFilter
        Filter output based on JobFilter. Example Snapbackup, DATA_VERIFICATION or SYNTHFULL etc.
        
    .PARAMETER JobCategory
        Filter output based on JobCategory. Example Active, Finished, All.
    
    .PARAMETER CompletedTime
        Filter output based on completed job lookup time expressed in hours.
    
    .PARAMETER Details
        Retrieves the details for a job.
    
    .PARAMETER limit
        The number of results to be listed in a page. Used for changing the paging limits. By default, the limit is 100 results per page.
    
    .PARAMETER First
        Get list of jobs with paging support -First 20 (20 per page).
    
    .PARAMETER Skip
        Get list of jobs with paging support -First 20 -Skip 5 (20 per page, skip first 5 jobs).
    
    .PARAMETER IncludeTotalCount
        Include total count of result record set.
    
    .EXAMPLE
        Get-CVJob
    
    .EXAMPLE
        Get-CVJob -CompletedTime 8 -IncludeTotalCount
        
    .EXAMPLE
        Get-CVJob -CompletedTime 72 -IncludeTotalCount -First 5    
    
    .EXAMPLE
        Get-CVJob -CompletedTime 240 -IncludeTotalCount -First 10 -Skip 0    
    
    .EXAMPLE
        Get-CVJob -CompletedTime 240 -IncludeTotalCount -First 10 -Skip 20
        
    .EXAMPLE
        Get-CVJob -Details
        
    .EXAMPLE
        Get-CVJob -ClientName VC2KR2
    
    .EXAMPLE
        Get-CVJob -ClientName VC2KR2 -SubclientName snap_backup2 -CompletedTime 72
    
    .EXAMPLE
        Get-CVJob | Where-Object { $_.Status -like 'Running' }
    
    .EXAMPLE
        Get-CVJob | Where-Object { $_.Status -like 'Pending' }
    
    .EXAMPLE
        Get-CVJob | Where-Object { $_.Status -like 'Waiting' }
    
    .EXAMPLE
        Get-CVJob | Where-Object { $_.Status -like 'Completed' }
    
    .OUTPUTS
        Outputs [PSCustomObject] containing job details.
    
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(SupportsPaging = $True, DefaultParameterSetName = 'Default')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $False, ParameterSetName = 'ById', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int32] $Id,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'Default')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'Default')]
            [ValidateNotNullorEmpty()]
            [String] $SubclientName,
    
            [Alias('Filter')]
            [Parameter(Mandatory = $False, ParameterSetName = 'Default')]
            [ValidateNotNullorEmpty()]
            [String] $JobFilter,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'Default')]
            [ValidateNotNullorEmpty()]
            [String] $JobCategory,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'Default')]
            [ValidateNotNullorEmpty()]
            [Int32] $CompletedTime = 24, # default 24 hours
    
            [Parameter(Mandatory = $False, ParameterSetName = 'Default')]
            [ValidateNotNullorEmpty()]
            [Int32] $limit = 100,
    
            [Switch] $Details
        )
        
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $sessionObj = Get-CVSessionDetail 'GetJobById'
                }
                else {
                    $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                }
                $endpointSave = $sessionObj.requestProps.endpoint
                $subclientId = $null
            }
            catch {
                throw $_
            }
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
    
            try 
            {
                $sessionObj.requestProps.endpoint = $endpointSave
    
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{jobId}', $Id)
    
                    $headerObj = Get-CVRESTHeader $sessionObj
                    $body = ''
                    $payload = @{ }
                    $payload.Add('headerObject', $headerObj)
                    $payload.Add('body', $body)
                    $validate = 'jobs'
                    
                    $response = Submit-CVRESTRequest $payload $validate
        
                    if ($response.IsValid) 
                    {
                        if ($Details) {
                            Write-Output (Get-CVJobDetail -Id $response.Content.jobs.jobSummary.jobId).detailInfo
                        }
                        else {
                            Write-Output $response.Content.jobs.jobSummary
                        }
                    }
                    else 
                    { 
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): job Id [$Id] not found"
                    }
                }
                else {
                    if (-not [String]::IsNullOrEmpty($ClientName)) {
                        $clientObj = Get-CVId -ClientName $ClientName
                        if ($null -ne $clientObj) { 
                            $sessionObj.requestProps.endpoint += '&clientId=' + $clientObj.clientId
                        }
                        else {
                            return
                        }
                    }
        
                    if (-not [String]::IsNullOrEmpty($SubclientName)) {
                        if ([String]::IsNullOrEmpty($ClientName)) {
                            $ClientName = Read-Host 'ClientName'
                        }
        
                        $subclientObj = Get-CVSubclient -Name $SubclientName -ClientName $ClientName
        
                        if ($null -ne $subclientObj) { 
                            $subclientId = $subclientObj.subclientId 
                        } 
                    }
                    
                    $sessionObj.requestProps.endpoint += "&hideAdminjobs=false"
    
                    if (-not [String]::IsNullOrEmpty($JobFilter)) {
                        $sessionObj.requestProps.endpoint += '&jobFilter=' + $JobFilter
                    }
        
                    if (-not [String]::IsNullOrEmpty($JobCategory)) {
                        $sessionObj.requestProps.endpoint += '&jobCategory=' + $JobCategory
                    }
        
                    if ($CompletedTime) {
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{completedJobLookupTime}', ($CompletedTime * 3600))
                    }
                    else {
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{completedJobLookupTime}', $null)
                    }
    
                    if ($limit) {
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{limit}', $limit)
                    }
                    else {
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{limit}', $null)
                    }
        
                    if ($PSCmdlet.PagingParameters.First -eq [Uint64]::MaxValue) { # MaxValue is system default
                        if ($PSCmdlet.PagingParameters.IncludeTotalCount.IsPresent) {
                            $headerObj = Get-CVRESTHeader $sessionObj -Limit 0 -Offset 0
                        }
                        else {
                            $headerObj = Get-CVRESTHeader $sessionObj
                        }
                    }
                    else {
                        $headerObj = Get-CVRESTHeader $sessionObj -Limit $PSCmdlet.PagingParameters.First -Offset $PSCmdlet.PagingParameters.Skip
                    }
    
                    $body = ''
                    $payload = @{ }
                    $payload.Add('headerObject', $headerObj)
                    $payload.Add('body', $body)
                    $validate = 'jobs'
                    
                    $response = Submit-CVRESTRequest $payload $validate
        
                    if ($response.IsValid) 
                    {
                        if ($subclientId) 
                        {
                            $foundSubclientJob = $False
                            foreach ($job in $response.Content.jobs) 
                            {
                                if ($job.jobSummary.subclient.subclientId -eq $subclientId) 
                                {
                                    $foundSubclientJob = $True
                                    if ($Details) {
                                        Write-Output (Get-CVJobDetail $job.jobSummary.jobId).detailInfo
                                    }
                                    else {
                                        Write-Output $job.jobSummary
                                    }
                                }
                            }
                            if (-not $foundSubclientJob) {
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no jobs found for subclient [$SubclientName]"
                            }
                        }
                        else 
                        { 
                            foreach ($job in $response.Content.jobs) 
                            {
                                if ($Details) {
                                    Write-Output (Get-CVJobDetail -Id $job.jobSummary.jobId).detailInfo
                                }
                                else {
                                    Write-Output $job.jobSummary
                                }
                            }
                        }
                    }
                    else 
                    { 
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no jobs found"
                    }
                }
            }
            catch 
            {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
            if ($PSCmdlet.PagingParameters.IncludeTotalCount) {
                [double] $accuracy = 1.0
                $PSCmdlet.PagingParameters.NewTotalCount($response.Content.totalRecordsWithoutPaging, $accuracy)
            }
        }
    }
    
    