 param($installPath, $toolsPath, $package)
 &{




    function Get-KtVsComService([type] $serviceType) {
        # Microsoft.VisualStudio.Shell.ServiceProvider hands back the managed service object
        # instead of a COM object, but it fails if more than one instance of VS is running.

        $serviceGuid = [System.Drawing.Design.IToolboxService].Guid

        $args = $serviceGuid, $serviceGuid, $null

        $hr = [Microsoft.VisualStudio.OLE.Interop.IServiceProvider].
            GetMethod([string] 'QueryService', [type[]] @([guid].MakeByRefType(), [guid].MakeByRefType(), [System.IntPtr].MakeByRefType())).
            Invoke($dte, $args)

        return [System.Runtime.InteropServices.Marshal]::GetObjectForIUnknown($args[2])
    }

    function Install-KtToolboxItems([string] $assemblyPath, [string] $tabName) {

        $assemblyName = [System.Reflection.AssemblyName]::GetAssemblyName($assemblyPath)

        # TODO: Read the whole running object table and do this for each instance of VS
        # because last instance to close overwrites the toolbox on disk.
        $toolboxService = Get-KtVsComService ([type] [System.Drawing.Design.IToolboxService])

        [System.Drawing.Design.IToolboxService].
            GetMethod([string] 'GetToolboxItems', [type[]] @([string])).
            Invoke($toolboxService, @($tabName)) |
            where { $_.AssemblyName.Name -eq $assemblyName.Name  } |
            foreach {
                [System.Drawing.Design.IToolboxService].
                    GetMethod([string] 'RemoveToolboxItem', [type[]] @([System.Drawing.Design.ToolboxItem], [string])).
                    Invoke($toolboxService, @([System.Drawing.Design.ToolboxItem] $_, $tabName))
            }

        # DTE method of adding toolbox items only works if a Windows Forms designer window is open somewhere.
        # DTE method also causes toolbox to flash the new tab before it's filled while at the NuGet package manager.
        # Doing this manually gives us control over the order.
        # Loosely based on https://msdn.microsoft.com/en-us/library/bb166237.aspx

        [System.Reflection.Assembly]::LoadFrom($assemblyPath).
            GetExportedTypes() |
            where { !$_.IsAbstract -and !$_.IsGenericType -and [System.ComponentModel.IComponent].IsAssignableFrom($_) } |
            foreach {
                $attr = $_.GetCustomAttributes([System.ComponentModel.ToolboxItemAttribute], $true) | select -first 1

                if ($attr -ne $null) {
                    if ($attr.ToolboxItemType -eq $null) { return }

                    $ctor = $attr.ToolboxItemType.GetConstructor(@([type]))
                    if ($ctor -ne $null) { return $ctor.Invoke(@([type] $_)) }

                    $ctor = $attr.ToolboxItemType.GetConstructor(@())
                    if ($ctor -ne $null) { return $ctor.Invoke(@()) }
                }

                return [System.Drawing.Design.ToolboxItem]::new($_)
            } |
            sort DisplayName |
            foreach {
                [System.Drawing.Design.IToolboxService].
                    GetMethod([string] 'AddToolboxItem', [type[]] @([System.Drawing.Design.ToolboxItem], [string])).
                    Invoke($toolboxService, @([System.Drawing.Design.ToolboxItem] $_, $tabName))
            }

        $toolboxService.Refresh()
    }

    function Get-KtProjectTargetFramework {
            param (
                [string]$projectFilePath
            )

            # Ensure the project file exists
            if (Test-Path $projectFilePath) {
                # Read the project file content
                $csprojContent = Get-Content $projectFilePath

                # Check for .NET Core, .NET Framework, or .NET 5 and later
                if ($csprojContent -match "<TargetFramework>(.*?)</TargetFramework>") {
                    return $matches[1]
                } elseif ($csprojContent -match "<TargetFrameworks>(.*?)</TargetFrameworks>") {
                    return $matches[1]
                } else {
                    return $null
                }
            } else {
                return $null
            }
           }

    function Get-KtIsNETCore {
        param (
            [string]$projectFilePath
        )

        $targetFramework = Get-KtProjectTargetFramework -projectFilePath $projectFilePath
        if ($targetFramework -like "netcoreapp*") {
            return $true
        } elseif ($targetFramework -like "net8*" -or $targetFramework -like "net7*" -or $targetFramework -like "net6*") {
            return $true
        } else {
            return $false
        }
    }

    function Get-KtIsNETFramework {
        param (
            [string]$projectFilePath
        )

        if (Test-Path $projectFilePath) {
          $fileContent = Get-Content $projectFilePath
          $fileContent =   $fileContent -replace '\s+', ''
            if ($fileContent -match "</TargetFrameworkVersion>") {
               return $true
            } 
        }
       return $false 
    }
    function Get-KtVersion {
        param (
            [string]$versionString
        )

        # Use regex to remove the part after the '+' symbol
        $fixedVersionString = $versionString -replace '\+.*$', ''

        return $fixedVersionString
    }
     
        Clear-Host

        $assemblyPath = [System.IO.Path]::GetFullPath("$PSScriptRoot\design\KimTools.WinForms.dll")

        $versionInfo = [System.Diagnostics.FileVersionInfo]::GetVersionInfo($assemblyPath)
       
        $project = Get-Project
        $projectFilePath = $project.FullName
    
        # Install only of TargetFramework is .NET Framework
        $isNETFramework = Get-KtIsNETFramework -projectFilePath $projectFilePath
     
        if ($isNETFramework) { 
            Install-KtToolboxItems $assemblyPath -tabName "$($versionInfo.ProductName)" 
            Write-Output "✓ Installing .NET Framework KimTools toolbox"
        } else { 
             Write-Output "✓ Installing .NET KimTools toolbox"
        }

            Write-Output "✓ KimTools SDK Tools Installed"
           # Read the contents of the file
        $welcomeTxtPath = [System.IO.Path]::GetFullPath("$PSScriptRoot\Welcome.txt")

        $content = Get-Content $welcomeTxtPath
    
        # Print the Welcome to the user
        $ktVersion= Get-KtVersion -$versionString $versionInfo.ProductVersion
        Write-Output $content
         if ($isNETFramework) { 
             Write-Output "Version: $($ktVersion)" 
         }
        Write-Output ""
        Write-Output ""
    }
