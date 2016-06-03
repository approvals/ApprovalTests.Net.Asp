rem .nuget\NuGet.exe setapikey e39ea-get-the-full-key-on-nuget.org

call CreateNuget.cmd
.nuget\NuGet.exe push nuget_packages\ApprovalTests.Asp.1.?.?.nupkg
.nuget\NuGet.exe push nuget_packages\ApprovalTests.Asp.1.?.?.symbols.nupkg

pause 