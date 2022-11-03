Add-AEnums
function Remove-CVBlackoutWindow {
    <#
    .SYNOPSIS
        Method to remove/delete an blackout window rule from the CommServe.
    .DESCRIPTION
        Method to remove/delete an blackout window rule from the CommServe.
    .PARAMETER Id
        Specify blackout window rule to be removed by Id.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Remove-CVBlackoutWindow -Id 42
        
    .OUTPUTS
        Outputs [PSCustomObject] containing remove rule result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = 'High')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int32] $Id,
    
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
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{ruleId}', $Id)
                
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add("headerObject", $headerObj)
                $payload.Add("body", $body)
                $validate = ''
                    
                if ($Force -or $PSCmdlet.ShouldProcess($Id)) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): remove workflow request failed for Id [$Id]"
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }