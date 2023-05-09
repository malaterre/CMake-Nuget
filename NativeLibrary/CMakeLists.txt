project(PNative LANGUAGES CXX)

add_library(NativeLibrary MODULE Source.cpp)
install(
  TARGETS NativeLibrary
  #DESTINATION ${FOO_LIBRARY_INSTALL_DIR}
  DESTINATION runtimes/win-x64/native/
  COMPONENT libraries)
