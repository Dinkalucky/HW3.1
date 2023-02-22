using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1
{
    public class Book
    {
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Назва книги:");
            new Title().Show();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Автор:");
            new Author().Show();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Зміст:");
            new Content().Show();
        }
    }

}
