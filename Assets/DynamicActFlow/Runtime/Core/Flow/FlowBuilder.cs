using DynamicActFlow.Runtime.Core.Action;
using UnityEngine;

namespace DynamicActFlow.Runtime.Core.Flow
{
    internal sealed class FlowBuilder: IFlowBuilder
    {
        private ActionBase currentAction;
        private MonoBehaviour owner;
    
        public FlowBuilder(MonoBehaviour owner)
        {
            this.owner = owner;
        }
        
        public ActionRef GetActionRef(ActionBase action)
        {
            return action.CreateActionRef(owner);
        }
    }
}