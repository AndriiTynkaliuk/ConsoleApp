using System;

namespace HotDocsFileCounter.Commands.CustomCommands
{
    public class ExitCommand : ICommand
    {
        public string Name
        {
            get { return "exit"; }
        }

        public string HelpText
        {
            get { return "Closes the application"; }
        }

        public bool IsPrivileged
        {
            get { return false; }
        }

        public string Execute(string[] args)
        {
            Environment.Exit(0);
            return null;
        }
    }
}
