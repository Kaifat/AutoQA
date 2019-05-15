using AutoQA.Task1_2;
using System;

namespace AutoQA.Helper
{
    public static class FigureFitting
    {
        public static bool DoesFit(this Object obj, Object obj2)
        {
            if (obj is Circle && obj2 is Square)
            {
                Circle circle = (Circle)obj;
                Square square = (Square)obj2;

                return circle.Radius <= square.SideLength / 2;
            }

            if (obj is Square && obj2 is Circle)
            {
                Square square = (Square)obj;
                Circle circle = (Circle)obj2;

                return circle.Radius * 2 >= square.SideLength * Math.Sqrt(2);
            }

            return false;
        }
    }
}
