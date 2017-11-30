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
	public partial class FunnelSeries  : Series
	{
		public FunnelSeries()
		{
			Sunburst = Sunburst_DefaultValue = "";
			Wordcloud = Wordcloud_DefaultValue = "";
			Id = Id_DefaultValue = "";
			Index = Index_DefaultValue = null;
			LegendIndex = LegendIndex_DefaultValue = null;
			Name = Name_DefaultValue = "";
			Type = Type_DefaultValue = "";
			ZIndex = ZIndex_DefaultValue = null;
			Label = Label_DefaultValue = "";
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Events = Events_DefaultValue = "";
			Point = Point_DefaultValue = "";
			DataLabels = DataLabels_DefaultValue = "";
			States = States_DefaultValue = "";
			StickyTracking = StickyTracking_DefaultValue = True;
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			Cursor = Cursor_DefaultValue = "";
			Description = Description_DefaultValue = "undefined";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			ExposeElementToA11y = ExposeElementToA11y_DefaultValue = null;
			Keys = Keys_DefaultValue = new List<string>();
			Linecap = Linecap_DefaultValue = "round";
			LinkedTo = LinkedTo_DefaultValue = "";
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShowInLegend = ShowInLegend_DefaultValue = true;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = "";
			Visible = Visible_DefaultValue = true;
			Tooltip = Tooltip_DefaultValue = "";
			BorderWidth = BorderWidth_DefaultValue = 1;
			Linecap = Linecap_DefaultValue = "round";
			Center = Center_DefaultValue = new string[] { "50%", "50%" };
			Clip = Clip_DefaultValue = False;
			DataLabels = DataLabels_DefaultValue = "";
			IgnoreHiddenPoint = IgnoreHiddenPoint_DefaultValue = true;
			ShowInLegend = ShowInLegend_DefaultValue = False;
			SlicedOffset = SlicedOffset_DefaultValue = 10;
			StickyTracking = StickyTracking_DefaultValue = False;
			Tooltip = Tooltip_DefaultValue = "";
			BorderColor = BorderColor_DefaultValue = "#ffffff";
			BorderWidth = BorderWidth_DefaultValue = 1;
			States = States_DefaultValue = "";
			Colors = Colors_DefaultValue = new List<string>();
			EndAngle = EndAngle_DefaultValue = null;
			InnerSize = InnerSize_DefaultValue = "0";
			MinSize = MinSize_DefaultValue = 80;
			StartAngle = StartAngle_DefaultValue = 0;
			Events = Events_DefaultValue = "";
			Point = Point_DefaultValue = "";
			Depth = Depth_DefaultValue = 0;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Center = Center_DefaultValue = new string[] { "50%", "50%" };
			Width = Width_DefaultValue = 90%;
			NeckWidth = NeckWidth_DefaultValue = 30%;
			Height = Height_DefaultValue = 100%;
			NeckHeight = NeckHeight_DefaultValue = 25%;
			Reversed = Reversed_DefaultValue = false;
			DataLabels = DataLabels_DefaultValue = "";
			States = States_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// A `sunburst` series. If the [type](#series.sunburst.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.sunburst](#plotOptions.sunburst).
		/// </summary>
		public FunnelSeriesSunburst Sunburst { get; set; }
		private FunnelSeriesSunburst Sunburst_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `wordcloud` series. If the [type](#series.wordcloud.type) option isnot specified, it is inherited from [chart.type](#chart.type).For options that apply to multiple series, it is recommended to addthem to the [plotOptions.series](#plotOptions.series) options structure.To apply to all series of this specific type, apply it to [plotOptions.wordcloud](#plotOptions.wordcloud).
		/// </summary>
		public FunnelSeriesWordcloud Wordcloud { get; set; }
		private FunnelSeriesWordcloud Wordcloud_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the series. This can be used after render time to get apointer to the series object through `chart.get()`.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// The index of the series in the chart, affecting the internal indexin the `chart.series` array, the visible Z index as well as the orderin the legend.
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sequential index of the series in the legend.
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The type of series, for example `line` or `column`.
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// Define the visual z index of the series.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.Requires the `series-label.js` module.
		/// </summary>
		public FunnelSeriesLabel Label { get; set; }
		private FunnelSeriesLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow this series' points to be selected by clicking on the graphic (columns, point markers, pie slices, map areas etc).
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allowselecting the series. The state of the checkbox is determined bythe `selected` option.
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see [chart.animation](#chart.animation) and the animation parameter under the API methods. Thefollowing properties are supported:<dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>A string reference to an easing function set on the `Math` object.See the _Custom easing function_ demo below.</dd></dl>Due to poor performance, animation is disabled in old IE browsersfor several chart types.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// General event handlers for the series items. These event hooks can alsobe attached to the series at run time using the `Highcharts.addEvent`function.
		/// </summary>
		public FunnelSeriesEvents Events { get; set; }
		private FunnelSeriesEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public FunnelSeriesPoint Point { get; set; }
		private FunnelSeriesPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the series data labels, appearing next to each datapoint.In styled mode, the data labels can be styled wtih the `.highcharts-data-label-box` and `.highcharts-data-label` class names ([see example](http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-datalabels)).
		/// </summary>
		public FunnelSeriesDataLabels DataLabels { get; set; }
		private FunnelSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public FunnelSeriesStates States { get; set; }
		private FunnelSeriesStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` eventon a series isn't triggered until the mouse moves over another series,or out of the plot area. When false, the `mouseOut` event on aseries is triggered when the mouse leaves the area around the series'graph or markers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltip willbe hidden when moving the mouse between series. Defaults to true for lineand area type series, but to false for columns, pies etc.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// A class name to apply to the series' graphical elements.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the series. In line type series it applies to theline and the point markers unless otherwise specified. In bar typeseries it applies to the bars unless a color is specified per point.The default value is pulled from the `options.colors` array.In styled mode, the color can be defined by the[colorIndex](#plotOptions.series.colorIndex) option. Also, the seriescolor can be set with the `.highcharts-series`, `.highcharts-color-{n}`,`.highcharts-{type}-series` or `.highcharts-series-{n}` class, orindividual classes given by the `className` option.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styled mode only. A specific color index to use for the series, so itsgraphic representations are given the class name `highcharts-color-{n}`.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// You can set the cursor to "pointer" if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.
		/// </summary>
		public string Cursor { get; set; }
		private string Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Requires the Accessibility module.A description of the series to add to the screen reader informationabout the series.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// By default, series are exposed to screen readers as regions. By enablingthis option, the series element itself will be exposed in the sameway as the data points. This is useful if the series is not usedas a grouping entity in the chart, but you still want to attach adescription to the series.Requires the Accessibility module.
		/// </summary>
		public bool? ExposeElementToA11y { get; set; }
		private bool? ExposeElementToA11y_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line cap used for line ends and line joins on the graph.
		/// </summary>
		public string Linecap { get; set; }
		private string Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [id](#series.id) of another series to link to. Additionally,the value can be ":previous" to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Same as [accessibility.pointDescriptionFormatter](#accessibility.pointDescriptionFormatter), but for an individual series. Overridesthe chart wide configuration.
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to select the series initially. If `showCheckbox` is true,the checkbox next to the series name in the legend will be checked for aselected series.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 the shadowcan be an object configuration containing `color`, `offsetX`, `offsetY`, `opacity` and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in the legend.The default value is `true` for standalone series, `false` for linkedseries.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// If set to `True`, the accessibility module will skip past the pointsin this series for keyboard navigation.
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		private bool? SkipKeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the initial visibility of the series.
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series.Properties are inherited from [tooltip](#tooltip), but only thefollowing properties can be defined on a series level.
		/// </summary>
		public FunnelSeriesTooltip Tooltip { get; set; }
		private FunnelSeriesTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width of each map area.In styled mode, the border stroke width is given in the `.highcharts-point` class.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The SVG value used for the `stroke-linecap` and `stroke-linejoin`of a line graph. Round means that lines are rounded in the ends andbends.
		/// </summary>
		public string Linecap { get; set; }
		private string Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The center of the pie chart relative to the plot area. Can be percentagesor pixel values. The default behaviour (as of 3.0) is to centerthe pie so that all slices and data labels are within the plot area.As a consequence, the pie may actually jump around in a chart withdynamic values, as the data labels move. In that case, the centershould be explicitly set, for example to `["50%", "50%"]`.
		/// </summary>
		public string[] Center { get; set; }
		private string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public FunnelSeriesClip Clip { get; set; }
		private FunnelSeriesClip Clip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public FunnelSeriesDataLabels DataLabels { get; set; }
		private FunnelSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Equivalent to [chart.ignoreHiddenSeries](#chart.ignoreHiddenSeries),this option tells whether the series shall be redrawn as if thehidden point were `null`.The default value changed from `false` to `true` with Highcharts3.0.
		/// </summary>
		public bool? IgnoreHiddenPoint { get; set; }
		private bool? IgnoreHiddenPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display this particular series or series type in thelegend. Since 2.1, pies are not shown in the legend by default.
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// If a point is sliced, moved out from the center, how many pixelsshould it be moved?.
		/// </summary>
		public double? SlicedOffset { get; set; }
		private double? SlicedOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` eventon a series isn't triggered until the mouse moves over another series,or out of the plot area. When false, the `mouseOut` event on aseries is triggered when the mouse leaves the area around the series'graph or markers. This also implies the tooltip. When `stickyTracking`is false and `tooltip.shared` is false, the tooltip will be hiddenwhen moving the mouse between series.
		/// </summary>
		public FunnelSeriesStickyTracking StickyTracking { get; set; }
		private FunnelSeriesStickyTracking StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public FunnelSeriesTooltip Tooltip { get; set; }
		private FunnelSeriesTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border surrounding each slice. When `null`, theborder takes the same color as the slice fill. This can be usedtogether with a `borderWidth` to fill drawing gaps created by antialiazingartefacts in borderless pies.In styled mode, the border stroke is given in the `.highcharts-point` class.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border surrounding each slice.When setting the border width to 0, there may be small gaps betweenthe slices due to SVG antialiasing artefacts. To work around this,keep the border width at 0.5 or 1, but set the `borderColor` to`null` instead.In styled mode, the border stroke width is given in the `.highcharts-point` class.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public FunnelSeriesStates States { get; set; }
		private FunnelSeriesStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to use insteadof the global [colors](#colors).
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end angle of the pie in degrees where 0 is top and 90 is right.Defaults to `startAngle` plus 360.
		/// </summary>
		public double? EndAngle { get; set; }
		private double? EndAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The size of the inner diameter for the pie. A size greater than 0renders a donut chart. Can be a percentage or pixel value. Percentagesare relative to the pie size. Pixel values are given as integers.Note: in Highcharts < 4.1.2, the percentage was relative to the plotarea, not the pie size.
		/// </summary>
		public string InnerSize { get; set; }
		private string InnerSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum size for a pie in response to auto margins. The pie willtry to shrink to make room for data labels in side the plot area, but only to this size.
		/// </summary>
		public double? MinSize { get; set; }
		private double? MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start angle of the pie slices in degrees where 0 is top and 90right.
		/// </summary>
		public double? StartAngle { get; set; }
		private double? StartAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public FunnelSeriesEvents Events { get; set; }
		private FunnelSeriesEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public FunnelSeriesPoint Point { get; set; }
		private FunnelSeriesPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// The thickness of a 3D pie. Requires `highcharts-3d.js`
		/// </summary>
		public double? Depth { get; set; }
		private double? Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Initial animation is by default disabled for the funnel chart.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The center of the series. By default, it is centered in the middleof the plot area, so it fills the plot area height.
		/// </summary>
		public string[] Center { get; set; }
		private string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the funnel compared to the width of the plot area,or the pixel width if it is a number.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the neck, the lower part of the funnel. A number definespixel width, a percentage string defines a percentage of the plotarea width.
		/// </summary>
		public double? NeckWidth { get; set; }
		private double? NeckWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the funnel or pyramid. If it is a number it definesthe pixel height, if it is a percentage string it is the percentageof the plot area height.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the neck, the lower part of the funnel. A number definespixel width, a percentage string defines a percentage of the plotarea height.
		/// </summary>
		public double? NeckHeight { get; set; }
		private double? NeckHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// A reversed funnel has the widest area down. A reversed funnel withno neck width and neck height is a pyramid.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public FunnelSeriesDataLabels DataLabels { get; set; }
		private FunnelSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the series states.
		/// </summary>
		public FunnelSeriesStates States { get; set; }
		private FunnelSeriesStates States_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Sunburst.IsDirty()) h.Add("sunburst",Sunburst.ToHashtable());
			if (Wordcloud.IsDirty()) h.Add("wordcloud",Wordcloud.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (ExposeElementToA11y != ExposeElementToA11y_DefaultValue) h.Add("exposeElementToA11y",ExposeElementToA11y);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (Linecap != Linecap_DefaultValue) h.Add("linecap",Linecap);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) h.Add("pointDescriptionFormatter",PointDescriptionFormatter);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (Tooltip != Tooltip_DefaultValue) h.Add("tooltip",Tooltip);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Linecap != Linecap_DefaultValue) h.Add("linecap",Linecap);
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (IgnoreHiddenPoint != IgnoreHiddenPoint_DefaultValue) h.Add("ignoreHiddenPoint",IgnoreHiddenPoint);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SlicedOffset != SlicedOffset_DefaultValue) h.Add("slicedOffset",SlicedOffset);
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (EndAngle != EndAngle_DefaultValue) h.Add("endAngle",EndAngle);
			if (InnerSize != InnerSize_DefaultValue) h.Add("innerSize",InnerSize);
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (StartAngle != StartAngle_DefaultValue) h.Add("startAngle",StartAngle);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (Depth != Depth_DefaultValue) h.Add("depth",Depth);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (NeckWidth != NeckWidth_DefaultValue) h.Add("neckWidth",NeckWidth);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (NeckHeight != NeckHeight_DefaultValue) h.Add("neckHeight",NeckHeight);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			

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