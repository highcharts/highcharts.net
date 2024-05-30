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
	public partial class HeatmapSeriesMarkerStatesSelect  : BaseObject
	{
		Hashtable h = new Hashtable();

		public HeatmapSeriesMarkerStatesSelect()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The number of pixels to increase the height of thehovered point.
		/// </summary>
		public double? HeightPlus { get; set; }
		private double? HeightPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of pixels to increase the width of thehovered point.
		/// </summary>
		public double? WidthPlus { get; set; }
		private double? WidthPlus_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (HeightPlus != null) h.Add("heightPlus",HeightPlus);
			if (WidthPlus != null) h.Add("widthPlus",WidthPlus);
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