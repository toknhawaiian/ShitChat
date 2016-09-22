using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitChat.Domain
{
    public abstract class ShitChatDomain
    {
        public Guid Key { get; private set; }

        public ShitChatDomain(Guid key)
        {
            Key = key;
        }
    }
}
