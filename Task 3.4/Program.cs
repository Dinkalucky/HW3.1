using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._4
{
    public class Point
    {
        int num1, num2;
        string text;

        public int Num1
        {
            get
            {
                return num1;
            }
        }
        public int Num2
        {
            get
            {
                return num2;
            }
        }

        //не зрозуміла, для чого ця властивість
        public string Text
        {
            get
            {
                return text;
            }
        }

        public Point(int num1, int num2, string text)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.text = text;
        }
    }

    public class Figure
    {
        private double perimeter;
        public Figure(Point A, Point B, Point C)
        {
            Console.WriteLine("Це трикутник");
            perimeter = LengthSide(A, B);
            perimeter += LengthSide(B, C);
            perimeter += LengthSide(C, A);
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            Console.WriteLine("\nЦе прямокутник");
            perimeter = LengthSide(A, B);
            perimeter += LengthSide(B, C);
            perimeter += LengthSide(C, D);
            perimeter += LengthSide(D, A);
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            Console.WriteLine("\nЦе п'ятикутник");
            perimeter = LengthSide(A, B);
            perimeter += LengthSide(B, C);
            perimeter += LengthSide(C, D);
            perimeter += LengthSide(D, E);
            perimeter += LengthSide(E, A);
        }

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.Num1 - A.Num1), 2) + Math.Pow((B.Num2 - A.Num2), 2));
        }

        public void PerimeterCalculator()
        {
             Console.Write(perimeter);
        }

    }
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
