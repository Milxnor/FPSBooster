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
        public static void ReadWriteFile(string path, string msg, char splitChar, string newValue, string type) //bool trailingZeros = true)// bool useLast = true)
        {
            var originalLines = File.ReadAllLines(path);

            var updatedLines = new List<string>();
            foreach (var line in originalLines)
            {
                string[] infos = line.Split(splitChar);
                if (infos[0] == msg)
                {
                    // update value
                    type = type.ToLower(); // me reading the code later: why did i do this? I could have just always made string?? Eh good practice for me, ill fix it one day.
                    if (type == "int") // System.FormatException if you put soemtyhing thats not a int.
                    {
                        infos[1] = int.Parse(newValue).ToString();
                    }
                    else if (type == "string" || type == "str")
                    {
                        infos[1] = newValue;
                    }
                    else if (type == "float")
                    {
                        infos[1] = float.Parse(newValue).ToString();
                        /*if (trailingZeros)
                        {
                            float f;
                            float.TryParse(newValue, NumberStyles.Any,
                            CultureInfo.InvariantCulture, out f);
                            Console.WriteLine(f.ToString(CultureInfo.InvariantCulture));
                        }
                        else infos[1] = float.Parse(newValue).ToString(); */
                    }
                    else if (type == "bool" || type == "boolean")
                    {
                        infos[1] = bool.Parse(newValue).ToString();
                    }
                    /*else if (type == "decimal" || type == "dec")
                    {
                        if (trailingZeros)
                        {
                            decimal d;
                            decimal.TryParse(newValue, NumberStyles.Any,
                            CultureInfo.InvariantCulture, out d);
                            Console.WriteLine(d.ToString(CultureInfo.InvariantCulture));
                        }
                        else decimal.Parse(newValue).ToString();
                    } */
                }

                updatedLines.Add(string.Join("=", infos));
            }

            File.WriteAllLines(path, updatedLines);
        }
    }
}
