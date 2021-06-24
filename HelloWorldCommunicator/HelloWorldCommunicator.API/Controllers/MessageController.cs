using HelloWorldCommunicator.API.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldCommunicator.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMessageRepository MessageRepository;

        public MessageController(IMessageRepository messageRepository)
        {
            MessageRepository = messageRepository;
        }

        [HttpGet]
        public string GetMessage()
        {
            return MessageRepository.GetMessage();
        }
    }
}
