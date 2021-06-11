using System;
using System.Collections.Generic;
using static FPSBooster.Utils.Logs;
using static FPSBooster.Utils.vars;
using System.IO;
using System.Linq;

namespace FPSBooster.Utils
{
    /*
    [1] Windows FPS Boost
    [2] Config FPS Boost
    [3] Hardware FPS Boost
    [4] Other
    */
    class FortniteBoost
    {
    }
    class WindowsFN
    { 
        public static void InitWindowsFN()
        {
            ClearCache();
        }
        public static void ClearCache()
        {

        }
    }
    class ConfigFN
    {
        public static void InitConfigFN()
        {
            ChangeUserSettings();
        }
        public static void ChangeUserSettings()
        {

        }
    }
    class HardwareFN
    {
        public static void InitHardwareFN()
        {
            InstallDrivers();
        }
        public static void InstallDrivers()
        {
            
        }
    }
    class OtherFN
    {
        public static void InitOtherFN()
        {
            ClearTemp();
        }
        public static void ClearTemp()
        {
            //DirectoryInfo tempDI = new DirectoryInfo(Path.GetTempPath());
            string[] fileArr = Directory.GetFiles(Path.GetTempPath());
            string[] dirArr = Directory.GetDirectories(Path.GetTempPath());
            foreach (string filePath in fileArr)
            {
                try
                {
                    File.Delete(filePath);
                    Log("[LOG] Deleted " + filePath, "");
                }
                catch//(IOException e)
                {
                    fileArr.Where(val => val != filePath).ToArray();
                }
            }
            foreach (string dirPath in dirArr)
            {
                string[] dirFiles = Directory.GetFiles(dirPath);
                foreach (string filePath in dirFiles)
                {
                    try
                    {
                        File.Delete(filePath);
                        Log("[LOG] Deleted " + filePath, "");
                    }
                    catch// (IOException e)
                    {
                        dirFiles.Where(val => val != filePath).ToArray();
                    }
                }
                try
                {
                    Directory.Delete(dirPath);
                    Log("[LOG] Deleted " + dirPath, "");
                }
                catch// (IOException e)
                {
                    dirArr.Where(val => val != dirPath).ToArray();
                }
            }
            Console.WriteLine("Completed!");
        }
    }
}
