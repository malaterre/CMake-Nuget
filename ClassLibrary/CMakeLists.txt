cmake_minimum_required(VERSION 3.25)
project(DotNet LANGUAGES CSharp)

add_library(ClassLibrary SHARED Class.cs)
set_property(TARGET ClassLibrary PROPERTY DOTNET_SDK "Microsoft.NET.Sdk")
set_property(TARGET ClassLibrary PROPERTY DOTNET_TARGET_FRAMEWORK "net5.0")

install(
  TARGETS ClassLibrary
  DESTINATION lib/net5.0
  COMPONENT CSharpLibraries)
