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
	public partial class PlotOptionsTreemapStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTreemapStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsTreemapStatesHover();
			Inactive = Inactive_DefaultValue = new PlotOptionsTreemapStatesInactive();
			Normal = Normal_DefaultValue = new PlotOptionsTreemapStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsTreemapStatesSelect();
			
		}	
		

		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public PlotOptionsTreemapStatesHover Hover { get; set; }
		private PlotOptionsTreemapStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public PlotOptionsTreemapStatesInactive Inactive { get; set; }
		private PlotOptionsTreemapStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public PlotOptionsTreemapStatesNormal Normal { get; set; }
		private PlotOptionsTreemapStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after beingselected by[allowPointSelect](#plotOptions.series.allowPointSelect)or programmatically.
		/// </summary>
		public PlotOptionsTreemapStatesSelect Select { get; set; }
		private PlotOptionsTreemapStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Hover != Hover_DefaultValue) h.Add("hover",Hover);
			if (Inactive.IsDirty()) h.Add("inactive",Inactive.ToHashtable());
			if (Normal.IsDirty()) h.Add("normal",Normal.ToHashtable());
			if (Select != Select_DefaultValue) h.Add("select",Select);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}