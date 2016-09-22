using ShitChat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitChat.Repository
{
    public class ShitChatUserRepository : IShitChatRepository<User>
    {
        private Dictionary<Guid, User> users;

        public ShitChatUserRepository()
        {
            users = new Dictionary<Guid, User>();
        }

        public async Task Delete(Guid key)
        {
            users.Remove(key);
            await Task.FromResult(0);
        }

        public async Task Persist(User user)
        {
            User activeUser = null;
            if(users.TryGetValue(user.Key, out activeUser))
            {
                activeUser = user;
            }
            else
            {
                users.Add(user.Key, user);
            }

            await Task.FromResult(0);
        }

        public async Task<User> Reconstitute(Guid key)
        {
            User activeUser = null;
            users.TryGetValue(key, out activeUser);
            return await Task.FromResult(activeUser);
        }
    }
}
