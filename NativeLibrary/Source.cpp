#include <iostream>

#ifdef _WIN32
#define FOO_EXPORT __declspec(dllexport)
#else
#define FOO_EXPORT __attribute__((visibility("default")))
#endif
extern "C" FOO_EXPORT void HelloWorld();

void HelloWorld()
{
  std::cout << "Hello world from c++" << std::endl;
}
