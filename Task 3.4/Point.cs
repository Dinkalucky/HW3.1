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
}
