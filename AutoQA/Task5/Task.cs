using System;
using System.Collections.Generic;
using System.Text;

namespace AutoQA.Task5
{
    class Task
    {
        public string Description;
        public Priority Priority;
        public Complexity Complexity;
        public int Time
        {
            get
            {
                Complexity complexity = (Complexity)Enum.Parse(typeof(Complexity), Complexity.ToString());
                return ((TimeAttr)complexity.GetAttr()).Time;
            }
        }

        public Task(string description, Priority priority, Complexity complexity)
        {
            Description = description;
            Priority = priority;
            Complexity = complexity;
        }
    }
}
