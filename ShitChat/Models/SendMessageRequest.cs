using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShitChat.Models
{
    public class SendMessageRequest
    {
        public Guid DeviceId { get; set; }
        public string Message { get; set; }

        public SendMessageRequest()
        {
        }

        public SendMessageRequest(Guid deviceId, string message)
        {
            DeviceId = deviceId;
            Message = message;
        }
    }
}
