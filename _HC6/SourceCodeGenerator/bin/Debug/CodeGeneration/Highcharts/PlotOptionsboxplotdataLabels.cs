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
	public partial class PlotOptionsBoxplotDataLabels  : BaseObject
	{
		public PlotOptionsBoxplotDataLabels()
		{
			Align = Align_DefaultValue = PlotOptionsBoxplotDataLabelsAlign.Center;
			Formatter = Formatter_DefaultValue = "";
			Style = Style_DefaultValue = new Hashtable{{"color", "contrast"},{ "fontSize", "11px"},{ "fontWeight", "bold"},{ "textOutline", "1px contrast" }};
			VerticalAlign = VerticalAlign_DefaultValue = PlotOptionsBoxplotDataLabelsVerticalAlign.Bottom;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = -6;
			Padding = Padding_DefaultValue = "5";
			AllowOverlap = AllowOverlap_DefaultValue = false;
			BorderRadius = BorderRadius_DefaultValue = 0;
			BorderWidth = BorderWidth_DefaultValue = 0;
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "";
			Crop = Crop_DefaultValue = true;
			Defer = Defer_DefaultValue = true;
			Enabled = Enabled_DefaultValue = false;
			Format = Format_DefaultValue = "";
			BackgroundColor = BackgroundColor_DefaultValue = "";
			BorderColor = BorderColor_DefaultValue = "undefined";
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Inside = Inside_DefaultValue = "";
			Overflow = Overflow_DefaultValue = PlotOptionsBoxplotDataLabelsOverflow.Justify;
			Rotation = Rotation_DefaultValue = 0;
			UseHTML = UseHTML_DefaultValue = false;
			Shape = Shape_DefaultValue = "square";
			ZIndex = ZIndex_DefaultValue = 6;
			Filter = Filter_DefaultValue = new PlotOptionsBoxplotDataLabelsFilter();
			
		}	
		

		/// <summary>
		/// The alignment of the data label compared to the point. If `right`,the right side of the label should be touching the point. Forpoints with an extent, like columns, the alignments also dictateshow to align it inside the box, as given with the [inside](#plotOptions.column.dataLabels.inside) option. Can be one of "left", "center"or "right".
		/// </summary>
		public PlotOptionsBoxplotDataLabelsAlign Align { get; set; }
		private PlotOptionsBoxplotDataLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the data label. Note thatif a `format` is defined, the format takes precedence and the formatteris ignored. Available data are:<table><tbody><tr><td>`this.percentage`</td><td>Stacked series and pies only. The point's percentage of thetotal.</td></tr><tr><td>`this.point`</td><td>The point object. The point name, if defined, is availablethrough `this.point.name`.</td></tr><tr><td>`this.series`:</td><td>The series object. The series name is available through `this.series.name`.</td></tr><tr><td>`this.total`</td><td>Stacked series only. The total value at this point's x value.</td></tr><tr><td>`this.x`:</td><td>The x value.</td></tr><tr><td>`this.y`:</td><td>The y value.</td></tr></tbody></table>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styles for the label. The default `color` setting is `"contrast"`,which is a pseudo color that Highcharts picks up and applies themaximum contrast to the underlying point item, for example thebar in a bar chart.The `textOutline` is a pseudo property thatapplies an outline of the given width with the given color, whichby default is the maximum contrast to the text. So a bright textcolor will result in a black text outline for maximum readabilityon a mixed background. In some cases, especially with grayscaletext, the text outline doesn't work well, in which cases it canbe disabled by setting it to `"none"`. When `useHTML` is true, the`textOutline` will not be picked up. In this, case, the same effectcan be acheived through the `text-shadow` CSS property.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of a data label. Can be one of `top`, `middle`or `bottom`. The default value depends on the data, for instancein a column chart, the label is above positive values and belownegative values.
		/// </summary>
		public PlotOptionsBoxplotDataLabelsVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsBoxplotDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the point.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the point.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// When either the `borderWidth` or the `backgroundColor` is set,this is the padding within the box.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to allow data labels to overlap. To make the labels lesssensitive for overlapping, the [dataLabels.padding](#plotOptions.series.dataLabels.padding) can be set to 0.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border radius in pixels for the data label.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width in pixels for the data label.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A class name for the data label. Particularly in styled mode, this canbe used to give each series' or point's data label unique styling.In addition to this option, a default color class name is addedso that we can give the labels a [contrast text shadow](http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/css/data-label-contrast/).
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text color for the data labels. Defaults to `null`. For certain seriestypes, like column or map, the data labels can be drawn inside the points.In this case the data label will be drawn with maximum contrast by default.Additionally, it will be given a `text-outline` style with the oppositecolor, to further increase the contrast. This can be overridden by settingthe `text-outline` style to `none` in the `dataLabels.style` option.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to hide data labels that are outside the plot area. By default,the data label is moved inside the plot area according to the [overflow](#plotOptions.series.dataLabels.overflow) option.
		/// </summary>
		public bool? Crop { get; set; }
		private bool? Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to defer displaying the data labels until the initial seriesanimation has finished.
		/// </summary>
		public bool? Defer { get; set; }
		private bool? Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the data labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// A [format string](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting) for the data label. Available variables arethe same as for `formatter`.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color or gradient for the data label.
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the data label. Defaults to `undefined`.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow of the box. Works best with `borderWidth` or `backgroundColor`.Since 2.3 the shadow can be an object configuration containing `color`, `offsetX`, `offsetY`, `opacity` and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// For points with an extent, like columns or map areas, whether to align the datalabel inside the box or to the actual value point. Defaults to `false`in most cases, `true` in stacked columns.
		/// </summary>
		public bool? Inside { get; set; }
		private bool? Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle data labels that flow outside the plot area. The defaultis `justify`, which aligns them inside the plot area. For columnsand bars, this means it will be moved inside the bar. To displaydata labels outside the plot area, set `crop` to `false` and `overflow`to `"none"`.
		/// </summary>
		public PlotOptionsBoxplotDataLabelsOverflow Overflow { get; set; }
		private PlotOptionsBoxplotDataLabelsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Text rotation in degrees. Note that due to a more complex structure,backgrounds, borders and padding will be lost on a rotated datalabel.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html) to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of a symbol to use for the border around the label. Symbolsare predefined functions on the Renderer object.
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the data labels. The default Z index puts it abovethe series. Use a Z index of 2 to display it behind the series.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// A declarative filter for which data labels to display. Thedeclarative filter is designed for use when callback functions arenot available, like when the chart options require a pure JSONstructure or for use with graphical editors. For programmaticcontrol, use the `formatter` instead, and return `false` to disablea single data label.
		/// </summary>
		public PlotOptionsBoxplotDataLabelsFilter Filter { get; set; }
		private PlotOptionsBoxplotDataLabelsFilter Filter_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow", Highcharts.FirstCharacterToLower(Overflow.ToString()));
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (Filter.IsDirty()) h.Add("filter",Filter.ToHashtable());
			

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