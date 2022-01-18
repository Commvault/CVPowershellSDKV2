#
# Package install script for 'CommvaultPSModule'
#
# Author: Sowmya
# Company: Commvault
#
# Original Source: © 2019 Rogier Langeveld, Waternet, NL
#

Function Main {

    [CmdletBinding()]
    param(
        [string]$scriptPath = $null
    )

    [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

    if ($scriptPath -eq "" -and $scriptPath -eq [String]::Empty)
    {
        $scriptPath = (Get-Location).Path
    } 
    
    #Initialize varibale 
    $ScriptDir = $scriptPath
    $binPath = (Split-Path $ScriptDir -Parent) + "\" + "bin"
    $compressedFolder = $ScriptDir + "\"+ "CommvaultPowerShell.0.1.0.zip"
    $extractedFolder = $ScriptDir + "\"+ "CommvaultPowerShell"

    $WorkingDir = $PSScriptRoot

    $packageName = "CommvaultPowerShell.0.1.0.nupkg"

    $packagePath = $ScriptDir + "\"+ $packageName
    if (-not (Test-Path $packagePath))
    {
        if (-not (Test-Path $binPath))
        {
        Write-Host("Please execute the script from the same path where you nuget packages are there")
        }
        else
        {
            $binPkgName = $binPath + "\"+ $packageName
            Copy-Item -Path $binPkgName -Destination $ScriptDir -Confirm:$False -Force
        }
    }


    try {
        #unBlocking the NUget file
         Write-Host -ForegroundColor Green 'UnBlocking the Nuget Package'
        Unblock-File -Path ($packagePath)

        #Extract the contents
         Write-Host -ForegroundColor Green 'Extracting nuget Package'
        $fileName = [io.path]::GetFileNameWithoutExtension($packageName)
        $file_name_arr = $fileName.split(".")
        $extractDir = $ScriptDir + "\"+ $file_name_arr[0]       
        Rename-Item -Path $packagePath -NewName ([io.path]::ChangeExtension($packageName, '.zip')) -Verbose
        $zippackagePath = $packagePath.Replace("nupkg", "zip")
        Expand-Archive $zippackagePath -DestinationPath $extractDir

        #remove unwanted files
        $folderList = @("package","_rels","[Content_Types].xml","CommvaultPowerShell.nuspec")
        foreach ($file in $folderList) {
        $filePath = $extractDir + "\"+ $file
         if(Test-Path $filePath)
         {
            Remove-Item -Recurse -Path $filePath -force -ErrorAction Ignore
        }
       }

        #copy the Folder
        Write-Host -ForegroundColor Green 'Copy the folders to Powershell Module'
        $ModulePaths = $env:PSModulePath.Split(";")
        foreach($path in $ModulePaths){
        $path_check =$path+ '\CommvaultPowerShell'
        if (-not (Test-Path $path_check))
        {
        Copy-Item -Recurse -Path $extractDir -Destination $path -Confirm:$False -Force
        }
        }

        #removing folder from Install
        Remove-Item -Recurse -Path $compressedFolder -force -ErrorAction Ignore
        Remove-Item -Recurse -Path $extractedFolder -force -ErrorAction Ignore

        #Import Module 
        Import-Module CommvaultPowerShell  
        Write-Host -ForegroundColor Green 'Imported the Module Sucessfully'
                 
            
    }
    catch {
        throw $_
    }
    }      
 
 
 Clear-Host
 Main 