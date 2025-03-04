using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_task_4
{
    internal class Program


    {
        static void Main(string[] args)
        {
            Book book1 = new Book { Title = "Pride and Prejudice", Author = "Jane Austen", ISBN = "111111", Price = 2500 };
            Book book2 = new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", ISBN = "222222", Price = 3800 };
            Book book3 = new Book { Title = "War and Peace", Author = "Leo Tolstoy", ISBN = "333333", Price = 4500 };

            Console.WriteLine("Book Collection:");

            Book[] books = { book1, book2, book3 };

            foreach (Book book in books)
            {
                Console.WriteLine("========================");
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("ISBN: " + book.ISBN);
                Console.WriteLine("Price: " + book.Price);
                Console.WriteLine("----------------------------");
                Console.Write("Enter discount percentage: ");
                double discount = double.Parse(Console.ReadLine());
                book.Price -= book.Price * (discount / 100);
                Console.WriteLine("Discounted Price: " + book.Price);
                Console.WriteLine("----------------------------");
            }
        }
    }
}