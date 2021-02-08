using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisBole
{
    public static partial class IOCConverter
    {
        public static readonly string CountryNameWildcard = "Any";
        public static string CountryNameToCode(string countryName)
        {
            if(NameToCode is null)
            {
                NameToCode = new Dictionary<string, string>();
                for (int i = 0; i < CountryNames.Length; i++)
                    NameToCode[CountryNames[i]] = NationalCodes[i];
            }
            return NameToCode[countryName];
        }

        public static string CodeToCountryName(string code)
        {
            if (CodeToName is null)
            {
                CodeToName = new Dictionary<string, string>();
                for (int i = 0; i < NationalCodes.Length; i++)
                    CodeToName[NationalCodes[i]] = CountryNames[i];
            }
            return CodeToName[code];
        }
    }
}
