if(($null -eq $TestName) -or ($TestName -contains 'Invoke-CVBrowseHypervisorInventory'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-CVBrowseHypervisorInventory.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-CVBrowseHypervisorInventory' {
    It 'Browse' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'BrowseViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}