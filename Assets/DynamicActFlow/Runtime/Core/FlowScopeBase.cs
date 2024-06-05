using UnityEngine;

namespace DynamicActFlow.Runtime.Core
{
    public abstract class FlowScopeBase: MonoBehaviour
    {
        protected virtual void Flow(IFlowBuilder builder)
        {
            
        }

        private void Start()
        {
            var builder = new FlowBuilder();
            Flow(builder);
        }
    }
}