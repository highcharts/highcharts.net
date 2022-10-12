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
	public partial class SunburstSeriesLevelsLevelSize  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SunburstSeriesLevelsLevelSize()
		{
			Unit = Unit_DefaultValue = SunburstSeriesLevelsLevelSizeUnit.Weight;
			Value = Value_DefaultValue = 1;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// How to interpret `levelSize.value`.- `percentage` gives a width relative to result of outer radius  minus inner radius.- `pixels` gives the ring a fixed width in pixels.- `weight` takes the remaining width after percentage and pixels,  and distributes it accross all "weighted" levels. The value  relative to the sum of all weights determines the width.
		/// </summary>
		public SunburstSeriesLevelsLevelSizeUnit Unit { get; set; }
		private SunburstSeriesLevelsLevelSizeUnit Unit_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value used for calculating the width of the ring. Its' affectis determined by `levelSize.unit`.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Unit != Unit_DefaultValue) h.Add("unit", highcharts.FirstCharacterToLower(Unit.ToString()));
			if (Value != Value_DefaultValue) h.Add("value",Value);
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