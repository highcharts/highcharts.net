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
	public partial class PlotOptionsSlowstochasticStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSlowstochasticStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsSlowstochasticStatesHover();
			Inactive = Inactive_DefaultValue = new PlotOptionsSlowstochasticStatesInactive();
			Normal = Normal_DefaultValue = new PlotOptionsSlowstochasticStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsSlowstochasticStatesSelect();
			
		}	
		

		/// <summary>
		/// Options for the hovered series. These settings override thenormal state options when a series is moused over or touched.
		/// </summary>
		public PlotOptionsSlowstochasticStatesHover Hover { get; set; }
		private PlotOptionsSlowstochasticStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public PlotOptionsSlowstochasticStatesInactive Inactive { get; set; }
		private PlotOptionsSlowstochasticStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public PlotOptionsSlowstochasticStatesNormal Normal { get; set; }
		private PlotOptionsSlowstochasticStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after beingselected by[allowPointSelect](#plotOptions.series.allowPointSelect)or programmatically.
		/// </summary>
		public PlotOptionsSlowstochasticStatesSelect Select { get; set; }
		private PlotOptionsSlowstochasticStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty(highstock)) h.Add("hover",Hover.ToHashtable(highstock));
			if (Inactive.IsDirty(highstock)) h.Add("inactive",Inactive.ToHashtable(highstock));
			if (Normal.IsDirty(highstock)) h.Add("normal",Normal.ToHashtable(highstock));
			if (Select.IsDirty(highstock)) h.Add("select",Select.ToHashtable(highstock));
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}