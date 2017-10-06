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
	public partial class PlotOptionsFunnel  : BaseObject
	{
		public PlotOptionsFunnel()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Center = Center_DefaultValue = new string[] { "50%", "50%" };
			Width = Width_DefaultValue = "90%";
			NeckWidth = NeckWidth_DefaultValue = "30%";
			Height = Height_DefaultValue = "100%";
			NeckHeight = NeckHeight_DefaultValue = "25%";
			Reversed = Reversed_DefaultValue = false;
			DataLabels = DataLabels_DefaultValue = new PlotOptionsFunnelDataLabels();
			States = States_DefaultValue = new PlotOptionsFunnelStates();
			Clip = Clip_DefaultValue = null;
			IgnoreHiddenPoint = IgnoreHiddenPoint_DefaultValue = true;
			ShowInLegend = ShowInLegend_DefaultValue = null;
			SlicedOffset = SlicedOffset_DefaultValue = 10;
			StickyTracking = StickyTracking_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = new PlotOptionsFunnelTooltip();
			BorderColor = BorderColor_DefaultValue = "#ffffff";
			BorderWidth = BorderWidth_DefaultValue = 1;
			Colors = Colors_DefaultValue = new List<string>();
			EndAngle = EndAngle_DefaultValue = null;
			InnerSize = InnerSize_DefaultValue = "0";
			MinSize = MinSize_DefaultValue = 80;
			StartAngle = StartAngle_DefaultValue = 0;
			Events = Events_DefaultValue = new PlotOptionsFunnelEvents();
			Point = Point_DefaultValue = new PlotOptionsFunnelPoint();
			Depth = Depth_DefaultValue = 0;
			Linecap = Linecap_DefaultValue = PlotOptionsFunnelLinecap.Round;
			Label = Label_DefaultValue = new PlotOptionsFunnelLabel();
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			ClassName = ClassName_DefaultValue = null;
			Color = Color_DefaultValue = null;
			ColorIndex = ColorIndex_DefaultValue = null;
			Cursor = Cursor_DefaultValue = PlotOptionsFunnelCursor.Null;
			Description = Description_DefaultValue = "undefined";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			ExposeElementToA11y = ExposeElementToA11y_DefaultValue = null;
			Keys = Keys_DefaultValue = new List<string>();
			LinkedTo = LinkedTo_DefaultValue = null;
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			Visible = Visible_DefaultValue = true;
			
		}	
		

		/// <summary>
		/// <p>Initial animation is by default disabled for the funnel chart.</p>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The center of the series. By default, it is centered in the middleof the plot area, so it fills the plot area height.</p>
		/// </summary>
		public string[] Center { get; set; }
		private string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the funnel compared to the width of the plot area,or the pixel width if it is a number.</p>
		/// </summary>
		public string Width { get; set; }
		private string Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the neck, the lower part of the funnel. A number definespixel width, a percentage string defines a percentage of the plotarea width.</p>
		/// </summary>
		public string NeckWidth { get; set; }
		private string NeckWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The height of the funnel or pyramid. If it is a number it definesthe pixel height, if it is a percentage string it is the percentageof the plot area height.</p>
		/// </summary>
		public string Height { get; set; }
		private string Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The height of the neck, the lower part of the funnel. A number definespixel width, a percentage string defines a percentage of the plotarea height.</p>
		/// </summary>
		public string NeckHeight { get; set; }
		private string NeckHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A reversed funnel has the widest area down. A reversed funnel withno neck width and neck height is a pyramid.</p>
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the series data labels, appearing next to each datapoint.</p><p>In styled mode, the data labels can be styled wtih the <code>.highcharts-data-label-box</code> and <code>.highcharts-data-label</code> class names (<a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/series-datalabels">see example</a>).</p>
		/// </summary>
		public PlotOptionsFunnelDataLabels DataLabels { get; set; }
		private PlotOptionsFunnelDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the series states.</p>
		/// </summary>
		public PlotOptionsFunnelStates States { get; set; }
		private PlotOptionsFunnelStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Clip { get; set; }
		private bool? Clip_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Equivalent to <a href="#chart.ignoreHiddenSeries">chart.ignoreHiddenSeries</a>,this option tells whether the series shall be redrawn as if thehidden point were <code>null</code>.</p><p>The default value changed from <code>false</code> to <code>true</code> with Highcharts3.0.</p>
		/// </summary>
		public bool? IgnoreHiddenPoint { get; set; }
		private bool? IgnoreHiddenPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to display this particular series or series type in thelegend. Since 2.1, pies are not shown in the legend by default.</p>
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If a point is sliced, moved out from the center, how many pixelsshould it be moved?.</p>
		/// </summary>
		public double? SlicedOffset { get; set; }
		private double? SlicedOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Sticky tracking of mouse events. When true, the <code>mouseOut</code> eventon a series isn&#39;t triggered until the mouse moves over another series,or out of the plot area. When false, the <code>mouseOut</code> event on aseries is triggered when the mouse leaves the area around the series&#39;graph or markers. This also implies the tooltip. When <code>stickyTracking</code>is false and <code>tooltip.shared</code> is false, the tooltip will be hiddenwhen moving the mouse between series.</p>
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A configuration object for the tooltip rendering of each single series.Properties are inherited from <a href="#tooltip">tooltip</a>, but only thefollowing properties can be defined on a series level.</p>
		/// </summary>
		public PlotOptionsFunnelTooltip Tooltip { get; set; }
		private PlotOptionsFunnelTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the border surrounding each slice. When <code>null</code>, theborder takes the same color as the slice fill. This can be usedtogether with a <code>borderWidth</code> to fill drawing gaps created by antialiazingartefacts in borderless pies.</p><p>In styled mode, the border stroke is given in the <code>.highcharts-point</code> class.</p>
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the border surrounding each slice.</p><p>When setting the border width to 0, there may be small gaps betweenthe slices due to SVG antialiasing artefacts. To work around this,keep the border width at 0.5 or 1, but set the <code>borderColor</code> to<code>null</code> instead.</p><p>In styled mode, the border stroke width is given in the <code>.highcharts-point</code> class.</p>
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A series specific or series type specific color set to use insteadof the global <a href="#colors">colors</a>.</p>
		/// </summary>
		public List<string> Colors { get; set; }
		private List<string> Colors_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The end angle of the pie in degrees where 0 is top and 90 is right.Defaults to <code>startAngle</code> plus 360.</p>
		/// </summary>
		public double? EndAngle { get; set; }
		private double? EndAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The size of the inner diameter for the pie. A size greater than 0renders a donut chart. Can be a percentage or pixel value. Percentagesare relative to the pie size. Pixel values are given as integers.</p><p>Note: in Highcharts &lt; 4.1.2, the percentage was relative to the plotarea, not the pie size.</p>
		/// </summary>
		public string InnerSize { get; set; }
		private string InnerSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The minimum size for a pie in response to auto margins. The pie willtry to shrink to make room for data labels in side the plot area, but only to this size.</p>
		/// </summary>
		public double? MinSize { get; set; }
		private double? MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The start angle of the pie slices in degrees where 0 is top and 90right.</p>
		/// </summary>
		public double? StartAngle { get; set; }
		private double? StartAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>General event handlers for the series items. These event hooks can alsobe attached to the series at run time using the <code>Highcharts.addEvent</code>function.</p>
		/// </summary>
		public PlotOptionsFunnelEvents Events { get; set; }
		private PlotOptionsFunnelEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Properties for each single point.</p>
		/// </summary>
		public PlotOptionsFunnelPoint Point { get; set; }
		private PlotOptionsFunnelPoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The thickness of a 3D pie. Requires <code>highcharts-3d.js</code></p>
		/// </summary>
		public double? Depth { get; set; }
		private double? Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The SVG value used for the <code>stroke-linecap</code> and <code>stroke-linejoin</code>of a line graph. Round means that lines are rounded in the ends andbends.</p>
		/// </summary>
		public PlotOptionsFunnelLinecap Linecap { get; set; }
		private PlotOptionsFunnelLinecap Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.</p><p>The series labels currently work with series types having a<code>graph</code> or an <code>area</code>.</p><p>Requires the <code>series-label.js</code> module.</p>
		/// </summary>
		public PlotOptionsFunnelLabel Label { get; set; }
		private PlotOptionsFunnelLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Allow this series&#39; points to be selected by clicking on the graphic (columns, point markers, pie slices, map areas etc).</p>
		/// </summary>
		public bool? AllowPointSelect { get; set; }
		private bool? AllowPointSelect_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If true, a checkbox is displayed next to the legend item to allowselecting the series. The state of the checkbox is determined bythe <code>selected</code> option.</p>
		/// </summary>
		public bool? ShowCheckbox { get; set; }
		private bool? ShowCheckbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A class name to apply to the series&#39; graphical elements.</p>
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The main color of the series. In line type series it applies to theline and the point markers unless otherwise specified. In bar typeseries it applies to the bars unless a color is specified per point.The default value is pulled from the <code>options.colors</code> array.</p><p>In styled mode, the color can be defined by the<a href="#plotOptions.series.colorIndex">colorIndex</a> option. Also, the seriescolor can be set with the <code>.highcharts-series</code>, <code>.highcharts-color-{n}</code>,<code>.highcharts-{type}-series</code> or <code>.highcharts-series-{n}</code> class, orindividual classes given by the <code>className</code> option.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Styled mode only. A specific color index to use for the series, so itsgraphic representations are given the class name <code>highcharts-color-{n}</code>.</p>
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>You can set the cursor to &quot;pointer&quot; if you have click events attachedto the series, to signal to the user that the points and lines canbe clicked.</p>
		/// </summary>
		public PlotOptionsFunnelCursor Cursor { get; set; }
		private PlotOptionsFunnelCursor Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Requires the Accessibility module.</p><p>A description of the series to add to the screen reader informationabout the series.</p>
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the mouse tracking for a specific series. Thisincludes point tooltips and click events on graphs and points. Forlarge datasets it improves performance.</p>
		/// </summary>
		public bool? EnableMouseTracking { get; set; }
		private bool? EnableMouseTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>By default, series are exposed to screen readers as regions. By enablingthis option, the series element itself will be exposed in the sameway as the data points. This is useful if the series is not usedas a grouping entity in the chart, but you still want to attach adescription to the series.</p><p>Requires the Accessibility module.</p>
		/// </summary>
		public bool? ExposeElementToA11y { get; set; }
		private bool? ExposeElementToA11y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array specifying which option maps to which key in the data pointarray. This makes it convenient to work with unstructured data arraysfrom different sources.</p>
		/// </summary>
		public List<string> Keys { get; set; }
		private List<string> Keys_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The <a href="#series.id">id</a> of another series to link to. Additionally,the value can be &quot;:previous&quot; to link to the previous series. Whentwo series are linked, only the first one appears in the legend.Toggling the visibility of this also toggles the linked series.</p>
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Same as <a href="#accessibility.pointDescriptionFormatter">accessibility.pointDescriptionFormatter</a>, but for an individual series. Overridesthe chart wide configuration.</p>
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to select the series initially. If <code>showCheckbox</code> is true,the checkbox next to the series name in the legend will be checked for aselected series.</p>
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to apply a drop shadow to the graph line. Since 2.3 the shadowcan be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.</p>
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If set to <code>True</code>, the accessibility module will skip past the pointsin this series for keyboard navigation.</p>
		/// </summary>
		public bool? SkipKeyboardNavigation { get; set; }
		private bool? SkipKeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Set the initial visibility of the series.</p>
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (NeckWidth != NeckWidth_DefaultValue) h.Add("neckWidth",NeckWidth);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (NeckHeight != NeckHeight_DefaultValue) h.Add("neckHeight",NeckHeight);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (IgnoreHiddenPoint != IgnoreHiddenPoint_DefaultValue) h.Add("ignoreHiddenPoint",IgnoreHiddenPoint);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (SlicedOffset != SlicedOffset_DefaultValue) h.Add("slicedOffset",SlicedOffset);
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Colors != Colors_DefaultValue) h.Add("colors",Colors);
			if (EndAngle != EndAngle_DefaultValue) h.Add("endAngle",EndAngle);
			if (InnerSize != InnerSize_DefaultValue) h.Add("innerSize",InnerSize);
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (StartAngle != StartAngle_DefaultValue) h.Add("startAngle",StartAngle);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (Depth != Depth_DefaultValue) h.Add("depth",Depth);
			if (Linecap != Linecap_DefaultValue) h.Add("linecap", Highcharts.FirstCharacterToLower(Linecap.ToString()));
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (ExposeElementToA11y != ExposeElementToA11y_DefaultValue) h.Add("exposeElementToA11y",ExposeElementToA11y);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); Highcharts.AddFunction("PlotOptionsFunnelPointDescriptionFormatter.pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (SkipKeyboardNavigation != SkipKeyboardNavigation_DefaultValue) h.Add("skipKeyboardNavigation",SkipKeyboardNavigation);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			

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