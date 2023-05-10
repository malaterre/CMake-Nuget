# CMake-Nuget

```
cmake -S . -B build
cmake --build build
cmake --build build --target package
```

This repo is an attempt to create a NuGet/Native package using CMake framework (no hand-written .csproj).

Usage:
```
> cat .\Program.cs
using ClassLibrary;

Console.WriteLine("Hello, World!");
var obj = new Class();
obj.Run();
```

with:

```
> cat .\HelloWorld.csproj
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="cmake-nuget" Version="1.0.0" />
  </ItemGroup>

  <PropertyGroup>
    <ResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch>None</ResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch>
  </PropertyGroup>

</Project>
```

Documentation:
* https://cmake.org/cmake/help/latest/cpack_gen/nuget.html

Issues:
* https://gitlab.kitware.com/cmake/cmake/-/issues/24892

References:
* https://github.com/Mizux/dotnet-native/
* https://stackoverflow.com/questions/63175277/cpack-nuget-native-library
* https://jho.pe/posts/nuget-native-deps/
* https://stackoverflow.com/questions/10113532/how-do-i-fix-the-visual-studio-compile-error-mismatch-between-processor-archit
