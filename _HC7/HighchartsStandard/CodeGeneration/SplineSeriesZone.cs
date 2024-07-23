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
	public partial class SplineSeriesZone  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SplineSeriesZone()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Styled mode only. A custom class name for the zone.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// Defines the color of the series.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// A name for the dash style to use for the graph.
		/// </summary>
		public SplineSeriesZonesDashStyle DashStyle { get; set; }
		 

		/// <summary>
		/// Defines the fill color for the series (in area type series)
		/// </summary>
		public Object FillColor { get; set; }
		 

		/// <summary>
		/// The value up to where the zone extends, if undefined the zonesstretches to the last value in the series.
		/// </summary>
		public double? Value { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ClassName != null) h.Add("className",ClassName);
			if (Color != null) h.Add("color",Color);
			if (DashStyle != SplineSeriesZonesDashStyle.Null) h.Add("dashStyle", highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (FillColor != null) h.Add("fillColor",FillColor);
			if (Value != null) h.Add("value",Value);
			if (CustomFields.Count > 0)
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