#region

using DynamicActFlow.Runtime.Core.Action;
using UnityEngine;

#endregion

namespace DynamicActFlow.Runtime.Core.Flow
{
    public abstract class FlowScope : FlowScopeBase
    {
        private IFlowBuilder builder;

        private Coroutine coroutine;

        protected virtual void Start()
        {
            builder = new FlowBuilder(this);
            FlowCreate();
        }


        protected override void FlowCreate()
        {
            StopFlow();
            coroutine = StartCoroutine(Flow(builder));
        }

        protected void StopFlow()
        {
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
            }
        }

        protected override ActionRef Action(string actionName) => builder.Action(actionName);

        protected override ActionRef Wait(float seconds) => builder.Action(ActionName.Wait).Param("seconds", seconds);
    }
}