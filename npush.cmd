@echo off
nuget push common\bin\*.nupkg  -Source https://api.nuget.org/v3/index.json
pause