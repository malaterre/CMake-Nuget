cmake_minimum_required(VERSION 3.25)
project(CMakeNuget)

add_subdirectory(NativeLibrary)
add_subdirectory(ClassLibrary)

set(CPACK_BINARY_NSIS OFF)
set(CPACK_BINARY_NUGET ON)
set(CPACK_PACKAGE_NAME "cmake-nuget")
set(CPACK_PACKAGE_VERSION_MAJOR 1)
set(CPACK_PACKAGE_VERSION_MINOR 0)
set(CPACK_PACKAGE_VERSION_PATCH 0)
include(CPack)
