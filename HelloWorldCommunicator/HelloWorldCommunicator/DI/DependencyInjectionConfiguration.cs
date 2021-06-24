using HelloWorldCommunicator.BusinessLogic;
using HelloWorldCommunicator.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorldCommunicator.DI
{
    public static class DependencyInjectionConfiguration
    {
        public static ServiceProvider BuildServiceProvider()
        {
            return new ServiceCollection()
                .AddSingleton<IMessageWriter, ConsoleMessageWriter>()
                .BuildServiceProvider();
        }
    }
}
