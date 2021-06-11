using System;
using System.Collections.Generic;
using System.Linq;
using static FPSBooster.Utils.vars;
using System.Net;

namespace FPSBooster.Utils
{
    class NetUtils
    {
        public static void DownloadUtil(string url, string path)
        {
            WebClient webClient = new WebClient();
            Uri URI = new Uri(url); // TODO: check if url is valid by pinging.
            webClient.DownloadFile(URI, path);
        }
        public static string readString(string url)
        {
            WebClient webClient = new WebClient();
            Uri URI = new Uri(url); // TODO: check if url is valid by pinging.
            string downloaded = webClient.DownloadString(URI);
            return downloaded;
        }
        public static float getVersion(string url)
        {
            float value;
            try
            {
                value = float.Parse(readString(url));
            }
            catch (FormatException e) // for ex. if the link is a char it would cause this exception.
            {
                value = 0;
                Console.WriteLine("Value cannot be converted to a float.");
            }
            return value;
        }
        public static float VersionCheck()
        {
            float onlineVer = getVersion("https://pastebin.com/raw/WvUahKF7");
            if (onlineVer == InstallVersion) return 0f;
            else return onlineVer;
        }
    }
}
