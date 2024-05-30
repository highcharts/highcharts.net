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
	public partial class SunburstSeriesLevelsColorVariation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SunburstSeriesLevelsColorVariation()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The key of a color variation. Currently supports `brightness` only.
		/// </summary>
		public string Key { get; set; }
		private string Key_DefaultValue { get; set; }
		 

		/// <summary>
		/// The ending value of a color variation. The last sibling will receivethis value.
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Key != null) h.Add("key",Key);
			if (To != null) h.Add("to",To);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}