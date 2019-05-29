using System;
using System.Text.RegularExpressions;

namespace AutoQA.Task4
{
    class Polindrome
    {
        public static void CheckPolindrome()
        {
            string enteredString = ConsoleReaderHelper.ReadStringValue();

            string convertedString = Regex.Replace(enteredString, "[^a-zA-Z']", "").ToLower();

            char[] charsArray = convertedString.ToCharArray();
            Array.Reverse(charsArray);
            string reversedWord = new string(charsArray);

            if (convertedString == reversedWord)
            {
                Console.WriteLine($"Text \"{enteredString}\" is a polindrom");
            }
            else
            {
                Console.WriteLine($"Text \"{enteredString}\" is not a polindrom");
            }
        }
    }
}
