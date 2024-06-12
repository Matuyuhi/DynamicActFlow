using DynamicActFlow.Runtime.Core.Action;

namespace DynamicActFlow.Runtime.Core.Flow
{
    public interface IFlowBuilder
    {
    
        public ActionRef GetActionRef(ActionBase action);
    }
}