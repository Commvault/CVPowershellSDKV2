Add-AEnums
function Add-CVVirtualMachineGroupContent {
    <#
    .SYNOPSIS
        Method to perform a virtual machine group content preview with option to create clients from result set.
    .DESCRIPTION
        Method to perform a virtual machine group content preview with option to create clients from result set.
        
    .PARAMETER SubclientObject
        Virtual machine group for content preview. Can be piped or passed as a parameter.
    .PARAMETER EntityType
        Virtual server EntityType including: Host, Datastore, VMName, VMNamePattern, GuestOS, GuestDNSHostname, PoweredState, Notes, TemplateState, Tag, and TagCategory.
    .PARAMETER PoweredState
        Paired with EntityType PoweredState: On, Off, Other.
    .PARAMETER TemplateState
        Paired with EntityType TemplateState: $True or $False.
    .PARAMETER MatchingPattern
        Matching pattern to be used for search on DisplayName can be: Contains, Equals, StartsWith, or EndsWith.
    .PARAMETER DisplayName
        Search Term.
    .PARAMETER VMName
        Paired with EntityType VMName, this is the VM GUID.
    .PARAMETER CreateClientsForDiscoveredVms
        Switch to create clients for discovered virtual machines. 
        Recommend running first without this switch to preview discovery results.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Get-CVSubclient -Name GRS-VMGroup1 -ClientName accounting.mycompany.com | Add-CVVirtualMachineGroupContent -EntityType Datastore -MatchingPattern EndsWith -DisplayName DS1
    .EXAMPLE
        Get-CVSubclient -Name GRS-VMGroup1 -ClientName finance.mycompany.com | Add-CVVirtualMachineGroupContent -EntityType Host -MatchingPattern Equals -DisplayName 123.44.66.77
    .EXAMPLE
        Get-CVSubclient -Name GRS-VMGroup1 -ClientName sales.mycompany.com | Add-CVVirtualMachineGroupContent -EntityType VMNamePattern -MatchingPattern Contains -DisplayName GaryTest -CreateClientsForDiscoveredVms
    .EXAMPLE
        Get-CVSubclient -Name GRS-VMGroup1 -ClientName repos.mycompany.com | Add-CVVirtualMachineGroupContent -EntityType VMName -VMName 500bc16c-fb3f-17d6-5712-c00b4524d3d2
    .OUTPUTS
        Outputs [PSCustomObject] containing virtual machine discovery result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByObject', SupportsShouldProcess = $True, ConfirmImpact = 'High')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $SubclientObject,
    
            [Parameter(Mandatory = $True )]
            [ValidateNotNullorEmpty()]
            [CVVMGroupContentEntityType] $EntityType,
    
            [Parameter(Mandatory = $False )]
            [ValidateNotNullorEmpty()]
            [CVVSAPowerState] $PoweredState = [CVVSAPowerState]::On,
    
            [Parameter(Mandatory = $False )]
            [ValidateNotNullorEmpty()]
            [Boolean] $TemplateState = $True,
    
            [Parameter(Mandatory = $False )]
            [ValidateNotNullorEmpty()]
            [CVMatchingPattern] $MatchingPattern = [CVMatchingPattern]::Equals,
            
            [Parameter(Mandatory = $False )]
            [ValidateNotNullorEmpty()]
            [String] $DisplayName,
            
            [Parameter(Mandatory = $False, HelpMessage = 'This is the VM GUID')]
            [ValidateNotNullorEmpty()]
            [String] $VMName,
            
            [Switch] $CreateClientsForDiscoveredVms,
            [Switch] $Force
        )
    
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                $endpointSave = $sessionObj.requestProps.endpoint
                $bodySave = $sessionObj.requestProps.body
            }
            catch {
                throw $_
            }
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
    
            try {
                $sessionObj.requestProps.endpoint = $endpointSave
                $sessionObj.requestProps.body = $bodySave
    
                if ($CreateClientsForDiscoveredVms.IsPresent) {
                    $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{createClientsForDiscoveredVms}', 1)
                }
                else {
                    $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{createClientsForDiscoveredVms}', 0)
                }
    
                $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{clientId}', $SubclientObject.clientId)
                $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{instanceId}', $SubclientObject.instanceId)
                $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{backupsetId}', $SubclientObject.backupsetId)
                $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{subclientId}', $SubclientObject.subclientId)
    
                $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{type}', $EntityType.value__)
    
                if ($EntityType -eq [CVVMGroupContentEntityType]::PoweredState) {
                    $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{name}', $EntityType)
                    $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{displayName}', $PoweredState)
                }
                elseif ($EntityType -eq [CVVMGroupContentEntityType]::TemplateState) {
                    $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{name}', $EntityType)
                    $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{displayName}', $TemplateState)
                }
                elseif ($EntityType -eq [CVVMGroupContentEntityType]::VMName) {
                    $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{name}', $VMName)
                    $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{displayName}', $DisplayName)
                }
                else {
                    if ($MatchingPattern -eq [CVMatchingPattern]::Equals) {
                        $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{displayName}', $DisplayName)
                    }
                    elseif ($MatchingPattern -eq [CVMatchingPattern]::Contains) {
                        $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{displayName}', "*$DisplayName*")
                    }
                    elseif ($MatchingPattern -eq [CVMatchingPattern]::StartsWith) {
                        $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{displayName}', "$DisplayName*")
                    }
                    elseif ($MatchingPattern -eq [CVMatchingPattern]::EndsWith) {
                        $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{displayName}', "*$DisplayName")
                    }
                }
    
                $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{name}', $null)
                $sessionObj.requestProps.body = $sessionObj.requestProps.body -creplace ('{displayName}', $null)
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $sessionObj.requestProps.body)
                $validate = 'jobid'
                
                if ($Force -or $PSCmdlet.ShouldProcess($SubclientObject.subclientName)) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                Write-Output $response.Content
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }