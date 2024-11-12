## Highcharts .NET and Highstock .NET General Info

* Official website: [dotnet.highcharts.com](https://dotnet.highcharts.com)
* Documentation page: [https://dotnet.highcharts.com/Highcharts/Demo/Docs?section=ServerSideRequirements](https://dotnet.highcharts.com/Highcharts/Demo/Docs?section=ServerSideRequirements)
* Highcharts .NET API page: [https://dotnet.highcharts.com/Help/Highcharts/html/index.html](https://dotnet.highcharts.com/Help/Highcharts/html/index.html)
* Highstock .NET API page: [https://dotnet.highcharts.com/Help/Highstock/html/index.html](https://dotnet.highcharts.com/Help/Highstock/html/index.html)


## Project structure and dependencies

.NET solution file which contains all projects is located in _HC7\HighSoft.sln

Highcharts .NET source code is located in project HighchartsStandard.
Highstock .NET source code is located in project HighstockStandard.
Both above projects have dependency on Newtonsoft.Json 13.0.3 and NETStandard.Library v2.0.3 - information about which technologies and versions are supported is located here:
[https://dotnet.highcharts.com/Highcharts/Demo/Docs?section=ServerSideRequirements](https://dotnet.highcharts.com/Highcharts/Demo/Docs?section=ServerSideRequirements)
SourceCodeGenerator project contains solution for generating source code which is later placed in HighchartsStandard\CodeGeneration and HighstockStandard\CodeGeneration folders
MVC_Demo_Standard project contains entire website which is located on [dotnet.highcharts.com](https://dotnet.highcharts.com)
UnitTests_HC, UnitTest_HS (xUnit) and UnitTests_MVC (nUnit) contain unit test 

## Overall architecture and philosophy of the technical approach

Highcharts .NET and Highstock .NET are based on .NET Standard 2.0.3 which allows to use those wrappers across many other .NET technologies like: 
.NET Framework (MVC, WinForms, WPF), .NET Core, .NET, Mono, Xamarin.iOS, Xamarin.Android, Universal Windows Platform, Unity
Wrappers have classes generated based on json file downloaded from [https://api.highcharts.com/highcharts/tree.json](https://api.highcharts.com/highcharts/tree.json). 
For every element in json file is generated separated class, which causes that multiple classes have the same logic but different names.
Class Names depend on the element name and parent full name.

To use wrappers user needs to add information about location of highcharts.js and needed modules like here:
```
<script src="https://code.highcharts.com/highcharts.js"></script>
```
, define aliases to namespaces like here: 
```
using Highsoft.Web.Mvc.Charts
using Highsoft.Web.Mvc.Charts.Rendering;
```
, define options by defining properties in Highcharts/Highstock object and at the end call a proper method from HighchartsRenderer/HighstockRenderer (depends on technology) - which generates and executes JS script on the client side.
JS script contains only properties which were defined earlier in Highcharts/Highstock object.

## Instructions for building, testing, etc.

1. Download json file [https://api.highcharts.com/highcharts/tree.json](https://api.highcharts.com/highcharts/tree.json) 
2. Remove highcharts_old.json file from SourceCodeGenerator project from JsonFiles folder, rename highcharts.json on highcharts_old.json
3. Add downloaded json file to SourceCodeGenerator project to JsonFiles as highcharts.json.
4. Set SourceCodeGenerator project as Startup Project
5. Build and execute SourceCodeGenerator
6. Generated code goes to \bin\Debug or \bin\Release
7. Use WinMerge to compare \bin\Debug\CodeGeneration\Highcharts and source code for current version from \HighchartsStandard\CodeGeneration
8. There may be new, updated or removed parts of code (each from all of those may be correct or incorrect) - if you figure out that something is incorrect you must investigate why is that.
8.1. Verify if json file has correct values
8.2. SourceCodeGenerator compares json from current and new versions. In the past default logic in case of any updates was to keep an old solution (f.e. property type), because of many incorrect values in json. 
     Currently it is set to keep new changes but there is still an option to overwrite change by defined value in specific file. You can use this file to fix issue if something is off in json file.
8.3. If above doesn't help then you can use services (classes: TypeService, MultiplicationService, JsonUpdateService, FilterService). If you identify that updating the source code in those services will help then do so.
8.4. If above doesn't help - update classes which are responsible for generating C# source code for .NET wrappers - Generator or HighchartsGenerator
8.5. Go back to point 5 if issue is not fixed 
9. When issue is fixed make a copy of project HighchartsStandard on side
10. Remove files from HighchartsStandard\CodeGeneration
11. Copy files from \bin\Debug\CodeGeneration\Highcharts to \HighchartsStandard\CodeGeneration
12. Build HighchartsStandard in Visual Studio if that fails fix the issue or just go back to 5
13. Run unit tests from Visual Studio
14. Update release notes and version on properties for HighchartsStandard
15. Change configuratin solution on Release
16. Build HighchartsStandard
17. Take the latest (for current build) nupkg file (Highsoft.Highcharts.X.Y.Z.nupkg) and upload on NuGet
18. Run DoxyWizard, specify working directory (click Select and Select Folder). 
    Define: Project name, Project version, Source code directory - select \HighchartsStandard\CodeGeneration, Destination folder, Documented Entities Only, Optimized for C#, HTML with navigation panel, turn off LaTeX, No diagrams
	and click Run Doxygen to generate API documentation
19. Upload documentation on dotnet.highchart.com
18. Go back to point 5 and repeat all steps for Highstock .NET
19. Take generated earlier Highcharts.dll and Highstock.dll and add to zip file on dotnet.highchart.com

## List project standards/conventions

C# most common naming convention.

## List commit and PR standards, and generating a ChangeLog

No pull requests.
ChangeLog is updated in properies of projects: HighchartsStandard and HighstockStandard.


## Write instructions for contributors

SourceCodeGenerator folders:
* CodeAddOns contains unique classes
* CodeTemplates contains templates used to generate classes, enums, properties
* Generators contains main classes which are responsible for generating C# code for Highcharts .NET and Highstock .NET
* JsonFiles contains json files downloaded from [https://api.highcharts.com/highcharts/tree.json](https://api.highcharts.com/highcharts/tree.json) 
* Logs contains files used to updated changes in comparison to previous version
* Parser contans classes responsible for parsin json file
* Services contains classes responsible for update objects after parser

## Write instructions for writing tests

Old tests are written using nUnit and newer with using xUnit. Most of tests are spread between UnitTests_HC and UnitTests_HS to be able build and test f.e. only Highcharts library or only Highstock library.
Proper test may be found easly by naming convention of classes and testing methods.