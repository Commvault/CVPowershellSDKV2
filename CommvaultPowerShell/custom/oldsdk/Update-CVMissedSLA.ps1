function Update-CVMissedSLA {
    <#
    .SYNOPSIS
        Initiates backup job for subclients with missed SLA.
    .DESCRIPTION
        Initiates backup job for subclients with missed SLA.
    .PARAMETER ClientName
        Filter SLA report by ClientName.
        
    .PARAMETER ClientId
        Filter SLA report by ClientId.
        
    .PARAMETER ClientObject
        Filter SLA report by piped ClientObject.
        
    .PARAMETER Type
        Client = 1 (default), Agent = 2.
    .PARAMETER Category
        Any = 0, Protected = 1, Failed = 2 (default), NoJobFound = 3, NoSchedule = 4.
    .PARAMETER Status
        Any = 0, Protected = 1, Unprotected = 2 (default), Excluded = 3.
    .PARAMETER EmailAddr
        EmailAddr for notification purpose.
    .EXAMPLE
        Update-CVMissedSLA
    .EXAMPLE
        Update-CVMissedSLA -ClientName carbonwincs1 -EmailAddr admin@testlab.commvault.com
    .EXAMPLE
        Update-CVMissedSLA -ClientId 57
    .EXAMPLE
        Get-CVClient | Update-CVMissedSLA
    .OUTPUTS
        Outputs [PSCustomObject] for each subclient with missed SLA, containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Protect-CVMissedSLA')]
        [CmdletBinding(DefaultParameterSetName = 'Default')]
        param(
            [Parameter(Mandatory = $False, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $ClientId,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $ClientObject,
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $EmailAddr,
    
            [Parameter (Mandatory = $False)] 
            [Int32] $Type = 1,
    
            [Parameter (Mandatory = $False)] 
            [Int32] $Category = 2,
    
            [Parameter (Mandatory = $False)] 
            [Int32] $Status = 2
        )
     
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
    
                if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    $clientObj = Get-CVClient -Name $ClientName
                    if ($null -ne $clientObj) { 
                        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $clientObj.clientId)
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$ClientName]"      
                        return
                    }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientId)
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByObject') {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientObject.clientId)
                    $ClientName = $ClientObject.clientName
                }
                
                #noop here if already replaced
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $null)
    
                $slaFlags = @{ }
                $slaFlags.Add('pageSize', 20),
                $slaFlags.Add('type', $Type)
                $slaFlags.Add('category', $Category)
                $slaFlags.Add('status', $Status)
    
                $body = (PrepareSLABodyJson $slaFlags).body
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'failedSubclientList'
                
                $response = Submit-CVRESTRequest $payload $validate
                
                if ($response.IsValid) {
                    $uniqueSubclients = @{ }
                    foreach ($row in $response.Content.failedSubclientList) {
                        if (-not ($uniqueSubclients.ContainsKey($row.appId))) {
                            $null = $uniqueSubclients.Add($row.appId, $row)
                            $str = $row | Out-String
                            Write-Host $str -ForegroundColor red                    }
                    }
    
                    #Submit the jobs for each of the subclient which has failed object to protect
                    foreach ($key in $uniqueSubclients.Keys) {
                        Write-Output (Backup-CVSubclient -SubclientId $uniqueSubclients[$key].appId)
                    }
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no failed subclients found"      
                }
            }
            catch { #GRSHACK: web service invoke request is throwing exception in SP16 when subclient is excluded or does not have an assigned storage policy
                if ($_.Exception.Message -eq 'The remote server returned an error: (500) Internal Server Error.') {
                    Write-Error -Message "$($MyInvocation.MyCommand): $($_.Exception.Message)"      
                }
                else {
                    throw $_
                }
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }

    function PrepareSLABodyJson ($payload) {

        try {
            $mapSLA = [ordered]@{ }
            $mapSLA.Add("type", $payload.type)
            $mapSLA.Add("category", $payload.category)
            $mapSLA.Add("status", $payload.status)
            $body = $mapSLA | ConvertTo-Json -Depth 10
            Write-Output @{ 'body' = $body }
        }
        catch {
            throw $_
        }
    }