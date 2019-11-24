using System;
using System.Collections.Generic;

namespace Cwiczenie_6_Klasa_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 6\n");

            Stack sk = new Stack();

            sk.AddItem(3);
            sk.PrintAllItems();
            sk.AddItem(6);
            sk.PrintAllItems();
            sk.AddItem(3);
            sk.PrintAllItems();
            sk.AddItem(1);
            sk.PrintAllItems();
            sk.AddItem(4);
            sk.PrintAllItems();
            sk.AddItem(5);
            sk.PrintAllItems();
            sk.AddItem(8);
            sk.PrintAllItems();
            sk.AddItem(7);
            sk.PrintAllItems();
            sk.DeleteItem();
            sk.PrintAllItems();

            Console.WriteLine("..............");
            sk.ShowMinItem();
            sk.ShowMaxItem();
            Console.WriteLine("{0}", sk.FindAnItem(0));
            Console.WriteLine("{0}", sk.FindAnItem(1));
            Console.WriteLine("{0}", sk.FindAnItem(2));
            Console.WriteLine("{0}", sk.FindAnItem(3));
            sk.ClearAll();
            sk.PrintAllItems();

            Random rnd = new Random();
            Stack sk1 = new Stack();
            Stack sk2 = new Stack();
            Stack sk3 = new Stack();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0}", rnd.Next(1, 100));
                sk1.AddItem(rnd.Next(1, 100));
                sk2.AddItem(rnd.Next(1, 100));
            }

            for(int i = 0; i <= 100; i++)
            {
                if((sk1.FindAnItem(i) >= 0) || (sk2.FindAnItem(i) >= 0))
                {
                    if(i % 2 == 0)
                    {
                        sk3.AddItem(i);
                    }
                }
            }

            sk1.PrintAllItems();
            sk2.PrintAllItems();
            sk3.PrintAllItems();
        }
    }

    class Stack
    {
        List<int> mem = new List<int>();

        public void AddItem(int item)
        {
            mem.Add(item);
        }

        public void DeleteItem()
        {
            mem.Remove(mem[0]);
        }
        
        public void ShowTheNumberOfItems()
        {
            Console.WriteLine("Number of items: " + mem.Count.ToString());
        }
        
        public void ShowMinItem()
        {
            int min = 0;

            if(mem.Count > 0)
            {
                min = mem[0];
            }

            for (int i = 0; i < mem.Count; i++)
            {
                if (min > mem[i])
                {
                    min = mem[i];
                }
            }

            Console.WriteLine("Minimum item: " + min.ToString());
        }

        public void ShowMaxItem()
        {
            int max = 0;

            if (mem.Count > 0)
            {
                max = mem[0];
            }

            for (int i = 0; i < mem.Count; i++)
            {
                if (max < mem[i])
                {
                    max = mem[i];
                }
            }

            Console.WriteLine("Maximum item: " + max.ToString());
        }
        
        public int FindAnItem(int item)
        {
            for(int i = 0; i < mem.Count; i++)
            {
                if(mem[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        public void PrintAllItems()
        {
            for ( int i = 0; i < mem.Count; i++)
            {
                Console.Write("[{0}]", mem[i]);
            }
            Console.WriteLine();
        }

        public void ClearAll()
        {
            mem.Clear();
        }
    }
}
