using System;

namespace AutoQA.Task3
{
    class ArraySum
    {
        public const int minimalRange = 10;
        public const int firstDifference = 3;
        public const int secondDifference = 5 * firstDifference;

        private int from, to;

        public void SumItems()
        {
            int sum;

            while (true)
            {
                Console.WriteLine("Please, enter integer 'FROM' value ");
                if (int.TryParse(Console.ReadLine(), out this.from))
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
                Console.WriteLine("Please, enter integer 'TO' value ");
                if (int.TryParse(Console.ReadLine(), out this.to))
                {
                    if (this.to >= (this.from + minimalRange))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"The range is too small, please, enter value bigger or equals to {this.from + minimalRange}");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("The value is incorrect, please, try again");
                }
            }

            sum = ArithmeticProgressionSum(firstDifference) - ArithmeticProgressionSum(secondDifference);

            Console.WriteLine("Sum of the numbers is " + sum);
        }

        private int ArithmeticProgressionSum(int difference) {

            int modulo, a1, n;

            modulo = this.from % difference;
            if (modulo > 0)
            {
                a1 = this.from - modulo + difference;
            }
            else {
                a1 = this.from;
            }

            n = (int)(this.to - this.from) / difference;

            return ((2 * a1 + (n - 1) * difference)* n) / 2;
        }
    }
}
