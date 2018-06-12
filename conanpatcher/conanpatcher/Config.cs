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
        [DefaultValue(defaultServerName)]
        public String ServerName { get; set; }

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

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public String ModPath { get; set; }

        public const string defaultConanGameID = "440900";
        public const string defaultConanGameName = "Conan Exiles";
        public const string defaultRsyncArgs = "--inplace --no-acls --no-xattrs --no-perms --no-owner --no-group  --compress --progress --verbose --checksum --delete --recursive --force --log-file=rsync.log";
        public const string defaultServerName = "Default Server";

        public Config()
        {
            ModPath = SharedState.PathInfo.WorkshopModFolder;
            GameName = defaultConanGameName;
            GameID = defaultConanGameID;
            ServerName = defaultServerName;
            RsyncArgs = defaultRsyncArgs;
        }

        public string GetAbsoluteModPath()
        {
            String baseString = SharedState.PathInfo.GameFolder, modString = ModPath;

            if (Path.IsPathRooted(ModPath))
            {
                return MakeRelativePath(baseString, modString).TrimEnd(Path.DirectorySeparatorChar);
            }
            else
            {
                return Path.GetFullPath(Path.Combine(baseString, modString));
            }
        }

        public static String MakeRelativePath(String fromPath, String toPath)
        {
            if (!(fromPath.EndsWith("/") || fromPath.EndsWith("\\")))
            {
                fromPath += "\\";
            }

            if (!(toPath.EndsWith("/") || toPath.EndsWith("\\")))
            {
                toPath += "\\";
            }

            if (String.IsNullOrEmpty(fromPath)) throw new ArgumentNullException("fromPath");
            if (String.IsNullOrEmpty(toPath)) throw new ArgumentNullException("toPath");

            Uri fromUri = new Uri(fromPath);
            Uri toUri = new Uri(toPath);

            if (fromUri.Scheme != toUri.Scheme) { return toPath; } // path can't be made relative.

            Uri relativeUri = fromUri.MakeRelativeUri(toUri);
            String relativePath = Uri.UnescapeDataString(relativeUri.ToString());

            if (toUri.Scheme.Equals("file", StringComparison.InvariantCultureIgnoreCase))
            {
                relativePath = relativePath.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
            }

            return relativePath;
        }
    }
}
