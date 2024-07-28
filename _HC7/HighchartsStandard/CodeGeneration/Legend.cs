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
	public partial class Legend  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Legend()
		{
		}	
		

		/// <summary>
		/// Accessibility options for the legend. Requires the Accessibilitymodule.
		/// </summary>
		public LegendAccessibility Accessibility { get; set; }
		 

		/// <summary>
		/// The horizontal alignment of the legend box within the chart area.Valid values are `left`, `center` and `right`.In the case that the legend is aligned in a corner position, the`layout` option will determine whether to place it above/belowor on the side of the plot area.
		/// </summary>
		public LegendAlign Align { get; set; }
		 

		/// <summary>
		/// If the [layout](legend.layout) is `horizontal` and the legend itemsspan over two lines or more, whether to align the items into verticalcolumns. Setting this to `false` makes room for more items, but willlook more messy.
		/// </summary>
		public bool? AlignColumns { get; set; }
		 

		/// <summary>
		/// The background color of the legend.
		/// </summary>
		public string BackgroundColor { get; set; }
		 

		/// <summary>
		/// The color of the drawn border around the legend.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The border corner radius of the legend.
		/// </summary>
		public double? BorderRadius { get; set; }
		 

		/// <summary>
		/// The width of the drawn border around the legend.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// The bubble legend is an additional element in legend whichpresents the scale of the bubble series. Individual bubble rangescan be defined by user or calculated from series. In the case ofautomatically calculated ranges, a 1px margin of error ispermitted.
		/// </summary>
		public LegendBubbleLegend BubbleLegend { get; set; }
		 

		/// <summary>
		/// A CSS class name to apply to the legend group.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// Enable or disable the legend. There is also a series-specific option,[showInLegend](#plotOptions.series.showInLegend), that can hide theseries from the legend. In some series types this is `false` bydefault, so it must set to `true` in order to show the legend for theseries.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// General event handlers for the legend. These event hooks canalso be attached to the legend at run time using the`Highcharts.addEvent` function.
		/// </summary>
		public LegendEvents Events { get; set; }
		 

		/// <summary>
		/// When the legend is floating, the plot area ignores it and is allowedto be placed below it.
		/// </summary>
		public bool? Floating { get; set; }
		 

		/// <summary>
		/// Default styling for the checkbox next to a legend item when`showCheckbox` is true.
		/// </summary>
		public Hashtable ItemCheckboxStyle { get; set; }
		 

		/// <summary>
		/// In a legend with horizontal layout, the itemDistance defines thepixel distance between each item.
		/// </summary>
		public double? ItemDistance { get; set; }
		 

		/// <summary>
		/// CSS styles for each legend item when the corresponding series orpoint is hidden. Only a subset of CSS is supported, notably thoseoptions related to text. Properties are inherited from `style`unless overridden here.
		/// </summary>
		public Hashtable ItemHiddenStyle { get; set; }
		 

		/// <summary>
		/// CSS styles for each legend item in hover mode. Only a subset ofCSS is supported, notably those options related to text. Propertiesare inherited from `style` unless overridden here.
		/// </summary>
		public Hashtable ItemHoverStyle { get; set; }
		 

		/// <summary>
		/// The pixel bottom margin for each legend item.
		/// </summary>
		public double? ItemMarginBottom { get; set; }
		 

		/// <summary>
		/// The pixel top margin for each legend item.
		/// </summary>
		public double? ItemMarginTop { get; set; }
		 

		/// <summary>
		/// CSS styles for each legend item. Only a subset of CSS is supported,notably those options related to text. The default `textOverflow`property makes long texts truncate. Set it to `undefined` to wraptext instead. A `width` property can be added to control the textwidth.
		/// </summary>
		public Hashtable ItemStyle { get; set; }
		 

		/// <summary>
		/// The width for each legend item. By default the items are laid outsuccessively. In a [horizontal layout](legend.layout), if the itemsare laid out across two rows or more, they will be vertically aligneddepending on the [legend.alignColumns](legend.alignColumns) option.
		/// </summary>
		public double? ItemWidth { get; set; }
		 

		/// <summary>
		/// A [format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)for each legend label. Available variables relates to properties onthe series, or the point in case of pies.
		/// </summary>
		public string LabelFormat { get; set; }
		 

		/// <summary>
		/// Callback function to format each of the series' labels. The `this`keyword refers to the series object, or the point object in case ofpie charts. By default the series or point name is printed.
		/// </summary>
		public bool? LabelFormatter { get; set; }
		 

		/// <summary>
		/// The layout of the legend items. Can be one of `horizontal` or`vertical` or `proximate`. When `proximate`, the legend items will beplaced as close as possible to the graphs they're representing,except in inverted charts or when the legend position doesn't allowit.
		/// </summary>
		public LegendLayout Layout { get; set; }
		 

		/// <summary>
		/// Line height for the legend items. Deprecated as of 2.1\. Instead,the line height for each item can be set using`itemStyle.lineHeight`, and the padding between items using`itemMarginTop` and `itemMarginBottom`.
		/// </summary>
		public double? LineHeight { get; set; }
		 

		/// <summary>
		/// If the plot area sized is calculated automatically and the legend isnot floating, the legend margin is the space between the legend andthe axis labels or plot area.
		/// </summary>
		public double? Margin { get; set; }
		 

		/// <summary>
		/// Maximum pixel height for the legend. When the maximum height isextended, navigation will show.
		/// </summary>
		public double? MaxHeight { get; set; }
		 

		/// <summary>
		/// Options for the paging or navigation appearing when the legend isoverflown. Navigation works well on screen, but not in staticexported images. One way of working around that is to[increase the chart height inexport](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/legend/navigation-enabled-false/).
		/// </summary>
		public LegendNavigation Navigation { get; set; }
		 

		/// <summary>
		/// The inner padding of the legend box.
		/// </summary>
		public double? Padding { get; set; }
		 

		/// <summary>
		/// Whether to reverse the order of the legend items compared to theorder of the series or points as defined in the configuration object.
		/// </summary>
		public bool? Reversed { get; set; }
		 

		/// <summary>
		/// Whether to show the symbol on the right side of the text rather thanthe left side. This is common in Arabic and Hebrew.
		/// </summary>
		public bool? Rtl { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the legend. A `backgroundColor`also needs to be applied for this to take effect. The shadow can bean object configuration containing `color`, `offsetX`, `offsetY`,`opacity` and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		 

		/// <summary>
		/// When this is true, the legend symbol width will be the same asthe symbol height, which in turn defaults to the font size of thelegend items.
		/// </summary>
		public bool? SquareSymbol { get; set; }
		 

		/// <summary>
		/// CSS styles for the legend area. In the 1.x versions the positionof the legend area was determined by CSS. In 2.x, the position isdetermined by properties like `align`, `verticalAlign`, `x` and `y`,but the styles are still parsed for backwards compatibility.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// The pixel height of the symbol for series types that use a rectanglein the legend. Defaults to the font size of legend items.Note: This option is a default source of color axis height, if the[colorAxis.height](https://api.highcharts.com/highcharts/colorAxis.height)option is not set.
		/// </summary>
		public double? SymbolHeight { get; set; }
		 

		/// <summary>
		/// The pixel padding between the legend item symbol and the legenditem text.
		/// </summary>
		public double? SymbolPadding { get; set; }
		 

		/// <summary>
		/// The border radius of the symbol for series types that use a rectanglein the legend. Defaults to half the `symbolHeight`, effectivelycreating a circle.For color axis scales, it defaults to 3.
		/// </summary>
		public double? SymbolRadius { get; set; }
		 

		/// <summary>
		/// The pixel width of the legend item symbol. When the `squareSymbol`option is set, this defaults to the `symbolHeight`, otherwise 16.Note: This option is a default source of color axis width, if the[colorAxis.width](https://api.highcharts.com/highcharts/colorAxis.width)option is not set.
		/// </summary>
		public double? SymbolWidth { get; set; }
		 

		/// <summary>
		/// A title to be added on top of the legend.
		/// </summary>
		public LegendTitle Title { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the legend item texts.Prior to 4.1.7, when using HTML, [legend.navigation](#legend.navigation) was disabled.
		/// </summary>
		public bool? UseHTML { get; set; }
		 

		/// <summary>
		/// For a color axis with data classes, how many decimals to render inthe legend. The default preserves the decimals of the range numbers.
		/// </summary>
		public double? ValueDecimals { get; set; }
		 

		/// <summary>
		/// For a color axis with data classes, a suffix for the range numbers inthe legend.
		/// </summary>
		public string ValueSuffix { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the legend box. Can be one of `top`,`middle` or `bottom`. Vertical position can be further determinedby the `y` option.In the case that the legend is aligned in a corner position, the`layout` option will determine whether to place it above/belowor on the side of the plot area.When the [layout](#legend.layout) option is `proximate`, the`verticalAlign` option doesn't apply.
		/// </summary>
		public LegendVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// The width of the legend box. If a number is set, it translates topixels. Since v7.0.2 it allows setting a percent string of the fullchart width, for example `40%`.Defaults to the full chart width for legends below or above thechart, half the chart width for legends to the left and right.
		/// </summary>
		public string Width { get; set; }
		 

		/// <summary>
		/// The width of the legend box. If a number is set, it translates topixels. Since v7.0.2 it allows setting a percent string of the fullchart width, for example `40%`.Defaults to the full chart width for legends below or above thechart, half the chart width for legends to the left and right.
		/// </summary>
		public double? WidthNumber { get; set; }
		 

		/// <summary>
		/// The x offset of the legend relative to its horizontal alignment`align` within chart.spacingLeft and chart.spacingRight. Negativex moves it to the left, positive x moves it to the right.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The vertical offset of the legend relative to it's vertical alignment`verticalAlign` within chart.spacingTop and chart.spacingBottom. Negative y moves it up, positive y moves it down.
		/// </summary>
		public double? Y { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (Align != LegendAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (AlignColumns != null) h.Add("alignColumns",AlignColumns);
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (BubbleLegend != null) h.Add("bubbleLegend",BubbleLegend.ToHashtable(highcharts));
			if (ClassName != null) h.Add("className",ClassName);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
			if (Floating != null) h.Add("floating",Floating);
			if (ItemCheckboxStyle != null) h.Add("itemCheckboxStyle",ItemCheckboxStyle);
			if (ItemDistance != null) h.Add("itemDistance",ItemDistance);
			if (ItemHiddenStyle != null) h.Add("itemHiddenStyle",ItemHiddenStyle);
			if (ItemHoverStyle != null) h.Add("itemHoverStyle",ItemHoverStyle);
			if (ItemMarginBottom != null) h.Add("itemMarginBottom",ItemMarginBottom);
			if (ItemMarginTop != null) h.Add("itemMarginTop",ItemMarginTop);
			if (ItemStyle != null) h.Add("itemStyle",ItemStyle);
			if (ItemWidth != null) h.Add("itemWidth",ItemWidth);
			if (LabelFormat != null) h.Add("labelFormat",LabelFormat);
			if (LabelFormatter != null) h.Add("labelFormatter",LabelFormatter);
			if (Layout != LegendLayout.Null) h.Add("layout", highcharts.FirstCharacterToLower(Layout.ToString()));
			if (LineHeight != null) h.Add("lineHeight",LineHeight);
			if (Margin != null) h.Add("margin",Margin);
			if (MaxHeight != null) h.Add("maxHeight",MaxHeight);
			if (Navigation != null) h.Add("navigation",Navigation.ToHashtable(highcharts));
			if (Padding != null) h.Add("padding",Padding);
			if (Reversed != null) h.Add("reversed",Reversed);
			if (Rtl != null) h.Add("rtl",Rtl);
			if (Shadow != null) h.Add("shadow",Shadow);
			if (SquareSymbol != null) h.Add("squareSymbol",SquareSymbol);
			if (Style != null) h.Add("style",Style);
			if (SymbolHeight != null) h.Add("symbolHeight",SymbolHeight);
			if (SymbolPadding != null) h.Add("symbolPadding",SymbolPadding);
			if (SymbolRadius != null) h.Add("symbolRadius",SymbolRadius);
			if (SymbolWidth != null) h.Add("symbolWidth",SymbolWidth);
			if (Title != null) h.Add("title",Title.ToHashtable(highcharts));
			if (UseHTML != null) h.Add("useHTML",UseHTML);
			if (ValueDecimals != null) h.Add("valueDecimals",ValueDecimals);
			if (ValueSuffix != null) h.Add("valueSuffix",ValueSuffix);
			if (VerticalAlign != LegendVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (Width != null) h.Add("width",Width);
			if (WidthNumber != null) h.Add("width",WidthNumber);
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
			if (CustomFields != null && CustomFields.Count > 0)
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