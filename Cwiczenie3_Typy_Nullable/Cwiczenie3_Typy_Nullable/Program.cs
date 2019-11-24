using System;

namespace Cwiczenie3_Typy_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 3");

            Nullable<int> zmienna;

            //Console.WriteLine(zmienna);                       // Nie da się
            //Console.WriteLine(zmienna.GetValueOrDefault());   // Nie da się
            //Console.WriteLine(zmienna.HasValue);              // Nie da się

            zmienna = 3;

            Console.WriteLine(zmienna);                       
            Console.WriteLine(zmienna.GetValueOrDefault());   
            Console.WriteLine(zmienna.HasValue);

            zmienna = null;

            Console.WriteLine(zmienna);
            Console.WriteLine(zmienna.GetValueOrDefault());
            Console.WriteLine(zmienna.HasValue);
        }
    }
}
