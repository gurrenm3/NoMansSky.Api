# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/NoMansSky.Api/*" -Force -Recurse
dotnet publish "./NoMansSky.Api.csproj" -c Release -o "$env:RELOADEDIIMODS/NoMansSky.Api" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location