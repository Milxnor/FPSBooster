using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static FPSBooster.Utils.vars;

namespace FPSBooster.Utils
{
    class Reader
    {
        public static void ReadFile(string path, string msg, char splitChar)
        {
            if (path == null) path = localAD;
            string line;
            using (StreamReader file = new StreamReader(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains(msg))
                    {
                        string splitted = line.Split(splitChar).Last();
                        Console.WriteLine(splitted);
                    }
                }
            }
        }
    }
}
