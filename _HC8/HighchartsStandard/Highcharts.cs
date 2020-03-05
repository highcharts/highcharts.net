using System.Collections;
using System;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Highcharts : BaseObject
	{
        internal static Hashtable functions = new Hashtable();

        internal static void AddFunction(string eventName, string functionName)
        {
            
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