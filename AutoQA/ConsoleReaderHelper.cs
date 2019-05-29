using System;

namespace AutoQA
{
    public static class ConsoleReaderHelper
    {
        public const int MaxAttempts = 5;

        public static string ReadStringValue()
        {
            int ActualAttempts = 0;
            string value = "";

            Console.WriteLine("Please, enter your text");

            while (ActualAttempts++ < MaxAttempts)
            {
                value = Convert.ToString(Console.ReadLine());
                if (value.Length > 0)
                {
                    return value;
                }

                Console.WriteLine("The value is incorrect, please, try again");
            }

            Console.WriteLine("You've used all allowed attempts. Good bye");
            Environment.Exit(0);
            return value;
        }

        public static double ReadDoubleValue(string inputName) {

            int ActualAttempts = 0;
            double value = 0;

            Console.WriteLine($"Please, enter {inputName} value");

            while (ActualAttempts++ < MaxAttempts)
            {
                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                {
                    return value;
                }

                Console.WriteLine("The value is incorrect, please, try again");
            }
           
            Console.WriteLine("You've used all allowed attempts. Good bye");
            Environment.Exit(0);
            return value;
        }


        public static int ReadIntegerValue(string inputName) {
            return ReadIntegerValue(inputName, 0, 0);
        }
        public static int ReadIntegerValue(string inputName, int min, int max)
        {

            int ActualAttempts = 0;
            int value = 0;

            Console.WriteLine($"Please, enter {inputName} value");

            while (ActualAttempts++ < MaxAttempts)
            {
                if (int.TryParse(Console.ReadLine(), out value) && value > 0)
                {
                    return value;
                }

                Console.WriteLine("The value is incorrect, please, try again");
            }

            Console.WriteLine("You've used all allowed attempts. Good bye");
            Environment.Exit(0);
            return value;
        }
    }
}
