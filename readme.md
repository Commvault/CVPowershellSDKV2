CVPowershellSDKV2
===============

<ul>
<li>
CVPowershellSDKV2 is a Windows PowerShell package for Commvault software which offers variety of cmdlets including the commandlets already existing powershell module.
</li>
<li>
CVPowershellSDKV2 uses the Commvault REST API to perform operations on a CommCell via the WebConsole.</li>
</ul>

<h2>
The latest version of the SDK combines both the CVPowershellSDK and CVPowershellSDKV2 . Using the same session a user can execute the commandlets of both the SDKs
</h2>

Requirements
------------
- Windows PowerShell version 5.1 or above
- Commvault Software v11 SP28 or later release with WebServer installed

Installation
------------
- Install-Module -Name CommvaultPowerShell

Status
------------
[![CommvaultPowerShell](https://img.shields.io/powershellgallery/v/CommvaultPowerShell.svg?style=flat-square&label=CommvaultPowerShell "CommvaultPowerShell")](https://www.powershellgallery.com/packages/CommvaultPowerShell/)

Link to the PowershellGallery
-------------
- <a href="https://www.powershellgallery.com/packages/CommvaultPowerShell/">Latest version</a>
- Install/Update the module to the latest version from the gallery

Versions
-------------
Version <a href="https://www.powershellgallery.com/packages/CommvaultPowerShell/0.2.10">0.2.10</a> - SDK is supported on Commvault Version 2022E

Usage
-----
Login to Commcell:
- PS > Invoke-SetupLogin -Username "#username" -Password "#base64Encodedpassword" -WebServerURL "http://#csName/webconsole/api"

To get all the command:
-PS > Get-Command -Module CommvaultPowershell

- For information on any Commvault PowerShell command, run Get-Help [command] 
- For detailed examples on any Commvault PowerShell command, run Get-Help [command] -Examples, Get-Help [command] -Full
- Switch Parameter of any cmdlet if provided will pass true in the payload . If false has to be provided please use the syntax like -<Switch_Name>:$false
- To use a commandlet which accept data in hastable please create the hashtable with the model prefix. You can find the model prefix for a particular command using Get-help [command] -Full. Hashtable inputs are case sensitive. 
- For example : New-User requires an input Users which has a model [Commvault.Powershell.ICreateUser] . To create a hashtable for creating a user prefix the model before the curly braces which will populate the keys for which the values has to be updated. 
```
PS > $data = [Commvault.Powershell.Models.ICreateUser]@{}
PS > $data.Email
PS > $data.Email = "test@domain.com"
PS > $data.FullName = "Testuser "
PS > $data.Name = "Test"
PS > $data.Password = "QwVXRJZ4Fh1NhkA"
PS > $data.UserGroups = @{
>> id = 1
>> name = "master"
>> }
PS > $data.InviteUser = $false
PS > New-CVUser -Users $data

Output:

Guid                                 Id     Name
----                                 --     ----
F37D1722-BE70-430D-95BD-38775574D7A7 373668 Test

```
- Fill the required values in the hashtable created.
- Another way is to create entire hashtable  
``` 
$userdata = @{
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
 PS> New-CVUser -Users $userdata
```
<h3>Please visit swagger Api Explorer in commserver for more information on the payload structure for the cmdlets using POST , PUT APIs</h3>
<h3>Documentation about swagger : <a href="https://documentation.commvault.com/11.24/essential/107350_apiexplorer.html">link</a></h3>
