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
	public partial class SunburstSeriesLevelSize  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SunburstSeriesLevelSize()
		{
		}	
		

		/// <summary>
		/// How to interpret `levelSize.value`.- `percentage` gives a width relative to result of outer radius  minus inner radius.- `pixels` gives the ring a fixed width in pixels.- `weight` takes the remaining width after percentage and pixels,  and distributes it across all "weighted" levels. The value  relative to the sum of all weights determines the width.
		/// </summary>
		public SunburstSeriesLevelSizeUnit Unit { get; set; }
		 

		/// <summary>
		/// The value used for calculating the width of the ring. Its' affectis determined by `levelSize.unit`.
		/// </summary>
		public double? Value { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Unit != SunburstSeriesLevelSizeUnit.Null) h.Add("unit", highcharts.FirstCharacterToLower(Unit.ToString()));
			if (Value != null) h.Add("value",Value);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}