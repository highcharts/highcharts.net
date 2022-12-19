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
	public partial class ColorAxisDateTimeLabelFormatsSecond  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColorAxisDateTimeLabelFormatsSecond()
		{
			Main = Main_DefaultValue = "%H:%M:%S";
			Range = Range_DefaultValue = false;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Main { get; set; }
		private string Main_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Range { get; set; }
		private bool? Range_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Main != Main_DefaultValue) h.Add("main",Main);
			if (Range != Range_DefaultValue) h.Add("range",Range);
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