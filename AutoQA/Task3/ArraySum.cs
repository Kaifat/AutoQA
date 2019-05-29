using System;

namespace AutoQA.Task3
{
    class ArraySum
    {
        private const int minimalRange = 10;
        private const int firstDifference = 3;
        private const int secondDifference = 5 * firstDifference;

        private int from = ConsoleReaderHelper.ReadIntegerValue("integer 'FROM'"),
                    to = ConsoleReaderHelper.ReadIntegerValue("integer 'TO'");

        public void SumItems()
        {
            int ActualAttempts = 0;
            
            while (to < (from + minimalRange) && ActualAttempts++ <= ConsoleReaderHelper.MaxAttempts) {
                Console.WriteLine($"The range is too small, please, enter value bigger or equals to {from + minimalRange}");
                to = ConsoleReaderHelper.ReadIntegerValue("integer 'TO'");
            }

            if (to < (from + minimalRange))
            {
                Console.WriteLine("You've used all allowed attempts. Good bye");
                Environment.Exit(0);
            }

            int sum = ArithmeticProgressionSum(firstDifference) - ArithmeticProgressionSum(secondDifference);

            Console.WriteLine("Sum of the numbers is " + sum);

            //For test purpose only:
            int sum2 = 0;
            int iter = 0;
            for (int i = from; i <= to; i++) {
                if (i % 3 == 0 && i % 5 != 0) {
                    sum2 += i;
                    iter++;
                }
            }
            Console.WriteLine("Sum2 of the numbers is " + sum2);
            Console.WriteLine("Iter of the numbers is " + iter);
        }
        
        private int ArithmeticProgressionSum(int difference) {

            int a1 = CalculateMember(from, difference, true),
                aN = CalculateMember(to, difference),
                n =((aN - a1) / difference) + 1;

            return ((2 * a1 + (n - 1) * difference)* n) /2;
        }

        private int CalculateMember(int member, int difference, bool nextMember = false)
        {
            int modulo = member % difference;

            if (modulo > 0)
            {
                return member - modulo + (nextMember ? difference : 0);
            }

            return member;
        }
    }
}
