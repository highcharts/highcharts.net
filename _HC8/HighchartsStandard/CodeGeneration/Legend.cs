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
			Accessibility = Accessibility_DefaultValue = new LegendAccessibility();
			Align = Align_DefaultValue = LegendAlign.Center;
			AlignColumns = AlignColumns_DefaultValue = true;
			BackgroundColor = BackgroundColor_DefaultValue = "";
			BorderColor = BorderColor_DefaultValue = "#999999";
			BorderRadius = BorderRadius_DefaultValue = 0;
			BorderWidth = BorderWidth_DefaultValue = 0;
			BubbleLegend = BubbleLegend_DefaultValue = new LegendBubbleLegend();
			ClassName = ClassName_DefaultValue = "highcharts-no-tooltip";
			Enabled = Enabled_DefaultValue = null;
			Floating = Floating_DefaultValue = false;
			ItemCheckboxStyle = ItemCheckboxStyle_DefaultValue = new Hashtable();
			ItemDistance = ItemDistance_DefaultValue = null;
			ItemHiddenStyle = ItemHiddenStyle_DefaultValue = new Hashtable();
			ItemHoverStyle = ItemHoverStyle_DefaultValue = new Hashtable();
			ItemMarginBottom = ItemMarginBottom_DefaultValue = 0;
			ItemMarginTop = ItemMarginTop_DefaultValue = 0;
			ItemStyle = ItemStyle_DefaultValue = new Hashtable();
			ItemWidth = ItemWidth_DefaultValue = null;
			LabelFormat = LabelFormat_DefaultValue = "{name}";
			LabelFormatter = LabelFormatter_DefaultValue = null;
			Layout = Layout_DefaultValue = LegendLayout.Horizontal;
			LineHeight = LineHeight_DefaultValue = 16;
			Margin = Margin_DefaultValue = null;
			MaxHeight = MaxHeight_DefaultValue = null;
			Navigation = Navigation_DefaultValue = new LegendNavigation();
			Padding = Padding_DefaultValue = 8;
			Reversed = Reversed_DefaultValue = false;
			Rtl = Rtl_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow();
			SquareSymbol = SquareSymbol_DefaultValue = true;
			Style = Style_DefaultValue = new Hashtable();
			SymbolHeight = SymbolHeight_DefaultValue = null;
			SymbolPadding = SymbolPadding_DefaultValue = 5;
			SymbolRadius = SymbolRadius_DefaultValue = null;
			SymbolWidth = SymbolWidth_DefaultValue = null;
			Title = Title_DefaultValue = new LegendTitle();
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = LegendVerticalAlign.Bottom;
			Width = Width_DefaultValue = "";
			WidthNumber = WidthNumber_DefaultValue = null;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 0;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Accessibility options for the legend. Requires the Accessibilitymodule.
		/// </summary>
		public LegendAccessibility Accessibility { get; set; }
		private LegendAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// The horizontal alignment of the legend box within the chart area.Valid values are `left`, `center` and `right`.In the case that the legend is aligned in a corner position, the`layout` option will determine whether to place it above/belowor on the side of the plot area.
		/// </summary>
		public LegendAlign Align { get; set; }
		private LegendAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// If the [layout](legend.layout) is `horizontal` and the legend itemsspan over two lines or more, whether to align the items into verticalcolumns. Setting this to `false` makes room for more items, but willlook more messy.
		/// </summary>
		public bool? AlignColumns { get; set; }
		private bool? AlignColumns_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color of the legend.
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the drawn border around the legend.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border corner radius of the legend.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the drawn border around the legend.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The bubble legend is an additional element in legend whichpresents the scale of the bubble series. Individual bubble rangescan be defined by user or calculated from series. In the case ofautomatically calculated ranges, a 1px margin of error ispermitted.
		/// </summary>
		public LegendBubbleLegend BubbleLegend { get; set; }
		private LegendBubbleLegend BubbleLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// A CSS class name to apply to the legend group.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the legend. There is also a series-specific option,[showInLegend](#plotOptions.series.showInLegend), that can hide theseries from the legend. In some series types this is `false` bydefault, so it must set to `true` in order to show the legend for theseries.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the legend is floating, the plot area ignores it and is allowedto be placed below it.
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// Default styling for the checkbox next to a legend item when`showCheckbox` is true.
		/// </summary>
		public Hashtable ItemCheckboxStyle { get; set; }
		private Hashtable ItemCheckboxStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a legend with horizontal layout, the itemDistance defines thepixel distance between each item.
		/// </summary>
		public double? ItemDistance { get; set; }
		private double? ItemDistance_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for each legend item when the corresponding series orpoint is hidden. Only a subset of CSS is supported, notably thoseoptions related to text. Properties are inherited from `style`unless overridden here.
		/// </summary>
		public Hashtable ItemHiddenStyle { get; set; }
		private Hashtable ItemHiddenStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for each legend item in hover mode. Only a subset ofCSS is supported, notably those options related to text. Propertiesare inherited from `style` unless overridden here.
		/// </summary>
		public Hashtable ItemHoverStyle { get; set; }
		private Hashtable ItemHoverStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel bottom margin for each legend item.
		/// </summary>
		public double? ItemMarginBottom { get; set; }
		private double? ItemMarginBottom_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel top margin for each legend item.
		/// </summary>
		public double? ItemMarginTop { get; set; }
		private double? ItemMarginTop_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for each legend item. Only a subset of CSS is supported,notably those options related to text. The default `textOverflow`property makes long texts truncate. Set it to `undefined` to wraptext instead. A `width` property can be added to control the textwidth.
		/// </summary>
		public Hashtable ItemStyle { get; set; }
		private Hashtable ItemStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width for each legend item. By default the items are laid outsuccessively. In a [horizontal layout](legend.layout), if the itemsare laid out across two rows or more, they will be vertically aligneddepending on the [legend.alignColumns](legend.alignColumns) option.
		/// </summary>
		public double? ItemWidth { get; set; }
		private double? ItemWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A [format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)for each legend label. Available variables relates to properties onthe series, or the point in case of pies.
		/// </summary>
		public string LabelFormat { get; set; }
		private string LabelFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback function to format each of the series' labels. The `this`keyword refers to the series object, or the point object in case ofpie charts. By default the series or point name is printed.
		/// </summary>
		public bool? LabelFormatter { get; set; }
		private bool? LabelFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// The layout of the legend items. Can be one of `horizontal` or`vertical` or `proximate`. When `proximate`, the legend items will beplaced as close as possible to the graphs they're representing,except in inverted charts or when the legend position doesn't allowit.
		/// </summary>
		public LegendLayout Layout { get; set; }
		private LegendLayout Layout_DefaultValue { get; set; }
		 

		/// <summary>
		/// Line height for the legend items. Deprecated as of 2.1\. Instead,the line height for each item can be set using`itemStyle.lineHeight`, and the padding between items using`itemMarginTop` and `itemMarginBottom`.
		/// </summary>
		public double? LineHeight { get; set; }
		private double? LineHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// If the plot area sized is calculated automatically and the legend isnot floating, the legend margin is the space between the legend andthe axis labels or plot area.
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// Maximum pixel height for the legend. When the maximum height isextended, navigation will show.
		/// </summary>
		public double? MaxHeight { get; set; }
		private double? MaxHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the paging or navigation appearing when the legend isoverflown. Navigation works well on screen, but not in staticexported images. One way of working around that is to[increase the chart height inexport](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/legend/navigation-enabled-false/).
		/// </summary>
		public LegendNavigation Navigation { get; set; }
		private LegendNavigation Navigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner padding of the legend box.
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reverse the order of the legend items compared to theorder of the series or points as defined in the configuration object.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to show the symbol on the right side of the text rather thanthe left side. This is common in Arabic and Hebrew.
		/// </summary>
		public bool? Rtl { get; set; }
		private bool? Rtl_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the legend. A `backgroundColor`also needs to be applied for this to take effect. The shadow can bean object configuration containing `color`, `offsetX`, `offsetY`,`opacity` and `width`.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this is true, the legend symbol width will be the same asthe symbol height, which in turn defaults to the font size of thelegend items.
		/// </summary>
		public bool? SquareSymbol { get; set; }
		private bool? SquareSymbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the legend area. In the 1.x versions the positionof the legend area was determined by CSS. In 2.x, the position isdetermined by properties like `align`, `verticalAlign`, `x` and `y`,but the styles are still parsed for backwards compatibility.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel height of the symbol for series types that use a rectanglein the legend. Defaults to the font size of legend items.
		/// </summary>
		public double? SymbolHeight { get; set; }
		private double? SymbolHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel padding between the legend item symbol and the legenditem text.
		/// </summary>
		public double? SymbolPadding { get; set; }
		private double? SymbolPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border radius of the symbol for series types that use a rectanglein the legend. Defaults to half the `symbolHeight`.
		/// </summary>
		public double? SymbolRadius { get; set; }
		private double? SymbolRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the legend item symbol. When the `squareSymbol`option is set, this defaults to the `symbolHeight`, otherwise 16.
		/// </summary>
		public double? SymbolWidth { get; set; }
		private double? SymbolWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A title to be added on top of the legend.
		/// </summary>
		public LegendTitle Title { get; set; }
		private LegendTitle Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the legend item texts.Prior to 4.1.7, when using HTML, [legend.navigation](#legend.navigation) was disabled.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the legend box. Can be one of `top`,`middle` or `bottom`. Vertical position can be further determinedby the `y` option.In the case that the legend is aligned in a corner position, the`layout` option will determine whether to place it above/belowor on the side of the plot area.When the [layout](#legend.layout) option is `proximate`, the`verticalAlign` option doesn't apply.
		/// </summary>
		public LegendVerticalAlign VerticalAlign { get; set; }
		private LegendVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the legend box. If a number is set, it translates topixels. Since v7.0.2 it allows setting a percent string of the fullchart width, for example `40%`.Defaults to the full chart width for legends below or above thechart, half the chart width for legends to the left and right.
		/// </summary>
		public string Width { get; set; }
		private string Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the legend box. If a number is set, it translates topixels. Since v7.0.2 it allows setting a percent string of the fullchart width, for example `40%`.Defaults to the full chart width for legends below or above thechart, half the chart width for legends to the left and right.
		/// </summary>
		public double? WidthNumber { get; set; }
		private double? WidthNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x offset of the legend relative to its horizontal alignment`align` within chart.spacingLeft and chart.spacingRight. Negativex moves it to the left, positive x moves it to the right.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical offset of the legend relative to it's vertical alignment`verticalAlign` within chart.spacingTop and chart.spacingBottom. Negative y moves it up, positive y moves it down.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Accessibility.IsDirty(ref highcharts)) h.Add("accessibility",Accessibility.ToHashtable(ref highcharts));
			if (Align != Align_DefaultValue) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (AlignColumns != AlignColumns_DefaultValue) h.Add("alignColumns",AlignColumns);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BubbleLegend.IsDirty(ref highcharts)) h.Add("bubbleLegend",BubbleLegend.ToHashtable(ref highcharts));
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Floating != Floating_DefaultValue) h.Add("floating",Floating);
			if (ItemCheckboxStyle != ItemCheckboxStyle_DefaultValue) h.Add("itemCheckboxStyle",ItemCheckboxStyle);
			if (ItemDistance != ItemDistance_DefaultValue) h.Add("itemDistance",ItemDistance);
			if (ItemHiddenStyle != ItemHiddenStyle_DefaultValue) h.Add("itemHiddenStyle",ItemHiddenStyle);
			if (ItemHoverStyle != ItemHoverStyle_DefaultValue) h.Add("itemHoverStyle",ItemHoverStyle);
			if (ItemMarginBottom != ItemMarginBottom_DefaultValue) h.Add("itemMarginBottom",ItemMarginBottom);
			if (ItemMarginTop != ItemMarginTop_DefaultValue) h.Add("itemMarginTop",ItemMarginTop);
			if (ItemStyle != ItemStyle_DefaultValue) h.Add("itemStyle",ItemStyle);
			if (ItemWidth != ItemWidth_DefaultValue) h.Add("itemWidth",ItemWidth);
			if (LabelFormat != LabelFormat_DefaultValue) h.Add("labelFormat",LabelFormat);
			if (LabelFormatter != LabelFormatter_DefaultValue) h.Add("labelFormatter",LabelFormatter);
			if (Layout != Layout_DefaultValue) h.Add("layout", highcharts.FirstCharacterToLower(Layout.ToString()));
			if (LineHeight != LineHeight_DefaultValue) h.Add("lineHeight",LineHeight);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (MaxHeight != MaxHeight_DefaultValue) h.Add("maxHeight",MaxHeight);
			if (Navigation.IsDirty(ref highcharts)) h.Add("navigation",Navigation.ToHashtable(ref highcharts));
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (Rtl != Rtl_DefaultValue) h.Add("rtl",Rtl);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (SquareSymbol != SquareSymbol_DefaultValue) h.Add("squareSymbol",SquareSymbol);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (SymbolHeight != SymbolHeight_DefaultValue) h.Add("symbolHeight",SymbolHeight);
			if (SymbolPadding != SymbolPadding_DefaultValue) h.Add("symbolPadding",SymbolPadding);
			if (SymbolRadius != SymbolRadius_DefaultValue) h.Add("symbolRadius",SymbolRadius);
			if (SymbolWidth != SymbolWidth_DefaultValue) h.Add("symbolWidth",SymbolWidth);
			if (Title.IsDirty(ref highcharts)) h.Add("title",Title.ToHashtable(ref highcharts));
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (WidthNumber != WidthNumber_DefaultValue) h.Add("width",WidthNumber);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}