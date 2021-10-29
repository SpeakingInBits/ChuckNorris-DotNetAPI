# ChuckNorris-DotNetAPI
This will be a .NET API for the [ICNDB (Internet of Chuck Norris Database)](http://icndb.com)

## Prerequisites
This project requires the [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/visual-studio-sdks) to be installed.  
If you would like to use a newer .NET you can double-click on the ApiTester project and modify the target framework
```xml
<PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
</PropertyGroup>
```
Change to desired .NET and build. Example:
```xml
<PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
</PropertyGroup>
```
After modifying the target framework you will have to rebuild the project.  

Pull requests will not be accepted in this repo. Either use the template to make a copy in your own GitHub account (recommended approach), or Fork the project
