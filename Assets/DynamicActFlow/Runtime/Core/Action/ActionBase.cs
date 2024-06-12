#region

using System.Collections;
using UnityEngine;

#endregion

namespace DynamicActFlow.Runtime.Core.Action
{
    public abstract class ActionBase
    {
        protected MonoBehaviour Owner;

        public virtual void SetDefault()
        {
        }

        protected abstract IEnumerator OnAction();

        public IEnumerator ExecuteActionCoroutine(MonoBehaviour @object)
        {
            Owner = @object;
            yield return OnAction();
        }
    }
}