using System.Collections;

namespace DynamicActFlow.Runtime.Core.Action
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class CalledAction: ActionBase
    {
        protected abstract IEnumerator Call();

        protected override IEnumerator OnAction()
        {
            yield return Call();
        }
    }
}