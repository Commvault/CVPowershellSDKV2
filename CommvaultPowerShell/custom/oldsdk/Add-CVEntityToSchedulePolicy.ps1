Add-AEnums
function Add-CVEntitytoSchedulePolicy {
    <#
    .SYNOPSIS
        Method to add an entity to a schedule policy
    .DESCRIPTION
        Method to add an entity to a schedule policy
    .LINK
        https://documentation.commvault.com/11.24/essential/48824_rest_api_post_schedule_policy_add_entity.html
    .PARAMETER taskId
        Schedule policy ID
    .OUTPUTS
        Outputs [PSCustomObject]
    .EXAMPLE
        PS C:\>$body = "subclientId=300"
        PS C:\>$policy = Get-CVSchedulePolicy -Name testpolicy
        PS C:\>$policy | Add-EntitytoSchedulePolicy -Body $body -Forc
        Output:
        errorMessage errorCode
        ------------ ---------
                             0
    .NOTES
        Author: Jnanesh D
        Company: Commvault
    #>
    
        [CmdletBinding(DefaultParameterSetName = 'Default')]
        [OutputType([PSCustomObject])]
        param(
            
            [Parameter(Mandatory= $True, ParameterSetName="ByObject", ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $taskObject,
    
            [Alias('RequestBody')]
            [Parameter(Mandatory = $True)]
            [ValidateNotNullorEmpty()]
            [PSObject] $Body,
    
            [Switch] $Force,
            
            # Parameter help description
            [Parameter(Mandatory= $True, ParameterSetName="ById")]
            [ValidateNotNullorEmpty()]
            [Int64] $taskId
    
        )
        begin{
            Write-Debug -Message "$($MyInvocation.MyCommand): process"
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
                if ($PSCmdlet.ParameterSetName -eq "ById"){
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{taskId}', $taskId)
                }
                else {
                    $taskId = $taskObject.task.taskId
                    $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{taskId}', $taskId)
                }
                
                $body = $Body
                $payload = @{ }
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'errorMessage'
    
                if ($Force) {
                    $response = Submit-CVRESTRequest $payload $validate
                    Write-Output $response.Content
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
                
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }