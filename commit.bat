@echo off
setlocal enabledelayedexpansion

set repo_path=C:\Work\Codes\HMI\VS\WPF_Tutorials
set file_names=App.xaml App.xaml.cs AssemblyInfo.cs MainWindow.xaml MainWindow.xaml.cs WPFTutorial.csproj

for %%F in (%file_names%) do (
    
    set file_path=.\Ep24_RelayCommandMVVM\WPFTutorial\%%F
    set commit_message=Create Ep24 %%F

    cd %repo_path%
    echo !file_path!
    git add !file_path!

    git commit -m "!commit_message!"
    git push

    echo Commit and Push Complete!
)