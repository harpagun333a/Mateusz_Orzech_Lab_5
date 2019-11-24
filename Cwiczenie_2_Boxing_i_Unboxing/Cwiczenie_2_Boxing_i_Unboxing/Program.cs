using System;

namespace Cwiczenie_2_Boxing_i_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 2");

            Int32 i = 23;
            object o = i;
            i = 123;
            Console.WriteLine(i + ", " + (Int32) o);
            long j = (long)o;
            Console.WriteLine(j + ", " + (Int32)o);
        }
    }
}
