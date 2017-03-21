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
	public partial class Tooltip  : BaseObject
	{
		public Tooltip()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			BackgroundColor = BackgroundColor_DefaultValue = "rgba(247,247,247,0.85)";
			BorderColor = BorderColor_DefaultValue = "null";
			BorderRadius = BorderRadius_DefaultValue = 3;
			BorderWidth = BorderWidth_DefaultValue = 1;
			ChangeDecimals = ChangeDecimals_DefaultValue = null;
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = new Hashtable();
			Enabled = Enabled_DefaultValue = true;
			FollowPointer = FollowPointer_DefaultValue = false;
			FollowTouchMove = FollowTouchMove_DefaultValue = true;
			Formatter = Formatter_DefaultValue = "";
			HeaderFormat = HeaderFormat_DefaultValue = "";
			Padding = Padding_DefaultValue = 8;
			PointFormat = PointFormat_DefaultValue = "<span style='color:{point.color}'>\u25CF</span> {series.name}: <b>{point.y}</b><br/>";
			PointFormatter = PointFormatter_DefaultValue = "";
			Positioner = Positioner_DefaultValue = "";
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Shape = Shape_DefaultValue = "callout";
			Shared = Shared_DefaultValue = true;
			Snap = Snap_DefaultValue = 10/25;
			Split = Split_DefaultValue = false;
			Style = Style_DefaultValue = new Hashtable{{ "color", "#333333"},{ "cursor", "default"},{ "fontSize", "12px"},{ "pointerEvents", "none"},{ "whiteSpace", "nowrap" }};
			UseHTML = UseHTML_DefaultValue = false;
			ValueDecimals = ValueDecimals_DefaultValue = null;
			ValuePrefix = ValuePrefix_DefaultValue = null;
			ValueSuffix = ValueSuffix_DefaultValue = null;
			XDateFormat = XDateFormat_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Enable or disable animation of the tooltip. In slow legacy IE browsers the animation is disabled by default.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The background color or gradient for the tooltip.</p><p>In <a href="http://www.highcharts.com/docs/chart-design-and-style/style-by-css">styled mode</a>, the stroke width is set in the <code>.highcharts-tooltip-box</code> class.</p>
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the tooltip border. When <code>null</code>, the border takes the color of the corresponding series or point.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius of the rounded border corners.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel width of the tooltip border.</p><p>In <a href="http://www.highcharts.com/docs/chart-design-and-style/style-by-css">styled mode</a>, the stroke width is set in the <code>.highcharts-tooltip-box</code> class.</p>
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// How many decimals to show for the <code>point.change</code> value when the <code>series.compare</code> option is set. This is overridable in each series' tooltip options object. The default is to preserve all decimals.
		/// </summary>
		public double? ChangeDecimals { get; set; }
		private double? ChangeDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For series on a datetime axes, the date format in the tooltip's header will by default be guessed based on the closest data points. This member gives the default string representations used for each unit. For an overview of the replacement codes, see <a href="#Highcharts.dateFormat">dateFormat</a>.</p><p>Defaults to:<pre>{    millisecond:"%A, %b %e, %H:%M:%S.%L",    second:"%A, %b %e, %H:%M:%S",    minute:"%A, %b %e, %H:%M",    hour:"%A, %b %e, %H:%M",    day:"%A, %b %e, %Y",    week:"Week from %A, %b %e, %Y",    month:"%B %Y",    year:"%Y"}</pre></p>
		/// </summary>
		public Hashtable DateTimeLabelFormats { get; set; }
		private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the tooltip.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether the tooltip should follow the mouse as it moves across columns, pie slices and other point types with an extent. By default it behaves this way for scatter, bubble and pie series by override in the <code>plotOptions</code> for those series types. </p><p>For touch moves to behave the same way, <a href="#tooltip.followTouchMove">followTouchMove</a> must be <code>true</code> also.</p>
		/// </summary>
		public bool? FollowPointer { get; set; }
		private bool? FollowPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should follow the finger as it moves on a touch device. If this is <code>true</code> and <a href="#chart.panning">chart.panning</a> is set,<code>followTouchMove</code> will take over one-finger touches, so the user needs to use two fingers for zooming and panning.
		/// </summary>
		public bool? FollowTouchMove { get; set; }
		private bool? FollowTouchMove_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Callback function to format the text of the tooltip from scratch. Return false to disable tooltip for a specific point on series.</p> <p>A subset of HTML is supported. The HTML of the tooltip is parsed and converted to SVG,  therefore this isn't a complete HTML renderer. The following tags are supported:  <code>&lt;b&gt;</code>, <code>&lt;strong&gt;</code>, <code>&lt;i&gt;</code>, <code>&lt;em&gt;</code>, <code>&lt;br/&gt;</code>, <code>&lt;span&gt;</code>. Spans can be styled with a <code>style</code> attribute, but only text-related CSS that is  shared with SVG is handled. </p> <p>Since version 2.1 the tooltip can be shared between multiple series through  the <code>shared</code> option. The available data in the formatter differ a bit depending on whether the tooltip is shared or not. In a shared tooltip, all  properties except <code>x</code>, which is common for all points, are kept in  an array, <code>this.points</code>. Another feature that affects what properties are available, is <a href="#plotOptions.series.dataGrouping">dataGrouping</a>.</p>  <p>Available data are:</p> <dl> <dt>this.percentage (not shared) / this.points[i].percentage (shared)</dt> <dd>Stacked series and pies only. The point's percentage of the total.</dd>  <dt>this.point (not shared) / this.points[i].point (shared)</dt> <dd>The point object. The point name, if defined, is available  through <code>this.point.name</code>.</dd>  <dt>this.points</dt> <dd>In a shared tooltip, this is an array containing all other properties for each point.</dd>  <dt>this.series (not shared) / this.points[i].series (shared)</dt> <dd>The series object. The series name is available  through <code>this.series.name</code>.</dd>  <dt>this.total (not shared) / this.points[i].total (shared)</dt> <dd>Stacked series only. The total value at this point's x value.</dd>  <dt>this.x</dt> <dd>The x value. This property is the same regardless of the tooltip being shared or not.</dd>  <dt>this.y (not shared) / this.points[i].y (shared)</dt> <dd>The y value.</dd>  </dl>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The HTML of the tooltip header line. Variables are enclosed by curly brackets. Available variablesare <code>point.key</code>, <code>series.name</code>, <code>series.color</code> and other members from the <code>point</code> and <code>series</code> objects. The <code>point.key</code> variable contains the category name, x value or datetime string depending on the type of axis. For datetime axes, the <code>point.key</code> date format can be set using tooltip.xDateFormat.</p> <p>Defaults to <code>&lt;span style="font-size: 10px"&gt;{point.key}&lt;/span&gt;&lt;br/&gt;</code></p>
		/// </summary>
		public string HeaderFormat { get; set; }
		private string HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding inside the tooltip, in pixels.
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The HTML of the point's line in the tooltip. Variables are enclosed by curly brackets. Available variables are point.x, point.y, point.change, series.name and series.color and other properties on the same form. Furthermore,  point.y can be extended by the tooltip.valuePrefix and tooltip.valueSuffix variables. This can also be overridden for each series, which makes it a good hook for displaying units.</p><p>In <a href="http://www.highcharts.com/docs/chart-design-and-style/style-by-css">styled mode</a>, the dot is colored by a class name rather than the point color.</p>
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function for formatting the HTML output for a single point in the tooltip. Like the <code>pointFormat</code> string, but with more flexibility.
		/// </summary>
		public string PointFormatter { get; set; }
		private string PointFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A callback function to place the tooltip in a default position. The callback receives three parameters: <code>labelWidth</code>, <code>labelHeight</code> and <code>point</code>, where point contains values for <code>plotX</code> and <code>plotY</code> telling where the reference point is in the plot area. Add <code>chart.plotLeft</code> and <code>chart.plotTop</code> to get the full coordinates.</p><p>The return should be an object containing x and y values, for example <code>{ x: 100, y: 100 }</code>.</p>
		/// </summary>
		public string Positioner { get; set; }
		private string Positioner_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the tooltip.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of a symbol to use for the border around the tooltip. In Highstock 1.x, the shape was <code>square</code>. 
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When the tooltip is shared, the entire plot area will capture mouse movement or touch events. Tooltip texts for series types with ordered data (not pie, scatter, flags etc) will be shown in a single bubble. This is recommended for single series charts and for tablet/mobile optimized charts.</p><p>See also <a href="#tooltip.split">tooltip.split</a>, that is better suited for charts with many series, especially line-type series.</p>
		/// </summary>
		public bool? Shared { get; set; }
		private bool? Shared_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Proximity snap for graphs or single points. It defaults to 10 for mouse-powered devices and 25 for touch devices.</p><p>Note that in most cases the whole plot area captures the mouse movement, and in these cases <code>tooltip.snap</code> doesn't make sense. This applies when <a href="#plotOptions.series.stickyTracking">stickyTracking</a> is <code>true</code> (default) and when the tooltip is <a href="#tooltip.shared">shared</a> or <a href="#tooltip.split">split</a>.</p>
		/// </summary>
		public double? Snap { get; set; }
		private double? Snap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Split the tooltip into one label per series, with the header close to the axis. This is recommended over <a href="#tooltip.shared">shared</a> tooltips for charts with multiple line series, generally making them easier to read.
		/// </summary>
		public bool? Split { get; set; }
		private bool? Split_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the tooltip. The tooltip can also be styled through the CSS class <code>.highcharts-tooltip</code>.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Use HTML to render the contents of the tooltip instead of SVG. Using HTML allows advanced formatting like tables and images in the tooltip. It is also recommended for rtl languages as it works around rtl bugs in early Firefox.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// How many decimals to show in each series' y value. This is overridable in each series' tooltip options object. The default is to preserve all decimals.
		/// </summary>
		public double? ValueDecimals { get; set; }
		private double? ValueDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// A string to prepend to each series' y value. Overridable in each series' tooltip options object.
		/// </summary>
		public string ValuePrefix { get; set; }
		private string ValuePrefix_DefaultValue { get; set; }
		 

		/// <summary>
		/// A string to append to each series' y value. Overridable in each series' tooltip options object.
		/// </summary>
		public string ValueSuffix { get; set; }
		private string ValueSuffix_DefaultValue { get; set; }
		 

		/// <summary>
		/// The format for the date in the tooltip header. If data grouping is used, the default is  a smart guess based on how close the closest points are. It is pulled from the #plotOptions.dataGrouping.dateTimeLabelFormats array.
		/// </summary>
		public string XDateFormat { get; set; }
		private string XDateFormat_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Animation.IsDirty()) h.Add("animation",Animation.ToJSON());
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ChangeDecimals != ChangeDecimals_DefaultValue) h.Add("changeDecimals",ChangeDecimals);
			if (DateTimeLabelFormats != DateTimeLabelFormats_DefaultValue) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (FollowTouchMove != FollowTouchMove_DefaultValue) h.Add("followTouchMove",FollowTouchMove);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highstock.AddFunction("TooltipFormatter.formatter", Formatter); }  
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (PointFormatter != PointFormatter_DefaultValue) { h.Add("pointFormatter",PointFormatter); Highstock.AddFunction("TooltipPointFormatter.pointFormatter", PointFormatter); }  
			if (Positioner != Positioner_DefaultValue) { h.Add("positioner",Positioner); Highstock.AddFunction("TooltipPositioner.positioner", Positioner); }  
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (Shared != Shared_DefaultValue) h.Add("shared",Shared);
			if (Snap != Snap_DefaultValue) h.Add("snap",Snap);
			if (Split != Split_DefaultValue) h.Add("split",Split);
			if (Style != Style_DefaultValue) h.Add("style",Style);
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
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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