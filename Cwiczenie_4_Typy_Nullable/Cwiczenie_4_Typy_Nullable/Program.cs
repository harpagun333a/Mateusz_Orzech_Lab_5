using System;

namespace Cwiczenie_4_Typy_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 4");

            int? i = null;
            int j = 10;

            Console.WriteLine(i < j);
            Console.WriteLine(i == j);
            Console.WriteLine(i > j);
        }
    }
}
