using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace conanpatcher
{
    class Cygpath
    {
        private static readonly Regex reg = new Regex("^([A-Za-z]):(.*)",RegexOptions.Compiled);

        public static string Convert(string winPath)
        {
            String cygPath = winPath.Replace(@"\", "/");
            cygPath = reg.Replace(cygPath, "/cygdrive/$1/$2");
            cygPath = cygPath.Replace(@"//", @"/");
            return cygPath;
        }
    }
}
