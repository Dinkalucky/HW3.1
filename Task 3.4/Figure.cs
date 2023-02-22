using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._4
{
    public class Figure
    {
        private double[] storony = new double[5];
        public Figure(Point A, Point B, Point C)
        {
            Console.WriteLine("Це трикутник");
            storony[0] = LengthSide(A, B);
            storony[1] = LengthSide(B, C);
            storony[2] = LengthSide(C, A);
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            Console.WriteLine("\nЦе прямокутник");
            storony[0] = LengthSide(A, B);
            storony[1] = LengthSide(B, C);
            storony[2] = LengthSide(C, D);
            storony[3] = LengthSide(D, A);
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            Console.WriteLine("\nЦе п'ятикутник");
            storony[0] = LengthSide(A, B);
            storony[1] = LengthSide(B, C);
            storony[2] = LengthSide(C, D);
            storony[3] = LengthSide(D, E);
            storony[4] = LengthSide(E, A);
        }

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.Num1 - A.Num1), 2) + Math.Pow((B.Num2 - A.Num2), 2));
        }

        public void PerimeterCalculator()
        {
            Console.Write(storony.Sum());
        }

    }
}
