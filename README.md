# appsettings.json and build solution problem #

## Solution 1 ##

Create symbol-link for appsettings.json file insite src folder

```powershell
mklink.exe appsettings.json Objectum.Cli\appsettings.json
```

## Solution 2 ##

Provide **/p:PropertyName=PropertyValue** command parameter to build process to overwrite default value

```powershell
dotnet build /p:AppSettingsPath=./Objectum.Cli/appsettings.json
```