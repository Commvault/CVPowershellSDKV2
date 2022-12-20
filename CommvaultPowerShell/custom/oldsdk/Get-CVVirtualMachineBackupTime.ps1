Add-AEnums
function Get-CVVirtualMachineBackupTime {
    <#
    .SYNOPSIS
        Method to retrieve the last backup details of virtual machines in the CommCell.
    .DESCRIPTION
        Method to retrieve the last backup details of virtual machines in the CommCell.
        
    .PARAMETER Name
        Filter output to virtual machine Name.
    .PARAMETER ClientName
        Filter output by active subclients of ClientName.
    .PARAMETER ClientObject
        Filter output by active subclients of ClientObject.
    .EXAMPLE
        Get-CVVirtualMachineBackupTime
    .EXAMPLE
        Get-CVVirtualMachineBackupTime -ClientName Openstack-V2-client
    .EXAMPLE
        Get-CVVirtualMachineBackupTime -ClientName Openstack-V2-client -Name autocs-winvm2
    .EXAMPLE
        Get-CVClient | Get-CVVirtualMachineBackupTime
    .OUTPUTS
        Outputs [PSCustomObject] representing virtual machine last backup details.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [Alias('Get-CVLastBackup')]
        [CmdletBinding(DefaultParameterSetName = 'Default')]
        param(
            [Alias('VMName')]
            [Parameter(Mandatory = $False)]
            [ValidateNotNullorEmpty()]
            [String] $Name,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'ByClient')]
            [ValidateNotNullorEmpty()]
            [String] $ClientName,
    
            [Parameter(Mandatory = $False, ParameterSetName = 'ByClient', ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $ClientObject
        )
    
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
            }
            catch {
                throw $_
            }
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
    
            try {
                if ($null -ne $ClientObject -and -not [String]::IsNullOrEmpty($Name)) {
                    $vmRecords = Get-CVVirtualMachine -Name $Name -ClientObject $ClientObject -Protected
                }
                elseif ($null -ne $ClientObject) {
                    $vmRecords = Get-CVVirtualMachine -ClientObject $ClientObject -Protected
                }
                elseif (-not [String]::IsNullOrEmpty($Name) -and -not [String]::IsNullOrEmpty($ClientName)) {
                    $vmRecords = Get-CVVirtualMachine -Name $Name -ClientName $ClientName -Protected
                }
                elseif (-not [String]::IsNullOrEmpty($Name)) {
                    $vmRecords = Get-CVVirtualMachine -Name $Name -Protected
                }
                elseif (-not [String]::IsNullOrEmpty($ClientName)) {
                    $vmRecords = Get-CVVirtualMachine -ClientName $ClientName -Protected
                }
                else {
                    $vmRecords = Get-CVVirtualMachine -Protected
                }
    
                if ($null -ne $vmRecords) {
                    foreach ($record in $vmRecords) {
                        $lastbackupTime = $record |`
                        Select-Object  @{Name='LastBackupTime';Expression={[timezone]::CurrentTimeZone.ToLocalTime(([datetime]'1/1/1970').AddSeconds($_.bkpEndTime))}}|`
                        Select-Object -ExpandProperty LastBackupTime
                        [PSCustomObject] $custom = New-Object PSObject
                        $custom | Add-Member -NotePropertyName 'Host' -NotePropertyValue $record.vmHost
                        $custom | Add-Member -NotePropertyName 'Agent' -NotePropertyValue $record.vmAgent
                        $custom | Add-Member -NotePropertyName 'Subclient' -NotePropertyValue $record.subclientName
                        $custom | Add-Member -NotePropertyName 'Name' -NotePropertyValue $record.name
                        $custom | Add-Member -NotePropertyName 'JobId' -NotePropertyValue $record.vmBackupJob
                        $custom | Add-Member -NotePropertyName 'BackupTime' -NotePropertyValue $lastbackupTime
                        
                        Write-Output $custom
                    }
                }
                else {
                    if (-not [String]::IsNullOrEmpty($Name)) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): last backup time not found having the virtual machine [$Name]"
                    }
                    elseif (-not [String]::IsNullOrEmpty($ClientName)) {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): last backup time(s) not found having client [$ClientName]"
                    }
                    else {
                        Write-Information -InformationAction Continue -MessageData "INFO: $($MyInvocation.MyCommand): no protected virtual machine records found"
                    }
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }