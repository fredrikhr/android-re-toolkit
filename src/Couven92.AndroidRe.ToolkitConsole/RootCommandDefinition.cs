using System.CommandLine;
using System.CommandLine.Invocation;

using THNETII.CommandLine.Hosting;

namespace Couven92.AndroidRe.ToolkitConsole
{
    internal class RootCommandDefinition : ICommandDefinition
    {
        public RootCommandDefinition(ICommandHandler handler)
        {
            RootCommand = new RootCommand() { Handler = handler };
        }

        public Command RootCommand { get; }
    }
}
