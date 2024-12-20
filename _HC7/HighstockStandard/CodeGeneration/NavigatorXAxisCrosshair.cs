using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class NavigatorXAxisCrosshair  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigatorXAxisCrosshair()
		{
		}	
		

		/// <summary>
		/// A class name for the crosshair, especially as a hook for styling.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// The color of the crosshair. Defaults to `#cccccc` for numeric anddatetime axes, and `rgba(204,214,235,0.25)` for category axes, wherethe crosshair by default highlights the whole category.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// The dash style for the crosshair. See[plotOptions.series.dashStyle](#plotOptions.series.dashStyle)for possible values.
		/// </summary>
		public NavigatorXAxisCrosshairDashStyle DashStyle { get; set; }
		 

		/// <summary>
		/// A label on the axis next to the crosshair.In styled mode, the label is styled with the`.highcharts-crosshair-label` class.
		/// </summary>
		public NavigatorXAxisCrosshairLabel Label { get; set; }
		 

		/// <summary>
		/// Whether the crosshair should snap to the point or follow the pointerindependent of points.
		/// </summary>
		public bool? Snap { get; set; }
		 

		/// <summary>
		/// The pixel width of the crosshair. Defaults to 1 for numeric ordatetime axes, and for one category width for category axes.
		/// </summary>
		public double? Width { get; set; }
		 

		/// <summary>
		/// The Z index of the crosshair. Higher Z indices allow drawing thecrosshair on top of the series or behind the grid lines.
		/// </summary>
		public double? ZIndex { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ClassName != null) h.Add("className",ClassName);
			if (Color != null) h.Add("color",Color);
			if (DashStyle != NavigatorXAxisCrosshairDashStyle.Null) h.Add("dashStyle", highstock.FirstCharacterToLower(DashStyle.ToString()));
			if (Label != null) h.Add("label",Label.ToHashtable(highstock));
			if (Snap != null) h.Add("snap",Snap);
			if (Width != null) h.Add("width",Width);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
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