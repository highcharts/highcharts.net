using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Configuration;

namespace Highsoft.Web.Mvc.Charts
{
    internal static class LicenseVerifier
    {
        private static string KEY_NAME = "Highcharts";

        public static int Check()
        {
            string line = GetSerialFromFile();

            if (line == null)
                return -1; //trial

            if (IsSerialCorrect(DecodeSerial(line)))
                return 1; //unlimited

            return 0; //incorrect serial -> trial mode + warning message
        }

        static bool IsSerialCorrect(string serial)
        {
            if (serial.Length < 12)
                return false;

            if (serial.Substring(0, 3) != "Ver")
                return false;

            if (GetLicenseVersion(serial) != GetAssemblyVersion())
                return false;

            if (serial.Substring(4, 7) != "NetWrap")
                return false;

            return true;
        }


        static string GetAssemblyVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.Major.ToString();
        }

        static string GetLicenseVersion(string serial)
        {
            return serial.Substring(3, 1);
        }

        static string DecodeSerial(string text)
        {
            string decodedSerial;
            try
            {
                decodedSerial = Encoding.UTF8.GetString(Convert.FromBase64String(text));
            }
            catch(Exception)
            {
                decodedSerial = "";
            }

            return decodedSerial;
        }

        static string GetSerialFromFile()
        {
            string[] values = ConfigurationManager.AppSettings.GetValues(KEY_NAME);

            if (values == null)
                return null;

            if (values.Length == 0)
                return null;

            return values[0];
        }
    }
}
