using System;
using System.Collections.Generic;
using System.Text;

namespace AutoQA.Task5
{

    public class TimeAttr : EnumAttr
    {
        public int Time { get; set; }
    }
    public enum Complexity
    {
        [TimeAttr(Time = 4)]
        Hard,
        [TimeAttr(Time = 2)]
        Medium,
        [TimeAttr(Time = 1)]
        Easy
    }
}
