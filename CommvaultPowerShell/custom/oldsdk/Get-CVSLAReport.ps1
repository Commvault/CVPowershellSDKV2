Add-AEnums
function Get-CVSLAReport {
    <#
    .SYNOPSIS
        Gets SLA report for specific client or entire CommCell.
    .DESCRIPTION
        Gets SLA report for specific client or entire CommCell.
    .PARAMETER ClientName
        Filter SLA report by ClientName.
        
    .PARAMETER ClientId
        Filter SLA report by ClientId.
        
    .PARAMETER ClientObject
        Filter SLA report by piped ClientObject.
        
    .PARAMETER Type
        Client = 1 (default), Agent = 2.
    .PARAMETER Category
        Any = 0 (default), Protected = 1, Failed = 2, NoJobFound = 3, NoSchedule = 4.
    .PARAMETER Status
        Any = 0 (default), Protected = 1, Unprotected = 2, Excluded = 3.
    .PARAMETER EmailAddr
        EmailAddr for notification purpose.
    .PARAMETER AllProperties
        Use this switch for extended detail.
    .EXAMPLE
        Get-CVSLAReport
    .EXAMPLE
        Get-CVSLAReport -ClientName carbonwincs1 -EmailAddr admin@testlab.commvault.com
    .EXAMPLE
        Get-CVSLAReport -ClientId 57 -AllProperties
    .EXAMPLE
        Get-CVClient | Get-CVSLAReport
    .OUTPUTS
        Outputs [PSCustomObject] containing SLA report.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Get-CVSLA')]
        [CmdletBinding(DefaultParameterSetName = 'Default')]
        [OutputType([PSCustomObject])]
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
            [int] $Category = 0,
    
            [Parameter (Mandatory = $False)] 
            [int] $Status = 0,
    
            [Switch] $AllProperties
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
    
                $slaFlags = [ordered]@{ }
                $slaFlags.Add('type', $Type)
                $slaFlags.Add('category', $Category)
                $slaFlags.Add('status', $Status)
    
                $body = (PrepareSLABodyJson $slaFlags).body
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload = @{ }
                if (-not [String]::IsNullOrEmpty($EmailAddr)) {
                    $payload.Add('EmailId', $EmailAddr)
                    if (-not [String]::IsNullOrEmpty($ClientName)) {
                        $payload.Add('emailSubject', "SLA report for client: $ClientName")
                    }
                    else {
                        $payload.Add('emailSubject', "SLA report for CommCell")
                    }
                }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'lastSLA'
    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    if ($AllProperties) {
                        Write-Output $response.Content
                    }
                    else {
                        Write-Output $response.Content.lastSLA
                    }
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): SLA report not found"
                }
            }
            catch {
                throw $_
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