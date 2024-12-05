Add-AEnums
function Get-CVJobDetail {
    <#
.SYNOPSIS
    Gets extended details for a job.

.DESCRIPTION
    Gets extended details for a job. JobId must be valid.

.PARAMETER Id
    Gets extended details for the job specified by Id.

.PARAMETER InfoType
	Gets additional job information.

.PARAMETER JobObject
    Gets extended details for the job specified by piped JobObject.

.EXAMPLE
    Get-CVJobDetail
    
.EXAMPLE
    Get-CVJobDetail -Id 175

.EXAMPLE
    Get-CVJob | Get-CVJobDetail

.EXAMPLE
    Get-CVJobDetail -Id 175 | Select-Object -ExpandProperty detailInfo

.EXAMPLE
    Get-CVJobDetail -Id 175 | Select-Object -ExpandProperty generalInfo

.EXAMPLE
    Get-CVJobDetail -Id 175 | Select-Object -ExpandProperty progressInfo

.EXAMPLE
    Get-CVJobDetail -Id 175 InfoType 1

.OUTPUTS
    Outputs [PSCustomObject] containing result.

.NOTES
    Author: Gary Stoops
    Company: Commvault
#>
    [Alias('Get-CVJobDetails')]
    [CmdletBinding(DefaultParameterSetName = 'ById')]
    [OutputType([PSCustomObject])]
    param(
        [Alias('JobId')]
        [Parameter(Mandatory = $True, ParameterSetName = 'ById')]
        [ValidateNotNullorEmpty()]
        [Int32] $Id,

        [Parameter(Mandatory = $False, ParameterSetName = 'ById', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
        [ValidateNotNullorEmpty()]
        [Int32] $InfoType,

        [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
        [ValidateNotNullorEmpty()]
        [System.Object] $JobObject
    )

    begin {
        Write-Debug -Message "$($MyInvocation.MyCommand): begin"

        try {
            if ($InfoType -eq 0) {
                $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                $endpointSave = $sessionObj.requestProps.endpoint  
            }
            else {
                $sessionObj = Get-CVSessionDetail 'GetJobById'
                $endpointSave = $sessionObj.requestProps.endpoint  
            }
        }
        catch {
            throw $_
        }
    }

    process {
        Write-Debug -Message "$($MyInvocation.MyCommand): process"

        try {
            if ($InfoType -gt 0) {
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $job_id = $Id
                }
                else {
                    $job_id = $JobObject.jobId
                }
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{jobId}', ($job_id))
                $sessionObj.requestProps.endpoint = -join ($sessionObj.requestProps.endpoint, "/AdvancedDetails?infoType=", $InfoType)
                $body = ''
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = ''

                $response = Submit-CVRESTRequest $payload $validate

                if ($response.IsValid) {
                    Write-Output $response.Content
                }
            }
            else {
                $sessionObj.requestProps.endpoint = $endpointSave

                $headerObj = Get-CVRESTHeader $sessionObj
                $jobObj = @{ }
                if ($PSCmdlet.ParameterSetName -eq 'ById') {
                    $jobObj.Add('jobId', $Id)
                }
                else {
                    $jobObj.Add('jobId', $JobObject.jobId)
                }
                $body = $jobObj | ConvertTo-Json -Depth 10
                $payload = @{ }
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'job'
    
                $response = Submit-CVRESTRequest $payload $validate
    
                if ($response.IsValid) {
                    Write-Output $response.Content.job.jobDetail
                }
            }

        }
        catch {
            throw $_
        }
    }

    end {
        Write-Debug -Message "$($MyInvocation.MyCommand): end"
    }
}