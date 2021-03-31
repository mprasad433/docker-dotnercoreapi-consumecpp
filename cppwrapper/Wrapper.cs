using System;
using System.Runtime.InteropServices;

namespace cppwrapper
{
    public class Wrapper
    {
        [DllImport("cpplib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int math_lib();

        public int GetCppValue()
        {
            return math_lib();
        }
    }
}
