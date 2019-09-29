using ColossalFramework;
using ColossalFramework.IO;
using ColossalFramework.UI;
using ICities;
using System;
using System.IO;
using UnityEngine;

namespace PersistentFogAdjuster
{
    public class ModThreading : ThreadingExtensionBase
    {
        PersistentFogAdjusterConfiguration config = Configuration<PersistentFogAdjusterConfiguration>.Load();
        public override void OnUpdate(float realTimeDelta, float simulationTimeDelta)
        {
            WeatherManager.instance.m_currentFog = config.FogValue;
            Debug.Log("Fog Value:" + WeatherManager.instance.m_currentFog + "saved:" + config.FogValue);

        }

    }
}