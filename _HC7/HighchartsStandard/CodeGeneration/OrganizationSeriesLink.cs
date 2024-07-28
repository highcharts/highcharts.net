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
		}	
		

		/// <summary>
		/// The color of the links between nodes.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// The line width of the links connecting nodes, in pixels.
		/// </summary>
		public double? LineWidth { get; set; }
		 

		/// <summary>
		/// Modifier of the shape of the curved link. Works best for valuesbetween 0 and 1, where 0 is a straight line, and 1 is a shapeclose to the default one.
		/// </summary>
		public double? Offset { get; set; }
		 

		/// <summary>
		/// Radius for the rounded corners of the links between nodes.Works for `default` link type.
		/// </summary>
		public double? Radius { get; set; }
		 

		/// <summary>
		/// Type of the link shape.
		/// </summary>
		public OrganizationSeriesLinkType Type { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Color != null) h.Add("color",Color);
			if (LineWidth != null) h.Add("lineWidth",LineWidth);
			if (Offset != null) h.Add("offset",Offset);
			if (Radius != null) h.Add("radius",Radius);
			if (Type != OrganizationSeriesLinkType.Null) h.Add("type", highcharts.FirstCharacterToLower(Type.ToString()));
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