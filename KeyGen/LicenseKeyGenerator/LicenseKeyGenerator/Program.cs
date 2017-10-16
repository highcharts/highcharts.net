using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseKeyGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "Ver6NetWrap8686308";
            byte[] bytes = Encoding.UTF8.GetBytes(key);
            string base64 = Convert.ToBase64String(bytes);

            Console.WriteLine(base64);
            Console.ReadLine();
        }
    }
}
