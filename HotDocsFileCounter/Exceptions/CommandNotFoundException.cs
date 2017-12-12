using System;
using System.Runtime.Serialization;

namespace HotDocsFileCounter.Exceptions
{
    class CommandNotFoundException : Exception
    {
        public string RequestedCommandName { get; set; }

        public CommandNotFoundException() { }

        public CommandNotFoundException(string commandName) 
            : base(string.Format("Command {0} was not found", commandName)) { }

        protected CommandNotFoundException(SerializationInfo info, StreamingContext context) 
            : base(info, context) { }
    }
}
