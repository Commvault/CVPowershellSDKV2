Add-AEnums
function Remove-CVVirtualMachine {
    <#
    .SYNOPSIS
        Method to remove virtual server subclient content.
    .DESCRIPTION
        Method to remove virtual server subclient content.
        
    .PARAMETER ClientName
        ClientName of the client in which subclient resides.
    .PARAMETER ClientObject
        Piped ClientObject of the client in which subclient resides.
    .PARAMETER SubclientName
        SubclientName from which content should be removed. If this parameter not passed, assumes default subclient.
    .PARAMETER Entity
        Name of the Entity to be removed. Multiple entities can be added using a comma separated list. Virtual machine Name, datastore name etc.
    .PARAMETER EntityType
        EntityType can be VMName (default), Host or Cluster etc.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Remove-CVVirtualMachine -Entity LSRegVm1 -ClientName vsa-vc65.testlab.commvault.com
    .EXAMPLE
        Remove-CVVirtualMachine -Entity LSRegVm1 -ClientName vsa-vc65.testlab.commvault.com -SubclientName LSRegVMG1    
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
        If successful, specified content is removed from the subclient.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Remove-CVVM')]
        [CmdletBinding(DefaultParameterSetName = 'ByName', SupportsShouldProcess = $True, ConfirmImpact = 'High')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $ClientObject,
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $SubclientName,
    
            [Parameter(Mandatory = $True)]
            [ValidateNotNullorEmpty()]
            [String] $Entity,
    
            [Parameter(Mandatory = $False)]
            [CVVSAContentEntityType] $EntityType = 'VMName',
    
            [Switch] $Force
        )
    
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
    
            try {
                if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    if (-not [String]::IsNullOrEmpty($SubclientName)) {
                        if ($Force) {
                            Add-CVVirtualMachine -Entity $Entity -EntityType $EntityType -ClientName $ClientName -SubclientName $SubclientName -OperationType 'DELETE' -Force
                        }
                        else {
                            Add-CVVirtualMachine -Entity $Entity -EntityType $EntityType -ClientName $ClientName -SubclientName $SubclientName -OperationType 'DELETE'
                        }
                    }
                    else {
                        if ($Force) {
                            Add-CVVirtualMachine -Entity $Entity -EntityType $EntityType -ClientName $ClientName -OperationType 'DELETE' -Force
                        }
                        else {
                            Add-CVVirtualMachine -Entity $Entity -EntityType $EntityType -ClientName $ClientName -OperationType 'DELETE'
                        }
                    }
                }
                else {
                    if (-not [String]::IsNullOrEmpty($SubclientName)) {
                        if ($Force) {
                            $ClientObject | Add-CVVirtualMachine -Entity $Entity -EntityType $EntityType -SubclientName $SubclientName -OperationType 'DELETE' -Force
                        }
                        else {
                            $ClientObject | Add-CVVirtualMachine -Entity $Entity -EntityType $EntityType -SubclientName $SubclientName -OperationType 'DELETE'
                        }
                    }
                    else {
                        if ($Force) {
                            $ClientObject | Add-CVVirtualMachine -Entity $Entity -EntityType $EntityType -OperationType 'DELETE' -Force
                        }
                        else {
                            $ClientObject | Add-CVVirtualMachine -Entity $Entity -EntityType $EntityType -OperationType 'DELETE'
                        }
                    }
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }