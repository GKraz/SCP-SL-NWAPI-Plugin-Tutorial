using System.ComponentModel;

namespace SCPSL_Plugin_Training._3._Less_Basic_Example.ExampleEvent
{
    public class SubConfig
    {
        [Description("This is a string")]
        public string String { get; set; } = "Example string";

        [Description("Irradiation damage interval (seconds).")]
        public int Interval { get; set; } = 2;
    }
}