using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
 ________ ________  ________           ________  ________  ________  ________  _________  _______   ________     
|\  _____\\   __  \|\   ____\         |\   __  \|\   __  \|\   __  \|\   ____\|\___   ___\\  ___ \ |\   __  \    
\ \  \__/\ \  \|\  \ \  \___|_        \ \  \|\ /\ \  \|\  \ \  \|\  \ \  \___|\|___ \  \_\ \   __/|\ \  \|\  \   
 \ \   __\\ \   ____\ \_____  \        \ \   __  \ \  \\\  \ \  \\\  \ \_____  \   \ \  \ \ \  \_|/_\ \   _  _\  
  \ \  \_| \ \  \___|\|____|\  \        \ \  \|\  \ \  \\\  \ \  \\\  \|____|\  \   \ \  \ \ \  \_|\ \ \  \\  \| 
   \ \__\   \ \__\     ____\_\  \        \ \_______\ \_______\ \_______\____\_\  \   \ \__\ \ \_______\ \__\\ _\ 
    \|__|    \|__|    |\_________\        \|_______|\|_______|\|_______|\_________\   \|__|  \|_______|\|__|\|__|
                      \|_________|                                     \|_________|
                ");
            Console.WriteLine(@"
[1] Windows FPS Boost
[2] Config FPS Boost
[3] Hardware FPS Boost
[4] Other" + "\n");
            Console.WriteLine("Please pick a number: ");
            string num = Console.ReadLine();
            if(num == "1") 
            Console.ReadLine();
        }
    }
}
