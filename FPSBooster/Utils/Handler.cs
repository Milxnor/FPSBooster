using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static FPSBooster.Utils.vars;

namespace FPSBooster.Utils
{
    class Handler
    {
        public static void Handle(string num = "", string num2 = "1")
        { 
            if (num2 == fnCode)
            {
                if (num == windowCode) WindowsFN.InitWindowsFN();
                else if (num == configCode) ConfigFN.ChangeUserSettings();
                else if (num == hardwareCode) HardwareFN.InitHardwareFN();
                else if (num == otherCode) OtherFN.InitOtherFN();
                else
                {
                    Console.WriteLine(@"
[1] Windows FPS Boost
[2] Config FPS Boost
[3] Hardware FPS Boost
[4] Network Optimization
[5] Other" + "\n");
                }
            }   
        }
        /*public static string GetInput(string msg) // TODO
        {

        } */
    }
}
