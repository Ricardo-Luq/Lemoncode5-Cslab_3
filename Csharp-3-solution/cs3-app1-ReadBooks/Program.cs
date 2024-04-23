using System;

namespace cs3_app1_ReadBooks
{
    internal class Program
    {

        public class Book
        {
            public string Title { get; set; }
            public bool IsRead { get; set; }
        }
        public static bool IsBookRead(Book[] books, string titleToSearch)
        {
            bool bookFound = false;
            int i = 0;
            while (!bookFound && i < books.Length)
            {
                if (titleToSearch == books[i].Title)
                {
                    return books[i].IsRead;
                }
                i++;
            }
            return false; //if no book was found, return false
        }
        static void Main(string[] args)
        {
            var books = new Book[] {
                new Book
                {
                    Title = "Harry Potter y la piedra filosofal",
                    IsRead = true
                },
                new Book
                {
                    Title = "Canción de hielo y fuego",
                    IsRead = false
                },
                new Book
                {
                    Title = "Devastación",
                    IsRead = true
                },
            };

            Console.WriteLine(IsBookRead(books, "Devastación")); // true
            Console.WriteLine(IsBookRead(books, "Canción de hielo y fuego")); // false
            Console.WriteLine(IsBookRead(books, "Los Pilares de la Tierra")); // false
        }
    }
}
