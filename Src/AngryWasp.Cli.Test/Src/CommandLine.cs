using AngryWasp.Cli.Config;

namespace AngryWasp.Cli.Test
{
    public class CommandLine
    {
        [CommandLineArgument("a", "Example integer argument.")]
        public int A { get; set; } = 100;

        [CommandLineArgument("b", "Example string argument.")]
        public string B { get; set; } = "Hello World";

        [CommandLineArgument("c", "Example boolean argument.")]
        public bool C { get; set; }
    }
}