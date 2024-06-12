using DynamicActFlow.Runtime.Core.Flow;

namespace DynamicActFlow.Runtime.Core.Action
{
    public static class Actions
    {

        internal static ActionRef Action(this IFlowBuilder builder, string tag) =>
            builder.GetActionRef(ActionFactory.CreateAction(tag));

        public static ActionRef Param(this ActionRef action, string key, object value)
        {
            action.SetParam(key, value);
            return action;
        }
        
        public static ActionRef IfEnd(this ActionRef action, string key, object value)
        {
            action.SetParam(key, value);
            return action;
        }
    }
}