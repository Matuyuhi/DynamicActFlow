using System;

namespace DynamicActFlow.Runtime.Core.Action
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ActionParameterAttribute : Attribute
    {
        public string Tag { get; private set; }
        
        public object DefaultValue { get; private set; }

        public ActionParameterAttribute(string tag, object defaultValue = default)
        {
            Tag = tag;
            
            DefaultValue = defaultValue;
        }
    }
}