# MessagePack.MSBuild.SourceGenerator.Tasks
[![GitHub](https://img.shields.io/github/license/hikarin522/MessagePack.MSBuild.SourceGenerator.Tasks)](LICENSE)
[![Nuget](https://img.shields.io/nuget/v/MessagePack.MSBuild.SourceGenerator.Tasks)](https://www.nuget.org/packages/MessagePack.MSBuild.SourceGenerator.Tasks/)
[![Nuget](https://img.shields.io/nuget/dt/MessagePack.MSBuild.SourceGenerator.Tasks)](https://www.nuget.org/packages/MessagePack.MSBuild.SourceGenerator.Tasks/)

MessagePack.MSBuild.Tasks extensions for C# Source Generator.

You will be able to use C# Source Generator and [MessagePack.MSBuild.Tasks](https://www.nuget.org/packages/MessagePack.MSBuild.Tasks) at the same time.

## Usage

`YourProject.csproj`
```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <!-- Path relative to the project root folder. Similar to CompilerGeneratedFilesOutputPath. Default: $(IntermediateOutputPath)generated -->
    <GeneratedFilesOutputPath>GeneratedFiles</GeneratedFilesOutputPath>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="MessagePack" Version="2.3.112" />
    <PackageReference Include="MessagePack.MSBuild.SourceGenerator.Tasks" Version="1.0.0">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="MessagePack.MSBuild.Tasks" Version="2.3.112">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="MessagePackAnalyzer" Version="2.3.112">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
  </ItemGroup>
  
  <!-- !!! Required! Please be sure to add. !!! -->
  <ItemGroup>
    <PackageReference Update="MessagePack.MSBuild.Tasks" ExcludeAssets="build" GeneratePathProperty="true" />
  </ItemGroup>

</Project>
```
