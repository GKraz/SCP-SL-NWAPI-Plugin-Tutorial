using PluginAPI.Core.Attributes;
using PluginAPI.Events;
using SCPSL_Plugin_Training._3._Less_Basic_Example.ExampleEvents;

namespace SCPSL_Plugin_Training._3._Less_Basic_Example
{
    public class Main
    {
        [PluginConfig] public static MainConfig MainConfig;
        
        /// <summary>
        /// Initial plugin loading and event registration
        /// </summary>
        [PluginEntryPoint("LessBasicPlugin", "0.0.0", "Example", "DMFGames")]
        public void EntryPoint()
        {
            if (!MainConfig.Enabled) return;
            
            // You can register events by class.
            EventManager.RegisterEvents<HandcuffExample>(this);
            
            // Or register all events.
            EventManager.RegisterAllEvents(this);
        }
    }
}