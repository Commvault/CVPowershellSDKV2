Add-AEnums
function Get-CVVirtualMachineLiveMount {
    <#
    .SYNOPSIS
        Method to retrieve list of active mounts for specified source virtual machine.
    .DESCRIPTION
        Method to retrieve list of active mounts for specified source virtual machine.
        
    .PARAMETER Name
        Source virtual machine Name.
    .PARAMETER ClientName
        Source virtual machine associated ClientName.
    .PARAMETER SubclientName
        Specify SubclientName to override the default behavior.
    .PARAMETER Id
        Specify Id representing source virtual machine GUID.
    .EXAMPLE
        Get-CVVirtualMachineLiveMount | Select-Object -ExpandProperty virtualMachines
    .EXAMPLE
        Get-CVVirtualMachineLiveMount -Id 502d15b2-9f17-1df9-5231-20b22d73b952 | Select-Object -ExpandProperty virtualMachines
    .EXAMPLE
        Get-CVVirtualMachineLiveMount -Name LSRegVm1 -ClientName vsa-vc65.testlab.commvault.com -SubclientName LSRegVMG1 | Select-Object -ExpandProperty virtualMachines
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByName')]
        [OutputType([PSCustomObject])]
        param(
            [Alias('VMName')]
            [Parameter(Mandatory = $True, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [String] $Id,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $ClientObject,
    
            [Parameter(Mandatory = $False )]
            [ValidateNotNullorEmpty()]
            [String] $SubclientName
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
                else {
                    $subclientObj = $null
    
                    if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                        $clientObj = Get-CVClient -Name $ClientName
                        if ($null -ne $clientObj) {
                            $ClientObject = $clientObj
                        }
                        else {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$ClientName]"
                            return
                        }
                    }
        
                    if (-not [String]::IsNullOrEmpty($SubclientName)) {
                        $subclientObj = $ClientObject | Get-CVSubclient -Name $SubclientName
                        if ($null -eq $subclientObj) { 
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having name [$SubclientName] for client [$ClientName]"      
                            return
                        }
                    }
                    else { # use default subclient
                        $globalsObj = Get-CVCommCellGlobals 
                        $SubclientName = $globalsObj.defaultSubclient 
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient name not provided...retrieving default subclient"
                        $subclientObj = $ClientObject | Get-CVSubclient -Name $SubclientName
                        if ($null -eq $subclientObj) {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient not found having name [$SubclientName]"
                            return
                        }
                    }
            
                    $vmObj = ($ClientObject | Get-CVVirtualMachine -Name $Name)
                    if ($null -eq $vmObj) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): virtual machine not found having name [$Name]"
                        return
                    }
                }
    
                if ($vmObj.vmStatus -ne [CVVSAVMStatus]::PROTECTED) {
                    [CVVSAVMStatus] $status = $vmObj.vmStatus
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): virtual machine [$($vmObj.name)] has unsupported status [$status]"
                    return
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{vmGUID}', $vmObj.strGUID)
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'virtualMachines'
                
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    if ($PSCmdlet.ParameterSetName -eq 'ById') {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no active live mounts found for virtual machine [$Id]"      
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no active live mounts found for virtual machine [$Name]"      
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
      