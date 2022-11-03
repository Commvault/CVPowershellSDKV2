Add-AEnums
function Mount-CVSQLDatabase { 
    <#
    .SYNOPSIS
        Method to submit SQL database mount job.
    .DESCRIPTION
        Method to submit SQL database mount job.
        
    .PARAMETER Name
        Mount the SQL database identified by Name.
    .PARAMETER DatabaseObject
        Mount the SQL database identified by DatabaseObject.
    .PARAMETER DestDatabaseName
        Mount the SQL database with DestDatabaseName.
    .PARAMETER ExpireDays
        Mount the SQL database with ExpireDays. Default: 30
    .PARAMETER OverwriteDatabase
        Switch to control OverwriteDatabase.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Mount-CVSQLDatabase
    .EXAMPLE
        Mount-CVSQLDatabase -Name AuditDB -OverwriteDatabase
    .EXAMPLE
        Mount-CVSQLDatabase -Name AuditDB -OverwriteDatabase -ExpiryDays 120
    .EXAMPLE
        Get-CVSQLDatabase | Mount-CVSQLDatabase -OverwriteDatabase -ExpiryDays 120
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByName', SupportsShouldProcess = $True, ConfirmImpact = 'Medium')]
        [OutputType([String])]
        param(
            [Parameter(Mandatory = $True, ParameterSetName = 'ByName')]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Parameter(Mandatory = $True, ParameterSetName = 'ByObject', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $DatabaseObject,
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $DestDatabaseName,
    
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [Int32] $ExpireDays=30,
    
            [Switch] $OverwriteDatabase,
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
                    $databaseObj = Get-CVSQLDatabase -Name $Name
                    if ($null -ne $databaseObj) { 
                        $DatabaseObject = $databaseObj
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): database not found having name [$Name]"      
                        return
                    }
                }
    
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{instanceId}', $DatabaseObject.insId)
                $sessionObj.requestProps.endpoint = $sessionObj.requestProps.endpoint -creplace ('{databaseId}', $DatabaseObject.dbId)
    
                $body = @{}
                $body.Add('overwriteDatabase', $OverwriteDatabase.IsPresent)
                $body.Add('destinationDatabaseName', $DestDatabaseName)
                $body.Add('expireDays', $ExpireDays)
                $body = ($body | ConvertTo-Json -Depth 10)
    
                $payload = @{}
                $headerObj = Get-CVRESTHeader $sessionObj
                $payload.Add('headerObject', $headerObj)
                $payload.Add('body', $body)
                $validate = 'taskId'
    
                if ($Force -or $PSCmdlet.ShouldProcess($DatabaseObject.dbName)) {
                    $response = Submit-CVRESTRequest $payload $validate
                }
                else {
                    $response = Submit-CVRESTRequest $payload $validate -DryRun
                }
    
                if ($response.IsValid) {
                    Write-Output $response.Content
                }
                else {
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): mount request declined for database [$($DatabaseObject.dbName)]"      
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