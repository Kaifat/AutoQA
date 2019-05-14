using System;

namespace AutoQA.Task6
{
    class SimpleGarland : Garland
    {
        public override int BulbCount { get; set; }

        public override void Display()
        {
            Console.WriteLine("Current minute is: " + DateTime.Now.Minute);

            for (int i = 1; i <= BulbCount; i++)
            {
                Bulb bulb = new Bulb() { Index = i };

                Console.WriteLine("Bulb #: " + i + " \tBulb state: " + bulb.State);
            }

        }
    }
}
