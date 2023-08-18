using PluginAPI.Core.Attributes;
using PluginAPI.Events;

namespace SCPSL_Plugin_Training._3._Less_Basic_Example
{
    public class Main
    {
        public Main Plugin { get; private set; }
        
        [PluginConfig] public MainConfig MainConfig;
        
        
        [PluginEntryPoint("", "", "", "")]
        public void EntryPoint()
        {
            if (!Plugin.MainConfig.Enabled) return;
            
            Plugin = this;
            
            EventManager.RegisterEvents<Event>(Plugin);
        }
    }
}