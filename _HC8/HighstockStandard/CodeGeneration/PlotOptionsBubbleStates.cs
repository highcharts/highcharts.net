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
	public partial class PlotOptionsBubbleStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsBubbleStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsBubbleStatesHover();
			Inactive = Inactive_DefaultValue = new PlotOptionsBubbleStatesInactive();
			Normal = Normal_DefaultValue = new PlotOptionsBubbleStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsBubbleStatesSelect();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleStatesHover Hover { get; set; }
		private PlotOptionsBubbleStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public PlotOptionsBubbleStatesInactive Inactive { get; set; }
		private PlotOptionsBubbleStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public PlotOptionsBubbleStatesNormal Normal { get; set; }
		private PlotOptionsBubbleStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after beingselected by[allowPointSelect](#plotOptions.series.allowPointSelect)or programmatically.
		/// </summary>
		public PlotOptionsBubbleStatesSelect Select { get; set; }
		private PlotOptionsBubbleStatesSelect Select_DefaultValue { get; set; }
		  

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