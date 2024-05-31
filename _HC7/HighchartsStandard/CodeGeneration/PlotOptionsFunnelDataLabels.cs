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
	public partial class PlotOptionsFunnelDataLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsFunnelDataLabels()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The alignment of the data label compared to the point. If `right`,the right side of the label should be touching the point. For pointswith an extent, like columns, the alignments also dictates how toalign it inside the box, as given with the[inside](#plotOptions.column.dataLabels.inside) option. Can be one of`left`, `center` or `right`.
		/// </summary>
		public PlotOptionsFunnelDataLabelsAlign Align { get; set; }
		 

		/// <summary>
		/// Alignment method for data labels. Possible values are:- `plotEdges`: Each label touches the nearest vertical edge of  the plot area.- `connectors`: Connectors have the same x position and the  widest label of each half (left & right) touches the nearest  vertical edge of the plot area.
		/// </summary>
		public string AlignTo { get; set; }
		 

		/// <summary>
		/// Whether to allow data labels to overlap. To make the labels lesssensitive for overlapping, the[dataLabels.padding](#plotOptions.series.dataLabels.padding)can be set to 0.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayedfor the `dataLabels`. The animation can also be set as aconfiguration object. Please note that this option only applies tothe initial animation.For other animations, see [chart.animation](#chart.animation) and theanimation parameter under the API methods. The following propertiesare supported:- `defer`: The animation delay time in milliseconds.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Enable or disable the initial animation when a series is displayedfor the `dataLabels`. The animation can also be set as aconfiguration object. Please note that this option only applies tothe initial animation.For other animations, see [chart.animation](#chart.animation) and theanimation parameter under the API methods. The following propertiesare supported:- `defer`: The animation delay time in milliseconds.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// The background color or gradient for the data label. Setting it to`auto` will use the point's color.
		/// </summary>
		public string BackgroundColor { get; set; }
		 

		/// <summary>
		/// The border color for the data label. Setting it to `auto` will usethe point's color. Defaults to `undefined`.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The border radius in pixels for the data label.
		/// </summary>
		public double? BorderRadius { get; set; }
		 

		/// <summary>
		/// The border width in pixels for the data label.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// A class name for the data label. Particularly in styled mode,this can be used to give each series' or point's data labelunique styling. In addition to this option, a default color classname is added so that we can give the labels a contrast textshadow.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// This options is deprecated.Use [style.color](#plotOptions.series.dataLabels.style) instead.The text color for the data labels. Defaults to `undefined`. Forcertain series types, like column or map, the data labels can bedrawn inside the points. In this case the data label will bedrawn with maximum contrast by default. Additionally, it will begiven a `text-outline` style with the opposite color, to furtherincrease the contrast. This can be overridden by setting the`text-outline` style to `none` in the `dataLabels.style` option.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// The color of the line connecting the data label to the pie slice.The default color is the same as the point's color.In styled mode, the connector stroke is given in the`.highcharts-data-label-connector` class.
		/// </summary>
		public string ConnectorColor { get; set; }
		 

		/// <summary>
		/// The distance from the data label to the connector. Note thatdata labels also have a default `padding`, so in order for theconnector to touch the text, the `padding` must also be 0.
		/// </summary>
		public double? ConnectorPadding { get; set; }
		 

		/// <summary>
		/// Specifies the method that is used to generate the connector path.Highcharts provides 3 built-in connector shapes: `'crookedLine'`(default since v11), `'fixedOffset'` and `'straight'`.Users can provide their own method by passing a function instead of astring. Three arguments are passed to the callback:- An object that holds the information about the coordinates of the  label (`x` & `y` properties) and how the label is located in  relation to the pie (`alignment` property). `alignment` can by one  of the following: `'left'` (pie on the left side of the data  label), `'right'` (pie on the right side of the data label) or  `'center'` (data label overlaps the pie).- An object that holds the information about the position of the  connector. Its `touchingSliceAt`  porperty tells the position of  the place where the connector touches the slice.- Data label optionsThe function has to return an SVG path definition in array form (seethe example).
		/// </summary>
		public string ConnectorShape { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? ConnectorWidth { get; set; }
		 

		/// <summary>
		/// Works only if `connectorShape` is `'crookedLine'`. It defines howfar from the vertical plot edge the coonnector path should becrooked. With the default, `undefined`, the crook is placed so thatthe horizontal line from the label intersects with the radial lineextending through the center of the pie slice.
		/// </summary>
		public string CrookDistance { get; set; }
		 

		/// <summary>
		/// Whether to hide data labels that are outside the plot area. Bydefault, the data label is moved inside the plot area accordingto the[overflow](#plotOptions.series.dataLabels.overflow)option.
		/// </summary>
		public bool? Crop { get; set; }
		 

		/// <summary>
		/// Whether to defer displaying the data labels until the initialseries animation has finished. Setting to `false` renders thedata label immediately. If set to `true` inherits the defertime set in [plotOptions.series.animation](#plotOptions.series.animation).
		/// </summary>
		public bool? Defer { get; set; }
		 

		/// <summary>
		/// The distance of the data label from the pie's edge. Negativenumbers put the data label on top of the pie slices. Can also bedefined as a percentage of pie's radius. Connectors are onlyshown for data labels outside the pie.
		/// </summary>
		public string Distance { get; set; }
		 

		/// <summary>
		/// The distance of the data label from the pie's edge. Negativenumbers put the data label on top of the pie slices. Can also bedefined as a percentage of pie's radius. Connectors are onlyshown for data labels outside the pie.
		/// </summary>
		public double? DistanceNumber { get; set; }
		 

		/// <summary>
		/// Enable or disable the data labels.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// A declarative filter to control of which data labels to display.The declarative filter is designed for use when callbackfunctions are not available, like when the chart options requirea pure JSON structure or for use with graphical editors. Forprogrammatic control, use the `formatter` instead, and return`undefined` to disable a single data label.
		/// </summary>
		public PlotOptionsFunnelDataLabelsFilter Filter { get; set; }
		 

		/// <summary>
		/// A[format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)for the data label. Available variables are the same as for`formatter`.
		/// </summary>
		public string Format { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the data label. Note that if a`format` is defined, the format takes precedence and the formatter isignored.
		/// </summary>
		public string Formatter { get; set; }
		 

		/// <summary>
		/// For points with an extent, like columns or map areas, whether toalign the data label inside the box or to the actual value point.Defaults to `false` in most cases, `true` in stacked columns.
		/// </summary>
		public bool? Inside { get; set; }
		 

		/// <summary>
		/// Format for points with the value of null. Works analogously to[format](#plotOptions.series.dataLabels.format). `nullFormat` canbe applied only to series which support displaying null pointsi.e `heatmap` or `tilemap`. Does not work with series that don'tdisplay null points, like `line`, `column`, `bar` or `pie`.
		/// </summary>
		public string NullFormat { get; set; }
		 

		/// <summary>
		/// Format for points with the value of null. Works analogously to[format](#plotOptions.series.dataLabels.format). `nullFormat` canbe applied only to series which support displaying null pointsi.e `heatmap` or `tilemap`. Does not work with series that don'tdisplay null points, like `line`, `column`, `bar` or `pie`.
		/// </summary>
		public bool? NullFormatBool { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function that defines formatting for pointswith the value of null. Works analogously to[formatter](#plotOptions.series.dataLabels.formatter).`nullFormatter` can be applied only to series which supportdisplaying null points i.e `heatmap` or `tilemap`. Does not workwith series that don't display null points, like `line`, `column`,`bar` or `pie`.
		/// </summary>
		public string NullFormatter { get; set; }
		 

		/// <summary>
		/// How to handle data labels that flow outside the plot area. Thedefault is `"justify"`, which aligns them inside the plot area.For columns and bars, this means it will be moved inside the bar.To display data labels outside the plot area, set `crop` to`false` and `overflow` to `"allow"`.
		/// </summary>
		public PlotOptionsFunnelDataLabelsOverflow Overflow { get; set; }
		 

		/// <summary>
		/// When either the `borderWidth` or the `backgroundColor` is set,this is the padding within the box.
		/// </summary>
		public double? Padding { get; set; }
		 

		/// <summary>
		/// Aligns data labels relative to points. If `center` alignment isnot possible, it defaults to `right`.
		/// </summary>
		public PlotOptionsFunnelDataLabelsPosition Position { get; set; }
		 

		/// <summary>
		/// Text rotation in degrees. Note that due to a more complexstructure, backgrounds, borders and padding will be lost on arotated data label.
		/// </summary>
		public double? Rotation { get; set; }
		 

		/// <summary>
		/// The shadow of the box. Works best with `borderWidth` or`backgroundColor`. Since 2.3 the shadow can be an objectconfiguration containing `color`, `offsetX`, `offsetY`, `opacity`and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		 

		/// <summary>
		/// The shadow of the box. Works best with `borderWidth` or`backgroundColor`. Since 2.3 the shadow can be an objectconfiguration containing `color`, `offsetX`, `offsetY`, `opacity`and `width`.
		/// </summary>
		public bool? ShadowBool { get; set; }
		 

		/// <summary>
		/// The name of a symbol to use for the border around the label.Symbols are predefined functions on the Renderer object.
		/// </summary>
		public string Shape { get; set; }
		 

		/// <summary>
		/// Whether to render the connector as a soft arc or a line with a sharpbreak. Works only if `connectorShape` equals to `fixedOffset`.
		/// </summary>
		public bool? SoftConnector { get; set; }
		 

		/// <summary>
		/// Styles for the label. The default `color` setting is`"contrast"`, which is a pseudo color that Highcharts picks upand applies the maximum contrast to the underlying point item,for example the bar in a bar chart.The `textOutline` is a pseudo property that applies an outline ofthe given width with the given color, which by default is themaximum contrast to the text. So a bright text color will resultin a black text outline for maximum readability on a mixedbackground. In some cases, especially with grayscale text, thetext outline doesn't work well, in which cases it can be disabledby setting it to `"none"`. When `useHTML` is true, the`textOutline` will not be picked up. In this, case, the sameeffect can be acheived through the `text-shadow` CSS property.For some series types, where each point has an extent, like forexample tree maps, the data label may overflow the point. Thereare two strategies for handling overflow. By default, the textwill wrap to multiple lines. The other strategy is to set`style.textOverflow` to `ellipsis`, which will keep the text onone line plus it will break inside long words.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// Options for a label text which should follow marker's shape.Border and background are disabled for a label that follows apath.**Note:** Only SVG-based renderer supports this option. Setting`useHTML` to true will disable this option.
		/// </summary>
		public PlotOptionsFunnelDataLabelsTextPath TextPath { get; set; }
		 

		/// <summary>
		/// Whether to[use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsFunnelDataLabelsVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the point inpixels.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the point inpixels.
		/// </summary>
		public double? Y { get; set; }
		 

		/// <summary>
		/// The z index of the data labels. Use a `zIndex` of 6 to display it abovethe series, or use a `zIndex` of 2 to display it behind the series.
		/// </summary>
		public double? ZIndex { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Align != PlotOptionsFunnelDataLabelsAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (AlignTo != null) h.Add("alignTo",AlignTo);
			if (AllowOverlap != null) h.Add("allowOverlap",AllowOverlap);
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (ClassName != null) h.Add("className",ClassName);
			if (Color != null) h.Add("color",Color);
			if (ConnectorColor != null) h.Add("connectorColor",ConnectorColor);
			if (ConnectorPadding != null) h.Add("connectorPadding",ConnectorPadding);
			if (ConnectorShape != null) h.Add("connectorShape",ConnectorShape);
			if (ConnectorWidth != null) h.Add("connectorWidth",ConnectorWidth);
			if (CrookDistance != null) h.Add("crookDistance",CrookDistance);
			if (Crop != null) h.Add("crop",Crop);
			if (Defer != null) h.Add("defer",Defer);
			if (Distance != null) h.Add("distance",Distance);
			if (DistanceNumber != null) h.Add("distance",DistanceNumber);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Filter != null) h.Add("filter",Filter.ToHashtable(highcharts));
			if (Format != null) h.Add("format",Format);
			if (Formatter != null) { h.Add("formatter",Formatter); highcharts.AddFunction("formatter", Formatter); }  
			if (Inside != null) h.Add("inside",Inside);
			if (NullFormat != null) h.Add("nullFormat",NullFormat);
			if (NullFormatBool != null) h.Add("nullFormat",NullFormatBool);
			if (NullFormatter != null) { h.Add("nullFormatter",NullFormatter); highcharts.AddFunction("nullFormatter", NullFormatter); }  
			if (Overflow != PlotOptionsFunnelDataLabelsOverflow.Null) h.Add("overflow", highcharts.FirstCharacterToLower(Overflow.ToString()));
			if (Padding != null) h.Add("padding",Padding);
			if (Position != PlotOptionsFunnelDataLabelsPosition.Null) h.Add("position", highcharts.FirstCharacterToLower(Position.ToString()));
			if (Rotation != null) h.Add("rotation",Rotation);
			if (Shadow != null) h.Add("shadow",Shadow.ToHashtable(highcharts));
			if (ShadowBool != null) h.Add("shadow",ShadowBool);
			if (Shape != null) h.Add("shape",Shape);
			if (SoftConnector != null) h.Add("softConnector",SoftConnector);
			if (Style != null) h.Add("style",Style);
			if (TextPath != null) h.Add("textPath",TextPath.ToHashtable(highcharts));
			if (UseHTML != null) h.Add("useHTML",UseHTML);
			if (VerticalAlign != PlotOptionsFunnelDataLabelsVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}