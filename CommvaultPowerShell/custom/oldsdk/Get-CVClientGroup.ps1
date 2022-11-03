Add-AEnums
function Get-CVClientGroup {
    <#
    .SYNOPSIS
        Method to retrieve client groups from the CommServe.
    .DESCRIPTION
        Method to retrieve client groups or a single specified group from the CommServe.
        
    .PARAMETER Name
        Get a client group by Name.
    .PARAMETER AllProperties
        Get detail properties for each client group.
    .EXAMPLE
        Get-CVClientGroup
        
    .EXAMPLE
        Get-CVClientGroup -Name Snow-Test
        
    .EXAMPLE
        Get-CVClientGroup -Name Snow-Test -AllProperties
    .EXAMPLE
        Get-CVClientGroup -Name Snow-Test -AllProperties | Select-Object -ExpandProperty firewallConfiguration
        
    .EXAMPLE
        Get-CVClientGroup -Name Snow-Test -AllProperties | Select-Object -ExpandProperty firewallConfiguration | Select-Object -ExpandProperty firewallOptions
        
    .OUTPUTS
        Outputs [PSCustomObject] containing client group properties.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Get-CVClientGroupProps')]
        [CmdletBinding(DefaultParameterSetName = 'Default')]
        [OutputType([PSCustomObject])]
        param(
            [Alias('ClientGroupName')]
            [Parameter(Mandatory = $False, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
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
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'groups'
    
                $response = Submit-CVRESTRequest $payload $validate
    
                $foundGroup = $False
    
                if ($response.IsValid) {
                    foreach ($group in $response.Content.groups) {
                        if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                            if ($Name -eq $group.name) {
                                $foundGroup = $True
                                if ($AllProperties) {
                                    Write-Output (GetClientGroupProperties -GroupObject $group)
                                }
                                else {
                                    Write-Output $group
                                }
                            }
                        }
                        else {
                            if ($AllProperties) {
                                Write-Output (GetClientGroupProperties -GroupObject $group)
                            }
                            else {
                                Write-Output $group
                            }
                        }
                    }
                    if ($PSCmdlet.ParameterSetName -eq 'ByName' -and -not $foundGroup) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client group not found having name [$Name]"                
                    }
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no client groups found"                
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }
    function GetClientGroupProperties ([System.Object] $GroupObject) {

        try {
            $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientGroupId}', $GroupObject.Id) 
    
            $headerObj = Get-CVRESTHeader $sessionObj
            $body = ''
            $payload = @{ }
            $payload.Add('headerObject', $headerObj)
            $payload.Add('body', $body)
            $validate = 'clientGroupDetail'
    
            $response = Submit-CVRESTRequest $payload $validate
            
            if ($response.IsValid) {
                Write-Output $response.Content.clientGroupDetail
            }
        }
        catch {
            throw $_
        }
    }