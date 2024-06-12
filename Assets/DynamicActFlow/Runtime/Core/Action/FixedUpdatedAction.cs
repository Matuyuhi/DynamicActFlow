#region

using System.Collections;
using UnityEngine;

#endregion

namespace DynamicActFlow.Runtime.Core.Action
{
    public abstract class FixedUpdatedAction : ActionBase
    {
        protected abstract void Start();
        protected abstract void FixedUpdate();

        protected abstract bool CheckIfEnd();

        protected override IEnumerator OnAction()
        {
            Start();
            while (!CheckIfEnd())
            {
                FixedUpdate();
                yield return new WaitForFixedUpdate();
            }
        }
    }
}