using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class Highstock
	{
        internal Hashtable functions = new Hashtable();

        internal void AddFunction(string eventName, string functionName)
        {
            functions[Guid.NewGuid()+"."+eventName] = functionName;
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