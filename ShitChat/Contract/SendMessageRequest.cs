using ShitChat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitChat.Contract
{
    public class SendMessageRequest : ShitChatRequest
    {
        public Guid Key;
        public IList<MessageModel> Messages;
    }
}
