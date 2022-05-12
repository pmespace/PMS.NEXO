@echo off
nuget push nexo.30\bin\*.nupkg  -Source https://api.nuget.org/v3/index.json
nuget push nexo.31\bin\*.nupkg  -Source https://api.nuget.org/v3/index.json
pause