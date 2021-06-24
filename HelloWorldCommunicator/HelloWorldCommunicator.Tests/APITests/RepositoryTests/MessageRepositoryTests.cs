using HelloWorldCommunicator.API.Repositories;
using Xunit;

namespace HelloWorldCommunicator.Tests.APITests.RepositoryTests
{
    public class MessageRepositoryTests
    {
        private MessageRepository MessageRepository;

        [Fact]
        public void MessageRepository_GetMessage_Success()
        {
            MessageRepository = new MessageRepository();
            var expectedMessage = "Hello World!";
            var message = MessageRepository.GetMessage();

            Assert.Equal(expectedMessage, message);
        }
    }
}
