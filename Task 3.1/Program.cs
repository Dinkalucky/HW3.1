using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

    public class Title
    {
        private string title = "CLR VIA C#";

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
        }
    }

    public class Author
    {
        private string author = "CLR VIA C#";

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(author);
        }
    }

    public class Content
    {
        private string content = "Книга з програмування.";

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(content);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Book book = new Book();
            book.Show();

            Console.Read();
        }
    }
}
