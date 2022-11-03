Add-AEnums
function Restore-CVVirtualMachine {
    <#
    .SYNOPSIS
        Method to initiate restore/recovery of specified virtual machine.
    .DESCRIPTION
        Method to initiate restore/recovery of specified virtual machine.
        
    .PARAMETER Id
        Specify the virtual machine to be restored by GUID.
    .PARAMETER Name
        Specify the virtual machine to be restored by Name.
    .PARAMETER ClientName
        Source virtual machine associated ClientName
    .PARAMETER SubclientName
        Specify SubclientName to override the default behaviour.
    .PARAMETER JobId
        Specify JobId from which to restore.
    .PARAMETER CopyPrecedence
        Specify CopyPrecedence from which the restore should occur: Primary, secondary or cloud.
    .PARAMETER PowerOnAfterRestore
        Switch to PowerOnAfterRestore.
    .PARAMETER OverwriteExisting
        Switch to OverwriteExisting.
    .PARAMETER RestoreType
        Specify RestoreType: FullVirtualMachine or VirtualMachineFiles.
    .PARAMETER OutofPlace
        Switch to create an out-of-place virtual machine restore.
    .PARAMETER Requestbody
        PSCustom object with request body which contains destination client and destination info or vmFileLevelRestoreOptions for out-of-place restore
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Restore-CVVirtualMachine
    .EXAMPLE
        Restore-CVVirtualMachine -Id 502df85e-7fe7-e1d6-8f0a-a9cdadd8c13e
    .EXAMPLE
        Restore-CVVirtualMachine -Name TESTVM12 -ClientName VSAQAVCDR.vsatest.commvault.com -SubclientName VMGroup1 -PowerOnAfterRestore -OverwriteExisting
    .EXAMPLE
        Restore-CVVirtualMachine -Name TESTVM12 -ClientName VSAQAVCDR.vsatest.commvault.com -SubclientName VMGroup1 -PowerOnAfterRestore -OverwriteExisting 
    .EXAMPLE
        PS C:\> $requestbody = @'{
        "destinationClient": {
            "clientName": "testvsvc1.testlab.commvault.com_v2"
        },
        "destinationInfo": [
            {
                "vmware": {
                        "esxHost": "172.24.42.9",
                        "newName": "va-dummyVM2_DND",
                        "dataStore": "HDD_AutoDatastore",
                        "resourcePool": "/"
                    }
                }
            ]
        } '@ | ConvertFrom-Json
        Restore-CVVirtualMachine -Name va-dummyVM2_DND2 -outofPlace -Requestbody $requestbody -OverwriteExisting
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Restore-CVVM')]
        [Alias('Restore-CVVMOut')]
        [CmdletBinding(DefaultParameterSetName = 'ByName', SupportsShouldProcess = $True, ConfirmImpact = 'High')]
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
    
            [Parameter(Mandatory = $False)]   
            [ValidateNotNullorEmpty()]
            [Int32] $JobId,
    
            [Parameter(Mandatory = $False)]   
            [Int32] $CopyPrecedence,
    
            [Parameter(Mandatory = $False)]
            [CVVSARestoreType] $RestoreType = 'FullVirtualMachine',
    
            [Switch] $OutofPlace,
            [Switch] $PowerOnAfterRestore,
            [Switch] $OverwriteExisting,
            [Switch] $Force,
    
            #Parameters required when OutOfPlace is enabled
            
            [Parameter(Mandatory= $False)]
            [System.Object] $Requestbody
    
        )
    
            
    
           #Set-StrictMode -Version Latest
    
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
                
                    if ($vmObj.vmStatus -ne [CVVSAVMStatus]::PROTECTED) {
                        if ($vmObj.vmStatus -eq [CVVSAVMStatus]::BACKED_UP_WITH_ERROR -and (-not $Force.IsPresent)) {
                            [CVVSAVMStatus] $status = $vmObj.vmStatus
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): virtual machine [$($vmObj.name)] has unsupported status [$status]"
                            return
                        }
                    }
                }
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{vmGUID}', $vmObj.strGUID)
    
                <# request body parameters
                {
                    "powerOnVmAfterRestore": true,
                    "passUnconditionalOverride": true,
                    "inPlaceRestore": true,
                    "jobId": "string",
                    "copyPrecedence": "string",
                    "destinationClient": {
                        "clientName": "string"
                    },
                    "vmFileLevelRestoreOptions": {
                        "sourcePath": [
                            "string"
                        ],
                        "destPath": "string",
                        "guestCredentials": {
                            "userName": "string",
                            "password": "string"
                        }
                    },
                    "destinationInfo": {
                        "vmware": {
                            "esxHost": "string",
                            "dataStore": "string",
                            "resourcePool": "string",
                            "vmfolder": "string",
                            "newName": "string"
                        },
                        "hyperv": {
                            "Server": "string",
                            "destinationPath": "string",
                            "registerwithFailover": "string",
                            "newName": "string"
                        }
                    }
                }
                #>
                
                $parameters = @{}
                $parameters.Add('passUnconditionalOverride', $OverwriteExisting.IsPresent)
                $parameters.Add('powerOnVmAfterRestore', $PowerOnAfterRestore.IsPresent)
                if ($JobId -gt 0) { $parameters.Add('jobId', $JobId) }
                #$parameters.Add('copyPrecedence', $CopyPrecedence) #GRSTODO: job fails with this specified
        
                if ($RestoreType -eq 'FullVirtualMachine') {
                    if ($OutofPlace) {
                        $parameters.Add('inPlaceRestore', $False)
                        $parameters.Add('destinationClient', $Requestbody.destinationClient)
                        $parameters.Add('destinationInfo', $Requestbody.destinationInfo)
                    }
                    else {
                        $parameters.Add('inPlaceRestore', $True)
                    }
                }
                elseif($RestoreType -eq "VirtualMachineFiles"){
                    if ($OutofPlace) {
                        $parameters.Add('inPlaceRestore', $False)
                    }
                    else{
                        $parameters.Add('inPlaceRestore', $True)
                    }
                    $parameters.Add('vmFileLevelRestoreOptions', $Requestbody.vmFileLevelRestoreOptions)
                }
    
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): restore type [$RestoreType] is not currently supported"
                }
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = $parameters | ConvertTo-Json -Depth 10
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
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): restore request declined for virtual machine [$($vmObj.name)]"
                }
            }
        
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }