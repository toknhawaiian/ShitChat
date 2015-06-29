using ShitChat.Models;
using Nancy;
using Nancy.ModelBinding;
using ShitChatCore;

namespace ShitChat.Modules
{
    public class ShitChatModule : NancyModule
    {

        public ShitChatModule()
            : base("/ShitChat")
        {
            Post["/GetFriend"] = _ =>
            {
                var guid = this.Bind<DeviceIdRequest>();

                ShitChatSandbox.GetAvailableUser(guid.DeviceId);

                return Response.AsJson("Complete");
            };

            Post["/SendMessage"] = _ =>
            {
                var guid = this.Bind<SendMessageRequest>();

                ShitChatSandbox.SendMessage(guid.DeviceId, guid.Message);

                return Response.AsJson("Complete");
            };

            Post["/GetMessages"] = _ =>
            {
                var guid = this.Bind<DeviceIdRequest>();

                var list = ShitChatSandbox.GetMessages(guid.DeviceId);
                var res = new RetrieveMessageResponse(list);
                ShitChatSandbox.ClearMessages(guid.DeviceId);
                return Response.AsJson(res);
            };
        }

    }
}
