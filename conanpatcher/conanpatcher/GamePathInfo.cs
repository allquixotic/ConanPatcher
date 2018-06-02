using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace conanpatcher
{
    public class GamePathInfo
    {
        public string GameFolder { get; private set; }
        public string ModFolder { get; private set; }
        public string SteamappsFolder { get; private set; }

        public void SetAllBasedOnGameFolder(string gameFolder, string gameId)
        {
            GameFolder = Path.GetFullPath(gameFolder);
            if(String.IsNullOrWhiteSpace(GameFolder))
            {
                ModFolder = null;
                SteamappsFolder = null;
            }
            else
            {
                ModFolder = Path.GetFullPath(Path.Combine(gameFolder, "..", "..", "workshop", "content", gameId));
                SteamappsFolder = Path.GetFullPath(Path.Combine(gameFolder, "..", ".."));
            }
        }
    }
}
