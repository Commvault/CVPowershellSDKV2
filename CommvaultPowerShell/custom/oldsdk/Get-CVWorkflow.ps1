Add-AEnums
function Get-CVWorkflow {
    <#
    .SYNOPSIS
        Method to retrieve workflows from the CommServe.
    .DESCRIPTION
        Method to retrieve workflows from the CommServe. Output can be filtered by workflow Name or Id.
    .PARAMETER Name
        Specify the workflow to be output by Name.
    .PARAMETER Id
        Specify the workflow to be output by Id.
    .EXAMPLE
        Get-CVWorkflow
        
    .EXAMPLE
        Get-CVWorkflow -Name DBMaintenance
        
    .EXAMPLE
        Get-CVWorkflow -Id 7
        
    .OUTPUTS
        Outputs [PSCustomObject] containing workflow(s).
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByList')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $False, ParameterSetName = 'ByName', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [String] $Name,
        
            [Parameter(Mandatory = $False, ParameterSetName = 'ById', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int32] $Id
        )
        
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $sessionObj = Get-CVSessionDetail 'GetWorkflowDetail'
                }
                else {
                    $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                }
                $endpointSave = $sessionObj.requestProps.endpoint
                $outputCount = 0
            }
            catch {
                throw $_
            }
        }
        
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
        
            try {
                $sessionObj.requestProps.endpoint = $endpointSave
    
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{workflowId}', $Id)
                }
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add("headerObject", $headerObj)
                $payload.Add("body", $body)
                $validate = 'container'
    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    foreach ($workflow in $response.Content.container) {
                        if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                            if ($Name -eq $workflow.entity.workflowName) {
                                Write-Output $workflow
                                $outputCount++
                            }
                        }
                        else { # 'ByList'
                            Write-Output $workflow
                            $outputCount++
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
                if ($outputCount -eq 0) {
                    if ($PSCmdlet.ParameterSetName -eq 'ById') {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): workflow not found having Id [$Id]"
                    }
                    elseif ($PSCmdlet.ParameterSetName -eq 'ByName') {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): workflow not found having name [$name]"
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no workflows found"
                    }
                }
            }
            catch {
                throw $_
            }
        }
    }
      