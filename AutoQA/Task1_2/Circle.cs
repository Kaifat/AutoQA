using System;

namespace AutoQA.Task1_2
{
    class Circle
    {
        public const double Pi = Math.PI;

        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Pi * Math.Pow(Radius, 2);
        }
    }
}
