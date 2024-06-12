using System.Collections;
using DynamicActFlow.Runtime.Core.Action;
using UnityEngine;

namespace DynamicActFlow.Runtime.Core.Flow
{
    public abstract class FlowScopeBase: MonoBehaviour
    {
        protected abstract IEnumerator Flow(IFlowBuilder context);

        protected abstract void FlowCreate();

        protected abstract ActionRef Action(string actionName);
        
        protected abstract ActionRef Wait(float seconds);
        
    }
}