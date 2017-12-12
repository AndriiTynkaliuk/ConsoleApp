namespace HotDocsFileCounter.Commands
{
    public interface ICommand
    {
        string Name { get; }
        string HelpText { get; }
        bool IsPrivileged { get; }
        string Execute(string[] args);
    }
}