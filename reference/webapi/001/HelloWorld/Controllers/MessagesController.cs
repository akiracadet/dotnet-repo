using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    [Route("api/messages")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        [HttpGet]
        public ActionResult <IEnumerable<Message>> GetAllMessages()
        {
            var messages = new List<Message>
            {
                new Message{Id=0, Content="Message 1"},
                new Message{Id=1, Content="Message 2"},
                new Message{Id=2, Content="Message 3"}
            };

            return Ok(messages);
        }

        [HttpGet("{id}")]
        public ActionResult <Message> GetMessageById(int id)
        {
            var message = new Message{Id=0, Content="Message 1"};

            return Ok(message);
        }
    }
}
