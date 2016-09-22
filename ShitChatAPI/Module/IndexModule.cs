using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitChatAPI.Module
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/list"] = parameters => {
                return "The list of products";
            };

            Get["/"] = parameters =>
            {
                return View["index"];
            };
        }
    }
}
