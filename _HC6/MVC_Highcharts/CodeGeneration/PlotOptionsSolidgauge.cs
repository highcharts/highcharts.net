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
	public partial class PlotOptionsSolidgauge  : BaseObject
	{
		public PlotOptionsSolidgauge()
		{
			ColorByPoint = ColorByPoint_DefaultValue = null;
			Linecap = Linecap_DefaultValue = PlotOptionsSolidgaugeLinecap.Round;
			Rounded = Rounded_DefaultValue = false;
			Threshold = Threshold_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = new PlotOptionsSolidgaugeDataLabels();
			Tooltip = Tooltip_DefaultValue = new PlotOptionsSolidgaugeTooltip();
			ShowInLegend = ShowInLegend_DefaultValue = null;
			Overshoot = Overshoot_DefaultValue = 0;
			Wrap = Wrap_DefaultValue = true;
			Label = Label_DefaultValue = new PlotOptionsSolidgaugeLabel();
			LineWidth = LineWidth_DefaultValue = 2;
			AllowPointSelect = AllowPointSelect_DefaultValue = false;
			ShowCheckbox = ShowCheckbox_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Events = Events_DefaultValue = new PlotOptionsSolidgaugeEvents();
			Point = Point_DefaultValue = new PlotOptionsSolidgaugePoint();
			States = States_DefaultValue = new PlotOptionsSolidgaugeStates();
			StickyTracking = StickyTracking_DefaultValue = null;
			ClassName = ClassName_DefaultValue = null;
			Color = Color_DefaultValue = null;
			ColorIndex = ColorIndex_DefaultValue = null;
			Cursor = Cursor_DefaultValue = PlotOptionsSolidgaugeCursor.Null;
			Description = Description_DefaultValue = "undefined";
			EnableMouseTracking = EnableMouseTracking_DefaultValue = true;
			ExposeElementToA11y = ExposeElementToA11y_DefaultValue = null;
			Keys = Keys_DefaultValue = new List<string>();
			LinkedTo = LinkedTo_DefaultValue = null;
			NegativeColor = NegativeColor_DefaultValue = "null";
			PointDescriptionFormatter = PointDescriptionFormatter_DefaultValue = "";
			PointInterval = PointInterval_DefaultValue = 1;
			PointIntervalUnit = PointIntervalUnit_DefaultValue = PlotOptionsSolidgaugePointIntervalUnit.Null;
			PointStart = PointStart_DefaultValue = 0;
			Selected = Selected_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			SkipKeyboardNavigation = SkipKeyboardNavigation_DefaultValue = null;
			Visible = Visible_DefaultValue = true;
			
		}	
		

		/// <summary>
		/// <p>Whether to give each point an individual color.</p>
		/// </summary>
		public bool? ColorByPoint { get; set; }
		private bool? ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether the strokes of the solid gauge should be <code>round</code> or <code>square</code>.</p>
		/// </summary>
		public PlotOptionsSolidgaugeLinecap Linecap { get; set; }
		private PlotOptionsSolidgaugeLinecap Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Wether to draw rounded edges on the gauge.</p>
		/// </summary>
		public bool? Rounded { get; set; }
		private bool? Rounded_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The threshold or base level for the gauge.</p>
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Data labels for the gauge. For gauges, the data labels are enabledby default and shown in a bordered box below the point.</p>
		/// </summary>
		public PlotOptionsSolidgaugeDataLabels DataLabels { get; set; }
		private PlotOptionsSolidgaugeDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A configuration object for the tooltip rendering of each single series.Properties are inherited from <a href="#tooltip">tooltip</a>, but only thefollowing properties can be defined on a series level.</p>
		/// </summary>
		public PlotOptionsSolidgaugeTooltip Tooltip { get; set; }
		private PlotOptionsSolidgaugeTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to display this particular series or series type in thelegend. Defaults to false for gauge series.</p>
		/// </summary>
		public bool? ShowInLegend { get; set; }
		private bool? ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Allow the dial to overshoot the end of the perimeter axis by thismany degrees. Say if the gauge axis goes from 0 to 60, a value of100, or 1000, will show 5 degrees beyond the end of the axis.</p>
		/// </summary>
		public double? Overshoot { get; set; }
		private double? Overshoot_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When this option is <code>true</code>, the dial will wrap around the axes. Forinstance, in a full-range gauge going from 0 to 360, a value of 400will point to 40. When <code>wrap</code> is <code>false</code>, the dial stops at 360.</p>
		/// </summary>
		public bool? Wrap { get; set; }
		private bool? Wrap_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Series labels are placed as close to the series as possible in anatural way, seeking to avoid other series. The goal of thisfeature is to make the chart more easily readable, like if ahuman designer placed the labels in the optimal position.</p><p>The series labels currently work with series types having a<code>graph</code> or an <code>area</code>.</p><p>Requires the <code>series-label.js</code> module.</p>
		/// </summary>
		public PlotOptionsSolidgaugeLabel Label { get; set; }
		private PlotOptionsSolidgaugeLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Pixel with of the graph line.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

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
		/// <p>Enable or disable the initial animation when a series is displayed.The animation can also be set as a configuration object. Pleasenote that this option only applies to the initial animation of theseries itself. For other animations, see <a href="#chart.animation">chart.animation</a> and the animation parameter under the API methods. Thefollowing properties are supported:</p><dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>A string reference to an easing function set on the <code>Math</code> object.See the <em>Custom easing function</em> demo below.</dd></dl><p>Due to poor performance, animation is disabled in old IE browsersfor several chart types.</p>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>General event handlers for the series items. These event hooks can alsobe attached to the series at run time using the <code>Highcharts.addEvent</code>function.</p>
		/// </summary>
		public PlotOptionsSolidgaugeEvents Events { get; set; }
		private PlotOptionsSolidgaugeEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Properties for each single point.</p>
		/// </summary>
		public PlotOptionsSolidgaugePoint Point { get; set; }
		private PlotOptionsSolidgaugePoint Point_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A wrapper object for all the series options in specific states.</p>
		/// </summary>
		public PlotOptionsSolidgaugeStates States { get; set; }
		private PlotOptionsSolidgaugeStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Sticky tracking of mouse events. When true, the <code>mouseOut</code> eventon a series isn&#39;t triggered until the mouse moves over another series,or out of the plot area. When false, the <code>mouseOut</code> event on aseries is triggered when the mouse leaves the area around the series&#39;graph or markers. This also implies the tooltip when not shared. When<code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the tooltip willbe hidden when moving the mouse between series. Defaults to true for lineand area type series, but to false for columns, pies etc.</p>
		/// </summary>
		public bool? StickyTracking { get; set; }
		private bool? StickyTracking_DefaultValue { get; set; }
		 

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
		public PlotOptionsSolidgaugeCursor Cursor { get; set; }
		private PlotOptionsSolidgaugeCursor Cursor_DefaultValue { get; set; }
		 

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
		/// <p>The color for the parts of the graph or points that are below the<a href="#plotOptions.series.threshold">threshold</a>.</p>
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Same as <a href="#accessibility.pointDescriptionFormatter">accessibility.pointDescriptionFormatter</a>, but for an individual series. Overridesthe chart wide configuration.</p>
		/// </summary>
		public string PointDescriptionFormatter { get; set; }
		private string PointDescriptionFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If no x values are given for the points in a series, <code>pointInterval</code>defines the interval of the x values. For example, if a series containsone value every decade starting from year 0, set <code>pointInterval</code> to<code>10</code>. In true <code>datetime</code> axes, the <code>pointInterval</code> is set inmilliseconds.</p><p>It can be also be combined with <code>pointIntervalUnit</code> to draw irregulartime intervals.</p>
		/// </summary>
		public double? PointInterval { get; set; }
		private double? PointInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>On datetime series, this allows for setting the<a href="#plotOptions.series.pointInterval">pointInterval</a> to irregular time units, <code>day</code>, <code>month</code> and <code>year</code>. A day is usually the same as 24 hours,but <code>pointIntervalUnit</code> also takes the DST crossover into considerationwhen dealing with local time. Combine this option with <code>pointInterval</code>to draw weeks, quarters, 6 months, 10 years etc.</p>
		/// </summary>
		public PlotOptionsSolidgaugePointIntervalUnit PointIntervalUnit { get; set; }
		private PlotOptionsSolidgaugePointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If no x values are given for the points in a series, pointStart defineson what value to start. For example, if a series contains one yearlyvalue starting from 1945, set pointStart to 1945.</p>
		/// </summary>
		public double? PointStart { get; set; }
		private double? PointStart_DefaultValue { get; set; }
		 

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

			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (Linecap != Linecap_DefaultValue) h.Add("linecap", Highcharts.FirstCharacterToLower(Linecap.ToString()));
			if (Rounded != Rounded_DefaultValue) h.Add("rounded",Rounded);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (Overshoot != Overshoot_DefaultValue) h.Add("overshoot",Overshoot);
			if (Wrap != Wrap_DefaultValue) h.Add("wrap",Wrap);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (AllowPointSelect != AllowPointSelect_DefaultValue) h.Add("allowPointSelect",AllowPointSelect);
			if (ShowCheckbox != ShowCheckbox_DefaultValue) h.Add("showCheckbox",ShowCheckbox);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Point.IsDirty()) h.Add("point",Point.ToHashtable());
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor", Highcharts.FirstCharacterToLower(Cursor.ToString()));
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (EnableMouseTracking != EnableMouseTracking_DefaultValue) h.Add("enableMouseTracking",EnableMouseTracking);
			if (ExposeElementToA11y != ExposeElementToA11y_DefaultValue) h.Add("exposeElementToA11y",ExposeElementToA11y);
			if (Keys != Keys_DefaultValue) h.Add("keys",Keys);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue) { h.Add("pointDescriptionFormatter",PointDescriptionFormatter); Highcharts.AddFunction("PlotOptionsSolidgaugePointDescriptionFormatter.pointDescriptionFormatter", PointDescriptionFormatter); }  
			if (PointInterval != PointInterval_DefaultValue) h.Add("pointInterval",PointInterval);
			if (PointIntervalUnit != PointIntervalUnit_DefaultValue) h.Add("pointIntervalUnit", Highcharts.FirstCharacterToLower(PointIntervalUnit.ToString()));
			if (PointStart != PointStart_DefaultValue) h.Add("pointStart",PointStart);
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