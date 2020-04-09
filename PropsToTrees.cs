using System;
using ICities;
using UnityEngine;
using ColossalFramework.Plugins;

namespace PropsToTrees
{
    public class PropsToTrees : IUserMod
    {
        public string Name
        {  
            get { return "PropsToTrees"; }
        }

        public string Description
        {
            get { return "My first mode to convert Props to Trees"; }
        }
    }

    public class Loader : LoadingExtensionBase
    {
        public override void OnLevelLoaded(LoadMode mode)
        {
            GameObject go = new GameObject("Test Object");
            go.AddComponent<MyBehaviour>();
        }
    }

    public class MyBehaviour : MonoBehaviour
    {
        void Start()
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "IT WORKS!!! SOO COOL");
        }
            
        void Update()
        {
            //
        }
    }
}
