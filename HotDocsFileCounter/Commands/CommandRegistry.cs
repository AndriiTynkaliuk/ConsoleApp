using System.Collections.Generic;
using HotDocsFileCounter.Exceptions;

namespace HotDocsFileCounter.Commands
{
    public static class CommandRegistry<T> where T : ICommand
    {
        private static readonly Dictionary<string, T> Register;

        static CommandRegistry()
        {
            Register = new Dictionary<string, T>();
        }

        public static T GetCommand(string name)
        {
            if (Register.ContainsKey(name))
                return Register[name];

            throw new CommandNotFoundException(name);
        }

        public static void RegisterCommand(T command)
        {
            Register.Add(command.Name, command);
        }

        public static string Execute(string name, string[] args)
        {
            if (Register.ContainsKey(name))
                return Register[name].Execute(args);
            throw new CommandNotFoundException(name);
        }
    }
}
