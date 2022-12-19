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
	public partial class Tooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Tooltip()
		{
			Animation = Animation_DefaultValue = new Animation();
			BackgroundColor = BackgroundColor_DefaultValue = "";
			BorderColor = BorderColor_DefaultValue = "";
			BorderRadius = BorderRadius_DefaultValue = 3;
			BorderWidth = BorderWidth_DefaultValue = 1;
			ClassName = ClassName_DefaultValue = "";
			ClusterFormat = ClusterFormat_DefaultValue = "Clustered points: {point.clusterPointsAmount}";
			Crosshairs = Crosshairs_DefaultValue = new List<Crosshair>();
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = new Hashtable();
			Distance = Distance_DefaultValue = 16;
			Enabled = Enabled_DefaultValue = true;
			FollowPointer = FollowPointer_DefaultValue = null;
			FollowTouchMove = FollowTouchMove_DefaultValue = null;
			FooterFormat = FooterFormat_DefaultValue = "";
			Formatter = Formatter_DefaultValue = "";
			HeaderFormat = HeaderFormat_DefaultValue = "";
			HeaderShape = HeaderShape_DefaultValue = TooltipHeaderShape.Callout;
			HideDelay = HideDelay_DefaultValue = 500;
			NullFormat = NullFormat_DefaultValue = "";
			NullFormatter = NullFormatter_DefaultValue = "";
			Outside = Outside_DefaultValue = null;
			Padding = Padding_DefaultValue = 8;
			PointFormat = PointFormat_DefaultValue = "";
			PointFormatter = PointFormatter_DefaultValue = "";
			Positioner = Positioner_DefaultValue = "";
			Shadow = Shadow_DefaultValue = new Shadow();
			ShadowBool = ShadowBool_DefaultValue = true;
			Shape = Shape_DefaultValue = "callout";
			Shared = Shared_DefaultValue = false;
			Snap = Snap_DefaultValue = null;
			Split = Split_DefaultValue = null;
			StickOnContact = StickOnContact_DefaultValue = false;
			Style = Style_DefaultValue = new Hashtable();
			UseHTML = UseHTML_DefaultValue = false;
			ValueDecimals = ValueDecimals_DefaultValue = null;
			ValuePrefix = ValuePrefix_DefaultValue = "";
			ValueSuffix = ValueSuffix_DefaultValue = "";
			XDateFormat = XDateFormat_DefaultValue = "";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Enable or disable animation of the tooltip.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color or gradient for the tooltip.In styled mode, the stroke width is set in the`.highcharts-tooltip-box` class.
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the tooltip border. When `undefined`, the border takesthe color of the corresponding series or point.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius of the rounded border corners.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the tooltip border.In styled mode, the stroke width is set in the`.highcharts-tooltip-box` class.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A CSS class name to apply to the tooltip's container div,allowing unique CSS styling for each chart.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML of the cluster point's in the tooltip. Works only withmarker-clusters module and analogously to[pointFormat](#tooltip.pointFormat).The cluster tooltip can be also formatted using`tooltip.formatter` callback function and `point.isCluster` flag.
		/// </summary>
		public string ClusterFormat { get; set; }
		private string ClusterFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Since 4.1, the crosshair definitions are moved to the Axis objectin order for a better separation from the tooltip. See[xAxis.crosshair](#xAxis.crosshair).
		/// </summary>
		public List<Crosshair> Crosshairs { get; set; }
		private List<Crosshair> Crosshairs_DefaultValue { get; set; }
		 

		/// <summary>
		/// For series on datetime axes, the date format in the tooltip'sheader will by default be guessed based on the closest data points.This member gives the default string representations used foreach unit. For an overview of the replacement codes, see[dateFormat](/class-reference/Highcharts.Time#dateFormat).
		/// </summary>
		public Hashtable DateTimeLabelFormats { get; set; }
		private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// Distance from point to tooltip in pixels.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the tooltip.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should follow the mouse as it moves acrosscolumns, pie slices and other point types with an extent.By default it behaves this way for pie, polygon, map, sankeyand wordcloud series by override in the `plotOptions`for those series types.Does not apply if [split](#tooltip.split) is `true`.For touch moves to behave the same way, [followTouchMove](#tooltip.followTouchMove) must be `true` also.
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
		/// Callback function to format the text of the tooltip from scratch. Incase of single or [shared](#tooltip.shared) tooltips, a string shouldbe returned. In case of [split](#tooltip.split) tooltips, it shouldreturn an array where the first item is the header, and subsequentitems are mapped to the points. Return `false` to disable tooltip fora specific point on series.A subset of HTML is supported. Unless `useHTML` is true, the HTML ofthe tooltip is parsed and converted to SVG, therefore this isn't acomplete HTML renderer. The following HTML tags are supported: `b`,`br`, `em`, `i`, `span`, `strong`. Spans can be styled with a `style`attribute, but only text-related CSS, that is shared with SVG, ishandled.The available data in the formatter differ a bit depending on whetherthe tooltip is shared or split, or belongs to a single point. In ashared/split tooltip, all properties except `x`, which is common forall points, are kept in an array, `this.points`.Available data are:- **this.percentage (not shared) /**  **this.points[i].percentage (shared)**:  Stacked series and pies only. The point's percentage of the total.- **this.point (not shared) / this.points[i].point (shared)**:  The point object. The point name, if defined, is available through  `this.point.name`.- **this.points**:  In a shared tooltip, this is an array containing all other  properties for each point.- **this.series (not shared) / this.points[i].series (shared)**:  The series object. The series name is available through  `this.series.name`.- **this.total (not shared) / this.points[i].total (shared)**:  Stacked series only. The total value at this point's x value.- **this.x**:  The x value. This property is the same regardless of the tooltip  being shared or not.- **this.y (not shared) / this.points[i].y (shared)**:  The y value.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML of the tooltip header line. Variables are enclosed bycurly brackets. Available variables are `point.key`, `series.name`,`series.color` and other members from the `point` and `series`objects. The `point.key` variable contains the category name, xvalue or datetime string depending on the type of axis. For datetimeaxes, the `point.key` date format can be set using`tooltip.xDateFormat`.
		/// </summary>
		public string HeaderFormat { get; set; }
		private string HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of a symbol to use for the border around the tooltipheader. Applies only when [tooltip.split](#tooltip.split) isenabled.Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols` the same way as for[series.marker.symbol](plotOptions.line.marker.symbol).
		/// </summary>
		public TooltipHeaderShape HeaderShape { get; set; }
		private TooltipHeaderShape HeaderShape_DefaultValue { get; set; }
		 

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
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML of the point's line in the tooltip. Variables are enclosedby curly brackets. Available variables are `point.x`, `point.y`,`series.name` and `series.color` and other properties on the sameform. Furthermore, `point.y` can be extended by the`tooltip.valuePrefix` and `tooltip.valueSuffix` variables. This canalso be overridden for each series, which makes it a good hook fordisplaying units.In styled mode, the dot is colored by a class name ratherthan the point color.
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function for formatting the HTML output for a single pointin the tooltip. Like the `pointFormat` string, but with moreflexibility.
		/// </summary>
		public string PointFormatter { get; set; }
		private string PointFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function to place the tooltip in a custom position. Thecallback receives three parameters: `labelWidth`, `labelHeight` and`point`, where point contains values for `plotX` and `plotY` tellingwhere the reference point is in the plot area. Add `chart.plotLeft`and `chart.plotTop` to get the full coordinates.To find the actual hovered `Point` instance, use`this.chart.hoverPoint`. For shared or split tooltips, all the hoverpoints are available in `this.chart.hoverPoints`.Since v7, when [tooltip.split](#tooltip.split) option is enabled,positioner is called for each of the boxes separately, includingxAxis header. xAxis header is not a point, instead `point` argumentcontains info: `{ plotX: Number, plotY: Number, isHeader: Boolean }`The return should be an object containing x and y values, for example`{ x: 100, y: 100 }`.
		/// </summary>
		public string Positioner { get; set; }
		private string Positioner_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the tooltip.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the tooltip.
		/// </summary>
		public bool? ShadowBool { get; set; }
		private bool? ShadowBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of a symbol to use for the border around the tooltip. Canbe one of: `"callout"`, `"circle"` or `"rect"`. When[tooltip.split](#tooltip.split)option is enabled, shape is applied to all boxes except header, whichis controlled by[tooltip.headerShape](#tooltip.headerShape).Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols` the same way as for[series.marker.symbol](plotOptions.line.marker.symbol).
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the tooltip is shared, the entire plot area will capture mousemovement or touch events. Tooltip texts for series types with ordereddata (not pie, scatter, flags etc) will be shown in a single bubble.This is recommended for single series charts and for tablet/mobileoptimized charts.See also [tooltip.split](#tooltip.split), that is better suited forcharts with many series, especially line-type series. The`tooltip.split` option takes precedence over `tooltip.shared`.
		/// </summary>
		public bool? Shared { get; set; }
		private bool? Shared_DefaultValue { get; set; }
		 

		/// <summary>
		/// Proximity snap for graphs or single points. It defaults to 10 formouse-powered devices and 25 for touch devices.Note that in most cases the whole plot area captures the mousemovement, and in these cases `tooltip.snap` doesn't make sense. Thisapplies when [stickyTracking](#plotOptions.series.stickyTracking)is `true` (default) and when the tooltip is [shared](#tooltip.shared)or [split](#tooltip.split).
		/// </summary>
		public double? Snap { get; set; }
		private double? Snap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Split the tooltip into one label per series, with the header closeto the axis. This is recommended over [shared](#tooltip.shared)tooltips for charts with multiple line series, generally making themeasier to read. This option takes precedence over `tooltip.shared`.
		/// </summary>
		public bool? Split { get; set; }
		private bool? Split_DefaultValue { get; set; }
		 

		/// <summary>
		/// Prevents the tooltip from switching or closing when touched orpointed.
		/// </summary>
		public bool? StickOnContact { get; set; }
		private bool? StickOnContact_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the tooltip. The tooltip can also be styled throughthe CSS class `.highcharts-tooltip`.Note that the default `pointerEvents` style makes the tooltip ignoremouse events, so in order to use clickable tooltips, this value mustbe set to `auto`.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Use HTML to render the contents of the tooltip instead of SVG. UsingHTML allows advanced formatting like tables and images in thetooltip. It is also recommended for rtl languages as it works aroundrtl bugs in early Firefox.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

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
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Animation.IsDirty(highcharts)) h.Add("animation",Animation.ToHashtable(highcharts));
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (ClusterFormat != ClusterFormat_DefaultValue) h.Add("clusterFormat",ClusterFormat);
			if (Crosshairs != Crosshairs_DefaultValue) h.Add("crosshairs",Crosshairs);
			if (DateTimeLabelFormats != DateTimeLabelFormats_DefaultValue) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (FollowTouchMove != FollowTouchMove_DefaultValue) h.Add("followTouchMove",FollowTouchMove);
			if (FooterFormat != FooterFormat_DefaultValue) h.Add("footerFormat",FooterFormat);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); highcharts.AddFunction("formatter", Formatter); }  
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (HeaderShape != HeaderShape_DefaultValue) h.Add("headerShape", highcharts.FirstCharacterToLower(HeaderShape.ToString()));
			if (HideDelay != HideDelay_DefaultValue) h.Add("hideDelay",HideDelay);
			if (NullFormat != NullFormat_DefaultValue) h.Add("nullFormat",NullFormat);
			if (NullFormatter != NullFormatter_DefaultValue) { h.Add("nullFormatter",NullFormatter); highcharts.AddFunction("nullFormatter", NullFormatter); }  
			if (Outside != Outside_DefaultValue) h.Add("outside",Outside);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (PointFormatter != PointFormatter_DefaultValue) { h.Add("pointFormatter",PointFormatter); highcharts.AddFunction("pointFormatter", PointFormatter); }  
			if (Positioner != Positioner_DefaultValue) { h.Add("positioner",Positioner); highcharts.AddFunction("positioner", Positioner); }  
			if (Shadow.IsDirty(highcharts)) h.Add("shadow",Shadow.ToHashtable(highcharts));
			if (ShadowBool != ShadowBool_DefaultValue) h.Add("shadow",ShadowBool);
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (Shared != Shared_DefaultValue) h.Add("shared",Shared);
			if (Snap != Snap_DefaultValue) h.Add("snap",Snap);
			if (Split != Split_DefaultValue) h.Add("split",Split);
			if (StickOnContact != StickOnContact_DefaultValue) h.Add("stickOnContact",StickOnContact);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (ValueDecimals != ValueDecimals_DefaultValue) h.Add("valueDecimals",ValueDecimals);
			if (ValuePrefix != ValuePrefix_DefaultValue) h.Add("valuePrefix",ValuePrefix);
			if (ValueSuffix != ValueSuffix_DefaultValue) h.Add("valueSuffix",ValueSuffix);
			if (XDateFormat != XDateFormat_DefaultValue) h.Add("xDateFormat",XDateFormat);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}