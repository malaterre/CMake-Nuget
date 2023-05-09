using System;
using System.Runtime.InteropServices;

namespace ClassLibrary
{
    public class Class
    {
        [DllImport("NativeLibrary.dll")]
        public static extern void HelloWorld();

        public void Run()
        {
            HelloWorld();
        }
    }
}
