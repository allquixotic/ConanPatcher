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
            if(DoModlistReplace(c))
            {
                SharedState.Logger.Log("modlist.txt process completed.");
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

        public static bool DoRsync(Config c)
        {
            try
            {
                try { File.Delete(Path.GetFullPath("rsync.log")); } catch (Exception) { }
                String cygPath = Cygpath.Convert(SharedState.PathInfo.ModFolder);
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
                var proc = Process.Start(psi);
                proc.WaitForExit();
            }
            catch(Exception e)
            {
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
