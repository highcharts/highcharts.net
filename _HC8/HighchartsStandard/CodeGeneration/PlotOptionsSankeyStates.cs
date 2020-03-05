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
	public partial class PlotOptionsSankeyStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSankeyStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsSankeyStatesHover();
			Inactive = Inactive_DefaultValue = new PlotOptionsSankeyStatesInactive();
			Normal = Normal_DefaultValue = new PlotOptionsSankeyStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsSankeyStatesSelect();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyStatesHover Hover { get; set; }
		private PlotOptionsSankeyStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for a single point node/link.
		/// </summary>
		public PlotOptionsSankeyStatesInactive Inactive { get; set; }
		private PlotOptionsSankeyStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public PlotOptionsSankeyStatesNormal Normal { get; set; }
		private PlotOptionsSankeyStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after beingselected by[allowPointSelect](#plotOptions.series.allowPointSelect)or programmatically.
		/// </summary>
		public PlotOptionsSankeyStatesSelect Select { get; set; }
		private PlotOptionsSankeyStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
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