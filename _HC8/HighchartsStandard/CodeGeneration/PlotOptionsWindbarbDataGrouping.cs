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
	public partial class PlotOptionsWindbarbDataGrouping  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsWindbarbDataGrouping()
		{
			Approximation = Approximation_DefaultValue = "windbarb";
			Enabled = Enabled_DefaultValue = true;
			GroupPixelWidth = GroupPixelWidth_DefaultValue = 30;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Approximation function for the data grouping. The defaultreturns an average of wind speed and a vector average directionweighted by wind speed.
		/// </summary>
		public string Approximation { get; set; }
		private string Approximation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to enable data grouping.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The approximate data group width.
		/// </summary>
		public double? GroupPixelWidth { get; set; }
		private double? GroupPixelWidth_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Approximation != Approximation_DefaultValue) h.Add("approximation",Approximation);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (GroupPixelWidth != GroupPixelWidth_DefaultValue) h.Add("groupPixelWidth",GroupPixelWidth);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}