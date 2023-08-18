using System.ComponentModel;
using SCPSL_Plugin_Training._3._Less_Basic_Example.ExampleEvent;

namespace SCPSL_Plugin_Training._3._Less_Basic_Example
{
    public class MainConfig
    {
        [Description("If the plugin is enabled.")]
        public bool Enabled { get; set; } = true;

        public SubConfig SubConfig { get; set; } = new();
    }
}