set CTCOPTS="-i m"
dotnet msbuild -property:CscToolPath="%CTCHOME%\ToolPath"
dotnet test --no-build