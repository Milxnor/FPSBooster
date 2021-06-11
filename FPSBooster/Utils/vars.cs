using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSBooster.Utils
{
    class vars
    {
        public static string localAD = Environment.GetEnvironmentVariable("LocalAppData");
        public static string fnCode = "1";
        public static string valCode = "2";
        public static string csgoCode = "3";
        public static string bocwCode = "4";
        public static string windowCode = "1";
        public static string configCode = "2"; // I know what your saying, this is stupid and resourceful, i have to agree but it makes more sense for the reader
        public static string hardwareCode = "3";
        public static string networkCode = "4";
        public static string otherCode = "5";
        public static string asciiText = @"
 ________ ________  ________           ________  ________  ________  ________  _________  _______   ________     
|\  _____\\   __  \|\   ____\         |\   __  \|\   __  \|\   __  \|\   ____\|\___   ___\\  ___ \ |\   __  \    
\ \  \__/\ \  \|\  \ \  \___|_        \ \  \|\ /\ \  \|\  \ \  \|\  \ \  \___|\|___ \  \_\ \   __/|\ \  \ \  \   
 \ \   __\\ \   ____\ \_____  \        \ \   __  \ \  \\\  \ \  \\\  \ \_____  \   \ \  \ \ \  \_|/_\ \   _  _\  
  \ \  \_| \ \  \___|\|____|\  \        \ \  \|\  \ \  \\\  \ \  \\\  \|____|\  \   \ \  \ \ \  \_|\ \ \  \\  \  
   \ \__\   \ \__\     ____\_\  \        \ \_______\ \_______\ \_______\____\_\  \   \ \__\ \ \_______\ \__\\ _\ 
    \|__|    \|__|    |\_________\        \|_______|\|_______|\|_______|\_________\   \|__|  \|_______|\|__|\|__|
                      \|_________|                                     \|_________|
                ";
        public static float InstallVersion = 0.9f;
        public static bool IsNullOrEmpty<T>(T[] array) where T : class
        {
            if (array == null || array.Length == 0)
                return true;
            else
                return array.All(item => item == null);
        }
    }
}
