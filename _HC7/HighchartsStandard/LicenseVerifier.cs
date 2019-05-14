using System;
using System.Text;
using System.Reflection;
using System.Configuration;


namespace Highsoft.Web.Mvc.Charts
{
    internal static class LicenseVerifier
    {
        private static string KEY_NAME = "Highcharts";

        public static SerialKey Check()
        {
            string line = GetSerialFromFile();

            if (string.IsNullOrWhiteSpace(line))
                return SerialKey.Missing;

            var serial = DecodeSerial(line);
            if (!IsSerialCorrect(serial))
                return SerialKey.Invalid;

            if (IsUnlimitedKeyValid(serial))
                return SerialKey.UnlimitedValid;

            return GetTrialStatus(serial);
        }

        /// <summary>
        /// serial format VVTYYYYMMDDOrderId, OrderId = 9 digits
        /// </summary>
        /// <param name="serial"></param>
        /// <returns></returns>
        static bool IsSerialCorrect(string serial)
        {
            if (string.IsNullOrWhiteSpace(serial))
                return false;

            if (serial.Length != 20)
                return false;

            if (GetLicenseVersion(serial) < GetAssemblyVersion())
                return false;

            if (!IsSerialLimited(serial) && !IsSerialUnlimited(serial))
                return false;

            if (!IsDateCorrect(serial))
                return false;

            int orderId;
            if (!int.TryParse(serial.Substring(11, 9), out orderId))
                return false;

            return true;
        }

        static bool IsDateCorrect(string serial)
        {
            try
            {
                var validDate = DateTime.ParseExact(serial.Substring(3, 8), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static SerialKey GetTrialStatus(string serial)
        {
            try
            {
                var validDate = DateTime.ParseExact(serial.Substring(3, 8), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                if (validDate <= DateTime.Today)
                    return SerialKey.TrialExpired;

                if ((validDate - DateTime.Today).TotalDays == 14)
                    return SerialKey.Trial14DaysBeforeEndValid;
            }
            catch (Exception)
            {
                return SerialKey.Invalid;
            }

            return SerialKey.TrialValid;
        }

        static bool IsUnlimitedKeyValid(string serial)
        {
            if (serial.Substring(2, 1) == "1" && serial.Substring(3, 8).Equals("99990101"))
                return true;

            return false;
        }

        static bool IsSerialUnlimited(string serial)
        {
            if (serial.Substring(2, 1) == "1")
                return true;

            return false;
        }

        static bool IsSerialLimited(string serial)
        {
            if (serial.Substring(2, 1) == "0")
                return true;

            return false;
        }

        static int GetAssemblyVersion()
        {
            return Convert.ToInt32(Assembly.GetExecutingAssembly().GetName().Version.Major.ToString());
        }

        static int GetLicenseVersion(string serial)
        {
            int result;
            bool success = int.TryParse(serial.Substring(0, 2), out result);

            if (success)
                return result;

            return -1;
        }

        static string DecodeSerial(string text)
        {
            string decodedSerial;
            try
            {
                decodedSerial = Encoding.UTF8.GetString(Convert.FromBase64String(text));
            }
            catch (Exception)
            {
                decodedSerial = string.Empty;
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
