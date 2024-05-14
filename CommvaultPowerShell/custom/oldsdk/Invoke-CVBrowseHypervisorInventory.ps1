Add-AEnums
function Invoke-CVBrowseHypervisorInventory {
    <#
    .Synopsis
        Browse the Inventory of your hypervisor
    .Description
        Browse the Inventory of your hypervisor : URL /V4/Hypervisor/{hypervisorId}/{InventoryEntityName}/Browse
    .Parameter hypervisorId
        Hypervisor client ID to browse
    .Parameter InventoryEntityName
        Name of the inventory entity that needs to be browsed like ESX Host name in VCenter
    #>
    [OutputType([PSCustomObject])]
    param(
        [Parameter(Mandatory=$True)]
        [ValidateNotNullorEmpty()]
        [Hashtable] $hypervisorId,

        [Parameter(Mandatory=$True)]
        [ValidateNotNullorEmpty()]
        [String] $InventoryEntityName
        )
    begin {Write-Debug "$($MyInvocation.MyCommand): begin"
        try{
            $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
            $endpointSave = $sessionObj.requestProps.endpoint
            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{hypervisorId}', $hypervisorId)
            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{InventoryEntityName}', $InventoryEntityName)
        }
        catch {
            throw $_
        }
    }
    process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
        try {
            $headerObj = Get-CVRESTHeader $sessionObj
            $body = ''
            $payload = @{ }
            $payload.Add('headerObject', $headerObj)
            $Body = ConvertTo-Json $Properties -Depth 10
            $payload.Add('body', $Body)

            $response = Submit-CVRESTRequest $payload 

            Write-Output $response.Content
        }
    
        catch {
            throw $_
        }
    }
}