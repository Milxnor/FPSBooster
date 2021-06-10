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
        public static string fnCode, windowCode = "1";
        public static string configCode = "2"; // I know what your saying, this is stupid and resourceful, i have to agree but it makes more sense for the reader
        public static string hardwareCode = "3";
        public static string otherCode = "4";
    }
}
