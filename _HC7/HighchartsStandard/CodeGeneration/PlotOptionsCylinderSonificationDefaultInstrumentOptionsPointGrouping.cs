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
	public partial class PlotOptionsCylinderSonificationDefaultInstrumentOptionsPointGrouping  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsCylinderSonificationDefaultInstrumentOptionsPointGrouping()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The grouping algorithm, deciding which points to keep whengrouping a set of points together. By default `"minmax"` isused, which keeps both the minimum and maximum points.The other algorithms will either keep the first point in thegroup (time wise), last point, middle point, or both the firstand the last point.The timing of the resulting point(s) is then adjusted to playevenly, regardless of its original position within the group.
		/// </summary>
		public PlotOptionsCylinderSonificationDefaultInstrumentOptionsPointGroupingAlgorithm Algorithm { get; set; }
		private PlotOptionsCylinderSonificationDefaultInstrumentOptionsPointGroupingAlgorithm Algorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether or not to group points
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The size of each group in milliseconds. Audio events closer thanthis are grouped together.
		/// </summary>
		public double? GroupTimespan { get; set; }
		private double? GroupTimespan_DefaultValue { get; set; }
		 

		/// <summary>
		/// The data property for each point to compare when deciding whichpoints to keep in the group.By default it is "y", which means that if the `"minmax"`algorithm is used, the two points the group with the lowest andhighest `y` value will be kept, and the others not played.
		/// </summary>
		public string Prop { get; set; }
		private string Prop_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Algorithm != PlotOptionsCylinderSonificationDefaultInstrumentOptionsPointGroupingAlgorithm.Null) h.Add("algorithm", highcharts.FirstCharacterToLower(Algorithm.ToString()));
			if (Enabled != null) h.Add("enabled",Enabled);
			if (GroupTimespan != null) h.Add("groupTimespan",GroupTimespan);
			if (Prop != null) h.Add("prop",Prop);
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