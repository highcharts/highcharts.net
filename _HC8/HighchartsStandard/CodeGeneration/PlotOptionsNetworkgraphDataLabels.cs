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
	public partial class PlotOptionsNetworkgraphDataLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsNetworkgraphDataLabels()
		{
			Align = Align_DefaultValue = PlotOptionsNetworkgraphDataLabelsAlign.Center;
			AllowOverlap = AllowOverlap_DefaultValue = false;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationBool = AnimationBool_DefaultValue = null;
			BackgroundColor = BackgroundColor_DefaultValue = "";
			BorderColor = BorderColor_DefaultValue = "";
			BorderRadius = BorderRadius_DefaultValue = 0;
			BorderWidth = BorderWidth_DefaultValue = 0;
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "";
			Crop = Crop_DefaultValue = true;
			Defer = Defer_DefaultValue = true;
			Enabled = Enabled_DefaultValue = false;
			Filter = Filter_DefaultValue = new PlotOptionsNetworkgraphDataLabelsFilter();
			Format = Format_DefaultValue = "";
			Formatter = Formatter_DefaultValue = "";
			Inside = Inside_DefaultValue = null;
			LinkFormat = LinkFormat_DefaultValue = "";
			LinkFormatter = LinkFormatter_DefaultValue = "";
			LinkTextPath = LinkTextPath_DefaultValue = new PlotOptionsNetworkgraphDataLabelsLinkTextPath();
			NullFormat = NullFormat_DefaultValue = "";
			NullFormatBool = NullFormatBool_DefaultValue = null;
			NullFormatter = NullFormatter_DefaultValue = "";
			Overflow = Overflow_DefaultValue = "justify";
			Padding = Padding_DefaultValue = "5";
			Position = Position_DefaultValue = new Hashtable();
			Rotation = Rotation_DefaultValue = 0;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ShadowBool = ShadowBool_DefaultValue = null;
			Shape = Shape_DefaultValue = "square";
			Style = Style_DefaultValue = new Hashtable();
			TextPath = TextPath_DefaultValue = new PlotOptionsNetworkgraphDataLabelsTextPath();
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = PlotOptionsNetworkgraphDataLabelsVerticalAlign.Bottom;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 0;
			Z = Z_DefaultValue = 6;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The alignment of the data label compared to the point. If`right`, the right side of the label should be touching thepoint. For points with an extent, like columns, the alignmentsalso dictates how to align it inside the box, as given with the[inside](#plotOptions.column.dataLabels.inside)option. Can be one of `left`, `center` or `right`.
		/// </summary>
		public PlotOptionsNetworkgraphDataLabelsAlign Align { get; set; }
		private PlotOptionsNetworkgraphDataLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to allow data labels to overlap. To make the labels lesssensitive for overlapping, the[dataLabels.padding](#plotOptions.series.dataLabels.padding)can be set to 0.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series isdisplayed for the `dataLabels`. The animation can also be set asa configuration object. Please note that this option onlyapplies to the initial animation.For other animations, see [chart.animation](#chart.animation)and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series isdisplayed for the `dataLabels`. The animation can also be set asa configuration object. Please note that this option onlyapplies to the initial animation.For other animations, see [chart.animation](#chart.animation)and the animation parameter under the API methods.The following properties are supported:- `defer`: The animation delay time in milliseconds.
		/// </summary>
		public bool? AnimationBool { get; set; }
		private bool? AnimationBool_DefaultValue { get; set; }
		 

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
		/// A class name for the data label. Particularly in styled mode,this can be used to give each series' or point's data labelunique styling. In addition to this option, a default color classname is added so that we can give the labels a contrast textshadow.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text color for the data labels. Defaults to `undefined`. Forcertain series types, like column or map, the data labels can bedrawn inside the points. In this case the data label will bedrawn with maximum contrast by default. Additionally, it will begiven a `text-outline` style with the opposite color, to furtherincrease the contrast. This can be overridden by setting the`text-outline` style to `none` in the `dataLabels.style` option.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to hide data labels that are outside the plot area. Bydefault, the data label is moved inside the plot area accordingto the[overflow](#plotOptions.series.dataLabels.overflow)option.
		/// </summary>
		public bool? Crop { get; set; }
		private bool? Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to defer displaying the data labels until the initialseries animation has finished. Setting to `false` renders thedata label immediately. If set to `true` inherits the defertime set in [plotOptions.series.animation](#plotOptions.series.animation).
		/// </summary>
		public bool? Defer { get; set; }
		private bool? Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the data labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// A declarative filter to control of which data labels to display.The declarative filter is designed for use when callbackfunctions are not available, like when the chart options requirea pure JSON structure or for use with graphical editors. Forprogrammatic control, use the `formatter` instead, and return`undefined` to disable a single data label.
		/// </summary>
		public PlotOptionsNetworkgraphDataLabelsFilter Filter { get; set; }
		private PlotOptionsNetworkgraphDataLabelsFilter Filter_DefaultValue { get; set; }
		 

		/// <summary>
		/// The[format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)specifying what to show for _node_ in the networkgraph. In v7.0defaults to `{key}`, since v7.1 defaults to `undefined` and`formatter` is used instead.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the data label for a node.Note that if a `format` is defined, the format takes precedenceand the formatter is ignored.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// For points with an extent, like columns or map areas, whether toalign the data label inside the box or to the actual value point.Defaults to `false` in most cases, `true` in stacked columns.
		/// </summary>
		public bool? Inside { get; set; }
		private bool? Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// The[format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)specifying what to show for _links_ in the networkgraph.(Default: `undefined`)
		/// </summary>
		public string LinkFormat { get; set; }
		private string LinkFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback to format data labels for _links_ in the sankey diagram.The `linkFormat` option takes precedence over the`linkFormatter`.
		/// </summary>
		public string LinkFormatter { get; set; }
		private string LinkFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for a _link_ label text which should follow linkconnection. Border and background are disabled for a label thatfollows a path.**Note:** Only SVG-based renderer supports this option. Setting`useHTML` to true will disable this option.
		/// </summary>
		public PlotOptionsNetworkgraphDataLabelsLinkTextPath LinkTextPath { get; set; }
		private PlotOptionsNetworkgraphDataLabelsLinkTextPath LinkTextPath_DefaultValue { get; set; }
		 

		/// <summary>
		/// Format for points with the value of null. Works analogously to[format](#plotOptions.series.dataLabels.format). `nullFormat` canbe applied only to series which support displaying null points.
		/// </summary>
		public string NullFormat { get; set; }
		private string NullFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Format for points with the value of null. Works analogously to[format](#plotOptions.series.dataLabels.format). `nullFormat` canbe applied only to series which support displaying null points.
		/// </summary>
		public bool? NullFormatBool { get; set; }
		private bool? NullFormatBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function that defines formatting for pointswith the value of null. Works analogously to[formatter](#plotOptions.series.dataLabels.formatter).`nullPointFormatter` can be applied only to series which supportdisplaying null points.
		/// </summary>
		public string NullFormatter { get; set; }
		private string NullFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle data labels that flow outside the plot area. Thedefault is `"justify"`, which aligns them inside the plot area.For columns and bars, this means it will be moved inside the bar.To display data labels outside the plot area, set `crop` to`false` and `overflow` to `"allow"`.
		/// </summary>
		public string Overflow { get; set; }
		private string Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// When either the `borderWidth` or the `backgroundColor` is set,this is the padding within the box.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Aligns data labels relative to points. If `center` alignment isnot possible, it defaults to `right`.
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// Text rotation in degrees. Note that due to a more complexstructure, backgrounds, borders and padding will be lost on arotated data label.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow of the box. Works best with `borderWidth` or`backgroundColor`. Since 2.3 the shadow can be an objectconfiguration containing `color`, `offsetX`, `offsetY`, `opacity`and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow of the box. Works best with `borderWidth` or`backgroundColor`. Since 2.3 the shadow can be an objectconfiguration containing `color`, `offsetX`, `offsetY`, `opacity`and `width`.
		/// </summary>
		public bool? ShadowBool { get; set; }
		private bool? ShadowBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of a symbol to use for the border around the label.Symbols are predefined functions on the Renderer object.
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsNetworkgraphDataLabelsTextPath TextPath { get; set; }
		private PlotOptionsNetworkgraphDataLabelsTextPath TextPath_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to[use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of a data label. Can be one of `top`,`middle` or `bottom`. The default value depends on the data, forinstance in a column chart, the label is above positive valuesand below negative values.
		/// </summary>
		public PlotOptionsNetworkgraphDataLabelsVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsNetworkgraphDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the point inpixels.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the point inpixels.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the data labels. The default Z index puts it abovethe series. Use a Z index of 2 to display it behind the series.
		/// </summary>
		public double? Z { get; set; }
		private double? Z_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Filter.IsDirty()) h.Add("filter",Filter.ToHashtable());
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highcharts.AddFunction("formatter", Formatter); }  
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (LinkFormat != LinkFormat_DefaultValue) h.Add("linkFormat",LinkFormat);
			if (LinkFormatter != LinkFormatter_DefaultValue) { h.Add("linkFormatter",LinkFormatter); Highcharts.AddFunction("linkFormatter", LinkFormatter); }  
			if (LinkTextPath.IsDirty()) h.Add("linkTextPath",LinkTextPath.ToHashtable());
			if (NullFormat != NullFormat_DefaultValue) h.Add("nullFormat",NullFormat);
			if (NullFormatBool != NullFormatBool_DefaultValue) h.Add("nullFormat",NullFormatBool);
			if (NullFormatter != NullFormatter_DefaultValue) { h.Add("nullFormatter",NullFormatter); Highcharts.AddFunction("nullFormatter", NullFormatter); }  
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (ShadowBool != ShadowBool_DefaultValue) h.Add("shadow",ShadowBool);
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (TextPath.IsDirty()) h.Add("textPath",TextPath.ToHashtable());
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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