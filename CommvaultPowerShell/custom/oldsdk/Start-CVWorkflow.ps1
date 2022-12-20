Add-AEnums
function Start-CVWorkflow {
    <#
    .SYNOPSIS
        Method to start/execute a workflow on the CommServe.
    .DESCRIPTION
        Method to start/execute a workflow on the CommServe.
    .PARAMETER Name
        Specify workflow to be started by Name.
    .PARAMETER Id
        Specify workflow to be started by Id.
    .PARAMETER WorkflowObject
        Specify workflow to be started by WorkflowObject.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Start-CVWorkflow -Name DBMaintenance
        
    .EXAMPLE
        Start-CVWorkflow -Id 7
        
    .EXAMPLE
        Get-CVWorkflow -Name DBMaintenance | Start-CVWorkflow
        
    .OUTPUTS
        Outputs [PSCustomObject] containing start workflow result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByObject', SupportsShouldProcess = $True, ConfirmImpact = 'High')]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [String] $Name,
        
            [Parameter(Mandatory = $True, ParameterSetName = 'ById', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [Int32] $Id,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $WorkflowObject,
    
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
    
                if ($PSCmdlet.ParameterSetName -eq 'ByName') {
                    $workflowObj = Get-CVWorkflow -Name $Name
                    if ($null -ne $workflowObj) { 
                        $WorkflowObject = $workflowObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): workflow not found having name [$Name]"
                        return
                    }
                }
                elseif ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $workflowObj = Get-CVWorkflow -Id $Id
                    if ($null -ne $workflowObj) { 
                        $WorkflowObject = $workflowObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): workflow not found having Id [$Id]"
                        return
                    }
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{workflowName}', $WorkflowObject.entity.workflowName) 
    
                $inputObj = $null
               
                if ((HasProperty $WorkflowObject 'deployments') -and
                    (HasProperty $WorkflowObject.deployments[0] 'inputForm') -and
                    (HasProperty $WorkflowObject.deployments[0].inputForm 'entries')) {
                    $inputObj = $WorkflowObject.deployments[0].inputForm.entries
                }
                elseif ((HasProperty $WorkflowObject 'workflow') -and
                    (HasProperty $WorkflowObject.workflow 'schema') -and
                    (HasProperty $WorkflowObject.workflow.schema 'inputs') -and
                    (HasProperty $WorkflowObject.workflow.schema.inputs 'children')) {
                    $inputObj = $WorkflowObject.workflow.schema.inputs.children
                }
                
                if ($null -ne $inputObj) {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): enter inputs for workflow [$($WorkflowObject.entity.workflowName)]"
                    $first = $true
                    foreach ($input in $inputObj) {
                        if (HasProperty $input 'options') {
                            if (-not [String]::IsNullOrEmpty($input.displayName)) {
                                $value = $input.options | Out-GridView -PassThru -Title ($WorkflowObject.entity.workflowName + ': ' + $input.displayName)
                            }
                            else {
                                $value = $input.options | Out-GridView -PassThru -Title ($WorkflowObject.entity.workflowName + ': ' + $input.name)
                            }
                        }
                        else {
                            if (-not [String]::IsNullOrEmpty($input.displayName)) {
                                $value = Read-Host -Prompt $input.displayName
                            }
                            else {
                                $value = Read-Host -Prompt $input.name
                            }
                        }
    
                        if ($null -ne $value) {
                            if ($first) {
                                $first = $false
                                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint + '?'
                            }
                            else {
                                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint + '&'
                            }
                            $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint + $input.name + '=' + $value
                        }
                    }
                }
    
                $headerObj = Get-CVRESTHeader $sessionObj
                $body = ''
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'jobId'
    
                if ($Force -or $PSCmdlet.ShouldProcess($WorkflowObject.entity.workflowName)) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): start workflow request failed for [$($WorkflowObject.entity.workflowName)]"
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }


    function HasProperty($Object, $PropertyName)
{
    $PropertyName -in $Object.PSobject.Properties.Name
}