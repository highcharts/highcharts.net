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
	public partial class ChartParallelAxesResize  : BaseObject
	{
		public ChartParallelAxesResize()
		{
			ControlledAxis = ControlledAxis_DefaultValue = new ChartParallelAxesResizeControlledAxis();
			Enabled = Enabled_DefaultValue = null;
			Cursor = Cursor_DefaultValue = "ns-resize";
			LineColor = LineColor_DefaultValue = "#cccccc";
			LineDashStyle = LineDashStyle_DefaultValue = "Solid";
			LineWidth = LineWidth_DefaultValue = null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Contains two arrays of axes that are controlled by control lineof the axis.</p><p>This feature requires the <code>drag-panes.js</code> module.</p>
		/// </summary>
		public ChartParallelAxesResizeControlledAxis ControlledAxis { get; set; }
		private ChartParallelAxesResizeControlledAxis ControlledAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable resize by drag for the axis.</p><p>This feature requires the <code>drag-panes.js</code> module.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Cursor style for the control line.</p><p>In styled mode use class <code>highcharts-axis-resizer</code> instead.</p><p>This feature requires the <code>drag-panes.js</code> module.</p>
		/// </summary>
		public string Cursor { get; set; }
		private string Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Color of the control line.</p><p>In styled mode use class <code>highcharts-axis-resizer</code> instead.</p><p>This feature requires the <code>drag-panes.js</code> module.</p>
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Dash style of the control line.</p><p>In styled mode use class <code>highcharts-axis-resizer</code> instead.</p><p>This feature requires the <code>drag-panes.js</code> module.</p>
		/// </summary>
		public string LineDashStyle { get; set; }
		private string LineDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Width of the control line.</p><p>In styled mode use class <code>highcharts-axis-resizer</code> instead.</p><p>This feature requires the <code>drag-panes.js</code> module.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Horizontal offset of the control line.</p><p>This feature requires the <code>drag-panes.js</code> module.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Vertical offset of the control line.</p><p>This feature requires the <code>drag-panes.js</code> module.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ControlledAxis.IsDirty()) h.Add("controlledAxis",ControlledAxis.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
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