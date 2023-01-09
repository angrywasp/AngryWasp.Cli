using System.Threading.Tasks;
using AngryWasp.Cli.Prompts;

namespace AngryWasp.Cli.Test.Commands
{
    public class Hello : IApplicationCommand
    {
        public async Task<bool> Handle(string command)
        {
            Application.UserInputPaused = true;
            ApplicationLogWriter.WriteImmediate("Hello\n", System.ConsoleColor.Green);
            Application.UserInputPaused = false;
            return true;
        }
    }
}