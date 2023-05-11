cmake_minimum_required(VERSION 3.25)
project(DotNet LANGUAGES CSharp)

add_library(ClassLibrary SHARED Class.cs Class2.cs)
set_property(TARGET ClassLibrary PROPERTY DOTNET_SDK "Microsoft.NET.Sdk")
set_property(TARGET ClassLibrary PROPERTY DOTNET_TARGET_FRAMEWORK "net6.0")
set_property(TARGET ClassLibrary PROPERTY VS_PACKAGE_REFERENCES
                                          "Microsoft.Extensions.Logging_7.0.0")
install(
  TARGETS ClassLibrary
  DESTINATION lib/net6.0
  COMPONENT CSharpLibraries)
