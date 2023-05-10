project(PNative LANGUAGES CXX)

add_library(NativeLibrary SHARED Source.cpp)
if(WIN32)
  set(VER_FILEVERSION
      ${CMakeNuget_VERSION_MAJOR},${CMakeNuget_VERSION_MINOR},${CMakeNuget_VERSION_PATCH}
  )
  set(VER_PRODUCTVERSION
      ${CMakeNuget_VERSION_MAJOR},${CMakeNuget_VERSION_MINOR},${CMakeNuget_VERSION_PATCH}
  )
  set(VER_FILEVERSION_STR
      ${CMakeNuget_VERSION_MAJOR}.${CMakeNuget_VERSION_MINOR}.${CMakeNuget_VERSION_PATCH}
  )
  set(VER_PRODUCTVERSION_STR
      ${CMakeNuget_VERSION_MAJOR}.${CMakeNuget_VERSION_MINOR}.${CMakeNuget_VERSION_PATCH}
  )
  set(VER_COMPANYNAME_STR "ACME")
  set(VER_FILEDESCRIPTION_STR "CMake Nuget")
  set(VER_PRODUCTNAME_STR "CMake Nuget")
  set(VER_LEGALCOPYRIGHT_STR "Copyright ACME.")
  configure_file(${CMAKE_CURRENT_SOURCE_DIR}/version.rc.in
                 ${CMAKE_CURRENT_BINARY_DIR}/version.rc @ONLY)
  target_sources(NativeLibrary PRIVATE ${CMAKE_CURRENT_BINARY_DIR}/version.rc)
endif()
message(${CMakeNuget_VERSION})
message(${CMakeNuget_SOVERSION})
set_property(TARGET NativeLibrary PROPERTY VERSION ${CMakeNuget_VERSION})
set_property(TARGET NativeLibrary PROPERTY SOVERSION ${CMakeNuget_SOVERSION})

install(
  TARGETS NativeLibrary
  # DESTINATION ${FOO_LIBRARY_INSTALL_DIR}
  DESTINATION runtimes/win-x64/native/
  COMPONENT libraries)
