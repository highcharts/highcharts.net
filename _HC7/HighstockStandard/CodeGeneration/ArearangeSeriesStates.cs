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
	public partial class ArearangeSeriesStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ArearangeSeriesStates()
		{
			Hover = Hover_DefaultValue = new ArearangeSeriesStatesHover();
			Inactive = Inactive_DefaultValue = new ArearangeSeriesStatesInactive();
			Normal = Normal_DefaultValue = new ArearangeSeriesStatesNormal();
			Select = Select_DefaultValue = new ArearangeSeriesStatesSelect();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Options for the hovered series. These settings override thenormal state options when a series is moused over or touched.
		/// </summary>
		public ArearangeSeriesStatesHover Hover { get; set; }
		private ArearangeSeriesStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public ArearangeSeriesStatesInactive Inactive { get; set; }
		private ArearangeSeriesStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public ArearangeSeriesStatesNormal Normal { get; set; }
		private ArearangeSeriesStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after beingselected by[allowPointSelect](#plotOptions.series.allowPointSelect)or programmatically.
		/// </summary>
		public ArearangeSeriesStatesSelect Select { get; set; }
		private ArearangeSeriesStatesSelect Select_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty(highstock)) h.Add("hover",Hover.ToHashtable(highstock));
			if (Inactive.IsDirty(highstock)) h.Add("inactive",Inactive.ToHashtable(highstock));
			if (Normal.IsDirty(highstock)) h.Add("normal",Normal.ToHashtable(highstock));
			if (Select.IsDirty(highstock)) h.Add("select",Select.ToHashtable(highstock));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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