Add-AEnums
function Restore-CVSQLDatabase { 
    <#
    .SYNOPSIS
        Method to submit SQL database in-place or out-of-place restore job.
    .DESCRIPTION
        Method to submit SQL database in-place or out-of-place restore job.
        
    .PARAMETER Name
        Specify the database files to be restored by database Name.
    .PARAMETER DatabaseObject
        Specify the database files to be restored by piping DatabaseObject.
    .PARAMETER PointInTime
        Specify the database files to be restored by PointInTime.
    .PARAMETER CopyPrecedence
        Specify the database files to be restored by the CopyPrecedence applicable to your environment.
    .PARAMETER DestClientName
        Restore out-of-place the SQL database files to DestClientName.
    .PARAMETER DestInstanceName
        Restore out-of-place the SQL database files to DestInstanceName.
    .PARAMETER DestDatabaseName
        Restore out-of-place the SQL database files to DestDatabaseName.
    .PARAMETER DataFilePath
        Restore out-of-place the SQL database data files to DataFilePath.
    .PARAMETER LogFilePath
        Restore out-of-place the SQL database log files to LogFilePath.
    .PARAMETER OutofPlace
        Switch to initiate an out-of-place restore.
    .PARAMETER OverwriteExisting
        Switch to control OverwriteExisting of the database files.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Restore-CVSQLDatabase
    .EXAMPLE
        Restore-CVSQLDatabase -Name AuditDB -OverwriteExisting
    .EXAMPLE
        Restore-CVSQLDatabase -Name AuditDB -OverwriteExisting -OutofPlace
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(DefaultParameterSetName = 'ByName', SupportsShouldProcess = $True, ConfirmImpact = 'High')]
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
            [Int32] $PointInTime,
    
            [Parameter(Mandatory = $False)]   
            [Int32] $CopyPrecedence,
    
            [Switch] $OutofPlace,
            [Switch] $OverwriteExisting,
            [Switch] $Force
        )
        
        DynamicParam {
            if ($OutofPlace) {
                $paramDictionary = New-Object System.Management.Automation.RuntimeDefinedParameterDictionary
    
                $destClientNameAttrColl = new-object System.Collections.ObjectModel.Collection[System.Attribute]
                $destClientNameAttr = New-Object System.Management.Automation.ParameterAttribute
                $destClientNameAttr.Mandatory = $true
                $destClientNameAttr.HelpMessage = 'out-of-place restore destination client name'
                $destClientNameAttrColl.Add($destClientNameAttr)
                $destClientNameParam = New-Object System.Management.Automation.RuntimeDefinedParameter('DestClientName', [String], $destClientNameAttrColl)
                $paramDictionary.Add('DestClientName', $destClientNameParam)
    
                $destInstanceNameAttrColl = new-object System.Collections.ObjectModel.Collection[System.Attribute]
                $destInstanceNameAttr = New-Object System.Management.Automation.ParameterAttribute
                $destInstanceNameAttr.Mandatory = $true
                $destInstanceNameAttr.HelpMessage = 'out-of-place restore destination instance name'
                $destInstanceNameAttrColl.Add($destInstanceNameAttr)
                $destInstanceNameParam = New-Object System.Management.Automation.RuntimeDefinedParameter('DestInstanceName', [String], $destInstanceNameAttrColl)
                $paramDictionary.Add('DestInstanceName', $destInstanceNameParam)
    
                $destDatabaseNameAttrColl = new-object System.Collections.ObjectModel.Collection[System.Attribute]
                $destDatabaseNameAttr = New-Object System.Management.Automation.ParameterAttribute
                $destDatabaseNameAttr.Mandatory = $true
                $destDatabaseNameAttr.HelpMessage = 'out-of-place restore destination database name'
                $destDatabaseNameAttrColl.Add($destDatabaseNameAttr)
                $destDatabaseNameParam = New-Object System.Management.Automation.RuntimeDefinedParameter('DestDatabaseName', [String], $destDatabaseNameAttrColl)
                $paramDictionary.Add('DestDatabaseName', $destDatabaseNameParam)
    
                $dataFilePathAttrColl = new-object System.Collections.ObjectModel.Collection[System.Attribute]
                $dataFilePathAttr = New-Object System.Management.Automation.ParameterAttribute
                $dataFilePathAttr.Mandatory = $true
                $dataFilePathAttr.HelpMessage = 'out-of-place restore data files path'
                $dataFilePathAttrColl.Add($dataFilePathAttr)
                $dataFilePathParam = New-Object System.Management.Automation.RuntimeDefinedParameter('DataFilePath', [String], $dataFilePathAttrColl)
                $paramDictionary.Add('DataFilePath', $dataFilePathParam)
    
                $logFilePathAttrColl = new-object System.Collections.ObjectModel.Collection[System.Attribute]
                $logFilePathAttr = New-Object System.Management.Automation.ParameterAttribute
                $logFilePathAttr.Mandatory = $true
                $logFilePathAttr.HelpMessage = 'out-of-place restore log files path'
                $logFilePathAttrColl.Add($logFilePathAttr)
                $logFilePathParam = New-Object System.Management.Automation.RuntimeDefinedParameter('LogFilePath', [String], $logFilePathAttrColl)
                $paramDictionary.Add('LogFilePath', $logFilePathParam)
    
                return $paramDictionary
           }
        }
    
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
                [System.Object] $clientObj = $null
    
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
                if ($PointInTime -gt 0) {
                    $body.Add('pointInTimeValue', $PointInTime)
                }
                $body.Add('overwriteFiles', $OverwriteExisting.IsPresent)
                $body.Add('copyPrecedence', $CopyPrecedence)
    
                $destEntity = @{}
                if ($OutofPlace) {
                    $clientObj = Get-CVSQLClientDetail -Name $PSBoundParameters.DestClientName
                    if ($null -eq $clientObj) { 
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): destination client not found having name [$($PSBoundParameters.DestClientName)]"      
                        return
                    }
        
                    $instanceObj = Get-CVSQLInstance -Name $PSBoundParameters.DestInstanceName | Where-Object { $_.insName -ieq $PSBoundParameters.DestClientName }
                    if ($null -eq $instanceObj) { 
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): destination instance not found having name [$($PSBoundParameters.DestInstanceName)]"      
                        return
                    }
    
                    $destEntity.Add('clientId', $clientObj.cId)
                    $destEntity.Add('instanceId', $instanceObj.insId)
    
                    $body.Add('destinationDatabaseName', $PSBoundParameters.DestDatabaseName)
                    $body.Add('dataFilePath', $PSBoundParameters.DataFilePath)
                    $body.Add('logFilePath', $PSBoundParameters.LogFilePath)
                }
                else {
                    $destEntity.Add('clientId', $DatabaseObject.cId)
                }
                $body.Add('destinationEntity', $destEntity)
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
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): restore request declined for database [$($DatabaseObject.dbName)]"      
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
            