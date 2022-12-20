Add-AEnums
function Remove-CVSQLClone { #GRS-WORKINPROGRESS
    <#
    .SYNOPSIS
        Method to retrieve SQL clone information.
    .DESCRIPTION
        Method to retrieve SQL clone information.
        
    .PARAMETER ClientName
        Get clone information filtered by ClientName.
    .PARAMETER ClientId
        Get clone information filtered by ClientId.
    .PARAMETER ClientObject
        Get clone information filtered by piping ClientObject.
    .PARAMETER InstanceName
        Get clone information filtered by InstanceName.
    .PARAMETER InstanceId
        Get clone information filtered by InstanceId.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Get-CVSQLClone -ClientName vosql7
    .EXAMPLE
        Get-CVSQLClone -ClientId 104
    .EXAMPLE
        Get-CVSQLClone -ClientId 104 -InstanceId 109
    .EXAMPLE
        Get-CVClient | Get-CVSQLClone
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ById', SupportsShouldProcess = $True, ConfirmImpact = 'High')]
        [OutputType([String])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $InstanceId,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ById')]
            [ValidateNotNullorEmpty()]
            [Int32] $CloneId,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $InstanceName,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $CloneObject,
    
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
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $InstanceId)
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{cloneId}', $CloneId)
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    $instanceObj = Get-CVSQLInstance -Name $InstanceName
                    if ($null -ne $instanceObj) { 
                        $CloneId = Read-Host 'CloneId'
                        if ($CloneId -gt 0) {
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $instanceObj.insId)
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{cloneId}', $CloneId)
                        }
                        else {
                            Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): clone id must be greater than 0"      
                            return
                        }
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): instance not found having name [$InstanceName]"      
                        return
                    }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ByObject') {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $CloneObject.insId)
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{cloneId}', $CloneObject.Id)
                }
    
                # noop here if already replaced
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $null)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{cloneId}', $null)
    
                #GRS-WORKINPROGRESS
                $body = @{}
                $body.Add('overwriteDatabase', $OverwriteDatabase.IsPresent)
                $body.Add('destinationDatabaseName', '')
                $body.Add('copyPrecedence', 0)
                $body.Add('expireDays', 0)
                $destClient = @{}
                $destClient.Add('clientId', 0)
                $destClient.Add('clientName', '')
                $body.Add('destinationClient', $destClient)
                $body = ($body | ConvertTo-Json -Depth 10)
    
                $payload = @{}
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'taskId'
    
                if ($Force -or $PSCmdlet.ShouldProcess('remove clone?')) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
                
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): clone removal request declined"      
                }
            }
            catch
            {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }