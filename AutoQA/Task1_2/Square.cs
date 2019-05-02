using System;
using System.Collections.Generic;
using System.Text;

namespace AutoQA.Task1_2
{
    public class Square
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double CalculateArea()
        {
            return Math.Pow(SideLength, 2);
        }
    }
}
