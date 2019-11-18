using System;

namespace Cwiczenie_1_Petla_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 5\n");

            string input;
            int n;
            int i_while_1;
            int i_while_2;

            Console.Write("Podaj liczbę wierszy: ");
            while((input = Console.ReadLine()) != "q")
            {
                if (!int.TryParse(input, out n))
                {
                    Console.WriteLine("To nie int\n");
                    continue;
                }

                Console.WriteLine("\nPętla for:");
                for(int i = 1; i <= n; i++)
                {
                    for(int j = 1; j <= i; j++)
                    {
                        Console.Write(j.ToString() + ' ');
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i.ToString() + ' ');
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nPętla while:");
                i_while_1 = 1;
                while(i_while_1 <= n)
                {
                    i_while_2 = 1;
                    while (i_while_2 <= i_while_1)
                    {
                        Console.Write(i_while_2.ToString() + ' ');
                        i_while_2++;
                    }
                    i_while_1++;
                    Console.WriteLine();
                }

                Console.WriteLine();
                i_while_1 = 1;
                while (i_while_1 <= n)
                {
                    i_while_2 = 1;
                    while (i_while_2 <= i_while_1)
                    {
                        Console.Write(i_while_1.ToString() + ' ');
                        i_while_2++;
                    }
                    i_while_1++;
                    Console.WriteLine();
                }

                Console.WriteLine("\nPętla do while");
                i_while_1 = 1;
                do
                {
                    i_while_2 = 1;
                    do
                    {
                        Console.Write(i_while_2.ToString() + ' ');
                        i_while_2++;
                    }
                    while(i_while_2 <= i_while_1);
                    i_while_1++;
                    Console.WriteLine();
                }
                while(i_while_1 <= n);

                Console.WriteLine();
                i_while_1 = 1;
                do
                {
                    i_while_2 = 1;
                    do
                    {
                        Console.Write(i_while_1.ToString() + ' ');
                        i_while_2++;
                    }
                    while (i_while_2 <= i_while_1);
                    i_while_1++;
                    Console.WriteLine();
                }
                while (i_while_1 <= n);

                Console.Write("\nPodaj liczbę wierszy: ");
            }
        }
    }
}
