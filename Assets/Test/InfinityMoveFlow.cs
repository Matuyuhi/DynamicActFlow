using System.Collections;
using DynamicActFlow.Runtime.Core.Action;
using DynamicActFlow.Runtime.Core.Flow;
using UnityEngine;

namespace Test
{
    public class InfinityMoveFlow: FlowScope
    {
        protected override IEnumerator Flow(IFlowBuilder context)
        {
            for (var _ = 0; _ < 2; _++)
            {
                yield return Wait(2f)
                    .Execute();

                yield return Action("MoveLoop")
                    .Param("direction", Vector3.right)
                    .Param("loopCount", 2)
                    .Param("range", 5f)
                    .Execute();
            }
        }
    }
}