using System;

namespace home_task_4
{


    using System;

    class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public double Price;

        public void DisplayBookInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Price: " + Price);
        }

        public void ApplyDiscount(double percentage)
        {
            Price -= Price * (percentage / 100);
        }
    }
}