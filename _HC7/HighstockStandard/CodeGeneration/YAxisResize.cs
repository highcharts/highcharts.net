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
	public partial class YAxisResize  : BaseObject
	{
		Hashtable h = new Hashtable();

		public YAxisResize()
		{
		}	
		

		/// <summary>
		/// Contains two arrays of axes that are controlled by control lineof the axis.
		/// </summary>
		public YAxisResizeControlledAxis ControlledAxis { get; set; }
		 

		/// <summary>
		/// Cursor style for the control line.In styled mode use class `highcharts-axis-resizer` instead.
		/// </summary>
		public string Cursor { get; set; }
		 

		/// <summary>
		/// Enable or disable resize by drag for the axis.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Color of the control line.In styled mode use class `highcharts-axis-resizer` instead.
		/// </summary>
		public string LineColor { get; set; }
		 

		/// <summary>
		/// Dash style of the control line.In styled mode use class `highcharts-axis-resizer` instead.
		/// </summary>
		public Hashtable LineDashStyle { get; set; }
		 

		/// <summary>
		/// Width of the control line.In styled mode use class `highcharts-axis-resizer` instead.
		/// </summary>
		public double? LineWidth { get; set; }
		 

		/// <summary>
		/// Horizontal offset of the control line.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// Vertical offset of the control line.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ControlledAxis != null) h.Add("controlledAxis",ControlledAxis.ToHashtable(highstock));
			if (Cursor != null) h.Add("cursor",Cursor);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (LineColor != null) h.Add("lineColor",LineColor);
			if (LineDashStyle != null) h.Add("lineDashStyle",LineDashStyle);
			if (LineWidth != null) h.Add("lineWidth",LineWidth);
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
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