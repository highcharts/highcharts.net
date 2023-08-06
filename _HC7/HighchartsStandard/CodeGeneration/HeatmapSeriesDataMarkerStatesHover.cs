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
	public partial class HeatmapSeriesDataMarkerStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public HeatmapSeriesDataMarkerStatesHover()
		{
			Height = Height_DefaultValue = null;
			HeightPlus = HeightPlus_DefaultValue = null;
			LineWidthPlus = LineWidthPlus_DefaultValue = 0;
			Width = Width_DefaultValue = null;
			WidthPlus = WidthPlus_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Set the marker's fixed height on hover state.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of pixels to increase the height of thehovered point.
		/// </summary>
		public double? HeightPlus { get; set; }
		private double? HeightPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the marker's fixed width on hover state.
		/// </summary>
		public double? LineWidthPlus { get; set; }
		private double? LineWidthPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the marker's fixed width on hover state.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

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

			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (HeightPlus != HeightPlus_DefaultValue) h.Add("heightPlus",HeightPlus);
			if (LineWidthPlus != LineWidthPlus_DefaultValue) h.Add("lineWidthPlus",LineWidthPlus);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (WidthPlus != WidthPlus_DefaultValue) h.Add("widthPlus",WidthPlus);
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