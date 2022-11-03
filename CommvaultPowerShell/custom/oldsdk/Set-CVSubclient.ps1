Add-AEnums
function Set-CVSubclient {
    <#
    .SYNOPSIS
        Method to create a new subclient.
    .DESCRIPTION
        Method to create a new subclient.
    .PARAMETER Body
        Request body for the subclient creation : Refer to https://documentation.commvault.com/11.24/essential/49174_rest_api_post_subclient.html.
    .EXAMPLE
        PS C:\>$req =  @"
        {
            "subClientProperties": {
                "subClientEntity": {
                    "clientName": "Side1",
                    "appName": "File System",
                    "backupsetName": "DefaultBackupset",
                    "subclientName": "subclient001"
                }
            }
        }
        "@
        PS C:\>$propobj = $req | ConvertFrom-Json
        PS C:\>Set-CVSubclient -body $propobj
    .OUTPUTS
        Outputs [PSCustomObject]
    .NOTES
        Author: Jnanesh D
        Company: Commvault
    #>   
        [CmdletBinding(DefaultParameterSetName = 'Default',SupportsShouldProcess)]
        [OutputType([PSCustomObject])]
        param(
            [Alias('RequestBody')]
            [Parameter(Mandatory = $True)]
            [ValidateNotNullorEmpty()]
            [PSObject] $Body,
    
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
                $body = ($Body | ConvertTo-Json -Depth 10)
                $payload = @{ }
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'errorMessage'
    
                if ($Force -or $PSCmdlet.ShouldProcess($Body)) {
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