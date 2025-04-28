@ECHO OFF

REM Initialize a local scope
SETLOCAL

REM Change to solution folder
PUSHD "%~dp0"
CD..\..
RD..\Artefacts /S /Q >nul 2>nul
MD..\Artefacts >nul 2>nul

REM Publish the NuGet package
FOR /R %%a IN (*.nupkg) DO (
  XCOPY "%%a" "..\Artefacts"
  NUGET push %%a -Source https://api.nuget.org/v3/index.json
)

:EOF
POPD
ENDLOCAL
