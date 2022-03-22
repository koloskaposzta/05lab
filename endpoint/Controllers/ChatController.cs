using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using server.Logic;
using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        IChatLogic logic;

        public ChatController(IChatLogic l)
        {
            this.logic = l;
        }

        [HttpGet]
        public IEnumerable<Message> ReadAll()
        {
            return logic.GetAllMessages();
        }

        [HttpPost]

        public void SendAMessage([FromBody] Message m)
        {
            logic.SendMessage(m);
        }
    }
}
