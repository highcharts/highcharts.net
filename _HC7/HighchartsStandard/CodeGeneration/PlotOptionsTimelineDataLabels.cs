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
	public partial class PlotOptionsTimelineDataLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTimelineDataLabels()
		{
		}	
		

		/// <summary>
		/// The alignment of the data label compared to the point. If `right`,the right side of the label should be touching the point. For pointswith an extent, like columns, the alignments also dictates how toalign it inside the box, as given with the[inside](#plotOptions.column.dataLabels.inside) option. Can be one of`left`, `center` or `right`.
		/// </summary>
		public PlotOptionsTimelineDataLabelsAlign Align { get; set; }
		 

		/// <summary>
		/// Alignment method for data labels. If set to `plotEdges`, the labelsare aligned within the plot area in the direction of the y-axis. Soin a regular column chart, the labels are aligned verticallyaccording to the `verticalAlign` setting. In a bar chart, which isinverted, the labels are aligned horizontally according to the`align` setting. Applies to cartesian series only.
		/// </summary>
		public string AlignTo { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? AllowOverlap { get; set; }
		 

		/// <summary>
		/// Whether to position data labels alternately. For example, if[distance](#plotOptions.timeline.dataLabels.distance)is set equal to `100`, then data labels will be positionedalternately (on both sides of the point) at a distance of 100px.
		/// </summary>
		public bool? Alternate { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayedfor the `dataLabels`. The animation can also be set as aconfiguration object. Please note that this option only applies tothe initial animation.For other animations, see [chart.animation](#chart.animation) and theanimation parameter under the API methods. The following propertiesare supported:- `defer`: The animation delay time in milliseconds.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayedfor the `dataLabels`. The animation can also be set as aconfiguration object. Please note that this option only applies tothe initial animation.For other animations, see [chart.animation](#chart.animation) and theanimation parameter under the API methods. The following propertiesare supported:- `defer`: The animation delay time in milliseconds.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BackgroundColor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? BorderRadius { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// A class name for the data label. Particularly in styled mode,this can be used to give each series' or point's data labelunique styling. In addition to this option, a default color classname is added so that we can give the labels a contrast textshadow.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// The color of the line connecting the data label to the point.The default color is the same as the point's color.In styled mode, the connector stroke is given in the`.highcharts-data-label-connector` class.
		/// </summary>
		public string ConnectorColor { get; set; }
		 

		/// <summary>
		/// The width of the line connecting the data label to the point.In styled mode, the connector stroke width is given in the`.highcharts-data-label-connector` class.
		/// </summary>
		public double? ConnectorWidth { get; set; }
		 

		/// <summary>
		/// Whether to hide data labels that are outside the plot area. Bydefault, the data label is moved inside the plot area accordingto the[overflow](#plotOptions.series.dataLabels.overflow)option.
		/// </summary>
		public bool? Crop { get; set; }
		 

		/// <summary>
		/// Whether to defer displaying the data labels until the initialseries animation has finished. Setting to `false` renders thedata label immediately. If set to `true` inherits the defertime set in [plotOptions.series.animation](#plotOptions.series.animation).
		/// </summary>
		public bool? Defer { get; set; }
		 

		/// <summary>
		/// A pixel value defining the distance between the data label andthe point. Negative numbers puts the label on top of the point in anon-inverted chart. Defaults to 100 for horizontal and 20 forvertical timeline (`chart.inverted: true`).
		/// </summary>
		public string Distance { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// A declarative filter to control of which data labels to display.The declarative filter is designed for use when callbackfunctions are not available, like when the chart options requirea pure JSON structure or for use with graphical editors. Forprogrammatic control, use the `formatter` instead, and return`undefined` to disable a single data label.
		/// </summary>
		public PlotOptionsTimelineDataLabelsFilter Filter { get; set; }
		 

		/// <summary>
		/// A[format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)for the data label. Available variables are the same as for`formatter`.
		/// </summary>
		public string Format { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Formatter { get; set; }
		 

		/// <summary>
		/// For points with an extent, like columns or map areas, whether toalign the data label inside the box or to the actual value point.Defaults to `false` in most cases, `true` in stacked columns.
		/// </summary>
		public bool? Inside { get; set; }
		 

		/// <summary>
		/// Format for points with the value of null. Works analogously to[format](#plotOptions.series.dataLabels.format). `nullFormat` canbe applied only to series which support displaying null pointsi.e `heatmap` or `tilemap`. Does not work with series that don'tdisplay null points, like `line`, `column`, `bar` or `pie`.
		/// </summary>
		public string NullFormat { get; set; }
		 

		/// <summary>
		/// Format for points with the value of null. Works analogously to[format](#plotOptions.series.dataLabels.format). `nullFormat` canbe applied only to series which support displaying null pointsi.e `heatmap` or `tilemap`. Does not work with series that don'tdisplay null points, like `line`, `column`, `bar` or `pie`.
		/// </summary>
		public bool? NullFormatBool { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function that defines formatting for pointswith the value of null. Works analogously to[formatter](#plotOptions.series.dataLabels.formatter).`nullFormatter` can be applied only to series which supportdisplaying null points i.e `heatmap` or `tilemap`. Does not workwith series that don't display null points, like `line`, `column`,`bar` or `pie`.
		/// </summary>
		public string NullFormatter { get; set; }
		 

		/// <summary>
		/// How to handle data labels that flow outside the plot area. Thedefault is `"justify"`, which aligns them inside the plot area.For columns and bars, this means it will be moved inside the bar.To display data labels outside the plot area, set `crop` to`false` and `overflow` to `"allow"`.
		/// </summary>
		public PlotOptionsTimelineDataLabelsOverflow Overflow { get; set; }
		 

		/// <summary>
		/// When either the `borderWidth` or the `backgroundColor` is set,this is the padding within the box.
		/// </summary>
		public double? Padding { get; set; }
		 

		/// <summary>
		/// Aligns data labels relative to points. If `center` alignment isnot possible, it defaults to `right`.
		/// </summary>
		public PlotOptionsTimelineDataLabelsPosition Position { get; set; }
		 

		/// <summary>
		/// Text rotation in degrees. Note that due to a more complexstructure, backgrounds, borders and padding will be lost on arotated data label.
		/// </summary>
		public double? Rotation { get; set; }
		 

		/// <summary>
		/// Shadow options for the data label.
		/// </summary>
		public Shadow Shadow { get; set; }
		 

		/// <summary>
		/// The name of a symbol to use for the border around the label.Symbols are predefined functions on the Renderer object.
		/// </summary>
		public string Shape { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// Options for a label text which should follow marker's shape.Border and background are disabled for a label that follows apath.**Note:** Only SVG-based renderer supports this option. Setting`useHTML` to true will disable this option.
		/// </summary>
		public PlotOptionsTimelineDataLabelsTextPath TextPath { get; set; }
		 

		/// <summary>
		/// Whether to[use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		 

		/// <summary>
		/// The vertical alignment of a data label. Can be one of `top`,`middle` or `bottom`. The default value depends on the data, forinstance in a column chart, the label is above positive valuesand below negative values.
		/// </summary>
		public PlotOptionsTimelineDataLabelsVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Width { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the point inpixels.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the point inpixels.
		/// </summary>
		public double? Y { get; set; }
		 

		/// <summary>
		/// The z index of the data labels. Use a `zIndex` of 6 to display it abovethe series, or use a `zIndex` of 2 to display it behind the series.
		/// </summary>
		public double? ZIndex { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Align != PlotOptionsTimelineDataLabelsAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (AlignTo != null) h.Add("alignTo",AlignTo);
			if (AllowOverlap != null) h.Add("allowOverlap",AllowOverlap);
			if (Alternate != null) h.Add("alternate",Alternate);
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (ClassName != null) h.Add("className",ClassName);
			if (Color != null) h.Add("color",Color);
			if (ConnectorColor != null) h.Add("connectorColor",ConnectorColor);
			if (ConnectorWidth != null) h.Add("connectorWidth",ConnectorWidth);
			if (Crop != null) h.Add("crop",Crop);
			if (Defer != null) h.Add("defer",Defer);
			if (Distance != null) h.Add("distance",Distance);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Filter != null) h.Add("filter",Filter.ToHashtable(highcharts));
			if (Format != null) h.Add("format",Format);
			if (Formatter != null) { h.Add("formatter",Formatter); highcharts.AddFunction("formatter", Formatter); }  
			if (Inside != null) h.Add("inside",Inside);
			if (NullFormat != null) h.Add("nullFormat",NullFormat);
			if (NullFormatBool != null) h.Add("nullFormat",NullFormatBool);
			if (NullFormatter != null) { h.Add("nullFormatter",NullFormatter); highcharts.AddFunction("nullFormatter", NullFormatter); }  
			if (Overflow != PlotOptionsTimelineDataLabelsOverflow.Null) h.Add("overflow", highcharts.FirstCharacterToLower(Overflow.ToString()));
			if (Padding != null) h.Add("padding",Padding);
			if (Position != PlotOptionsTimelineDataLabelsPosition.Null) h.Add("position", highcharts.FirstCharacterToLower(Position.ToString()));
			if (Rotation != null) h.Add("rotation",Rotation);
			if (Shadow != null) h.Add("shadow",Shadow);
			if (Shape != null) h.Add("shape",Shape);
			if (Style != null) h.Add("style",Style);
			if (TextPath != null) h.Add("textPath",TextPath.ToHashtable(highcharts));
			if (UseHTML != null) h.Add("useHTML",UseHTML);
			if (VerticalAlign != PlotOptionsTimelineDataLabelsVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (Width != null) h.Add("width",Width);
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
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