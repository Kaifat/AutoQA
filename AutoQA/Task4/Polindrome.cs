using System;
using System.Collections.Generic;
using System.Text;

namespace AutoQA.Task4
{
    class Polindrome
    {
        public static void CheckPolindrome()
        {
            string enteredWord;

            while (true)
            {
                Console.Write("Please enter you word: ");
                enteredWord = Convert.ToString(Console.ReadLine());
                bool spaceExists = enteredWord.Contains(" ");

                if (spaceExists)
                {
                    Console.WriteLine("It should be only one word without spaces");
                }
                else
                {
                    break;
                }
            }

            char[] charsArray = enteredWord.ToCharArray();
            Array.Reverse(charsArray);
            string reversedWord = new string(charsArray);

            if (enteredWord == reversedWord)
            {
                Console.WriteLine("Word \"" + enteredWord + "\" is a polindrom");
            }
            else
            {
                Console.WriteLine("Word \"" + enteredWord + "\" is not a polindrom");
            }
        }
    }
}
