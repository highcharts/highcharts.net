using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class YAxisResize  : BaseObject
	{
		public YAxisResize()
		{
			ControlledAxis = ControlledAxis_DefaultValue = new YAxisResizeControlledAxis();
			Cursor = Cursor_DefaultValue = "ns-resize";
			Enabled = Enabled_DefaultValue = false;
			LineColor = LineColor_DefaultValue = "#cccccc";
			LineDashStyle = LineDashStyle_DefaultValue = "Solid";
			LineWidth = LineWidth_DefaultValue = 4;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// Contains two arrays of axes that are controlled by control lineof the axis.This feature requires the `drag-panes.js` module.
		/// </summary>
		public YAxisResizeControlledAxis ControlledAxis { get; set; }
		private YAxisResizeControlledAxis ControlledAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// Cursor style for the control line.In styled mode use class `highcharts-axis-resizer` instead.This feature requires the `drag-panes.js` module.
		/// </summary>
		public string Cursor { get; set; }
		private string Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable resize by drag for the axis.This feature requires the `drag-panes.js` module.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the control line.In styled mode use class `highcharts-axis-resizer` instead.This feature requires the `drag-panes.js` module.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Dash style of the control line.In styled mode use class `highcharts-axis-resizer` instead.This feature requires the `drag-panes.js` module.
		/// </summary>
		public string LineDashStyle { get; set; }
		private string LineDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width of the control line.In styled mode use class `highcharts-axis-resizer` instead.This feature requires the `drag-panes.js` module.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal offset of the control line.This feature requires the `drag-panes.js` module.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical offset of the control line.This feature requires the `drag-panes.js` module.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ControlledAxis.IsDirty()) h.Add("controlledAxis",ControlledAxis.ToHashtable());
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineDashStyle != LineDashStyle_DefaultValue) h.Add("lineDashStyle",LineDashStyle);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}