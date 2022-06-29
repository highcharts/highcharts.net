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
	public partial class PlotOptionsStreamgraphZone  : PlotOptionsSeries
	{
		Hashtable h = new Hashtable();

		public PlotOptionsStreamgraphZone()
		{
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "";
			DashStyle = DashStyle_DefaultValue = PlotOptionsStreamgraphZonesDashStyle.Null;
			FillColor = FillColor_DefaultValue = null;
			Value = Value_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Styled mode only. A custom class name for the zone.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the color of the series.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// A name for the dash style to use for the graph.
		/// </summary>
		public PlotOptionsStreamgraphZonesDashStyle DashStyle { get; set; }
		private PlotOptionsStreamgraphZonesDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the fill color for the series (in area type series)
		/// </summary>
		public Object FillColor { get; set; }
		private Object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value up to where the zone extends, if undefined the zonesstretches to the last value in the series.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
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

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}