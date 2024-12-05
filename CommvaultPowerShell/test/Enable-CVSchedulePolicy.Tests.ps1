if(($null -eq $TestName) -or ($TestName -contains 'Enable-CVSchedulePolicy'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Enable-CVSchedulePolicy.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Enable-CVSchedulePolicy' {
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
