using ShitChat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitChat.Repository
{
    public interface IShitChatUserAssociation
    {
        BiDictionaryOneToOne<Guid, Guid> Dictionary { get; set; }
    }
}
