@ECHO OFF

REM Initialize a local scope
SETLOCAL

REM Change to project folder
PUSHD "%~dp0"
CD..

REM Check args
SET ConfigurationName=%1
SET TargetFramework=%2
SET ConfigurationName=%ConfigurationName:"=%
SET TargetFramework=%TargetFramework:"=%
IF "%ConfigurationName%" EQU "" ECHO:Configuration not specified (arg 1) && EXIT -1
IF "%TargetFramework%" EQU "" ECHO:Target framework not specified (arg 2) && EXIT -1

REM Only do if solution configuration "NuGet" and only once (any framework will do)
IF /I "%ConfigurationName%|%TargetFramework%" NEQ "NuGet|net20" GOTO EOF
ECHO Deleting old NuGet packages...
DEL "bin\NuGet\*.nupkg" /S /Q 2>nul

:EOF
POPD
ENDLOCAL
