#region

using System;

#endregion

namespace DynamicActFlow.Runtime.Core.Action
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ActionParameterAttribute : Attribute
    {
        public ActionParameterAttribute(string tag, object defaultValue = default)
        {
            Tag = tag;

            DefaultValue = defaultValue;
        }

        public string Tag { get; private set; }

        public object DefaultValue { get; private set; }
    }
}