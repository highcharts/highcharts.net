using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class NavigatorYAxisPlotLines  : BaseObject
	{
		public NavigatorYAxisPlotLines()
		{
			ClassName = ClassName_DefaultValue = null;
			Color = Color_DefaultValue = "null";
			DashStyle = DashStyle_DefaultValue = NavigatorYAxisPlotLinesDashStyle.Solid;
			Events = Events_DefaultValue = null;
			Id = Id_DefaultValue = "null";
			Value = Value_DefaultValue = null;
			Width = Width_DefaultValue = null;
			ZIndex = ZIndex_DefaultValue = null;
			Label = Label_DefaultValue = new NavigatorYAxisPlotLinesLabel();
			
		}	
		

		/// <summary>
		/// <p>A custom class name, in addition to the default <code>highcharts-plot-line</code>, to apply to each individual line.</p>
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the line.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The dashing or dot style for the plot line. For possible values see<a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/">this overview</a>.</p>
		/// </summary>
		public NavigatorYAxisPlotLinesDashStyle DashStyle { get; set; }
		private NavigatorYAxisPlotLinesDashStyle DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An object defining mouse events for the plot line. Supported propertiesare <code>click</code>, <code>mouseover</code>, <code>mouseout</code>, <code>mousemove</code>.</p>
		/// </summary>
		public Object Events { get; set; }
		private Object Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An id used for identifying the plot line in Axis.removePlotLine.</p>
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The position of the line in axis units.</p>
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width or thickness of the plot line.</p>
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The z index of the plot line within the chart.</p>
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Text labels for the plot bands</p>
		/// </summary>
		public NavigatorYAxisPlotLinesLabel Label { get; set; }
		private NavigatorYAxisPlotLinesLabel Label_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle", Highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (Events != Events_DefaultValue) h.Add("events",Events);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			

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