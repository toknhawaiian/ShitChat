using Nancy;
using ShitChat.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitChatAPI.Module
{
    public class ShitChat : NancyModule
    {
        public ShitChat() : base("/ShitChat/api")
        {
            Get["/checkInbox", true] = async (parameters, cancelationToken) =>
            {
                return await Task.FromResult(1);
            };

            Post["/sendMessage", true] = async (parameters, cancelationToken) =>
            {
                return await Task.FromResult(1);
            };

            Post["/findFriend", true] = async (parameters, cancelationToken) =>
            {
                return await Task.FromResult(1);
            };
        }
    }
}
