using ShitChat.Contract;
using ShitChat.Domain;
using ShitChat.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitChat.Workflow
{
    public class SendMessage : ShitChatCommandWorkflow<SendMessageRequest>
    {
        private IShitChatUserAssociation association;
        private IShitChatRepository<User> repository;

        public SendMessage(IShitChatRepository<User> repository,
                           IShitChatUserAssociation association)
        {
            this.association = association;
        }

        protected override async Task<CommandResponse> PerformBehavior(SendMessageRequest request)
        {
            var response = new CommandResponse();

            var activeAssociation = Guid.Empty;
            if (!association.Dictionary.TryGetByFirst(request.Key, out activeAssociation))
            {
                if (!association.Dictionary.TryGetBySecond(request.Key, out activeAssociation))
                {
                    response.Status = ShitChatResponseStatus.Failed;
                    return await Task.FromResult(response);
                }
            }

            var sendTo = await repository.Reconstitute(activeAssociation);
            request.Messages.(m => sendTo.Messages.Add(new Message(Guid.NewGuid(), m.Content, m.Sent)));


            repository.Persist
        }
    }
}
