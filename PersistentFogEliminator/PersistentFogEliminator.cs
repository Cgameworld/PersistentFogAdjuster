using ColossalFramework.UI;
using ICities;
using UnityEngine;

namespace PersistentFogAdjuster
{
    public class PersistentFogAdjuster : IUserMod
    {
        public string Name
        {
            get { return "Persistent Fog Adjuster"; }
        }

        public string Description
        {
            get { return "Makes specified fog value persistent"; }
        }
        // Sets up a settings user interface
        public void OnSettingsUI(UIHelperBase helper)
        {
            // Load the configuration
            PersistentFogAdjusterConfiguration config = Configuration<PersistentFogAdjusterConfiguration>.Load();

            //maybe add restricted/ unrestricted mode and on off button
            helper.AddTextfield("Fog Value (Functional Range: -0.49 to 2)", config.FogValue.ToString(), sel =>
            {
               /* if (sel != "-" && float.TryParse(sel, out _) == false)
                {
                    ExceptionPanel panel = UIView.library.ShowModal<ExceptionPanel>("ExceptionPanel");
                    panel.SetMessage("Bad Value", "Only numerical values accepted", false);
                }
                else if (float.Parse(sel) <= -0.50f)
                {
                    ExceptionPanel panel = UIView.library.ShowModal<ExceptionPanel>("ExceptionPanel");
                    panel.SetMessage("Value Too Low", "Enter values greater than -0.49", false);
                }
                else
                {
                    config.FogValue = float.Parse(sel);
                    Configuration<PersistentFogAdjusterConfiguration>.Save();
                }
                */
                config.FogValue = float.Parse(sel);
                Configuration<PersistentFogAdjusterConfiguration>.Save();

            });
        }


    }
}
