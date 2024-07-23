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
	public partial class PaneBackground  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PaneBackground()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The background color or gradient for the pane.
		/// </summary>
		public Object BackgroundColor { get; set; }
		 

		/// <summary>
		/// The pane background border color.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The border radius of the pane background when the shape is `arc`. Can bea number (pixels) or a percentage string.
		/// </summary>
		public string BorderRadius { get; set; }
		 

		/// <summary>
		/// The border radius of the pane background when the shape is `arc`. Can bea number (pixels) or a percentage string.
		/// </summary>
		public double? BorderRadiusNumber { get; set; }
		 

		/// <summary>
		/// The pixel border width of the pane background.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// The class name for this background.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// The inner radius of the pane background. Can be either numeric(pixels) or a percentage string.
		/// </summary>
		public string InnerRadius { get; set; }
		 

		/// <summary>
		/// The inner radius of the pane background. Can be either numeric(pixels) or a percentage string.
		/// </summary>
		public double? InnerRadiusNumber { get; set; }
		 

		/// <summary>
		/// The outer radius of the circular pane background. Can be eithernumeric (pixels) or a percentage string.
		/// </summary>
		public string OuterRadius { get; set; }
		 

		/// <summary>
		/// The outer radius of the circular pane background. Can be eithernumeric (pixels) or a percentage string.
		/// </summary>
		public double? OuterRadiusNumber { get; set; }
		 

		/// <summary>
		/// The shape of the pane background. When `solid`, the backgroundis circular. When `arc`, the background extends only from the minto the max of the value axis.
		/// </summary>
		public string Shape { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderRadiusNumber != null) h.Add("borderRadius",BorderRadiusNumber);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (ClassName != null) h.Add("className",ClassName);
			if (InnerRadius != null) h.Add("innerRadius",InnerRadius);
			if (InnerRadiusNumber != null) h.Add("innerRadius",InnerRadiusNumber);
			if (OuterRadius != null) h.Add("outerRadius",OuterRadius);
			if (OuterRadiusNumber != null) h.Add("outerRadius",OuterRadiusNumber);
			if (Shape != null) h.Add("shape",Shape);
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