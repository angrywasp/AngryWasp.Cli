using AngryWasp.Cli.Config;

namespace AngryWasp.Cli.Test
{
    public class CommandLine
    {
        [CommandLineArgument("a", 100, "Example integer argument.")]
        public int A { get; set; }

        [CommandLineArgument("b", "Hello World", "Example string argument.")]
        public string B { get; set; }

        [CommandLineArgument("c", true, "Example boolean argument.")]
        public bool C { get; set; }
    }
}