using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShitChat.Models
{
    public class DeviceIdRequest
    {
        public Guid DeviceId { get; set; }

        public DeviceIdRequest()
        {

        }

        public DeviceIdRequest(Guid deviceId)
        {
            DeviceId = deviceId;
        }
    }
}
