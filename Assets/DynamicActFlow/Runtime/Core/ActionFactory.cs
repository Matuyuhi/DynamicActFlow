using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DynamicActFlow.Runtime.Action;

namespace DynamicActFlow.Runtime.Core
{
    public static class ActionFactory
    {
        private static Dictionary<string, Type> actionMap = new Dictionary<string, Type>();

        static ActionFactory()
        {
            // アクションをマップに登録
            RegisterActions();
        }

        private static void RegisterActions()
        {
            // 全アクションクラスを反射で検出し、マップに登録
            var actionTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsSubclassOf(typeof(ActionBase)) && t.GetCustomAttribute<ActionTagAttribute>() != null);
        
            foreach (var type in actionTypes)
            {
                var tagAttribute = type.GetCustomAttribute<ActionTagAttribute>();
                actionMap[tagAttribute.Tag] = type;
            }
        }

        public static ActionBase CreateAction(string tag)
        {
            if (actionMap.ContainsKey(tag))
            {
                return (ActionBase)Activator.CreateInstance(actionMap[tag]);
            }
            throw new InvalidOperationException("No action found with tag: " + tag);
        }
    }
}