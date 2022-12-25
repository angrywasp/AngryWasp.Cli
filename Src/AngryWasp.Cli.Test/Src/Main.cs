using AngryWasp.Logger;
using AngryWasp.Cli.Args;
using AngryWasp.Cli.Config;
using System;

namespace AngryWasp.Cli.Test
{
    internal class MainClass
    {
        private static void Main(string[] rawArgs)
        {
            var args = Arguments.Parse(rawArgs);
            CommandLine cl = new CommandLine();
            if (!ConfigMapper<CommandLine>.Process(args, cl, null))
                return;

            //use the usual console write methods before the application is started
            Console.WriteLine($"arg A: {cl.A}");
            Console.WriteLine($"arg B: {cl.B}");
            Console.WriteLine($"arg C: {cl.C}");

            Log.CreateInstance(true);

            Console.WriteLine("type 'help' to get a list of commands");
            Application.RegisterCommands();
            Application.Start();
        }
    }
}