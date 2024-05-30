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
	public partial class PlotOptionsGaugeDial  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsGaugeDial()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The background or fill color of the gauge's dial.
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the dial's base part, relative to the totalradius or length of the dial.
		/// </summary>
		public string BaseLength { get; set; }
		private string BaseLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the base of the gauge dial. The base isthe part closest to the pivot, defined by baseLength.
		/// </summary>
		public double? BaseWidth { get; set; }
		private double? BaseWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color or stroke of the gauge's dial. By default,the borderWidth is 0, so this must be set in addition to acustom border color.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the gauge dial border in pixels.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array with an SVG path for the custom dial.
		/// </summary>
		public string Path { get; set; }
		private string Path_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius or length of the dial, in percentages relative tothe radius of the gauge itself.
		/// </summary>
		public string Radius { get; set; }
		private string Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the dial's rear end, the part that extends outon the other side of the pivot. Relative to the dial'slength.
		/// </summary>
		public string RearLength { get; set; }
		private string RearLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the top of the dial, closest to the perimeter.The pivot narrows in from the base to the top.
		/// </summary>
		public double? TopWidth { get; set; }
		private double? TopWidth_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BaseLength != null) h.Add("baseLength",BaseLength);
			if (BaseWidth != null) h.Add("baseWidth",BaseWidth);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (Path != null) h.Add("path",Path);
			if (Radius != null) h.Add("radius",Radius);
			if (RearLength != null) h.Add("rearLength",RearLength);
			if (TopWidth != null) h.Add("topWidth",TopWidth);
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