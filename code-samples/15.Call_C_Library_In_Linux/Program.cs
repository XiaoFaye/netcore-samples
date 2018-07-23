using System;
using System.Runtime.InteropServices;

namespace CallCLib
{
    class Program
    {
        [DllImport(@"plus.so", EntryPoint = "Add", CallingConvention = CallingConvention.StdCall)]
        public static extern int Add(int a, int b);


        static void Main(string[] args)
        {
            Console.WriteLine(Add(19, 19));
        }
    }
}
