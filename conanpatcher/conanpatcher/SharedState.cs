using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace conanpatcher
{
    class SharedState
    {
        public static ISimpleLogger Logger { get; set; }
        public static GamePathInfo PathInfo { get; private set; }

        static SharedState()
        {
            PathInfo = new GamePathInfo();
        }
    }
}
