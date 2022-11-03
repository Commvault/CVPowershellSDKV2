function Add-CVBlackoutWindow {
    <#
    .SYNOPSIS
        Method to add/create an blackout window rule.
    .DESCRIPTION
        Method to add/create an blackout window rule.
    .PARAMETER Properties
        Piped-in Properties set. 
    .PARAMETER Force
        Switch to Force override of default 'WhatIf' confirmation behavior.
    .EXAMPLE
        PS C:\>$props = @"
        {
            "operationWindow": {
                "endDate": 1521691200,
                "name": "Holiday_1",
                "startDate": 1520485200,
                "operations": [
                1,
                2
                ],
                "dayTime": [
                {
                    "startTime": 46800,
                    "endTime": 50400,
                    "dayOfWeek": [
                    1,
                    2
                    ]
                }
                ]
            },
            "entity": {
                "clientGroupId": 0,
                "clientId": 2
            }
        }"@    
        PS C:\>$propobj = $prop | ConvertFrom-Json
        PS C:\>$propobj | Add-CVBlackoutWindow -Force
    .OUTPUTS
        Outputs [PSCustomObject] containing job submission result.
    .NOTES
        Author: Gary Stoops
        Company: Commvault
    #>
        [CmdletBinding(SupportsShouldProcess = $True, ConfirmImpact = 'Medium')]
        [OutputType([PSCustomObject])]
        param(
            [Parameter(Mandatory = $True, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $True)]
            [ValidateNotNullorEmpty()]
            [System.Object] $Properties,
    
            [Switch] $Force
        )
    
        begin { Write-Debug -Message "$($MyInvocation.MyCommand): begin"
    
            try {
                $sessionObj = Get-CVSessionDetail $MyInvocation.MyCommand.Name
                $endpointSave = $sessionObj.requestProps.endpoint
            }
            catch {
                throw $_
            }
        }
    
        process { Write-Debug -Message "$($MyInvocation.MyCommand): process"
    
            try {
                $sessionObj.requestProps.endpoint = $endpointSave
                if ($Force -or ($PSCmdlet.ShouldProcess($Properties.operationWindow.name))) {
                    ProcessBlackoutWindowUpdate $sessionObj $Properties $False
                }
                else {
                    ProcessBlackoutWindowUpdate $sessionObj $Properties $True
                }
            }
            catch {
                throw $_
            }
        }
    
        end { Write-Debug -Message "$($MyInvocation.MyCommand): end"
        }
    }
    
    function ProcessBlackoutWindowUpdate([System.Object] $Session, [System.Object] $Properties, [bool] $DryRun) {
        <#
            ruleEnabled    : True
            doNotSubmitJob : False
            endDate        : 1588230000
            level          : 1
            name           : GRS-LaptopClientsBoR
            ruleId         : 1
            startDate      : 1588057200
            operations     : {1}
            company        : @{_type_=61; providerId=0; providerDomainName=Commcell}
            entity         : @{schedulePolicyId=0; subclientId=0; clientGroupId=4; applicationId=0; clientName=Laptop Clients; backupsetId=0; commCellName=carbonwincs1; instanceId=0; schedulePolicyName=; clientId=0; subclientName=; backupsetName=;
                            instanceName=; clientGroupName=Laptop Clients; _type_=0; appName=}
            dayTime        : {@{startTime=28800; endTime=64800; dayOfWeek=System.Object[]}}            {
        #>            
        $body = @{}
        $opWin = @{}
        if (HasProperty $Properties 'ruleEnabled') {
            $opWin.Add('ruleEnabled', $Properties.ruleEnabled)
        }
        if (HasProperty $Properties 'doNotSubmitJob') {
            $opWin.Add('doNotSubmitJob', $Properties.doNotSubmitJob)
        }
        if (HasProperty $Properties 'endDate') {
            $opWin.Add('endDate', $Properties.endDate)
        }
        if (HasProperty $Properties 'level') {
            $opWin.Add('level', $Properties.level)
        }
        if (HasProperty $Properties 'name') {
            $opWin.Add('name', $Properties.name)
        }
        if (HasProperty $Properties 'ruleId') {
            $opWin.Add('ruleId', $Properties.ruleId)
        }
        if (HasProperty $Properties 'startDate') {
            $opWin.Add('startDate', $Properties.startDate)
        }
        if (HasProperty $Properties 'operations') {
            $opWin.Add('operations', $Properties.operations)
        }
        if (HasProperty $Properties 'company') {
            $opWin.Add('company', $Properties.company)
        }
        if (HasProperty $Properties 'dayTime') {
            $opWin.Add('dayTime', $Properties.dayTime)
        }
        if (HasProperty $Properties "operationWindow"){
            $opWin = $Properties.operationWindow
        }
        $entity = $Properties.entity
        $body.Add('operationWindow', $opWin)
        $body.Add('entity', $entity)
        $body = ($body | ConvertTo-Json -Depth 10)
    
        $headerObj = Get-CVRESTHeader $sessionObj
        $payload = @{ }
        $payload.Add('headerObject', $headerObj)
        $payload.Add('body', $body)
        $validate = ''
    
        if (-not $DryRun) {
            $response = Submit-CVRESTRequest $payload $validate
        }
        else {
            $response = Submit-CVRESTRequest $payload $validate -DryRun
        }
    
        Write-Output $response.Content
    }

    function HasProperty($Object, $PropertyName)
    {
        $PropertyName -in $Object.PSobject.Properties.Name
    }