using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class Legend
	{
		public Legend()
		{
			Align = Align_DefaultValue = LegendAlign.Center;
			BackgroundColor = BackgroundColor_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = "#909090";
			BorderRadius = BorderRadius_DefaultValue = 0;
			BorderWidth = BorderWidth_DefaultValue = 0;
			Enabled = Enabled_DefaultValue = true;
			Floating = Floating_DefaultValue = false;
			ItemDistance = ItemDistance_DefaultValue = 20;
			ItemHiddenStyle = ItemHiddenStyle_DefaultValue = null;
			ItemHoverStyle = ItemHoverStyle_DefaultValue = null;
			ItemMarginBottom = ItemMarginBottom_DefaultValue = 0;
			ItemMarginTop = ItemMarginTop_DefaultValue = 0;
			ItemStyle = ItemStyle_DefaultValue = new NameValueCollection{{ "color", "#333333"},{ "cursor", "pointer"},{ "fontSize", "12px"},{ "fontWeight", "bold" }};
			ItemWidth = ItemWidth_DefaultValue = null;
			LabelFormat = LabelFormat_DefaultValue = "{name}";
			LabelFormatter = LabelFormatter_DefaultValue = "";
			Layout = Layout_DefaultValue = LegendLayout.Horizontal;
			LineHeight = LineHeight_DefaultValue = 16;
			Margin = Margin_DefaultValue = 15;
			MaxHeight = MaxHeight_DefaultValue = null;
			Navigation = Navigation_DefaultValue = new LegendNavigation();
			Padding = Padding_DefaultValue = 8;
			Reversed = Reversed_DefaultValue = false;
			Rtl = Rtl_DefaultValue = false;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Style = Style_DefaultValue = null;
			SymbolHeight = SymbolHeight_DefaultValue = 12;
			SymbolPadding = SymbolPadding_DefaultValue = 5;
			SymbolRadius = SymbolRadius_DefaultValue = 2;
			SymbolWidth = SymbolWidth_DefaultValue = 16;
			Title = Title_DefaultValue = new LegendTitle();
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = LegendVerticalAlign.Bottom;
			Width = Width_DefaultValue = null;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// The horizontal alignment of the legend box within the chart area. Valid values are <code>"left"</code>, <code>"center"</code> and <code>"right"</code>.
		/// </summary>
		public LegendAlign Align { get; set; }
		private LegendAlign Align_DefaultValue { get; set; }
		 

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
		/// Enable or disable the legend.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the legend is floating, the plot area ignores it and is allowed to be placed below it.
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a legend with horizontal layout, the itemDistance defines the pixel distance between each item. 
		/// </summary>
		public double? ItemDistance { get; set; }
		private double? ItemDistance_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for each legend item when the corresponding series or point is hidden. Only a subset of CSS is supported, notably those options related to text. Properties are inherited from <code>style</code> unless overridden here. Defaults to:<pre>itemHiddenStyle: {color: '#CCC'}</pre>
		/// </summary>
		public NameValueCollection ItemHiddenStyle { get; set; }
		private NameValueCollection ItemHiddenStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for each legend item in hover mode. Only a subset of CSS is supported, notably those options related to text. Properties are inherited from <code>style</code> unless overridden here. Defaults to:<pre>itemHoverStyle: {color: '#000'}</pre>
		/// </summary>
		public NameValueCollection ItemHoverStyle { get; set; }
		private NameValueCollection ItemHoverStyle_DefaultValue { get; set; }
		 

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
		/// CSS styles for each legend item. Only a subset of CSS is supported, notably those options related to text.
		/// </summary>
		public NameValueCollection ItemStyle { get; set; }
		private NameValueCollection ItemStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width for each legend item. This is useful in a horizontal layout with many items when you want the items to align vertically.  .
		/// </summary>
		public double? ItemWidth { get; set; }
		private double? ItemWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting">format string</a> for each legend label. Available variables relates to properties on the series, or the point in case of pies.
		/// </summary>
		public string LabelFormat { get; set; }
		private string LabelFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback function to format each of the series' labels. The <em>this</em> keyword refers to the series object, or the point object in case of pie charts. By default the series or point name is printed.
		/// </summary>
		public string LabelFormatter { get; set; }
		private string LabelFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// The layout of the legend items. Can be one of "horizontal" or "vertical".
		/// </summary>
		public LegendLayout Layout { get; set; }
		private LegendLayout Layout_DefaultValue { get; set; }
		 

		/// <summary>
		/// Line height for the legend items. Deprecated as of 2.1. Instead, the line height for each  item can be set using itemStyle.lineHeight, and the padding between items using itemMarginTop and itemMarginBottom.
		/// </summary>
		public double? LineHeight { get; set; }
		private double? LineHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// If the plot area sized is calculated automatically and the legend is not floating, the legend margin is the  space between the legend and the axis labels or plot area.
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// Maximum pixel height for the legend. When the maximum height is extended, navigation will show.
		/// </summary>
		public double? MaxHeight { get; set; }
		private double? MaxHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the paging or navigation appearing when the legend is overflown. When <a href="#legend.useHTML">legend.useHTML</a> is enabled, navigation is disabled. 
		/// </summary>
		public LegendNavigation Navigation { get; set; }
		private LegendNavigation Navigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner padding of the legend box.
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reverse the order of the legend items compared to the order of the series or points as defined in the configuration object.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to show the symbol on the right side of the text rather than the left side.  This is common in Arabic and Hebraic.
		/// </summary>
		public bool? Rtl { get; set; }
		private bool? Rtl_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to apply a drop shadow to the legend. A <code>backgroundColor</code> also needs to be applied for this to take effect. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the legend area. In the 1.x versions the position of the legend area was determined by CSS. In 2.x, the position is determined by properties like  <code>align</code>, <code>verticalAlign</code>, <code>x</code> and <code>y</code>, but the styles are still parsed for backwards compatibility.
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel height of the symbol for series types that use a rectangle in the legend.
		/// </summary>
		public double? SymbolHeight { get; set; }
		private double? SymbolHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel padding between the legend item symbol and the legend item text.
		/// </summary>
		public double? SymbolPadding { get; set; }
		private double? SymbolPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border radius of the symbol for series types that use a rectangle in the legend.
		/// </summary>
		public double? SymbolRadius { get; set; }
		private double? SymbolRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the legend item symbol.
		/// </summary>
		public double? SymbolWidth { get; set; }
		private double? SymbolWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A title to be added on top of the legend.
		/// </summary>
		public LegendTitle Title { get; set; }
		private LegendTitle Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a> to render the legend item texts. When using HTML, <a href="#legend.navigation">legend.navigation</a> is disabled.</p>
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the legend box. Can be one of "top", "middle" or  "bottom". Vertical position can be further determined by the <code>y</code> option.
		/// </summary>
		public LegendVerticalAlign VerticalAlign { get; set; }
		private LegendVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the legend box.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x offset of the legend relative to its horizontal alignment <code>align</code> within chart.spacingLeft and chart.spacingRight. Negative x moves it to the left, positive x moves it to the right. 
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical offset of the legend relative to it's vertical alignment <code>verticalAlign</code> within chart.spacingTop and chart.spacingBottom. Negative y moves it up, positive y moves it down.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Floating != Floating_DefaultValue) h.Add("floating",Floating);
			if (ItemDistance != ItemDistance_DefaultValue) h.Add("itemDistance",ItemDistance);
			if (ItemHiddenStyle != ItemHiddenStyle_DefaultValue) h.Add("itemHiddenStyle",ItemHiddenStyle);
			if (ItemHoverStyle != ItemHoverStyle_DefaultValue) h.Add("itemHoverStyle",ItemHoverStyle);
			if (ItemMarginBottom != ItemMarginBottom_DefaultValue) h.Add("itemMarginBottom",ItemMarginBottom);
			if (ItemMarginTop != ItemMarginTop_DefaultValue) h.Add("itemMarginTop",ItemMarginTop);
			if (ItemStyle != ItemStyle_DefaultValue) h.Add("itemStyle",ItemStyle);
			if (ItemWidth != ItemWidth_DefaultValue) h.Add("itemWidth",ItemWidth);
			if (LabelFormat != LabelFormat_DefaultValue) h.Add("labelFormat",LabelFormat);
			if (LabelFormatter != LabelFormatter_DefaultValue) { h.Add("labelFormatter",LabelFormatter); Highcharts.AddFunction("labelFormatter", LabelFormatter); }  
			if (Layout != Layout_DefaultValue) h.Add("layout",Layout);
			if (LineHeight != LineHeight_DefaultValue) h.Add("lineHeight",LineHeight);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (MaxHeight != MaxHeight_DefaultValue) h.Add("maxHeight",MaxHeight);
			if (Navigation.IsDirty()) h.Add("navigation",Navigation.ToHashtable());
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (Rtl != Rtl_DefaultValue) h.Add("rtl",Rtl);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (SymbolHeight != SymbolHeight_DefaultValue) h.Add("symbolHeight",SymbolHeight);
			if (SymbolPadding != SymbolPadding_DefaultValue) h.Add("symbolPadding",SymbolPadding);
			if (SymbolRadius != SymbolRadius_DefaultValue) h.Add("symbolRadius",SymbolRadius);
			if (SymbolWidth != SymbolWidth_DefaultValue) h.Add("symbolWidth",SymbolWidth);
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}