using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace conanpatcher
{
    class WebConfigLoader
    {
        public static Config Load(string url)
        {
            var req = WebRequest.Create(url);
            return JsonConfigLoader.Load(WebHelper.GetDocumentContents(req));
        }
    }
}
