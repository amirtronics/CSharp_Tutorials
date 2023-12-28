@echo off
setlocal enabledelayedexpansion

REM Comment

set repo_path=C:\Work\Codes\HMI\VS\CSharp_Tutorials
set file_names=Program.cs SharpTutorial.csproj
set "episodeName=Ep18_MethodOverloading"

set "sln_commit=true"

for %%F in (%file_names%) do (
    
    set file_path=.\!episodeName!\SharpTutorial\%%F
    set commit_message=Create !episodeName! %%F

    cd %repo_path%
    echo !file_path!
    git add !file_path!

    git commit -m "!commit_message!"
    git push

    echo Commit and Push Complete!
)



if "%sln_commit%"=="true" (
    set file_path=.\!episodeName!\SharpTutorial.sln
    set commit_message=Create !episodeName! SharpTutorial.sln
    git add !file_path!

    git commit -m "!commit_message!"
    git push

    echo Commit and Push Complete!
)