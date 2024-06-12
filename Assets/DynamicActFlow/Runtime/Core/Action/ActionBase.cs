using System.Collections;
using UnityEngine;

namespace DynamicActFlow.Runtime.Core.Action
{
    public abstract class ActionBase
    {
        protected MonoBehaviour Owner;

        protected abstract IEnumerator OnAction();

        public IEnumerator ExecuteActionCoroutine(MonoBehaviour @object)
        {
            Owner = @object;
            yield return OnAction();
        }
    }
}