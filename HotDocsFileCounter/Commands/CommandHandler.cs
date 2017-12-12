using System.Collections.Generic;
using HotDocsFileCounter.Commands.CustomCommands;

namespace HotDocsFileCounter.Commands
{
    public static class CommandHandler
    {
        public static readonly List<ICommand> AllCommands = new List<ICommand>
        {
            new ClearCommand(),
            new ExitCommand(),
            new HelpCommand()
        };

        public static void RegisterCommands()
        {
            foreach (ICommand command in AllCommands)
            {
                CommandRegistry<ICommand>.RegisterCommand(command);
            }
        }
    }
}
