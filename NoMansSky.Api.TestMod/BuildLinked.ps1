# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/NoMansSky.Api.TestMod/*" -Force -Recurse
dotnet publish "./NoMansSky.Api.TestMod.csproj" -c Release -o "$env:RELOADEDIIMODS/NoMansSky.Api.TestMod" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location