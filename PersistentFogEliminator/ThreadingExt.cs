using ColossalFramework.UI;
using ICities;
using UnityEngine;

namespace PersistentFogAdjuster
{
    public class ThreadingExt : LoadingExtensionBase
    {
        public override void OnLevelLoaded(LoadMode mode)
        {
            Debug.Log("Mod Loaded!");
        }

    }
}
