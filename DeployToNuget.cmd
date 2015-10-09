rem .nuget\NuGet.exe setapikey e39ea-get-the-full-key-on-nuget.org

call CreateNuget.cmd
.nuget\NuGet.exe push nuget_packages\ApprovalTests.Asp.WebApi.1.0.?.nupkg
.nuget\NuGet.exe push nuget_packages\ApprovalTests.Asp.WebApi.1.0.?.symbols.nupkg

pause 