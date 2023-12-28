@echo off
setlocal enabledelayedexpansion

for /f "delims=" %%a in ('wmic OS Get localdatetime ^| find "."') do set datetime=%%a
set folderName=Ep10_WhileLoop
set projectName=SharpTutorial

mkdir %folderName%
cd %folderName%

dotnet new sln -n %projectName%
dotnet new console -n %projectName%

dotnet sln add %projectName%\%projectName%.csproj
start devenv.exe %projectName%.sln