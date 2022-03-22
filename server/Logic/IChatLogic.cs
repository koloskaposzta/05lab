using server.Models;
using System.Collections.Generic;

namespace server.Logic
{
    public interface IChatLogic
    {
        IList<Message> GetAllMessages();
        void SendMessage(Message m);
    }
}