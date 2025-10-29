Add-AEnums
function Restore-CVSQLDatabase { 
    <#
    .SYNOPSIS
        Method to submit SQL database in-place or out-of-place restore job (V2).
    .DESCRIPTION
        Method to submit SQL database in-place or out-of-place restore job (V2).
        
    .PARAMETER Name
        Specify the database files to be restored by database Name.
    .PARAMETER DatabaseObject
        Specify the database files to be restored by piping DatabaseObject.
    .PARAMETER PointInTime
        Specify the database files to be restored by PointInTime.
    .PARAMETER CopyPrecedence
        Specify the database files to be restored by the CopyPrecedence applicable to your environment.
    .PARAMETER DestClientName
        Restore out-of-place the SQL database files to DestClientName. Required when using -OutofPlace.
    .PARAMETER DestInstanceName
        Restore out-of-place the SQL database files to DestInstanceName. Required when using -OutofPlace.
    .PARAMETER DestDatabaseName
        Restore out-of-place the SQL database files to DestDatabaseName. Required when using -OutofPlace.
    .PARAMETER DataFilePath
        Restore out-of-place the SQL database data files to DataFilePath. Required when using -OutofPlace.
    .PARAMETER LogFilePath
        Restore out-of-place the SQL database log files to LogFilePath. Required when using -OutofPlace.
    .PARAMETER OutofPlace
        Switch to initiate an out-of-place restore.
    .PARAMETER OverwriteExisting
        Switch to control OverwriteExisting of the database files.
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        Restore-CVSQLDatabase -DatabaseObject $database_obj
        
        Performs an in-place restore of the AuditDB database.
    .EXAMPLE
        Restore-CVSQLDatabase -DatabaseObject $database_obj -OverwriteExisting
        
        Performs an in-place restore and overwrites existing database files.
    .EXAMPLE
        Restore-CVSQLDatabase -DatabaseObject $database_obj -OutofPlace -DestClientName "Server02" -DestInstanceName "MSSQLSERVER" -DestDatabaseName "AuditDB_Restore" -DataFilePath "D:\Data" -LogFilePath "E:\Logs" -OverwriteExisting
        
        Performs an out-of-place restore to a different server and instance.
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
        [Switch] $Force,

        # Static optional parameters for out-of-place restore
        [Parameter(Mandatory = $False)]
        [String] $DestClientName,
        
        [Parameter(Mandatory = $False)]
        [String] $DestInstanceName,
        
        [Parameter(Mandatory = $False)]
        [String] $DestDatabaseName,
        
        [Parameter(Mandatory = $False)]
        [String] $DataFilePath,
        
        [Parameter(Mandatory = $False)]
        [String] $LogFilePath
    )

    begin { 
        Write-Debug -Message "$($MyInvocation.MyCommand): begin"

        try {
            $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
            $endpointSave = $sessionObj.requestProps.endpoint
        }
        catch {
            throw $_
        }
    }

    process { 
        Write-Debug -Message "$($MyInvocation.MyCommand): process"

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
                # Validate all required out-of-place parameters are provided
                if ([string]::IsNullOrWhiteSpace($DestClientName) -or 
                    [string]::IsNullOrWhiteSpace($DestInstanceName) -or 
                    [string]::IsNullOrWhiteSpace($DestDatabaseName) -or 
                    [string]::IsNullOrWhiteSpace($DataFilePath) -or 
                    [string]::IsNullOrWhiteSpace($LogFilePath)) {
                    throw [System.ArgumentException]::new("When using -OutofPlace, you must provide all destination parameters: DestClientName, DestInstanceName, DestDatabaseName, DataFilePath, and LogFilePath.")
                }

                $clientObj = Get-CVSQLClientDetail -Name $DestClientName
                if ($null -eq $clientObj) { 
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): destination client not found having name [$DestClientName]"      
                    return
                }
    
                # FIXED: Changed from $DestClientName to $DestInstanceName in the Where-Object filter
                $instanceObj = Get-CVSQLInstance -Name $DestInstanceName | Where-Object { $_.insName -ieq $DestInstanceName }
                if ($null -eq $instanceObj) { 
                    Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): destination instance not found having name [$DestInstanceName]"      
                    return
                }

                $destEntity.Add('clientId', $clientObj.cId)
                $destEntity.Add('instanceId', $instanceObj.insId)

                $body.Add('destinationDatabaseName', $DestDatabaseName)
                $body.Add('dataFilePath', $DataFilePath)
                $body.Add('logFilePath', $LogFilePath)
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
        catch {
            throw $_
        }
    }

    end { 
        Write-Debug -Message "$($MyInvocation.MyCommand): end"
    }
}