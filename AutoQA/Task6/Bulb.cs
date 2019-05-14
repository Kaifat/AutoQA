using System;

namespace AutoQA.Task6
{
    class Bulb
    {
        public int Index;

        public State State
        {
            get
            {
                if (DateTime.Now.Minute % 2 == Index % 2)
                {
                    return State.On;
                }

                return State.Off;
            }
        }
    }
}
