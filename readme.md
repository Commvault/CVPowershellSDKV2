CVPowershellSDKV2
===============
CVPowershellSDKV2 is a Windows PowerShell package for Commvault software which offers variety of cmdlets apart from the already existing powershell module.

CVPowershellSDKV2 uses the Commvault REST API to perform operations on a CommCell via the WebConsole.

Requirements
------------
- Windows PowerShell version 5.1 or above
- Commvault Software v11 SP28 or later release with WebServer installed

Installation
------------
Download the Install Folder and Run InstallCVModule-Auto
- PS C:\Users\UserName\Downloads\PSSDK\Install> .\InstallCVModule-Auto.ps1


Usage
-----
Login to Commcell:
- PS > Invoke-SetupLogin -Username "#username" -Password "#base64Encodedpassword" -WebServerURL "http://#csName/webconsole/api"

To get all the command:
-PS > Get-Command -Module CommvaultPowershell

- For information on any Commvault PowerShell command, run Get-Help [command] 
- For detailed examples on any Commvault PowerShell command, run Get-Help [command] -Examples, Get-Help [command] -Full
- To use a commandlet which accept data in hastable please create the hashtable with the model prefix
- For example : New-User requires an input Users which has a model [Commvault.Powershell.ICreateUser] . To create a hashtable for creating a user prefix the model before the curly braces
```
  $userdata = [Commvault.Powershell.Models.ICreateUser]@{}
```
- Fill the required values in the hashtable created.
- Another way is to create entire hashtable by prepending the model 
``` 
$userdata = [Commvault.Powershell.Models.ICreateUser]@{
 Name = "TempUser"
 email = "Temp@tempdomain.com"
 FullName = "Temp User"
 Password = "XXXX"
 UserGroups = @{
 id = 1
 name = "master"
 }
 useSystemGeneratePassword = $false
 inviteUser = $false
 }
```
