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
	public partial class Tooltip  : BaseObject
	{
		public Tooltip()
		{
			Enabled = Enabled_DefaultValue = true;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			BorderRadius = BorderRadius_DefaultValue = 3;
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = new Hashtable();
			FooterFormat = FooterFormat_DefaultValue = "";
			Padding = Padding_DefaultValue = "8";
			Snap = Snap_DefaultValue = null;
			HeaderFormat = HeaderFormat_DefaultValue = "<span style='font-size: 10px'>{point.key}</span><br/>";
			PointFormat = PointFormat_DefaultValue = "<span style='color:{point.color}'>\u25CF</span> {series.name}: <b>{point.y}</b><br/>";
			BackgroundColor = BackgroundColor_DefaultValue = "rgba(247,247,247,0.85)";
			BorderWidth = BorderWidth_DefaultValue = 1;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Style = Style_DefaultValue = new Hashtable{{ "color", "#333333"},{ "cursor", "default"},{ "fontSize", "12px"},{ "pointerEvents", "none"},{ "whiteSpace", "nowrap" }};
			BorderColor = BorderColor_DefaultValue = "null";
			Crosshairs = Crosshairs_DefaultValue = new List<Crosshair>();
			FollowPointer = FollowPointer_DefaultValue = "";
			FollowTouchMove = FollowTouchMove_DefaultValue = "";
			Formatter = Formatter_DefaultValue = "";
			HideDelay = HideDelay_DefaultValue = 500;
			PointFormatter = PointFormatter_DefaultValue = "";
			Positioner = Positioner_DefaultValue = "";
			Shape = Shape_DefaultValue = TooltipShape.Callout;
			Shared = Shared_DefaultValue = false;
			Split = Split_DefaultValue = "";
			UseHTML = UseHTML_DefaultValue = false;
			ValueDecimals = ValueDecimals_DefaultValue = null;
			ValuePrefix = ValuePrefix_DefaultValue = "";
			ValueSuffix = ValueSuffix_DefaultValue = "";
			XDateFormat = XDateFormat_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Enable or disable the tooltip.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable animation of the tooltip. In slow legacy IE browsersthe animation is disabled by default.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius of the rounded border corners.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// For series on a datetime axes, the date format in the tooltip'sheader will by default be guessed based on the closest data points.This member gives the default string representations used foreach unit. For an overview of the replacement codes, see [dateFormat](#Highcharts.dateFormat).Defaults to:<pre>{    millisecond:"%A, %b %e, %H:%M:%S.%L",    second:"%A, %b %e, %H:%M:%S",    minute:"%A, %b %e, %H:%M",    hour:"%A, %b %e, %H:%M",    day:"%A, %b %e, %Y",    week:"Week from %A, %b %e, %Y",    month:"%B %Y",    year:"%Y"}</pre>
		/// </summary>
		public Hashtable DateTimeLabelFormats { get; set; }
		private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// A string to append to the tooltip format.
		/// </summary>
		public string FooterFormat { get; set; }
		private string FooterFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding inside the tooltip, in pixels.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Proximity snap for graphs or single points. It defaults to 10 formouse-powered devices and 25 for touch devices.Note that in most cases the whole plot area captures the mousemovement, and in these cases `tooltip.snap` doesn't make sense.This applies when [stickyTracking](#plotOptions.series.stickyTracking)is `true` (default) and when the tooltip is [shared](#tooltip.shared)or [split](#tooltip.split).
		/// </summary>
		public double? Snap { get; set; }
		private double? Snap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML of the tooltip header line. Variables are enclosed bycurly brackets. Available variables are `point.key`, `series.name`,`series.color` and other members from the `point` and `series`objects. The `point.key` variable contains the category name, xvalue or datetime string depending on the type of axis. For datetimeaxes, the `point.key` date format can be set using tooltip.xDateFormat.
		/// </summary>
		public string HeaderFormat { get; set; }
		private string HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML of the point's line in the tooltip. Variables are enclosedby curly brackets. Available variables are point.x, point.y, series.name and series.color and other properties on the same form. Furthermore,point.y can be extended by the `tooltip.valuePrefix` and `tooltip.valueSuffix` variables. This can also be overridden for each series,which makes it a good hook for displaying units.In styled mode, the dot is colored by a class name ratherthan the point color.
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color or gradient for the tooltip.In styled mode, the stroke width is set in the `.highcharts-tooltip-box` class.
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the tooltip border.In styled mode, the stroke width is set in the `.highcharts-tooltip-box` class.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the tooltip.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the tooltip. The tooltip can also be styled throughthe CSS class `.highcharts-tooltip`.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the tooltip border. When `null`, the border takes thecolor of the corresponding series or point.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Since 4.1, the crosshair definitions are moved to the Axis objectin order for a better separation from the tooltip. See [xAxis.crosshair](#xAxis.crosshair)<a>.</a>
		/// </summary>
		public List<Crosshair> Crosshairs { get; set; }
		private List<Crosshair> Crosshairs_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should follow the mouse as it moves across columns,pie slices and other point types with an extent. By default it behavesthis way for scatter, bubble and pie series by override in the `plotOptions`for those series types.For touch moves to behave the same way, [followTouchMove](#tooltip.followTouchMove) must be `true` also.
		/// </summary>
		public bool? FollowPointer { get; set; }
		private bool? FollowPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should follow the finger as it moves on a touchdevice. If this is `true` and [chart.panning](#chart.panning) isset,`followTouchMove` will take over one-finger touches, so the userneeds to use two fingers for zooming and panning.
		/// </summary>
		public bool? FollowTouchMove { get; set; }
		private bool? FollowTouchMove_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback function to format the text of the tooltip from scratch. Return`false` to disable tooltip for a specific point on series.A subset of HTML is supported. Unless `useHTML` is true, the HTML of thetooltip is parsed and converted to SVG, therefore this isn't a complete HTMLrenderer. The following tags are supported: `<b>`, `<strong>`, `<i>`, `<em>`,`<br/>`, `<span>`. Spans can be styled with a `style` attribute,but only text-related CSS that is shared with SVG is handled.Since version 2.1 the tooltip can be shared between multiple seriesthrough the `shared` option. The available data in the formatterdiffer a bit depending on whether the tooltip is shared or not. Ina shared tooltip, all properties except `x`, which is common forall points, are kept in an array, `this.points`.Available data are:<dl><dt>this.percentage (not shared) / this.points[i].percentage (shared)</dt><dd>Stacked series and pies only. The point's percentage of the total.</dd><dt>this.point (not shared) / this.points[i].point (shared)</dt><dd>The point object. The point name, if defined, is available through`this.point.name`.</dd><dt>this.points</dt><dd>In a shared tooltip, this is an array containing all other propertiesfor each point.</dd><dt>this.series (not shared) / this.points[i].series (shared)</dt><dd>The series object. The series name is available through`this.series.name`.</dd><dt>this.total (not shared) / this.points[i].total (shared)</dt><dd>Stacked series only. The total value at this point's x value.</dd><dt>this.x</dt><dd>The x value. This property is the same regardless of the tooltipbeing shared or not.</dd><dt>this.y (not shared) / this.points[i].y (shared)</dt><dd>The y value.</dd></dl>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of milliseconds to wait until the tooltip is hidden whenmouse out from a point or chart.
		/// </summary>
		public double? HideDelay { get; set; }
		private double? HideDelay_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function for formatting the HTML output for a single pointin the tooltip. Like the `pointFormat` string, but with more flexibility.
		/// </summary>
		public string PointFormatter { get; set; }
		private string PointFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function to place the tooltip in a default position. Thecallback receives three parameters: `labelWidth`, `labelHeight` and`point`, where point contains values for `plotX` and `plotY` tellingwhere the reference point is in the plot area. Add `chart.plotLeft`and `chart.plotTop` to get the full coordinates.The return should be an object containing x and y values, for example`{ x: 100, y: 100 }`.
		/// </summary>
		public string Positioner { get; set; }
		private string Positioner_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of a symbol to use for the border around the tooltip.
		/// </summary>
		public TooltipShape Shape { get; set; }
		private TooltipShape Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the tooltip is shared, the entire plot area will capture mousemovement or touch events. Tooltip texts for series types with ordereddata (not pie, scatter, flags etc) will be shown in a single bubble.This is recommended for single series charts and for tablet/mobileoptimized charts.See also [tooltip.split](#tooltip.split), that is better suited forcharts with many series, especially line-type series.
		/// </summary>
		public bool? Shared { get; set; }
		private bool? Shared_DefaultValue { get; set; }
		 

		/// <summary>
		/// Split the tooltip into one label per series, with the header closeto the axis. This is recommended over [shared](#tooltip.shared) tooltipsfor charts with multiple line series, generally making them easierto read.
		/// </summary>
		public bool? Split { get; set; }
		private bool? Split_DefaultValue { get; set; }
		 

		/// <summary>
		/// Use HTML to render the contents of the tooltip instead of SVG. UsingHTML allows advanced formatting like tables and images in the tooltip.It is also recommended for rtl languages as it works around rtlbugs in early Firefox.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// How many decimals to show in each series' y value. This is overridablein each series' tooltip options object. The default is to preserveall decimals.
		/// </summary>
		public double? ValueDecimals { get; set; }
		private double? ValueDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// A string to prepend to each series' y value. Overridable in eachseries' tooltip options object.
		/// </summary>
		public string ValuePrefix { get; set; }
		private string ValuePrefix_DefaultValue { get; set; }
		 

		/// <summary>
		/// A string to append to each series' y value. Overridable in each series'tooltip options object.
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

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (DateTimeLabelFormats != DateTimeLabelFormats_DefaultValue) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (FooterFormat != FooterFormat_DefaultValue) h.Add("footerFormat",FooterFormat);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Snap != Snap_DefaultValue) h.Add("snap",Snap);
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Crosshairs != Crosshairs_DefaultValue) h.Add("crosshairs",Crosshairs);
			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (FollowTouchMove != FollowTouchMove_DefaultValue) h.Add("followTouchMove",FollowTouchMove);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (HideDelay != HideDelay_DefaultValue) h.Add("hideDelay",HideDelay);
			if (PointFormatter != PointFormatter_DefaultValue) h.Add("pointFormatter",PointFormatter);
			if (Positioner != Positioner_DefaultValue) h.Add("positioner",Positioner);
			if (Shape != Shape_DefaultValue) h.Add("shape", Highcharts.FirstCharacterToLower(Shape.ToString()));
			if (Shared != Shared_DefaultValue) h.Add("shared",Shared);
			if (Split != Split_DefaultValue) h.Add("split",Split);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (ValueDecimals != ValueDecimals_DefaultValue) h.Add("valueDecimals",ValueDecimals);
			if (ValuePrefix != ValuePrefix_DefaultValue) h.Add("valuePrefix",ValuePrefix);
			if (ValueSuffix != ValueSuffix_DefaultValue) h.Add("valueSuffix",ValueSuffix);
			if (XDateFormat != XDateFormat_DefaultValue) h.Add("xDateFormat",XDateFormat);
			

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