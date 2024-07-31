#region

using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        private List<TriggerBase> Trigger { get; set; } = new();

        public virtual void OnCreated()
        {
        }

        internal void SetTrigger(TriggerBase trigger)
        {
            Trigger.Add(trigger);
        }

        internal void SetTriggers(TriggerBase[] triggers)
        {
            Trigger = new(triggers);
        }

        internal void StartTrigger()
        {
            Trigger.ForEach(trigger => trigger.Start());
        }

        protected bool IfEndWithTrigger() => Trigger != null && Trigger.Any(trigger => trigger.IfEnd(Owner));

        protected abstract IEnumerator OnAction();

        public IEnumerator ExecuteActionCoroutine(MonoBehaviour @object)
        {
            Owner = @object;
            yield return OnAction();
        }
    }
}