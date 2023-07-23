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
	public partial class PlotOptionsOrganizationLink  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsOrganizationLink()
		{
			Color = Color_DefaultValue = "#666666";
			LineWidth = LineWidth_DefaultValue = 1;
			Radius = Radius_DefaultValue = 10;
			Type = Type_DefaultValue = PlotOptionsOrganizationLinkType.Default;
			
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
		/// Radius for the rounded corners of the links between nodes.Works for `default` link type.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// Type of the link shape.
		/// </summary>
		public PlotOptionsOrganizationLinkType Type { get; set; }
		private PlotOptionsOrganizationLinkType Type_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Color != Color_DefaultValue) h.Add("color",Color);
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