using HelloWorldCommunicator.API.Contracts;

namespace HelloWorldCommunicator.API.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        public string GetMessage()
        {
            return "Hello World!";
        }
    }
}
