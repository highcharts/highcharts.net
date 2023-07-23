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
	public partial class TreegraphSeriesLink  : BaseObject
	{
		Hashtable h = new Hashtable();

		public TreegraphSeriesLink()
		{
			Color = Color_DefaultValue = "#666666";
			Cursor = Cursor_DefaultValue = "default";
			CurveFactor = CurveFactor_DefaultValue = null;
			LineWidth = LineWidth_DefaultValue = 1;
			Radius = Radius_DefaultValue = 10;
			Type = Type_DefaultValue = TreegraphSeriesLinkType.Curved;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The color of the links between nodes.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Cursor { get; set; }
		private string Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Modifier of the shape of the curved link. Works best forvalues between 0 and 1, where 0 is a straight line, and 1 isa shape close to the default one.
		/// </summary>
		public double? CurveFactor { get; set; }
		private double? CurveFactor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line width of the links connecting nodes, in pixels.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Radius for the rounded corners of the links between nodes.Works for `default` link type.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// Type of the link shape.
		/// </summary>
		public TreegraphSeriesLinkType Type { get; set; }
		private TreegraphSeriesLinkType Type_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (CurveFactor != CurveFactor_DefaultValue) h.Add("curveFactor",CurveFactor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (Type != Type_DefaultValue) h.Add("type", highcharts.FirstCharacterToLower(Type.ToString()));
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