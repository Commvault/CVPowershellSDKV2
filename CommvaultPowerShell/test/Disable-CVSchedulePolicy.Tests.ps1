if(($null -eq $TestName) -or ($TestName -contains 'Disable-CVSchedulePolicy'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Disable-CVSchedulePolicy.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Disable-CVSchedulePolicy' {
    It 'ByPolicyName' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ByPolicyId' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ByPolicyObject' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'BySubclient' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
