using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace conanpatcher
{
    static class Program
    {
        private static Config _c = null;
        public static Config c
        {
            set
            {
                _c = value;
                if(!(String.IsNullOrWhiteSpace(_c.GameName) || String.IsNullOrWhiteSpace(_c.GameID)))
                {
                    SharedState.PathInfo.SetAllBasedOnGameFolder(SteamHelper.FindOurGamePath(c), _c.GameID);
                }
                
            }

            get
            {
                return _c;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            c = new Config();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mf = new MainForm();
            SharedState.Logger = mf;
            Application.Run(mf);
        }
    }
}
