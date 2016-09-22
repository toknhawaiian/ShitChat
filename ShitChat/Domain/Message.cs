using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitChat.Domain
{
    public class Message : ShitChatDomain
    {
        public Message(Guid key, string content, DateTime sent) : base(key)
        {
            Content = content;
            Sent = sent;
        }

        public string Content { get; private set; }
        public DateTime Sent { get; private set; }
    }
}
