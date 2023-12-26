@echo off
setlocal enabledelayedexpansion

set "sourceFolder=C:\Path\To\Your\Folder"
set "destinationFolder=C:\Path\To\Your\Destination"

if not exist "%destinationFolder%" mkdir "%destinationFolder%"

for %%F in ("%sourceFolder%\*.*") do (
    set "sourceFile=%%~dpnxF"
    set "destinationFile=%destinationFolder%\%%~nxF"

    for %%A in (!sourceFile!) do for %%B in (!destinationFile!) do (
        set sourceDate=%%~tA
        set destDate=%%~tB

        if "!sourceDate!" gtr "!destDate!" (
            copy /Y "%%F" "%destinationFolder%"
            echo Copied: "%%F"
        )
    )
)

echo Done.