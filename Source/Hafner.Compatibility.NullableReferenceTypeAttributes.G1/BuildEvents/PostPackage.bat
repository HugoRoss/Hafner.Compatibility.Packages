@ECHO OFF

REM Initialize a local scope
SETLOCAL

REM Change to project folder
PUSHD "%~dp0"
CD..

REM Ensure Artefacts folder exists
MD..\..\Artefacts >nul 2>nul

REM Publish the NuGet package to nuget.org and the Artefacts folder
FOR /R %%a IN (*.nupkg) DO (
  XCOPY "%%a" "..\..\Artefacts" /R
  NUGET push %%a -Source https://api.nuget.org/v3/index.json -SkipDuplicate
)

:EOF
POPD
ENDLOCAL
