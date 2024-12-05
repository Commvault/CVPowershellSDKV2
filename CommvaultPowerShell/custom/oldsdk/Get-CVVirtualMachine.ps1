Add-AEnums
function Get-CVVirtualMachine {
<#
.SYNOPSIS
    Method to retrieve the list of virtual machines in the CommCell.

.DESCRIPTION
    This method is implemented with Powershell paging support.
    Method to retrieve the list of virtual machines in the CommCell. 
    Output can be filtered by Protected/Unprotected status, active subclients of a client, and virtual machine Name.
    
.PARAMETER Name
    Filter output to virtual machine Name.

.PARAMETER ClientName
    Filter output by active subclients of ClientName.

.PARAMETER ClientId
    Filter output by active subclients of ClientId.

.PARAMETER ClientObject
    Filter output by active subclients of ClientObject.

.PARAMETER Id
    Specify Id representing virtual machine GUID.

.PARAMETER Protected
    Filter output by Protected virtual machines.

.PARAMETER UnProtected
    Filter output by UnProtected virtual machines.

.PARAMETER First
    Get list of virtual machines with paging support -First 20 (20 per page).

.PARAMETER Skip
    Get list of virtual machines with paging support -First 20 -Skip 5 (20 per page, skip first 5 pages).

.PARAMETER IncludeTotalCount
    Include total count of result record set.

.EXAMPLE
    Get-CVVirtualMachine

.EXAMPLE
    Get-CVVirtualMachine -Id 502df85e-7fe7-e1d6-8f0a-a9cdadd8c13e

.EXAMPLE
    Get-CVVirtualMachine -IncludeTotalCount -First 20 -Skip 5 (20 per page, skip first 5 pages)

.EXAMPLE
    Get-CVVirtualMachine -Protected

.EXAMPLE
    Get-CVVirtualMachine -UnProtected

.EXAMPLE
    Get-CVClient | Get-CVVirtualMachine -Protected

.EXAMPLE
    Get-CVVirtualMachine -Name autocs-winvm2

.EXAMPLE
    Get-CVVirtualMachine -ClientName Openstack-V2-client -Protected

.EXAMPLE
    Get-CVVirtualMachine -ClientName Openstack-V2-client -Name autocs-winvm2

.OUTPUTS
    Outputs [PSCustomObject] representing a virtual machine.

.NOTES
    Author: Gary Stoops
    Company: Commvault
#>
    [Alias('Perform-CVVMBrowse')]
    [CmdletBinding(DefaultParameterSetName = 'Default', SupportsPaging = $True)]
    param(
        [Alias('VMName')]
        [Parameter(Mandatory = $False)]
        [ValidateNotNullorEmpty()]
        [String] $Name,

        [Parameter(Mandatory = $False, ParameterSetName = 'ById')]
        [ValidateNotNullorEmpty()]
        [String] $Id,

        [Parameter(Mandatory = $False, ParameterSetName = 'ByClientName')]
        [ValidateNotNullorEmpty()]
        [String] $ClientName,

        [Parameter(Mandatory = $False, ParameterSetName = 'ByClientId')]
        [ValidateNotNullorEmpty()]
        [Int32] $ClientId,

        [Parameter(Mandatory = $False, ParameterSetName = 'ByClientObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
        [ValidateNotNullorEmpty()]
        [System.Object] $ClientObject,

        [switch] $Protected,
        [switch] $UnProtected
    )

    begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"

        try {
            enum RunType {
                ById
                ByClient
                ByDefault
            }

            [RunType] $runType = 'ByDefault'

            if ($PSCmdlet.ParameterSetName -eq 'ById') {
                $sessionObj = Get-CVSessionDetail 'InplaceRecover-VMDetails'
                $runType = 'ById'
            }
            elseif ($PSCmdlet.ParameterSetName -eq 'ByClientName' -or 
                    $PSCmdlet.ParameterSetName -eq 'ByClientId' -or 
                    $PSCmdlet.ParameterSetName -eq 'ByClientObject') {
                $sessionObj = Get-CVSessionDetail ($MyInvocation.MyCommand.Name + 'ByClient')
                $runType = 'ByClient'
            }
            else {
                $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
            }

            $endpointSave = $sessionObj.requestProps.endpoint
            $protectedByActiveSubclientCount = 0
            $processCount = 0
            $totalCount = 0
            $pagingObj = @{ 'paging' = 0; 'pageSize' = $null; 'startPage' = $null; 'badParams' = $False }
        }
        catch {
            throw $_
        }
    }

    process { Write-Debug -Message "$($MyInvocation.MyCommand): process"

        try {
            $sessionObj.requestProps.endpoint = $endpointSave

            if ($runType -eq 'ById') {
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{vmGUID}', $Id)
                $pagingObj = ValidatePagingParameters $PSCmdlet.PagingParameters 1

                if (-not $pagingObj.badParams) {
                    $headerObj = Get-CVRESTHeader $sessionObj
                    $body     = ''
                    $payload = @{}
                    $payload.Add('headerObject', $headerObj)
                    $payload.Add('body', $body)
                    $validate = 'vmStatusInfoList'
        
                    $response = Submit-CVRESTRequest $payload $validate
    
                    if ($response.IsValid) {
                        foreach ($vmRecord in $response.Content.vmStatusInfoList) {
                            Write-Output $vmRecord
                            $processCount++
                        }
                    }
                }
            }
            else {
                if ($Protected) {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{status}', 1)
                }
                elseif ($UnProtected) {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{status}', 2)
                }
                else {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{status}', 0)
                }
    
                if ($runType -eq 'ByClient') {
                    if ($PSCmdlet.ParameterSetName -eq 'ByClientName') {
                        $clientObj = Get-CVClient -Name $ClientName
                        if ($null -ne $clientObj) {
                            $ClientObject = $clientObj
                        }
                        else {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having name [$ClientName]"
                            return
                        }
                    }
                    elseif ($PSCmdlet.ParameterSetName -eq 'ByClientId') {
                        $clientObj = Get-CVClient -Id $ClientId
                        if ($null -ne $clientObj) {
                            $ClientObject = $clientObj
                        }
                        else {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): client not found having id [$ClientId]"
                            return
                        }
                    }

                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{id}', $ClientObject.clientId)
                    
                    if ($Protected) {
                        $activeSubclients = ($ClientObject | Get-CVSubclient)
                    }

                    $headerObj = Get-CVRESTHeader $sessionObj
                    $body     = ''
                    $payload = @{}
                    $payload.Add('headerObject', $headerObj)
                    $payload.Add('body', $body)
                    $validate = 'vmStatusInfoList'
        
                    $response = Submit-CVRESTRequest $payload $validate
    
                    if ($response.IsValid) {
                        $totalCount = $response.Content.vmStatusInfoList.Length
                        $pagingObj = ValidatePagingParameters $PSCmdlet.PagingParameters $totalCount
                        if ($pagingObj.paging) {
                            if ($pagingObj.startPage -eq 0) { $index = 0 }
                            else { $index = ($pagingObj.startPage * $pagingObj.pageSize) }
                            $pageItemCount = 0
                            for (; $index -lt $response.Content.vmStatusInfoList.Length; $index++) {
                                if (-not [String]::IsNullOrEmpty($Name)) {
                                    if ($vmRecord.name -ne $Name) {
                                        continue
                                    }
                                }
                                if ($Protected -and ($response.Content.vmStatusInfoList[$index].vmStatus -eq [CVVSAVMStatus]::PROTECTED)) {
                                    foreach ($subclient in $activeSubclients) {
                                        if ($subclient.subclientId -eq $response.Content.vmStatusInfoList[$index].subclientId) {
                                            Write-Output $response.Content.vmStatusInfoList[$index]
                                            $protectedByActiveSubclientCount++
                                            $processCount++
                                            $pageItemCount++
                                            break
                                        }
                                    }
                                }
                                else {
                                    Write-Output $response.Content.vmStatusInfoList[$index]
                                    $processCount++
                                    $pageItemCount++
                                }
                                if ($index -eq $response.Content.vmStatusInfoList.Length - 1) {
                                    break
                                }
                                elseif ($pageItemCount -eq $pagingObj.pageSize) {
                                    $pageItemCount = 0
                                    Read-Host '[Enter] for next page'
                                }
                            }
                        }
                        elseif (-not $pagingObj.badParams) {
                            foreach ($vmRecord in $response.Content.vmStatusInfoList) {
                                if (-not [String]::IsNullOrEmpty($Name)) {
                                    if ($vmRecord.name -ne $Name) {
                                        continue
                                    }
                                }
                                if ($Protected -and ($vmRecord.vmStatus -eq [CVVSAVMStatus]::PROTECTED)) {
                                    foreach ($subclient in $activeSubclients) {
                                        if ($subclient.subclientId -eq $vmRecord.subclientId) {
                                            Write-Output $vmRecord
                                            $protectedByActiveSubclientCount++
                                            $processCount++
                                            break
                                        }
                                    }
                                }
                                else {
                                    Write-Output $vmRecord
                                    $processCount++
                                }
                            }
                        }
                    }

                    if ($PSCmdlet.ParameterSetName -eq 'ByClientObject') {
                        if ($processCount -eq 0) {
                            if ($Protected) {
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no protected virtual machines found for client [$($ClientObject.clientName)]"      
                            }
                            else {
                                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no virtual machines found for client [$($ClientObject.clientName)]"      
                            }
                        }
                        else {
                            $processCount = 0
                        }
                    }
                }
                else { # ByDefault
                    # query with startPage=0, pageSize=0 to get totalRecords
                    $pagingInfo = '0,999999'
                    $headerObj = Get-CVRESTHeader $sessionObj -PagingInfo $pagingInfo
                    $body = ''
                    $payload = @{}
                    $payload.Add('headerObject', $headerObj)
                    $payload.Add('body', $body)
                    $validate = 'vmStatusInfoList'
                    $totalCount = (Submit-CVRESTRequest $payload $validate).Content.totalRecords
                    if ([String]::IsNullOrEmpty($Name)) { # vm name filter overrides paging functionality
                        $pagingObj = ValidatePagingParameters $PSCmdlet.PagingParameters $totalCount
                    }

                    if (-not $pagingObj.badParams) {
                        do {
                            $pagingInfo = '{startPage},{pageSize}'
                            
                            if ($pagingObj.paging) {
                                $pagingInfo = $pagingInfo -creplace ('{startPage}', $pagingObj.startPage)
                                $pagingInfo = $pagingInfo -creplace ('{pageSize}', $pagingObj.pageSize)
                            }
                            else { # TR - 190508-795
                                $pagingInfo = $pagingInfo -creplace ('{startPage}', 0)
                                $pagingInfo = $pagingInfo -creplace ('{pageSize}', $totalCount)
                            }
                            
                            $pagingObj.startPage++

                            $headerObj = Get-CVRESTHeader $sessionObj -PagingInfo $pagingInfo
                            $payload.Clear()
                            $payload.Add('headerObject', $headerObj)
                            $payload.Add('body', $body)
                
                            $response = Submit-CVRESTRequest $payload $validate
            
                            if ($response.IsValid) {
                                foreach ($vmRecord in $response.Content.vmStatusInfoList) {
                                    if (-not [String]::IsNullOrEmpty($Name)) {
                                        if ($vmRecord.name -ne $Name) {
                                            continue
                                        }
                                    }
                                    Write-Output $vmRecord
                                    $processCount++
                                }
                
                                if ($pagingObj.paging) {
                                    if (($pagingObj.startPage * $pagingObj.pageSize) -ge $totalCount) {
                                        $pagingObj.paging = 0
                                    }
                                    else {
                                        Read-Host '[Enter] for next page'
                                    }
                                }
                            }
                            else {
                                $pagingObj.paging = 0
                            }
                        } until (-not $pagingObj.paging)
                    }
                }
            }
        }
        catch {
            throw $_
        }
    }

    end { Write-Debug -Message "$($MyInvocation.MyCommand): end"

        try {
            if ($PSCmdlet.PagingParameters.IncludeTotalCount) {
                [double] $accuracy = 1.0
                if ($runType -eq 'ById') { $PSCmdlet.PagingParameters.NewTotalCount(1, $accuracy) }
                else { $PSCmdlet.PagingParameters.NewTotalCount($totalCount, $accuracy) }
            }
    
            if ($Protected -and $runType -eq 'ByClient') {
                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): protected virtual machines with active subclients [$protectedByActiveSubclientCount]"
            }
            elseif ($PSCmdlet.ParameterSetName -ne 'ByClientObject' -and $processCount -eq 0 -and -not $pagingObj.badParams) {
                if (-not [String]::IsNullOrEmpty($Name)) {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): virtual machine not found having name [$Name]"
                }
                elseif ($Protected) {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no protected virtual machines found"
                }
                elseif ($UnProtected) {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no unprotected virtual machines found"
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no virtual machines found"
                }
            }
        }
        catch {
            throw $_
        }
    }
}