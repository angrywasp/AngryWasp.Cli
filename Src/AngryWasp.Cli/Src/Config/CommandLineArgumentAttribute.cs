using System;

namespace AngryWasp.Cli.Config
{
    public class CommandLineArgumentAttribute : Attribute
    {
        private string flag;
        private string description;

        public string Flag => flag;
        public string Description => description;

        public CommandLineArgumentAttribute(string flag, string description)
        {
            this.flag = flag;
            this.description = description;
        }
    }
}