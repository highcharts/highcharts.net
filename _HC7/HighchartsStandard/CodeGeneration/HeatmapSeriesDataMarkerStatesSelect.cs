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
	public partial class HeatmapSeriesDataMarkerStatesSelect  : BaseObject
	{
		Hashtable h = new Hashtable();

		public HeatmapSeriesDataMarkerStatesSelect()
		{
		}	
		

		/// <summary>
		/// Set the marker's fixed height on select state.
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// The number of pixels to increase the height of thehovered point.
		/// </summary>
		public double? HeightPlus { get; set; }
		 

		/// <summary>
		/// Set the marker's fixed width on select state.
		/// </summary>
		public double? Width { get; set; }
		 

		/// <summary>
		/// The number of pixels to increase the width of thehovered point.
		/// </summary>
		public double? WidthPlus { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Height != null) h.Add("height",Height);
			if (HeightPlus != null) h.Add("heightPlus",HeightPlus);
			if (Width != null) h.Add("width",Width);
			if (WidthPlus != null) h.Add("widthPlus",WidthPlus);
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