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
			FooterFormat = FooterFormat_DefaultValue = "false";
			Padding = Padding_DefaultValue = 8;
			Snap = Snap_DefaultValue = 10/25;
			HeaderFormat = HeaderFormat_DefaultValue = "<span style='font-size: 10px'>{point.key}</span><br/>";
			PointFormat = PointFormat_DefaultValue = "<span style='color:{point.color}'>\u25CF</span> {series.name}: <b>{point.y}</b><br/>";
			BackgroundColor = BackgroundColor_DefaultValue = "rgba(247,247,247,0.85)";
			BorderWidth = BorderWidth_DefaultValue = 1;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Style = Style_DefaultValue = new TooltipStyle();
			BorderColor = BorderColor_DefaultValue = "null";
			FollowPointer = FollowPointer_DefaultValue = null;
			FollowTouchMove = FollowTouchMove_DefaultValue = null;
			Formatter = Formatter_DefaultValue = "";
			HideDelay = HideDelay_DefaultValue = 500;
			PointFormatter = PointFormatter_DefaultValue = "";
			Positioner = Positioner_DefaultValue = "";
			Shape = Shape_DefaultValue = TooltipShape.Callout;
			Shared = Shared_DefaultValue = false;
			Split = Split_DefaultValue = null;
			UseHTML = UseHTML_DefaultValue = false;
			ValueDecimals = ValueDecimals_DefaultValue = null;
			ValuePrefix = ValuePrefix_DefaultValue = null;
			ValueSuffix = ValueSuffix_DefaultValue = null;
			XDateFormat = XDateFormat_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Enable or disable the tooltip.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable animation of the tooltip. In slow legacy IE browsersthe animation is disabled by default.</p>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The radius of the rounded border corners.</p>
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For series on a datetime axes, the date format in the tooltip&#39;sheader will by default be guessed based on the closest data points.This member gives the default string representations used foreach unit. For an overview of the replacement codes, see <a href="#Highcharts.dateFormat">dateFormat</a>.</p><p>Defaults to:</p><pre>{    millisecond:"%A, %b %e, %H:%M:%S.%L",    second:"%A, %b %e, %H:%M:%S",    minute:"%A, %b %e, %H:%M",    hour:"%A, %b %e, %H:%M",    day:"%A, %b %e, %Y",    week:"Week from %A, %b %e, %Y",    month:"%B %Y",    year:"%Y"}</pre>
		/// </summary>
		public Hashtable DateTimeLabelFormats { get; set; }
		private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A string to append to the tooltip format.</p>
		/// </summary>
		public string FooterFormat { get; set; }
		private string FooterFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Padding inside the tooltip, in pixels.</p>
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Proximity snap for graphs or single points. It defaults to 10 formouse-powered devices and 25 for touch devices.</p><p>Note that in most cases the whole plot area captures the mousemovement, and in these cases <code>tooltip.snap</code> doesn&#39;t make sense.This applies when <a href="#plotOptions.series.stickyTracking">stickyTracking</a>is <code>true</code> (default) and when the tooltip is <a href="#tooltip.shared">shared</a>or <a href="#tooltip.split">split</a>.</p>
		/// </summary>
		public double? Snap { get; set; }
		private double? Snap_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The HTML of the tooltip header line. Variables are enclosed bycurly brackets. Available variables are <code>point.key</code>, <code>series.name</code>,<code>series.color</code> and other members from the <code>point</code> and <code>series</code>objects. The <code>point.key</code> variable contains the category name, xvalue or datetime string depending on the type of axis. For datetimeaxes, the <code>point.key</code> date format can be set using tooltip.xDateFormat.</p>
		/// </summary>
		public string HeaderFormat { get; set; }
		private string HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The HTML of the point&#39;s line in the tooltip. Variables are enclosedby curly brackets. Available variables are point.x, point.y, series.name and series.color and other properties on the same form. Furthermore,point.y can be extended by the <code>tooltip.valuePrefix</code> and <code>tooltip.valueSuffix</code> variables. This can also be overridden for each series,which makes it a good hook for displaying units.</p><p>In styled mode, the dot is colored by a class name ratherthan the point color.</p>
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The background color or gradient for the tooltip.</p><p>In styled mode, the stroke width is set in the <code>.highcharts-tooltip-box</code> class.</p>
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel width of the tooltip border.</p><p>In styled mode, the stroke width is set in the <code>.highcharts-tooltip-box</code> class.</p>
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to apply a drop shadow to the tooltip.</p>
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the tooltip. The tooltip can also be styled throughthe CSS class <code>.highcharts-tooltip</code>.</p>
		/// </summary>
		public TooltipStyle Style { get; set; }
		private TooltipStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the tooltip border. When <code>null</code>, the border takes thecolor of the corresponding series or point.</p>
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether the tooltip should follow the mouse as it moves across columns,pie slices and other point types with an extent. By default it behavesthis way for scatter, bubble and pie series by override in the <code>plotOptions</code>for those series types.</p><p>For touch moves to behave the same way, <a href="#tooltip.followTouchMove">followTouchMove</a> must be <code>true</code> also.</p>
		/// </summary>
		public bool? FollowPointer { get; set; }
		private bool? FollowPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether the tooltip should follow the finger as it moves on a touchdevice. If this is <code>true</code> and <a href="#chart.panning">chart.panning</a> isset,<code>followTouchMove</code> will take over one-finger touches, so the userneeds to use two fingers for zooming and panning.</p>
		/// </summary>
		public bool? FollowTouchMove { get; set; }
		private bool? FollowTouchMove_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Callback function to format the text of the tooltip from scratch. Return<code>false</code> to disable tooltip for a specific point on series.</p><p>A subset of HTML is supported. Unless <code>useHTML</code> is true, the HTML of thetooltip is parsed and converted to SVG, therefore this isn&#39;t a complete HTMLrenderer. The following tags are supported: <code>&lt;b&gt;</code>, <code>&lt;strong&gt;</code>, <code>&lt;i&gt;</code>, <code>&lt;em&gt;</code>,<code>&lt;br/&gt;</code>, <code>&lt;span&gt;</code>. Spans can be styled with a <code>style</code> attribute,but only text-related CSS that is shared with SVG is handled.</p><p>Since version 2.1 the tooltip can be shared between multiple seriesthrough the <code>shared</code> option. The available data in the formatterdiffer a bit depending on whether the tooltip is shared or not. Ina shared tooltip, all properties except <code>x</code>, which is common forall points, are kept in an array, <code>this.points</code>.</p><p>Available data are:</p><dl><dt>this.percentage (not shared) / this.points[i].percentage (shared)</dt><dd>Stacked series and pies only. The point&#39;s percentage of the total.</dd><dt>this.point (not shared) / this.points[i].point (shared)</dt><dd>The point object. The point name, if defined, is available through<code>this.point.name</code>.</dd><dt>this.points</dt><dd>In a shared tooltip, this is an array containing all other propertiesfor each point.</dd><dt>this.series (not shared) / this.points[i].series (shared)</dt><dd>The series object. The series name is available through<code>this.series.name</code>.</dd><dt>this.total (not shared) / this.points[i].total (shared)</dt><dd>Stacked series only. The total value at this point&#39;s x value.</dd><dt>this.x</dt><dd>The x value. This property is the same regardless of the tooltipbeing shared or not.</dd><dt>this.y (not shared) / this.points[i].y (shared)</dt><dd>The y value.</dd></dl>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The number of milliseconds to wait until the tooltip is hidden whenmouse out from a point or chart.</p>
		/// </summary>
		public double? HideDelay { get; set; }
		private double? HideDelay_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A callback function for formatting the HTML output for a single pointin the tooltip. Like the <code>pointFormat</code> string, but with more flexibility.</p>
		/// </summary>
		public string PointFormatter { get; set; }
		private string PointFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A callback function to place the tooltip in a default position. Thecallback receives three parameters: <code>labelWidth</code>, <code>labelHeight</code> and<code>point</code>, where point contains values for <code>plotX</code> and <code>plotY</code> tellingwhere the reference point is in the plot area. Add <code>chart.plotLeft</code>and <code>chart.plotTop</code> to get the full coordinates.</p><p>The return should be an object containing x and y values, for example<code>{ x: 100, y: 100 }</code>.</p>
		/// </summary>
		public string Positioner { get; set; }
		private string Positioner_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The name of a symbol to use for the border around the tooltip.</p>
		/// </summary>
		public TooltipShape Shape { get; set; }
		private TooltipShape Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When the tooltip is shared, the entire plot area will capture mousemovement or touch events. Tooltip texts for series types with ordereddata (not pie, scatter, flags etc) will be shown in a single bubble.This is recommended for single series charts and for tablet/mobileoptimized charts.</p><p>See also <a href="#tooltip.split">tooltip.split</a>, that is better suited forcharts with many series, especially line-type series.</p>
		/// </summary>
		public bool? Shared { get; set; }
		private bool? Shared_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Split the tooltip into one label per series, with the header closeto the axis. This is recommended over <a href="#tooltip.shared">shared</a> tooltipsfor charts with multiple line series, generally making them easierto read.</p>
		/// </summary>
		public bool? Split { get; set; }
		private bool? Split_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Use HTML to render the contents of the tooltip instead of SVG. UsingHTML allows advanced formatting like tables and images in the tooltip.It is also recommended for rtl languages as it works around rtlbugs in early Firefox.</p>
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>How many decimals to show in each series&#39; y value. This is overridablein each series&#39; tooltip options object. The default is to preserveall decimals.</p>
		/// </summary>
		public double? ValueDecimals { get; set; }
		private double? ValueDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A string to prepend to each series&#39; y value. Overridable in eachseries&#39; tooltip options object.</p>
		/// </summary>
		public string ValuePrefix { get; set; }
		private string ValuePrefix_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A string to append to each series&#39; y value. Overridable in each series&#39;tooltip options object.</p>
		/// </summary>
		public string ValueSuffix { get; set; }
		private string ValueSuffix_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The format for the date in the tooltip header if the X axis is adatetime axis. The default is a best guess based on the smallestdistance between points in the chart.</p>
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
			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (FollowTouchMove != FollowTouchMove_DefaultValue) h.Add("followTouchMove",FollowTouchMove);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highcharts.AddFunction("TooltipFormatter.formatter", Formatter); }  
			if (HideDelay != HideDelay_DefaultValue) h.Add("hideDelay",HideDelay);
			if (PointFormatter != PointFormatter_DefaultValue) { h.Add("pointFormatter",PointFormatter); Highcharts.AddFunction("TooltipPointFormatter.pointFormatter", PointFormatter); }  
			if (Positioner != Positioner_DefaultValue) { h.Add("positioner",Positioner); Highcharts.AddFunction("TooltipPositioner.positioner", Positioner); }  
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