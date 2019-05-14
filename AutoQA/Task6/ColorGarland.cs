using System;

namespace AutoQA.Task6
{
    class ColorGarland : Garland
    {
        public override int BulbCount { get; set; }

        public override void Display()
        {
            Console.WriteLine("Current minute is: " + DateTime.Now.Minute);

            for (int i = 1; i <= BulbCount; i++) {
                ColorBulb colorBulb = new ColorBulb() { Index = i };

                Console.WriteLine("Bulb #: " + i + " \tBulb color: " + colorBulb.Color + " \tBulb state: " + colorBulb.State);
            }
           
        }
    }
}
