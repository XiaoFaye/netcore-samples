using System;
using System.Runtime.InteropServices;

namespace CallCLib
{
    class Program
    {
        [DllImport(@"/path/to/getifname.so", EntryPoint = "getifname", CallingConvention = CallingConvention.StdCall)]
        public static extern int getifname([MarshalAs(UnmanagedType.FunctionPtr)]CallbackFun callback_f);

        public delegate void CallbackFun(string name);

        static void CSCallbackFun(string name)
        {
            Console.WriteLine(name);
        }

        static void Main(string[] args)
        {
            getifname(CSCallbackFun);
        }
    }
}
