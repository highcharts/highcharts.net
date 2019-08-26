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
	public partial class PlotOptionsSeriesTooltip  : BaseObject
	{
		public PlotOptionsSeriesTooltip()
		{
			ClassName = ClassName_DefaultValue = "";
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = new Hashtable();
			FollowPointer = FollowPointer_DefaultValue = null;
			FollowTouchMove = FollowTouchMove_DefaultValue = null;
			FooterFormat = FooterFormat_DefaultValue = "";
			HeaderFormat = HeaderFormat_DefaultValue = "<span style='font-size: 10px'>{point.key}</span><br/>";
			HeaderShape = HeaderShape_DefaultValue = PlotOptionsSeriesTooltipHeaderShape.Callout;
			HideDelay = HideDelay_DefaultValue = 500;
			NullFormat = NullFormat_DefaultValue = "";
			NullFormatter = NullFormatter_DefaultValue = "";
			Outside = Outside_DefaultValue = null;
			Padding = Padding_DefaultValue = "8";
			PointFormat = PointFormat_DefaultValue = "<span style='color:{point.color}'> u25CF</span> {series.name}: <b>{point.y}</b><br/>";
			PointFormatter = PointFormatter_DefaultValue = "";
			Split = Split_DefaultValue = null;
			ValueDecimals = ValueDecimals_DefaultValue = null;
			ValuePrefix = ValuePrefix_DefaultValue = "";
			ValueSuffix = ValueSuffix_DefaultValue = "";
			XDateFormat = XDateFormat_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// A CSS class name to apply to the tooltip's container div,allowing unique CSS styling for each chart.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// For series on a datetime axes, the date format in the tooltip'sheader will by default be guessed based on the closest data points.This member gives the default string representations used foreach unit. For an overview of the replacement codes, see[dateFormat](/class-reference/Highcharts#dateFormat).
		/// </summary>
		public Hashtable DateTimeLabelFormats { get; set; }
		private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should follow the mouse as it moves acrosscolumns, pie slices and other point types with an extent.By default it behaves this way for pie, polygon, map, sankeyand wordcloud series by override in the `plotOptions`for those series types.For touch moves to behave the same way, [followTouchMove](#tooltip.followTouchMove) must be `true` also.
		/// </summary>
		public bool? FollowPointer { get; set; }
		private bool? FollowPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should update as the finger moves on a touchdevice. If this is `true` and [chart.panning](#chart.panning) isset,`followTouchMove` will take over one-finger touches, so the userneeds to use two fingers for zooming and panning.Note the difference to [followPointer](#tooltip.followPointer) thatonly defines the _position_ of the tooltip. If `followPointer` isfalse in for example a column series, the tooltip will show above orbelow the column, but as `followTouchMove` is true, the tooltip willjump from column to column as the user swipes across the plot area.
		/// </summary>
		public bool? FollowTouchMove { get; set; }
		private bool? FollowTouchMove_DefaultValue { get; set; }
		 

		/// <summary>
		/// A string to append to the tooltip format.
		/// </summary>
		public string FooterFormat { get; set; }
		private string FooterFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML of the tooltip header line. Variables are enclosed bycurly brackets. Available variables are `point.key`, `series.name`,`series.color` and other members from the `point` and `series`objects. The `point.key` variable contains the category name, xvalue or datetime string depending on the type of axis. For datetimeaxes, the `point.key` date format can be set using`tooltip.xDateFormat`.
		/// </summary>
		public string HeaderFormat { get; set; }
		private string HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of a symbol to use for the border around the tooltipheader. Applies only when [tooltip.split](#tooltip.split) isenabled.Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols` the same way as for[series.marker.symbol](plotOptions.line.marker.symbol).
		/// </summary>
		public PlotOptionsSeriesTooltipHeaderShape HeaderShape { get; set; }
		private PlotOptionsSeriesTooltipHeaderShape HeaderShape_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of milliseconds to wait until the tooltip is hidden whenmouse out from a point or chart.
		/// </summary>
		public double? HideDelay { get; set; }
		private double? HideDelay_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML of the null point's line in the tooltip. Works analogouslyto [pointFormat](#tooltip.pointFormat).
		/// </summary>
		public string NullFormat { get; set; }
		private string NullFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback function to format the text of the tooltip forvisible null points.Works analogously to [formatter](#tooltip.formatter).
		/// </summary>
		public string NullFormatter { get; set; }
		private string NullFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to allow the tooltip to render outside the chart's SVGelement box. By default (`false`), the tooltip is rendered within thechart's SVG element, which results in the tooltip being alignedinside the chart area. For small charts, this may result in clippingor overlapping. When `true`, a separate SVG element is created andoverlaid on the page, allowing the tooltip to be aligned inside thepage itself.Defaults to `true` if `chart.scrollablePlotArea` is activated,otherwise `false`.
		/// </summary>
		public bool? Outside { get; set; }
		private bool? Outside_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding inside the tooltip, in pixels.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML of the point's line in the tooltip. Variables are enclosedby curly brackets. Available variables are point.x, point.y, series.name and series.color and other properties on the same form.Furthermore, `point.y` can be extended by the `tooltip.valuePrefix`and `tooltip.valueSuffix` variables. This can also be overridden foreach series, which makes it a good hook for displaying units.In styled mode, the dot is colored by a class name ratherthan the point color.
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function for formatting the HTML output for a single pointin the tooltip. Like the `pointFormat` string, but with moreflexibility.
		/// </summary>
		public string PointFormatter { get; set; }
		private string PointFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Split the tooltip into one label per series, with the header closeto the axis. This is recommended over [shared](#tooltip.shared)tooltips for charts with multiple line series, generally making themeasier to read. This option takes precedence over `tooltip.shared`.
		/// </summary>
		public bool? Split { get; set; }
		private bool? Split_DefaultValue { get; set; }
		 

		/// <summary>
		/// How many decimals to show in each series' y value. This isoverridable in each series' tooltip options object. The default is topreserve all decimals.
		/// </summary>
		public double? ValueDecimals { get; set; }
		private double? ValueDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// A string to prepend to each series' y value. Overridable in eachseries' tooltip options object.
		/// </summary>
		public string ValuePrefix { get; set; }
		private string ValuePrefix_DefaultValue { get; set; }
		 

		/// <summary>
		/// A string to append to each series' y value. Overridable in eachseries' tooltip options object.
		/// </summary>
		public string ValueSuffix { get; set; }
		private string ValueSuffix_DefaultValue { get; set; }
		 

		/// <summary>
		/// The format for the date in the tooltip header if the X axis is adatetime axis. The default is a best guess based on the smallestdistance between points in the chart.
		/// </summary>
		public string XDateFormat { get; set; }
		private string XDateFormat_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (DateTimeLabelFormats != DateTimeLabelFormats_DefaultValue) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (FollowTouchMove != FollowTouchMove_DefaultValue) h.Add("followTouchMove",FollowTouchMove);
			if (FooterFormat != FooterFormat_DefaultValue) h.Add("footerFormat",FooterFormat);
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (HeaderShape != HeaderShape_DefaultValue) h.Add("headerShape", Highcharts.FirstCharacterToLower(HeaderShape.ToString()));
			if (HideDelay != HideDelay_DefaultValue) h.Add("hideDelay",HideDelay);
			if (NullFormat != NullFormat_DefaultValue) h.Add("nullFormat",NullFormat);
			if (NullFormatter != NullFormatter_DefaultValue) { h.Add("nullFormatter",NullFormatter); Highcharts.AddFunction("80f3ea98-b286-4a7d-967f-4a6dc1981a8f.nullFormatter", NullFormatter); }  
			if (Outside != Outside_DefaultValue) h.Add("outside",Outside);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (PointFormatter != PointFormatter_DefaultValue) { h.Add("pointFormatter",PointFormatter); Highcharts.AddFunction("b8ed2af2-88a8-4ca2-b837-a76f8fda0a18.pointFormatter", PointFormatter); }  
			if (Split != Split_DefaultValue) h.Add("split",Split);
			if (ValueDecimals != ValueDecimals_DefaultValue) h.Add("valueDecimals",ValueDecimals);
			if (ValuePrefix != ValuePrefix_DefaultValue) h.Add("valuePrefix",ValuePrefix);
			if (ValueSuffix != ValueSuffix_DefaultValue) h.Add("valueSuffix",ValueSuffix);
			if (XDateFormat != XDateFormat_DefaultValue) h.Add("xDateFormat",XDateFormat);
			

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