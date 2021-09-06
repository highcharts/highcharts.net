using Newtonsoft.Json;
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
	public partial class PlotOptionsMacdStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsMacdStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsMacdStatesHover();
			Inactive = Inactive_DefaultValue = new PlotOptionsMacdStatesInactive();
			Normal = Normal_DefaultValue = new PlotOptionsMacdStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsMacdStatesSelect();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsMacdStatesHover Hover { get; set; }
		private PlotOptionsMacdStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public PlotOptionsMacdStatesInactive Inactive { get; set; }
		private PlotOptionsMacdStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public PlotOptionsMacdStatesNormal Normal { get; set; }
		private PlotOptionsMacdStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after beingselected by[allowPointSelect](#plotOptions.series.allowPointSelect)or programmatically.
		/// </summary>
		public PlotOptionsMacdStatesSelect Select { get; set; }
		private PlotOptionsMacdStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty(ref highstock)) h.Add("hover",Hover.ToHashtable(ref highstock));
			if (Inactive.IsDirty(ref highstock)) h.Add("inactive",Inactive.ToHashtable(ref highstock));
			if (Normal.IsDirty(ref highstock)) h.Add("normal",Normal.ToHashtable(ref highstock));
			if (Select.IsDirty(ref highstock)) h.Add("select",Select.ToHashtable(ref highstock));
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}