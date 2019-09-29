namespace PersistentFogAdjuster
{
    [ConfigurationPath("PersistentFogAdjuster.xml")]
    public class PersistentFogAdjusterConfiguration
    {
        public float FogValue { get; set; } = -0.49f;
    }
}
