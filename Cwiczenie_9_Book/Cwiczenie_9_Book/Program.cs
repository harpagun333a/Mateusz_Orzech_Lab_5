using System;
using System.Collections.Generic;

namespace Cwiczenie_9_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 9\n");

            BookLibrary lib = new BookLibrary();
            lib.AddBook(new Book("Tytul_1", "Autor1", 12.50, "123", new DateTime(2019, 11, 2)));
            lib.AddBook(new Book("Tytul_2", "Autor2", 22.50, "124", new DateTime(2018, 9, 30)));
            lib.AddBook(new Book("Tytul_3", "Autor3", 13.99, "125", new DateTime(2017, 6, 23)));
            lib.AddBook(new Book("Tytul_4", "Autor1", 6.66, "126", new DateTime(2016, 7, 14)));
            lib.AddBook(new Book("Tytul_5", "Autor2", 77.99, "127", new DateTime(2015, 5, 3)));
            lib.AddBook(new Book("Tytul_6", "Autor3", 12.80, "128", new DateTime(2014, 12, 17)));
            lib.AddBook(new Book("Tytul_7", "Autor1", 17.50, "129", new DateTime(2013, 5, 22)));
            lib.AddBook(new Book("Tytul_8", "Autor2", 2.50, "130", new DateTime(2012, 3, 5)));
            lib.AddBook(new Book("Tytul_9", "Autor3", 13.13, "131", new DateTime(2011, 1, 24)));
            lib.print();

            Console.WriteLine("------------------------------");
            List<Book> BookList = new List<Book>();

            BookList = lib.FindByTitle("Tytul_3");

            for(int i = 0; i < BookList.Count; i++)
            {
                Console.WriteLine();
                BookList[i].print();
            }

            BookList = lib.FindByAuthor("Autor2");

            for (int i = 0; i < BookList.Count; i++)
            {
                Console.WriteLine();
                BookList[i].print();
            }

            BookList = lib.FindByPrice(6.66);

            for (int i = 0; i < BookList.Count; i++)
            {
                Console.WriteLine();
                BookList[i].print();
            }

            BookList = lib.FindByISBN("130");

            for (int i = 0; i < BookList.Count; i++)
            {
                Console.WriteLine();
                BookList[i].print();
            }

            Console.WriteLine("\n{0}", lib.IsExists(new Book("Tytul_9", "Autor3", 13.13, "131", new DateTime(2011, 1, 24))));

            Console.WriteLine("\n-----------------------------\n");

            lib.RemoveBook("125");
            lib.print();
        }

        public class Book
        {
            public string _title;
            public string _author;
            public double _price;
            protected string _isbn;
            public DateTime date;

            public Book(string title, string author, double price, string isbn, DateTime d)
            {
                this._title = title;
                this._author = author;
                this._price = price;
                this._isbn = isbn;
                this.date = d;
            }

            public void print()
            {
                Console.WriteLine("Tytuł: {0}", this._title);
                Console.WriteLine("Autor: {0}", this._author);
                Console.WriteLine("Cena: {0:0.00} zł", this._price);
                Console.WriteLine("ISBN: {0}", this._isbn);
                Console.WriteLine("Data: {0}", this.date.ToShortDateString());
            }

            public string GetISBN()
            {
                return this._isbn;
            }
        }

        class BookLibrary
        {
            List<Book> library = new List<Book>();

            public void print()
            {
                for(int i = 0; i < library.Count; i++)
                {
                    Console.WriteLine();
                    library[i].print();
                }
            }

            public List<Book> FindByTitle(string t)
            {
                List<Book> finded = new List<Book>();

                for(int i = 0; i < library.Count; i++)
                {
                    if(t == library[i]._title)
                    {
                        finded.Add(library[i]);
                    }
                }

                return finded;
            }

            public List<Book> FindByAuthor(string a)
            {
                List<Book> finded = new List<Book>();

                for (int i = 0; i < library.Count; i++)
                {
                    if (a == library[i]._author)
                    {
                        finded.Add(library[i]);
                    }
                }

                return finded;
            }

            public List<Book> FindByPrice(double p)
            {
                List<Book> finded = new List<Book>();

                for (int i = 0; i < library.Count; i++)
                {
                    if (p == library[i]._price)
                    {
                        finded.Add(library[i]);
                    }
                }

                return finded;
            }

            public List<Book> FindByISBN(string isbn)
            {
                List<Book> finded = new List<Book>();

                for (int i = 0; i < library.Count; i++)
                {
                    if (isbn == library[i].GetISBN())
                    {
                        finded.Add(library[i]);
                    }
                }

                return finded;
            }

            public void AddBook(Book b)
            {
                for(int i = 0; i < library.Count; i++)
                {
                    if(library[i].GetISBN() == b.GetISBN())
                    {
                        Console.WriteLine("Książka o podanym numerze ISBN już istnieje");
                        return;
                    }
                }

                library.Add(b);
            }

            public void RemoveBook(string ISBN)
            {
                for (int i = 0; i < library.Count; i++)
                {
                    if (library[i].GetISBN() == ISBN)
                    {
                        library.Remove(library[i]);
                        return;
                    }
                }
                Console.WriteLine("Podana książka nie istnieje");
            }

            public bool IsExists(Book b)
            {
                for(int i = 0; i < library.Count; i++)
                {
                    if(b.GetISBN() == library[i].GetISBN())
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
