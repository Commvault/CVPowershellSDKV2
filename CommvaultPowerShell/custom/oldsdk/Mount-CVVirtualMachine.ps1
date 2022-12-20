Add-AEnums
function Mount-CVVirtualMachine {
    <#
    .SYNOPSIS
        Method to initiate live mount of specified virtual machine.
    .DESCRIPTION
        Method to initiate live mount of specified virtual machine from specified media.
        
    .PARAMETER Id
        Specify Id representing source virtual machine GUID.
    .PARAMETER Name
        Source virtual machine Name.
    .PARAMETER ClientName
        Source virtual machine associated ClientName.
    .PARAMETER SubclientName
        Specify SubclientName to override the default behaviour.
    .PARAMETER NetworkName
        Specify NetworkName for live mount operation.
    .PARAMETER PolicyName
        Specify PolicyName for live mount operation.
    .PARAMETER JobId
        Specify JobId to live mount from particular backup job.
    .PARAMETER LiveMountVMName
        Specify LiveMountVMName to override default naming behavior.
    .PARAMETER ExpirationInHours
        Specify ExpirationInHours for in-place live mount.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Mount-CVVirtualMachine -Id 502df85e-7fe7-e1d6-8f0a-a9cdadd8c13e
    .EXAMPLE
        Mount-CVVirtualMachine -ClientName VSAAZURE -Name AzureProxyV2CS
    .EXAMPLE
        Mount-CVVirtualMachine -ClientName VSAAZURE -Name AzureProxyV2CS -SubclientName test-2567
    .EXAMPLE
        Mount-CVVirtualMachine -ClientName VSAAZURE -Name AzureProxyV2CS -SubclientName test-2567 -PolicyName policy1 -JobId 12345 -LiveMountVMName AzureProxyV2CS_m1 -ExpirationInHours 3
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Mount-CVVM')]
        [CmdletBinding(DefaultParameterSetName = 'ByName', SupportsShouldProcess = $True, ConfirmImpact = 'Medium')]
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
            [String] $SubclientName,
    
            [Parameter(Mandatory = $False )]
            [ValidateNotNullorEmpty()]
            [String] $NetworkName,
    
            [Parameter(Mandatory = $False )]
            [ValidateNotNullorEmpty()]
            [String] $PolicyName,
    
            [Parameter(Mandatory = $False )]
            [ValidateNotNullorEmpty()]
            [String] $JobId,
    
            [Parameter(Mandatory = $False )]
            [ValidateNotNullorEmpty()]
            [String] $LiveMountVMName,
    
            [Parameter(Mandatory = $False )]
            [ValidateNotNullorEmpty()]
            [String] $ExpirationInHours,
    
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
    
                $jobObj = @{}
                $jobObj.Add('networkName', $NetworkName)
                $jobObj.Add('policyName', $PolicyName)
                $jobObj.Add('jobId', $JobId)
                $jobObj.Add('liveMountVMName', $LiveMountVMName)
                $jobObj.Add('expirationInHours', $ExpirationInHours)
        
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = (PrepareMountTaskBodyJson $jobObj).body
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
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
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): mount request declined for virtual machine [$($vmObj.name)]"      
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }
    

    function PrepareMountTaskBodyJson ([HashTable] $JobObj) {

        try {
            $createTaskReq = [ordered]@{}
            $vmLiveMountReq = [ordered]@{ }
            $vmLiveMountReq.Add('useSourceNetwork', $False)
            $vmLiveMountReq.Add('networkName', $JobObj.networkName)
            $vmLiveMountReq.Add('policyName', $JobObj.policyName)
            $vmLiveMountReq.Add('jobId', $JobObj.jobId)
            $vmLiveMountReq.Add('liveMountVMName', $JobObj.liveMountVMName)
            $vmLiveMountReq.Add('expirationInHours', $JobObj.expirationInHours)
            $createTaskReq.Add('VMLiveMountReq', $vmLiveMountReq)
            
            $body = $createTaskReq | ConvertTo-Json -Depth 10
            return @{ 'body' = $body }
        }
        catch {
            throw $_
        }
    }