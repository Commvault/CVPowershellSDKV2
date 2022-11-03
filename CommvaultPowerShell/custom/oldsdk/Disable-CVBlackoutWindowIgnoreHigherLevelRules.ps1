function Disable-CVBlackoutWindowIgnoreHigherLevelRules {
    <#
    .SYNOPSIS
        Method to disable 'ignore CommCell higher-level blackout window rules' by entity.
    .DESCRIPTION
        Method to disable 'ignore CommCell higher-level blackout window rules' by entity.
    .PARAMETER ClientId
        Specify entity by ClientId.
    .PARAMETER AppTypeId
        Specify entity by AppTypeId.
    .PARAMETER InstanceId
        Specify entity by InstanceId.
    .PARAMETER BackupsetId
        Specify entity by BackupsetId.
    .PARAMETER SubclientId
        Specify entity by SubclientId.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Disable-CVBlackoutWindowIgnoreHigherLevelRules -SubclientId 4
        
    .OUTPUTS
        Outputs [PSCustomObject] containing result code.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding()]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int32] $ClientId,
    
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int32] $AppTypeId,
            
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int32] $InstanceId,
    
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int32] $BackupsetId,
            
            [Parameter(Mandatory = $False, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int32] $SubclientId,
    
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
                ProcessBlackoutWindowIgnoreHigherLevelRules $sessionObj $ClientId $AppTypeId $InstanceId $BackupsetId $SubclientId $Force.IsPresent
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }

    function ProcessBlackoutWindowIgnoreHigherLevelRules {
        [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = 'High')]
        [OutputType([PSCustomObject])]
        param(
            [System.Object] $Session,
            [Int32] $ClientId,
            [Int32] $AppTypeId,
            [Int32] $InstanceId,
            [Int32] $BackupsetId,
            [Int32] $SubclientId,
            [bool] $Force
        )
    
        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{clientId}', $ClientId)
        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{appTypeId}', $AppTypeId)
        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $InstanceId)
        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{backupsetId}', $BackupsetId)
        $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{subclientId}', $SubclientId) 
    
        $headerObj = Get-CVRESTHeader $sessionObj
        $body = ''
        $payload = @{ }
        $payload.Add("headerObject", $headerObj)
        $payload.Add("body", $body)
            
        $validate = 'error'
    
        if ($Force -or $PSCmdlet.ShouldProcess($sessionObj.requestProps.endpoint)) {
            $response = Submit-CVRESTRequest $payload $validate
        
            if ($response.IsValid) {
                if ($response.Content.error.errorCode -eq 0) {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand.Name): request was successful"      
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand.Name): request failed: [$($response.Content.error)]"
                }
            } 
            else {
                Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand.Name): request failed: [$($response.Content)]"      
            }
        }
        else {
            $response = Submit-CVRESTRequest $payload $validate -DryRun
        }
    }
    