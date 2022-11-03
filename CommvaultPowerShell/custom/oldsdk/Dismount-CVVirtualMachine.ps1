Add-AEnums
function Dismount-CVVirtualMachine {
    <#
    .SYNOPSIS
        Method to initiate dismount of live mounted virtual machine.
    .DESCRIPTION
        Method to initiate dismount of live mounted virtual machine.
        
    .PARAMETER Id
        Specify Id representing live mounted virtual machine GUID.
    .PARAMETER ActiveMountObject
        Specify ActiveMountObject containing live mounted virtual machine GUID.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Dismount-CVVirtualMachine -Id f7db5498-2bb5-4152-9064-dd50df07eff5
    .EXAMPLE
        Get-CVVirtualMachineLiveMount -ClientName VSAAZURE -Name AzureProxyV2CS -SubclientName test-2567 | Dismount-CVVirtualMachine
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ById', SupportsShouldProcess = $True, ConfirmImpact = 'High')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [String] $Id,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $ActiveMountObject,
    
            [Switch] $Force
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
    
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $vmObj = (Get-CVVirtualMachine -Id $Id)
                    if ($null -eq $vmObj) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): virtual machine not found having id [$Id]"
                        return
                    }
                }
                elseif ((HasProperty $ActiveMountObject 'vm') -and (HasProperty $ActiveMountObject.vm 'vmGUID')) {
                    $vmObj = (Get-CVVirtualMachine -Id $ActiveMountObject.vm.vmGUID)
                    if ($null -eq $vmObj) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): virtual machine not found having id [$($ActiveMountObject.vm.vmGUID)]"
                        return
                    }
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): live mount virtual machine GUID property not found on [$ActiveMountObject]"
                    return
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{vmGUID}', $vmObj.strGUID)
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                #GRSTODO: what is valid response id?
                $validate = 'taskId'
                
                if ($Force -or $PSCmdlet.ShouldProcess($vmObj.name)) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): dismount request declined for virtual machine [$($vmObj.name)]"      
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }


    function HasProperty($Object, $PropertyName)
{
    $PropertyName -in $Object.PSobject.Properties.Name
}