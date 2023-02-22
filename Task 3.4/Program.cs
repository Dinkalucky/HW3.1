using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Point point1 = new Point(3, 2, "Точка 1");
            Point point2 = new Point(4, 6, "Точка 2");
            Point point3 = new Point(5, 7, "Точка 3");
            Point point4 = new Point(6, 8, "Точка 2");
            Point point5 = new Point(7, 9, "Точка 3");

            Figure figure = new Figure(point1, point2, point3);
            Console.WriteLine("З периметром: ");
            figure.PerimeterCalculator();

            Figure figure1 = new Figure(point1, point2, point3, point4);
            Console.WriteLine("З периметром: ");
            figure1.PerimeterCalculator();

            Figure figure2 = new Figure(point1, point2, point3,point4,point5);
            Console.WriteLine("З периметром: ");
            figure2.PerimeterCalculator();
            Console.ReadLine();
        }
    }
}
