using ShitChat.Domain;
using ShitChat.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitChat.Workflow
{
    public abstract class ShitChatCommandWorkflow<Request>
        where Request : ShitChatRequest
    {
        protected ShitChatCommandWorkflow()
        {
        }

        protected abstract Task<CommandResponse> PerformBehavior(Request request);

        public async Task<CommandResponse> Invoke(Request request)
        {
            return await PerformBehavior(request);
        }
    }
}
