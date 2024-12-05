Add-AEnums
function Set-CVManagedAccount {
    <#
    .SYNOPSIS
        Sets or resets the environment variable for the specified Lighthouse Account ID.
    .DESCRIPTION
        This cmdlet allows you to set the environment variable `lhAccountId` to the provided Lighthouse Account ID.
        If the `-Reset` flag is specified, it clears the `lhAccountId` environment variable.
    .PARAMETER lhAccountId
        The Lighthouse Account ID to set in the environment variable.
    .PARAMETER Reset
        A switch parameter that clears the `lhAccountId` environment variable when specified.
    .EXAMPLE
        Set-CVManagedAccount -lhAccountId "12345"
        Sets the `lhAccountId` environment variable to "12345".
    .EXAMPLE
        Set-CVManagedAccount -Reset
        Clears the `lhAccountId` environment variable.
    .OUTPUTS
        Writes a confirmation message to the console.
    #>
    [CmdletBinding()]
    param (
        [Parameter(Mandatory = $false, ParameterSetName = "Set", HelpMessage = "The Lighthouse Account ID to set.")]
        [ValidateNotNullOrEmpty()]
        [string]$lhAccountId,

        [Parameter(Mandatory = $true, ParameterSetName = "Reset", HelpMessage = "Clears the Lighthouse Account ID.")]
        [switch]$Reset
    )

    begin {
        Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    }

    process {
        if ($PSCmdlet.ParameterSetName -eq "Reset") {
            # Clear the environment variable
            [System.Environment]::SetEnvironmentVariable("lhAccountId", $null, [System.EnvironmentVariableTarget]::User)
            Write-Output "INFO: Environment variable 'lhAccountId' has been cleared."
        }
        else {
            if (-not $lhAccountId) {
                Write-Error -Message "ERROR: Please provide a valid Lighthouse Account ID."
                return
            }

            # Set the environment variable
            [System.Environment]::SetEnvironmentVariable("lhAccountId", $lhAccountId, [System.EnvironmentVariableTarget]::User)
            Write-Output "INFO: Environment variable 'lhAccountId' has been set to '$lhAccountId'."
        }
    }

    end {
        Write-Debug -Message "$($MyInvocation.MyCommand): end"
    }
}
