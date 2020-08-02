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
		public Hashtable Hover { get; set; }
		private Hashtable Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public Hashtable Inactive { get; set; }
		private Hashtable Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public Hashtable Normal { get; set; }
		private Hashtable Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after beingselected by[allowPointSelect](#plotOptions.series.allowPointSelect)or programmatically.
		/// </summary>
		public PlotOptionsMacdStatesSelect Select { get; set; }
		private PlotOptionsMacdStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Inactive.IsDirty()) h.Add("inactive",Inactive.ToHashtable());
			if (Normal.IsDirty()) h.Add("normal",Normal.ToHashtable());
			if (Select.IsDirty()) h.Add("select",Select.ToHashtable());
			

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