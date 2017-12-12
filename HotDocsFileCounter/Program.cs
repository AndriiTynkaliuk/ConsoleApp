using System;
using System.Linq;
using HotDocsFileCounter.Commands;
using HotDocsFileCounter.Exceptions;

namespace HotDocsFileCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandHandler.RegisterCommands();
            while (true)
            {
                try
                {
                    if (args.Length == 0)
                    {
                        Console.Write(">>> ");
                        string line = Console.ReadLine();
                        if (String.IsNullOrEmpty(line))
                        {
                            Console.WriteLine("Parameters have not been specified");
                            continue;
                        }

                        string[] arguments = line.Split(' ');
                        string command = arguments[0].ToLower();
                        arguments = arguments.Skip(1).ToArray();

                        Console.WriteLine("[{0}] {1}",
                            command,
                            CommandRegistry<ICommand>.Execute(command, arguments));
                    }
                    else
                    {
                        string command = args[0];
                        string[] arguments = args.Skip(1).ToArray();
                        Console.WriteLine("[{0}] {1}", 
                            command, 
                            CommandRegistry<ICommand>.Execute(command, arguments));
                        
                        break;
                    }
                }
                catch (CommandNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
