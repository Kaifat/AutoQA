using System;

namespace AutoQA.Task1_2
{
    using AutoQA.Helper;
    class Calculator
    { 
        public static void Calculate()
        {
            double radius = 0;
            double sideLength = 0;
            int tries = 0;

            while (tries < 10)
            {
                Console.WriteLine("Please, enter circle radius: ");
                if (double.TryParse(Console.ReadLine(), out radius) && radius > 0)
                {
                    tries = 0;
                    break;
                }
                else
                {
                    tries++;
                    Console.WriteLine("The value is incorrect, please, try again");
                }
            }          

            while (tries < 10)
            {
                Console.WriteLine("Please, enter square side length: ");

                if (double.TryParse(Console.ReadLine(), out sideLength) && sideLength > 0)
                {
                    tries = 0;
                    break;
                }
                else
                {
                    tries++;
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
