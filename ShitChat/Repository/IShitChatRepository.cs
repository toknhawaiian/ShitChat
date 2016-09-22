using ShitChat.Domain;
using ShitChat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitChat.Repository
{
    public interface IShitChatRepository<Domain> where Domain : ShitChatDomain
    {
        Task<Domain> Reconstitute(Guid key);
        Task Persist(User user);
        Task Delete(Guid key);

    }
}
