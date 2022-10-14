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
	public partial class ArcdiagramSeriesLevelsStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ArcdiagramSeriesLevelsStates()
		{
			Hover = Hover_DefaultValue = new ArcdiagramSeriesLevelsStatesHover();
			Inactive = Inactive_DefaultValue = new ArcdiagramSeriesLevelsStatesInactive();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public ArcdiagramSeriesLevelsStatesHover Hover { get; set; }
		private ArcdiagramSeriesLevelsStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for a single point node/link.
		/// </summary>
		public ArcdiagramSeriesLevelsStatesInactive Inactive { get; set; }
		private ArcdiagramSeriesLevelsStatesInactive Inactive_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty(highcharts)) h.Add("hover",Hover.ToHashtable(highcharts));
			if (Inactive.IsDirty(highcharts)) h.Add("inactive",Inactive.ToHashtable(highcharts));
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