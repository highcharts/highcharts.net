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
	public partial class VariablepieSeriesDataLabels  : BaseObject
	{
		public VariablepieSeriesDataLabels()
		{
			Distance = Distance_DefaultValue = 30;
			Enabled = Enabled_DefaultValue = null;
			Formatter = Formatter_DefaultValue = "";
			X = X_DefaultValue = null;
			ConnectorColor = ConnectorColor_DefaultValue = "{point.color}";
			ConnectorPadding = ConnectorPadding_DefaultValue = 5;
			ConnectorWidth = ConnectorWidth_DefaultValue = 1;
			SoftConnector = SoftConnector_DefaultValue = null;
			Style = Style_DefaultValue = new VariablepieSeriesDataLabelsStyle();
			VerticalAlign = VerticalAlign_DefaultValue = VariablepieSeriesDataLabelsVerticalAlign.Bottom;
			Y = Y_DefaultValue = -6;
			Padding = Padding_DefaultValue = null;
			BorderRadius = BorderRadius_DefaultValue = 0;
			BorderWidth = BorderWidth_DefaultValue = 0;
			ClassName = ClassName_DefaultValue = null;
			Color = Color_DefaultValue = null;
			Crop = Crop_DefaultValue = true;
			Defer = Defer_DefaultValue = true;
			Format = Format_DefaultValue = null;
			BackgroundColor = BackgroundColor_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = "undefined";
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Inside = Inside_DefaultValue = null;
			Overflow = Overflow_DefaultValue = VariablepieSeriesDataLabelsOverflow.Justify;
			Rotation = Rotation_DefaultValue = 0;
			Shape = Shape_DefaultValue = "square";
			ZIndex = ZIndex_DefaultValue = 6;
			Align = Align_DefaultValue = VariablepieSeriesDataLabelsAlign.Center;
			AllowOverlap = AllowOverlap_DefaultValue = false;
			
		}	
		

		/// <summary>
		/// <p>The distance of the data label from the pie&#39;s edge. Negative numbersput the data label on top of the pie slices. Connectors are onlyshown for data labels outside the pie.</p>
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the data labels.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Callback JavaScript function to format the data label. Note thatif a <code>format</code> is defined, the format takes precedence and the formatteris ignored. Available data are:</p><table><tbody><tr><td><code>this.percentage</code></td><td>Stacked series and pies only. The point&#39;s percentage of thetotal.</td></tr><tr><td><code>this.point</code></td><td>The point object. The point name, if defined, is availablethrough <code>this.point.name</code>.</td></tr><tr><td><code>this.series</code>:</td><td>The series object. The series name is available through <code>this.series.name</code>.</td></tr><tr><td><code>this.total</code></td><td>Stacked series only. The total value at this point&#39;s x value.</td></tr><tr><td><code>this.x</code>:</td><td>The x value.</td></tr><tr><td><code>this.y</code>:</td><td>The y value.</td></tr></tbody></table>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to render the connector as a soft arc or a line with sharpbreak.</p>
		/// </summary>
		public bool? X { get; set; }
		private bool? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the line connecting the data label to the pie slice.The default color is the same as the point&#39;s color.</p><p>In styled mode, the connector stroke is given in the<code>.highcharts-data-label-connector</code> class.</p>
		/// </summary>
		public string ConnectorColor { get; set; }
		private string ConnectorColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The distance from the data label to the connector.</p>
		/// </summary>
		public double? ConnectorPadding { get; set; }
		private double? ConnectorPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the line connecting the data label to the pie slice.</p><p>In styled mode, the connector stroke width is given in the<code>.highcharts-data-label-connector</code> class.</p>
		/// </summary>
		public double? ConnectorWidth { get; set; }
		private double? ConnectorWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to render the connector as a soft arc or a line with sharpbreak.</p>
		/// </summary>
		public bool? SoftConnector { get; set; }
		private bool? SoftConnector_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Styles for the label. The default <code>color</code> setting is <code>&quot;contrast&quot;</code>,which is a pseudo color that Highcharts picks up and applies themaximum contrast to the underlying point item, for example thebar in a bar chart.</p><p>The <code>textOutline</code> is a pseudo property thatapplies an outline of the given width with the given color, whichby default is the maximum contrast to the text. So a bright textcolor will result in a black text outline for maximum readabilityon a mixed background. In some cases, especially with grayscaletext, the text outline doesn&#39;t work well, in which cases it canbe disabled by setting it to <code>&quot;none&quot;</code>. When <code>useHTML</code> is true, the<code>textOutline</code> will not be picked up. In this, case, the same effectcan be acheived through the <code>text-shadow</code> CSS property.</p>
		/// </summary>
		public VariablepieSeriesDataLabelsStyle Style { get; set; }
		private VariablepieSeriesDataLabelsStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The vertical alignment of a data label. Can be one of <code>top</code>, <code>middle</code>or <code>bottom</code>. The default value depends on the data, for instancein a column chart, the label is above positive values and belownegative values.</p>
		/// </summary>
		public VariablepieSeriesDataLabelsVerticalAlign VerticalAlign { get; set; }
		private VariablepieSeriesDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The y position offset of the label relative to the point.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When either the <code>borderWidth</code> or the <code>backgroundColor</code> is set,this is the padding within the box.</p>
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border radius in pixels for the data label.</p>
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border width in pixels for the data label.</p>
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A class name for the data label. Particularly in styled mode, this canbe used to give each series&#39; or point&#39;s data label unique styling.In addition to this option, a default color class name is addedso that we can give the labels a <a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/data-label-contrast/">contrast text shadow</a>.</p>
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The text color for the data labels. Defaults to <code>null</code>. For certain seriestypes, like column or map, the data labels can be drawn inside the points.In this case the data label will be drawn with maximum contrast by default.Additionally, it will be given a <code>text-outline</code> style with the oppositecolor, to further increase the contrast. This can be overridden by settingthe <code>text-outline</code> style to <code>none</code> in the <code>dataLabels.style</code> option.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to hide data labels that are outside the plot area. By default,the data label is moved inside the plot area according to the <a href="#plotOptions.series.dataLabels.overflow">overflow</a> option.</p>
		/// </summary>
		public bool? Crop { get; set; }
		private bool? Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to defer displaying the data labels until the initial seriesanimation has finished.</p>
		/// </summary>
		public bool? Defer { get; set; }
		private bool? Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting">format string</a> for the data label. Available variables arethe same as for <code>formatter</code>.</p>
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The background color or gradient for the data label.</p>
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border color for the data label. Defaults to <code>undefined</code>.</p>
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The shadow of the box. Works best with <code>borderWidth</code> or <code>backgroundColor</code>.Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.</p>
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For points with an extent, like columns or map areas, whether to align the datalabel inside the box or to the actual value point. Defaults to <code>false</code>in most cases, <code>true</code> in stacked columns.</p>
		/// </summary>
		public bool? Inside { get; set; }
		private bool? Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>How to handle data labels that flow outside the plot area. The defaultis <code>justify</code>, which aligns them inside the plot area. For columnsand bars, this means it will be moved inside the bar. To displaydata labels outside the plot area, set <code>crop</code> to <code>false</code> and <code>overflow</code>to <code>&quot;none&quot;</code>.</p>
		/// </summary>
		public VariablepieSeriesDataLabelsOverflow Overflow { get; set; }
		private VariablepieSeriesDataLabelsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Text rotation in degrees. Note that due to a more complex structure,backgrounds, borders and padding will be lost on a rotated datalabel.</p>
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The name of a symbol to use for the border around the label. Symbolsare predefined functions on the Renderer object.</p>
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Z index of the data labels. The default Z index puts it abovethe series. Use a Z index of 2 to display it behind the series.</p>
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The alignment of the data label compared to the point. If <code>right</code>,the right side of the label should be touching the point. Forpoints with an extent, like columns, the alignments also dictateshow to align it inside the box, as given with the <a href="#plotOptions.column.dataLabels.inside">inside</a> option. Can be one of &quot;left&quot;, &quot;center&quot;or &quot;right&quot;.</p>
		/// </summary>
		public VariablepieSeriesDataLabelsAlign Align { get; set; }
		private VariablepieSeriesDataLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to allow data labels to overlap. To make the labels lesssensitive for overlapping, the <a href="#plotOptions.series.dataLabels.padding">dataLabels.padding</a> can be set to 0.</p>
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highcharts.AddFunction("VariablepieSeriesDataLabelsFormatter.formatter", Formatter); }  
			if (X != X_DefaultValue) h.Add("x",X);
			if (ConnectorColor != ConnectorColor_DefaultValue) h.Add("connectorColor",ConnectorColor);
			if (ConnectorPadding != ConnectorPadding_DefaultValue) h.Add("connectorPadding",ConnectorPadding);
			if (ConnectorWidth != ConnectorWidth_DefaultValue) h.Add("connectorWidth",ConnectorWidth);
			if (SoftConnector != SoftConnector_DefaultValue) h.Add("softConnector",SoftConnector);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow", Highcharts.FirstCharacterToLower(Overflow.ToString()));
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			

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