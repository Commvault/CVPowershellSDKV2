if(($null -eq $TestName) -or ($TestName -contains 'Invoke-CVVMActionRefresh'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-CVVMActionRefresh.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-CVVMActionRefresh' {
    It 'Post' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PostViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
