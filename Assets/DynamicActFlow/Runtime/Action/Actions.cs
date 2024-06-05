using DynamicActFlow.Runtime.Core;

namespace DynamicActFlow.Runtime.Action
{
    public static class Actions
    {

        public static ActionBase Action(this IFlowBuilder builder, string tag)
        {
            return ActionFactory.CreateAction(tag);
        }
    }
}