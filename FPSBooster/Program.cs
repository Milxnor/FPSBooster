using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static FPSBooster.Utils.vars;

namespace FPSBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(asciiText);
            Console.Write("\nYou are running on v" + InstallVersion);
            if (Utils.NetUtils.VersionCheck() != 0) Console.Write($@", there is a new update availible (v{Utils.NetUtils.VersionCheck()})" + "\n");
            Console.WriteLine($@"
[1] Fortnite
[2] Valorant (coming soon)
[3] CSGO (coming soon)
[4] Black Ops Cold War (coming soon)
[5] Youtuber Prefrences (coming soon)
");
            Console.Write("Please pick a number: ");
            string inputGame = Console.ReadLine();
            Utils.Handler.Handle("bruh", inputGame);
            Console.Write("Please pick a number: ");
            string inputOption = Console.ReadLine();
            Utils.Handler.Handle(inputOption, inputGame);
            Console.ReadLine();
        }
    }
}
