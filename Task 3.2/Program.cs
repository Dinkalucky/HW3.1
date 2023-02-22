using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Rectangle rectangle = new Rectangle(5, 4);
            rectangle.AreaCalculator();
            Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
            rectangle.PerimeterCalculator();
            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");

            Console.ReadLine();
        }
    }
}
