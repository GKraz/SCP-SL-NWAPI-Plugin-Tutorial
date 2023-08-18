using System.ComponentModel;

namespace SCPSL_Plugin_Training._3._Less_Basic_Example.ExampleEvent
{
    public class SubConfig
    {
        [Description("This is a string")]
        public string Thing { get; set; } = "Example string";
    }
}