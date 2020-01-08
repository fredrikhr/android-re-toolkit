using System.CommandLine.Invocation;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;

using THNETII.CommandLine.Hosting;

namespace Couven92.AndroidRe.ToolkitConsole
{
    public static class Program
    {
        public static ICommandHandler RootCommandHandler { get; } = CommandHandler.Create(
        (IHost host, CancellationToken cancelToken) =>
        {

        });

        public static Task<int> Main(string[] args)
        {
            var definition = new RootCommandDefinition(RootCommandHandler);

            return DefaultCommandLine.InvokeAsync(definition, args, host =>
            {

            });
        }
    }
}
