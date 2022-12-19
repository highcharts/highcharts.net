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
	public partial class OrganizationSeriesLink  : BaseObject
	{
		Hashtable h = new Hashtable();

		public OrganizationSeriesLink()
		{
			Color = Color_DefaultValue = "#666666";
			LineWidth = LineWidth_DefaultValue = 1;
			Offset = Offset_DefaultValue = null;
			Radius = Radius_DefaultValue = 10;
			Type = Type_DefaultValue =  default ;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The color of the links between nodes.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line width of the links connecting nodes, in pixels.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Modifier of the shape of the curved link. Works best for valuesbetween 0 and 1, where 0 is a straight line, and 1 is a shapeclose to the default one.
		/// </summary>
		public double? Offset { get; set; }
		private double? Offset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Radius for the rounded corners of the links between nodes.Works for `default` link type.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// Type of the link shape.
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (Type != Type_DefaultValue) h.Add("type",Type);
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