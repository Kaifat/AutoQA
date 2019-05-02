using System;
using System.Collections.Generic;
using System.Text;

namespace AutoQA.Task5
{
    class Task
    {
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public Complexity Complexity { get; set; }
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
