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
	public partial class PlotOptionsSankey  : BaseObject
	{
		public PlotOptionsSankey()
		{
			ColorByPoint = ColorByPoint_DefaultValue = True;
			CurveFactor = CurveFactor_DefaultValue = 0.33;
			DataLabels = DataLabels_DefaultValue = "";
			LinkOpacity = LinkOpacity_DefaultValue = 0.5;
			NodeWidth = NodeWidth_DefaultValue = 20;
			NodePadding = NodePadding_DefaultValue = 10;
			ShowInLegend = ShowInLegend_DefaultValue = False;
			States = States_DefaultValue = "";
			Tooltip = Tooltip_DefaultValue = "";
			Label = Label_DefaultValue = "";
			AllowPointSelect = AllowPointSelect_DefaultValue = False;
			ShowCheckbox = ShowCheckbox_DefaultValue = False;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Events = Events_DefaultValue = "";
			Point = Point_DefaultValue = "";
			DataLabels = DataLabels_DefaultValue = "";
			States = States_DefaultValue = "";
			StickyTracking = StickyTracking_DefaultValue = True;
			TurboThreshold = TurboThreshold_DefaultValue = 1000;
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			Cursor = Cursor_DefaultValue = PlotOptionsSankeyCursor.Null;
			Description = Description_DefaultValue = "undefined";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			ExposeElementToA11y = ExposeElementToA11y_DefaultValue = null;
			GetExtremesFromAll = GetExtremesFromAll_DefaultValue = false;
			Keys = Keys_DefaultValue = new List<string>();
			LinkedTo = LinkedTo_DefaultValue = "";
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			Selected = Selected_DefaultValue = false;
			ShowInLegend = ShowInLegend_DefaultValue = true;
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = "";
			Visible = Visible_DefaultValue = true;
			Tooltip = Tooltip_DefaultValue = "";
			MinPointLength = MinPointLength_DefaultValue = 0;
			States = States_DefaultValue = "";
			DataLabels = DataLabels_DefaultValue = "";
			StickyTracking = StickyTracking_DefaultValue = False;
			Tooltip = Tooltip_DefaultValue = "";
			ColorByPoint = ColorByPoint_DefaultValue = false;
			Colors = Colors_DefaultValue = new List<string>();
			DataGrouping = DataGrouping_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyColorByPoint ColorByPoint { get; set; }
		private PlotOptionsSankeyColorByPoint ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Higher numbers makes the links in a sankey diagram render more curved.A `curveFactor` of 0 makes the lines straight.
		/// </summary>
		public PlotOptionsSankeyCurveFactor CurveFactor { get; set; }
		private PlotOptionsSankeyCurveFactor CurveFactor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the data labels appearing on top of the nodes and links. Forsankey charts, data labels are visible for the nodes by default, but hidden for links. This is controlled by modifying the `nodeFormat`, andthe `format` that applies to links and is an empty string by default.
		/// </summary>
		public PlotOptionsSankeyDataLabels DataLabels { get; set; }
		private PlotOptionsSankeyDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity for the links between nodes in the sankey diagram.
		/// </summary>
		public PlotOptionsSankeyLinkOpacity LinkOpacity { get; set; }
		private PlotOptionsSankeyLinkOpacity LinkOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of each node in a sankey diagram, or the height in casethe chart is inverted.
		/// </summary>
		public PlotOptionsSankeyNodeWidth NodeWidth { get; set; }
		private PlotOptionsSankeyNodeWidth NodeWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The padding between nodes in a sankey diagram, in pixels.
		/// </summary>
		public PlotOptionsSankeyNodePadding NodePadding { get; set; }
		private PlotOptionsSankeyNodePadding NodePadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyShowInLegend ShowInLegend { get; set; }
		private PlotOptionsSankeyShowInLegend ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyStates States { get; set; }
		private PlotOptionsSankeyStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyTooltip Tooltip { get; set; }
		private PlotOptionsSankeyTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.The series labels currently work with series types having a`graph` or an `area`.Requires the `series-label.js` module.
		/// </summary>
		public PlotOptionsSankeyLabel Label { get; set; }
		private PlotOptionsSankeyLabel Label_DefaultValue { get; set; }
		 

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
		public PlotOptionsSankeyEvents Events { get; set; }
		private PlotOptionsSankeyEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Properties for each single point.
		/// </summary>
		public PlotOptionsSankeyPoint Point { get; set; }
		private PlotOptionsSankeyPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the series data labels, appearing next to each datapoint.In styled mode, the data labels can be styled wtih the `.highcharts-data-label-box` and `.highcharts-data-label` class names ([see example](http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-datalabels)).
		/// </summary>
		public PlotOptionsSankeyDataLabels DataLabels { get; set; }
		private PlotOptionsSankeyDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsSankeyStates States { get; set; }
		private PlotOptionsSankeyStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Sticky tracking of mouse events. When true, the `mouseOut` eventon a series isn't triggered until the mouse moves over another series,or out of the plot area. When false, the `mouseOut` event on aseries is triggered when the mouse leaves the area around the series'graph or markers. This also implies the tooltip when not shared. When`stickyTracking` is false and `tooltip.shared` is false, the tooltip willbe hidden when moving the mouse between series. Defaults to true for lineand area type series, but to false for columns, pies etc.
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// When a series contains a data array that is longer than this, onlyone dimensional arrays of numbers, or two dimensional arrays withx and y values are allowed. Also, only the first point is tested,and the rest are assumed to be the same format. This saves expensivedata checking and indexing in long series. Set it to `0` disable.
		/// </summary>
		public double? TurboThreshold { get; set; }
		private double? TurboThreshold_DefaultValue { get; set; }
		 

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
		public PlotOptionsSankeyCursor Cursor { get; set; }
		private PlotOptionsSankeyCursor Cursor_DefaultValue { get; set; }
		 

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
		/// Whether to use the Y extremes of the total chart width or only thezoomed area when zooming in on parts of the X axis. By default, theY axis adjusts to the min and max of the visible data. Cartesianseries only.
		/// </summary>
		public bool? GetExtremesFromAll { get; set; }
		private bool? GetExtremesFromAll_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

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
		public PlotOptionsSankeyTooltip Tooltip { get; set; }
		private PlotOptionsSankeyTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimal height for a column or width for a bar. By default,0 values are not shown. To visualize a 0 (or close to zero) point,set the minimal point length to a pixel value like 3\. In stackedcolumn charts, minPointLength might not be respected for tightlypacked values.
		/// </summary>
		public double? MinPointLength { get; set; }
		private double? MinPointLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyStates States { get; set; }
		private PlotOptionsSankeyStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyDataLabels DataLabels { get; set; }
		private PlotOptionsSankeyDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyStickyTracking StickyTracking { get; set; }
		private PlotOptionsSankeyStickyTracking StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyTooltip Tooltip { get; set; }
		private PlotOptionsSankeyTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using automatic point colors pulled from the `options.colors`collection, this option determines whether the chart should receiveone color per series or one color per point.
		/// </summary>
		public bool? ColorByPoint { get; set; }
		private bool? ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// A series specific or series type specific color set to apply insteadof the global [colors](#colors) when [colorByPoint](#plotOptions.column.colorByPoint) is true.
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyDataGrouping DataGrouping { get; set; }
		private PlotOptionsSankeyDataGrouping DataGrouping_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (CurveFactor != CurveFactor_DefaultValue) h.Add("curveFactor",CurveFactor);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (LinkOpacity != LinkOpacity_DefaultValue) h.Add("linkOpacity",LinkOpacity);
			if (NodeWidth != NodeWidth_DefaultValue) h.Add("nodeWidth",NodeWidth);
			if (NodePadding != NodePadding_DefaultValue) h.Add("nodePadding",NodePadding);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (TurboThreshold != TurboThreshold_DefaultValue) h.Add("turboThreshold",TurboThreshold);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (ExposeElementToA11y != ExposeElementToA11y_DefaultValue) h.Add("exposeElementToA11y",ExposeElementToA11y);
			if (GetExtremesFromAll != GetExtremesFromAll_DefaultValue) h.Add("getExtremesFromAll",GetExtremesFromAll);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) h.Add("pointDescriptionFormatter",PointDescriptionFormatter);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (Tooltip != Tooltip_DefaultValue) h.Add("tooltip",Tooltip);
			if (MinPointLength != MinPointLength_DefaultValue) h.Add("minPointLength",MinPointLength);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (DataGrouping != DataGrouping_DefaultValue) h.Add("dataGrouping",DataGrouping);
			

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