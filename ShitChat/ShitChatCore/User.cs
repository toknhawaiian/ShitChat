using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitChatCore
{
    public class User
    {
        public Guid UserId { get; private set; }
        public List<string> Inbox { get; set; }
        public bool Paired { get; private set; }
        public Guid PairedWith { get; private set; }

        public User()
        {
        }

        public User(Guid userId, List<string> inbox)
        {
            UserId = userId;
            Inbox = inbox;
        }
    }
}
