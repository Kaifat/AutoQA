using AutoQA.Task1_2;
using System;

namespace AutoQA.Helper
{
    public static class Geometry {
        public static bool DoesFit(this Object obj, Object obj2) {
            if (obj is Circle && obj2 is Square)
            {
                Circle circle = (Circle) obj;
                Square square = (Square) obj2;

                return circle.Radius <= square.SideLength / 2;
            }

            if (obj is Square && obj2 is Circle)
            {
                Square square = (Square) obj;
                Circle circle = (Circle) obj2;

                return circle.Radius * 2 >= square.SideLength * Math.Sqrt(2);
            }

            return false;
        }
    }
}

namespace AutoQA.Task1_2
{
    using AutoQA.Helper;
    class Calculator
    { 
        public static void Calculate()
        {
            double radius;
            double sideLength;

            while (true)
            {
                Console.WriteLine("Please, enter circle radius: ");
                if (double.TryParse(Console.ReadLine(), out radius))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The value is incorrect, please, try again");
                }
            }          

            while (true)
            {
                Console.WriteLine("Please, enter square side length: ");

                if (double.TryParse(Console.ReadLine(), out sideLength))

                {
                    break;
                }
                else
                {
                    Console.WriteLine("The value is incorrect, please, try again");
                }
            }

            Circle circle = new Circle(radius);
            Square square = new Square(sideLength);

            double circleArea = circle.CalculateArea();
            double squareArea = square.CalculateArea();

            Console.WriteLine("Circle area is " + circleArea);
            Console.WriteLine("Square area is " + squareArea);

            if (circle.DoesFit(square))
            {
                Console.WriteLine("The circle fits the square");
            }
            else
            {
                Console.WriteLine("The circle does not fit the square");
            }

            if (square.DoesFit(circle))
            {
                Console.WriteLine("The square fits the circle");
            }
            else
            {
                Console.WriteLine("The square does not fit the circle");
            }
        }
    }
}
