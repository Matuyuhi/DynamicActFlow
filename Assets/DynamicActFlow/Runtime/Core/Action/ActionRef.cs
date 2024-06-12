#region

using System;
using System.Collections;
using UnityEngine;

#endregion

namespace DynamicActFlow.Runtime.Core.Action
{
    public class ActionRef
    {
        private readonly ActionBase action;
        private readonly MonoBehaviour owner;
        private Action<string, object> a;

        internal ActionRef(ActionBase action, MonoBehaviour owner)
        {
            this.action = action;
            this.owner = owner;
        }

        internal void SetCallback(Action<string, object> callback)
        {
            a = callback;
        }

        internal void SetParam(string key, object param)
        {
            action.SetProperty(key, param);
        }

        public IEnumerator Execute()
        {
            yield return owner.StartCoroutine(action.ExecuteActionCoroutine(owner));
        }
    }
}