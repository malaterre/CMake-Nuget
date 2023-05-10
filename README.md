# CMake-Nuget

```
cmake -S . -B build
cmake --build build
cmake --build build --target package
```

This repo is an attempt to create a NuGet/Native package using CMake framework (no hand-written .csproj).

Documentation:
* https://cmake.org/cmake/help/latest/cpack_gen/nuget.html

Issues:
* https://gitlab.kitware.com/cmake/cmake/-/issues/24892

References:
* https://github.com/Mizux/dotnet-native/
* https://stackoverflow.com/questions/63175277/cpack-nuget-native-library
* https://jho.pe/posts/nuget-native-deps/
