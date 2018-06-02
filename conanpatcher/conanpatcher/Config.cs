using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace conanpatcher
{
    public class Config
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(defaultConanGameID)]
        public String GameID { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(defaultConanGameName)]
        public String GameName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public String ModlistUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public String RsyncUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(defaultRsyncArgs)]
        public String RsyncArgs { get; set; }

        public const string defaultConanGameID = "440900";
        public const string defaultConanGameName = "Conan Exiles";
        public const string defaultRsyncArgs = "-z --progress --verbose --checksum --delete --recursive --force --log-file=rsync.log";

        public Config()
        {
            
        }
    }
}
