using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
{
    public class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
                this.side1 = side1;
                this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return side1* side2;
             
        }

        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
        
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
        
    }
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
