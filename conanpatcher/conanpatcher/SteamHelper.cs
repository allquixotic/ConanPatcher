using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace conanpatcher
{
    public static class SteamHelper
    {
        public static string FindOurGamePath(Config c)
        {
            return FindSteamGamePath(c, int.Parse(c.GameID), c.GameName);
        }

        public static string FindSteamGamePath(Config c, int appid, string gameName)
        {
            if (ReadRegistrySafe("Software\\Valve\\Steam", "SteamPath") == null)
            {
                return null;
            }

            string appsPath = Path.Combine((string)ReadRegistrySafe("Software\\Valve\\Steam", "SteamPath"), "steamapps");

            if (File.Exists(Path.Combine(appsPath, $"appmanifest_{appid}.acf")))
            {
                return Path.GetFullPath(Path.Combine(Path.Combine(appsPath, "common"), gameName));
            }

            string path = SearchAllInstallations(Path.Combine(appsPath, "libraryfolders.vdf"), appid, gameName);
            if (path == null)
            {
                SharedState.Logger.Log($"It appears you don't have {gameName} installed anywhere. The game files are needed to install the mods.");
            }
            else
            {
                return Path.GetFullPath(path);
            }

            return null;
        }

        private static string SearchAllInstallations(string libraryfolders, int appid, string gameName)
        {
            StreamReader file = new StreamReader(libraryfolders);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                line.Trim();
                line.Trim('\t');
                line = Regex.Unescape(line);
                Match regMatch = Regex.Match(line, "\"(.*)\"\t*\"(.*)\"");
                string key = regMatch.Groups[1].Value;
                string value = regMatch.Groups[2].Value;
                int number;
                if (int.TryParse(key, out number))
                {
                    if (File.Exists(Path.Combine(value, $"steamapps/appmanifest_{appid}.acf")))
                    {
                        return Path.Combine(Path.Combine(value, "steamapps/common"), gameName);
                    }
                }
            }

            return null;
        }

        private static object ReadRegistrySafe(string path, string key)
        {
            using (RegistryKey subkey = Registry.CurrentUser.OpenSubKey(path))
            {
                if (subkey != null)
                {
                    return subkey.GetValue(key);
                }
            }

            return null;
        }
    }
}
