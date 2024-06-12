using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace DynamicActFlow.Runtime.Core.Action
{
    public class ActionRef
    {

        private ActionBase action;
        private MonoBehaviour owner;
        
        internal ActionRef(ActionBase action, MonoBehaviour owner)
        {
            this.action = action;
            this.owner = owner;
        }

        private Action<string, object> a;
        
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