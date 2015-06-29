using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShitChat.Models
{
    public class RetrieveMessageResponse
    {
        public List<string> MessageList { get; set; }

        public RetrieveMessageResponse()
        {
        }

        public RetrieveMessageResponse(List<string> messageList)
        {
            MessageList = messageList;
        }
    }
}
