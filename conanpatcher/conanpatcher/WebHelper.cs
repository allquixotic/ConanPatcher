using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace conanpatcher
{
    class WebHelper
    {
        public static string GetDocumentContents(WebRequest Request)
        {
            string documentContents;
            using (Stream receiveStream = Request.GetResponse().GetResponseStream())
            {
                using (StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8))
                {
                    documentContents = readStream.ReadToEnd();
                }
            }
            return documentContents;
        }
    }
}
