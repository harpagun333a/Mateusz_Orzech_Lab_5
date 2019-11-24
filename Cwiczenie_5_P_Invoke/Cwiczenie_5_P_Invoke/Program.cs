using System;
using System.Runtime.InteropServices;

namespace Cwiczenie_5_P_Invoke
{
    class Program
    {
        [DllImport("msvcrt.dll")]
        public static extern int puts(string c);

        [DllImport("msvcrt.dll")]
        public static extern int _flushall();

        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 5");

            string s = "Ala ma kota";
            puts(s);
            _flushall();
        }
    }
}
