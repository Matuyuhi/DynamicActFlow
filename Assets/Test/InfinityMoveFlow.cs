using DynamicActFlow.Runtime.Action;
using DynamicActFlow.Runtime.Core;

namespace Test
{
    public class InfinityMoveFlow: FlowScope
    {
        protected override void Flow(IFlowBuilder builder)
        {
            base.Flow(builder);
            builder.Action("Move");
        }
    }
}