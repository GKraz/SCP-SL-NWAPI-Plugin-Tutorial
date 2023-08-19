using PluginAPI.Core.Attributes;
using PluginAPI.Events;
using SCPSL_Plugin_Training._3._Less_Basic_Example.ExampleEvents;

namespace SCPSL_Plugin_Training._3._Less_Basic_Example
{
    public class Main
    {
        public static Main Plugin { get; private set; }
        
        [PluginConfig] public MainConfig MainConfig;
        
        /// <summary>
        /// Initial plugin loading and event registration
        /// </summary>
        [PluginEntryPoint("LessBasicPlugin", "", "", "")]
        public void EntryPoint()
        {
            Plugin = this;
            
            if (!Plugin.MainConfig.Enabled) return;
            
            // You can register events by class.
            EventManager.RegisterEvents<HandcuffExample>(Plugin);
            
            // Or register all events.
            EventManager.RegisterAllEvents(Plugin);
        }
    }
}