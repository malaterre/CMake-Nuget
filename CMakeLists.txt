cmake_minimum_required(VERSION 3.25)
# project is set to language C and not "NONE" to have cpack/nuget generate in
# right folder "win64":
project(
  CMakeNuget
  VERSION 1.0.0
  LANGUAGES C)

set(CMakeNuget_SOVERSION "${CMakeNuget_VERSION_MAJOR}")

include(GNUInstallDirs)
set(FOO_LIBRARY_INSTALL_DIR "${CMAKE_INSTALL_LIBDIR}")
add_subdirectory(NativeLibrary)
if(MSVC)
  add_subdirectory(ClassLibrary)
endif()

# override default:
set(CPACK_NUGET_PACKAGE_DEBUG ON)
set(CPACK_BINARY_NSIS OFF)

set(CPACK_NUGET_PACKAGE_TAGS "native")
set(CPACK_PACKAGE_NAME "cmake-nuget")
set(CPACK_PACKAGE_VERSION_MAJOR 1)
set(CPACK_PACKAGE_VERSION_MINOR 0)
set(CPACK_PACKAGE_VERSION_PATCH 0)
set(CPACK_NUGET_PACKAGE_AUTHORS "malat")

# setup components for nuget:
set(CPACK_NUGET_COMPONENT_INSTALL ON)
# define list of components to install
set(CPACK_COMPONENTS_ALL "NugetLibraries" "CSharpLibraries")
# all components in a single group:
set(CPACK_COMPONENTS_GROUPING ALL_COMPONENTS_IN_ONE)
include(CPack)
