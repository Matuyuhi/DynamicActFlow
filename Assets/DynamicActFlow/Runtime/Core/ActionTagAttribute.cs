using System;

namespace DynamicActFlow.Runtime.Core
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ActionTagAttribute : Attribute
    {
        public string Tag { get; private set; }

        public ActionTagAttribute(string tag)
        {
            Tag = tag;
        }
    }
}