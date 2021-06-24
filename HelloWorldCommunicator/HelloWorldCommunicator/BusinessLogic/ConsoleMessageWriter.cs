using HelloWorldCommunicator.Contracts;
using System;

namespace HelloWorldCommunicator.BusinessLogic
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
