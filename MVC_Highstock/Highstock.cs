using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highstock.Web.Mvc
{
	public partial class Highstock
	{
        internal static Hashtable functions = new Hashtable();

        internal static void AddFunction(string eventName, string functionName)
        {
            //if (functions[eventName] == null)
            functions[eventName] = functionName;
        }

        public static string FirstCharacterToLower(string str)
        {
            if (String.IsNullOrEmpty(str) || Char.IsLower(str, 0))
                return str;

            return Char.ToLowerInvariant(str[0]) + str.Substring(1);
        }

		/// <summary>
		/// The ID of the chart
		/// </summary>
		public string ID { get; set; }
	}
}