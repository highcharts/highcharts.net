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
	public partial class PlotOptionsDependencywheelStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsDependencywheelStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsDependencywheelStatesHover();
			Inactive = Inactive_DefaultValue = new PlotOptionsDependencywheelStatesInactive();
			Normal = Normal_DefaultValue = new PlotOptionsDependencywheelStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsDependencywheelStatesSelect();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Options for the hovered series. These settings override thenormal state options when a series is moused over or touched.
		/// </summary>
		public PlotOptionsDependencywheelStatesHover Hover { get; set; }
		private PlotOptionsDependencywheelStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public PlotOptionsDependencywheelStatesInactive Inactive { get; set; }
		private PlotOptionsDependencywheelStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public PlotOptionsDependencywheelStatesNormal Normal { get; set; }
		private PlotOptionsDependencywheelStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after beingselected by[allowPointSelect](#plotOptions.series.allowPointSelect)or programmatically.
		/// </summary>
		public PlotOptionsDependencywheelStatesSelect Select { get; set; }
		private PlotOptionsDependencywheelStatesSelect Select_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
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