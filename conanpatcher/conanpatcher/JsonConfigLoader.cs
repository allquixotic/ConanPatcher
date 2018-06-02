using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conanpatcher
{
    class JsonConfigLoader
    {
        public static Config Load(string jsonData)
        {
            Config conf = JsonConvert.DeserializeObject<Config>(jsonData);
            return conf;
        }
    }
}
