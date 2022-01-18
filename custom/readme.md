CVPowershellSDK -V2
===============
CVPowershellSDK -V2 is a Windows PowerShell package for Commvault software.

CVPowershellSDK uses the Commvault REST API to perform operations on a CommCell via the WebConsole.

Requirements
------------
- Windows PowerShell version 5.1 or above
- Commvault Software v11 SP26 or later release with WebServer installed

Installation
------------
After downloading and extracting the package, Go to Install folder and Run InstallCVModule-Auto as Administrator
- PS C:\Users\UserName\Downloads\PSSDK\Install> .\InstallCVModule-Auto.ps1


Usage
-----
Login to Commcell:
- PS > Invoke-SetupLogin -Username "#username" -Password "#Base64Encodedpassword" -WebServerURL "http://#csName/webconsole/api"

To get all the command:
-PS > Get-Command -Module CommvaultPowerShell

- For information on any Commvault PowerShell command, run Get-Help [command] 
- For detailed examples on any Commvault PowerShell command, run Get-Help [command] -Examples


Contributions
=============
Contributions are welcome; please do a pull request against the 'dev' branch.