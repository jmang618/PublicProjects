using HelloWorldCommunicator.Contracts;
using HelloWorldCommunicator.DI;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HelloWorldCommunicator
{
    public class Program
    { 
        public static void Main()
        {
            var services = DependencyInjectionConfiguration.BuildServiceProvider();
            var messageWriter = services.GetService<IMessageWriter>();

            messageWriter.WriteMessage("Hello World!");

            Console.Read();
        }
    }
}
