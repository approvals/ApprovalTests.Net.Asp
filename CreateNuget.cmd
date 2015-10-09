set version=1.0.0
if not exist .\nuget_packages mkdir nuget_packages
del /Q .\nuget_packages\*.*
.nuget\NuGet.exe pack ApprovalTests.Asp.WebApi\ApprovalTests.Asp.WebApi.csproj -OutputDirectory .\nuget_packages -Version %version% -symbols
pause 