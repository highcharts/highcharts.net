using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class TreegraphSeriesLevelsColorVariation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public TreegraphSeriesLevelsColorVariation()
		{
		}	
		

		/// <summary>
		/// The key of a color variation. Currently supports `brightness` only.
		/// </summary>
		public string Key { get; set; }
		 

		/// <summary>
		/// The ending value of a color variation. The last sibling will receivethis value.
		/// </summary>
		public double? To { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Key != null) h.Add("key",Key);
			if (To != null) h.Add("to",To);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}