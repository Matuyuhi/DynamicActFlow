#region

using UnityEngine;

#endregion

namespace DynamicActFlow.Runtime.Core.Action
{
    internal static class ActionBaseEx
    {
        internal static ActionRef CreateActionRef(this ActionBase action, MonoBehaviour owner)
        {
            ActionRef actionRef = new(action, owner);
            return actionRef;
        }
    }
}