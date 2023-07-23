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
	public partial class ColumnSeriesStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColumnSeriesStates()
		{
			Hover = Hover_DefaultValue = new ColumnSeriesStatesHover();
			Inactive = Inactive_DefaultValue = new ColumnSeriesStatesInactive();
			Normal = Normal_DefaultValue = new ColumnSeriesStatesNormal();
			Select = Select_DefaultValue = new ColumnSeriesStatesSelect();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public ColumnSeriesStatesHover Hover { get; set; }
		private ColumnSeriesStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public ColumnSeriesStatesInactive Inactive { get; set; }
		private ColumnSeriesStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public ColumnSeriesStatesNormal Normal { get; set; }
		private ColumnSeriesStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColumnSeriesStatesSelect Select { get; set; }
		private ColumnSeriesStatesSelect Select_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty(highcharts)) h.Add("hover",Hover.ToHashtable(highcharts));
			if (Inactive.IsDirty(highcharts)) h.Add("inactive",Inactive.ToHashtable(highcharts));
			if (Normal.IsDirty(highcharts)) h.Add("normal",Normal.ToHashtable(highcharts));
			if (Select.IsDirty(highcharts)) h.Add("select",Select.ToHashtable(highcharts));
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