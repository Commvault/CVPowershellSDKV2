$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-CVDiskSpace.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-CVDiskSpace' {
    It 'ByLibraryName' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ByMediaAgentName' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ByLibraryObject' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
