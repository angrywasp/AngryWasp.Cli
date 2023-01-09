using AngryWasp.Logger;
using AngryWasp.Cli.Args;
using AngryWasp.Cli.Config;
using System;
using AngryWasp.Cli.Test.Commands;

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

            //Automatically register all commands with the ApplicationCommand attribute
            Application.RegisterCommands();

            //Or manually register commands
            Application.RegisterCommand("hello", "Says hello", new Hello().Handle);
            
            Application.Start();
        }
    }
}