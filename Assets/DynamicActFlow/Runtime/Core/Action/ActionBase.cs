#region

using System.Collections;
using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace DynamicActFlow.Runtime.Core.Action
{
    public abstract class ActionBase : IFlowObject
    {
        /// <summary>
        ///     Represents the owner of an Action.
        /// </summary>
        protected MonoBehaviour Owner;

        [CanBeNull] protected TriggerBase Trigger { get; private set; }

        public virtual void OnCreated()
        {
        }

        internal void SetTrigger(TriggerBase trigger)
        {
            Trigger = trigger;
        }

        protected bool IfEndWithTrigger() => Trigger != null && Trigger.IfEnd(Owner);

        protected abstract IEnumerator OnAction();

        public IEnumerator ExecuteActionCoroutine(MonoBehaviour @object)
        {
            Owner = @object;
            yield return OnAction();
        }
    }
}