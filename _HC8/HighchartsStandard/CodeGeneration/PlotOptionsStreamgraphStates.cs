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
	public partial class PlotOptionsStreamgraphStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsStreamgraphStates()
		{
			Hover = Hover_DefaultValue = new Hashtable();
			Inactive = Inactive_DefaultValue = new Hashtable();
			Normal = Normal_DefaultValue = new Hashtable();
			Select = Select_DefaultValue = new PlotOptionsStreamgraphStatesSelect();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Options for the hovered series. These settings override thenormal state options when a series is moused over or touched.
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
		public PlotOptionsStreamgraphStatesSelect Select { get; set; }
		private PlotOptionsStreamgraphStatesSelect Select_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Hover != Hover_DefaultValue) h.Add("hover",Hover);
			if (Inactive != Inactive_DefaultValue) h.Add("inactive",Inactive);
			if (Normal != Normal_DefaultValue) h.Add("normal",Normal);
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