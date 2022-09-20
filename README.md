
## How to create  C4Sharp repos


## Refs
- https://github.com/8T4/c4sharp
- https://github.com/8T4/c4sharp/wiki/Getting-Started


 
### Application Dependencies
You need these things to run C4Sharp:

- JavaJDK https://adoptium.net/de/
- .NET Standard 50+  https://dotnet.microsoft.com/en-us/download


Use the .NET CLI to create a project and add C4Sharp support:
```cmd
dotnet new console -o c4-model-app
dotnet add package C4Sharp -Version 5.2.159

# Run Application
dotnet restore
dotnet run
```

### Compiling
There are two strategies for compiling diagrams in your project: self-compiling and using the C4SCLI tool.

a) self-compiling in-code approach
```c#
var diagrams = new[]
    {
        new ContainerDiagram().Build(),
    };

new PlantumlSession()
    .UseDiagramImageBuilder()
    .seDiagramSvgImageBuilder()
    .UseStandardLibraryBaseUrl()
    .UseHtmlPageBuilder()
    .Export(diagrams);
```

b) Using the C4SCLI tool:
```cmd
c4scli build <solution path> [-o <output path>] [-d <html>]
```

### Setup c4scli
```cmd
dotnet tool install --global c4scli --version 1.2.159-beta
```