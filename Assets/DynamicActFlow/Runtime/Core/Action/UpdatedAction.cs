#region

using System.Collections;

#endregion

namespace DynamicActFlow.Runtime.Core.Action
{
    public abstract class UpdatedAction : ActionBase
    {
        protected abstract void Start();
        protected abstract void Update();

        protected abstract bool CheckIfEnd();


        protected override IEnumerator OnAction()
        {
            Start();
            while (!CheckIfEnd())
            {
                Update();
                yield return null;
            }
        }
    }
}