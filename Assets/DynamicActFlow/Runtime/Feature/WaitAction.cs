using System.Collections;
using DynamicActFlow.Runtime.Core;
using DynamicActFlow.Runtime.Core.Action;
using UnityEngine;

namespace DynamicActFlow.Runtime.Feature
{
    [ActionTag("Wait")]
    public sealed class WaitAction: CalledAction
    {
        [ActionParameter("seconds", 1f)] private float Seconds { get; set; } = 1f;

        protected override IEnumerator Call()
        {
            yield return new WaitForSeconds(Seconds);
        }
    }
}