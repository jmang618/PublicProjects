using HelloWorldCommunicator.API.Contracts;
using HelloWorldCommunicator.API.Controllers;
using Moq;
using Xunit;

namespace HelloWorldCommunicator.Tests.APITests.ControllerTests
{
    public class MessageControllerTests
    {
        private readonly Mock<IMessageRepository> MessageRepository;
        private MessageController MessageController;

        public MessageControllerTests()
        {
            MessageRepository = new Mock<IMessageRepository>();
        }

        [Fact]
        public void MessageController_GetMessage_Success()
        {
            var expectedString = "Hello World!";

            MessageRepository.Setup(m => m.GetMessage()).Returns(expectedString);

            MessageController = new MessageController(MessageRepository.Object);

            var responseMessage = MessageController.GetMessage();

            Assert.Equal(expectedString, responseMessage);
        }
    }
}
