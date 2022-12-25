using System;

namespace AngryWasp.Cli.Config
{
    public class CommandLineArgumentAttribute : Attribute
    {
        private string flag;
        private object defaultValue;
        private string description;

        public string Flag => flag;
        public object DefaultValue => defaultValue;
        public string Description => description;

        public CommandLineArgumentAttribute(string flag, object defaultValue, string description)
        {
            this.flag = flag;
            this.defaultValue = defaultValue;
            this.description = description;
        }
    }
}