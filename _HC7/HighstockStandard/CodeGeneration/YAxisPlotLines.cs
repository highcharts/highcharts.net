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
	public partial class YAxisPlotLines  : BaseObject
	{
		public YAxisPlotLines()
		{
			AcrossPanes = AcrossPanes_DefaultValue = true;
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "#999999";
			DashStyle = DashStyle_DefaultValue = "Solid";
			Events = Events_DefaultValue = null;
			Id = Id_DefaultValue = "";
			Label = Label_DefaultValue = new YAxisPlotLinesLabel();
			Value = Value_DefaultValue = null;
			Width = Width_DefaultValue = 2;
			ZIndex = ZIndex_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Flag to decide if plotLine should be rendered across all panes.
		/// </summary>
		public bool? AcrossPanes { get; set; }
		private bool? AcrossPanes_DefaultValue { get; set; }
		 

		/// <summary>
		/// A custom class name, in addition to the default `highcharts-plot-line`,to apply to each individual line.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the line.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dashing or dot style for the plot line. For possible values see[this overview](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/).
		/// </summary>
		public string DashStyle { get; set; }
		private string DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// An object defining mouse events for the plot line. Supportedproperties are `click`, `mouseover`, `mouseout`, `mousemove`.
		/// </summary>
		public Object Events { get; set; }
		private Object Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id used for identifying the plot line in Axis.removePlotLine.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// Text labels for the plot bands
		/// </summary>
		public YAxisPlotLinesLabel Label { get; set; }
		private YAxisPlotLinesLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the line in axis units.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width or thickness of the plot line.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The z index of the plot line within the chart.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AcrossPanes != AcrossPanes_DefaultValue) h.Add("acrossPanes",AcrossPanes);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle",DashStyle);
			if (Events != Events_DefaultValue) h.Add("events",Events);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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