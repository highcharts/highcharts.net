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
	public partial class YAxisPlotLines  : BaseObject
	{
		Hashtable h = new Hashtable();

		public YAxisPlotLines()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Flag to decide if plotLine should be rendered across all panes.
		/// </summary>
		public bool? AcrossPanes { get; set; }
		 

		/// <summary>
		/// A custom class name, in addition to the default `highcharts-plot-line`,to apply to each individual line.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// The color of the line.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// The dashing or dot style for the plot line. For possible values see[this overview](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public YAxisPlotLinesDashStyle DashStyle { get; set; }
		 

		/// <summary>
		/// An object defining mouse events for the plot line. Supportedproperties are `click`, `mouseover`, `mouseout`, `mousemove`.
		/// </summary>
		public Object Events { get; set; }
		 

		/// <summary>
		/// An id used for identifying the plot line in Axis.removePlotLine.
		/// </summary>
		public string Id { get; set; }
		 

		/// <summary>
		/// Text labels for the plot bands
		/// </summary>
		public YAxisPlotLinesLabel Label { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public YAxisPlotLinesLabels Labels { get; set; }
		 

		/// <summary>
		/// The position of the line in axis units.
		/// </summary>
		public double? Value { get; set; }
		 

		/// <summary>
		/// The width or thickness of the plot line.
		/// </summary>
		public double? Width { get; set; }
		 

		/// <summary>
		/// The z index of the plot line within the chart.
		/// </summary>
		public double? ZIndex { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (AcrossPanes != null) h.Add("acrossPanes",AcrossPanes);
			if (ClassName != null) h.Add("className",ClassName);
			if (Color != null) h.Add("color",Color);
			if (DashStyle != YAxisPlotLinesDashStyle.Null) h.Add("dashStyle", highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (Events != null) h.Add("events",Events);
			if (Id != null) h.Add("id",Id);
			if (Label != null) h.Add("label",Label.ToHashtable(highcharts));
			if (Labels != null) h.Add("labels",Labels.ToHashtable(highcharts));
			if (Value != null) h.Add("value",Value);
			if (Width != null) h.Add("width",Width);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
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