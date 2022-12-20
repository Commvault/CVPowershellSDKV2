Add-AEnums
function Add-CVVirtualMachine {
    <#
    .SYNOPSIS
        Method to add virtual server subclient content.
    .DESCRIPTION
        Method to add virtual server subclient content.
        
    .PARAMETER ClientName
        ClientName of the client in which subclient resides.
    .PARAMETER ClientObject
        Piped ClientObject of the client in which subclient resides.
    .PARAMETER SubclientName
        SubclientName to which content should be added. If this parameter not passed, assumes default subclient.
    .PARAMETER Entity
        Name of the Entity to be added. Multiple entities can be added using a comma separated list. Virtual machine Name, datastore name etc.
    .PARAMETER EntityType
        EntityType can be VMName (default), Host or Cluster etc.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Add-CVVirtualMachine -Entity LSRegVm1 -ClientName vsa-vc65.testlab.commvault.com
    .EXAMPLE
        Add-CVVirtualMachine -Entity LSRegVm1 -ClientName vsa-vc65.testlab.commvault.com -SubclientName LSRegVMG1    
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
        If successful, specified content is added to the subclient.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Add-CVVM')]
        [CmdletBinding(DefaultParameterSetName = 'ByName', SupportsShouldProcess = $True, ConfirmImpact = 'Medium')]
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
    
            [Parameter(DontShow)]
            [CVVSAContentOperationType] $OperationType = 'ADD',
    
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
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{subclientId}', $subclientObj.subclientId) 
    
                $entityObj = GetVirtualMachineEntityObject
                $entityObj['entity']        = $Entity                # Entity Name can be: VM name in format like VM1, VM2, VM3 
                $entityObj['entityType']    = $EntityType            # Virtualization entity type. ESX Host, Datastore, VM, Cluster...etc 
                $entityObj['operationType'] = $OperationType         # DELETE or ADD or OVERWRITE
                $entityObj['clientId']      = $ClientObject.clientId # Virtualization clientId
    
                $bodyJson = PrepareContentBodyJson -EntityObj $entityObj
                if ($null -eq $bodyJson) {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): entity not found for add/remove virtual machine request"
                    return
                }
                else {
                    $body = $bodyJson.body
                }
                
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload = @{}
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'response'
    
                if ($Force -or $PSCmdlet.ShouldProcess($Entity)) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): subclient content modification request declined for entity [$Entity]"      
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }

    function PrepareContentBodyJson ([HashTable] $EntityObj) {

        try {
            [System.Collections.ArrayList] $childrenNode_arr = @()
    
            if ($EntityObj.Entity) {
                $entities = $EntityObj.Entity -split ","
                if ($entities) {
                    foreach ($entity in $entities) {
                        $uuid = $null
                        if ($EntityObj.EntityType.value__ -ne 10)
                        {
                            $vmProps = Get-CVVirtualMachine -Name $entity -ClientId $EntityObj.clientId
                            if ($null -ne $vmProps -and $null -ne $vmProps.strGUID) {
                                $uuid = $vmProps.strGUID
                            }
                            else {
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): virtual machine GUID not found for entity [$entity]"
                                continue
                            }
                        }
    
                        $vmObj = [ordered]@{ }
                        $vmObj.Add('allOrAnyChildren' , $True)
                        $vmObj.Add('displayName'      , $entity)
                        $vmObj.Add('equalsOrNotEquals', $True)
                        if ($uuid -eq $null)
                        {
                            $vmObj.Add('name'             , '')
                        }
                        else
                        {
                            $vmObj.Add('name'             , $uuid)
                        }                 
                        $vmObj.Add('type'             , $EntityObj.EntityType.value__)
                        $vmObj.Add('path'             , '')
                        $null = $childrenNode_arr.Add($vmObj)
                    }
                }
            }
    
            if ($childrenNode_arr.Count -eq 0) {
                return $null
            }
    
            $subClientProp = @{ }
            $children = @{ }
            $children.Add('children', $childrenNode_arr)
            $subClientPropertiesObj = @{ }
            $subClientPropertiesObj.Add('vmContentOperationType', $EntityObj.OperationType.ToString())
            $subClientPropertiesObj.Add('vmDiskFilterOperationType', 1)
            $subClientPropertiesObj.Add('vmFilterOperationType', 1)
            $subClientPropertiesObj.Add('vmContent' , $children)
    
            $subClientProp.Add('subClientProperties', $subClientPropertiesObj)
            #$rootObj.Add('App_UpdateSubClientPropertiesRequest', $subClientProp)
            $body = $subClientProp | ConvertTo-Json -Depth 10
            return @{ 'body' = $body }
        }
        catch {
            throw $_
        }
    }


    function GetVirtualMachineEntityObject {

        try {
            $entityObj  = @{}
            $entityObj.Add('entity', '')           #Entity Name can be say: VM name in format like VM1, VM2, VM3
            $entityObj.Add('entityType', '')       #Virtualization entity type. ESX Host, Datastore, VM, Cluster...etc 
            $entityObj.Add('operationType', '')    #DELETE or ADD  or OVERWRITE
            $entityObj.Add('clientId', '')         #Virtualization clientId
            
            return $entityObj
        }
        catch {
            throw $_
        }
    }