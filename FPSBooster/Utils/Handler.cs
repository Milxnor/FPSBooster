using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static FPSBooster.Utils.vars;

namespace FPSBooster.Utils
{
    class Handler
    {
        public static void Handle(string num, string num2)
        { 
            if (num2 == fnCode)
            {
                if (num == windowCode) WindowsFN.InitWindowsFN();
                else if (num == configCode) ConfigFN.ChangeUserSettings();
            }
        }
    }
}
