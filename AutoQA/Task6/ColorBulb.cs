using System;

namespace AutoQA.Task6
{
    class ColorBulb
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

        public Color Color {
            get {
                switch (Index % 4)
                {
                    case 1:
                        return Color.Red;
                    case 2:
                        return Color.Yellow;
                    case 3:
                        return Color.Green;
                    default:
                        return Color.Blue;
                }             
            }
        }

    }
}
