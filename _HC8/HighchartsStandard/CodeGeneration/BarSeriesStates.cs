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
	public partial class BarSeriesStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public BarSeriesStates()
		{
			Hover = Hover_DefaultValue = new BarSeriesStatesHover();
			Inactive = Inactive_DefaultValue = new BarSeriesStatesInactive();
			Normal = Normal_DefaultValue = new BarSeriesStatesNormal();
			Select = Select_DefaultValue = new BarSeriesStatesSelect();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public BarSeriesStatesHover Hover { get; set; }
		private BarSeriesStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public BarSeriesStatesInactive Inactive { get; set; }
		private BarSeriesStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public BarSeriesStatesNormal Normal { get; set; }
		private BarSeriesStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public BarSeriesStatesSelect Select { get; set; }
		private BarSeriesStatesSelect Select_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty(ref highcharts)) h.Add("hover",Hover.ToHashtable(ref highcharts));
			if (Inactive.IsDirty(ref highcharts)) h.Add("inactive",Inactive.ToHashtable(ref highcharts));
			if (Normal.IsDirty(ref highcharts)) h.Add("normal",Normal.ToHashtable(ref highcharts));
			if (Select.IsDirty(ref highcharts)) h.Add("select",Select.ToHashtable(ref highcharts));
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