Add-AEnums
function Get-CVSubclientMediaAgent {
    <#
    .SYNOPSIS
        Method to retrieve subclient media agent instances from the CommServe.
    .DESCRIPTION
        Method to retrieve subclient media agent instances from the CommServe.
    .PARAMETER Name
        Retrieve media agent instances for subclient identified by Name.
    .PARAMETER Id
        Retrieve media agent instances for subclient identified by Id.
    .PARAMETER ClientName
        Provide ClientName for subclient lookup.
        
    .PARAMETER SubclientObject
        Retrieve media agent instances by piped SubclientObject.
    .EXAMPLE
        Get-CVSubclientMediaAgent
        
    .EXAMPLE
        Get-CVSubclientMediaAgent -Name default -ClientName carbonwincs1
        
    .EXAMPLE
        Get-CVSubclientMediaAgent -Id 2 -ClientName carbonwincs1
        
    .EXAMPLE
        Get-CVSubclient -ClientName carbonwincs1 | Get-CVSubclientMediaAgent
    .OUTPUTS
        Outputs [PSCustomObject] containing subclient media agent instances.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByName')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [Parameter(Mandatory = $True, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $Id,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $SubclientObject
        )
        
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                $endpointSave = $sessionObj.requestProps.endpoint
                $processCount = 0
            }
            catch {
                throw $_
            }
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
        
            try {
                $sessionObj.requestProps.endpoint = $endpointSave
                
                if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    $subclientObj = Get-CVSubclient -Name $Name -ClientName $ClientName
                    if ($null -ne $subclientObj) { 
                        $SubclientObject = $subclientObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having name [$Name] for client [$ClientName]"      
                        return
                    }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $subclientObj = Get-CVSubclient -Id $Id -ClientName $ClientName
                    if ($null -ne $subclientObj) { 
                        $SubclientObject = $subclientObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having id [$Id] for client [$ClientName]"      
                        return
                    }
                }
                
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{subclientId}', $SubclientObject.subclientId)
    
                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): ...processing subclient [$($SubclientObject.subclientName)]"      
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'mediaAgentId'
                    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    foreach ($mediaAgent in $response.Content) {
                        Write-Output $mediaAgent
                        $processCount++
                    }
                }
    
                if ($PSCmdlet.ParameterSetName -eq 'ByObject') {
                    if ($processCount -eq 0) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no media agents found for subclient [$($SubclientObject.subclientName)]"      
                    }
                    else {
                        $processCount = 0
                    }
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
    
            try {
                if ($PSCmdlet.ParameterSetName -ne 'ByClientObject' -and $processCount -eq 0) {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no media agents found for subclient [$($SubclientObject.subclientName)]"      
                }
            }
            catch {
                throw $_
            }
        }
    }