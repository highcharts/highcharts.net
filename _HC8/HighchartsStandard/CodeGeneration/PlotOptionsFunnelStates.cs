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
	public partial class PlotOptionsFunnelStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsFunnelStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsFunnelStatesHover();
			Inactive = Inactive_DefaultValue = new PlotOptionsFunnelStatesInactive();
			Normal = Normal_DefaultValue = new PlotOptionsFunnelStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsFunnelStatesSelect();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsFunnelStatesHover Hover { get; set; }
		private PlotOptionsFunnelStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public PlotOptionsFunnelStatesInactive Inactive { get; set; }
		private PlotOptionsFunnelStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public PlotOptionsFunnelStatesNormal Normal { get; set; }
		private PlotOptionsFunnelStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for a selected funnel item.
		/// </summary>
		public PlotOptionsFunnelStatesSelect Select { get; set; }
		private PlotOptionsFunnelStatesSelect Select_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Inactive.IsDirty()) h.Add("inactive",Inactive.ToHashtable());
			if (Normal.IsDirty()) h.Add("normal",Normal.ToHashtable());
			if (Select.IsDirty()) h.Add("select",Select.ToHashtable());
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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