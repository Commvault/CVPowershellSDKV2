using namespace System.Management.Automation;

Add-AEnums

function Get-CVSessionDetail {
    [Alias('Get-CVSessionDetails')]
    [CmdletBinding()]
    [OutputType([HashTable])]
    param([String] $MethodName)

    begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"

        try {
            $output = @{ }
        }
        catch {
            throw $_
        }
    }

    process { Write-Debug -Message "$($MyInvocation.MyCommand): process"

        try {
            

            $sessionToken = [System.Environment]::GetEnvironmentVariable('CVToken')
            $requestProps = (GetAPIDetail -request $MethodName)
            $output.Add('sessionToken', $sessionToken)
            $output.Add('requestProps', $requestProps)
            $output.Add('server', [System.Environment]::GetEnvironmentVariable('WebServerUrl'))
        }
        catch {
            $PSCmdlet.ThrowTerminatingError($_) 
        }
        finally {
            Write-Output $output
        }
    }

    end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
    }
}
