using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class Highcharts
	{
        internal static Hashtable functions = new Hashtable();
       
        internal static void AddFunction(string eventName, string functionName)
        {
            if (functions[eventName] == null)
                functions.Add(eventName, functionName);
        }

		/// <summary>
		/// The ID of the chart
		/// </summary>
		public string ID { get; set; }
	}
}