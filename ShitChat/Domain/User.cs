using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitChat.Domain
{
    public class User : ShitChatDomain
    {
        public User(Guid key) : base(key)
        {

        }

        public IList<Message> Messages { get; private set; }
    }
}
