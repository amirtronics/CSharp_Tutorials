@echo off
setlocal enabledelayedexpansion

set repo_path=C:\Work\Codes\HMI\VS\CSharp_Tutorials
set file_names=Program.cs SharpTutorial.csproj
set "episodeName=Ep2_SyntaxBasics"

set "sln_commit=false"

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