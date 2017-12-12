using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDocsFileCounter.Commands.CustomCommands
{
    public class HelpCommand : ICommand
    {
        public string Name
        {
            get { return "help"; }
        }

        public string HelpText
        {
            get { return "Displays information about the program."; }
        }

        public bool IsPrivileged
        {
            get { return false; }
        }

        public string Execute(string[] args)
        {
            foreach (ICommand command in CommandHandler.AllCommands)
            {
                Console.WriteLine("\t{0}:\t{1}", command.Name, command.HelpText);
            }
            return null;
        }
    }
}
