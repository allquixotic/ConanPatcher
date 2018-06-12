using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace conanpatcher
{
    class Doer
    {
        public static void Do(Config c)
        {
            if(DoRsync(c))
            {
                SharedState.Logger.Log("Rsync process completed.");
            }
            else
            {
                SharedState.Logger.Log("Rsync process exited with an error.");
            }
            if(DoModlistReplace(c))
            {
                SharedState.Logger.Log("modlist.txt process completed.");
            }
            else
            {
                SharedState.Logger.Log("modlist.txt process exited with an error.");
            }
            if(File.Exists(Path.GetFullPath("rsync.log")))
            {
                SharedState.Logger.Log("rsync.log:\r\n" + File.ReadAllText(Path.GetFullPath("rsync.log")));
            }
            else
            {
                SharedState.Logger.Log("Did not find an rsync.log file to display here; displaying this message instead.");
            }
        }

        //Determine if user already has any mods from modlist.txt from Steam Workshop
        private static void CopyUsefulSteamWorkshopMods(Config c)
        {
            //Parse out the file names from modlist.txt (to lowercase)
            string modlistTxt = WebHelper.GetDocumentContents(WebRequest.Create(c.ModlistUrl));
            List<string> modFileNames = modlistTxt.Split(null).ToList();

            {
                List<string> two = new List<string>();
                foreach (string s in modFileNames)
                {
                    two.Add(Path.GetFileName(s.Replace("/", @"\")).ToLower());
                }
                modFileNames = two;
            }

            //Gather all file names from workshop dir (to lowercase)
            Dictionary<string, string> workshopPakFiles = new Dictionary<string, string>();
            IEnumerable<string> workshopMods, gameFolderMods;
            string gameFolderModDir = Path.Combine(SharedState.PathInfo.GameFolder, "ConanSandbox", "Mods");

            if (Directory.Exists(SharedState.PathInfo.WorkshopModFolder))
            {
                workshopMods = Directory.EnumerateFiles(SharedState.PathInfo.WorkshopModFolder, "*.pak", SearchOption.AllDirectories);
            }
            else
            {
                workshopMods = new List<string>();
            }

            if(Directory.Exists(gameFolderModDir))
            {
                gameFolderMods = Directory.EnumerateFiles(gameFolderModDir, "*.pak", SearchOption.AllDirectories);
            }
            else
            {
                gameFolderMods = new List<string>();
            }

            foreach(string file in workshopMods.Union(gameFolderMods))
            {
                string key = Path.GetFileName(file).ToLower();
                if (!workshopPakFiles.ContainsKey(key))
                {
                    workshopPakFiles.Add(key, file);
                }
            }

            //For each file that does not exist in target ModPath, copy it over
            foreach(string modFile in modFileNames)
            {
                if(!File.Exists(Path.GetFullPath(Path.Combine(c.GetAbsoluteModPath(), modFile))) 
                    && workshopPakFiles.ContainsKey(modFile))
                {
                    try
                    {
                        string src = workshopPakFiles[modFile];
                        string dest = Path.Combine(c.GetAbsoluteModPath(), Path.GetFileName(src));
                        File.Copy(src, dest, false);
                        SharedState.Logger.Log("Copied " + src + " to " + dest);
                    } catch (Exception) { }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
                }
            }
        }

        public static bool DoRsync(Config c)
        {
            try
            {
                try { Directory.CreateDirectory(c.GetAbsoluteModPath()); } catch (Exception) { }
                try { File.Delete(Path.GetFullPath("rsync.log")); } catch (Exception) { }
                String cygPath = Cygpath.Convert(c.GetAbsoluteModPath());
                var cwd = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                var psi = new ProcessStartInfo();
                string args = c.RsyncArgs + " " + c.RsyncUrl + " \"" + cygPath + "\"";
                psi.FileName = @"rsync.exe";
                psi.WorkingDirectory = cwd;
                SharedState.Logger.Log("(DEBUG INFO) \n\trsync command: " + psi.FileName + "\n\trsync arguments: " + args);
                psi.Arguments = args;
                psi.CreateNoWindow = false;
                psi.UseShellExecute = false;
                psi.ErrorDialog = true;
                psi.WindowStyle = ProcessWindowStyle.Normal;

                CopyUsefulSteamWorkshopMods(c);

                var proc = Process.Start(psi);
                proc.WaitForExit();
            }
            catch(Exception e)
            {
                SharedState.Logger.Log(e.Message);
                SharedState.Logger.Log(e.StackTrace);
                return false;
            }

            return true;
        }

        public static bool DoModlistReplace(Config c)
        {
            if (!String.IsNullOrWhiteSpace(c.ModlistUrl))
            {
                try
                {
                    try { Directory.CreateDirectory(Path.Combine(SharedState.PathInfo.GameFolder, "ConanSandbox", "Mods")); } catch (Exception) { }
                    string modlistPath = Path.GetFullPath(Path.Combine(SharedState.PathInfo.GameFolder, "ConanSandbox", "Mods", "modlist.txt"));
                    File.WriteAllText(modlistPath, WebHelper.GetDocumentContents(WebRequest.Create(c.ModlistUrl)));
                }
                catch(Exception e)
                {
                    SharedState.Logger.Log("Modlist Replace didn't work!");
                    SharedState.Logger.Log(e.Message + "\r\n" + e.StackTrace);
                    return false;
                }
                return true;
            }
            else return true;
        }
    }
}
