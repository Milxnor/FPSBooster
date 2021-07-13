using System;
using static FPSBooster.Utils.Reader;
using static FPSBooster.Utils.NetUtils;
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
        public static void InstallTimerRes() // idk i might just use islc but idk how to do it as this is simple, you can run with args and hide and max.
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
            ReadWriteFile(userSettings, "bMotionBlur", '=', "False", "bool");
            ReadWriteFile(userSettings, "bShowGrass", '=', "False", "bool");
            ReadWriteFile(userSettings, "sg.ViewDistanceQuality", '=', "0", "int");
            ReadWriteFile(userSettings, "sg.AntiAliasingQuality", '=', "0", "int");
            ReadWriteFile(userSettings, "sg.ShadowQuality", '=', "0", "int");
            ReadWriteFile(userSettings, "sg.PostProcessQuality", '=', "0", "int");
            ReadWriteFile(userSettings, "sg.TextureQuality", '=', "0", "int");
            ReadWriteFile(userSettings, "sg.EffectsQuality", '=', "0", "int");
            ReadWriteFile(userSettings, "sg.FoliageQuality", '=', "0", "int");
            ReadWriteFile(userSettings, "sg.ShadingQuality", '=', "0", "int");
            ReadWriteFile(userSettings, "sg.ResolutionQuality", '=', "100", "int");
            ReadWriteFile(userSettings, "MeshQuality", '=', "0", "int"); // low meshes
        }
        public static void ResetCache() // Rename/Delete FortniteGame.
        {

        }
        public static float getHz() // use this for "FrameRateLimit="
        {
            return 0;
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
        public static void OverclockInput() // https://github.com/LordOfMice/hidusbf
        {

        }
    }
    class NetworkFN
    {
        public static void InitNetworkFN()
        {
            InstallTCPOptimizer();
        }
        public static void InstallTCPOptimizer()
        {
            DownloadUtil("https://download2389.mediafire.com/sm5crq14y24g/5c0abmmr20j7mm0/TCPOptimizer.exe", cD);
        }
        public static void FindBestServer()
        {

        }
    }
    class OtherFN
    {
        public static void InitOtherFN()
        {
            string resChange = "";
            Console.Write("\nWould you like to change your resolution (Y/N): ");
            string resChangeAns = Console.ReadLine();
            if(resChangeAns == "Y")
            {
                Console.WriteLine("\nWhat would you like to change your resolution to?: ");
                resChange = Console.ReadLine();
            }
            if (resChange != "")
            {
                ChangeRes(resChange);
            }
            ClearTemp();
        }
        public static void ClearTemp() // pain i could have just used a easy bat file :/
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
        public static void ChangeRes(string res)
        {
            string resChangeHeight = res.Split('x').Last().ToString();
            string resChangeWidth = res.Split('x').ToString();
            ReadWriteFile(userSettings, "ResolutionSizeX", '=', resChangeWidth, "int");
            ReadWriteFile(userSettings, "ResolutionSizeY", '=', resChangeWidth, "int");
            ReadWriteFile(userSettings, "LastUserConfirmedResolutionSizeX", '=', resChangeWidth, "int");
            ReadWriteFile(userSettings, "LastUserConfirmedResolutionSizeY", '=', resChangeHeight, "int");
            ReadWriteFile(userSettings, "DesiredScreenWidth", '=', resChangeWidth, "int");
            ReadWriteFile(userSettings, "DesiredScreenHeight", '=', resChangeHeight, "int");
        }
        public static void InstallTimerRes()
        {

        }
    }
}
