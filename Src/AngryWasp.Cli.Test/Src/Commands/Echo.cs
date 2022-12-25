using System.Threading.Tasks;
using AngryWasp.Cli.Prompts;

namespace AngryWasp.Cli.Test.Commands
{
    [ApplicationCommand("echo", "Repeats the text you enter")]
    public class Sync : IApplicationCommand
    {
        public async Task<bool> Handle(string command)
        {
            //Stop the logger spamming the console while using it temporarily
            Application.UserInputPaused = true;
            
            //ApplicationLogWriter allows you to either write immediately to the console or buffer text
            //buffered text will not be displayed until UserInputPaused = false
            if (!InputPrompt.Get("Enter some text", out string enteredText))
                ApplicationLogWriter.WriteImmediate("You quit without entering anything\n", System.ConsoleColor.Red);
            else
                ApplicationLogWriter.WriteImmediate($"You entered: {enteredText}\n", System.ConsoleColor.Green);

            //bring the spam back
            Application.UserInputPaused = false;
            return true;
        }
    }
}