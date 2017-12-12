using System;

namespace HotDocsFileCounter.Commands.CustomCommands
{
    class ClearCommand : ICommand
    {
        public string Name
        {
            get { return "clear"; }
        }
        public string HelpText
        {
            get { return "Clears the console screen"; }
        }

        public bool IsPrivileged
        {
            get { return false; }
        }

        public string Execute(string[] args)
        {
            Console.Clear();
            return null;
        }


        
    }
}
