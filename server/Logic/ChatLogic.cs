using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Logic
{
    public class ChatLogic : IChatLogic
    {
        List<Message> allMessages;

        public ChatLogic()
        {

            allMessages = new List<Message>();
            this.SendMessage(new Message() { Date = DateTime.Now, Sender = "Chat god", Text = "Welcome to the chat" });
        }
        public void SendMessage(Message m)
        {
            allMessages.Add(m);
        }

        public IList<Message> GetAllMessages()
        {
            return allMessages;
        }
    }
}
