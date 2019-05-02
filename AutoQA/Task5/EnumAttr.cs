using System;
using System.Collections.Generic;
using System.Text;

namespace AutoQA.Task5
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class EnumAttr : Attribute
    {
        public EnumAttr()
        {
        }
    }
}
