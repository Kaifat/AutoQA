using System;

namespace AutoQA.Task6
{
    public static class Illumination
    {
        public static void ShowGarlands() {

            Console.WriteLine("Please, enter the number of lightbulbs");

            int bulbCount;
            while (!int.TryParse(Console.ReadLine(), out bulbCount) || bulbCount <= 0)
            {
                Console.WriteLine("The value is incorrect, please, try again");
            }

            Console.WriteLine();
            new SimpleGarland() { BulbCount = bulbCount }.Display();
            Console.WriteLine();
            new ColorGarland() { BulbCount = bulbCount }.Display();
        }

    }
}
