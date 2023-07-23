using System.Collections;
using System;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Highcharts
	{
        internal Hashtable functions = new Hashtable();

        internal void AddFunction(string eventName, string functionName)
        {
            functions[Guid.NewGuid() + "." + eventName] = functionName;
        }

        public string FirstCharacterToLower(string str)
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